<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.LabeAlumnos = New System.Windows.Forms.Label()
        Me.LabelFolio = New System.Windows.Forms.Label()
        Me.DataGridLibros = New System.Windows.Forms.DataGridView()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxAutor = New System.Windows.Forms.TextBox()
        Me.LabelAutor = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.LabelSucursal = New System.Windows.Forms.Label()
        Me.ComboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.LabelRegistros = New System.Windows.Forms.Label()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.TextBoxFol = New System.Windows.Forms.TextBox()
        Me.PanelInferior.SuspendLayout()
        CType(Me.DataGridLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonActualizar)
        Me.PanelInferior.Controls.Add(Me.ButtonEliminar)
        Me.PanelInferior.Controls.Add(Me.ButtonReiniciar)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 565)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(860, 95)
        Me.PanelInferior.TabIndex = 37
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
        'LabeAlumnos
        '
        Me.LabeAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabeAlumnos.AutoSize = True
        Me.LabeAlumnos.BackColor = System.Drawing.Color.Silver
        Me.LabeAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabeAlumnos.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabeAlumnos.Location = New System.Drawing.Point(384, 33)
        Me.LabeAlumnos.Name = "LabeAlumnos"
        Me.LabeAlumnos.Size = New System.Drawing.Size(105, 41)
        Me.LabeAlumnos.TabIndex = 36
        Me.LabeAlumnos.Text = "Libros"
        '
        'LabelFolio
        '
        Me.LabelFolio.AutoSize = True
        Me.LabelFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFolio.Location = New System.Drawing.Point(66, 130)
        Me.LabelFolio.Name = "LabelFolio"
        Me.LabelFolio.Size = New System.Drawing.Size(52, 24)
        Me.LabelFolio.TabIndex = 40
        Me.LabelFolio.Text = "Folio"
        '
        'DataGridLibros
        '
        Me.DataGridLibros.AllowUserToAddRows = False
        Me.DataGridLibros.AllowUserToResizeColumns = False
        Me.DataGridLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridLibros.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLibros.GridColor = System.Drawing.Color.Silver
        Me.DataGridLibros.Location = New System.Drawing.Point(297, 121)
        Me.DataGridLibros.Name = "DataGridLibros"
        Me.DataGridLibros.ReadOnly = True
        Me.DataGridLibros.RowHeadersWidth = 51
        Me.DataGridLibros.RowTemplate.Height = 24
        Me.DataGridLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridLibros.Size = New System.Drawing.Size(536, 386)
        Me.DataGridLibros.TabIndex = 38
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(70, 231)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxNombre.TabIndex = 43
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(66, 204)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 24)
        Me.LabelNombre.TabIndex = 42
        Me.LabelNombre.Text = "Nombre"
        '
        'TextBoxAutor
        '
        Me.TextBoxAutor.Location = New System.Drawing.Point(70, 299)
        Me.TextBoxAutor.Name = "TextBoxAutor"
        Me.TextBoxAutor.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxAutor.TabIndex = 45
        '
        'LabelAutor
        '
        Me.LabelAutor.AutoSize = True
        Me.LabelAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutor.Location = New System.Drawing.Point(66, 272)
        Me.LabelAutor.Name = "LabelAutor"
        Me.LabelAutor.Size = New System.Drawing.Size(55, 24)
        Me.LabelAutor.TabIndex = 44
        Me.LabelAutor.Text = "Autor"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(70, 369)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxDescripcion.TabIndex = 47
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(66, 342)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(110, 24)
        Me.LabelDescripcion.TabIndex = 46
        Me.LabelDescripcion.Text = "Descripcion"
        '
        'LabelSucursal
        '
        Me.LabelSucursal.AutoSize = True
        Me.LabelSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSucursal.Location = New System.Drawing.Point(66, 415)
        Me.LabelSucursal.Name = "LabelSucursal"
        Me.LabelSucursal.Size = New System.Drawing.Size(160, 24)
        Me.LabelSucursal.TabIndex = 48
        Me.LabelSucursal.Text = "Sucursal de venta"
        '
        'ComboBoxSucursal
        '
        Me.ComboBoxSucursal.FormattingEnabled = True
        Me.ComboBoxSucursal.Items.AddRange(New Object() {"Queretaro", "Cancun", "Las vegas", "Qatar", "Croacia", "Ixtapalapa"})
        Me.ComboBoxSucursal.Location = New System.Drawing.Point(70, 443)
        Me.ComboBoxSucursal.Name = "ComboBoxSucursal"
        Me.ComboBoxSucursal.Size = New System.Drawing.Size(196, 24)
        Me.ComboBoxSucursal.TabIndex = 49
        '
        'LabelRegistros
        '
        Me.LabelRegistros.AutoSize = True
        Me.LabelRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistros.Location = New System.Drawing.Point(643, 80)
        Me.LabelRegistros.Name = "LabelRegistros"
        Me.LabelRegistros.Size = New System.Drawing.Size(154, 24)
        Me.LabelRegistros.TabIndex = 50
        Me.LabelRegistros.Text = "Total de registros"
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumero.Location = New System.Drawing.Point(803, 80)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(30, 24)
        Me.LabelNumero.TabIndex = 51
        Me.LabelNumero.Text = "19"
        '
        'TextBoxFol
        '
        Me.TextBoxFol.Location = New System.Drawing.Point(70, 168)
        Me.TextBoxFol.Name = "TextBoxFol"
        Me.TextBoxFol.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxFol.TabIndex = 52
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 660)
        Me.Controls.Add(Me.TextBoxFol)
        Me.Controls.Add(Me.LabelNumero)
        Me.Controls.Add(Me.LabelRegistros)
        Me.Controls.Add(Me.ComboBoxSucursal)
        Me.Controls.Add(Me.LabelSucursal)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.TextBoxAutor)
        Me.Controls.Add(Me.LabelAutor)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabeAlumnos)
        Me.Controls.Add(Me.LabelFolio)
        Me.Controls.Add(Me.DataGridLibros)
        Me.Controls.Add(Me.PanelInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Libros"
        Me.Text = "Libros"
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.DataGridLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents LabeAlumnos As Label
    Friend WithEvents LabelFolio As Label
    Friend WithEvents DataGridLibros As DataGridView
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxAutor As TextBox
    Friend WithEvents LabelAutor As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents LabelSucursal As Label
    Friend WithEvents ComboBoxSucursal As ComboBox
    Friend WithEvents LabelRegistros As Label
    Friend WithEvents LabelNumero As Label
    Friend WithEvents TextBoxFol As TextBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonReiniciar As Button
    Friend WithEvents ButtonActualizar As Button
End Class
