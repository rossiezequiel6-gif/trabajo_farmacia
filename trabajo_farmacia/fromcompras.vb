Imports MySqlConnector
Public Class fromcompras
    Dim idSeleccionado As Integer = 0
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
    End Sub


    Private Sub fromcompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCompras()
        CargarCombos()

        Estilos.EstilizarGrilla(dgvcompras)

        Me.BackColor = Color.FromArgb(244, 247, 246)
        Estilos.EstilizarCampos(Me)

        'estiliza el group 
        EstilizarGroupBox(gbcompras)

        'estiliza los botones 
        EstilizarBoton(btnregistrar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificar, ColorActivo)
        EstilizarBoton(btnlimpiar, Color.FromArgb(90, 160, 145))

    End Sub



    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ' Si hay una fila seleccionada, estarías duplicando una compra existente
        If idSeleccionado <> 0 Then
            MessageBox.Show("Hay una compra seleccionada. ")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub   ' si falta algo, corto acá

        If cbusuario.SelectedIndex = -1 Then  ' en el alta, el usuario también es obligatorio
            MessageBox.Show("Elegí el usuario que registra la compra")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' Los @algo son parámetros: se completan abajo. Evitan errores y la inyección SQL
                Dim consulta As String = "INSERT INTO compras (fecha_compra, numero_factura, id_usuario, id_proveedor)" &
                                     " VALUES (@fecha, @factura, @usuario, @proveedor)"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date)                    ' la fecha del calendario, sin hora
                    cmd.Parameters.AddWithValue("@factura", txtfactura.Text.Trim)
                    cmd.Parameters.AddWithValue("@usuario", CInt(cbusuario.SelectedValue))        ' el id del usuario elegido
                    cmd.Parameters.AddWithValue("@proveedor", CInt(cbproveedor.SelectedValue))    ' el id del proveedor elegido
                    cmd.ExecuteNonQuery()                                                         ' ejecuta el INSERT
                End Using
            End Using

            MessageBox.Show("Compra registrada correctamente")
            CargarCompras()   ' recarga la grilla para ver la compra nueva
            limpiar()         ' deja el formulario listo para otra

        Catch ex As MySqlException
            If ex.Number = 1062 Then   ' 1062 = valor duplicado 
                MessageBox.Show("Ya existe una compra con ese número de factura para ese proveedor")
            Else
                MessageBox.Show("Error al registrar: " & ex.Message)
            End If
        End Try

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
End Class