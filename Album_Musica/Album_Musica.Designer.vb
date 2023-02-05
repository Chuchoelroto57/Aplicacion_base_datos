<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Album_Musica
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
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.LabelRegistros = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.TextBoxCanciones = New System.Windows.Forms.TextBox()
        Me.LabelCanciones = New System.Windows.Forms.Label()
        Me.TextBoxArtista = New System.Windows.Forms.TextBox()
        Me.LabelArtista = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelMusica = New System.Windows.Forms.Label()
        Me.LabelCodigo = New System.Windows.Forms.Label()
        Me.DataGridMusica = New System.Windows.Forms.DataGridView()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.TextBoxGenero = New System.Windows.Forms.TextBox()
        Me.TextBoxAño = New System.Windows.Forms.TextBox()
        Me.LabelAño = New System.Windows.Forms.Label()
        CType(Me.DataGridMusica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(70, 118)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxCodigo.TabIndex = 67
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumero.Location = New System.Drawing.Point(803, 63)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(30, 24)
        Me.LabelNumero.TabIndex = 66
        Me.LabelNumero.Text = "19"
        '
        'LabelRegistros
        '
        Me.LabelRegistros.AutoSize = True
        Me.LabelRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistros.Location = New System.Drawing.Point(643, 63)
        Me.LabelRegistros.Name = "LabelRegistros"
        Me.LabelRegistros.Size = New System.Drawing.Size(154, 24)
        Me.LabelRegistros.TabIndex = 65
        Me.LabelRegistros.Text = "Total de registros"
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenero.Location = New System.Drawing.Point(66, 327)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(74, 24)
        Me.LabelGenero.TabIndex = 63
        Me.LabelGenero.Text = "Genero"
        '
        'TextBoxCanciones
        '
        Me.TextBoxCanciones.Location = New System.Drawing.Point(70, 293)
        Me.TextBoxCanciones.Name = "TextBoxCanciones"
        Me.TextBoxCanciones.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxCanciones.TabIndex = 62
        '
        'LabelCanciones
        '
        Me.LabelCanciones.AutoSize = True
        Me.LabelCanciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanciones.Location = New System.Drawing.Point(66, 266)
        Me.LabelCanciones.Name = "LabelCanciones"
        Me.LabelCanciones.Size = New System.Drawing.Size(198, 24)
        Me.LabelCanciones.TabIndex = 61
        Me.LabelCanciones.Text = "Numero de canciones"
        '
        'TextBoxArtista
        '
        Me.TextBoxArtista.Location = New System.Drawing.Point(70, 231)
        Me.TextBoxArtista.Name = "TextBoxArtista"
        Me.TextBoxArtista.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxArtista.TabIndex = 60
        '
        'LabelArtista
        '
        Me.LabelArtista.AutoSize = True
        Me.LabelArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArtista.Location = New System.Drawing.Point(66, 204)
        Me.LabelArtista.Name = "LabelArtista"
        Me.LabelArtista.Size = New System.Drawing.Size(60, 24)
        Me.LabelArtista.TabIndex = 59
        Me.LabelArtista.Text = "Artista"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(70, 179)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxNombre.TabIndex = 58
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(66, 152)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(167, 24)
        Me.LabelNombre.TabIndex = 57
        Me.LabelNombre.Text = "Nombre del album"
        '
        'LabelMusica
        '
        Me.LabelMusica.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelMusica.AutoSize = True
        Me.LabelMusica.BackColor = System.Drawing.Color.Silver
        Me.LabelMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMusica.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMusica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMusica.Location = New System.Drawing.Point(384, 16)
        Me.LabelMusica.Name = "LabelMusica"
        Me.LabelMusica.Size = New System.Drawing.Size(118, 41)
        Me.LabelMusica.TabIndex = 53
        Me.LabelMusica.Text = "Musica"
        '
        'LabelCodigo
        '
        Me.LabelCodigo.AutoSize = True
        Me.LabelCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodigo.Location = New System.Drawing.Point(66, 91)
        Me.LabelCodigo.Name = "LabelCodigo"
        Me.LabelCodigo.Size = New System.Drawing.Size(71, 24)
        Me.LabelCodigo.TabIndex = 56
        Me.LabelCodigo.Text = "Código"
        '
        'DataGridMusica
        '
        Me.DataGridMusica.AllowUserToAddRows = False
        Me.DataGridMusica.AllowUserToResizeColumns = False
        Me.DataGridMusica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridMusica.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridMusica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMusica.GridColor = System.Drawing.Color.Silver
        Me.DataGridMusica.Location = New System.Drawing.Point(297, 104)
        Me.DataGridMusica.Name = "DataGridMusica"
        Me.DataGridMusica.ReadOnly = True
        Me.DataGridMusica.RowHeadersWidth = 51
        Me.DataGridMusica.RowTemplate.Height = 24
        Me.DataGridMusica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMusica.Size = New System.Drawing.Size(536, 386)
        Me.DataGridMusica.TabIndex = 55
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonActualizar)
        Me.PanelInferior.Controls.Add(Me.ButtonEliminar)
        Me.PanelInferior.Controls.Add(Me.ButtonReiniciar)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 518)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(842, 95)
        Me.PanelInferior.TabIndex = 54
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEliminar.Location = New System.Drawing.Point(391, 22)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonEliminar.TabIndex = 14
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReiniciar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonReiniciar.Location = New System.Drawing.Point(552, 22)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonReiniciar.TabIndex = 13
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistrar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRegistrar.Location = New System.Drawing.Point(702, 22)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonRegistrar.TabIndex = 12
        Me.ButtonRegistrar.Text = "Registrar"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonActualizar.Location = New System.Drawing.Point(702, 22)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonActualizar.TabIndex = 15
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        Me.ButtonActualizar.Visible = False
        '
        'TextBoxGenero
        '
        Me.TextBoxGenero.Location = New System.Drawing.Point(70, 354)
        Me.TextBoxGenero.Name = "TextBoxGenero"
        Me.TextBoxGenero.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxGenero.TabIndex = 68
        '
        'TextBoxAño
        '
        Me.TextBoxAño.Location = New System.Drawing.Point(70, 418)
        Me.TextBoxAño.Name = "TextBoxAño"
        Me.TextBoxAño.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxAño.TabIndex = 70
        '
        'LabelAño
        '
        Me.LabelAño.AutoSize = True
        Me.LabelAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAño.Location = New System.Drawing.Point(66, 391)
        Me.LabelAño.Name = "LabelAño"
        Me.LabelAño.Size = New System.Drawing.Size(178, 24)
        Me.LabelAño.TabIndex = 69
        Me.LabelAño.Text = "Año de lanzamiento"
        '
        'Album_Musica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(842, 613)
        Me.Controls.Add(Me.TextBoxAño)
        Me.Controls.Add(Me.LabelAño)
        Me.Controls.Add(Me.TextBoxGenero)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.LabelNumero)
        Me.Controls.Add(Me.LabelRegistros)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.TextBoxCanciones)
        Me.Controls.Add(Me.LabelCanciones)
        Me.Controls.Add(Me.TextBoxArtista)
        Me.Controls.Add(Me.LabelArtista)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelMusica)
        Me.Controls.Add(Me.LabelCodigo)
        Me.Controls.Add(Me.DataGridMusica)
        Me.Controls.Add(Me.PanelInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Album_Musica"
        Me.Text = "Album_Musica"
        CType(Me.DataGridMusica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents LabelNumero As Label
    Friend WithEvents LabelRegistros As Label
    Friend WithEvents LabelGenero As Label
    Friend WithEvents TextBoxCanciones As TextBox
    Friend WithEvents LabelCanciones As Label
    Friend WithEvents TextBoxArtista As TextBox
    Friend WithEvents LabelArtista As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelMusica As Label
    Friend WithEvents LabelCodigo As Label
    Friend WithEvents DataGridMusica As DataGridView
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonReiniciar As Button
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents TextBoxGenero As TextBox
    Friend WithEvents TextBoxAño As TextBox
    Friend WithEvents LabelAño As Label
End Class
