<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PanelBarradeTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonAgrandar = New System.Windows.Forms.Button()
        Me.ButtonRestaurar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.ButtonMusica = New System.Windows.Forms.Button()
        Me.ButtonLibros = New System.Windows.Forms.Button()
        Me.ButtonDocentes = New System.Windows.Forms.Button()
        Me.LabelCiudad = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.ButtonCerrarSesion = New System.Windows.Forms.Button()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.ButtonMaterias = New System.Windows.Forms.Button()
        Me.ButtonAlumnos = New System.Windows.Forms.Button()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarradeTitulo.SuspendLayout()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarradeTitulo
        '
        Me.PanelBarradeTitulo.BackColor = System.Drawing.Color.DarkGray
        Me.PanelBarradeTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarradeTitulo.Controls.Add(Me.ButtonAgrandar)
        Me.PanelBarradeTitulo.Controls.Add(Me.ButtonRestaurar)
        Me.PanelBarradeTitulo.Controls.Add(Me.ButtonSalir)
        Me.PanelBarradeTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarradeTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarradeTitulo.Name = "PanelBarradeTitulo"
        Me.PanelBarradeTitulo.Size = New System.Drawing.Size(1100, 40)
        Me.PanelBarradeTitulo.TabIndex = 0
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMinimizar.Image = CType(resources.GetObject("ButtonMinimizar.Image"), System.Drawing.Image)
        Me.ButtonMinimizar.Location = New System.Drawing.Point(991, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonMinimizar.TabIndex = 5
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonAgrandar
        '
        Me.ButtonAgrandar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAgrandar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAgrandar.FlatAppearance.BorderSize = 0
        Me.ButtonAgrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgrandar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAgrandar.Image = CType(resources.GetObject("ButtonAgrandar.Image"), System.Drawing.Image)
        Me.ButtonAgrandar.Location = New System.Drawing.Point(1023, 0)
        Me.ButtonAgrandar.Name = "ButtonAgrandar"
        Me.ButtonAgrandar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonAgrandar.TabIndex = 4
        Me.ButtonAgrandar.UseVisualStyleBackColor = True
        '
        'ButtonRestaurar
        '
        Me.ButtonRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRestaurar.FlatAppearance.BorderSize = 0
        Me.ButtonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRestaurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonRestaurar.Image = CType(resources.GetObject("ButtonRestaurar.Image"), System.Drawing.Image)
        Me.ButtonRestaurar.Location = New System.Drawing.Point(1023, 0)
        Me.ButtonRestaurar.Name = "ButtonRestaurar"
        Me.ButtonRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonRestaurar.TabIndex = 3
        Me.ButtonRestaurar.UseVisualStyleBackColor = True
        Me.ButtonRestaurar.Visible = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.Location = New System.Drawing.Point(1060, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(40, 40)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.DarkGray
        Me.PanelMenuLateral.Controls.Add(Me.ButtonMusica)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonLibros)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonDocentes)
        Me.PanelMenuLateral.Controls.Add(Me.LabelCiudad)
        Me.PanelMenuLateral.Controls.Add(Me.LabelEdad)
        Me.PanelMenuLateral.Controls.Add(Me.LabelGenero)
        Me.PanelMenuLateral.Controls.Add(Me.LabelNombre)
        Me.PanelMenuLateral.Controls.Add(Me.LabelCorreo)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonCerrarSesion)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonProductos)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonMaterias)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonAlumnos)
        Me.PanelMenuLateral.Controls.Add(Me.ButtonInicio)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(240, 660)
        Me.PanelMenuLateral.TabIndex = 1
        '
        'ButtonMusica
        '
        Me.ButtonMusica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMusica.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMusica.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonMusica.FlatAppearance.BorderSize = 0
        Me.ButtonMusica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonMusica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMusica.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMusica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMusica.Image = CType(resources.GetObject("ButtonMusica.Image"), System.Drawing.Image)
        Me.ButtonMusica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMusica.Location = New System.Drawing.Point(0, 403)
        Me.ButtonMusica.Name = "ButtonMusica"
        Me.ButtonMusica.Size = New System.Drawing.Size(240, 36)
        Me.ButtonMusica.TabIndex = 26
        Me.ButtonMusica.Text = "    Musica"
        Me.ButtonMusica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMusica.UseVisualStyleBackColor = True
        '
        'ButtonLibros
        '
        Me.ButtonLibros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonLibros.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonLibros.FlatAppearance.BorderSize = 0
        Me.ButtonLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLibros.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLibros.Image = CType(resources.GetObject("ButtonLibros.Image"), System.Drawing.Image)
        Me.ButtonLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLibros.Location = New System.Drawing.Point(0, 367)
        Me.ButtonLibros.Name = "ButtonLibros"
        Me.ButtonLibros.Size = New System.Drawing.Size(240, 36)
        Me.ButtonLibros.TabIndex = 25
        Me.ButtonLibros.Text = "    Libros"
        Me.ButtonLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLibros.UseVisualStyleBackColor = True
        '
        'ButtonDocentes
        '
        Me.ButtonDocentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDocentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonDocentes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDocentes.FlatAppearance.BorderSize = 0
        Me.ButtonDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDocentes.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDocentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDocentes.Image = CType(resources.GetObject("ButtonDocentes.Image"), System.Drawing.Image)
        Me.ButtonDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDocentes.Location = New System.Drawing.Point(0, 331)
        Me.ButtonDocentes.Name = "ButtonDocentes"
        Me.ButtonDocentes.Size = New System.Drawing.Size(240, 36)
        Me.ButtonDocentes.TabIndex = 24
        Me.ButtonDocentes.Text = "    Docentes"
        Me.ButtonDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDocentes.UseVisualStyleBackColor = True
        '
        'LabelCiudad
        '
        Me.LabelCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCiudad.AutoSize = True
        Me.LabelCiudad.BackColor = System.Drawing.Color.DarkGray
        Me.LabelCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCiudad.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCiudad.Location = New System.Drawing.Point(12, 519)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(70, 23)
        Me.LabelCiudad.TabIndex = 23
        Me.LabelCiudad.Text = "Ciudad"
        '
        'LabelEdad
        '
        Me.LabelEdad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.BackColor = System.Drawing.Color.DarkGray
        Me.LabelEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEdad.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelEdad.Location = New System.Drawing.Point(12, 587)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(52, 23)
        Me.LabelEdad.TabIndex = 22
        Me.LabelEdad.Text = "Edad"
        '
        'LabelGenero
        '
        Me.LabelGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.BackColor = System.Drawing.Color.DarkGray
        Me.LabelGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelGenero.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelGenero.Location = New System.Drawing.Point(12, 555)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(72, 23)
        Me.LabelGenero.TabIndex = 21
        Me.LabelGenero.Text = "Genero"
        '
        'LabelNombre
        '
        Me.LabelNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.DarkGray
        Me.LabelNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(12, 442)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 23)
        Me.LabelNombre.TabIndex = 20
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.BackColor = System.Drawing.Color.DarkGray
        Me.LabelCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(12, 483)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(68, 23)
        Me.LabelCorreo.TabIndex = 19
        Me.LabelCorreo.Text = "Correo"
        '
        'ButtonCerrarSesion
        '
        Me.ButtonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonCerrarSesion.FlatAppearance.BorderSize = 0
        Me.ButtonCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrarSesion.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCerrarSesion.Location = New System.Drawing.Point(0, 624)
        Me.ButtonCerrarSesion.Name = "ButtonCerrarSesion"
        Me.ButtonCerrarSesion.Size = New System.Drawing.Size(240, 36)
        Me.ButtonCerrarSesion.TabIndex = 17
        Me.ButtonCerrarSesion.Text = "Salir"
        Me.ButtonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCerrarSesion.UseVisualStyleBackColor = True
        '
        'ButtonProductos
        '
        Me.ButtonProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonProductos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonProductos.FlatAppearance.BorderSize = 0
        Me.ButtonProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProductos.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonProductos.Image = CType(resources.GetObject("ButtonProductos.Image"), System.Drawing.Image)
        Me.ButtonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProductos.Location = New System.Drawing.Point(0, 295)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(240, 36)
        Me.ButtonProductos.TabIndex = 16
        Me.ButtonProductos.Text = "    Productos"
        Me.ButtonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'ButtonMaterias
        '
        Me.ButtonMaterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMaterias.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMaterias.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonMaterias.FlatAppearance.BorderSize = 0
        Me.ButtonMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMaterias.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMaterias.Image = CType(resources.GetObject("ButtonMaterias.Image"), System.Drawing.Image)
        Me.ButtonMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMaterias.Location = New System.Drawing.Point(0, 259)
        Me.ButtonMaterias.Name = "ButtonMaterias"
        Me.ButtonMaterias.Size = New System.Drawing.Size(240, 36)
        Me.ButtonMaterias.TabIndex = 15
        Me.ButtonMaterias.Text = "    Materias"
        Me.ButtonMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMaterias.UseVisualStyleBackColor = True
        '
        'ButtonAlumnos
        '
        Me.ButtonAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAlumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAlumnos.FlatAppearance.BorderSize = 0
        Me.ButtonAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAlumnos.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAlumnos.Image = CType(resources.GetObject("ButtonAlumnos.Image"), System.Drawing.Image)
        Me.ButtonAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAlumnos.Location = New System.Drawing.Point(0, 223)
        Me.ButtonAlumnos.Name = "ButtonAlumnos"
        Me.ButtonAlumnos.Size = New System.Drawing.Size(240, 36)
        Me.ButtonAlumnos.TabIndex = 14
        Me.ButtonAlumnos.Text = "    Alumnos"
        Me.ButtonAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAlumnos.UseVisualStyleBackColor = True
        '
        'ButtonInicio
        '
        Me.ButtonInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonInicio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonInicio.FlatAppearance.BorderSize = 0
        Me.ButtonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInicio.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonInicio.Image = CType(resources.GetObject("ButtonInicio.Image"), System.Drawing.Image)
        Me.ButtonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInicio.Location = New System.Drawing.Point(0, 187)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(240, 36)
        Me.ButtonInicio.TabIndex = 13
        Me.ButtonInicio.Text = "    Inicio"
        Me.ButtonInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBoxLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(240, 187)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(3, -10)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(234, 201)
        Me.PictureBoxLogo.TabIndex = 2
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Silver
        Me.PanelContenedor.Controls.Add(Me.LabelFecha)
        Me.PanelContenedor.Controls.Add(Me.LabelHora)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(240, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(860, 660)
        Me.PanelContenedor.TabIndex = 2
        '
        'LabelFecha
        '
        Me.LabelFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.BackColor = System.Drawing.Color.Silver
        Me.LabelFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFecha.Location = New System.Drawing.Point(270, 299)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(350, 34)
        Me.LabelFecha.TabIndex = 22
        Me.LabelFecha.Text = "Miercoles 26 Agosto 2022"
        '
        'LabelHora
        '
        Me.LabelHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHora.AutoSize = True
        Me.LabelHora.BackColor = System.Drawing.Color.Silver
        Me.LabelHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelHora.Location = New System.Drawing.Point(314, 223)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(275, 76)
        Me.LabelHora.TabIndex = 21
        Me.LabelHora.Text = "00:00:00"
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarradeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.PanelBarradeTitulo.ResumeLayout(False)
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelMenuLateral.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarradeTitulo As Panel
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonAgrandar As Button
    Friend WithEvents ButtonRestaurar As Button
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonCerrarSesion As Button
    Friend WithEvents ButtonProductos As Button
    Friend WithEvents ButtonMaterias As Button
    Friend WithEvents ButtonAlumnos As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents TimerHora As Timer
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents LabelEdad As Label
    Friend WithEvents LabelGenero As Label
    Friend WithEvents ButtonDocentes As Button
    Friend WithEvents ButtonLibros As Button
    Friend WithEvents ButtonMusica As Button
End Class
