Imports mysqlconnector
Public Class Form1
    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        'boton para probar conexion a BD
        'try catch intercepta errores
        Try
            'preparo la conexion, declaro el objeto de conexion
            Using CN As New MySqlConnection(CADENA)

                'metodo Open conecta a la BD
                CN.Open()

                MessageBox.Show("CONEXION EXITOSA!!")

            End Using

        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub

    ' Abre un formulario dentro del panel derecho. El menú no se toca.
    Sub AbrirFormulario(formHijo As Form, Optional titulo As String = "")
        ' Cierro lo que haya abierto, para que no se acumulen
        For i As Integer = pnlcontenedor.Controls.Count - 1 To 0 Step -1
            pnlcontenedor.Controls(i).Dispose()
        Next

        formHijo.TopLevel = False                        ' deja de ser una ventana independiente
        formHijo.FormBorderStyle = FormBorderStyle.None  ' sin borde ni barra de título
        formHijo.Dock = DockStyle.Fill                   ' ocupa todo el panel
        pnlcontenedor.Controls.Add(formHijo)             ' lo meto en el panel
        formHijo.Show()
        lbltitulo.Text = titulo
    End Sub

    Sub MarcarActivo(btn As Button)
        For Each b As Button In New Button() {btnmedicamentos, btnproveedores, btncompras}
            b.BackColor = Estilos.ColorMenu
        Next
        btn.BackColor = Estilos.ColorActivo
    End Sub


    Private Sub btnmedicamentos_Click(sender As Object, e As EventArgs) Handles btnmedicamentos.Click
        AbrirFormulario(New medicamentos(), "Medicamentos")
        MarcarActivo(btnmedicamentos)
    End Sub

    Private Sub btnproveedores_Click(sender As Object, e As EventArgs) Handles btnproveedores.Click
        AbrirFormulario(New fromproveedores(), "Proveedores")
        MarcarActivo(btnproveedores)
    End Sub

    Private Sub btncompras_Click(sender As Object, e As EventArgs) Handles btncompras.Click
        AbrirFormulario(New fromcompras(), "Compras")
        MarcarActivo(btncompras)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlmenu.BackColor = Estilos.ColorMenu
        Estilos.EstilizarBotonMenu(btnmedicamentos, pnlmenu.Width)
        Estilos.EstilizarBotonMenu(btnproveedores, pnlmenu.Width)
        Estilos.EstilizarBotonMenu(btncompras, pnlmenu.Width)
        Estilos.EstilizarBotonMenu(btndashboard, pnlmenu.Width)

        configurarmenusegunrol()

        'pantalla completa
        Me.WindowState = FormWindowState.Maximized

        btncompras.Visible = Permisos.PuedeRegistrarCompras()
        btnformusuarios.Visible = Permisos.EsAdmin()
    End Sub

    Private Sub configurarmenusegunrol()
        'si no es admin desabilitamos el boton USUARIOS
        If Modulosesion.esadmin Then
            btnformusuarios.Visible = True
            Estilos.EstilizarBotonMenu(btnformusuarios, pnlmenu.Width)
        Else
            btnformusuarios.Visible = False
        End If
    End Sub

    Private Sub btnformusuarios_Click(sender As Object, e As EventArgs) Handles btnformusuarios.Click
        If Not Modulosesion.esadmin Then
            MessageBox.Show("No tenés permisos para acceder a la gestión de usuarios.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        AbrirFormulario(New Formusuarios, "Usuarios")
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        AbrirFormulario(New dashboard, "Panel de Control y Métricas")
        MarcarActivo(btndashboard)
    End Sub
End Class
