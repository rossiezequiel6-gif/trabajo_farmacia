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

    Private Sub btnmedicamentos_Click(sender As Object, e As EventArgs) Handles btnmedicamentos.Click
        medicamentos.Show()
    End Sub
End Class
