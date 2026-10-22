Imports MySqlConnector
Module moduloauxiliares
    'guardar, modificar y eliminar laboratorio
    Public Function guardarlaboratorio(nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO laboratorio (nombre) VALUES (@nombre);"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar laboratorio: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function modificarlaboratorio(id As Integer, nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE laboratorio SET nombre = @nombre WHERE id = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar laboratorio: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function eliminarlaboratorio(id As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE laboratorio SET estado = 0 WHERE id_laboratorio = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar laboratorio: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub cargarcombolab(cbo As ComboBox)
        Try
            Dim dt As New DataTable
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT id_laboratorio, nombre FROM laboratorio WHERE estado = 1;"
                Using cmd As New MySqlCommand(sql, cn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            cbo.DataSource = dt
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "id_laboratorio"

        Catch ex As Exception
            MessageBox.Show("Error al cargar combo laboratorio: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'guardar, modificar y eliminar presentacion
    Public Function guardarPresentacion(nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO presentacion (nombre) VALUES (@nombre);"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar presentación: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function modificarPresentacion(id As Integer, nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE presentacion SET nombre = @nombre WHERE id_presentacion = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar presentación: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function eliminarPresentacion(id As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE presentacion SET estado = 0 WHERE id_presentacion = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar presentación: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub cargarComboPresentacion(cbo As ComboBox)
        Try
            Dim dt As New DataTable
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT id_presentacion, descripcion FROM presentacion WHERE estado = 1;"
                Using cmd As New MySqlCommand(sql, cn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            cbo.DataSource = dt
            cbo.DisplayMember = "descripcion"
            cbo.ValueMember = "id_presentacion"

        Catch ex As Exception
            MessageBox.Show("Error al cargar combo presentación: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'guardar, modificar y eliminar droga
    Public Function guardarDroga(nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO droga (nombre) VALUES (@nombre);"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar droga: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function modificarDroga(id As Integer, nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE droga SET nombre = @nombre WHERE id_droga = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar droga: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function eliminarDroga(id As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE droga SET estado = 0 WHERE id_droga = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar droga: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub cargarComboDroga(cbo As ComboBox)
        Try
            Dim dt As New DataTable
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT id_droga, nombre FROM droga WHERE estado = 1;"
                Using cmd As New MySqlCommand(sql, cn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            cbo.DataSource = dt
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "id_droga"

        Catch ex As Exception
            MessageBox.Show("Error al cargar combo droga: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'agregar, modificar y eliminar acción terapéutica
    Public Function guardaraccion(nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO accion_terapeutica (nombre) VALUES (@nombre);"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar la acción terapéutica: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function modificaraccion(id As Integer, nombre As String) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE accion_terapeutica SET nombre = @nombre WHERE id_accion = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar la acción terapéutica: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function eliminaraccion(id As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "UPDATE accion_terapeutica SET estado = 0 WHERE id_accion = @id;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la acción terapéutica: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub cargarcomboaccion(cbo As ComboBox)
        Try
            Dim dt As New DataTable
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT id_accion, nombre FROM accion_terapeutica WHERE estado = 1;"
                Using cmd As New MySqlCommand(sql, cn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            cbo.DataSource = dt
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "id_accion"

        Catch ex As Exception
            MessageBox.Show("Error al cargar acciones terapéuticas: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
