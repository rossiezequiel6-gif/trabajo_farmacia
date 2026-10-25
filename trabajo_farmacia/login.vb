
Imports MySqlConnector
Public Class login


    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        ' 1\. Validar ingreso de datos
        If txtusuario.Text.Trim() = "" OrElse txtclave.Text.Trim() = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                ' Consulta SQL con nombre_completo y salt
                Dim sql As String = "SELECT usr.id_usuario, usr.nombre_usuario, usr.nombre_completo, usr.clave_hash, usr.salt, " &
                    "usr.id_rol, rol.nombre AS roles " &
                "FROM usuario AS usr " &
                "JOIN rol ON usr.id_rol = rol.id_rol " &
                "WHERE usr.nombre_usuario = @usuario AND usr.estado = 1;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@usuario", txtusuario.Text.Trim())

                    Using rd As MySqlDataReader = cmd.ExecuteReader()

                        ' Si rd no tiene filas, el usuario no existe o está inactivo
                        If Not rd.Read() Then
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        ' Leer el hash y el salt de la base de datos
                        Dim hashBD As String = rd("clave_hash").ToString()
                        Dim saltBD As String = rd("salt").ToString()

                        ' Crear hash de la contraseña ingresada usando el salt
                        Dim hashIngresado As String = Seguridad.CrearHash(txtclave.Text.Trim(), saltBD)

                        ' Comparar contraseñas
                        If hashIngresado <> hashBD Then
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        Dim iduser As Integer = Convert.ToInt32(rd("id_usuario"))
                        Dim nombreuser As String = rd("nombre_usuario").ToString()
                        Dim roluser As String = rd("roles").ToString()

                        Modulosesion.iniciarsesion(iduser, nombreuser, roluser)

                        ' 2\. Cargar variables de sesión
                        sesion.idUsuario = Convert.ToInt32(rd("id_usuario"))
                        sesion.nombreUsuario = rd("nombre_usuario").ToString()
                        sesion.rolUsuario = rd("roles").ToString()
                        sesion.NombreCompleto = rd("nombre_completo").ToString()

                        ' 3\. Abrir formulario principal y ocultar login
                        Form1.Show()
                        Me.Hide()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnverclave_Click(sender As Object, e As EventArgs) Handles btnverclave.Click
        If txtclave.UseSystemPasswordChar = True Then
            txtclave.UseSystemPasswordChar = False
            btnverclave.Text = ""
        Else
            ' Si está visible, la volvemos a ocultar
            txtclave.UseSystemPasswordChar = True
            btnverclave.Text = ""
        End If
    End Sub
End Class