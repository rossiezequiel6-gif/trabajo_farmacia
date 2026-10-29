Imports System.Drawing.Printing
Imports System.Reflection.Metadata
Imports MySqlConnector
Imports ScottPlot.Colormaps
Public Class dashboard

    Private filaActual As Integer = 0
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargar los contenedores cuando se abre el form
        cargarkpis()
        'cargar el grafico del stock actual
        cargargraficostock()
        'cargar el dgv con los medicamentos proximos a vencer
        cargartablavencimientos()
        Estilos.EstilizarGrilla(dgvvencimientos)
        'cargar dona de vencimientos
        CargarGraficoVencimientos()
    End Sub

    Private Sub cargarkpis()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'medicamentos con stock igual o menor al punto de pedido
                Dim sqlstockcritico As String = "SELECT COUNT(*) FROM (" &
                                                " SELECT m.id_medicamento " &
                                                " FROM medicamento m " &
                                                "LEFT JOIN lote l ON m.id_medicamento = l.id_medicamento " &
                                                "GROUP by m.id_medicamento, m.punto_pedido " &
                                                "HAVING IFNULL(SUM(l.cantidad_actual), 0) <= m.punto_pedido" &
                                                ") AS subconsulta;"
                Using cmd As New MySqlCommand(sqlstockcritico, cn)
                    lblstockcritico.Text = cmd.ExecuteScalar().ToString()
                End Using

                'lotes que vencen en los proximos 30 días
                Dim sqlvencimientos As String = "SELECT COUNT(*) FROM lote " &
                                                "WHERE fecha_vencimiento BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 30 DAY) " &
                                                "AND cantidad_actual > 0;"
                Using cmd As New MySqlCommand(sqlvencimientos, cn)
                    lblvencimiento.Text = cmd.ExecuteScalar().ToString()
                End Using

                'total de medicamentos registrados
                Dim sqltotal As String = "SELECT COUNT(*) FROM medicamento;"
                Using cmd As New MySqlCommand(sqltotal, cn)
                    lbltotalmedicamentos.Text = cmd.ExecuteScalar().ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar KPIs del Dashboard: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cargargraficostock()
        Try
            ' Listas temporales para guardar los datos cargados desde MySQL
            Dim nombres As New List(Of String)()
            Dim cantStock As New List(Of Double)()
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                ' Obtenemos el nombre del medicamento y la suma actual de sus lotes
                Dim sql As String = "SELECT m.nombre, IFNULL(SUM(l.cantidad_actual), 0) AS stock_total " &
                                    "FROM medicamento m " &
                                    "LEFT JOIN lote l ON m.id_medicamento = l.id_medicamento " &
                                    "GROUP BY m.id_medicamento, m.nombre " &
                                    "ORDER BY stock_total ASC " &
                                    "LIMIT 10;"

                ' Mostramos los 10 medicamentos con menor stock
                Using cmd As New MySqlCommand(sql, cn)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        While rd.Read()
                            nombres.Add(rd("nombre").ToString())
                            cantStock.Add(Convert.ToDouble(rd("stock_total")))
                        End While
                    End Using
                End Using
            End Using

            ' Si no hay medicamentos cargados, salimos sin graficar
            If cantStock.Count = 0 Then Exit Sub

            ' Configuración de ScottPlot
            FormsPlot1.Plot.Clear()

            ' Creamos el gráfico de barras
            Dim barras = FormsPlot1.Plot.Add.Bars(cantStock.ToArray())

            ' Personalizamos el título y los ejes
            FormsPlot1.Plot.Title("Nivel de Stock por Medicamento")
            FormsPlot1.Plot.YLabel("Cantidad en Unidades / Lotes")

            ' Asignamos los nombres de los medicamentos al eje X
            ' Compatible con la API de ScottPlot 5.x
            Dim ticks As New List(Of ScottPlot.Tick)()

            For i As Integer = 0 To nombres.Count - 1
                ticks.Add(New ScottPlot.Tick(i, nombres(i)))
            Next

            FormsPlot1.Plot.Axes.Bottom.TickGenerator =
                New ScottPlot.TickGenerators.NumericManual(ticks.ToArray())

            ' Actualizamos el gráfico
            FormsPlot1.Refresh()

        Catch ex As Exception
            MessageBox.Show(
                "Error al generar gráfico de stock: " & ex.Message,
                "Error ScottPlot",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cargartablavencimientos()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' Consulta: trae los lotes que vencen en los próximos 60 días,
                ' ordenados por la fecha más cercana
                Dim sql As String = "SELECT m.nombre AS 'Medicamento', " &
                                    "l.codigo AS 'N° Lote', " &
                                    "DATE_FORMAT(l.fecha_vencimiento, '%d/%m/%Y') AS 'Fecha Vencimiento', " &
                                    "l.cantidad_actual AS 'Cant. Restante' " &
                                    "FROM lote l " &
                                    "INNER JOIN medicamento m ON l.id_medicamento = m.id_medicamento " &
                                    "WHERE l.fecha_vencimiento BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 60 DAY) " &
                                    "AND l.cantidad_actual > 0 " &
                                    "ORDER BY l.fecha_vencimiento ASC;"

                Using cmd As New MySqlCommand(sql, cn)
                    Dim dt As New DataTable()

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    ' Asignamos los datos al DataGridView
                    dgvvencimientos.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error al cargar la tabla de vencimientos: " & ex.Message,
                "Error MySQL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvVencimientos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvvencimientos.CellFormatting

        ' Verificamos que sea una fila válida con datos
        If e.RowIndex < 0 OrElse dgvvencimientos.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' Evaluamos únicamente la columna "Fecha Vencimiento"
        If dgvvencimientos.Columns(e.ColumnIndex).Name = "Fecha Vencimiento" Then

            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then

                Dim fechaVenc As Date

                If Date.TryParse(e.Value.ToString(), fechaVenc) Then

                    Dim diasRestantes As Integer = (fechaVenc.Date - Date.Today).Days

                    ' CRÍTICO: vence en 15 días o menos (rojo suave)
                    If diasRestantes <= 15 Then

                        dgvvencimientos.Rows(e.RowIndex).DefaultCellStyle.BackColor =
                            Color.FromArgb(254, 226, 226)

                        dgvvencimientos.Rows(e.RowIndex).DefaultCellStyle.ForeColor =
                            Color.FromArgb(185, 28, 28)

                        ' ADVERTENCIA: vence entre 16 y 30 días (amarillo suave)
                    ElseIf diasRestantes <= 30 Then

                        dgvvencimientos.Rows(e.RowIndex).DefaultCellStyle.BackColor =
                            Color.FromArgb(254, 243, 199)

                        dgvvencimientos.Rows(e.RowIndex).DefaultCellStyle.ForeColor =
                            Color.FromArgb(180, 83, 9)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CargarGraficoVencimientos()
        Try
            Dim cantInminente As Double = 0 ' Hasta 30 días (Rojo)
            Dim cantProximos As Double = 0  ' 31 a 60 días (Naranja)
            Dim cantSeguro As Double = 0    ' Más de 60 días (Verde)

            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                ' Consulta SQL: agrupa las cantidades de los lotes según su fecha de vencimiento
                Dim sql As String = "SELECT " &
                                    "IFNULL(SUM(CASE WHEN DATEDIFF(fecha_vencimiento, CURDATE()) <= 30 THEN cantidad_actual ELSE 0 END), 0) AS inminente, " &
                                    "IFNULL(SUM(CASE WHEN DATEDIFF(fecha_vencimiento, CURDATE()) BETWEEN 31 AND 60 THEN cantidad_actual ELSE 0 END), 0) AS proximos, " &
                                    "IFNULL(SUM(CASE WHEN DATEDIFF(fecha_vencimiento, CURDATE()) > 60 THEN cantidad_actual ELSE 0 END), 0) AS seguro " &
                                    "FROM lote " &
                                    "WHERE cantidad_actual > 0 AND fecha_vencimiento >= CURDATE();"

                Using cmd As New MySqlCommand(sql, cn)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            cantInminente = Convert.ToDouble(rd("inminente"))
                            cantProximos = Convert.ToDouble(rd("proximos"))
                            cantSeguro = Convert.ToDouble(rd("seguro"))
                        End If
                    End Using
                End Using
            End Using

            ' Si no hay lotes con stock vigente, salimos sin graficar
            If cantInminente = 0 AndAlso
               cantProximos = 0 AndAlso
               cantSeguro = 0 Then
                Exit Sub
            End If

            ' Configuración de ScottPlot
            FormsPlot2.Plot.Clear()

            ' Definimos las porciones de la dona con sus respectivos colores
            Dim slices As New List(Of ScottPlot.PieSlice) From {
                New ScottPlot.PieSlice() With {
                    .Value = cantInminente,
                    .Label = "Hasta 30 días",
                    .FillColor = ScottPlot.Color.FromHex("#DC2626")
                },
                New ScottPlot.PieSlice() With {
                    .Value = cantProximos,
                    .Label = "31-60 días",
                    .FillColor = ScottPlot.Color.FromHex("#EA580C")
                },
                New ScottPlot.PieSlice() With {
                    .Value = cantSeguro,
                    .Label = "Más de 60 días",
                    .FillColor = ScottPlot.Color.FromHex("#16A34A")
                }
            }

            ' Filtramos las porciones con cantidad mayor a cero
            Dim slicesFiltradas = slices.
                Where(Function(s) s.Value > 0).
                ToList()

            ' Agregamos el gráfico de dona
            Dim pie = FormsPlot2.Plot.Add.Pie(slicesFiltradas)

            ' Agujero central del 50%
            pie.DonutFraction = 0.5

            ' Título del gráfico
            FormsPlot2.Plot.Title("Riesgo de Vencimiento de Lotes")

            ' Actualizamos el gráfico
            FormsPlot2.Refresh()

        Catch ex As Exception
            MessageBox.Show(
                "Error al cargar gráfico de vencimientos: " & ex.Message,
                "Error ScottPlot",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnlistado_Click(sender As Object, e As EventArgs) Handles btnlistado.Click
        If dgvvencimientos.Rows.Count = 0 OrElse
       (dgvvencimientos.Rows.Count = 1 AndAlso dgvvencimientos.Rows(0).IsNewRow) Then

            MessageBox.Show("No hay medicamentos próximos a vencer para imprimir.")
            Exit Sub
        End If

        filaActual = 0

        ' Configuramos la hoja en horizontal
        documento.DefaultPageSettings.Landscape = True

        ' Mostramos la vista previa
        Using vistaPrevia As New PrintPreviewDialog()
            vistaPrevia.Document = documento
            vistaPrevia.Width = 1000
            vistaPrevia.Height = 700
            vistaPrevia.ShowDialog()
        End Using

    End Sub


    Private Sub documento_PrintPage(sender As Object,
                                e As PrintPageEventArgs) Handles documento.PrintPage

        Dim fuenteTitulo As New Font("Arial", 16, FontStyle.Bold)
        Dim fuenteNormal As New Font("Arial", 10)
        Dim fuenteEncabezado As New Font("Arial", 10, FontStyle.Bold)

        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top
        Dim altoFila As Integer = 28

        ' Título del informe
        e.Graphics.DrawString(
        "LISTADO DE MEDICAMENTOS PRÓXIMOS A VENCER",
        fuenteTitulo,
        Brushes.Black,
        x, y)

        y += 35

        ' Fecha de impresión
        e.Graphics.DrawString(
        "Fecha de impresión: " & Date.Today.ToString("dd/MM/yyyy"),
        fuenteNormal,
        Brushes.Black,
        x, y)

        y += 35

        ' Ancho de las columnas
        Dim anchos() As Integer = {250, 130, 180, 150}
        Dim encabezados() As String = {
        "Medicamento",
        "N° Lote",
        "Fecha Vencimiento",
        "Cant. Restante"
    }

        ' Dibujar encabezados
        Dim posX As Integer = x

        For i As Integer = 0 To encabezados.Length - 1
            e.Graphics.DrawRectangle(
            Pens.Black, posX, y, anchos(i), altoFila)

            e.Graphics.DrawString(
            encabezados(i),
            fuenteEncabezado,
            Brushes.Black,
            New RectangleF(posX + 4, y + 4, anchos(i) - 8, altoFila - 4))

            posX += anchos(i)
        Next

        y += altoFila

        ' Imprimir las filas de la tabla
        While filaActual < dgvvencimientos.Rows.Count

            Dim fila As DataGridViewRow = dgvvencimientos.Rows(filaActual)

            If Not fila.IsNewRow Then

                ' Si no queda espacio, continuar en otra página
                If y + altoFila > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Exit Sub
                End If

                posX = x

                For i As Integer = 0 To encabezados.Length - 1

                    Dim valor As String = ""

                    If fila.Cells(i).Value IsNot Nothing Then
                        valor = fila.Cells(i).Value.ToString()
                    End If

                    e.Graphics.DrawRectangle(
                    Pens.Black, posX, y, anchos(i), altoFila)

                    e.Graphics.DrawString(
                    valor,
                    fuenteNormal,
                    Brushes.Black,
                    New RectangleF(posX + 4, y + 4, anchos(i) - 8, altoFila - 4))

                    posX += anchos(i)

                Next

                y += altoFila

            End If

            filaActual += 1

        End While

        ' Ya se imprimieron todas las filas
        e.HasMorePages = False
        filaActual = 0

    End Sub
End Class