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
        btnmedicamentos = New Button()
        btnproveedores = New Button()
        btncompras = New Button()
        pnlmenu = New Panel()
        btndashboard = New Button()
        btnformusuarios = New Button()
        pnltitulo = New Panel()
        lblbienvenida = New Label()
        picfotousuario = New PictureBox()
        btncerrarapp = New Button()
        lbltitulo = New Label()
        pnlcontenedor = New Panel()
        btncerrar_sesion = New Button()
        pnlmenu.SuspendLayout()
        pnltitulo.SuspendLayout()
        CType(picfotousuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        pnlmenu.Controls.Add(btncerrar_sesion)
        pnlmenu.Controls.Add(btndashboard)
        pnlmenu.Controls.Add(btnformusuarios)
        pnlmenu.Controls.Add(btncompras)
        pnlmenu.Controls.Add(btnproveedores)
        pnlmenu.Controls.Add(btnmedicamentos)
        pnlmenu.Dock = DockStyle.Left
        pnlmenu.ImeMode = ImeMode.NoControl
        pnlmenu.Location = New Point(0, 0)
        pnlmenu.Name = "pnlmenu"
        pnlmenu.Size = New Size(200, 542)
        pnlmenu.TabIndex = 5
        ' 
        ' btndashboard
        ' 
        btndashboard.BackColor = Color.SeaGreen
        btndashboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndashboard.Location = New Point(27, 440)
        btndashboard.Name = "btndashboard"
        btndashboard.Size = New Size(137, 43)
        btndashboard.TabIndex = 6
        btndashboard.Text = "DASHBOARD"
        btndashboard.UseVisualStyleBackColor = False
        ' 
        ' btnformusuarios
        ' 
        btnformusuarios.BackColor = Color.SeaGreen
        btnformusuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnformusuarios.Location = New Point(27, 370)
        btnformusuarios.Name = "btnformusuarios"
        btnformusuarios.Size = New Size(137, 43)
        btnformusuarios.TabIndex = 5
        btnformusuarios.Text = "USUARIOS"
        btnformusuarios.UseVisualStyleBackColor = False
        ' 
        ' pnltitulo
        ' 
        pnltitulo.BackColor = SystemColors.ActiveBorder
        pnltitulo.Controls.Add(lblbienvenida)
        pnltitulo.Controls.Add(picfotousuario)
        pnltitulo.Controls.Add(btncerrarapp)
        pnltitulo.Controls.Add(lbltitulo)
        pnltitulo.Dock = DockStyle.Top
        pnltitulo.Location = New Point(200, 0)
        pnltitulo.Name = "pnltitulo"
        pnltitulo.Padding = New Padding(20, 0, 0, 0)
        pnltitulo.Size = New Size(999, 60)
        pnltitulo.TabIndex = 6
        ' 
        ' lblbienvenida
        ' 
        lblbienvenida.AutoSize = True
        lblbienvenida.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblbienvenida.Location = New Point(1010, 20)
        lblbienvenida.Name = "lblbienvenida"
        lblbienvenida.Size = New Size(0, 19)
        lblbienvenida.TabIndex = 7
        ' 
        ' picfotousuario
        ' 
        picfotousuario.Location = New Point(928, 2)
        picfotousuario.Margin = New Padding(3, 2, 3, 2)
        picfotousuario.Name = "picfotousuario"
        picfotousuario.Size = New Size(66, 56)
        picfotousuario.SizeMode = PictureBoxSizeMode.Zoom
        picfotousuario.TabIndex = 7
        picfotousuario.TabStop = False
        ' 
        ' btncerrarapp
        ' 
        btncerrarapp.BackColor = Color.DarkRed
        btncerrarapp.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncerrarapp.ForeColor = Color.White
        btncerrarapp.Location = New Point(1259, 9)
        btncerrarapp.Margin = New Padding(3, 2, 3, 2)
        btncerrarapp.Name = "btncerrarapp"
        btncerrarapp.Size = New Size(69, 38)
        btncerrarapp.TabIndex = 7
        btncerrarapp.Text = "CERRAR"
        btncerrarapp.UseVisualStyleBackColor = False
        ' 
        ' lbltitulo
        ' 
        lbltitulo.BackColor = SystemColors.ActiveBorder
        lbltitulo.Dock = DockStyle.Fill
        lbltitulo.Enabled = False
        lbltitulo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitulo.Location = New Point(20, 0)
        lbltitulo.Name = "lbltitulo"
        lbltitulo.Size = New Size(979, 60)
        lbltitulo.TabIndex = 0
        lbltitulo.Text = "Inicio"
        lbltitulo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlcontenedor
        ' 
        pnlcontenedor.BackColor = SystemColors.ActiveBorder
        pnlcontenedor.Dock = DockStyle.Fill
        pnlcontenedor.Location = New Point(200, 60)
        pnlcontenedor.Name = "pnlcontenedor"
        pnlcontenedor.Size = New Size(999, 482)
        pnlcontenedor.TabIndex = 7
        ' 
        ' btncerrar_sesion
        ' 
        btncerrar_sesion.Location = New Point(27, 507)
        btncerrar_sesion.Name = "btncerrar_sesion"
        btncerrar_sesion.Size = New Size(137, 23)
        btncerrar_sesion.TabIndex = 0
        btncerrar_sesion.Text = "Cerrar Sesion"
        btncerrar_sesion.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1199, 542)
        Controls.Add(pnlcontenedor)
        Controls.Add(pnltitulo)
        Controls.Add(pnlmenu)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form_principal"
        pnlmenu.ResumeLayout(False)
        pnltitulo.ResumeLayout(False)
        pnltitulo.PerformLayout()
        CType(picfotousuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnmedicamentos As Button
    Friend WithEvents btnproveedores As Button
    Friend WithEvents btncompras As Button
    Friend WithEvents pnlmenu As Panel
    Friend WithEvents pnltitulo As Panel
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pnlcontenedor As Panel
    Friend WithEvents btnformusuarios As Button
    Friend WithEvents btndashboard As Button
    Friend WithEvents btncerrarapp As Button
    Friend WithEvents picfotousuario As PictureBox
    Friend WithEvents lblbienvenida As Label
    Friend WithEvents btncerrar_sesion As Button

End Class
