<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Docentes
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
        Me.LabelDocentes = New System.Windows.Forms.Label()
        Me.DataGridDocentes = New System.Windows.Forms.DataGridView()
        Me.ComboBoxDocentes = New System.Windows.Forms.ComboBox()
        Me.LabelCiudad = New System.Windows.Forms.Label()
        Me.LabelFolio = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.LabelMateria = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        CType(Me.DataGridDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDocentes
        '
        Me.LabelDocentes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDocentes.AutoSize = True
        Me.LabelDocentes.BackColor = System.Drawing.Color.Silver
        Me.LabelDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelDocentes.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDocentes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDocentes.Location = New System.Drawing.Point(369, 23)
        Me.LabelDocentes.Name = "LabelDocentes"
        Me.LabelDocentes.Size = New System.Drawing.Size(113, 30)
        Me.LabelDocentes.TabIndex = 24
        Me.LabelDocentes.Text = "Docentes"
        '
        'DataGridDocentes
        '
        Me.DataGridDocentes.AllowUserToAddRows = False
        Me.DataGridDocentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridDocentes.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDocentes.GridColor = System.Drawing.Color.Silver
        Me.DataGridDocentes.Location = New System.Drawing.Point(42, 123)
        Me.DataGridDocentes.Name = "DataGridDocentes"
        Me.DataGridDocentes.ReadOnly = True
        Me.DataGridDocentes.RowHeadersWidth = 51
        Me.DataGridDocentes.RowTemplate.Height = 24
        Me.DataGridDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDocentes.Size = New System.Drawing.Size(786, 350)
        Me.DataGridDocentes.TabIndex = 34
        '
        'ComboBoxDocentes
        '
        Me.ComboBoxDocentes.FormattingEnabled = True
        Me.ComboBoxDocentes.Location = New System.Drawing.Point(579, 67)
        Me.ComboBoxDocentes.Name = "ComboBoxDocentes"
        Me.ComboBoxDocentes.Size = New System.Drawing.Size(222, 24)
        Me.ComboBoxDocentes.TabIndex = 35
        '
        'LabelCiudad
        '
        Me.LabelCiudad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCiudad.AutoSize = True
        Me.LabelCiudad.BackColor = System.Drawing.Color.Silver
        Me.LabelCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCiudad.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCiudad.Location = New System.Drawing.Point(38, 515)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(79, 23)
        Me.LabelCiudad.TabIndex = 37
        Me.LabelCiudad.Text = "Nombre"
        '
        'LabelFolio
        '
        Me.LabelFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelFolio.AutoSize = True
        Me.LabelFolio.BackColor = System.Drawing.Color.Silver
        Me.LabelFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFolio.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFolio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFolio.Location = New System.Drawing.Point(38, 425)
        Me.LabelFolio.Name = "LabelFolio"
        Me.LabelFolio.Size = New System.Drawing.Size(0, 23)
        Me.LabelFolio.TabIndex = 38
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.BackColor = System.Drawing.Color.Silver
        Me.LabelCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(38, 485)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(79, 23)
        Me.LabelCorreo.TabIndex = 39
        Me.LabelCorreo.Text = "Nombre"
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.BackColor = System.Drawing.Color.Silver
        Me.LabelFacultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFacultad.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFacultad.Location = New System.Drawing.Point(38, 545)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(79, 23)
        Me.LabelFacultad.TabIndex = 40
        Me.LabelFacultad.Text = "Nombre"
        '
        'LabelMateria
        '
        Me.LabelMateria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMateria.AutoSize = True
        Me.LabelMateria.BackColor = System.Drawing.Color.Silver
        Me.LabelMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMateria.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMateria.Location = New System.Drawing.Point(38, 575)
        Me.LabelMateria.Name = "LabelMateria"
        Me.LabelMateria.Size = New System.Drawing.Size(79, 23)
        Me.LabelMateria.TabIndex = 41
        Me.LabelMateria.Text = "Nombre"
        '
        'LabelTipo
        '
        Me.LabelTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.BackColor = System.Drawing.Color.Silver
        Me.LabelTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTipo.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTipo.Location = New System.Drawing.Point(38, 605)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(79, 23)
        Me.LabelTipo.TabIndex = 42
        Me.LabelTipo.Text = "Nombre"
        '
        'Docentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 660)
        Me.Controls.Add(Me.LabelTipo)
        Me.Controls.Add(Me.LabelMateria)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelFolio)
        Me.Controls.Add(Me.LabelCiudad)
        Me.Controls.Add(Me.ComboBoxDocentes)
        Me.Controls.Add(Me.DataGridDocentes)
        Me.Controls.Add(Me.LabelDocentes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Docentes"
        Me.Text = "Docentes"
        CType(Me.DataGridDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDocentes As Label
    Friend WithEvents DataGridDocentes As DataGridView
    Friend WithEvents ComboBoxDocentes As ComboBox
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents LabelFolio As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents LabelMateria As Label
    Friend WithEvents LabelTipo As Label
End Class
