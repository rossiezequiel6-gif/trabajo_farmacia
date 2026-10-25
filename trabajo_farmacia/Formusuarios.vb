Public Class Formusuarios

    Dim idusuarioseleccionado As Integer = 0
    Private Sub Formusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrillausuarios(dgvusuarios)
        cargarcomboroles(cbrol)
        limpiarcampos()
        Estilos.EstilizarGrilla(dgvusuarios)

        'estilizar botones
        EstilizarBoton(btnguardarusu, ColorMenu)
        EstilizarBoton(btneliminar, Color.FromArgb(210, 85, 95))
        EstilizarBoton(btnmodifusu, ColorActivo)
        EstilizarBoton(btnlimpiarusu, Color.FromArgb(90, 160, 145))
    End Sub

    Private Sub limpiarcampos()
        idusuarioseleccionado = 0
        txtclave.Text = ""
        txtusuario.Text = ""
        txtnombrecomp.Text = ""
        cbrol.SelectedIndex = -1
        txtusuario.Focus()
    End Sub

    Private Sub txtbuscarusuario_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarusuario.TextChanged
        cargargrillausuarios(dgvusuarios, txtbuscarusuario.Text.Trim())
    End Sub

    Private Sub dgvusuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuarios.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim fila = dgvusuarios.Rows(e.RowIndex)
        idusuarioseleccionado = Convert.ToInt32(fila.Cells("id_usuario").Value)
        txtusuario.Text = fila.Cells("nombre_usuario").Value.ToString()
        txtnombrecomp.Text = fila.Cells("nombre_completo").Value.ToString()
        cbrol.SelectedValue = fila.Cells("id_rol").Value

    End Sub

    Private Sub btnguardarusu_Click(sender As Object, e As EventArgs) Handles btnguardarusu.Click
        'boton agregar nuevo usuario
        If txtusuario.Text.Trim() = "" OrElse txtnombrecomp.Text.Trim() = "" OrElse txtclave.Text.Trim() = "" OrElse cbrol.SelectedIndex < 0 Then
            MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If guardarusuario(txtusuario.Text.Trim(), txtnombrecomp.Text.Trim(), txtclave.Text.Trim(), Convert.ToInt32(cbrol.SelectedValue)) Then
            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargargrillausuarios(dgvusuarios)
            limpiarcampos()
        End If
    End Sub

    Private Sub btnmodifusu_Click(sender As Object, e As EventArgs) Handles btnmodifusu.Click
        'boton modificar usuario
        If idusuarioseleccionado = 0 Then
            MessageBox.Show("Seleccione un usuario para modificar.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If modificarusuario(idusuarioseleccionado, txtusuario.Text.Trim(), txtnombrecomp.Text.Trim(), Convert.ToInt32(cbrol.SelectedValue), txtclave.Text.Trim) Then
            MessageBox.Show("Datos de usuario actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargargrillausuarios(dgvusuarios)
            limpiarcampos()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'boton eliminar usuario
        If idusuarioseleccionado = 0 Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'evitamos que el admin se elimine a sí mismo
        If idusuarioseleccionado = Modulosesion.idusuarioactual Then
            MessageBox.Show("No puede eliminar el usuario actualmente conectado.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resp As DialogResult = MessageBox.Show("¿Está seguro de que desea dar de baja al usuario '" & txtusuario.Text & "'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            If eliminarusuario(idusuarioseleccionado) Then
                MessageBox.Show("Usuario dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargargrillausuarios(dgvusuarios)
                limpiarcampos()
            End If
        End If
    End Sub

    Private Sub btnlimpiarusu_Click(sender As Object, e As EventArgs) Handles btnlimpiarusu.Click
        limpiarcampos()
    End Sub
End Class