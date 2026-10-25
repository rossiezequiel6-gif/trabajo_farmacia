Imports MySqlConnector
Module Modulousuario
    'cargar grilla de usuario (solo activos: estado = 1)
    Public Sub cargargrillausuarios(dgv As DataGridView, Optional filtro As String = "")
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT u.id_usuario, u.nombre_usuario, u.nombre_completo, u.estado, u.id_rol, r.nombre AS rol " &
                                    "FROM usuario u " &
                                    "INNER JOIN rol r ON u.id_rol = r.id_rol " &
                                    "WHERE u.estado = 1 "
                If filtro.Trim() <> "" Then
                    sql &= "AND (u.nombre_usuario LIKE @filtro OR u.nombre_completo LIKE @filtro)"
                End If
                sql &= "ORDER BY u.nombre_usuario, u.nombre_completo ASC;"
                Using cmd As New MySqlCommand(sql, cn)
                    If filtro.Trim() <> "" Then
                        cmd.Parameters.AddWithValue("@filtro", "%" & filtro.Trim() & "%")
                    End If
                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    dgv.DataSource = dt

                    'ocultar columnas internas de id
                    If dgv.Columns.Contains("id_usuario") Then
                        dgv.Columns("id_usuario").Visible = False
                    End If
                    If dgv.Columns.Contains("id_rol") Then
                        dgv.Columns("id_rol").Visible = False
                    End If
                    If dgv.Columns.Contains("estado") Then
                        dgv.Columns("estado").Visible = False
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar lista de usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'cargar combobox de roles
    Public Sub cargarcomboroles(cbo As ComboBox)
        Try
            Dim dt As New DataTable()
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT id_rol, nombre FROM rol ORDER BY nombre ASC"
                Using da As New MySqlDataAdapter(sql, cn)
                    da.Fill(dt)
                End Using
            End Using
            cbo.DataSource = dt
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "id_rol"
            cbo.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'guardar nuevo usuario
    Public Function guardarusuario(nombreusuario As String, nombrecompleto As String, clave As String, idrol As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO usuario (nombre_usuario, nombre_completo, clave_hash, estado, id_rol) " &
                                    "VALUES (@nombreusuario, @nombrecompleto, SHA2(@clave, 256), 1, @rol)"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombreusuario", nombreusuario)
                    cmd.Parameters.AddWithValue("@nombrecompleto", nombrecompleto)
                    cmd.Parameters.AddWithValue("@clave", clave)
                    cmd.Parameters.AddWithValue("@rol", idrol)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    'modificar usuario existente
    Public Function modificarusuario(idusuario As Integer, nombreusuario As String, nombrecompleto As String, idrol As Integer, Optional nuevaclave As String = "") As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = ""
                If nuevaclave.Trim() <> "" Then
                    sql = "UPDATE usuario SET nombre_usuario = @nombreusuario, nombre_completo = @nombrecompleto, clave_hash = SHA2(@clave, 256), id_rol = @rol WHERE id_usuario = @idusuario"
                Else
                    sql = "UPDATE usuario SET nombre_usuario = @nombreusuario, nombre_completo = @nombrecompleto, id_rol = @rol WHERE id_usuario = @idusuario;"
                End If
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombreusuario", nombreusuario)
                    cmd.Parameters.AddWithValue("@nombrecompleto", nombrecompleto)
                    cmd.Parameters.AddWithValue("@rol", idrol)
                    cmd.Parameters.AddWithValue("@idusuario", idusuario)
                    If nuevaclave.Trim() <> "" Then
                        cmd.Parameters.AddWithValue("@clave", nuevaclave)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    'baja logica de usuario (estado = 0)
    Public Function eliminarusuario(idusuario As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE usuario SET estado = 0 WHERE id_usuario = @idusuario"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@idusuario", idusuario)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    'validar credenciales de login 
    Public Function ValidarLogin(usuario As String, clave As String, ByRef idUser As Integer, ByRef nombreCompleto As String, ByRef nombreRol As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT u.idusuario, u.nombre_completo, r.nombre AS rol " &
                                    "FROM usuario u " &
                                    "INNER JOIN rol r ON u.id_rol r.id_rol " &
                                    "WHERE u.nombre_usuario = @usuario AND u.clave_hash = SHA2(@clave, 256) AND u.estado = 1;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@usuario", usuario.Trim())
                    cmd.Parameters.AddWithValue("@clave", clave.Trim())

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            idUser = Convert.ToInt32(dr("id_usuario"))
                            nombreCompleto = ("nombre_completo").ToString()
                            nombreRol = dr("@rol").ToString()
                            Return True
                        Else
                            Return False
                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
