Imports MySqlConnector
Public Class medicamentos

    Sub Cargarmedicamentos()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT * FROM medicamento ORDER BY id_medicamento;"

                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargar la tabla en la grilla
                    dgvmedicamento.DataSource = tabla

                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar las editoriales: " & ex.Message)
        End Try
    End Sub

    Private Sub medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarmedicamentos()
    End Sub

    Private Sub dgvmedicamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmedicamento.CellClick
        'cuando hago click en la grilla, me traigo los datos de la fila seleccionada
        If e.RowIndex >= 0 Then
            txtid.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_medicamento").Value.ToString()
            txtnombre.Text = dgvmedicamento.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            txtlaboratorio.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_laboratorio").Value.ToString()
            txtcodigo.Text = dgvmedicamento.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            txtdroga.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_droga").Value.ToString()
            txtterapeutica.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_accion").Value.ToString()
            txtpresentacion.Text = dgvmedicamento.Rows(e.RowIndex).Cells("id_presentacion").Value.ToString()
            nudstockmin.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("stock_min").Value)
            nudstockmax.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("stock_max").Value)
            nudpedido.Value = Convert.ToDecimal(dgvmedicamento.Rows(e.RowIndex).Cells("punto_pedido").Value)
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        ' valido que haya seleccionado una fila en la grilla
        If dgvmedicamento.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If


        ' ahora modifico el registro seleccionado
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                ' armo mi consulta sql ' uso update para modificar registros, y where para indicar que registro modificar
                Dim consulta As String = "UPDATE medicamento SET " &
                                                    "codigo=@codigo, " &
                                                    "nombre=@nombre, " &
                                                    "stock_min=@stock_min, " &
                                                    "stock_max=@stock_max, " &
                                                    "punto_pedido=@punto_pedido, " &
                                                    "requiere_receta=@requiere_receta, " &
                                                    "id_droga=@id_droga, " &
                                                    "id_laboratorio=@id_laboratorio, " &
                                                    "id_accion=@id_accion, " &
                                                    "id_presentacion=@id_presentacion " &
                                                    "WHERE id_medicamento=@id_medicamento"

                Using cmd As New MySqlCommand(consulta, cn)

                    ' uso parametros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim)
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@stock_min", nudstockmin.Value)
                    cmd.Parameters.AddWithValue("@stock_max", nudstockmax.Value)
                    cmd.Parameters.AddWithValue("@punto_pedido", nudpedido.Value)
                    cmd.Parameters.AddWithValue("@requiere_receta", If(cbreceta.Checked, 1, 0))

                    ' parametros para los combos relacionales (se pasa el SelectedValue)
                    cmd.Parameters.AddWithValue("@id_droga", txtdroga.Text.Trim)
                    cmd.Parameters.AddWithValue("@id_laboratorio", txtlaboratorio.Text.Trim)
                    cmd.Parameters.AddWithValue("@id_accion", txtterapeutica.Text.Trim)
                    cmd.Parameters.AddWithValue("@id_presentacion", txtpresentacion.Text.Trim)

                    ' parametro para la clave primaria en el WHERE
                    cmd.Parameters.AddWithValue("@id_medicamento", txtid.Text.Trim)

                    ' llamo a ejecutar la consulta 
                    ' uso resultado para obtener la cantidad de registros afectados
                    Dim Resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros actualizados: " & Resultado)
                End Using
            End Using

            Cargarmedicamentos() ' recargo la grilla para ver los cambios

        Catch ex As Exception
            MessageBox.Show("Error al modificar " & ex.Message)
        End Try
    End Sub
End Class