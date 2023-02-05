<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recuperar_Contraseña
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar_Contraseña))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.ComboUsuario = New System.Windows.Forms.ComboBox()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelTitulo.Controls.Add(Me.ButtonSalir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(393, 39)
        Me.PanelTitulo.TabIndex = 19
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMinimizar.Image = CType(resources.GetObject("ButtonMinimizar.Image"), System.Drawing.Image)
        Me.ButtonMinimizar.Location = New System.Drawing.Point(305, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(46, 39)
        Me.ButtonMinimizar.TabIndex = 2
        Me.ButtonMinimizar.Text = "-"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.Location = New System.Drawing.Point(348, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(45, 39)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxCorreo.Location = New System.Drawing.Point(62, 404)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(277, 22)
        Me.TextBoxCorreo.TabIndex = 24
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.BackColor = System.Drawing.Color.Silver
        Me.LabelCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(58, 385)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(68, 23)
        Me.LabelCorreo.TabIndex = 23
        Me.LabelCorreo.Text = "Correo"
        '
        'ComboUsuario
        '
        Me.ComboUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboUsuario.FormattingEnabled = True
        Me.ComboUsuario.Items.AddRange(New Object() {"Jose de Jesus", "Juan Pedro", "Nirvana Belen"})
        Me.ComboUsuario.Location = New System.Drawing.Point(62, 340)
        Me.ComboUsuario.Name = "ComboUsuario"
        Me.ComboUsuario.Size = New System.Drawing.Size(277, 24)
        Me.ComboUsuario.TabIndex = 22
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.BackColor = System.Drawing.Color.Silver
        Me.LabelUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelUsuarios.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelUsuarios.Location = New System.Drawing.Point(58, 321)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(83, 23)
        Me.LabelUsuarios.TabIndex = 21
        Me.LabelUsuarios.Text = "Usuarios"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(81, 45)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(233, 273)
        Me.PictureBoxLogo.TabIndex = 20
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonEnviar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 659)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(393, 62)
        Me.PanelInferior.TabIndex = 26
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnviar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEnviar.Location = New System.Drawing.Point(250, 8)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonEnviar.TabIndex = 12
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 50
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(127, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Recuperar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(393, 721)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.ComboUsuario)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recuperar_Contraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar_Contraseña"
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents ComboUsuario As ComboBox
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents Button1 As Button
End Class
