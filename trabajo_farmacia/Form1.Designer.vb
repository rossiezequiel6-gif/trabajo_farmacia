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
        btnformusuarios = New Button()
        pnltitulo = New Panel()
        lbltitulo = New Label()
        pnlcontenedor = New Panel()
        btndashboard = New Button()
        pnlmenu.SuspendLayout()
        pnltitulo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnconectar
        ' 
        btnconectar.BackColor = Color.SeaGreen
        btnconectar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnconectar.Location = New Point(31, 108)
        btnconectar.Name = "btnconectar"
        btnconectar.Size = New Size(157, 61)
        btnconectar.TabIndex = 1
        btnconectar.Text = "CONECTAR CON LA BASE DE DATOS"
        btnconectar.UseVisualStyleBackColor = False
        ' 
        ' btnmedicamentos
        ' 
        btnmedicamentos.BackColor = Color.SeaGreen
        btnmedicamentos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmedicamentos.Location = New Point(31, 204)
        btnmedicamentos.Name = "btnmedicamentos"
        btnmedicamentos.Size = New Size(157, 61)
        btnmedicamentos.TabIndex = 2
        btnmedicamentos.Text = "MEDICAMENTOS"
        btnmedicamentos.UseVisualStyleBackColor = False
        ' 
        ' btnproveedores
        ' 
        btnproveedores.BackColor = Color.SeaGreen
        btnproveedores.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnproveedores.Location = New Point(31, 297)
        btnproveedores.Name = "btnproveedores"
        btnproveedores.Size = New Size(157, 61)
        btnproveedores.TabIndex = 3
        btnproveedores.Text = "PROVEEDORES"
        btnproveedores.UseVisualStyleBackColor = False
        ' 
        ' btncompras
        ' 
        btncompras.BackColor = Color.SeaGreen
        btncompras.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncompras.Location = New Point(31, 399)
        btncompras.Margin = New Padding(3, 4, 3, 4)
        btncompras.Name = "btncompras"
        btncompras.Size = New Size(157, 57)
        btncompras.TabIndex = 4
        btncompras.Text = "COMPRAS"
        btncompras.UseVisualStyleBackColor = False
        ' 
        ' pnlmenu
        ' 
        pnlmenu.BackColor = Color.MediumAquamarine
        pnlmenu.Controls.Add(btndashboard)
        pnlmenu.Controls.Add(btnformusuarios)
        pnlmenu.Controls.Add(btncompras)
        pnlmenu.Controls.Add(btnconectar)
        pnlmenu.Controls.Add(btnproveedores)
        pnlmenu.Controls.Add(btnmedicamentos)
        pnlmenu.Dock = DockStyle.Left
        pnlmenu.ImeMode = ImeMode.NoControl
        pnlmenu.Location = New Point(0, 0)
        pnlmenu.Margin = New Padding(3, 4, 3, 4)
        pnlmenu.Name = "pnlmenu"
        pnlmenu.Size = New Size(229, 723)
        pnlmenu.TabIndex = 5
        ' 
        ' btnformusuarios
        ' 
        btnformusuarios.BackColor = Color.SeaGreen
        btnformusuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnformusuarios.Location = New Point(31, 493)
        btnformusuarios.Margin = New Padding(3, 4, 3, 4)
        btnformusuarios.Name = "btnformusuarios"
        btnformusuarios.Size = New Size(157, 57)
        btnformusuarios.TabIndex = 5
        btnformusuarios.Text = "USUARIOS"
        btnformusuarios.UseVisualStyleBackColor = False
        ' 
        ' pnltitulo
        ' 
        pnltitulo.BackColor = SystemColors.ActiveBorder
        pnltitulo.Controls.Add(lbltitulo)
        pnltitulo.Dock = DockStyle.Top
        pnltitulo.Location = New Point(229, 0)
        pnltitulo.Margin = New Padding(3, 4, 3, 4)
        pnltitulo.Name = "pnltitulo"
        pnltitulo.Padding = New Padding(23, 0, 0, 0)
        pnltitulo.Size = New Size(931, 80)
        pnltitulo.TabIndex = 6
        ' 
        ' lbltitulo
        ' 
        lbltitulo.BackColor = SystemColors.ActiveBorder
        lbltitulo.Dock = DockStyle.Fill
        lbltitulo.Enabled = False
        lbltitulo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitulo.Location = New Point(23, 0)
        lbltitulo.Name = "lbltitulo"
        lbltitulo.Size = New Size(908, 80)
        lbltitulo.TabIndex = 0
        lbltitulo.Text = "Inicio"
        lbltitulo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlcontenedor
        ' 
        pnlcontenedor.BackColor = SystemColors.ActiveBorder
        pnlcontenedor.Dock = DockStyle.Fill
        pnlcontenedor.Location = New Point(229, 80)
        pnlcontenedor.Margin = New Padding(3, 4, 3, 4)
        pnlcontenedor.Name = "pnlcontenedor"
        pnlcontenedor.Size = New Size(931, 643)
        pnlcontenedor.TabIndex = 7
        ' 
        ' btndashboard
        ' 
        btndashboard.BackColor = Color.SeaGreen
        btndashboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndashboard.Location = New Point(31, 586)
        btndashboard.Margin = New Padding(3, 4, 3, 4)
        btndashboard.Name = "btndashboard"
        btndashboard.Size = New Size(157, 57)
        btndashboard.TabIndex = 6
        btndashboard.Text = "DASHBOARD"
        btndashboard.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1160, 723)
        Controls.Add(pnlcontenedor)
        Controls.Add(pnltitulo)
        Controls.Add(pnlmenu)
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
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pnlcontenedor As Panel
    Friend WithEvents btnformusuarios As Button
    Friend WithEvents btndashboard As Button

End Class
