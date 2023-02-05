<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Iniciar_Sesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iniciar_Sesion))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Usuarios = New System.Windows.Forms.Label()
        Me.ComboUsuario = New System.Windows.Forms.ComboBox()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.LabelInferior = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.LinkRecuperarContraseña = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelEtiquetaMostrar = New System.Windows.Forms.LinkLabel()
        Me.PictureMostrar = New System.Windows.Forms.PictureBox()
        Me.PictureOcultar = New System.Windows.Forms.PictureBox()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        CType(Me.PictureMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureOcultar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelTitulo.TabIndex = 0
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
        Me.ButtonSalir.Location = New System.Drawing.Point(348, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(45, 39)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(85, 42)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(239, 288)
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Silver
        Me.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTitulo.Location = New System.Drawing.Point(142, 292)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(126, 25)
        Me.LabelTitulo.TabIndex = 2
        Me.LabelTitulo.Text = "Iniciar Sesión"
        '
        'Usuarios
        '
        Me.Usuarios.AutoSize = True
        Me.Usuarios.BackColor = System.Drawing.Color.Silver
        Me.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Usuarios.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Usuarios.Location = New System.Drawing.Point(58, 342)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(83, 23)
        Me.Usuarios.TabIndex = 3
        Me.Usuarios.Text = "Usuarios"
        '
        'ComboUsuario
        '
        Me.ComboUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboUsuario.FormattingEnabled = True
        Me.ComboUsuario.Location = New System.Drawing.Point(62, 361)
        Me.ComboUsuario.Name = "ComboUsuario"
        Me.ComboUsuario.Size = New System.Drawing.Size(277, 24)
        Me.ComboUsuario.TabIndex = 4
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.BackColor = System.Drawing.Color.Silver
        Me.LabelContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelContraseña.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelContraseña.Location = New System.Drawing.Point(58, 406)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(106, 23)
        Me.LabelContraseña.TabIndex = 5
        Me.LabelContraseña.Text = "Contraseña"
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxContraseña.Location = New System.Drawing.Point(62, 425)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContraseña.Size = New System.Drawing.Size(277, 22)
        Me.TextBoxContraseña.TabIndex = 7
        '
        'LabelInferior
        '
        Me.LabelInferior.AutoSize = True
        Me.LabelInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelInferior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelInferior.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelInferior.Location = New System.Drawing.Point(277, 583)
        Me.LabelInferior.Name = "LabelInferior"
        Me.LabelInferior.Size = New System.Drawing.Size(0, 17)
        Me.LabelInferior.TabIndex = 8
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 659)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(393, 62)
        Me.PanelInferior.TabIndex = 10
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAceptar.Location = New System.Drawing.Point(250, 8)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonAceptar.TabIndex = 12
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'LinkRecuperarContraseña
        '
        Me.LinkRecuperarContraseña.AutoSize = True
        Me.LinkRecuperarContraseña.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRecuperarContraseña.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkRecuperarContraseña.Location = New System.Drawing.Point(119, 471)
        Me.LinkRecuperarContraseña.Name = "LinkRecuperarContraseña"
        Me.LinkRecuperarContraseña.Size = New System.Drawing.Size(179, 22)
        Me.LinkRecuperarContraseña.TabIndex = 11
        Me.LinkRecuperarContraseña.TabStop = True
        Me.LinkRecuperarContraseña.Text = "Recuperar Contraseña"
        '
        'LinkLabelEtiquetaMostrar
        '
        Me.LinkLabelEtiquetaMostrar.AutoSize = True
        Me.LinkLabelEtiquetaMostrar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEtiquetaMostrar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelEtiquetaMostrar.Location = New System.Drawing.Point(243, 621)
        Me.LinkLabelEtiquetaMostrar.Name = "LinkLabelEtiquetaMostrar"
        Me.LinkLabelEtiquetaMostrar.Size = New System.Drawing.Size(144, 22)
        Me.LinkLabelEtiquetaMostrar.TabIndex = 15
        Me.LinkLabelEtiquetaMostrar.TabStop = True
        Me.LinkLabelEtiquetaMostrar.Text = "Mostrar Etiquetas"
        Me.LinkLabelEtiquetaMostrar.Visible = False
        '
        'PictureMostrar
        '
        Me.PictureMostrar.BackgroundImage = CType(resources.GetObject("PictureMostrar.BackgroundImage"), System.Drawing.Image)
        Me.PictureMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureMostrar.Location = New System.Drawing.Point(345, 425)
        Me.PictureMostrar.Name = "PictureMostrar"
        Me.PictureMostrar.Size = New System.Drawing.Size(34, 22)
        Me.PictureMostrar.TabIndex = 17
        Me.PictureMostrar.TabStop = False
        '
        'PictureOcultar
        '
        Me.PictureOcultar.BackColor = System.Drawing.Color.White
        Me.PictureOcultar.BackgroundImage = CType(resources.GetObject("PictureOcultar.BackgroundImage"), System.Drawing.Image)
        Me.PictureOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureOcultar.Location = New System.Drawing.Point(345, 425)
        Me.PictureOcultar.Name = "PictureOcultar"
        Me.PictureOcultar.Size = New System.Drawing.Size(34, 22)
        Me.PictureOcultar.TabIndex = 18
        Me.PictureOcultar.TabStop = False
        Me.PictureOcultar.Visible = False
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 20
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 20
        '
        'Iniciar_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(393, 721)
        Me.Controls.Add(Me.PictureOcultar)
        Me.Controls.Add(Me.PictureMostrar)
        Me.Controls.Add(Me.LinkLabelEtiquetaMostrar)
        Me.Controls.Add(Me.LinkRecuperarContraseña)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelInferior)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.LabelContraseña)
        Me.Controls.Add(Me.ComboUsuario)
        Me.Controls.Add(Me.Usuarios)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Iniciar_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar_Sesion"
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.PictureMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureOcultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Usuarios As Label
    Friend WithEvents ComboUsuario As ComboBox
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents LabelInferior As Label
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents LinkRecuperarContraseña As LinkLabel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents LinkLabelEtiquetaMostrar As LinkLabel
    Friend WithEvents PictureMostrar As PictureBox
    Friend WithEvents PictureOcultar As PictureBox
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
End Class
