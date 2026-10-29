Imports MySqlConnector
Public Class fromcompras
    Dim idSeleccionado As Integer = 0
    Dim idLoteSeleccionado As Integer = 0

    Const DIAS_AVISO As Integer = 30
    Sub CargarCompras()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT c.id_compra, c.fecha_compra, c.numero_factura," &
                                          "p.nombre AS proveedor," &
                                           "u.nombre_usuario AS usuario," &
                                           "GROUP_CONCAT(l.codigo ORDER BY l.codigo SEPARATOR ', ') AS lotes, " &
                                           "c.id_proveedor, c.id_usuario " &
                                           "From compras As c " &
                                            "INNER Join proveedor AS p ON c.id_proveedor = p.id_proveedor " &
                                            "INNER Join usuario AS u ON c.id_usuario = u.id_usuario " &
                                           "Left Join detalle_compra AS d ON c.id_compra = d.id_compra " &
                                            "Left Join lote AS l ON d.id_lote = l.id_lote " &
                                            "GROUP BY c.id_compra, c.fecha_compra, c.numero_factura, " &
                                                     "p.nombre, u.nombre_usuario, c.id_proveedor, c.id_usuario " &
                                            "ORDER BY c.fecha_compra DESC"


                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using

                    'cargar la tabla en la grilla
                    dgvcompras.DataSource = tabla
                    dgvcompras.Columns("id_proveedor").Visible = False
                    dgvcompras.Columns("id_usuario").Visible = False
                    dgvcompras.Columns("fecha_compra").HeaderText = "Fecha"
                    dgvcompras.Columns("numero_factura").HeaderText = "N° de factura"
                    dgvcompras.Columns("proveedor").HeaderText = "Proveedor"
                    dgvcompras.Columns("usuario").HeaderText = "Registrado por"




                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar la compra: " & ex.Message)
        End Try
    End Sub



    'sub cargar los combos 
    Sub CargarCombos()
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Dim tProv As New DataTable
            Using cmd As New MySqlCommand("SELECT id_proveedor, nombre FROM proveedor WHERE estado = 1 ORDER BY nombre", cn)
                tProv.Load(cmd.ExecuteReader())
            End Using
            cbproveedor.DisplayMember = "nombre"
            cbproveedor.ValueMember = "id_proveedor"
            cbproveedor.DataSource = tProv
            cbproveedor.SelectedIndex = -1

            Dim tUsu As New DataTable
            Using cmd As New MySqlCommand("SELECT id_usuario, nombre_usuario FROM usuario WHERE estado = 1 ORDER BY nombre_usuario", cn)
                tUsu.Load(cmd.ExecuteReader())
            End Using
            cbusuario.DisplayMember = "nombre_usuario"
            cbusuario.ValueMember = "id_usuario"
            cbusuario.DataSource = tUsu
            cbusuario.SelectedIndex = -1

            Dim tMed As New DataTable
            Using cmd As New MySqlCommand("SELECT id_medicamento, nombre FROM medicamento ORDER BY nombre", cn)
                Using lector As MySqlDataReader = cmd.ExecuteReader()
                    tMed.Load(lector)
                End Using
            End Using
            cbmedicamentos.DisplayMember = "nombre"
            cbmedicamentos.ValueMember = "id_medicamento"
            cbmedicamentos.DataSource = tMed
            cbmedicamentos.SelectedIndex = -1

        End Using
    End Sub


    'validar datos
    Function validarDatos() As Boolean
        If txtfactura.Text.Trim = "" Then
            MessageBox.Show("El número de factura es obligatorio")
            Return False
        End If
        If cbproveedor.SelectedIndex = -1 Then
            MessageBox.Show("Elegí un proveedor")
            Return False
        End If
        Return True
    End Function

    Sub limpiar()
        idSeleccionado = 0
        txtidcompras.Text = ""
        txtfactura.Text = ""
        dtpfecha.Value = Date.Today
        cbproveedor.SelectedIndex = -1
        cbusuario.SelectedIndex = -1
        cbusuario.Enabled = True
        dgvcompras.ClearSelection()
        txtlote.Text = ""
    End Sub

    'validar los datos para cargar lote
    Function validarLote() As Boolean
        If cbmedicamentos.SelectedIndex = -1 Then
            MessageBox.Show("Elegí un medicamento")
            Return False
        End If

        Dim codigo As Integer
        If Not Integer.TryParse(txtcodigolote.Text.Trim, codigo) Then
            MessageBox.Show("El código de lote tiene que ser un número")
            Return False
        End If

        If dtpvencimiento.Value.Date <= Date.Today Then
            MessageBox.Show("El vencimiento tiene que ser posterior a hoy")
            Return False
        End If

        If nudprecio.Value <= 0 Then
            MessageBox.Show("Ingresá el precio unitario")
            Return False
        End If

        Return True
    End Function


    ' Deja marcada una compra en la grilla de arriba y carga sus ítems abajo
    Sub SeleccionarCompra(id As Integer)
        ' Busco en la grilla la fila de esa compra y la marco
        For Each fila As DataGridViewRow In dgvcompras.Rows
            If CInt(fila.Cells("id_compra").Value) = id Then
                dgvcompras.ClearSelection()
                fila.Selected = True
                dgvcompras.CurrentCell = fila.Cells("numero_factura")
                Exit For
            End If
        Next

        idSeleccionado = id          ' ahora Agregar ítem sabe a qué compra pertenece
        idLoteSeleccionado = 0       ' ningún ítem elegido todavía
        txtidcompras.Text = id.ToString()
        CargarDetalle(id)            ' muestra los lotes de esa compra en la grilla de abajo
    End Sub


    Sub InsertarItem(cn As MySqlConnection, tx As MySqlTransaction, idCompra As Long)
        Dim idLote As Long

        ' 1) El lote, con su código y su vencimiento
        Dim sqlLote As String = "INSERT INTO lote (codigo, fecha_vencimiento, cantidad_actual, id_medicamento)" &
                            " VALUES (@codigo, @venc, @cant, @med)"
        Using cmd As New MySqlCommand(sqlLote, cn, tx)
            cmd.Parameters.AddWithValue("@codigo", CInt(txtcodigolote.Text.Trim))
            cmd.Parameters.AddWithValue("@venc", dtpvencimiento.Value.Date)
            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
            cmd.Parameters.AddWithValue("@med", CInt(cbmedicamentos.SelectedValue))
            cmd.ExecuteNonQuery()
            idLote = cmd.LastInsertedId
        End Using

        ' 2) El detalle que une la compra con ese lote
        Dim sqlDet As String = "INSERT INTO detalle_compra (cantidad, precio_unit, id_compra, id_lote)" &
                           " VALUES (@cant, @precio, @compra, @lote)"
        Using cmd As New MySqlCommand(sqlDet, cn, tx)
            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
            cmd.Parameters.AddWithValue("@precio", nudprecio.Value)
            cmd.Parameters.AddWithValue("@compra", idCompra)
            cmd.Parameters.AddWithValue("@lote", idLote)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Sub LimpiarItem()
        cbmedicamentos.SelectedIndex = -1
        txtcodigolote.Text = ""
        dtpvencimiento.Value = Date.Today
        nudcantidad.Value = 1
        nudprecio.Value = 0
    End Sub


    ' Muestra en la grilla de abajo (dgvdetalle) los ítems de UNA compra

    Sub CargarDetalle(idCompra As Integer)
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "SELECT d.id_lote, l.codigo AS lote, m.nombre AS medicamento," &
                " l.fecha_vencimiento, d.cantidad, d.precio_unit," &
                " CASE" &
                " WHEN l.fecha_vencimiento < CURDATE() THEN 'Vencido'" &
                " WHEN l.fecha_vencimiento = CURDATE() THEN 'Vence hoy'" &
                " WHEN l.fecha_vencimiento = DATE_ADD(CURDATE(), INTERVAL 1 DAY) THEN 'Vence mañana'" &
                " WHEN l.fecha_vencimiento <= DATE_ADD(CURDATE(), INTERVAL @dias DAY)" &
                " THEN CONCAT('Vence en ', DATEDIFF(l.fecha_vencimiento, CURDATE()), ' días')" &
                " ELSE 'Vigente' END AS aviso" &
                " FROM detalle_compra AS d" &
                " INNER JOIN lote AS l ON d.id_lote = l.id_lote" &
                " INNER JOIN medicamento AS m ON l.id_medicamento = m.id_medicamento" &
                " WHERE d.id_compra = @id" &
                " ORDER BY l.fecha_vencimiento"

                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", idCompra)
                    cmd.Parameters.AddWithValue("@dias", DIAS_AVISO)

                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using

                    dgvdetalle.DataSource = tabla
                End Using
            End Using

            ' Presentación de las columnas
            dgvdetalle.Columns("id_lote").Visible = False
            dgvdetalle.Columns("lote").HeaderText = "Lote"
            dgvdetalle.Columns("medicamento").HeaderText = "Medicamento"
            dgvdetalle.Columns("fecha_vencimiento").HeaderText = "Vence"
            dgvdetalle.Columns("fecha_vencimiento").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvdetalle.Columns("cantidad").HeaderText = "Cant."
            dgvdetalle.Columns("precio_unit").HeaderText = "Precio"
            dgvdetalle.Columns("precio_unit").DefaultCellStyle.Format = "C2"
            dgvdetalle.Columns("aviso").HeaderText = "Aviso"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los ítems: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvcompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcompras.CellContentClick

    End Sub

    'grilla
    Private Sub dgvcompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcompras.CellClick
        ' Si hiciste clic en el encabezado, RowIndex vale -1 (no hay fila): salgo sin hacer nada
        If e.RowIndex < 0 Then Exit Sub

        ' "fila" es la fila de la grilla donde hiciste clic
        Dim fila As DataGridViewRow = dgvcompras.Rows(e.RowIndex)

        ' Guardo el id para saber qué compra modificar después
        idSeleccionado = CInt(fila.Cells("id_compra").Value)

        ' Paso los datos de la fila a los controles.
        ' El texto entre comillas es el nombre de la columna tal como sale del SELECT
        txtidcompras.Text = fila.Cells("id_compra").Value.ToString()
        txtfactura.Text = fila.Cells("numero_factura").Value.ToString()
        txtlote.Text = fila.Cells("lotes").Value.ToString()
        dtpfecha.Value = CDate(fila.Cells("fecha_compra").Value)   ' el calendario se posiciona en esa fecha

        ' Los combos se posicionan por el id (el ValueMember), no por el nombre
        cbproveedor.SelectedValue = CInt(fila.Cells("id_proveedor").Value)
        cbusuario.SelectedValue = CInt(fila.Cells("id_usuario").Value)

        ' Al modificar no se cambia quién registró la compra: bloqueo ese combo
        cbusuario.Enabled = False

        ' muestro los ítems de esta compra
        CargarDetalle(idSeleccionado)
    End Sub


    Private Sub fromcompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCompras()
        CargarCombos()

        Estilos.EstilizarGrilla(dgvcompras)
        Estilos.EstilizarGrilla(dgvdetalle)

        Me.BackColor = Color.FromArgb(244, 247, 246)
        Estilos.EstilizarCampos(Me)

        'estiliza el group 
        EstilizarGroupBox(gbcompras)
        EstilizarGroupBox(gbdetallecompra)

        'estiliza los botones 
        EstilizarBoton(btnregistrar, ColorMenu)
        EstilizarBoton(btnmodificar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnlimpiar, Color.FromArgb(90, 160, 145))
        EstilizarBoton(btnagregaritem, ColorMenu)

        dgvdetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvdetalle.MultiSelect = False
        dgvdetalle.AllowUserToAddRows = False
        dgvdetalle.ReadOnly = True

        ' Permisos

        Dim puede As Boolean = Permisos.PuedeRegistrarCompras()
        btnregistrar.Visible = puede
        btnmodificar.Visible = puede
        pnlotes.Visible = puede      ' incluye btnagregaritem y los controles del lote

    End Sub



    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If Not Permisos.PuedeRegistrarCompras() Then
            MessageBox.Show("Tu rol no tiene permiso para registrar compras")
            Exit Sub
        End If

        If idSeleccionado <> 0 Then
            MessageBox.Show("Hay una compra seleccionada. Usá Limpiar campos para cargar una nueva.")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub
        If Not validarLote() Then Exit Sub

        Dim idNuevo As Long = 0

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Using tx As MySqlTransaction = cn.BeginTransaction()
                    Try
                        ' 1) La compra
                        Dim sqlCompra As String = "INSERT INTO compras (fecha_compra, numero_factura, id_usuario, id_proveedor)" &
                                                  " VALUES (@fecha, @factura, @usuario, @proveedor)"
                        Using cmd As New MySqlCommand(sqlCompra, cn, tx)
                            cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date)
                            cmd.Parameters.AddWithValue("@factura", txtfactura.Text.Trim)
                            cmd.Parameters.AddWithValue("@usuario", sesion.idUsuario)
                            cmd.Parameters.AddWithValue("@proveedor", CInt(cbproveedor.SelectedValue))
                            cmd.ExecuteNonQuery()
                            idNuevo = cmd.LastInsertedId
                        End Using

                        ' 2) Su primer lote y el detalle
                        InsertarItem(cn, tx, idNuevo)

                        tx.Commit()      ' se guardan los tres registros juntos
                    Catch
                        tx.Rollback()    ' si algo falla, no queda nada a medias
                        Throw
                    End Try
                End Using
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                If ex.Message.Contains("'codigo'") Then
                    MessageBox.Show("Ya existe un lote con ese código")
                Else
                    MessageBox.Show("Ya existe una compra con ese número de factura para ese proveedor")
                End If
            Else
                MessageBox.Show("Error al registrar: " & ex.Message)
            End If
            Exit Sub
        End Try

        CargarCompras()                    ' la grilla ya muestra el código del lote
        SeleccionarCompra(CInt(idNuevo))   ' la compra queda seleccionada
        LimpiarItem()                      ' campos del lote listos para un segundo lote
        MessageBox.Show("Compra registrada con su lote")
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        ' Sin fila seleccionada no sé cuál compra modificar
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccioná una compra de la grilla primero")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' UPDATE cambia los datos de UNA compra: la del WHERE id_compra = @id
                ' No incluye id_usuario: la compra queda a nombre de quien la registró
                Dim consulta As String = "UPDATE compras SET fecha_compra=@fecha, numero_factura=@factura," &
                                     " id_proveedor=@proveedor" &
                                     " WHERE id_compra=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date)
                    cmd.Parameters.AddWithValue("@factura", txtfactura.Text.Trim)
                    cmd.Parameters.AddWithValue("@proveedor", CInt(cbproveedor.SelectedValue))
                    cmd.Parameters.AddWithValue("@id", idSeleccionado)   ' el id guardado en el CellClick
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Compra modificada correctamente")
            CargarCompras()
            limpiar()

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe una compra con ese número de factura para ese proveedor")
            Else
                MessageBox.Show("Error al modificar: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()

    End Sub

    Private Sub btnagregaritem_Click(sender As Object, e As EventArgs) Handles btnagregaritem.Click
        ' Permiso por rol
        If Not Permisos.PuedeRegistrarCompras() Then
            MessageBox.Show("Tu rol no tiene permiso para registrar compras")
            Exit Sub
        End If

        ' Tiene que haber una compra seleccionada: el ítem se agrega a esa compra
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccioná primero una compra de la grilla")
            Exit Sub
        End If

        ' Validaciones de los campos
        If cbmedicamentos.SelectedIndex = -1 Then
            MessageBox.Show("Elegí un medicamento")
            Exit Sub
        End If

        Dim codigoLote As Integer
        If Not Integer.TryParse(txtcodigolote.Text.Trim, codigoLote) Then
            MessageBox.Show("El código de lote tiene que ser un número")
            Exit Sub
        End If

        If dtpvencimiento.Value.Date <= Date.Today Then
            MessageBox.Show("El vencimiento tiene que ser posterior a hoy")
            Exit Sub
        End If

        If nudprecio.Value <= 0 Then
            MessageBox.Show("Ingresá el precio unitario")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Using tx As MySqlTransaction = cn.BeginTransaction()   ' empieza la transacción
                    Try
                        ' 1) Creo el lote con su vencimiento
                        Dim idLote As Long
                        Dim sqlLote As String = "INSERT INTO lote (codigo, fecha_vencimiento, cantidad_actual, id_medicamento)" &
                                            " VALUES (@codigo, @venc, @cant, @med)"
                        Using cmd As New MySqlCommand(sqlLote, cn, tx)
                            cmd.Parameters.AddWithValue("@codigo", codigoLote)
                            cmd.Parameters.AddWithValue("@venc", dtpvencimiento.Value.Date)
                            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
                            cmd.Parameters.AddWithValue("@med", CInt(cbmedicamentos.SelectedValue))
                            cmd.ExecuteNonQuery()
                            idLote = cmd.LastInsertedId                ' id que generó la base para ese lote
                        End Using

                        ' 2) Creo la línea de detalle que une la compra con ese lote
                        Dim sqlDet As String = "INSERT INTO detalle_compra (cantidad, precio_unit, id_compra, id_lote)" &
                                           " VALUES (@cant, @precio, @compra, @lote)"
                        Using cmd As New MySqlCommand(sqlDet, cn, tx)
                            cmd.Parameters.AddWithValue("@cant", CInt(nudcantidad.Value))
                            cmd.Parameters.AddWithValue("@precio", nudprecio.Value)
                            cmd.Parameters.AddWithValue("@compra", idSeleccionado)
                            cmd.Parameters.AddWithValue("@lote", idLote)
                            cmd.ExecuteNonQuery()
                        End Using

                        tx.Commit()      ' los dos registros se guardan juntos
                    Catch
                        tx.Rollback()    ' si algo falló, se deshace todo
                        Throw            ' y paso el error al Catch de afuera
                    End Try
                End Using
            End Using

            MessageBox.Show("Ítem agregado correctamente")
            CargarDetalle(idSeleccionado)   ' refresca la grilla de ítems
            CargarCompras()                 ' refresca la columna "lotes" de la grilla principal

            ' Limpio los campos del ítem para cargar el siguiente
            cbmedicamentos.SelectedIndex = -1
            txtcodigolote.Text = ""
            dtpvencimiento.Value = Date.Today
            nudcantidad.Value = nudcantidad.Minimum
            nudprecio.Value = nudprecio.Minimum

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe un lote con ese código")
            Else
                MessageBox.Show("Error al agregar el ítem: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub dgvdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick

    End Sub

    Private Sub dgvdetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetalle.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvdetalle.Rows(e.RowIndex)
        idLoteSeleccionado = CInt(fila.Cells("id_lote").Value)


        Dim consulta As String = "SELECT d.id_lote, l.codigo AS Lote, m.nombre AS medicamento," &
                         " l.fecha_vencimiento, d.cantidad, d.precio_unit" &
                         " FROM detalle_compra AS d" &
                         " INNER JOIN lote AS l ON d.id_lote = l.id_lote" &
                         " INNER JOIN medicamento AS m ON l.id_medicamento = m.id_medicamento" &
                         " WHERE d.id_compra = @id" &
                         " ORDER BY l.codigo"

        dgvdetalle.DataSource =
        dgvdetalle.Columns("id_lote").Visible = False
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnimprimirre_Click(sender As Object, e As EventArgs) Handles btnimprimirre.Click
        PrintDocument1.DocumentName = "Remito de compra"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim margen As Integer = 50
        Dim y As Integer = 40



        Dim titulo As New Font("Segoe UI", 20, FontStyle.Bold)
        Dim subtitulo As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim texto As New Font("Segoe UI", 10)
        Dim negrita As New Font("Segoe UI", 10, FontStyle.Bold)

        Dim verde As Color = Color.FromArgb(23, 107, 91)
        Dim pincelVerde As New SolidBrush(verde)
        Dim pincelBlanco As New SolidBrush(Color.White)
        Dim pincelNegro As Brush = Brushes.Black

        ' Encabezado
        g.FillRectangle(pincelVerde, margen, y, 740, 65)
        g.DrawString("FARMACIA", titulo, pincelBlanco, margen + 15, y + 5)
        g.DrawString("GESTIÓN DE STOCK", texto, pincelBlanco, margen + 18, y + 38)

        g.DrawString("REMITO DE COMPRA", subtitulo, pincelNegro, margen, y + 80)
        y += 115

        ' Datos de la compra
        g.DrawString("N° de compra: " & txtidcompras.Text, texto, pincelNegro, margen, y)
        g.DrawString("Factura: " & txtfactura.Text, texto, pincelNegro, margen + 300, y)
        y += 25

        g.DrawString("Fecha: " & dtpfecha.Value.ToString("dd/MM/yyyy"),
                     texto, pincelNegro, margen, y)
        y += 30

        g.DrawString("Proveedor: " & cbproveedor.Text,
             texto, Brushes.Black, margen, y)
        y += 40

        ' Encabezado de la tabla
        g.FillRectangle(pincelVerde, margen, y, 740, 30)
        g.DrawString("Medicamento", negrita, pincelBlanco, margen + 8, y + 7)
        g.DrawString("Lote", negrita, pincelBlanco, margen + 350, y + 7)
        g.DrawString("Cantidad", negrita, pincelBlanco, margen + 490, y + 7)
        g.DrawString("Precio", negrita, pincelBlanco, margen + 600, y + 7)

        y += 30


        For Each fila As DataGridViewRow In dgvdetalle.Rows

            If fila.IsNewRow Then Continue For

            Dim medicamento As String =
        Convert.ToString(fila.Cells("medicamento").Value)

            Dim lote As String = ""

            If dgvdetalle.Columns.Contains("Lote") Then
                lote = Convert.ToString(fila.Cells("Lote").Value)
            End If

            Dim cantidad As String =
        Convert.ToString(fila.Cells("cantidad").Value)

            Dim precio As Decimal = 0D

            If fila.Cells("precio_unit").Value IsNot Nothing Then
                Decimal.TryParse(
            fila.Cells("precio_unit").Value.ToString(),
            precio
        )
            End If

            g.DrawString(medicamento, texto, Brushes.Black,
                 margen + 8, y + 5)

            g.DrawString(lote, texto, Brushes.Black,
                 margen + 350, y + 5)

            g.DrawString(cantidad, texto, Brushes.Black,
                 margen + 490, y + 5)

            g.DrawString(precio.ToString("N2"), texto, Brushes.Black,
                 margen + 600, y + 5)

            g.DrawLine(Pens.LightGray, margen, y + 27,
               margen + 740, y + 27)

            y += 30

        Next

        y += 25
        g.DrawString("Observaciones: __________________________________________",
                     texto, pincelNegro, margen, y)
        y += 80

        g.DrawLine(Pens.Black, margen, y, margen + 220, y)
        g.DrawLine(Pens.Black, margen + 430, y, margen + 650, y)

        g.DrawString("Entregado por", texto, pincelNegro, margen + 55, y + 8)
        g.DrawString("Recibido por", texto, pincelNegro, margen + 485, y + 8)

        e.HasMorePages = False

    End Sub

    Private Sub dgvdetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvdetalle.CellFormatting
        If e.RowIndex < 0 OrElse e.Value Is Nothing Then Exit Sub
        If dgvdetalle.Columns(e.ColumnIndex).Name <> "aviso" Then Exit Sub

        Dim texto As String = e.Value.ToString()
        Dim fondo As Color
        Dim letra As Color

        If texto.StartsWith("Vencido") Then
            fondo = Color.FromArgb(248, 215, 218)     ' rojo claro
            letra = Color.FromArgb(132, 32, 41)
        ElseIf texto.StartsWith("Vence") Then
            fondo = Color.FromArgb(255, 243, 205)     ' ámbar
            letra = Color.FromArgb(102, 77, 3)
        Else
            fondo = Color.FromArgb(209, 231, 221)     ' verde claro
            letra = Color.FromArgb(15, 81, 50)
        End If

        e.CellStyle.BackColor = fondo
        e.CellStyle.ForeColor = letra
        e.CellStyle.SelectionBackColor = fondo        ' conserva el color aunque la fila esté seleccionada
        e.CellStyle.SelectionForeColor = letra
    End Sub

End Class