Module Permisos
    Public Function EsAdmin() As Boolean
        If String.IsNullOrEmpty(sesion.rolUsuario) Then Return False
        Return sesion.rolUsuario.ToLower().StartsWith("admin")
    End Function

    Public Function PuedeRegistrarCompras() As Boolean
        If String.IsNullOrEmpty(sesion.rolUsuario) Then Return False
        Dim r As String = sesion.rolUsuario.ToLower()
        Return r.StartsWith("admin") OrElse r.StartsWith("encargado")
    End Function
End Module
