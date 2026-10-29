<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromproveedores
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
        dgvprovedores = New DataGridView()
        gbproveedores = New GroupBox()
        Label6 = New Label()
        cbestado = New ComboBox()
        btnlimpiar = New Button()
        btneliminar = New Button()
        btnmodificar = New Button()
        btnguardar = New Button()
        txtnombre = New TextBox()
        txttelefono = New TextBox()
        txtdireccion = New TextBox()
        txtcuil = New TextBox()
        txtidproveedor = New TextBox()
        Label9 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtbuscarprov = New TextBox()
        GroupBox1 = New GroupBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(dgvprovedores, ComponentModel.ISupportInitialize).BeginInit()
        gbproveedores.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvprovedores
        ' 
        dgvprovedores.ColumnHeadersHeight = 29
        dgvprovedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvprovedores.Location = New Point(345, 75)
        dgvprovedores.Margin = New Padding(3, 4, 3, 4)
        dgvprovedores.Name = "dgvprovedores"
        dgvprovedores.RowHeadersWidth = 51
        dgvprovedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvprovedores.Size = New Size(720, 351)
        dgvprovedores.TabIndex = 0
        ' 
        ' gbproveedores
        ' 
        gbproveedores.BackColor = Color.DarkSeaGreen
        gbproveedores.BackgroundImageLayout = ImageLayout.None
        gbproveedores.Controls.Add(Label6)
        gbproveedores.Controls.Add(cbestado)
        gbproveedores.Controls.Add(btnlimpiar)
        gbproveedores.Controls.Add(btneliminar)
        gbproveedores.Controls.Add(btnmodificar)
        gbproveedores.Controls.Add(btnguardar)
        gbproveedores.Controls.Add(txtnombre)
        gbproveedores.Controls.Add(txttelefono)
        gbproveedores.Controls.Add(txtdireccion)
        gbproveedores.Controls.Add(txtcuil)
        gbproveedores.Controls.Add(txtidproveedor)
        gbproveedores.Controls.Add(Label9)
        gbproveedores.Controls.Add(Label5)
        gbproveedores.Controls.Add(Label4)
        gbproveedores.Controls.Add(Label3)
        gbproveedores.Controls.Add(Label2)
        gbproveedores.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbproveedores.Location = New Point(345, 433)
        gbproveedores.Name = "gbproveedores"
        gbproveedores.Size = New Size(720, 357)
        gbproveedores.TabIndex = 3
        gbproveedores.TabStop = False
        gbproveedores.Text = "Datos de Proveedores "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(330, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 27
        Label6.Text = "ESTADO:"
        ' 
        ' cbestado
        ' 
        cbestado.FormattingEnabled = True
        cbestado.Location = New Point(417, 25)
        cbestado.Margin = New Padding(3, 4, 3, 4)
        cbestado.Name = "cbestado"
        cbestado.Size = New Size(167, 31)
        cbestado.TabIndex = 5
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = Color.PaleGreen
        btnlimpiar.Location = New Point(592, 217)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(117, 63)
        btnlimpiar.TabIndex = 26
        btnlimpiar.Text = "LIMPIAR CAMPOS"
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = Color.Crimson
        btneliminar.Location = New Point(592, 157)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(117, 47)
        btneliminar.TabIndex = 25
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = SystemColors.ActiveCaption
        btnmodificar.Location = New Point(592, 99)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(117, 47)
        btnmodificar.TabIndex = 24
        btnmodificar.Text = "MODIFICAR"
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = SystemColors.ActiveCaption
        btnguardar.Location = New Point(592, 35)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(117, 47)
        btnguardar.TabIndex = 23
        btnguardar.Text = "GUARDAR"
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(150, 143)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(162, 30)
        txtnombre.TabIndex = 16
        ' 
        ' txttelefono
        ' 
        txttelefono.Location = New Point(150, 268)
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(162, 30)
        txttelefono.TabIndex = 14
        ' 
        ' txtdireccion
        ' 
        txtdireccion.Location = New Point(150, 217)
        txtdireccion.Name = "txtdireccion"
        txtdireccion.Size = New Size(262, 30)
        txtdireccion.TabIndex = 13
        ' 
        ' txtcuil
        ' 
        txtcuil.Location = New Point(150, 79)
        txtcuil.Name = "txtcuil"
        txtcuil.Size = New Size(162, 30)
        txtcuil.TabIndex = 12
        ' 
        ' txtidproveedor
        ' 
        txtidproveedor.Location = New Point(150, 35)
        txtidproveedor.Name = "txtidproveedor"
        txtidproveedor.ReadOnly = True
        txtidproveedor.Size = New Size(125, 30)
        txtidproveedor.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(34, 283)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 20)
        Label9.TabIndex = 7
        Label9.Text = "TELEFONO:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 3
        Label5.Text = "CUIL:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 2
        Label4.Text = "DIRECCIÓN:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 1
        Label3.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 20)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 4
        Label1.Text = "PROVEEDORES"
        ' 
        ' txtbuscarprov
        ' 
        txtbuscarprov.Location = New Point(199, 13)
        txtbuscarprov.Margin = New Padding(3, 4, 3, 4)
        txtbuscarprov.Name = "txtbuscarprov"
        txtbuscarprov.Size = New Size(361, 27)
        txtbuscarprov.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSeaGreen
        GroupBox1.Controls.Add(txtbuscarprov)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(345, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(720, 53)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar"
        ' 
        ' fromproveedores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1119, 802)
        Controls.Add(GroupBox1)
        Controls.Add(gbproveedores)
        Controls.Add(dgvprovedores)
        Margin = New Padding(3, 4, 3, 4)
        Name = "fromproveedores"
        Text = "fromproveedores"
        CType(dgvprovedores, ComponentModel.ISupportInitialize).EndInit()
        gbproveedores.ResumeLayout(False)
        gbproveedores.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvprovedores As DataGridView
    Friend WithEvents gbproveedores As GroupBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents cbreceta As CheckBox
    Friend WithEvents nudpedido As NumericUpDown
    Friend WithEvents nudstockmax As NumericUpDown
    Friend WithEvents nudstockmin As NumericUpDown
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtterapeutica As TextBox
    Friend WithEvents txtlaboratorio As TextBox
    Friend WithEvents txtpresentacion As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcuil As TextBox
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbestado As ComboBox
    Friend WithEvents txtbuscarprov As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
