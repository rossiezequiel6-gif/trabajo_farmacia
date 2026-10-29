Imports System.IO
Imports MySqlConnector

Module conexionbd

    Public CADENA As String = ""

        Public Sub ObtenerDatosConexion()
            Try
                Dim rutaArchivo As String =
                Path.Combine(AppContext.BaseDirectory, "conexion.ini")

                If Not File.Exists(rutaArchivo) Then
                    Throw New FileNotFoundException(
                    "No se encontró el archivo de configuración.")
                End If

                CADENA = File.ReadAllText(rutaArchivo).Trim()

                If String.IsNullOrWhiteSpace(CADENA) Then
                    Throw New Exception(
                    "El archivo de conexión está vacío.")
                End If

            Catch ex As Exception
                CADENA = ""
                MessageBox.Show(
                "No se pudo configurar la conexión a la base de datos.",
                "Error de conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            End Try
        End Sub

    End Module

