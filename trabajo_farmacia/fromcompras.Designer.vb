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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromcompras))
        dgvcompras = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        gbcompras = New GroupBox()
        btnimprimirre = New Button()
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
        gbdetallecompra = New GroupBox()
        Label9 = New Label()
        txtcodigolote = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        nudprecio = New NumericUpDown()
        dtpvencimiento = New DateTimePicker()
        Label4 = New Label()
        Label8 = New Label()
        nudcantidad = New NumericUpDown()
        cbmedicamentos = New ComboBox()
        Label12 = New Label()
        dgvdetalle = New DataGridView()
        btnagregaritem = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(dgvcompras, ComponentModel.ISupportInitialize).BeginInit()
        gbcompras.SuspendLayout()
        pnlotes.SuspendLayout()
        gbdetallecompra.SuspendLayout()
        CType(nudprecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudcantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvdetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvcompras
        ' 
        dgvcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcompras.Location = New Point(12, 118)
        dgvcompras.Margin = New Padding(3, 4, 3, 4)
        dgvcompras.Name = "dgvcompras"
        dgvcompras.RowHeadersWidth = 51
        dgvcompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcompras.Size = New Size(728, 288)
        dgvcompras.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 1
        Label1.Text = "Id Compra:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 2
        Label2.Text = "Fecha de Compra:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 20)
        Label3.TabIndex = 3
        Label3.Text = "Número de Factura:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 5
        Label5.Text = "Proveedor:"
        ' 
        ' gbcompras
        ' 
        gbcompras.BackColor = Color.Teal
        gbcompras.Controls.Add(btnimprimirre)
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
        gbcompras.Location = New Point(12, 426)
        gbcompras.Margin = New Padding(3, 4, 3, 4)
        gbcompras.Name = "gbcompras"
        gbcompras.Padding = New Padding(3, 4, 3, 4)
        gbcompras.Size = New Size(728, 355)
        gbcompras.TabIndex = 6
        gbcompras.TabStop = False
        gbcompras.Text = "Datos Compras"
        ' 
        ' btnimprimirre
        ' 
        btnimprimirre.Location = New Point(606, 241)
        btnimprimirre.Margin = New Padding(3, 4, 3, 4)
        btnimprimirre.Name = "btnimprimirre"
        btnimprimirre.Size = New Size(107, 53)
        btnimprimirre.TabIndex = 20
        btnimprimirre.Text = "Imprimir Remito"
        btnimprimirre.UseVisualStyleBackColor = True
        ' 
        ' txtlote
        ' 
        txtlote.Location = New Point(170, 196)
        txtlote.Margin = New Padding(3, 4, 3, 4)
        txtlote.Name = "txtlote"
        txtlote.Size = New Size(235, 27)
        txtlote.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 18
        Label7.Text = "Lote"
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.Location = New Point(606, 185)
        btnlimpiar.Margin = New Padding(3, 4, 3, 4)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(107, 41)
        btnlimpiar.TabIndex = 17
        btnlimpiar.Text = "Limpiar"
        btnlimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Location = New Point(606, 111)
        btnmodificar.Margin = New Padding(3, 4, 3, 4)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(107, 51)
        btnmodificar.TabIndex = 16
        btnmodificar.Text = "Modificar"
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnregistrar
        ' 
        btnregistrar.Location = New Point(606, 41)
        btnregistrar.Margin = New Padding(3, 4, 3, 4)
        btnregistrar.Name = "btnregistrar"
        btnregistrar.Size = New Size(107, 51)
        btnregistrar.TabIndex = 15
        btnregistrar.Text = "Registrar"
        btnregistrar.UseVisualStyleBackColor = True
        ' 
        ' dtpfecha
        ' 
        dtpfecha.Location = New Point(170, 69)
        dtpfecha.Margin = New Padding(3, 4, 3, 4)
        dtpfecha.Name = "dtpfecha"
        dtpfecha.Size = New Size(257, 27)
        dtpfecha.TabIndex = 7
        ' 
        ' cbusuario
        ' 
        cbusuario.FormattingEnabled = True
        cbusuario.Location = New Point(170, 241)
        cbusuario.Margin = New Padding(3, 4, 3, 4)
        cbusuario.Name = "cbusuario"
        cbusuario.Size = New Size(235, 28)
        cbusuario.TabIndex = 14
        ' 
        ' cbproveedor
        ' 
        cbproveedor.FormattingEnabled = True
        cbproveedor.Location = New Point(170, 155)
        cbproveedor.Margin = New Padding(3, 4, 3, 4)
        cbproveedor.Name = "cbproveedor"
        cbproveedor.Size = New Size(235, 28)
        cbproveedor.TabIndex = 13
        ' 
        ' txtfactura
        ' 
        txtfactura.Location = New Point(171, 116)
        txtfactura.Margin = New Padding(3, 4, 3, 4)
        txtfactura.Name = "txtfactura"
        txtfactura.Size = New Size(235, 27)
        txtfactura.TabIndex = 10
        ' 
        ' txtidcompras
        ' 
        txtidcompras.Location = New Point(171, 31)
        txtidcompras.Margin = New Padding(3, 4, 3, 4)
        txtidcompras.Name = "txtidcompras"
        txtidcompras.ReadOnly = True
        txtidcompras.Size = New Size(75, 27)
        txtidcompras.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 20)
        Label6.TabIndex = 7
        Label6.Text = "Usuario:"
        ' 
        ' pnlotes
        ' 
        pnlotes.Controls.Add(gbdetallecompra)
        pnlotes.Controls.Add(Label12)
        pnlotes.Controls.Add(dgvdetalle)
        pnlotes.Controls.Add(btnagregaritem)
        pnlotes.Location = New Point(746, 118)
        pnlotes.Margin = New Padding(3, 4, 3, 4)
        pnlotes.Name = "pnlotes"
        pnlotes.Size = New Size(786, 531)
        pnlotes.TabIndex = 7
        ' 
        ' gbdetallecompra
        ' 
        gbdetallecompra.Controls.Add(Label9)
        gbdetallecompra.Controls.Add(txtcodigolote)
        gbdetallecompra.Controls.Add(Label10)
        gbdetallecompra.Controls.Add(Label11)
        gbdetallecompra.Controls.Add(nudprecio)
        gbdetallecompra.Controls.Add(dtpvencimiento)
        gbdetallecompra.Controls.Add(Label4)
        gbdetallecompra.Controls.Add(Label8)
        gbdetallecompra.Controls.Add(nudcantidad)
        gbdetallecompra.Controls.Add(cbmedicamentos)
        gbdetallecompra.Location = New Point(7, 26)
        gbdetallecompra.Margin = New Padding(3, 4, 3, 4)
        gbdetallecompra.Name = "gbdetallecompra"
        gbdetallecompra.Padding = New Padding(3, 4, 3, 4)
        gbdetallecompra.Size = New Size(772, 113)
        gbdetallecompra.TabIndex = 13
        gbdetallecompra.TabStop = False
        gbdetallecompra.Text = "Detalle"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(138, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 20)
        Label9.TabIndex = 7
        Label9.Text = "Codigo"
        ' 
        ' txtcodigolote
        ' 
        txtcodigolote.Location = New Point(135, 55)
        txtcodigolote.Margin = New Padding(3, 4, 3, 4)
        txtcodigolote.Name = "txtcodigolote"
        txtcodigolote.Size = New Size(83, 27)
        txtcodigolote.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(235, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 20)
        Label10.TabIndex = 8
        Label10.Text = "Vencimiento"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(667, 25)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 20)
        Label11.TabIndex = 10
        Label11.Text = "Precio"
        ' 
        ' nudprecio
        ' 
        nudprecio.DecimalPlaces = 2
        nudprecio.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        nudprecio.Location = New Point(734, 69)
        nudprecio.Margin = New Padding(3, 4, 3, 4)
        nudprecio.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 131072})
        nudprecio.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        nudprecio.Name = "nudprecio"
        nudprecio.Size = New Size(107, 27)
        nudprecio.TabIndex = 4
        nudprecio.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        ' 
        ' dtpvencimiento
        ' 
        dtpvencimiento.Location = New Point(226, 55)
        dtpvencimiento.Margin = New Padding(3, 4, 3, 4)
        dtpvencimiento.Name = "dtpvencimiento"
        dtpvencimiento.Size = New Size(271, 27)
        dtpvencimiento.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(544, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 9
        Label4.Text = "Cantidad"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 20)
        Label8.TabIndex = 6
        Label8.Text = "Medicamento"
        ' 
        ' nudcantidad
        ' 
        nudcantidad.Location = New Point(607, 69)
        nudcantidad.Margin = New Padding(3, 4, 3, 4)
        nudcantidad.Name = "nudcantidad"
        nudcantidad.Size = New Size(91, 27)
        nudcantidad.TabIndex = 3
        ' 
        ' cbmedicamentos
        ' 
        cbmedicamentos.DropDownStyle = ComboBoxStyle.DropDownList
        cbmedicamentos.FormattingEnabled = True
        cbmedicamentos.Location = New Point(10, 54)
        cbmedicamentos.Margin = New Padding(3, 4, 3, 4)
        cbmedicamentos.Name = "cbmedicamentos"
        cbmedicamentos.Size = New Size(114, 28)
        cbmedicamentos.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(17, 171)
        Label12.Name = "Label12"
        Label12.Size = New Size(189, 25)
        Label12.TabIndex = 12
        Label12.Text = "Detalles de Compra "
        ' 
        ' dgvdetalle
        ' 
        dgvdetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdetalle.Location = New Point(7, 216)
        dgvdetalle.Margin = New Padding(3, 4, 3, 4)
        dgvdetalle.Name = "dgvdetalle"
        dgvdetalle.RowHeadersWidth = 51
        dgvdetalle.Size = New Size(770, 303)
        dgvdetalle.TabIndex = 11
        ' 
        ' btnagregaritem
        ' 
        btnagregaritem.Location = New Point(656, 147)
        btnagregaritem.Margin = New Padding(3, 4, 3, 4)
        btnagregaritem.Name = "btnagregaritem"
        btnagregaritem.Size = New Size(121, 61)
        btnagregaritem.TabIndex = 5
        btnagregaritem.Text = "Agregar lote"
        btnagregaritem.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' fromcompras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1550, 777)
        Controls.Add(pnlotes)
        Controls.Add(gbcompras)
        Controls.Add(dgvcompras)
        Margin = New Padding(3, 4, 3, 4)
        Name = "fromcompras"
        Text = "fromcompras"
        CType(dgvcompras, ComponentModel.ISupportInitialize).EndInit()
        gbcompras.ResumeLayout(False)
        gbcompras.PerformLayout()
        pnlotes.ResumeLayout(False)
        pnlotes.PerformLayout()
        gbdetallecompra.ResumeLayout(False)
        gbdetallecompra.PerformLayout()
        CType(nudprecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudcantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvdetalle, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnimprimirre As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label12 As Label
    Friend WithEvents gbdetallecompra As GroupBox
End Class
