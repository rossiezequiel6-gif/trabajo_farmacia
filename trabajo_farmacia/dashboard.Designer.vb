<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel11 = New Panel()
        Label12 = New Label()
        lblvencimiento = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel12 = New Panel()
        Label13 = New Label()
        Panel9 = New Panel()
        lbltotalmedicamentos = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel10 = New Panel()
        Label9 = New Label()
        Panel7 = New Panel()
        lblstockcritico = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        FormsPlot1 = New ScottPlot.WinForms.FormsPlot()
        Label4 = New Label()
        Panel5 = New Panel()
        FormsPlot2 = New ScottPlot.WinForms.FormsPlot()
        Label5 = New Label()
        Panel6 = New Panel()
        dgvvencimientos = New DataGridView()
        Label14 = New Label()
        Panel8 = New Panel()
        Panel1.SuspendLayout()
        Panel11.SuspendLayout()
        Panel2.SuspendLayout()
        Panel12.SuspendLayout()
        Panel3.SuspendLayout()
        Panel10.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(dgvvencimientos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Panel11)
        Panel1.Controls.Add(lblvencimiento)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(536, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(465, 157)
        Panel1.TabIndex = 0
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.OrangeRed
        Panel11.Controls.Add(Label12)
        Panel11.Location = New Point(12, 13)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(119, 125)
        Panel11.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe MDL2 Assets", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(18, 33)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 60)
        Label12.TabIndex = 2
        Label12.Text = ""
        ' 
        ' lblvencimiento
        ' 
        lblvencimiento.AutoSize = True
        lblvencimiento.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblvencimiento.Location = New Point(147, 68)
        lblvencimiento.Name = "lblvencimiento"
        lblvencimiento.Size = New Size(0, 38)
        lblvencimiento.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.GrayText
        Label7.Location = New Point(137, 118)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 20)
        Label7.TabIndex = 2
        Label7.Text = "Lotes Proximos a Vencer"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(137, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 28)
        Label2.TabIndex = 1
        Label2.Text = "VENCIMIENTOS (30 DIAS)"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(Panel12)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(lbltotalmedicamentos)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(1044, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(465, 157)
        Panel2.TabIndex = 1
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Blue
        Panel12.Controls.Add(Label13)
        Panel12.Location = New Point(12, 13)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(115, 125)
        Panel12.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe MDL2 Assets", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(16, 33)
        Label13.Name = "Label13"
        Label13.Size = New Size(85, 60)
        Label13.TabIndex = 2
        Label13.Text = ""
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Blue
        Panel9.Location = New Point(0, 145)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(465, 12)
        Panel9.TabIndex = 4
        ' 
        ' lbltotalmedicamentos
        ' 
        lbltotalmedicamentos.AutoSize = True
        lbltotalmedicamentos.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltotalmedicamentos.Location = New Point(159, 68)
        lbltotalmedicamentos.Name = "lbltotalmedicamentos"
        lbltotalmedicamentos.Size = New Size(0, 38)
        lbltotalmedicamentos.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.GrayText
        Label8.Location = New Point(133, 118)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 20)
        Label8.TabIndex = 2
        Label8.Text = "Unidades en Inventario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(133, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 28)
        Label3.TabIndex = 1
        Label3.Text = "TOTAL DE INSUMOS"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(Panel10)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(lblstockcritico)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(23, 34)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(468, 157)
        Panel3.TabIndex = 1
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.DarkRed
        Panel10.Controls.Add(Label9)
        Panel10.Location = New Point(13, 13)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(119, 125)
        Panel10.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe MDL2 Assets", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(18, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 60)
        Label9.TabIndex = 2
        Label9.Text = ""
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.DarkRed
        Panel7.Location = New Point(0, 145)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(468, 12)
        Panel7.TabIndex = 3
        ' 
        ' lblstockcritico
        ' 
        lblstockcritico.AutoSize = True
        lblstockcritico.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblstockcritico.Location = New Point(168, 68)
        lblstockcritico.Name = "lblstockcritico"
        lblstockcritico.Size = New Size(0, 38)
        lblstockcritico.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.GrayText
        Label6.Location = New Point(147, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 20)
        Label6.TabIndex = 1
        Label6.Text = "Ítems Debajo del Crítico"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(147, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 28)
        Label1.TabIndex = 0
        Label1.Text = "ESTOCK CRÍTICO"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(FormsPlot1)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(23, 236)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(978, 399)
        Panel4.TabIndex = 2
        ' 
        ' FormsPlot1
        ' 
        FormsPlot1.Location = New Point(0, 43)
        FormsPlot1.Name = "FormsPlot1"
        FormsPlot1.Size = New Size(978, 356)
        FormsPlot1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveBorder
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(103, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(495, 28)
        Label4.TabIndex = 1
        Label4.Text = "Medicamentos en stock crítico vs. Punto de pedido"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(FormsPlot2)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(1044, 236)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(465, 399)
        Panel5.TabIndex = 3
        ' 
        ' FormsPlot2
        ' 
        FormsPlot2.Location = New Point(0, 43)
        FormsPlot2.Name = "FormsPlot2"
        FormsPlot2.Size = New Size(465, 356)
        FormsPlot2.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveBorder
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(121, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(232, 28)
        Label5.TabIndex = 1
        Label5.Text = "Próximos vencimientos"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(dgvvencimientos)
        Panel6.Controls.Add(Label14)
        Panel6.Location = New Point(23, 661)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1486, 333)
        Panel6.TabIndex = 4
        ' 
        ' dgvvencimientos
        ' 
        dgvvencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvvencimientos.Location = New Point(13, 42)
        dgvvencimientos.Name = "dgvvencimientos"
        dgvvencimientos.RowHeadersWidth = 51
        dgvvencimientos.Size = New Size(1456, 288)
        dgvvencimientos.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.ActiveBorder
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(31, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(194, 28)
        Label14.TabIndex = 2
        Label14.Text = "Alertas de Reorden"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.OrangeRed
        Panel8.Location = New Point(536, 179)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(465, 12)
        Panel8.TabIndex = 4
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1533, 1007)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "dashboard"
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(dgvvencimientos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblvencimiento As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltotalmedicamentos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblstockcritico As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvvencimientos As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents FormsPlot1 As ScottPlot.WinForms.FormsPlot
    Friend WithEvents FormsPlot2 As ScottPlot.WinForms.FormsPlot
End Class
