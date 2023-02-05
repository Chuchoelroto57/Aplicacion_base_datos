<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCiudad = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.Barra_Carga_Bienvenida = New System.Windows.Forms.ProgressBar()
        Me.Label_Carga = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
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
        Me.PanelTitulo.Size = New System.Drawing.Size(736, 39)
        Me.PanelTitulo.TabIndex = 1
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMinimizar.Location = New System.Drawing.Point(639, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(46, 36)
        Me.ButtonMinimizar.TabIndex = 2
        Me.ButtonMinimizar.Text = "-"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Location = New System.Drawing.Point(691, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(45, 36)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Silver
        Me.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTitulo.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTitulo.Location = New System.Drawing.Point(257, 59)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(192, 29)
        Me.LabelTitulo.TabIndex = 3
        Me.LabelTitulo.Text = "BIENVENID@"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(505, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Informatica"
        '
        'LabelCiudad
        '
        Me.LabelCiudad.AutoSize = True
        Me.LabelCiudad.BackColor = System.Drawing.Color.Silver
        Me.LabelCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCiudad.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCiudad.Location = New System.Drawing.Point(39, 143)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(70, 23)
        Me.LabelCiudad.TabIndex = 17
        Me.LabelCiudad.Text = "Ciudad"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.BackColor = System.Drawing.Color.Silver
        Me.LabelCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(39, 211)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(68, 23)
        Me.LabelCorreo.TabIndex = 16
        Me.LabelCorreo.Text = "Correo"
        '
        'LabelEdad
        '
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.BackColor = System.Drawing.Color.Silver
        Me.LabelEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEdad.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelEdad.Location = New System.Drawing.Point(39, 178)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(52, 23)
        Me.LabelEdad.TabIndex = 15
        Me.LabelEdad.Text = "Edad"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Silver
        Me.LabelNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(37, 110)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 23)
        Me.LabelNombre.TabIndex = 18
        Me.LabelNombre.Text = "Nombre"
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 370)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(736, 56)
        Me.PanelInferior.TabIndex = 19
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
        Me.ButtonAceptar.Location = New System.Drawing.Point(593, 8)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonAceptar.TabIndex = 12
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 20
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 25
        '
        'Barra_Carga_Bienvenida
        '
        Me.Barra_Carga_Bienvenida.BackColor = System.Drawing.Color.White
        Me.Barra_Carga_Bienvenida.Location = New System.Drawing.Point(113, 279)
        Me.Barra_Carga_Bienvenida.Name = "Barra_Carga_Bienvenida"
        Me.Barra_Carga_Bienvenida.Size = New System.Drawing.Size(507, 24)
        Me.Barra_Carga_Bienvenida.TabIndex = 20
        Me.Barra_Carga_Bienvenida.Value = 55
        '
        'Label_Carga
        '
        Me.Label_Carga.AutoSize = True
        Me.Label_Carga.BackColor = System.Drawing.Color.Silver
        Me.Label_Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Carga.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Carga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_Carga.Location = New System.Drawing.Point(589, 253)
        Me.Label_Carga.Name = "Label_Carga"
        Me.Label_Carga.Size = New System.Drawing.Size(30, 23)
        Me.Label_Carga.TabIndex = 21
        Me.Label_Carga.Text = "10"
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.BackColor = System.Drawing.Color.Silver
        Me.LabelGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelGenero.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelGenero.Location = New System.Drawing.Point(39, 244)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(72, 23)
        Me.LabelGenero.TabIndex = 22
        Me.LabelGenero.Text = "Genero"
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(736, 426)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.Label_Carga)
        Me.Controls.Add(Me.Barra_Carga_Bienvenida)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelCiudad)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelEdad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelEdad As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents Barra_Carga_Bienvenida As ProgressBar
    Friend WithEvents Label_Carga As Label
    Friend WithEvents LabelGenero As Label
End Class
