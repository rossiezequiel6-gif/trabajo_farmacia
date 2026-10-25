Imports MySqlConnector

Public Class fromproveedores
    Dim idSeleccionado As Integer = 0

    Sub CargarProveedores()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT id_proveedor, nombre, cuil, telefono, direccion, estado," &
                                        " IF(estado = 1, 'Activo', 'Inactivo') AS estado " &
                                        " FROM proveedor"

                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargar la tabla en la grilla
                    dgvprovedores.DataSource = tabla
                    dgvprovedores.Columns("estado").Visible = False



                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar las Proveedores: " & ex.Message)
        End Try
    End Sub

    'sub rutina para limpiar todos los campos 
    Sub limpiar()
        txtidproveedor.Text = ""
        txtnombre.Text = ""
        txtcuil.Text = ""
        txttelefono.Text = ""
        txtdireccion.Text = ""
        idSeleccionado = 0
        cbestado.SelectedIndex = -1
    End Sub


    'funcion para ver si cargo los datos 
    Function validarDatos() As Boolean
        If txtnombre.Text.Trim = "" Then
            MessageBox.Show("El nombre es obligatorio")
            Return False
        End If
        If txtcuil.Text.Trim = "" Then
            MessageBox.Show("El CUIL es obligatorio")
            Return False
        End If
        Return True
    End Function


    'Sub rutina para buscar proveedores
    Private Sub buscarproveedores(filtro As String)
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "SELECT id_proveedor, nombre, cuil, direccion, telefono, estado, " &
                                     "IF(estado = 1, 'Activo', 'Inactivo') AS situacion " &
                                     "FROM proveedor " &
                                     "WHERE nombre LIKE @filtro " &
                                     "ORDER BY nombre;"

                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro.Trim() & "%")

                    Dim tabla As New DataTable()
                    tabla.Load(cmd.ExecuteReader())
                    dgvprovedores.DataSource = tabla
                    dgvprovedores.Columns("estado").Visible = False
                    dgvprovedores.ClearSelection()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar proveedores: " & ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprovedores.CellContentClick

    End Sub

    Private Sub dgvprovedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprovedores.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvprovedores.Rows(e.RowIndex)

        idSeleccionado = CInt(fila.Cells("id_proveedor").Value)
        txtidproveedor.Text = fila.Cells("id_proveedor").Value.ToString()
        txtnombre.Text = fila.Cells("nombre").Value.ToString()
        txtcuil.Text = fila.Cells("cuil").Value.ToString()
        txtdireccion.Text = fila.Cells("direccion").Value.ToString()
        txttelefono.Text = fila.Cells("telefono").Value.ToString()
        cbestado.SelectedIndex = If(CBool(fila.Cells("estado").Value), 0, 1)

    End Sub

    Private Sub fromproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'para que aparesca todo cargado en la grilla 
        CargarProveedores()

        cbestado.Items.Add("Activo")
        cbestado.Items.Add("Inactivo")
        cbestado.SelectedIndex = -1

        Estilos.EstilizarGrilla(dgvprovedores)

        Me.BackColor = Color.FromArgb(244, 247, 246)
        Estilos.EstilizarCampos(Me)

        EstilizarGroupBox(gbproveedores)
        EstilizarGroupBox(GroupBox1)

        'estiliza los botones 
        EstilizarBoton(btnguardar, ColorMenu)
        EstilizarBoton(btneliminar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificar, ColorActivo)
        EstilizarBoton(btnlimpiar, Color.FromArgb(90, 160, 145))
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'valido si selecciono una fila en la grilla 
        If Not validarDatos() Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                If idSeleccionado = 0 Then
                    ' No hay nada seleccionado → inserto un proveedor nuevo
                    Dim consulta As String = "INSERT INTO proveedor (nombre, cuil, telefono, direccion) " &
                                             "VALUES (@nombre, @cuil, @telefono, @direccion)"
                    Using cmd As New MySqlCommand(consulta, cn)
                        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                        cmd.Parameters.AddWithValue("@cuil", txtcuil.Text.Trim)
                        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text.Trim)
                        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text.Trim)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Proveedor agregado correctamente")

                Else
                    ' Hay un id seleccionado → modifico el existente
                    Dim consulta As String = "UPDATE proveedor SET nombre=@nombre, cuil=@cuil, " &
                                             "telefono=@telefono, direccion=@direccion " &
                                             "WHERE id_proveedor=@id"
                    Using cmd As New MySqlCommand(consulta, cn)
                        cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                        cmd.Parameters.AddWithValue("@cuil", txtcuil.Text.Trim)
                        cmd.Parameters.AddWithValue("@telefono", txttelefono.Text.Trim)
                        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text.Trim)
                        cmd.Parameters.AddWithValue("@id", idSeleccionado)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Proveedor modificado correctamente")
                End If
            End Using

            CargarProveedores()
            limpiar()

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe un proveedor con ese CUIL")
            Else
                MessageBox.Show("Error al guardar: " & ex.Message)
            End If
        End Try

        CargarProveedores()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        'verifico si selecciono un fila 
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccioná un proveedor de la grilla primero")
            Exit Sub
        End If

        If Not validarDatos() Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "UPDATE proveedor SET nombre=@nombre, cuil=@cuil, " &
                                             "telefono=@telefono, direccion=@direccion, estado=@estado " &
                                             "WHERE id_proveedor=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@cuil", txtcuil.Text.Trim)
                    cmd.Parameters.AddWithValue("@telefono", txttelefono.Text.Trim)
                    cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text.Trim)
                    cmd.Parameters.AddWithValue("@id", idSeleccionado)
                    cmd.Parameters.AddWithValue("@estado", If(cbestado.SelectedIndex = 0, 1, 0))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Proveedor modificado correctamente")
            CargarProveedores()
            limpiar()

        Catch ex As MySqlException
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        'valido que haya seleccionado una fila en la grilla
        If dgvprovedores.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un proveedor para dar de baja")
            Exit Sub
        End If

        If txtidproveedor.Text.Trim = "" Then
            MessageBox.Show("Debe seleccionar un proveedor para dar de baja")
            Exit Sub
        End If

        If MessageBox.Show("¿Seguro que querés dar de baja este proveedor?", "Confirmar",
                            MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'baja lógica: no borro, solo cambio el estado
                Dim consulta As String = "UPDATE proveedor SET estado = 0 WHERE id_proveedor=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", txtidproveedor.Text.Trim)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Proveedor dado de baja")
            CargarProveedores()
            limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al dar de baja: " & ex.Message)
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()

    End Sub

    Private Sub txtbuscarprov_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarprov.TextChanged
        If txtbuscarprov.Text.Trim() = "" Then
            CargarProveedores()
        Else
            buscarproveedores(txtbuscarprov.Text.Trim())
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class