Imports MySqlConnector
Public Class medicamentos

    Sub Cargarmedicamentos()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT m.id_medicamento, m.codigo, m.nombre AS medicamento, m.stock_min, m.stock_max, m.punto_pedido, m.requiere_receta, m.id_droga, d.nombre AS droga, 
                                            m.id_laboratorio, l.nombre AS laboratorio, m.id_accion, a.nombre AS accion_terapeutica, 
                                            m.id_presentacion, p.descripcion AS presentacion FROM medicamento m INNER JOIN droga d ON m.id_droga = d.id_droga 
                                            INNER JOIN laboratorio l ON m.id_laboratorio = l.id_laboratorio INNER JOIN accion_terapeutica a ON m.id_accion = a.id_accion 
                                            INNER JOIN presentacion p ON m.id_presentacion = p.id_presentacion ORDER BY m.id_medicamento;"

                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargar la tabla en la grilla
                    dgvmedicamento.DataSource = tabla
                    'ocultamos los IDs númericos pero los mantenemos en memoria
                    If dgvmedicamento.Columns.Contains("id_medicamento") Then
                        dgvmedicamento.Columns("id_medicamento").Visible = False
                        If dgvmedicamento.Columns.Contains("id_droga") Then
                            dgvmedicamento.Columns("id_droga").Visible = False
                        End If
                        If dgvmedicamento.Columns.Contains("id_laboratorio") Then
                            dgvmedicamento.Columns("id_laboratorio").Visible = False
                        End If
                        If dgvmedicamento.Columns.Contains("id_accion") Then
                            dgvmedicamento.Columns("id_accion").Visible = False
                        End If
                        If dgvmedicamento.Columns.Contains("id_presentacion") Then
                            dgvmedicamento.Columns("id_presentacion").Visible = False
                        End If
                    End If
                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar las editoriales: " & ex.Message)
        End Try
    End Sub
    Private Sub cargarcombos()
        'cargo combo de laboratorios
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "SELECT id_laboratorio, nombre FROM laboratorio ORDER BY id_laboratorio"
                Using cmd As New MySqlCommand(consulta, cn)
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    cblaboratorio.DataSource = tabla
                    cblaboratorio.DisplayMember = "nombre"
                    cblaboratorio.ValueMember = "id_laboratorio"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar el combo de laboratorios: " & ex.Message)
        End Try

        'cargo combo de drogas
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "SELECT id_droga, nombre FROM droga ORDER BY id_droga"
                Using cmd As New MySqlCommand(consulta, cn)
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargo el combo de drogas
                    cbdroga.DataSource = tabla
                    cbdroga.DisplayMember = "nombre"
                    cbdroga.ValueMember = "id_droga"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar el combo de drogas: " & ex.Message)
        End Try

        'cargo combo de acciones terapeuticas
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "SELECT id_accion, nombre FROM accion_terapeutica ORDER BY id_accion"
                Using cmd As New MySqlCommand(consulta, cn)
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargo el combo de acciones terapeuticas
                    cbterapeutica.DataSource = tabla
                    cbterapeutica.DisplayMember = "nombre"
                    cbterapeutica.ValueMember = "id_accion"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar el combo de acciones terapeuticas: " & ex.Message)
        End Try

        'cargo combo de presentaciones
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "SELECT id_presentacion, descripcion FROM presentacion ORDER BY id_presentacion"
                Using cmd As New MySqlCommand(consulta, cn)
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargo el combo de presentaciones
                    cbpresentacion.DataSource = tabla
                    cbpresentacion.DisplayMember = "descripcion"
                    cbpresentacion.ValueMember = "id_presentacion"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar el combo de presentaciones: " & ex.Message)
        End Try

        'cargo combo de acciones terapeuticas
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "SELECT id_accion, nombre FROM accion_terapeutica ORDER BY nombre"
                Using cmd As New MySqlCommand(consulta, cn)
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargo el combo de acciones terapeuticas
                    cbterapeutica.DataSource = tabla
                    cbterapeutica.DisplayMember = "nombre"
                    cbterapeutica.ValueMember = "id_accion"
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarmedicamentos()
        cargarcombos()
        limpiarform()
    End Sub

    Private Sub dgvmedicamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmedicamento.CellClick
        'ignoramos clics en la fila vacía de creacion
        If e.RowIndex < 0 OrElse dgvmedicamento.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If
        'cuando hago click en la grilla, me traigo los datos de la fila seleccionada
        If e.RowIndex >= 0 Then
            txtid.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_medicamento").Value.ToString()
            txtnombre.Text = dgvmedicamento.Rows(e.RowIndex).Cells("medicamento").Value.ToString()
            cblaboratorio.Text = dgvmedicamento.Rows(e.RowIndex).Cells("laboratorio").Value.ToString()
            txtcodigo.Text = dgvmedicamento.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            cbdroga.Text = dgvmedicamento.Rows(e.RowIndex).Cells("droga").Value.ToString()
            cbterapeutica.Text = dgvmedicamento.Rows(e.RowIndex).Cells("accion_terapeutica").Value.ToString()
            cbpresentacion.Text = dgvmedicamento.Rows(e.RowIndex).Cells("presentacion").Value.ToString()
            nudstockmin.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("stock_min").Value)
            nudstockmax.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("stock_max").Value)
            nudpedido.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("punto_pedido").Value)
            'obtener el valor de la celda en una variable
            Dim celdareceta = dgvmedicamento.Rows(e.RowIndex).Cells("requiere_receta").Value

            'verifico que no sea nulo o dbnull
            If Not IsDBNull(celdareceta) AndAlso celdareceta IsNot Nothing Then
                Dim valorreceta As String = celdareceta.ToString().Trim()
                'se marca como checked si el valor es 1 o true
                If valorreceta = "1" OrElse valorreceta.ToLower() = "true" Then
                    cbreceta.Checked = True
                Else
                    cbreceta.Checked = False
                End If
            End If
        End If



    End Sub
    Sub limpiarform()
        'limpiamos las casillas de texto
        txtid.Clear()
        txtcodigo.Clear()
        txtnombre.Clear()

        'desmarco el checkbox
        cbreceta.Checked = False

        'deseleccionamos los combos
        cbdroga.SelectedIndex = -1
        cblaboratorio.SelectedIndex = -1
        cbterapeutica.SelectedIndex = -1
        cbpresentacion.SelectedIndex = -1

        'reseteamos los numericupdown a 0
        nudstockmin.Value = 0
        nudstockmax.Value = 0
        nudpedido.Value = 0

        'ponemos el foco en el primer textbox
        txtcodigo.Focus()
    End Sub

    Private Sub buscarmedicamentos(filtro As String)
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'consulta sql que busca coincidencias en nombre, codigo o droga
                Dim consulta As String = "SELECT m.id_medicamento, m.codigo, m.nombre AS medicamento," &
                                         "m.stock_min, m.stock_max, m.punto_pedido, m.requiere_receta, " &
                                         "m.id_droga, d.nombre AS droga, " &
                                         "m.id_laboratorio, l.nombre AS laboratorio, " &
                                         "m.id_accion, a.nombre AS accion_terapeutica, " &
                                         "m.id_presentacion, p.descripcion AS presentacion " &
                                         "FROM medicamento m " &
                                         "INNER JOIN laboratorio l ON m.id_laboratorio = l.id_laboratorio " &
                                         "INNER JOIN droga d ON m.id_droga = d.id_droga " &
                                         "INNER JOIN accion_terapeutica a ON m.id_accion = a.id_accion " &
                                         "INNER JOIN presentacion p ON m.id_presentacion = p.id_presentacion " &
                                         "WHERE m.nombre LIKE @filtro OR m.codigo LIKE @filtro OR d.nombre LIKE @filtro " &
                                         "ORDER BY m.nombre;"

                Using cmd As New MySqlCommand(consulta, cn)
                    'el % permite econtrar coinsidencias parciales
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro.Trim() & "%")

                    Dim tabla As New DataTable()
                    tabla.Load(cmd.ExecuteReader())

                    'asignamos el resultado a la grilla
                    dgvmedicamento.DataSource = tabla
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al realizar la búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        ' valido que haya seleccionado una fila en la grilla
        If dgvmedicamento.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If

        'valido que los campos no estén vacio
        If txtnombre.Text.Trim = "" Then
            MessageBox.Show("El nombre del medicamento no puede estar vacío")
            txtnombre.Focus()
            Exit Sub
        End If

        If cblaboratorio.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un laboratorio", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cblaboratorio.Focus()
            Exit Sub
        End If

        If cbterapeutica.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una acción terapéutica", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbterapeutica.Focus()
            Exit Sub
        End If

        If cbdroga.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una droga", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbdroga.Focus()
            Exit Sub
        End If

        If cbpresentacion.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una presentación", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbpresentacion.Focus()
            Exit Sub
        End If

        'ejecucion del update en mysql
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'armo la consulta update
                Dim consulta As String = "UPDATE medicamento SET " &
                                         "codigo=@codigo, " &
                                         "nombre=@nombre, " &
                                         "stock_min=@stock_min, " &
                                         "stock_max=@stock_max, " &
                                         "punto_pedido=@punto_pedido, " &
                                         "requiere_receta=@requiere_receta, " &
                                         "id_droga=@id_droga, " &
                                         "id_laboratorio=@id_laboratorio, " &
                                         "id_accion=@id_accion, " &
                                         "id_presentacion=@id_presentacion " &
                                         "WHERE id_medicamento=@id_medicamento;"
                Using cmd As New MySqlCommand(consulta, cn)
                    'parametros de textos y numericos
                    cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim)
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@stock_min", nudstockmin.Value)
                    cmd.Parameters.AddWithValue("@stock_max", nudstockmax.Value)
                    cmd.Parameters.AddWithValue("@punto_pedido", nudpedido.Value)
                    cmd.Parameters.AddWithValue("@requiere_receta", If(cbreceta.Checked, 1, 0))

                    'parametros de claves foraneas
                    cmd.Parameters.AddWithValue("@id_droga", cbdroga.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_laboratorio", cblaboratorio.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_accion", cbterapeutica.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_presentacion", cbpresentacion.SelectedValue)

                    'parametro para el where
                    cmd.Parameters.AddWithValue("@id_medicamento", txtid.Text.Trim)

                    Dim filasafectadas As Integer = cmd.ExecuteNonQuery()
                    If filasafectadas > 0 Then
                        MessageBox.Show("Medicamento actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using
            End Using
            'limpiamos los campos y recargamos la grilla
            limpiarform()
            Cargarmedicamentos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar el medicamento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiarform()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'validacion de campos obligatorios
        If txtnombre.Text.Trim = "" Then
            MessageBox.Show("El nombre del medicamento no puede estar vacío", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnombre.Focus()
            Exit Sub
        End If

        If cblaboratorio.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un laboratorio", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cblaboratorio.Focus()
            Exit Sub
        End If

        If cbterapeutica.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una acción terapéutica", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbterapeutica.Focus()
            Exit Sub
        End If

        If cbdroga.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una droga", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbdroga.Focus()
            Exit Sub
        End If

        If cbpresentacion.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una presentación", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbpresentacion.Focus()
            Exit Sub
        End If

        'insercion en la base de datos
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "INSERT INTO medicamento (codigo, nombre, stock_min, stock_max, punto_pedido, requiere_receta, id_droga, id_laboratorio, id_accion, id_presentacion) " &
                                         "VALUES (@codigo, @nombre, @stock_min, @stock_max, @punto_pedido, @requiere_receta, @id_droga, @id_laboratorio, @id_accion, @id_presentacion)"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim)
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@stock_min", nudstockmin.Value)
                    cmd.Parameters.AddWithValue("@stock_max", nudstockmax.Value)
                    cmd.Parameters.AddWithValue("@punto_pedido", nudpedido.Value)
                    cmd.Parameters.AddWithValue("@requiere_receta", If(cbreceta.Checked, 1, 0))
                    cmd.Parameters.AddWithValue("@id_droga", cbdroga.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_laboratorio", cblaboratorio.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_accion", cbterapeutica.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_presentacion", cbpresentacion.SelectedValue)
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros insertados: " & resultado)
                End Using
            End Using
            Cargarmedicamentos() ' recargo la grilla para ver los cambios
            limpiarform() ' limpio el formulario después de guardar
        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'validamos que haya un registro seleccionado (revisando el id)
        If txtid.Text.Trim = "" Then
            MessageBox.Show("Debe seleccionar un medicamento para eliminar", "atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'pedimos pedimos confirmacion al usuario para evitar borrados accidentales
        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el medicamento seleccionado?", txtnombre.Text.Trim & "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                Using cn As New MySqlConnection(CADENA)
                    cn.Open()

                    Dim consulta As String = "DELETE FROM medicamento WHERE id_medicamento=@id_medicamento"
                    Using cmd As New MySqlCommand(consulta, cn)
                        cmd.Parameters.AddWithValue("@id_medicamento", txtid.Text.Trim)
                        Dim filasafectadas As Integer = cmd.ExecuteNonQuery()
                        If filasafectadas > 0 Then
                            MessageBox.Show("Medicamento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                    'limpiamos los casilleros y recargamos la grilla
                    limpiarform()
                    Cargarmedicamentos()

                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text.Trim() = "" Then
            Cargarmedicamentos()
        Else
            buscarmedicamentos(txtbuscar.Text.Trim())
        End If
    End Sub
End Class