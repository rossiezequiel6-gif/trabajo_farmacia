Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports MySqlConnector
Public Class medicamentos

    'funcion para convertir una imagen en un arreglo de bytes
    Private Function ImagenaBytes(img As Image) As Byte()
        'valido si la imagen es nula no hago
        If img Is Nothing Then Return Nothing

        'memory stream es un flujo de datos en memoria
        Using memoria As New MemoryStream()
            ' guardo la imagen en el memory stream
            img.Save(memoria, ImageFormat.Jpeg)
            'retorno la imagen en bytes
            Return memoria.ToArray()
        End Using
    End Function



    Private Sub CargarImagen(idMedicamento As Integer)

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
                "SELECT imagen FROM medicamento " &
                "WHERE id_medicamento = @id;"

                Using cmd As New MySqlCommand(sql, cn)

                    cmd.Parameters.AddWithValue("@id", idMedicamento)

                    Dim valor = cmd.ExecuteScalar()

                    'Verifico si el medicamento tiene imagen
                    If valor Is Nothing OrElse valor Is DBNull.Value Then
                        pbmedicamentos.Image = Nothing
                        Exit Sub
                    End If

                    'Convierto los bytes en imagen
                    Dim datos() As Byte = DirectCast(valor, Byte())

                    Using memoria As New MemoryStream(datos)
                        Using temporal As Image = Image.FromStream(memoria)

                            If pbmedicamentos.Image IsNot Nothing Then
                                pbmedicamentos.Image.Dispose()
                            End If

                            pbmedicamentos.Image = New Bitmap(temporal)

                        End Using
                    End Using

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message)
        End Try

    End Sub


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
    'Private Sub cargarcombos()
    '    'cargo combo de laboratorios
    '    Try
    '        Using cn As New MySqlConnection(CADENA)
    '            cn.Open()
    '            Dim consulta As String = "SELECT id_laboratorio, nombre FROM laboratorio ORDER BY id_laboratorio"
    '            Using cmd As New MySqlCommand(consulta, cn)
    '                Dim tabla As New DataTable
    '                Using lector As MySqlDataReader = cmd.ExecuteReader
    '                    tabla.Load(lector)
    '                End Using
    '                cblaboratorio.DataSource = tabla
    '                cblaboratorio.DisplayMember = "nombre"
    '                cblaboratorio.ValueMember = "id_laboratorio"
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar el combo de laboratorios: " & ex.Message)
    '    End Try

    '    'cargo combo de drogas
    '    Try
    '        Using cn As New MySqlConnection(CADENA)
    '            cn.Open()
    '            Dim consulta As String = "SELECT id_droga, nombre FROM droga ORDER BY id_droga"
    '            Using cmd As New MySqlCommand(consulta, cn)
    '                Dim tabla As New DataTable
    '                Using lector As MySqlDataReader = cmd.ExecuteReader
    '                    tabla.Load(lector)
    '                End Using
    '                'cargo el combo de drogas
    '                cbdroga.DataSource = tabla
    '                cbdroga.DisplayMember = "nombre"
    '                cbdroga.ValueMember = "id_droga"
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar el combo de drogas: " & ex.Message)
    '    End Try

    '    'cargo combo de acciones terapeuticas
    '    Try
    '        Using cn As New MySqlConnection(CADENA)
    '            cn.Open()
    '            Dim consulta As String = "SELECT id_accion, nombre FROM accion_terapeutica ORDER BY id_accion"
    '            Using cmd As New MySqlCommand(consulta, cn)
    '                Dim tabla As New DataTable
    '                Using lector As MySqlDataReader = cmd.ExecuteReader
    '                    tabla.Load(lector)
    '                End Using
    '                'cargo el combo de acciones terapeuticas
    '                cbterapeutica.DataSource = tabla
    '                cbterapeutica.DisplayMember = "nombre"
    '                cbterapeutica.ValueMember = "id_accion"
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar el combo de acciones terapeuticas: " & ex.Message)
    '    End Try

    '    'cargo combo de presentaciones
    '    Try
    '        Using cn As New MySqlConnection(CADENA)
    '            cn.Open()
    '            Dim consulta As String = "SELECT id_presentacion, descripcion FROM presentacion ORDER BY id_presentacion"
    '            Using cmd As New MySqlCommand(consulta, cn)
    '                Dim tabla As New DataTable
    '                Using lector As MySqlDataReader = cmd.ExecuteReader
    '                    tabla.Load(lector)
    '                End Using
    '                'cargo el combo de presentaciones
    '                cbpresentacion.DataSource = tabla
    '                cbpresentacion.DisplayMember = "descripcion"
    '                cbpresentacion.ValueMember = "id_presentacion"
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar el combo de presentaciones: " & ex.Message)
    '    End Try

    '    'cargo combo de acciones terapeuticas
    '    Try
    '        Using cn As New MySqlConnection(CADENA)
    '            cn.Open()
    '            Dim consulta As String = "SELECT id_accion, nombre FROM accion_terapeutica ORDER BY nombre"
    '            Using cmd As New MySqlCommand(consulta, cn)
    '                Dim tabla As New DataTable
    '                Using lector As MySqlDataReader = cmd.ExecuteReader
    '                    tabla.Load(lector)
    '                End Using
    '                'cargo el combo de acciones terapeuticas
    '                cbterapeutica.DataSource = tabla
    '                cbterapeutica.DisplayMember = "nombre"
    '                cbterapeutica.ValueMember = "id_accion"
    '            End Using
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargarmedicamentos()

        limpiarform()

        Estilos.EstilizarGrilla(dgvmedicamento) 'llamo al estilo 

        Me.BackColor = Color.FromArgb(244, 247, 246)
        Estilos.EstilizarCampos(Me)

        'estiliza los group box 
        EstilizarGroupBox(GroupBox2)
        EstilizarGroupBox(GroupBox1)
        EstilizarGroupBox(GroupBox3)

        'estiliza los botones 
        EstilizarBoton(btnagregar, ColorMenu)
        EstilizarBoton(btneliminar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificar, ColorActivo)
        EstilizarBoton(btnlimpiar, Color.FromArgb(90, 160, 145))

        EstilizarBoton(btnbuscar, ColorMenu)
        EstilizarBoton(btnguardar_ima, Color.FromArgb(0, 150, 136))
        EstilizarBoton(btnquitar_ima, Color.FromArgb(220, 80, 100))

        EstilizarBoton(btnagregarlab, ColorMenu)
        EstilizarBoton(btneliminarlab, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificarlab, ColorActivo)

        EstilizarBoton(btnagregarpres, ColorMenu)
        EstilizarBoton(btneliminarpres, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificarpres, ColorActivo)

        EstilizarBoton(btnagregaraccion, ColorMenu)
        EstilizarBoton(btneliminaraccion, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificaraccion, ColorActivo)

        EstilizarBoton(btnagregardroga, ColorMenu)
        EstilizarBoton(btneliminardroga, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodificardroga, ColorActivo)

        'cargar los combos
        moduloauxiliares.cargarcombolab(cblaboratorio)
        moduloauxiliares.cargarcombolab(cbabmlab)

        moduloauxiliares.cargarcomboaccion(cbterapeutica)
        moduloauxiliares.cargarcomboaccion(cbabmaccion)

        moduloauxiliares.cargarComboPresentacion(cbabmpres)
        moduloauxiliares.cargarComboPresentacion(cbpresentacion)

        moduloauxiliares.cargarComboDroga(cbabmdroga)
        moduloauxiliares.cargarComboDroga(cbdroga)

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

            'Cargar la imagen del medicamento seleccionado
            CargarImagen(CInt(txtid.Text))

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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"

            If dlg.ShowDialog() = DialogResult.OK Then
                Using temporal As Image = Image.FromFile(dlg.FileName)
                    If pbmedicamentos.Image IsNot Nothing Then
                        pbmedicamentos.Image.Dispose()
                    End If

                    pbmedicamentos.Image = New Bitmap(temporal)
                End Using
            End If
        End Using
    End Sub

    Private Sub btnguardar_ima_Click(sender As Object, e As EventArgs) Handles btnguardar_ima.Click
        'Verifico que haya un medicamento seleccionado
        If txtid.Text = "" Then
            MessageBox.Show("Seleccioná un medicamento primero")
            Exit Sub
        End If

        'Verifico que haya una imagen
        If pbmedicamentos.Image Is Nothing Then
            MessageBox.Show("Primero seleccioná una imagen")
            Exit Sub
        End If

        Dim datos() As Byte = ImagenaBytes(pbmedicamentos.Image)

        'Limito el tamaño a 1 MB
        If datos.Length > 1000000 Then
            MessageBox.Show("La imagen no puede superar 1 MB")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
                "UPDATE medicamento SET imagen = @imagen " &
                "WHERE id_medicamento = @id;"

                Using cmd As New MySqlCommand(sql, cn)

                    cmd.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = datos
                    cmd.Parameters.AddWithValue("@id", CInt(txtid.Text))

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Imagen guardada correctamente")
                    Else
                        MessageBox.Show("No se encontró el medicamento")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar la imagen: " & ex.Message)
        End Try

    End Sub

    Private Sub btnquitar_ima_Click(sender As Object, e As EventArgs) Handles btnquitar_ima.Click
        'Verifico que haya un medicamento seleccionado
        If txtid.Text = "" Then
            MessageBox.Show("Seleccioná un medicamento primero")
            Exit Sub
        End If

        'Confirmo la eliminación
        If MessageBox.Show("¿Querés quitar la imagen de este medicamento?",
                       "Confirmar",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
                "UPDATE medicamento SET imagen = NULL " &
                "WHERE id_medicamento = @id;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtid.Text))
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            'Limpio el PictureBox
            If pbmedicamentos.Image IsNot Nothing Then
                pbmedicamentos.Image.Dispose()
                pbmedicamentos.Image = Nothing
            End If

            MessageBox.Show("Imagen quitada correctamente")

        Catch ex As Exception
            MessageBox.Show("Error al quitar la imagen: " & ex.Message)
        End Try

    End Sub
    Private Sub mostrarpanelauxiliar(pnlmostrar As Panel)
        'hacer visible el panel padre
        pnlcontenedorabm.Visible = True

        'ocultar los paneles hijos
        pnllaboratorio.Visible = False
        pnlpresentacion.Visible = False
        pnlabmaccion.Visible = False
        pnlabmdroga.Visible = False

        'mostrar el panel que el usuario quiera ocupar
        pnlmostrar.Visible = True
        pnlmostrar.BringToFront()
    End Sub
    Private Sub btnmaslaboratorio_Click(sender As Object, e As EventArgs) Handles btnmaslaboratorio.Click
        'abrir el abm de laboratorios
        mostrarpanelauxiliar(pnllaboratorio)
        txtabmlab.Clear()
        txtabmlab.Focus()
    End Sub


    Private Sub btnmaspres_Click(sender As Object, e As EventArgs) Handles btnmaspres.Click
        'abrir el abm de presentaciones
        mostrarpanelauxiliar(pnlpresentacion)

        txtabmpresentacion.Clear()
        txtabmpresentacion.Focus()
    End Sub

    Private Sub btnmasaccion_Click(sender As Object, e As EventArgs) Handles btnmasaccion.Click
        'abrir el abm de acciones terapeuticas
        mostrarpanelauxiliar(pnlabmaccion)

        txtabmaccion.Clear()
        txtabmaccion.Focus()

    End Sub

    Private Sub btnmasdroga_Click(sender As Object, e As EventArgs) Handles btnmasdroga.Click
        'abrir el abm de drogas
        mostrarpanelauxiliar(pnlabmdroga)

        txtabmdroga.Clear()
        txtabmdroga.Focus()
    End Sub

    Private Sub btnagregarlab_Click(sender As Object, e As EventArgs) Handles btnagregarlab.Click
        'verifico que este cargado el txt del abmlab
        If txtabmlab.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese el nombre del laboratorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que guarda el laboratorio en la base de datos
            If moduloauxiliares.guardarlaboratorio(txtabmlab.Text.Trim()) Then
                MessageBox.Show("Laboratorio agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarcombolab(cblaboratorio)
                moduloauxiliares.cargarcombolab(cbabmlab)
                txtabmlab.Clear()
            Else
                MessageBox.Show("Error al agregar el laboratorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub btnagregaraccion_Click(sender As Object, e As EventArgs) Handles btnagregaraccion.Click
        'verifico que el txt este cargado
        If txtabmaccion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese el nombre de la acción terapéutica.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que guarda la accion terapeutica en la base de datos
            If moduloauxiliares.guardaraccion(txtabmaccion.Text.Trim()) Then
                MessageBox.Show("Acción terapéutica agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarcomboaccion(cbterapeutica)
                moduloauxiliares.cargarcomboaccion(cbabmaccion)
                txtabmaccion.Clear()
            Else
                MessageBox.Show("Error al agregar la acción terapéutica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnagregardroga_Click(sender As Object, e As EventArgs) Handles btnagregardroga.Click
        'verifico que el txt este cargado
        If txtabmdroga.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese el nombre de la droga.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que guarda la droga en la base de datos
            If moduloauxiliares.guardarDroga(txtabmdroga.Text.Trim()) Then
                MessageBox.Show("Droga agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarComboDroga(cbdroga)
                moduloauxiliares.cargarComboDroga(cbabmdroga)
                txtabmdroga.Clear()
            Else
                MessageBox.Show("Error al agregar la droga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnagregarpres_Click(sender As Object, e As EventArgs) Handles btnagregarpres.Click
        'verifico que el txt este cargado
        If txtabmpresentacion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese el nombre de la presentación.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que guarda la presentacion en la base de datos
            If moduloauxiliares.guardarPresentacion(txtabmpresentacion.Text.Trim()) Then
                MessageBox.Show("Presentación agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarComboPresentacion(cbpresentacion)
                moduloauxiliares.cargarComboPresentacion(cbabmpres)
                txtabmpresentacion.Clear()
            Else
                MessageBox.Show("Error al agregar la presentación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnmodificaraccion_Click(sender As Object, e As EventArgs) Handles btnmodificaraccion.Click
        'verifico el el txt este cargado y que haya seleccionado un item del combo
        If cbabmpres.SelectedValue Is Nothing OrElse txtabmaccion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, seleccione una acción terapéutica y asegúrese de que el nombre no esté vacío.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que modifica la accion terapeutica en la base de datos
            Dim id As Integer = Convert.ToInt32(cbabmaccion.SelectedValue)
            If moduloauxiliares.modificaraccion(id, txtabmaccion.Text.Trim()) Then
                MessageBox.Show("Presentación modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarComboPresentacion(cbabmaccion)
                moduloauxiliares.cargarComboPresentacion(cbterapeutica)
                txtabmaccion.Clear()
            End If
        End If
    End Sub

    Private Sub btnmodificardroga_Click(sender As Object, e As EventArgs) Handles btnmodificardroga.Click
        'verifico que el txt este cargado y que haya seleccionado un item del combo
        If cbabmdroga.SelectedValue Is Nothing OrElse txtabmdroga.Text.Trim() = "" Then
            MessageBox.Show("Por favor, seleccione una droga y asegúrese de que el nombre no esté vacío.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que modifica la droga en la base de datos
            Dim id As Integer = Convert.ToInt32(cbabmdroga.SelectedValue)
            If moduloauxiliares.modificarDroga(id, txtabmdroga.Text.Trim()) Then
                MessageBox.Show("Droga modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarComboDroga(cbabmdroga)
                moduloauxiliares.cargarComboDroga(cbdroga)
                txtabmdroga.Clear()
            End If
        End If
    End Sub

    Private Sub btnmodificarlab_Click(sender As Object, e As EventArgs) Handles btnmodificarlab.Click
        'verifico que el txt este cargado y que haya seleccionado un item del combo
        If cbabmlab.SelectedValue Is Nothing OrElse txtabmlab.Text.Trim() = "" Then
            MessageBox.Show("Por favor, seleccione un laboratorio y asegúrese de que el nombre no esté vacío.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que modifica el laboratorio en la base de datos
            Dim id As Integer = Convert.ToInt32(cbabmlab.SelectedValue)
            If moduloauxiliares.modificarlaboratorio(id, txtabmlab.Text.Trim()) Then
                MessageBox.Show("Laboratorio modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarcombolab(cbabmlab)
                moduloauxiliares.cargarcombolab(cblaboratorio)
                txtabmlab.Clear()
            End If
        End If
    End Sub

    Private Sub btnmodificarpres_Click(sender As Object, e As EventArgs) Handles btnmodificarpres.Click
        'verifico que el txt este cargado y que haya seleccionado un item del combo
        If cbabmpres.SelectedValue Is Nothing OrElse txtabmpresentacion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, seleccione una presentación y asegúrese de que el nombre no esté vacío.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
            'llamo a la funcion que modifica la presentacion en la base de datos
            Dim id As Integer = Convert.ToInt32(cbabmpres.SelectedValue)
            If moduloauxiliares.modificarPresentacion(id, txtabmpresentacion.Text.Trim()) Then
                MessageBox.Show("Presentación modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                moduloauxiliares.cargarComboPresentacion(cbabmpres)
                moduloauxiliares.cargarComboPresentacion(cbpresentacion)
                txtabmpresentacion.Clear()
            End If
        End If
    End Sub

    Private Sub btneliminaraccion_Click(sender As Object, e As EventArgs) Handles btneliminaraccion.Click
        'verifico que haya seleccionado un item del combo
        If cbabmaccion.SelectedValue Is Nothing Then Exit Sub
        'llamo a la funcion que elimina la accion terapeutica en la base de datos
        Dim id As Integer = Convert.ToInt32(cbabmaccion.SelectedValue)
        If moduloauxiliares.eliminaraccion(id) Then
            MessageBox.Show("Acción terapéutica eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            moduloauxiliares.cargarcomboaccion(cbabmaccion)
            moduloauxiliares.cargarcomboaccion(cbterapeutica)
            txtabmaccion.Clear()
        End If
    End Sub

    Private Sub btneliminardroga_Click(sender As Object, e As EventArgs) Handles btneliminardroga.Click
        'verifico que haya seleccionado un item del combo
        If cbabmdroga.SelectedValue Is Nothing Then Exit Sub
        'llamo a la funcion que elimina la droga en la base de datos
        Dim id As Integer = Convert.ToInt32(cbabmdroga.SelectedValue)
        If moduloauxiliares.eliminarDroga(id) Then
            MessageBox.Show("Droga eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            moduloauxiliares.cargarComboDroga(cbabmdroga)
            moduloauxiliares.cargarComboDroga(cbdroga)
            txtabmdroga.Clear()
        End If
    End Sub

    Private Sub btneliminarlab_Click(sender As Object, e As EventArgs) Handles btneliminarlab.Click
        'verifico que haya seleccionado un item del combo
        If cbabmlab.SelectedValue Is Nothing Then Exit Sub
        'llamo a la funcion que elimina el laboratorio en la base de datos
        Dim id As Integer = Convert.ToInt32(cbabmlab.SelectedValue)
        If moduloauxiliares.eliminarlaboratorio(id) Then
            MessageBox.Show("Laboratorio eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            moduloauxiliares.cargarcombolab(cbabmlab)
            moduloauxiliares.cargarcombolab(cblaboratorio)
            txtabmlab.Clear()
        End If
    End Sub

    Private Sub btneliminarpres_Click(sender As Object, e As EventArgs) Handles btneliminarpres.Click
        'verifico que haya seleccionado un item del combo
        If cbabmpres.SelectedValue Is Nothing Then Exit Sub
        'llamo a la funcion que elimina la presentacion en la base de datos
        Dim id As Integer = Convert.ToInt32(cbabmpres.SelectedValue)
        If moduloauxiliares.eliminarPresentacion(id) Then
            MessageBox.Show("Presentación eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            moduloauxiliares.cargarComboPresentacion(cbabmpres)
            moduloauxiliares.cargarComboPresentacion(cbpresentacion)
            txtabmpresentacion.Clear()
        End If
    End Sub

    Private Sub btncerrarlab_Click(sender As Object, e As EventArgs) Handles btncerrarlab.Click
        'cierro el panel de laboratorio
        pnlcontenedorabm.Visible = False
        pnllaboratorio.Visible = False
    End Sub

    Private Sub btncerrarpres_Click(sender As Object, e As EventArgs) Handles btncerrarpres.Click
        'cierro el panel de presentación
        pnlpresentacion.Visible = False
        pnlcontenedorabm.Visible = False
    End Sub
    Private Sub btncerrardroga_Click(sender As Object, e As EventArgs) Handles btncerrardroga.Click
        'cierro el panel de droga
        pnlcontenedorabm.Visible = False
        pnlabmdroga.Visible = False
    End Sub
    Private Sub btncerraraccion_Click(sender As Object, e As EventArgs) Handles btncerraraccion.Click
        'cierro el panel de acción
        pnlcontenedorabm.Visible = False
        pnlabmaccion.Visible = False
    End Sub

    Private Sub btnficha_Click(sender As Object, e As EventArgs) Handles btnficha.Click
        Using vistaPrevia As New PrintPreviewDialog()

            vistaPrevia.Document = PrintDocument1
            vistaPrevia.WindowState = FormWindowState.Maximized
            vistaPrevia.ShowDialog()

        End Using

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g = e.Graphics

        ' Fuentes
        Using titulo As New Font("Segoe UI", 22, FontStyle.Bold),
          subtitulo As New Font("Segoe UI", 10, FontStyle.Regular),
          seccion As New Font("Segoe UI", 12, FontStyle.Bold),
          texto As New Font("Segoe UI", 10, FontStyle.Regular),
          etiqueta As New Font("Segoe UI", 9, FontStyle.Bold)

            ' Colores
            Dim verde As Color = Color.FromArgb(22, 140, 136)
            Dim gris As Color = Color.FromArgb(90, 100, 110)
            Dim fondo As Color = Color.FromArgb(240, 247, 246)

            Using pincelVerde As New SolidBrush(verde),
              pincelGris As New SolidBrush(gris),
              pincelFondo As New SolidBrush(fondo),
              pincelNegro As New SolidBrush(Color.Black),
              lapizGris As New Pen(Color.LightGray, 1)

                Dim x As Integer = 65
                Dim ancho As Integer = 700

                ' ENCABEZADO
                g.DrawString("FARMACIA", titulo, pincelVerde, x, 45)
                g.DrawString("Sistema de gestión de medicamentos",
                         subtitulo, pincelGris, x, 83)

                g.DrawString("FICHA DE MEDICAMENTO",
                         seccion, pincelNegro, 390, 52)

                g.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"),
                         texto, pincelGris, 390, 78)

                g.DrawLine(New Pen(verde, 3), x, 115, x + ancho, 115)

                ' DATOS GENERALES
                g.DrawString("DATOS DEL MEDICAMENTO",
                         seccion, pincelVerde, x, 135)

                ' Imagen del medicamento
                Dim rectImagen As New Rectangle(555, 175, 155, 155)
                g.DrawRectangle(lapizGris, rectImagen)

                If pbmedicamentos.Image IsNot Nothing Then
                    g.DrawImage(pbmedicamentos.Image, rectImagen)
                Else
                    g.DrawString("Sin imagen", texto, pincelGris,
                             rectImagen.X + 35, rectImagen.Y + 65)
                End If

                ' Datos alineados verticalmente a la izquierda
                Dim y As Integer = 180
                Dim salto As Integer = 32

                g.DrawString("Código: " & txtcodigo.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("ID: " & txtid.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("Nombre: " & txtnombre.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("Droga: " & cbdroga.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("Laboratorio: " & cblaboratorio.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("Presentación: " & cbpresentacion.Text,
                         texto, pincelNegro, x, y)
                y += salto

                g.DrawString("Uso terapéutico: " & cbterapeutica.Text,
                         texto, pincelNegro, x, y)

                ' CONTROL DE STOCK
                Dim yStock As Integer = 430

                g.DrawString("CONTROL DE STOCK",
                         seccion, pincelVerde, x, yStock)

                yStock += 35

                Dim anchoCaja As Integer = 215
                Dim altoCaja As Integer = 75
                Dim separacion As Integer = 15

                Dim stockMin As New Rectangle(x, yStock, anchoCaja, altoCaja)
                Dim stockMax As New Rectangle(x + anchoCaja + separacion,
                                          yStock, anchoCaja, altoCaja)
                Dim puntoPedido As New Rectangle(
                x + (anchoCaja + separacion) * 2, yStock,
                anchoCaja, altoCaja)

                g.FillRectangle(pincelFondo, stockMin)
                g.FillRectangle(pincelFondo, stockMax)
                g.FillRectangle(pincelFondo, puntoPedido)

                g.DrawRectangle(lapizGris, stockMin)
                g.DrawRectangle(lapizGris, stockMax)
                g.DrawRectangle(lapizGris, puntoPedido)

                g.DrawString("STOCK MÍNIMO", etiqueta,
                         pincelGris, stockMin.X + 12, stockMin.Y + 10)
                g.DrawString(nudstockmin.Value.ToString(),
                         titulo, pincelNegro, stockMin.X + 12, stockMin.Y + 30)

                g.DrawString("STOCK MÁXIMO", etiqueta,
                         pincelGris, stockMax.X + 12, stockMax.Y + 10)
                g.DrawString(nudstockmax.Value.ToString(),
                         titulo, pincelNegro, stockMax.X + 12, stockMax.Y + 30)

                g.DrawString("PUNTO DE PEDIDO", etiqueta,
                         pincelGris, puntoPedido.X + 12, puntoPedido.Y + 10)
                g.DrawString(nudpedido.Value.ToString(),
                         titulo, pincelNegro, puntoPedido.X + 12, puntoPedido.Y + 30)

                ' PIE DE PÁGINA
                Dim yPie As Integer = 650

                g.DrawLine(lapizGris, x, yPie, x + ancho, yPie)

                g.DrawString("Documento informativo de control interno",
                         subtitulo, pincelGris, x, yPie + 12)

                g.DrawString("Farmacia | Ficha de medicamento",
                         subtitulo, pincelGris, x + 420, yPie + 12)

            End Using
        End Using

        e.HasMorePages = False

    End Sub
End Class