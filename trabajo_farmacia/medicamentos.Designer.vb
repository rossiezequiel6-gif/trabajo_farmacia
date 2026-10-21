<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicamentos
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtbuscar = New TextBox()
        dgvmedicamento = New DataGridView()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        nudpedido = New NumericUpDown()
        nudstockmax = New NumericUpDown()
        nudstockmin = New NumericUpDown()
        Label11 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        cbreceta = New CheckBox()
        cbterapeutica = New ComboBox()
        cbpresentacion = New ComboBox()
        cbdroga = New ComboBox()
        cblaboratorio = New ComboBox()
        btnlimpiar = New Button()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnagregar = New Button()
        txtnombre = New TextBox()
        txtcodigo = New TextBox()
        txtid = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        pbmedicamentos = New PictureBox()
        btnbuscar = New Button()
        btnguardar_ima = New Button()
        btnquitar_ima = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvmedicamento, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(nudpedido, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudstockmax, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudstockmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbmedicamentos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSeaGreen
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtbuscar)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(10, 18)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(901, 70)
        GroupBox1.Location = New Point(33, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1130, 93)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Busqueda"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 23)
        Label1.TabIndex = 1
        Label1.Text = "Medicamentos:"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(190, 41)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(382, 30)
        txtbuscar.TabIndex = 2
        ' 
        ' dgvmedicamento
        ' 
        dgvmedicamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvmedicamento.Location = New Point(11, 133)
        dgvmedicamento.MultiSelect = False
        dgvmedicamento.Name = "dgvmedicamento"
        dgvmedicamento.ReadOnly = True
        dgvmedicamento.RowHeadersWidth = 51
        dgvmedicamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvmedicamento.Size = New Size(901, 275)
        dgvmedicamento.Size = New Size(1173, 367)
        dgvmedicamento.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.DarkSeaGreen
        GroupBox2.BackgroundImageLayout = ImageLayout.None
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(cbterapeutica)
        GroupBox2.Controls.Add(cbpresentacion)
        GroupBox2.Controls.Add(cbdroga)
        GroupBox2.Controls.Add(cblaboratorio)
        GroupBox2.Controls.Add(btnlimpiar)
        GroupBox2.Controls.Add(btneliminar)
        GroupBox2.Controls.Add(btnmodificar)
        GroupBox2.Controls.Add(btnagregar)
        GroupBox2.Controls.Add(txtnombre)
        GroupBox2.Controls.Add(txtcodigo)
        GroupBox2.Controls.Add(txtid)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(11, 507)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(911, 326)
        GroupBox2.Size = New Size(1173, 435)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos de Medicamentos"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.OliveDrab
        Button4.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(425, 340)
        Button4.Name = "Button4"
        Button4.Size = New Size(37, 44)
        Button4.TabIndex = 35
        Button4.Text = "+"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OliveDrab
        Button3.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(425, 289)
        Button3.Name = "Button3"
        Button3.Size = New Size(37, 44)
        Button3.TabIndex = 34
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OliveDrab
        Button2.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(425, 236)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 44)
        Button2.TabIndex = 33
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OliveDrab
        Button1.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(425, 181)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 44)
        Button1.TabIndex = 32
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.DarkSeaGreen
        GroupBox3.Controls.Add(nudpedido)
        GroupBox3.Controls.Add(nudstockmax)
        GroupBox3.Controls.Add(nudstockmin)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(cbreceta)
        GroupBox3.Location = New Point(566, 59)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(281, 303)
        GroupBox3.TabIndex = 31
        GroupBox3.TabStop = False
        ' 
        ' nudpedido
        ' 
        nudpedido.Location = New Point(173, 165)
        nudpedido.Name = "nudpedido"
        nudpedido.Size = New Size(70, 30)
        nudpedido.TabIndex = 21
        ' 
        ' nudstockmax
        ' 
        nudstockmax.Location = New Point(173, 109)
        nudstockmax.Name = "nudstockmax"
        nudstockmax.Size = New Size(70, 30)
        nudstockmax.TabIndex = 20
        ' 
        ' nudstockmin
        ' 
        nudstockmin.Location = New Point(173, 53)
        nudstockmin.Name = "nudstockmin"
        nudstockmin.Size = New Size(70, 30)
        nudstockmin.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(57, 113)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 20)
        Label11.TabIndex = 9
        Label11.Text = "STOCK MAX:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(61, 59)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 20)
        Label10.TabIndex = 8
        Label10.Text = "STOCK MIN:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(9, 169)
        Label12.Name = "Label12"
        Label12.Size = New Size(150, 20)
        Label12.TabIndex = 10
        Label12.Text = "PUNTO DE PEDIDO: "
        ' 
        ' cbreceta
        ' 
        cbreceta.AutoSize = True
        cbreceta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbreceta.Location = New Point(61, 227)
        cbreceta.Name = "cbreceta"
        cbreceta.Size = New Size(160, 24)
        cbreceta.TabIndex = 22
        cbreceta.Text = "REQUIERE RECETA"
        cbreceta.UseVisualStyleBackColor = True
        ' 
        ' cbterapeutica
        ' 
        cbterapeutica.FormattingEnabled = True
        cbterapeutica.Location = New Point(127, 297)
        cbterapeutica.Name = "cbterapeutica"
        cbterapeutica.Size = New Size(281, 31)
        cbterapeutica.TabIndex = 30
        ' 
        ' cbpresentacion
        ' 
        cbpresentacion.FormattingEnabled = True
        cbpresentacion.Location = New Point(127, 244)
        cbpresentacion.Name = "cbpresentacion"
        cbpresentacion.Size = New Size(281, 31)
        cbpresentacion.TabIndex = 29
        ' 
        ' cbdroga
        ' 
        cbdroga.FormattingEnabled = True
        cbdroga.Location = New Point(127, 348)
        cbdroga.Name = "cbdroga"
        cbdroga.Size = New Size(281, 31)
        cbdroga.TabIndex = 28
        ' 
        ' cblaboratorio
        ' 
        cblaboratorio.FormattingEnabled = True
        cblaboratorio.Location = New Point(128, 189)
        cblaboratorio.Name = "cblaboratorio"
        cblaboratorio.Size = New Size(279, 31)
        cblaboratorio.TabIndex = 27
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = Color.PaleGreen
        btnlimpiar.Location = New Point(799, 229)
        btnlimpiar.Margin = New Padding(3, 2, 3, 2)
        btnlimpiar.Location = New Point(1017, 297)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(117, 91)
        btnlimpiar.TabIndex = 26
        btnlimpiar.Text = "LIMPIAR CAMPOS"
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.Crimson
        btneliminar.Location = New Point(799, 87)
        btneliminar.Margin = New Padding(3, 2, 3, 2)
        btneliminar.Location = New Point(1017, 115)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(117, 87)
        btneliminar.TabIndex = 25
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = SystemColors.ActiveCaption
        btnmodificar.Location = New Point(799, 162)
        btnmodificar.Margin = New Padding(3, 2, 3, 2)
        btnmodificar.Location = New Point(1017, 207)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(117, 84)
        btnmodificar.TabIndex = 24
        btnmodificar.Text = "MODIFICAR"
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' btnagregar
        ' 
        btnagregar.BackColor = SystemColors.ActiveCaption
        btnagregar.FlatStyle = FlatStyle.Flat
        btnagregar.ForeColor = Color.White
        btnagregar.Location = New Point(799, 14)
        btnagregar.Margin = New Padding(3, 2, 3, 2)
        btnagregar.Location = New Point(1017, 25)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(117, 83)
        btnagregar.TabIndex = 23
        btnagregar.Text = "AGREGAR"
        btnagregar.UseVisualStyleBackColor = False
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(128, 139)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(279, 30)
        txtnombre.TabIndex = 13
        ' 
        ' txtcodigo
        ' 
        txtcodigo.Location = New Point(128, 83)
        txtcodigo.Name = "txtcodigo"
        txtcodigo.Size = New Size(125, 30)
        txtcodigo.TabIndex = 12
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(128, 37)
        txtid.Name = "txtid"
        txtid.ReadOnly = True
        txtid.Size = New Size(71, 30)
        txtid.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(57, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 20)
        Label9.TabIndex = 7
        Label9.Text = "DROGA:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(0, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 20)
        Label7.TabIndex = 5
        Label7.Text = "PRESENTACIÓN:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(11, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 40)
        Label6.TabIndex = 4
        Label6.Text = "     ACCIÓN " & vbCrLf & "TERAPÉUTICA:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(6, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 3
        Label5.Text = "LABORATORIO:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 2
        Label4.Text = "NOMBRE:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 1
        Label3.Text = "CÓDIGO: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 20)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' pbmedicamentos
        ' 
        pbmedicamentos.Anchor = AnchorStyles.None
        pbmedicamentos.BorderStyle = BorderStyle.FixedSingle
        pbmedicamentos.Location = New Point(1076, 177)
        pbmedicamentos.Name = "pbmedicamentos"
        pbmedicamentos.Size = New Size(180, 186)
        pbmedicamentos.SizeMode = PictureBoxSizeMode.Zoom
        pbmedicamentos.TabIndex = 3
        pbmedicamentos.TabStop = False
        ' 
        ' btnbuscar
        ' 
        btnbuscar.Location = New Point(996, 387)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(103, 40)
        btnbuscar.TabIndex = 4
        btnbuscar.Text = "Buscar Imagen "
        btnbuscar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar_ima
        ' 
        btnguardar_ima.Location = New Point(996, 446)
        btnguardar_ima.Name = "btnguardar_ima"
        btnguardar_ima.Size = New Size(103, 40)
        btnguardar_ima.TabIndex = 5
        btnguardar_ima.Text = "Guardar Imagen"
        btnguardar_ima.UseVisualStyleBackColor = True
        ' 
        ' btnquitar_ima
        ' 
        btnquitar_ima.Location = New Point(996, 515)
        btnquitar_ima.Name = "btnquitar_ima"
        btnquitar_ima.Size = New Size(103, 40)
        btnquitar_ima.TabIndex = 6
        btnquitar_ima.Text = "Quitar Imagen"
        btnquitar_ima.UseVisualStyleBackColor = True
        ' 
        ' medicamentos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1370, 749)
        Controls.Add(btnquitar_ima)
        Controls.Add(btnguardar_ima)
        Controls.Add(btnbuscar)
        Controls.Add(pbmedicamentos)
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1195, 749)
        Controls.Add(GroupBox2)
        Controls.Add(dgvmedicamento)
        Controls.Add(GroupBox1)
        Name = "medicamentos"
        Text = "medicamentos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvmedicamento, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(nudpedido, ComponentModel.ISupportInitialize).EndInit()
        CType(nudstockmax, ComponentModel.ISupportInitialize).EndInit()
        CType(nudstockmin, ComponentModel.ISupportInitialize).EndInit()
        CType(pbmedicamentos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents dgvmedicamento As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents cbreceta As CheckBox
    Friend WithEvents nudpedido As NumericUpDown
    Friend WithEvents nudstockmax As NumericUpDown
    Friend WithEvents nudstockmin As NumericUpDown
    Friend WithEvents cblaboratorio As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbterapeutica As ComboBox
    Friend WithEvents cbpresentacion As ComboBox
    Friend WithEvents cbdroga As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pbmedicamentos As PictureBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnguardar_ima As Button
    Friend WithEvents btnquitar_ima As Button
End Class
