<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formusuarios
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
        Label1 = New Label()
        Panel2 = New Panel()
        btnqitar = New Button()
        btnagregar = New Button()
        btnbuscar = New Button()
        pbusuarios = New PictureBox()
        Label2 = New Label()
        Panel5 = New Panel()
        Label7 = New Label()
        btnlimpiarusu = New Button()
        btnguardarusu = New Button()
        Label3 = New Label()
        txtnombrecomp = New TextBox()
        btneliminar = New Button()
        txtusuario = New TextBox()
        Label4 = New Label()
        txtclave = New TextBox()
        btnmodifusu = New Button()
        cbrol = New ComboBox()
        Label5 = New Label()
        Panel3 = New Panel()
        dgvusuarios = New DataGridView()
        txtbuscarusuario = New TextBox()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbusuarios, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(20, 17)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1314, 86)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(270, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(704, 41)
        Label1.TabIndex = 0
        Label1.Text = "GESTION DE USUARIOS Y PERMISOS DE ACCESO"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(btnqitar)
        Panel2.Controls.Add(btnagregar)
        Panel2.Controls.Add(btnbuscar)
        Panel2.Controls.Add(pbusuarios)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(btnlimpiarusu)
        Panel2.Controls.Add(btnguardarusu)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtnombrecomp)
        Panel2.Controls.Add(btneliminar)
        Panel2.Controls.Add(txtusuario)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtclave)
        Panel2.Controls.Add(btnmodifusu)
        Panel2.Controls.Add(cbrol)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(20, 125)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(652, 621)
        Panel2.TabIndex = 1
        ' 
        ' btnqitar
        ' 
        btnqitar.Location = New Point(461, 162)
        btnqitar.Name = "btnqitar"
        btnqitar.Size = New Size(89, 40)
        btnqitar.TabIndex = 17
        btnqitar.Text = "Quitar"
        btnqitar.UseVisualStyleBackColor = True
        ' 
        ' btnagregar
        ' 
        btnagregar.Location = New Point(462, 89)
        btnagregar.Name = "btnagregar"
        btnagregar.Size = New Size(89, 40)
        btnagregar.TabIndex = 16
        btnagregar.Text = "Agregar"
        btnagregar.UseVisualStyleBackColor = True
        ' 
        ' btnbuscar
        ' 
        btnbuscar.Location = New Point(461, 26)
        btnbuscar.Name = "btnbuscar"
        btnbuscar.Size = New Size(90, 34)
        btnbuscar.TabIndex = 15
        btnbuscar.Text = "Buscar"
        btnbuscar.UseVisualStyleBackColor = True
        ' 
        ' pbusuarios
        ' 
        pbusuarios.Location = New Point(14, 14)
        pbusuarios.Name = "pbusuarios"
        pbusuarios.Size = New Size(229, 188)
        pbusuarios.TabIndex = 14
        pbusuarios.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 19)
        Label2.TabIndex = 0
        Label2.Text = "USUARIO :"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkSeaGreen
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(0, 226)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(652, 50)
        Panel5.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(173, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(253, 32)
        Label7.TabIndex = 2
        Label7.Text = "DATOS DEL USUARIO"
        ' 
        ' btnlimpiarusu
        ' 
        btnlimpiarusu.Location = New Point(492, 386)
        btnlimpiarusu.Margin = New Padding(3, 2, 3, 2)
        btnlimpiarusu.Name = "btnlimpiarusu"
        btnlimpiarusu.Size = New Size(98, 50)
        btnlimpiarusu.TabIndex = 11
        btnlimpiarusu.Text = "LIMPIAR CAMPOS"
        btnlimpiarusu.UseVisualStyleBackColor = True
        ' 
        ' btnguardarusu
        ' 
        btnguardarusu.Location = New Point(492, 311)
        btnguardarusu.Margin = New Padding(3, 2, 3, 2)
        btnguardarusu.Name = "btnguardarusu"
        btnguardarusu.Size = New Size(98, 49)
        btnguardarusu.TabIndex = 8
        btnguardarusu.Text = "GUARDAR"
        btnguardarusu.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 402)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 19)
        Label3.TabIndex = 1
        Label3.Text = "NOMBRE COMPLETO :"
        ' 
        ' txtnombrecomp
        ' 
        txtnombrecomp.Location = New Point(184, 402)
        txtnombrecomp.Margin = New Padding(3, 2, 3, 2)
        txtnombrecomp.Name = "txtnombrecomp"
        txtnombrecomp.Size = New Size(218, 23)
        txtnombrecomp.TabIndex = 6
        ' 
        ' btneliminar
        ' 
        btneliminar.Location = New Point(492, 462)
        btneliminar.Margin = New Padding(3, 2, 3, 2)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(98, 49)
        btneliminar.TabIndex = 10
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(184, 326)
        txtusuario.Margin = New Padding(3, 2, 3, 2)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(218, 23)
        txtusuario.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(116, 477)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 19)
        Label4.TabIndex = 2
        Label4.Text = "CLAVE :"
        ' 
        ' txtclave
        ' 
        txtclave.Location = New Point(184, 477)
        txtclave.Margin = New Padding(3, 2, 3, 2)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(218, 23)
        txtclave.TabIndex = 7
        ' 
        ' btnmodifusu
        ' 
        btnmodifusu.Location = New Point(492, 534)
        btnmodifusu.Margin = New Padding(3, 2, 3, 2)
        btnmodifusu.Name = "btnmodifusu"
        btnmodifusu.Size = New Size(98, 50)
        btnmodifusu.TabIndex = 9
        btnmodifusu.Text = "MODIFICAR"
        btnmodifusu.UseVisualStyleBackColor = True
        ' 
        ' cbrol
        ' 
        cbrol.FormattingEnabled = True
        cbrol.Location = New Point(184, 550)
        cbrol.Margin = New Padding(3, 2, 3, 2)
        cbrol.Name = "cbrol"
        cbrol.Size = New Size(218, 23)
        cbrol.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(132, 550)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 19)
        Label5.TabIndex = 3
        Label5.Text = "ROL :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(dgvusuarios)
        Panel3.Controls.Add(txtbuscarusuario)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(680, 125)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(654, 621)
        Panel3.TabIndex = 2
        ' 
        ' dgvusuarios
        ' 
        dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvusuarios.Location = New Point(0, 47)
        dgvusuarios.Margin = New Padding(3, 2, 3, 2)
        dgvusuarios.Name = "dgvusuarios"
        dgvusuarios.RowHeadersWidth = 51
        dgvusuarios.Size = New Size(654, 574)
        dgvusuarios.TabIndex = 7
        ' 
        ' txtbuscarusuario
        ' 
        txtbuscarusuario.Location = New Point(89, 14)
        txtbuscarusuario.Margin = New Padding(3, 2, 3, 2)
        txtbuscarusuario.Name = "txtbuscarusuario"
        txtbuscarusuario.Size = New Size(219, 23)
        txtbuscarusuario.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 19)
        Label6.TabIndex = 1
        Label6.Text = "BUSCAR:"
        ' 
        ' Formusuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        ClientSize = New Size(1327, 562)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Formusuarios"
        Text = "Formusuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbusuarios, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbrol As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnlimpiarusu As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodifusu As Button
    Friend WithEvents btnguardarusu As Button
    Friend WithEvents txtclave As TextBox
    Friend WithEvents txtnombrecomp As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents txtbuscarusuario As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pbusuarios As PictureBox
    Friend WithEvents btnqitar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnbuscar As Button
End Class
