Module seccion
    Public IdUsuario As Integer = 0
    Public NombreUsuario As String = ""
    Public NombreRol As String = ""

    Public Function PuedeRegistrarCompras() As Boolean
        Return NombreRol = "Admin" OrElse NombreRol = "Encargado de control"
    End Function

End Module
