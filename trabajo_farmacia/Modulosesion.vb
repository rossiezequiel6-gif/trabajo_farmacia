Module Modulosesion
    'variables globales para la sesión activa
    Public idusuarioactual As Integer = 0
    Public nombreusuarioactual As String = ""
    Public rolactual As String = ""
    Public esadmin As Boolean = False

    'metodo para iniciar sesion y validar el rol
    Public Sub iniciarsesion(id As Integer, nombre As String, rol As String)
        idusuarioactual = id
        nombreusuarioactual = If(nombre, "")
        rolactual = If(rol, "")

        'verificamos si el rol es administrador ( si el id de rol es 1)
        Dim rolLwr As String = rolactual.ToLower()
        If rolLwr = "administrador" OrElse rolLwr = "admin" OrElse rolLwr.Contains("admin") Then
            esadmin = True
        Else
            esadmin = False
        End If
    End Sub

    Public Sub cerrarsesion()
        idusuarioactual = 0
        nombreusuarioactual = ""
        rolactual = ""
        esadmin = False
    End Sub
End Module
