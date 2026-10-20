<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromcompras
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
        dgvcompras = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        gbcompras = New GroupBox()
        txtlote = New TextBox()
        Label7 = New Label()
        btnlimpiar = New Button()
        btnmodificar = New Button()
        btnregistrar = New Button()
        dtpfecha = New DateTimePicker()
        cbusuario = New ComboBox()
        cbproveedor = New ComboBox()
        txtfactura = New TextBox()
        txtidcompras = New TextBox()
        Label6 = New Label()
        CType(dgvcompras, ComponentModel.ISupportInitialize).BeginInit()
        gbcompras.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvcompras
        ' 
        dgvcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcompras.Location = New Point(18, 37)
        dgvcompras.Name = "dgvcompras"
        dgvcompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcompras.Size = New Size(612, 216)
        dgvcompras.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 1
        Label1.Text = "Id Compra:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha de Compra:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 15)
        Label3.TabIndex = 3
        Label3.Text = "Número de Factura:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 5
        Label5.Text = "Proveedor:"
        ' 
        ' gbcompras
        ' 
        gbcompras.BackColor = Color.Teal
        gbcompras.Controls.Add(txtlote)
        gbcompras.Controls.Add(Label7)
        gbcompras.Controls.Add(btnlimpiar)
        gbcompras.Controls.Add(btnmodificar)
        gbcompras.Controls.Add(btnregistrar)
        gbcompras.Controls.Add(dtpfecha)
        gbcompras.Controls.Add(cbusuario)
        gbcompras.Controls.Add(cbproveedor)
        gbcompras.Controls.Add(txtfactura)
        gbcompras.Controls.Add(txtidcompras)
        gbcompras.Controls.Add(Label6)
        gbcompras.Controls.Add(Label1)
        gbcompras.Controls.Add(Label5)
        gbcompras.Controls.Add(Label2)
        gbcompras.Controls.Add(Label3)
        gbcompras.FlatStyle = FlatStyle.Flat
        gbcompras.Location = New Point(18, 268)
        gbcompras.Name = "gbcompras"
        gbcompras.Size = New Size(612, 209)
        gbcompras.TabIndex = 6
        gbcompras.TabStop = False
        gbcompras.Text = "Datos Compras"
        ' 
        ' txtlote
        ' 
        txtlote.Location = New Point(133, 147)
        txtlote.Name = "txtlote"
        txtlote.Size = New Size(206, 23)
        txtlote.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 155)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 15)
        Label7.TabIndex = 18
        Label7.Text = "Lote"
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.Location = New Point(483, 124)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(94, 31)
        btnlimpiar.TabIndex = 17
        btnlimpiar.Text = "Limpiar"
        btnlimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Location = New Point(483, 72)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(94, 38)
        btnmodificar.TabIndex = 16
        btnmodificar.Text = "Modificar"
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnregistrar
        ' 
        btnregistrar.Location = New Point(483, 19)
        btnregistrar.Name = "btnregistrar"
        btnregistrar.Size = New Size(94, 38)
        btnregistrar.TabIndex = 15
        btnregistrar.Text = "Registrar"
        btnregistrar.UseVisualStyleBackColor = True
        ' 
        ' dtpfecha
        ' 
        dtpfecha.Location = New Point(133, 52)
        dtpfecha.Name = "dtpfecha"
        dtpfecha.Size = New Size(225, 23)
        dtpfecha.TabIndex = 7
        ' 
        ' cbusuario
        ' 
        cbusuario.FormattingEnabled = True
        cbusuario.Location = New Point(133, 176)
        cbusuario.Name = "cbusuario"
        cbusuario.Size = New Size(206, 23)
        cbusuario.TabIndex = 14
        ' 
        ' cbproveedor
        ' 
        cbproveedor.FormattingEnabled = True
        cbproveedor.Location = New Point(133, 116)
        cbproveedor.Name = "cbproveedor"
        cbproveedor.Size = New Size(206, 23)
        cbproveedor.TabIndex = 13
        ' 
        ' txtfactura
        ' 
        txtfactura.Location = New Point(133, 87)
        txtfactura.Name = "txtfactura"
        txtfactura.Size = New Size(206, 23)
        txtfactura.TabIndex = 10
        ' 
        ' txtidcompras
        ' 
        txtidcompras.Location = New Point(133, 23)
        txtidcompras.Name = "txtidcompras"
        txtidcompras.ReadOnly = True
        txtidcompras.Size = New Size(100, 23)
        txtidcompras.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 184)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 7
        Label6.Text = "Usuario:"
        ' 
        ' fromcompras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(933, 479)
        Controls.Add(gbcompras)
        Controls.Add(dgvcompras)
        Name = "fromcompras"
        Text = "fromcompras"
        CType(dgvcompras, ComponentModel.ISupportInitialize).EndInit()
        gbcompras.ResumeLayout(False)
        gbcompras.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvcompras As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbcompras As GroupBox
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents txtidcompras As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbusuario As ComboBox
    Friend WithEvents cbproveedor As ComboBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnregistrar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtlote As TextBox
    Friend WithEvents Label7 As Label
End Class
