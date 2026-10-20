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
        btnconectar = New Button()
        btnmedicamentos = New Button()
        btnproveedores = New Button()
        btncompras = New Button()
        pnlmenu = New Panel()
        pnltitulo = New Panel()
        lbltitulo = New Label()
        pnlcontenedor = New Panel()
        pnlmenu.SuspendLayout()
        pnltitulo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnconectar
        ' 
        btnconectar.BackColor = Color.SeaGreen
        btnconectar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnconectar.Location = New Point(27, 81)
        btnconectar.Margin = New Padding(3, 2, 3, 2)
        btnconectar.Name = "btnconectar"
        btnconectar.Size = New Size(137, 46)
        btnconectar.TabIndex = 1
        btnconectar.Text = "CONECTAR CON LA BASE DE DATOS"
        btnconectar.UseVisualStyleBackColor = False
        ' 
        ' btnmedicamentos
        ' 
        btnmedicamentos.BackColor = Color.SeaGreen
        btnmedicamentos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmedicamentos.Location = New Point(27, 153)
        btnmedicamentos.Margin = New Padding(3, 2, 3, 2)
        btnmedicamentos.Name = "btnmedicamentos"
        btnmedicamentos.Size = New Size(137, 46)
        btnmedicamentos.TabIndex = 2
        btnmedicamentos.Text = "MEDICAMENTOS"
        btnmedicamentos.UseVisualStyleBackColor = False
        ' 
        ' btnproveedores
        ' 
        btnproveedores.BackColor = Color.SeaGreen
        btnproveedores.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnproveedores.Location = New Point(27, 223)
        btnproveedores.Margin = New Padding(3, 2, 3, 2)
        btnproveedores.Name = "btnproveedores"
        btnproveedores.Size = New Size(137, 46)
        btnproveedores.TabIndex = 3
        btnproveedores.Text = "PROVEEDORES"
        btnproveedores.UseVisualStyleBackColor = False
        ' 
        ' btncompras
        ' 
        btncompras.BackColor = Color.SeaGreen
        btncompras.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncompras.Location = New Point(27, 299)
        btncompras.Name = "btncompras"
        btncompras.Size = New Size(137, 43)
        btncompras.TabIndex = 4
        btncompras.Text = "COMPRAS"
        btncompras.UseVisualStyleBackColor = False
        ' 
        ' pnlmenu
        ' 
        pnlmenu.BackColor = Color.MediumAquamarine
        pnlmenu.Controls.Add(btncompras)
        pnlmenu.Controls.Add(btnconectar)
        pnlmenu.Controls.Add(btnproveedores)
        pnlmenu.Controls.Add(btnmedicamentos)
        pnlmenu.Dock = DockStyle.Left
        pnlmenu.ImeMode = ImeMode.NoControl
        pnlmenu.Location = New Point(0, 0)
        pnlmenu.Name = "pnlmenu"
        pnlmenu.Size = New Size(200, 542)
        pnlmenu.TabIndex = 5
        ' 
        ' pnltitulo
        ' 
        pnltitulo.Controls.Add(lbltitulo)
        pnltitulo.Dock = DockStyle.Top
        pnltitulo.Location = New Point(200, 0)
        pnltitulo.Name = "pnltitulo"
        pnltitulo.Padding = New Padding(20, 0, 0, 0)
        pnltitulo.Size = New Size(815, 60)
        pnltitulo.TabIndex = 6
        ' 
        ' lbltitulo
        ' 
        lbltitulo.Dock = DockStyle.Fill
        lbltitulo.Enabled = False
        lbltitulo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitulo.Location = New Point(20, 0)
        lbltitulo.Name = "lbltitulo"
        lbltitulo.Size = New Size(795, 60)
        lbltitulo.TabIndex = 0
        lbltitulo.Text = "Inicio"
        lbltitulo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlcontenedor
        ' 
        pnlcontenedor.Dock = DockStyle.Fill
        pnlcontenedor.Location = New Point(200, 60)
        pnlcontenedor.Name = "pnlcontenedor"
        pnlcontenedor.Size = New Size(815, 482)
        pnlcontenedor.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1015, 542)
        Controls.Add(pnlcontenedor)
        Controls.Add(pnltitulo)
        Controls.Add(pnlmenu)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form_principal"
        pnlmenu.ResumeLayout(False)
        pnltitulo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnconectar As Button
    Friend WithEvents btnmedicamentos As Button
    Friend WithEvents btnproveedores As Button
    Friend WithEvents btncompras As Button
    Friend WithEvents pnlmenu As Panel
    Friend WithEvents pnltitulo As Panel
    Friend WithEvents pnlcontenedor As Panel
    Friend WithEvents lbltitulo As Label

End Class
