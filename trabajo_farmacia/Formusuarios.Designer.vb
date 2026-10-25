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
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(23, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1502, 115)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(309, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(864, 50)
        Label1.TabIndex = 0
        Label1.Text = "GESTION DE USUARIOS Y PERMISOS DE ACCESO"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
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
        Panel2.Location = New Point(23, 167)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(745, 828)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(109, 435)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 23)
        Label2.TabIndex = 0
        Label2.Text = "USUARIO :"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkSeaGreen
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(0, 302)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(745, 66)
        Panel5.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(198, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(319, 41)
        Label7.TabIndex = 2
        Label7.Text = "DATOS DEL USUARIO"
        ' 
        ' btnlimpiarusu
        ' 
        btnlimpiarusu.Location = New Point(562, 515)
        btnlimpiarusu.Name = "btnlimpiarusu"
        btnlimpiarusu.Size = New Size(112, 66)
        btnlimpiarusu.TabIndex = 11
        btnlimpiarusu.Text = "LIMPIAR CAMPOS"
        btnlimpiarusu.UseVisualStyleBackColor = True
        ' 
        ' btnguardarusu
        ' 
        btnguardarusu.Location = New Point(562, 415)
        btnguardarusu.Name = "btnguardarusu"
        btnguardarusu.Size = New Size(112, 65)
        btnguardarusu.TabIndex = 8
        btnguardarusu.Text = "GUARDAR"
        btnguardarusu.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 536)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 23)
        Label3.TabIndex = 1
        Label3.Text = "NOMBRE COMPLETO :"
        ' 
        ' txtnombrecomp
        ' 
        txtnombrecomp.Location = New Point(210, 536)
        txtnombrecomp.Name = "txtnombrecomp"
        txtnombrecomp.Size = New Size(248, 27)
        txtnombrecomp.TabIndex = 6
        ' 
        ' btneliminar
        ' 
        btneliminar.Location = New Point(562, 616)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(112, 65)
        btneliminar.TabIndex = 10
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(210, 435)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(248, 27)
        txtusuario.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(133, 636)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 23)
        Label4.TabIndex = 2
        Label4.Text = "CLAVE :"
        ' 
        ' txtclave
        ' 
        txtclave.Location = New Point(210, 636)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(248, 27)
        txtclave.TabIndex = 7
        ' 
        ' btnmodifusu
        ' 
        btnmodifusu.Location = New Point(562, 712)
        btnmodifusu.Name = "btnmodifusu"
        btnmodifusu.Size = New Size(112, 66)
        btnmodifusu.TabIndex = 9
        btnmodifusu.Text = "MODIFICAR"
        btnmodifusu.UseVisualStyleBackColor = True
        ' 
        ' cbrol
        ' 
        cbrol.FormattingEnabled = True
        cbrol.Location = New Point(210, 733)
        cbrol.Name = "cbrol"
        cbrol.Size = New Size(248, 28)
        cbrol.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(151, 733)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 23)
        Label5.TabIndex = 3
        Label5.Text = "ROL :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(dgvusuarios)
        Panel3.Controls.Add(txtbuscarusuario)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(777, 167)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(748, 828)
        Panel3.TabIndex = 2
        ' 
        ' dgvusuarios
        ' 
        dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvusuarios.Location = New Point(0, 63)
        dgvusuarios.Name = "dgvusuarios"
        dgvusuarios.RowHeadersWidth = 51
        dgvusuarios.Size = New Size(748, 765)
        dgvusuarios.TabIndex = 7
        ' 
        ' txtbuscarusuario
        ' 
        txtbuscarusuario.Location = New Point(102, 19)
        txtbuscarusuario.Name = "txtbuscarusuario"
        txtbuscarusuario.Size = New Size(250, 27)
        txtbuscarusuario.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 23)
        Label6.TabIndex = 1
        Label6.Text = "BUSCAR:"
        ' 
        ' Formusuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1549, 1032)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Formusuarios"
        Text = "Formusuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
End Class
