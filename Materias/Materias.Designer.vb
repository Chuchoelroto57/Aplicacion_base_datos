<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materias
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
        Me.LabelMaterias = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.ComboBoxSemestre = New System.Windows.Forms.ComboBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.ComboBoxFacultad = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.DataGridMaterias = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facultad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        CType(Me.DataGridMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMaterias
        '
        Me.LabelMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelMaterias.AutoSize = True
        Me.LabelMaterias.BackColor = System.Drawing.Color.Silver
        Me.LabelMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMaterias.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaterias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMaterias.Location = New System.Drawing.Point(356, 24)
        Me.LabelMaterias.Name = "LabelMaterias"
        Me.LabelMaterias.Size = New System.Drawing.Size(83, 23)
        Me.LabelMaterias.TabIndex = 22
        Me.LabelMaterias.Text = "Materias"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.Silver
        Me.LabelID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelID.Location = New System.Drawing.Point(29, 79)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(28, 23)
        Me.LabelID.TabIndex = 23
        Me.LabelID.Text = "ID"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(61, 78)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxID.TabIndex = 24
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(262, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxNombre.TabIndex = 26
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Silver
        Me.LabelNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(177, 79)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 23)
        Me.LabelNombre.TabIndex = 25
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelSemestre
        '
        Me.LabelSemestre.AutoSize = True
        Me.LabelSemestre.BackColor = System.Drawing.Color.Silver
        Me.LabelSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSemestre.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSemestre.Location = New System.Drawing.Point(550, 78)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(87, 23)
        Me.LabelSemestre.TabIndex = 27
        Me.LabelSemestre.Text = "Semestre"
        '
        'ComboBoxSemestre
        '
        Me.ComboBoxSemestre.FormattingEnabled = True
        Me.ComboBoxSemestre.Items.AddRange(New Object() {"1.- Semestre", "2.- Semestre", "3.- Semestre", "4.- Semestre", "5.- Semestre", "6.- Semestre", "7.- Semestre", "8.- Semestre", "9.- Semestre"})
        Me.ComboBoxSemestre.Location = New System.Drawing.Point(644, 75)
        Me.ComboBoxSemestre.Name = "ComboBoxSemestre"
        Me.ComboBoxSemestre.Size = New System.Drawing.Size(189, 24)
        Me.ComboBoxSemestre.TabIndex = 28
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(144, 125)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(254, 22)
        Me.TextBoxDescripcion.TabIndex = 30
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.BackColor = System.Drawing.Color.Silver
        Me.LabelDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDescripcion.Location = New System.Drawing.Point(29, 126)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(109, 23)
        Me.LabelDescripcion.TabIndex = 29
        Me.LabelDescripcion.Text = "Descripcion"
        '
        'ComboBoxFacultad
        '
        Me.ComboBoxFacultad.FormattingEnabled = True
        Me.ComboBoxFacultad.Items.AddRange(New Object() {"Ingeniería", "Informática", "Derecho", "Psicología", "Filosofía", "Lenguas y Letras", "Artes", "Ciencias Naturales", "Contaduría"})
        Me.ComboBoxFacultad.Location = New System.Drawing.Point(516, 123)
        Me.ComboBoxFacultad.Name = "ComboBoxFacultad"
        Me.ComboBoxFacultad.Size = New System.Drawing.Size(157, 24)
        Me.ComboBoxFacultad.TabIndex = 32
        '
        'LabelFacultad
        '
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.BackColor = System.Drawing.Color.Silver
        Me.LabelFacultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFacultad.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFacultad.Location = New System.Drawing.Point(422, 126)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(81, 23)
        Me.LabelFacultad.TabIndex = 31
        Me.LabelFacultad.Text = "Facultad"
        '
        'DataGridMaterias
        '
        Me.DataGridMaterias.AllowUserToAddRows = False
        Me.DataGridMaterias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridMaterias.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Semestre, Me.Descripcion, Me.Facultad})
        Me.DataGridMaterias.GridColor = System.Drawing.Color.Silver
        Me.DataGridMaterias.Location = New System.Drawing.Point(30, 207)
        Me.DataGridMaterias.Name = "DataGridMaterias"
        Me.DataGridMaterias.ReadOnly = True
        Me.DataGridMaterias.RowHeadersWidth = 51
        Me.DataGridMaterias.RowTemplate.Height = 24
        Me.DataGridMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMaterias.Size = New System.Drawing.Size(800, 352)
        Me.DataGridMaterias.TabIndex = 32
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'Semestre
        '
        Me.Semestre.HeaderText = "Semestre"
        Me.Semestre.MinimumWidth = 6
        Me.Semestre.Name = "Semestre"
        Me.Semestre.ReadOnly = True
        Me.Semestre.Width = 150
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'Facultad
        '
        Me.Facultad.HeaderText = "Facultad"
        Me.Facultad.MinimumWidth = 6
        Me.Facultad.Name = "Facultad"
        Me.Facultad.ReadOnly = True
        Me.Facultad.Width = 150
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonEliminar)
        Me.PanelInferior.Controls.Add(Me.ButtonReiniciar)
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 565)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(860, 95)
        Me.PanelInferior.TabIndex = 34
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonEliminar.Location = New System.Drawing.Point(30, 22)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonEliminar.TabIndex = 14
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReiniciar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonReiniciar.Location = New System.Drawing.Point(554, 22)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonReiniciar.TabIndex = 13
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAceptar.Location = New System.Drawing.Point(702, 22)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonAceptar.TabIndex = 12
        Me.ButtonAceptar.Text = "Agregar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(30, 179)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(81, 22)
        Me.TextBoxTotal.TabIndex = 35
        '
        'Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 660)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.DataGridMaterias)
        Me.Controls.Add(Me.ComboBoxFacultad)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.ComboBoxSemestre)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelMaterias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Materias"
        Me.Text = "Materias"
        CType(Me.DataGridMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMaterias As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents ComboBoxSemestre As ComboBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents ComboBoxFacultad As ComboBox
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents DataGridMaterias As DataGridView
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonReiniciar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Semestre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Facultad As DataGridViewTextBoxColumn
End Class
