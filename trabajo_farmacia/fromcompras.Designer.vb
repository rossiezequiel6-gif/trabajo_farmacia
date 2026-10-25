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
        pnlotes = New Panel()
        dgvdetalle = New DataGridView()
        Label11 = New Label()
        Label4 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        btnagregaritem = New Button()
        nudprecio = New NumericUpDown()
        nudcantidad = New NumericUpDown()
        dtpvencimiento = New DateTimePicker()
        txtcodigolote = New TextBox()
        cbmedicamentos = New ComboBox()
        CType(dgvcompras, ComponentModel.ISupportInitialize).BeginInit()
        gbcompras.SuspendLayout()
        pnlotes.SuspendLayout()
        CType(dgvdetalle, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudprecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudcantidad, ComponentModel.ISupportInitialize).BeginInit()
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
        txtlote.Location = New Point(149, 147)
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
        dtpfecha.Location = New Point(151, 52)
        dtpfecha.Name = "dtpfecha"
        dtpfecha.Size = New Size(225, 23)
        dtpfecha.TabIndex = 7
        ' 
        ' cbusuario
        ' 
        cbusuario.FormattingEnabled = True
        cbusuario.Location = New Point(149, 176)
        cbusuario.Name = "cbusuario"
        cbusuario.Size = New Size(206, 23)
        cbusuario.TabIndex = 14
        ' 
        ' cbproveedor
        ' 
        cbproveedor.FormattingEnabled = True
        cbproveedor.Location = New Point(149, 116)
        cbproveedor.Name = "cbproveedor"
        cbproveedor.Size = New Size(206, 23)
        cbproveedor.TabIndex = 13
        ' 
        ' txtfactura
        ' 
        txtfactura.Location = New Point(150, 87)
        txtfactura.Name = "txtfactura"
        txtfactura.Size = New Size(206, 23)
        txtfactura.TabIndex = 10
        ' 
        ' txtidcompras
        ' 
        txtidcompras.Location = New Point(152, 23)
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
        ' pnlotes
        ' 
        pnlotes.Controls.Add(dgvdetalle)
        pnlotes.Controls.Add(Label11)
        pnlotes.Controls.Add(Label4)
        pnlotes.Controls.Add(Label10)
        pnlotes.Controls.Add(Label9)
        pnlotes.Controls.Add(Label8)
        pnlotes.Controls.Add(btnagregaritem)
        pnlotes.Controls.Add(nudprecio)
        pnlotes.Controls.Add(nudcantidad)
        pnlotes.Controls.Add(dtpvencimiento)
        pnlotes.Controls.Add(txtcodigolote)
        pnlotes.Controls.Add(cbmedicamentos)
        pnlotes.Location = New Point(636, 37)
        pnlotes.Name = "pnlotes"
        pnlotes.Size = New Size(685, 401)
        pnlotes.TabIndex = 7
        ' 
        ' dgvdetalle
        ' 
        dgvdetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdetalle.Location = New Point(6, 121)
        dgvdetalle.Name = "dgvdetalle"
        dgvdetalle.Size = New Size(676, 208)
        dgvdetalle.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(550, 13)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 15)
        Label11.TabIndex = 10
        Label11.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(477, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 9
        Label4.Text = "Cantidad"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(250, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 15)
        Label10.TabIndex = 8
        Label10.Text = "Vencimiento"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(134, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 15)
        Label9.TabIndex = 7
        Label9.Text = "Codigo"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(21, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 15)
        Label8.TabIndex = 6
        Label8.Text = "Medicamento"
        ' 
        ' btnagregaritem
        ' 
        btnagregaritem.Location = New Point(529, 74)
        btnagregaritem.Name = "btnagregaritem"
        btnagregaritem.Size = New Size(100, 41)
        btnagregaritem.TabIndex = 5
        btnagregaritem.Text = "Agregar Item "
        btnagregaritem.UseVisualStyleBackColor = True
        ' 
        ' nudprecio
        ' 
        nudprecio.Location = New Point(550, 32)
        nudprecio.Name = "nudprecio"
        nudprecio.Size = New Size(49, 23)
        nudprecio.TabIndex = 4
        ' 
        ' nudcantidad
        ' 
        nudcantidad.Location = New Point(477, 32)
        nudcantidad.Name = "nudcantidad"
        nudcantidad.Size = New Size(60, 23)
        nudcantidad.TabIndex = 3
        ' 
        ' dtpvencimiento
        ' 
        dtpvencimiento.Location = New Point(245, 32)
        dtpvencimiento.Name = "dtpvencimiento"
        dtpvencimiento.Size = New Size(220, 23)
        dtpvencimiento.TabIndex = 2
        ' 
        ' txtcodigolote
        ' 
        txtcodigolote.Location = New Point(130, 32)
        txtcodigolote.Name = "txtcodigolote"
        txtcodigolote.Size = New Size(100, 23)
        txtcodigolote.TabIndex = 1
        ' 
        ' cbmedicamentos
        ' 
        cbmedicamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cbmedicamentos.FormattingEnabled = True
        cbmedicamentos.Location = New Point(17, 32)
        cbmedicamentos.Name = "cbmedicamentos"
        cbmedicamentos.Size = New Size(100, 23)
        cbmedicamentos.TabIndex = 0
        ' 
        ' fromcompras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1370, 546)
        Controls.Add(pnlotes)
        Controls.Add(gbcompras)
        Controls.Add(dgvcompras)
        Name = "fromcompras"
        Text = "fromcompras"
        CType(dgvcompras, ComponentModel.ISupportInitialize).EndInit()
        gbcompras.ResumeLayout(False)
        gbcompras.PerformLayout()
        pnlotes.ResumeLayout(False)
        pnlotes.PerformLayout()
        CType(dgvdetalle, ComponentModel.ISupportInitialize).EndInit()
        CType(nudprecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudcantidad, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlotes As Panel
    Friend WithEvents btnagregaritem As Button
    Friend WithEvents nudprecio As NumericUpDown
    Friend WithEvents nudcantidad As NumericUpDown
    Friend WithEvents dtpvencimiento As DateTimePicker
    Friend WithEvents txtcodigolote As TextBox
    Friend WithEvents cbmedicamentos As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvdetalle As DataGridView
    Friend WithEvents Label11 As Label
End Class
