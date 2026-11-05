
Imports System.Drawing.Drawing2D
Imports MySqlConnector

Public Class login

    Private Function RegionDerecha(w As Single, h As Single, dTop As Single, dMid As Single, dBot As Single) As GraphicsPath
        Dim p As New GraphicsPath()
        p.AddBezier(w * (0.645F - dTop), 0, w * (0.52F - dTop), h * 0.1F, w * (0.46F - dMid), h * 0.32F, w * (0.49F - dMid), h * 0.5F)
        p.AddBezier(w * (0.49F - dMid), h * 0.5F, w * (0.53F - dMid), h * 0.68F, w * (0.5F - dBot), h * 0.85F, w * (0.51F - dBot), h)
        p.AddLine(w, h, w, 0)
        p.CloseFigure()
        Return p
    End Function


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

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatosConexion()
        btningresar.BackColor = Color.FromArgb(0, 128, 118)
        btningresar.ForeColor = Color.White

        picfarmacia.Dock = DockStyle.Fill

        For Each c As Control In Panel3.Controls.Cast(Of Control).ToList()
            Dim pos = picfarmacia.PointToClient(c.PointToScreen(Point.Empty))
            c.Parent = picfarmacia
            c.Location = pos
        Next
        Panel3.Visible = False
    End Sub


    Private Sub login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            txtusuario.Clear()
            txtclave.Clear()
            txtclave.UseSystemPasswordChar = True
            txtusuario.Focus()
        End If


    End Sub

    Private Sub picfarmacia_Click(sender As Object, e As EventArgs) Handles picfarmacia.Click

    End Sub


    Private Sub picfarmacia_Paint(sender As Object, e As PaintEventArgs) Handles picfarmacia.Paint

        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim w As Single = picfarmacia.Width
        Dim h As Single = picfarmacia.Height

        Using fondo As New LinearGradientBrush(picfarmacia.ClientRectangle, Color.White, Color.FromArgb(220, 246, 243), LinearGradientMode.Horizontal)
            g.FillRectangle(fondo, picfarmacia.ClientRectangle)
        End Using

        Using p = RegionDerecha(w, h, 0.17F, 0.05F, 0.2F),
          b As New LinearGradientBrush(p.GetBounds(), Color.FromArgb(200, 112, 224, 211), Color.FromArgb(255, 112, 224, 211), LinearGradientMode.Horizontal)
            g.FillPath(b, p)
        End Using

        Using p = RegionDerecha(w, h, 0.115F, 0.03F, 0.08F), b As New SolidBrush(Color.FromArgb(255, 22, 177, 164))
            g.FillPath(b, p)
        End Using

        Using p = RegionDerecha(w, h, 0, 0, 0)
            g.SetClip(p)
            g.DrawImage(picfarmacia.Image, 0, 0, w, h)
            g.ResetClip()
        End Using

    End Sub

    Private Sub picfarmacia_Resize(sender As Object, e As EventArgs) Handles picfarmacia.Resize
        picfarmacia.Invalidate()
    End Sub
End Class