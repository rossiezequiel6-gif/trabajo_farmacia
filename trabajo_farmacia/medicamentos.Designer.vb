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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medicamentos))
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtbuscar = New TextBox()
        dgvmedicamento = New DataGridView()
        GroupBox2 = New GroupBox()
        cbubicacion = New ComboBox()
        Label21 = New Label()
        btnmasubicacion = New Button()
        btnficha = New Button()
        btnmasdroga = New Button()
        btnmasaccion = New Button()
        btnmaspres = New Button()
        btnmaslaboratorio = New Button()
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
        Panel1 = New Panel()
        pnlcontenedorabm = New Panel()
        pnlabmubicacion = New Panel()
        btncerrarubi = New Button()
        btnmodificarubicacion = New Button()
        btneliminarubicacion = New Button()
        btnagregarubicacion = New Button()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        txtdetalleubicacion = New TextBox()
        Label16 = New Label()
        cbnivelubicacion = New ComboBox()
        cbestanteubicacion = New ComboBox()
        cbpasilloubicacion = New ComboBox()
        pnlabmdroga = New Panel()
        cbabmdroga = New ComboBox()
        btncerrardroga = New Button()
        btnmodificardroga = New Button()
        btneliminardroga = New Button()
        btnagregardroga = New Button()
        txtabmdroga = New TextBox()
        Label15 = New Label()
        pnlabmaccion = New Panel()
        cbabmaccion = New ComboBox()
        btncerraraccion = New Button()
        btnmodificaraccion = New Button()
        btneliminaraccion = New Button()
        btnagregaraccion = New Button()
        txtabmaccion = New TextBox()
        Label14 = New Label()
        pnlpresentacion = New Panel()
        cbabmpres = New ComboBox()
        btncerrarpres = New Button()
        btnmodificarpres = New Button()
        btneliminarpres = New Button()
        btnagregarpres = New Button()
        txtabmpresentacion = New TextBox()
        Label13 = New Label()
        pnllaboratorio = New Panel()
        cbabmlab = New ComboBox()
        btncerrarlab = New Button()
        btnmodificarlab = New Button()
        btneliminarlab = New Button()
        btnagregarlab = New Button()
        txtabmlab = New TextBox()
        Label8 = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        GroupBox1.SuspendLayout()
        CType(dgvmedicamento, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(nudpedido, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudstockmax, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudstockmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbmedicamentos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        pnlcontenedorabm.SuspendLayout()
        pnlabmubicacion.SuspendLayout()
        pnlabmdroga.SuspendLayout()
        pnlabmaccion.SuspendLayout()
        pnlpresentacion.SuspendLayout()
        pnllaboratorio.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSeaGreen
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtbuscar)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(11, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1510, 104)
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
        dgvmedicamento.Size = New Size(1173, 427)
        dgvmedicamento.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.DarkSeaGreen
        GroupBox2.BackgroundImageLayout = ImageLayout.None
        GroupBox2.Controls.Add(cbubicacion)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Controls.Add(btnmasubicacion)
        GroupBox2.Controls.Add(btnficha)
        GroupBox2.Controls.Add(btnmasdroga)
        GroupBox2.Controls.Add(btnmasaccion)
        GroupBox2.Controls.Add(btnmaspres)
        GroupBox2.Controls.Add(btnmaslaboratorio)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(cbreceta)
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
        GroupBox2.Location = New Point(11, 565)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1173, 461)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos de Medicamentos"
        ' 
        ' cbubicacion
        ' 
        cbubicacion.FormattingEnabled = True
        cbubicacion.Location = New Point(128, 398)
        cbubicacion.Name = "cbubicacion"
        cbubicacion.Size = New Size(281, 31)
        cbubicacion.TabIndex = 39
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(21, 403)
        Label21.Name = "Label21"
        Label21.Size = New Size(96, 20)
        Label21.TabIndex = 38
        Label21.Text = "UBICACIÓN:"
        ' 
        ' btnmasubicacion
        ' 
        btnmasubicacion.BackColor = Color.OliveDrab
        btnmasubicacion.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmasubicacion.Location = New Point(425, 390)
        btnmasubicacion.Name = "btnmasubicacion"
        btnmasubicacion.Size = New Size(37, 44)
        btnmasubicacion.TabIndex = 37
        btnmasubicacion.Text = "+"
        btnmasubicacion.UseVisualStyleBackColor = False
        ' 
        ' btnficha
        ' 
        btnficha.Location = New Point(1017, 388)
        btnficha.Margin = New Padding(3, 4, 3, 4)
        btnficha.Name = "btnficha"
        btnficha.Size = New Size(117, 67)
        btnficha.TabIndex = 36
        btnficha.Text = "Imprimir Ficha"
        btnficha.UseVisualStyleBackColor = True
        ' 
        ' btnmasdroga
        ' 
        btnmasdroga.BackColor = Color.OliveDrab
        btnmasdroga.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmasdroga.Location = New Point(425, 340)
        btnmasdroga.Name = "btnmasdroga"
        btnmasdroga.Size = New Size(37, 44)
        btnmasdroga.TabIndex = 35
        btnmasdroga.Text = "+"
        btnmasdroga.UseVisualStyleBackColor = False
        ' 
        ' btnmasaccion
        ' 
        btnmasaccion.BackColor = Color.OliveDrab
        btnmasaccion.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmasaccion.Location = New Point(425, 289)
        btnmasaccion.Name = "btnmasaccion"
        btnmasaccion.Size = New Size(37, 44)
        btnmasaccion.TabIndex = 34
        btnmasaccion.Text = "+"
        btnmasaccion.UseVisualStyleBackColor = False
        ' 
        ' btnmaspres
        ' 
        btnmaspres.BackColor = Color.OliveDrab
        btnmaspres.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmaspres.Location = New Point(425, 236)
        btnmaspres.Name = "btnmaspres"
        btnmaspres.Size = New Size(37, 44)
        btnmaspres.TabIndex = 33
        btnmaspres.Text = "+"
        btnmaspres.UseVisualStyleBackColor = False
        ' 
        ' btnmaslaboratorio
        ' 
        btnmaslaboratorio.BackColor = Color.OliveDrab
        btnmaslaboratorio.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmaslaboratorio.Location = New Point(425, 181)
        btnmaslaboratorio.Name = "btnmaslaboratorio"
        btnmaslaboratorio.Size = New Size(37, 44)
        btnmaslaboratorio.TabIndex = 32
        btnmaslaboratorio.Text = "+"
        btnmaslaboratorio.UseVisualStyleBackColor = False
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
        GroupBox3.Location = New Point(566, 59)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(281, 303)
        GroupBox3.TabIndex = 31
        GroupBox3.TabStop = False
        ' 
        ' nudpedido
        ' 
        nudpedido.Location = New Point(170, 161)
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
        Label11.Location = New Point(100, 148)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 20)
        Label11.TabIndex = 9
        Label11.Text = "STOCK MAX:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(104, 56)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 20)
        Label10.TabIndex = 8
        Label10.Text = "STOCK MIN:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(61, 230)
        Label12.Name = "Label12"
        Label12.Size = New Size(150, 20)
        Label12.TabIndex = 10
        Label12.Text = "PUNTO DE PEDIDO: "
        ' 
        ' cbreceta
        ' 
        cbreceta.AutoSize = True
        cbreceta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbreceta.Location = New Point(627, 374)
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
        pbmedicamentos.Location = New Point(18, 13)
        pbmedicamentos.Name = "pbmedicamentos"
        pbmedicamentos.Size = New Size(293, 262)
        pbmedicamentos.SizeMode = PictureBoxSizeMode.Zoom
        pbmedicamentos.TabIndex = 3
        pbmedicamentos.TabStop = False
        ' 
        ' btnbuscar
        ' 
        btnbuscar.Location = New Point(112, 292)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(103, 40)
        btnbuscar.TabIndex = 4
        btnbuscar.Text = "Buscar Imagen "
        btnbuscar.UseVisualStyleBackColor = True
        ' 
        ' btnguardar_ima
        ' 
        btnguardar_ima.Location = New Point(112, 338)
        btnguardar_ima.Name = "btnguardar_ima"
        btnguardar_ima.Size = New Size(103, 40)
        btnguardar_ima.TabIndex = 5
        btnguardar_ima.Text = "Guardar Imagen"
        btnguardar_ima.UseVisualStyleBackColor = True
        ' 
        ' btnquitar_ima
        ' 
        btnquitar_ima.Location = New Point(112, 384)
        btnquitar_ima.Name = "btnquitar_ima"
        btnquitar_ima.Size = New Size(103, 40)
        btnquitar_ima.TabIndex = 6
        btnquitar_ima.Text = "Quitar Imagen"
        btnquitar_ima.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnbuscar)
        Panel1.Controls.Add(pbmedicamentos)
        Panel1.Controls.Add(btnquitar_ima)
        Panel1.Controls.Add(btnguardar_ima)
        Panel1.Location = New Point(1190, 133)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(333, 427)
        Panel1.TabIndex = 7
        ' 
        ' pnlcontenedorabm
        ' 
        pnlcontenedorabm.BorderStyle = BorderStyle.FixedSingle
        pnlcontenedorabm.Controls.Add(pnlabmubicacion)
        pnlcontenedorabm.Controls.Add(pnlabmdroga)
        pnlcontenedorabm.Controls.Add(pnlabmaccion)
        pnlcontenedorabm.Controls.Add(pnlpresentacion)
        pnlcontenedorabm.Controls.Add(pnllaboratorio)
        pnlcontenedorabm.Location = New Point(1193, 565)
        pnlcontenedorabm.Name = "pnlcontenedorabm"
        pnlcontenedorabm.Size = New Size(333, 461)
        pnlcontenedorabm.TabIndex = 8
        pnlcontenedorabm.Visible = False
        ' 
        ' pnlabmubicacion
        ' 
        pnlabmubicacion.Controls.Add(btncerrarubi)
        pnlabmubicacion.Controls.Add(btnmodificarubicacion)
        pnlabmubicacion.Controls.Add(btneliminarubicacion)
        pnlabmubicacion.Controls.Add(btnagregarubicacion)
        pnlabmubicacion.Controls.Add(Label20)
        pnlabmubicacion.Controls.Add(Label19)
        pnlabmubicacion.Controls.Add(Label18)
        pnlabmubicacion.Controls.Add(Label17)
        pnlabmubicacion.Controls.Add(txtdetalleubicacion)
        pnlabmubicacion.Controls.Add(Label16)
        pnlabmubicacion.Controls.Add(cbnivelubicacion)
        pnlabmubicacion.Controls.Add(cbestanteubicacion)
        pnlabmubicacion.Controls.Add(cbpasilloubicacion)
        pnlabmubicacion.Dock = DockStyle.Fill
        pnlabmubicacion.Location = New Point(0, 0)
        pnlabmubicacion.Name = "pnlabmubicacion"
        pnlabmubicacion.Size = New Size(331, 459)
        pnlabmubicacion.TabIndex = 37
        ' 
        ' btncerrarubi
        ' 
        btncerrarubi.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerrarubi.ForeColor = Color.Red
        btncerrarubi.Location = New Point(288, 3)
        btncerrarubi.Name = "btncerrarubi"
        btncerrarubi.Size = New Size(40, 29)
        btncerrarubi.TabIndex = 62
        btncerrarubi.Text = "X"
        btncerrarubi.UseVisualStyleBackColor = True
        ' 
        ' btnmodificarubicacion
        ' 
        btnmodificarubicacion.Location = New Point(115, 396)
        btnmodificarubicacion.Name = "btnmodificarubicacion"
        btnmodificarubicacion.Size = New Size(102, 49)
        btnmodificarubicacion.TabIndex = 52
        btnmodificarubicacion.Text = "MODIFICAR"
        btnmodificarubicacion.UseVisualStyleBackColor = True
        ' 
        ' btneliminarubicacion
        ' 
        btneliminarubicacion.Location = New Point(115, 336)
        btneliminarubicacion.Name = "btneliminarubicacion"
        btneliminarubicacion.Size = New Size(102, 49)
        btneliminarubicacion.TabIndex = 52
        btneliminarubicacion.Text = "ELIMINAR"
        btneliminarubicacion.UseVisualStyleBackColor = True
        ' 
        ' btnagregarubicacion
        ' 
        btnagregarubicacion.Location = New Point(115, 277)
        btnagregarubicacion.Name = "btnagregarubicacion"
        btnagregarubicacion.Size = New Size(102, 49)
        btnagregarubicacion.TabIndex = 61
        btnagregarubicacion.Text = "AGREGAR"
        btnagregarubicacion.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(15, 220)
        Label20.Name = "Label20"
        Label20.Size = New Size(62, 20)
        Label20.TabIndex = 60
        Label20.Text = "Detalle:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(27, 177)
        Label19.Name = "Label19"
        Label19.Size = New Size(49, 20)
        Label19.TabIndex = 59
        Label19.Text = "Nivel:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(18, 131)
        Label18.Name = "Label18"
        Label18.Size = New Size(65, 20)
        Label18.TabIndex = 58
        Label18.Text = "Estante:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(18, 85)
        Label17.Name = "Label17"
        Label17.Size = New Size(58, 20)
        Label17.TabIndex = 57
        Label17.Text = "Pasillo:"
        ' 
        ' txtdetalleubicacion
        ' 
        txtdetalleubicacion.Location = New Point(85, 217)
        txtdetalleubicacion.Name = "txtdetalleubicacion"
        txtdetalleubicacion.Size = New Size(220, 27)
        txtdetalleubicacion.TabIndex = 56
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(105, 23)
        Label16.Name = "Label16"
        Label16.Size = New Size(103, 23)
        Label16.TabIndex = 55
        Label16.Text = "UBICACIÓN"
        ' 
        ' cbnivelubicacion
        ' 
        cbnivelubicacion.FormattingEnabled = True
        cbnivelubicacion.Location = New Point(85, 174)
        cbnivelubicacion.Name = "cbnivelubicacion"
        cbnivelubicacion.Size = New Size(220, 28)
        cbnivelubicacion.TabIndex = 54
        ' 
        ' cbestanteubicacion
        ' 
        cbestanteubicacion.FormattingEnabled = True
        cbestanteubicacion.Location = New Point(85, 128)
        cbestanteubicacion.Name = "cbestanteubicacion"
        cbestanteubicacion.Size = New Size(220, 28)
        cbestanteubicacion.TabIndex = 53
        ' 
        ' cbpasilloubicacion
        ' 
        cbpasilloubicacion.FormattingEnabled = True
        cbpasilloubicacion.Location = New Point(85, 82)
        cbpasilloubicacion.Name = "cbpasilloubicacion"
        cbpasilloubicacion.Size = New Size(220, 28)
        cbpasilloubicacion.TabIndex = 52
        ' 
        ' pnlabmdroga
        ' 
        pnlabmdroga.Controls.Add(cbabmdroga)
        pnlabmdroga.Controls.Add(btncerrardroga)
        pnlabmdroga.Controls.Add(btnmodificardroga)
        pnlabmdroga.Controls.Add(btneliminardroga)
        pnlabmdroga.Controls.Add(btnagregardroga)
        pnlabmdroga.Controls.Add(txtabmdroga)
        pnlabmdroga.Controls.Add(Label15)
        pnlabmdroga.Dock = DockStyle.Fill
        pnlabmdroga.Location = New Point(0, 0)
        pnlabmdroga.Name = "pnlabmdroga"
        pnlabmdroga.Size = New Size(331, 459)
        pnlabmdroga.TabIndex = 36
        pnlabmdroga.Visible = False
        ' 
        ' cbabmdroga
        ' 
        cbabmdroga.FormattingEnabled = True
        cbabmdroga.Location = New Point(25, 115)
        cbabmdroga.Name = "cbabmdroga"
        cbabmdroga.Size = New Size(283, 28)
        cbabmdroga.TabIndex = 51
        ' 
        ' btncerrardroga
        ' 
        btncerrardroga.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerrardroga.ForeColor = Color.Red
        btncerrardroga.Location = New Point(289, 1)
        btncerrardroga.Name = "btncerrardroga"
        btncerrardroga.Size = New Size(40, 29)
        btncerrardroga.TabIndex = 50
        btncerrardroga.Text = "X"
        btncerrardroga.UseVisualStyleBackColor = True
        ' 
        ' btnmodificardroga
        ' 
        btnmodificardroga.Location = New Point(118, 373)
        btnmodificardroga.Name = "btnmodificardroga"
        btnmodificardroga.Size = New Size(102, 49)
        btnmodificardroga.TabIndex = 49
        btnmodificardroga.Text = "MODIFICAR"
        btnmodificardroga.UseVisualStyleBackColor = True
        ' 
        ' btneliminardroga
        ' 
        btneliminardroga.Location = New Point(118, 304)
        btneliminardroga.Name = "btneliminardroga"
        btneliminardroga.Size = New Size(102, 49)
        btneliminardroga.TabIndex = 48
        btneliminardroga.Text = "ELIMINAR"
        btneliminardroga.UseVisualStyleBackColor = True
        ' 
        ' btnagregardroga
        ' 
        btnagregardroga.Location = New Point(118, 233)
        btnagregardroga.Name = "btnagregardroga"
        btnagregardroga.Size = New Size(102, 49)
        btnagregardroga.TabIndex = 47
        btnagregardroga.Text = "AGREGAR"
        btnagregardroga.UseVisualStyleBackColor = True
        ' 
        ' txtabmdroga
        ' 
        txtabmdroga.Location = New Point(25, 179)
        txtabmdroga.Name = "txtabmdroga"
        txtabmdroga.Size = New Size(283, 27)
        txtabmdroga.TabIndex = 46
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(35, 83)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 23)
        Label15.TabIndex = 45
        Label15.Text = "DROGA"
        ' 
        ' pnlabmaccion
        ' 
        pnlabmaccion.Controls.Add(cbabmaccion)
        pnlabmaccion.Controls.Add(btncerraraccion)
        pnlabmaccion.Controls.Add(btnmodificaraccion)
        pnlabmaccion.Controls.Add(btneliminaraccion)
        pnlabmaccion.Controls.Add(btnagregaraccion)
        pnlabmaccion.Controls.Add(txtabmaccion)
        pnlabmaccion.Controls.Add(Label14)
        pnlabmaccion.Dock = DockStyle.Fill
        pnlabmaccion.Location = New Point(0, 0)
        pnlabmaccion.Name = "pnlabmaccion"
        pnlabmaccion.Size = New Size(331, 459)
        pnlabmaccion.TabIndex = 36
        pnlabmaccion.Visible = False
        ' 
        ' cbabmaccion
        ' 
        cbabmaccion.FormattingEnabled = True
        cbabmaccion.Location = New Point(25, 115)
        cbabmaccion.Name = "cbabmaccion"
        cbabmaccion.Size = New Size(283, 28)
        cbabmaccion.TabIndex = 44
        ' 
        ' btncerraraccion
        ' 
        btncerraraccion.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerraraccion.ForeColor = Color.Red
        btncerraraccion.Location = New Point(289, 1)
        btncerraraccion.Name = "btncerraraccion"
        btncerraraccion.Size = New Size(40, 29)
        btncerraraccion.TabIndex = 43
        btncerraraccion.Text = "X"
        btncerraraccion.UseVisualStyleBackColor = True
        ' 
        ' btnmodificaraccion
        ' 
        btnmodificaraccion.Location = New Point(118, 373)
        btnmodificaraccion.Name = "btnmodificaraccion"
        btnmodificaraccion.Size = New Size(102, 49)
        btnmodificaraccion.TabIndex = 42
        btnmodificaraccion.Text = "MODIFICAR"
        btnmodificaraccion.UseVisualStyleBackColor = True
        ' 
        ' btneliminaraccion
        ' 
        btneliminaraccion.Location = New Point(118, 304)
        btneliminaraccion.Name = "btneliminaraccion"
        btneliminaraccion.Size = New Size(102, 49)
        btneliminaraccion.TabIndex = 41
        btneliminaraccion.Text = "ELIMINAR"
        btneliminaraccion.UseVisualStyleBackColor = True
        ' 
        ' btnagregaraccion
        ' 
        btnagregaraccion.Location = New Point(118, 233)
        btnagregaraccion.Name = "btnagregaraccion"
        btnagregaraccion.Size = New Size(102, 49)
        btnagregaraccion.TabIndex = 40
        btnagregaraccion.Text = "AGREGAR"
        btnagregaraccion.UseVisualStyleBackColor = True
        ' 
        ' txtabmaccion
        ' 
        txtabmaccion.Location = New Point(25, 179)
        txtabmaccion.Name = "txtabmaccion"
        txtabmaccion.Size = New Size(283, 27)
        txtabmaccion.TabIndex = 39
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(35, 83)
        Label14.Name = "Label14"
        Label14.Size = New Size(190, 23)
        Label14.TabIndex = 38
        Label14.Text = "ACCIÓN TERAPÉUTICA"
        ' 
        ' pnlpresentacion
        ' 
        pnlpresentacion.Controls.Add(cbabmpres)
        pnlpresentacion.Controls.Add(btncerrarpres)
        pnlpresentacion.Controls.Add(btnmodificarpres)
        pnlpresentacion.Controls.Add(btneliminarpres)
        pnlpresentacion.Controls.Add(btnagregarpres)
        pnlpresentacion.Controls.Add(txtabmpresentacion)
        pnlpresentacion.Controls.Add(Label13)
        pnlpresentacion.Dock = DockStyle.Fill
        pnlpresentacion.Location = New Point(0, 0)
        pnlpresentacion.Name = "pnlpresentacion"
        pnlpresentacion.Size = New Size(331, 459)
        pnlpresentacion.TabIndex = 36
        pnlpresentacion.Visible = False
        ' 
        ' cbabmpres
        ' 
        cbabmpres.FormattingEnabled = True
        cbabmpres.Location = New Point(25, 117)
        cbabmpres.Name = "cbabmpres"
        cbabmpres.Size = New Size(283, 28)
        cbabmpres.TabIndex = 37
        ' 
        ' btncerrarpres
        ' 
        btncerrarpres.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerrarpres.ForeColor = Color.Red
        btncerrarpres.Location = New Point(289, 4)
        btncerrarpres.Name = "btncerrarpres"
        btncerrarpres.Size = New Size(40, 29)
        btncerrarpres.TabIndex = 36
        btncerrarpres.Text = "X"
        btncerrarpres.UseVisualStyleBackColor = True
        ' 
        ' btnmodificarpres
        ' 
        btnmodificarpres.Location = New Point(118, 376)
        btnmodificarpres.Name = "btnmodificarpres"
        btnmodificarpres.Size = New Size(102, 49)
        btnmodificarpres.TabIndex = 35
        btnmodificarpres.Text = "MODIFICAR"
        btnmodificarpres.UseVisualStyleBackColor = True
        ' 
        ' btneliminarpres
        ' 
        btneliminarpres.Location = New Point(118, 307)
        btneliminarpres.Name = "btneliminarpres"
        btneliminarpres.Size = New Size(102, 49)
        btneliminarpres.TabIndex = 34
        btneliminarpres.Text = "ELIMINAR"
        btneliminarpres.UseVisualStyleBackColor = True
        ' 
        ' btnagregarpres
        ' 
        btnagregarpres.Location = New Point(118, 236)
        btnagregarpres.Name = "btnagregarpres"
        btnagregarpres.Size = New Size(102, 49)
        btnagregarpres.TabIndex = 33
        btnagregarpres.Text = "AGREGAR"
        btnagregarpres.UseVisualStyleBackColor = True
        ' 
        ' txtabmpresentacion
        ' 
        txtabmpresentacion.Location = New Point(25, 181)
        txtabmpresentacion.Name = "txtabmpresentacion"
        txtabmpresentacion.Size = New Size(283, 27)
        txtabmpresentacion.TabIndex = 32
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(35, 85)
        Label13.Name = "Label13"
        Label13.Size = New Size(135, 23)
        Label13.TabIndex = 31
        Label13.Text = "PRESENTACIÓN"
        ' 
        ' pnllaboratorio
        ' 
        pnllaboratorio.Controls.Add(cbabmlab)
        pnllaboratorio.Controls.Add(btncerrarlab)
        pnllaboratorio.Controls.Add(btnmodificarlab)
        pnllaboratorio.Controls.Add(btneliminarlab)
        pnllaboratorio.Controls.Add(btnagregarlab)
        pnllaboratorio.Controls.Add(txtabmlab)
        pnllaboratorio.Controls.Add(Label8)
        pnllaboratorio.Dock = DockStyle.Fill
        pnllaboratorio.Location = New Point(0, 0)
        pnllaboratorio.Name = "pnllaboratorio"
        pnllaboratorio.Size = New Size(331, 459)
        pnllaboratorio.TabIndex = 0
        pnllaboratorio.Visible = False
        ' 
        ' cbabmlab
        ' 
        cbabmlab.FormattingEnabled = True
        cbabmlab.Location = New Point(25, 117)
        cbabmlab.Name = "cbabmlab"
        cbabmlab.Size = New Size(283, 28)
        cbabmlab.TabIndex = 30
        ' 
        ' btncerrarlab
        ' 
        btncerrarlab.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerrarlab.ForeColor = Color.Red
        btncerrarlab.Location = New Point(289, 3)
        btncerrarlab.Name = "btncerrarlab"
        btncerrarlab.Size = New Size(40, 29)
        btncerrarlab.TabIndex = 5
        btncerrarlab.Text = "X"
        btncerrarlab.UseVisualStyleBackColor = True
        ' 
        ' btnmodificarlab
        ' 
        btnmodificarlab.Location = New Point(118, 375)
        btnmodificarlab.Name = "btnmodificarlab"
        btnmodificarlab.Size = New Size(102, 49)
        btnmodificarlab.TabIndex = 4
        btnmodificarlab.Text = "MODIFICAR"
        btnmodificarlab.UseVisualStyleBackColor = True
        ' 
        ' btneliminarlab
        ' 
        btneliminarlab.Location = New Point(118, 307)
        btneliminarlab.Name = "btneliminarlab"
        btneliminarlab.Size = New Size(102, 49)
        btneliminarlab.TabIndex = 3
        btneliminarlab.Text = "ELIMINAR"
        btneliminarlab.UseVisualStyleBackColor = True
        ' 
        ' btnagregarlab
        ' 
        btnagregarlab.Location = New Point(118, 235)
        btnagregarlab.Name = "btnagregarlab"
        btnagregarlab.Size = New Size(102, 49)
        btnagregarlab.TabIndex = 2
        btnagregarlab.Text = "AGREGAR"
        btnagregarlab.UseVisualStyleBackColor = True
        ' 
        ' txtabmlab
        ' 
        txtabmlab.Location = New Point(25, 180)
        txtabmlab.Name = "txtabmlab"
        txtabmlab.Size = New Size(283, 27)
        txtabmlab.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(35, 84)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 23)
        Label8.TabIndex = 0
        Label8.Text = "LABORATORIO"
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
        ' medicamentos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1526, 1028)
        Controls.Add(pnlcontenedorabm)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        pnlcontenedorabm.ResumeLayout(False)
        pnlabmubicacion.ResumeLayout(False)
        pnlabmubicacion.PerformLayout()
        pnlabmdroga.ResumeLayout(False)
        pnlabmdroga.PerformLayout()
        pnlabmaccion.ResumeLayout(False)
        pnlabmaccion.PerformLayout()
        pnlpresentacion.ResumeLayout(False)
        pnlpresentacion.PerformLayout()
        pnllaboratorio.ResumeLayout(False)
        pnllaboratorio.PerformLayout()
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
    Friend WithEvents btnmasdroga As Button
    Friend WithEvents btnmasaccion As Button
    Friend WithEvents btnmaspres As Button
    Friend WithEvents btnmaslaboratorio As Button
    Friend WithEvents pbmedicamentos As PictureBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnguardar_ima As Button
    Friend WithEvents btnquitar_ima As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlcontenedorabm As Panel
    Friend WithEvents pnllaboratorio As Panel
    Friend WithEvents btnmodificarlab As Button
    Friend WithEvents btneliminarlab As Button
    Friend WithEvents btnagregarlab As Button
    Friend WithEvents txtabmlab As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btncerrarlab As Button
    Friend WithEvents cbabmlab As ComboBox
    Friend WithEvents pnlpresentacion As Panel
    Friend WithEvents pnlabmaccion As Panel
    Friend WithEvents cbabmaccion As ComboBox
    Friend WithEvents btncerraraccion As Button
    Friend WithEvents btnmodificaraccion As Button
    Friend WithEvents btneliminaraccion As Button
    Friend WithEvents btnagregaraccion As Button
    Friend WithEvents txtabmaccion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbabmpres As ComboBox
    Friend WithEvents btncerrarpres As Button
    Friend WithEvents btnmodificarpres As Button
    Friend WithEvents btneliminarpres As Button
    Friend WithEvents btnagregarpres As Button
    Friend WithEvents txtabmpresentacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents pnlabmdroga As Panel
    Friend WithEvents cbabmdroga As ComboBox
    Friend WithEvents btncerrardroga As Button
    Friend WithEvents btnmodificardroga As Button
    Friend WithEvents btneliminardroga As Button
    Friend WithEvents btnagregardroga As Button
    Friend WithEvents txtabmdroga As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnficha As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents pnlabmubicacion As Panel
    Friend WithEvents btneliminarubicacion As Button
    Friend WithEvents btnagregarubicacion As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtdetalleubicacion As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbnivelubicacion As ComboBox
    Friend WithEvents cbestanteubicacion As ComboBox
    Friend WithEvents cbpasilloubicacion As ComboBox
    Friend WithEvents btncerrarubi As Button
    Friend WithEvents btnmodificarubicacion As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btnmasubicacion As Button
    Friend WithEvents cbubicacion As ComboBox
End Class
