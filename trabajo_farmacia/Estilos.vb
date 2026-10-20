Module Estilos
    Public ReadOnly ColorMenu As Color = Color.FromArgb(15, 76, 74)
    Public ReadOnly ColorHover As Color = Color.FromArgb(24, 107, 103)
    Public ReadOnly ColorActivo As Color = Color.FromArgb(38, 166, 154)

    Sub EstilizarBotonMenu(b As Button, anchoMenu As Integer)
        b.FlatStyle = FlatStyle.Flat
        b.FlatAppearance.BorderSize = 0
        b.FlatAppearance.MouseOverBackColor = ColorHover
        b.BackColor = ColorMenu
        b.ForeColor = Color.White
        b.Font = New Font("Segoe UI", 11)
        b.TextAlign = ContentAlignment.MiddleLeft
        b.Padding = New Padding(20, 0, 0, 0)
        b.Height = 50
        b.Width = anchoMenu
        b.Left = 0
        b.Cursor = Cursors.Hand
    End Sub

    Sub EstilizarGrilla(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorMenu
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 36
        dgv.RowHeadersVisible = False              ' saca la columna gris de la izquierda
        dgv.AllowUserToAddRows = False             ' saca la fila vacía del final
        dgv.BorderStyle = BorderStyle.None
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 247, 246)
        dgv.DefaultCellStyle.SelectionBackColor = ColorActivo
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub EstilizarCampos(contenedor As Control)
        For Each c As Control In contenedor.Controls
            If TypeOf c Is TextBox OrElse TypeOf c Is ComboBox OrElse TypeOf c Is NumericUpDown Then
                c.BackColor = Color.White
                c.ForeColor = Color.FromArgb(33, 37, 41)
                c.Font = New Font("Segoe UI", 10)

                If TypeOf c Is ComboBox Then
                    DirectCast(c, ComboBox).FlatStyle = FlatStyle.Flat
                End If
                If TypeOf c Is TextBox AndAlso DirectCast(c, TextBox).ReadOnly Then
                    c.BackColor = Color.FromArgb(233, 236, 239)
                End If
            End If

            If c.HasChildren Then EstilizarCampos(c)   ' entra también a los GroupBox y paneles
        Next
    End Sub

    'Estilizar Groupbox 
    Sub EstilizarGroupBox(gb As GroupBox)

        gb.BackColor = Color.FromArgb(143, 184, 178)
        gb.ForeColor = ColorMenu
        gb.Font = New Font("Segoe UI", 10, FontStyle.Bold)

    End Sub


    'Estilizar botones
    Sub EstilizarBoton(btn As Button, colorFondo As Color)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = colorFondo
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
        btn.UseVisualStyleBackColor = False

    End Sub



End Module
