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
        btningresar = New Button()
        txtclave = New TextBox()
        txtusuario = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        btnverclave = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btningresar
        ' 
        btningresar.BackColor = Color.SeaGreen
        btningresar.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btningresar.Location = New Point(140, 236)
        btningresar.Margin = New Padding(3, 2, 3, 2)
        btningresar.Name = "btningresar"
        btningresar.Size = New Size(141, 38)
        btningresar.TabIndex = 0
        btningresar.Text = "Ingresar"
        btningresar.UseVisualStyleBackColor = False
        ' 
        ' txtclave
        ' 
        txtclave.BorderStyle = BorderStyle.None
        txtclave.Location = New Point(30, 2)
        txtclave.Margin = New Padding(3, 2, 3, 2)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(167, 16)
        txtclave.TabIndex = 1
        txtclave.UseSystemPasswordChar = True
        ' 
        ' txtusuario
        ' 
        txtusuario.BorderStyle = BorderStyle.None
        txtusuario.Location = New Point(30, 3)
        txtusuario.Margin = New Padding(3, 2, 3, 2)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(200, 16)
        txtusuario.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtusuario)
        Panel1.Location = New Point(100, 162)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 21)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 16)
        Label1.TabIndex = 4
        Label1.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 16)
        Label2.TabIndex = 4
        Label2.Text = ""
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnverclave)
        Panel2.Controls.Add(txtclave)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(100, 195)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(230, 22)
        Panel2.TabIndex = 5
        ' 
        ' btnverclave
        ' 
        btnverclave.Font = New Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnverclave.Location = New Point(202, -1)
        btnverclave.Margin = New Padding(3, 2, 3, 2)
        btnverclave.Name = "btnverclave"
        btnverclave.Size = New Size(27, 20)
        btnverclave.TabIndex = 6
        btnverclave.Text = ""
        btnverclave.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(445, 366)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btningresar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btningresar As Button
    Friend WithEvents txtclave As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnverclave As Button
End Class
