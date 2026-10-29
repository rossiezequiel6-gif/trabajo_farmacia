Imports System.IO
Imports MySqlConnector
Imports System.Drawing.Printing
Imports System.Drawing.Imaging

Public Class Formusuarios


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



    Dim idusuarioseleccionado As Integer = 0


    Private Sub CargarImagenUsuario(id As Integer)

        ' Limpio la imagen anterior
        If pbusuarios.Image IsNot Nothing Then
            pbusuarios.Image.Dispose()
            pbusuarios.Image = Nothing
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
                "SELECT imagen FROM usuario WHERE id_usuario = @id"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Dim resultado As Object = cmd.ExecuteScalar()

                    ' Verifico si el usuario tiene imagen
                    If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then

                        Dim datos() As Byte = DirectCast(resultado, Byte())

                        Using ms As New MemoryStream(datos)
                            Using temporal As Image = Image.FromStream(ms)
                                pbusuarios.Image = New Bitmap(temporal)
                            End Using
                        End Using

                        pbusuarios.SizeMode = PictureBoxSizeMode.Zoom

                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message)
        End Try

    End Sub
    Private Sub Formusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillausuarios(dgvusuarios)
        cargarcomboroles(cbrol)
        limpiarcampos()
        Estilos.EstilizarGrilla(dgvusuarios)

        'estilizar botones
        EstilizarBoton(btnguardarusu, ColorMenu)
        EstilizarBoton(btneliminar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodifusu, ColorActivo)
        EstilizarBoton(btnlimpiarusu, Color.FromArgb(90, 160, 145))
    End Sub

    Private Sub limpiarcampos()
        idusuarioseleccionado = 0
        txtclave.Text = ""
        txtusuario.Text = ""
        txtnombrecomp.Text = ""
        cbrol.SelectedIndex = -1
        txtusuario.Focus()
    End Sub

    Private Sub txtbuscarusuario_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarusuario.TextChanged
        cargargrillausuarios(dgvusuarios, txtbuscarusuario.Text.Trim())
    End Sub

    Private Sub dgvusuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuarios.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim fila = dgvusuarios.Rows(e.RowIndex)
        idusuarioseleccionado = Convert.ToInt32(fila.Cells("id_usuario").Value)
        txtusuario.Text = fila.Cells("nombre_usuario").Value.ToString()
        txtnombrecomp.Text = fila.Cells("nombre_completo").Value.ToString()
        cbrol.SelectedValue = fila.Cells("id_rol").Value
        idusuarioseleccionado = CInt(dgvusuarios.Rows(e.RowIndex).Cells("id_usuario").Value)

        idusuarioseleccionado =
      CInt(dgvusuarios.Rows(e.RowIndex).Cells("id_usuario").Value)

        CargarImagenUsuario(idusuarioseleccionado)

    End Sub

    Private Sub btnguardarusu_Click(sender As Object, e As EventArgs) Handles btnguardarusu.Click
        'boton agregar nuevo usuario
        If txtusuario.Text.Trim() = "" OrElse txtnombrecomp.Text.Trim() = "" OrElse txtclave.Text.Trim() = "" OrElse cbrol.SelectedIndex < 0 Then
            MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If guardarusuario(txtusuario.Text.Trim(), txtnombrecomp.Text.Trim(), txtclave.Text.Trim(), Convert.ToInt32(cbrol.SelectedValue)) Then
            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargargrillausuarios(dgvusuarios)
            limpiarcampos()
        End If
    End Sub

    Private Sub btnmodifusu_Click(sender As Object, e As EventArgs) Handles btnmodifusu.Click
        'boton modificar usuario
        If idusuarioseleccionado = 0 Then
            MessageBox.Show("Seleccione un usuario para modificar.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If modificarusuario(idusuarioseleccionado, txtusuario.Text.Trim(), txtnombrecomp.Text.Trim(), Convert.ToInt32(cbrol.SelectedValue), txtclave.Text.Trim) Then
            MessageBox.Show("Datos de usuario actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargargrillausuarios(dgvusuarios)
            limpiarcampos()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'boton eliminar usuario
        If idusuarioseleccionado = 0 Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'evitamos que el admin se elimine a sí mismo
        If idusuarioseleccionado = Modulosesion.idusuarioactual Then
            MessageBox.Show("No puede eliminar el usuario actualmente conectado.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resp As DialogResult = MessageBox.Show("¿Está seguro de que desea dar de baja al usuario '" & txtusuario.Text & "'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            If eliminarusuario(idusuarioseleccionado) Then
                MessageBox.Show("Usuario dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargargrillausuarios(dgvusuarios)
                limpiarcampos()
            End If
        End If
    End Sub

    Private Sub btnlimpiarusu_Click(sender As Object, e As EventArgs) Handles btnlimpiarusu.Click
        limpiarcampos()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            Using dlg As New OpenFileDialog()
                dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"
                dlg.Title = "Seleccionar imagen del usuario"

                If dlg.ShowDialog() = DialogResult.OK Then

                    Using temporal As Image = Image.FromFile(dlg.FileName)

                        If pbusuarios.Image IsNot Nothing Then
                            pbusuarios.Image.Dispose()
                        End If

                        pbusuarios.Image = New Bitmap(temporal)
                        pbusuarios.SizeMode = PictureBoxSizeMode.Zoom

                    End Using

                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If idusuarioseleccionado = 0 Then
            MessageBox.Show("Seleccioná un usuario de la grilla primero")
            Exit Sub
        End If

        If pbusuarios.Image Is Nothing Then
            MessageBox.Show("Primero seleccioná una imagen")
            Exit Sub
        End If

        Dim datos() As Byte = ImagenaBytes(pbusuarios.Image)

        If datos.Length > 1000000 Then
            MessageBox.Show("La imagen no puede superar 1 MB")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
            "UPDATE usuario SET imagen = @imagen WHERE id_usuario = @id;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = datos
                    cmd.Parameters.AddWithValue("@id", idusuarioseleccionado)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Imagen del usuario guardada correctamente")
                    Else
                        MessageBox.Show("No se encontró el usuario")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub btnqitar_Click(sender As Object, e As EventArgs) Handles btnqitar.Click
        ' Verifico que haya un usuario seleccionado
        If txtusuario.Text = "" Then
            MessageBox.Show("Seleccioná un usuario primero")
            Exit Sub
        End If

        ' Confirmo la eliminación
        If MessageBox.Show("¿Querés quitar la imagen de este usuario?",
                           "Confirmar",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String =
                    "UPDATE usuario SET imagen = NULL " &
                    "WHERE id_usuario = @id;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtusuario.Text))

                    Dim filas As Integer = cmd.ExecuteNonQuery()

                    If filas = 0 Then
                        MessageBox.Show("No se encontró el usuario.")
                        Exit Sub
                    End If
                End Using
            End Using

            ' Limpio el PictureBox
            If pbusuarios.Image IsNot Nothing Then
                pbusuarios.Image.Dispose()
                pbusuarios.Image = Nothing
            End If

            MessageBox.Show("Imagen del usuario quitada correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error al quitar la imagen: " & ex.Message)
        End Try
    End Sub
End Class