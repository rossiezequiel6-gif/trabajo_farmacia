Imports System.IO
Imports MySqlConnector
Imports System.Windows.Forms

Module conexionbd

    Public CADENA As String = ""

    Public Sub ObtenerDatosConexion()
        Try
            Dim rutaArchivo As String =
                System.IO.Path.Combine(
                    AppContext.BaseDirectory,
                    "conexion.ini"
                )

            If Not System.IO.File.Exists(rutaArchivo) Then
                Throw New System.IO.FileNotFoundException(
                    "No se encontró el archivo de configuración."
                )
            End If

            CADENA = System.IO.File.ReadAllText(rutaArchivo).Trim()

            If String.IsNullOrWhiteSpace(CADENA) Then
                Throw New Exception(
                    "El archivo de conexión está vacío."
                )
            End If

        Catch ex As Exception
            CADENA = ""
            MessageBox.Show(
                "No se pudo configurar la conexión: " & ex.Message,
                "Error de conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

End Module
