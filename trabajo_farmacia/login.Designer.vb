<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        picfarmacia = New PictureBox()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        txtusuario = New TextBox()
        Panel1 = New Panel()
        Label2 = New Label()
        btnverclave = New Button()
        txtclave = New TextBox()
        btningresar = New Button()
        CType(picfarmacia, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picfarmacia
        ' 
        picfarmacia.BackColor = Color.Transparent
        picfarmacia.Dock = DockStyle.Fill
        picfarmacia.Image = CType(resources.GetObject("picfarmacia.Image"), Image)
        picfarmacia.Location = New Point(0, 0)
        picfarmacia.Name = "picfarmacia"
        picfarmacia.Size = New Size(636, 339)
        picfarmacia.SizeMode = PictureBoxSizeMode.Zoom
        picfarmacia.TabIndex = 7
        picfarmacia.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Panel2)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(btningresar)
        Panel3.Location = New Point(12, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(226, 306)
        Panel3.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(61, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 21)
        Label3.TabIndex = 6
        Label3.Text = "Iniciar sesion"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtusuario)
        Panel2.Location = New Point(17, 98)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(201, 22)
        Panel2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 16)
        Label1.TabIndex = 4
        Label1.Text = ""
        ' 
        ' txtusuario
        ' 
        txtusuario.BorderStyle = BorderStyle.None
        txtusuario.Location = New Point(32, 2)
        txtusuario.Margin = New Padding(3, 2, 3, 2)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(144, 16)
        txtusuario.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnverclave)
        Panel1.Controls.Add(txtclave)
        Panel1.Location = New Point(15, 153)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(205, 21)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 16)
        Label2.TabIndex = 4
        Label2.Text = ""
        ' 
        ' btnverclave
        ' 
        btnverclave.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnverclave.Location = New Point(173, 0)
        btnverclave.Margin = New Padding(3, 2, 3, 2)
        btnverclave.Name = "btnverclave"
        btnverclave.Size = New Size(27, 20)
        btnverclave.TabIndex = 6
        btnverclave.Text = ""
        btnverclave.UseVisualStyleBackColor = True
        ' 
        ' txtclave
        ' 
        txtclave.BorderStyle = BorderStyle.None
        txtclave.Location = New Point(30, 2)
        txtclave.Margin = New Padding(3, 2, 3, 2)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(142, 16)
        txtclave.TabIndex = 1
        txtclave.UseSystemPasswordChar = True
        ' 
        ' btningresar
        ' 
        btningresar.BackColor = Color.SeaGreen
        btningresar.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btningresar.Location = New Point(49, 207)
        btningresar.Margin = New Padding(3, 2, 3, 2)
        btningresar.Name = "btningresar"
        btningresar.Size = New Size(141, 38)
        btningresar.TabIndex = 0
        btningresar.Text = "Ingresar"
        btningresar.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(636, 339)
        Controls.Add(Panel3)
        Controls.Add(picfarmacia)
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        Text = "login"
        CType(picfarmacia, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picfarmacia As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnverclave As Button
    Friend WithEvents txtclave As TextBox
    Friend WithEvents btningresar As Button
End Class
