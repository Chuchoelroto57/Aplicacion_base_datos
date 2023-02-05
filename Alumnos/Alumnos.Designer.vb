<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
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
        Me.LabelAlumnos = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.ComboBoxFacultad = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.PanelInferior.SuspendLayout()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAlumnos
        '
        Me.LabelAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelAlumnos.AutoSize = True
        Me.LabelAlumnos.BackColor = System.Drawing.Color.Silver
        Me.LabelAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelAlumnos.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAlumnos.Location = New System.Drawing.Point(335, 22)
        Me.LabelAlumnos.Name = "LabelAlumnos"
        Me.LabelAlumnos.Size = New System.Drawing.Size(144, 41)
        Me.LabelAlumnos.TabIndex = 21
        Me.LabelAlumnos.Text = "Alumnos"
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
        Me.ButtonAceptar.Location = New System.Drawing.Point(702, 22)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(131, 42)
        Me.ButtonAceptar.TabIndex = 12
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 565)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(860, 95)
        Me.PanelInferior.TabIndex = 32
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.AllowUserToAddRows = False
        Me.DataGridAlumnos.AllowUserToResizeColumns = False
        Me.DataGridAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.GridColor = System.Drawing.Color.Silver
        Me.DataGridAlumnos.Location = New System.Drawing.Point(33, 166)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.ReadOnly = True
        Me.DataGridAlumnos.RowHeadersWidth = 51
        Me.DataGridAlumnos.RowTemplate.Height = 24
        Me.DataGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAlumnos.Size = New System.Drawing.Size(800, 352)
        Me.DataGridAlumnos.TabIndex = 33
        '
        'ComboBoxFacultad
        '
        Me.ComboBoxFacultad.FormattingEnabled = True
        Me.ComboBoxFacultad.Location = New System.Drawing.Point(161, 108)
        Me.ComboBoxFacultad.Name = "ComboBoxFacultad"
        Me.ComboBoxFacultad.Size = New System.Drawing.Size(199, 24)
        Me.ComboBoxFacultad.TabIndex = 34
        '
        'LabelFacultad
        '
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.Location = New System.Drawing.Point(49, 108)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(82, 24)
        Me.LabelFacultad.TabIndex = 35
        Me.LabelFacultad.Text = "Facultad"
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 660)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.ComboBoxFacultad)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAlumnos As Label
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents ComboBoxFacultad As ComboBox
    Friend WithEvents LabelFacultad As Label
End Class
