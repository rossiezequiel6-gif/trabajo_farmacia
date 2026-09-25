<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnconectar = New Button()
        btnmedicamentos = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SeaGreen
        Label1.Font = New Font("Lucida Console", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(154, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 60)
        Label1.TabIndex = 0
        Label1.Text = "FARMACIA"
        ' 
        ' btnconectar
        ' 
        btnconectar.BackColor = Color.SeaGreen
        btnconectar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnconectar.Location = New Point(215, 254)
        btnconectar.Name = "btnconectar"
        btnconectar.Size = New Size(197, 62)
        btnconectar.TabIndex = 1
        btnconectar.Text = "CONECTAR CON LA BASE DE DATOS"
        btnconectar.UseVisualStyleBackColor = False
        ' 
        ' btnmedicamentos
        ' 
        btnmedicamentos.BackColor = Color.SeaGreen
        btnmedicamentos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmedicamentos.Location = New Point(215, 340)
        btnmedicamentos.Name = "btnmedicamentos"
        btnmedicamentos.Size = New Size(197, 62)
        btnmedicamentos.TabIndex = 2
        btnmedicamentos.Text = "MEDICAMENTOS"
        btnmedicamentos.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SeaGreen
        Button3.Location = New Point(215, 427)
        Button3.Name = "Button3"
        Button3.Size = New Size(197, 62)
        Button3.TabIndex = 3
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSeaGreen
        ClientSize = New Size(630, 723)
        Controls.Add(Button3)
        Controls.Add(btnmedicamentos)
        Controls.Add(btnconectar)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form_principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnconectar As Button
    Friend WithEvents btnmedicamentos As Button
    Friend WithEvents Button3 As Button

End Class
