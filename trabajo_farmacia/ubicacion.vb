Imports MySqlConnector
Public Class ubicacion

    Private Sub frmUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configuración de autocompletado por código
        cbbuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbbuscar.AutoCompleteSource = AutoCompleteSource.ListItems

        ' Cargar la lista de remedios
        CargarMedicamentosCombo()
        ResetearMapa()
    End Sub


    Private Sub CargarMedicamentosCombo()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT nombre FROM medicamento ORDER BY nombre ASC;"

                Using cmd As New MySqlCommand(sql, cn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        cbbuscar.Items.Clear()

                        While dr.Read()
                            cbbuscar.Items.Add(dr("nombre").ToString())
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error al cargar la lista de medicamentos: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        If lblubicacion Is Nothing OrElse cbbuscar Is Nothing Then Exit Sub

        If String.IsNullOrWhiteSpace(cbbuscar.Text) Then
            MessageBox.Show(
            "Seleccioná o buscá un medicamento de la lista.",
            "Atención",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Reseteamos los paneles del mapa a gris
        ResetearMapa()

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                ' Sumamos cantidad_actual desde la tabla lote y agrupamos
                Dim sql As String = "SELECT m.nombre, d.nombre AS droga, " &
                                "IFNULL(SUM(l.cantidad_actual), 0) AS stock_total, " &
                                "u.pasillo, u.estante, u.nivel, u.detalle " &
                                "FROM medicamento m " &
                                "LEFT JOIN droga d ON m.id_droga = d.id_droga " &
                                "LEFT JOIN lote l ON m.id_medicamento = l.id_medicamento " &
                                "LEFT JOIN ubicacion u ON m.id_ubicacion = u.id_ubicacion " &
                                "WHERE m.nombre = @nombre " &
                                "GROUP BY m.id_medicamento, m.nombre, d.nombre, " &
                                "u.pasillo, u.estante, u.nivel, u.detalle LIMIT 1;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", cbbuscar.Text.Trim())

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        If dr.Read() Then

                            ' 1. Medicamento
                            lblnombre.Text = dr("nombre").ToString()

                            ' 2. Droga
                            lblcategoria.Text =
                            If(IsDBNull(dr("droga")), "Sin especificar", dr("droga").ToString())

                            ' 3. Stock real calculado desde los lotes
                            lblstock.Text =
                            dr("stock_total").ToString() & " unidades"

                            ' 4. Ubicación en el mapa
                            If Not IsDBNull(dr("pasillo")) Then

                                Dim pasillo As String = dr("pasillo").ToString()
                                Dim estante As String = dr("estante").ToString()
                                Dim nivel As String = dr("nivel").ToString()
                                Dim detalle As String = dr("detalle").ToString()

                                lblubicacion.Text = " Ubicación: " &
                                pasillo & " | " & estante & " | " &
                                nivel & " (" & detalle & ")"

                                ' Encendemos el estante correspondiente en el mapa
                                ResaltarUbicacion(pasillo, estante)

                            Else
                                lblubicacion.Text = " Ubicación: Sin asignar en sistema"
                            End If

                        Else
                            lblnombre.Text = "Medicamento no encontrado"
                            lblcategoria.Text = "-"
                            lblstock.Text = "-"
                            lblubicacion.Text = " Ubicación: -"
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
            "Error al buscar ubicación: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try

    End Sub



    ' Método para devolver todos los paneles a su color original
    Private Sub ResetearMapa()

        pnl_p1_a.BackColor = Color.LightSteelBlue
        pnl_p1_b.BackColor = Color.LightSteelBlue

        pnl_p2_a.BackColor = Color.LightSteelBlue
        pnl_p2_b.BackColor = Color.LightSteelBlue

        pnl_p3_a.BackColor = Color.LightSteelBlue
        pnl_p3_b.BackColor = Color.LightSteelBlue

        pnl_p4_a.BackColor = Color.LightSteelBlue
        pnl_p4_b.BackColor = Color.LightSteelBlue

        pnl_p5.BackColor = Color.LightSteelBlue

        ' Recorremos los pasillos (del 1 al 5) y los estantes (del 1 al 6)
        For p As Integer = 1 To 5
            For e As Integer = 1 To 6

                Dim nombreBoton As String = "btn" & e & "_p" & p

                ' Buscamos el botón en el formulario por su nombre
                Dim controles() As Control = Me.Controls.Find(nombreBoton, True)

                If controles.Length > 0 Then
                    controles(0).BackColor = Color.LightBlue
                End If

            Next
        Next

    End Sub


    ' Método para encender en verde brillante el panel donde se encuentra la mercadería
    Private Sub ResaltarUbicacion(pasillo As String, estante As String)

        Dim panelTarget As Panel = Nothing
        ' 1. Pasamos a minúsculas y limpiamos espacios
        Dim textPasillo As String = pasillo.ToLower().Trim()
        Dim textEstante As String = estante.ToLower().Trim()

        ' 2. Extraemos solo el número del pasillo (ej: "Pasillo 1" -> "1", "2" -> "2")
        Dim numPasillo As String = System.Text.RegularExpressions.Regex.Match(textPasillo, "\d+").Value

        ' 3. Limpiamos la palabra "estante" para analizar si es del grupo A o B
        Dim estanteLimpio As String = textEstante.Replace("estante", "").Replace(" ", "")

        ' 4. Determinamos si corresponde al lado A o lado B
        Dim lado As String = ""

        If estanteLimpio.Contains("a") OrElse estanteLimpio.StartsWith("1") OrElse estanteLimpio.StartsWith("2") OrElse estanteLimpio.StartsWith("3") Then
            lado = "a"
        ElseIf estanteLimpio.Contains("b") OrElse estanteLimpio.StartsWith("4") OrElse estanteLimpio.StartsWith("5") OrElse estanteLimpio.StartsWith("6") Then
            lado = "b"
        End If

        ' 5. Armamos la clave del panel (ej: "p1_a", "p1_b", "p2_a", etc.)
        Dim clave As String = "p" & numPasillo & "_" & lado

        Select Case clave

    ' PASILLO 1
            Case "p1_a" : panelTarget = pnl_p1_a
            Case "p1_b" : panelTarget = pnl_p1_b

    ' PASILLO 2
            Case "p2_a" : panelTarget = pnl_p2_a
            Case "p2_b" : panelTarget = pnl_p2_b

    ' PASILLO 3
            Case "p3_a" : panelTarget = pnl_p3_a
            Case "p3_b" : panelTarget = pnl_p3_b

    ' PASILLO 4
            Case "p4_a" : panelTarget = pnl_p4_a
            Case "p4_b" : panelTarget = pnl_p4_b

    ' PASILLO 5 (si tenés pnl_p5 único o dividido)
            Case "p5_a", "p5_b", "p5_" : panelTarget = pnl_p5

        End Select

        ' Pintamos de verde el panel encontrado
        If panelTarget IsNot Nothing Then
            panelTarget.BackColor = Color.MediumSeaGreen
        End If

        ' Extraemos solo los dígitos numéricos de las cadenas
        ' Ejemplo: "Pasillo 1" -> "1", "Estante 4" -> "4"
        Dim numPasillo2 As String = System.Text.RegularExpressions.Regex.Match(pasillo, "\d+").Value
        Dim numEstante As String = System.Text.RegularExpressions.Regex.Match(estante, "\d+").Value

        ' Si el estante venía guardado con letras (A1..A3 / B1..B3), lo convertimos al número de botón (1..6)
        If String.IsNullOrEmpty(numEstante) Then
            Select Case estante.Trim().ToUpper()
                Case "A", "A1", "ESTANTE A" : numEstante = "1"
                Case "A2" : numEstante = "2"
                Case "A3" : numEstante = "3"
                Case "B", "B1", "ESTANTE B" : numEstante = "4"
                Case "B2" : numEstante = "5"
                Case "B3" : numEstante = "6"
            End Select
        End If

        ' Armamos el nombre del botón según tu convención: btn[estante]_p[pasillo] (ej: btn4_p1)
        Dim nombreBoton As String = "btn" & numEstante & "_p" & numPasillo2

        ' Buscamos el botón y lo pintamos de verde brillante
        Dim controles() As Control = Me.Controls.Find(nombreBoton, True)

        If controles.Length > 0 Then
            controles(0).BackColor = Color.SeaGreen
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetearMapa()
    End Sub
End Class
