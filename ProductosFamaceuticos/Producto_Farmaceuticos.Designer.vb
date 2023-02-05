<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Producto_Farmaceuticos
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
        Me.LabelProductosFarma = New System.Windows.Forms.Label()
        Me.DataGridProductos = New System.Windows.Forms.DataGridView()
        Me.ComboBoxLaboratorio = New System.Windows.Forms.ComboBox()
        Me.TextBoxTotalregistros = New System.Windows.Forms.TextBox()
        Me.LabelRegistro = New System.Windows.Forms.Label()
        CType(Me.DataGridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductosFarma
        '
        Me.LabelProductosFarma.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelProductosFarma.AutoSize = True
        Me.LabelProductosFarma.BackColor = System.Drawing.Color.Silver
        Me.LabelProductosFarma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelProductosFarma.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductosFarma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelProductosFarma.Location = New System.Drawing.Point(314, 28)
        Me.LabelProductosFarma.Name = "LabelProductosFarma"
        Me.LabelProductosFarma.Size = New System.Drawing.Size(221, 23)
        Me.LabelProductosFarma.TabIndex = 23
        Me.LabelProductosFarma.Text = "Productos Farmaceuticos"
        '
        'DataGridProductos
        '
        Me.DataGridProductos.AllowUserToAddRows = False
        Me.DataGridProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridProductos.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProductos.GridColor = System.Drawing.Color.Silver
        Me.DataGridProductos.Location = New System.Drawing.Point(37, 114)
        Me.DataGridProductos.Name = "DataGridProductos"
        Me.DataGridProductos.ReadOnly = True
        Me.DataGridProductos.RowHeadersWidth = 51
        Me.DataGridProductos.RowTemplate.Height = 24
        Me.DataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProductos.Size = New System.Drawing.Size(800, 515)
        Me.DataGridProductos.TabIndex = 33
        '
        'ComboBoxLaboratorio
        '
        Me.ComboBoxLaboratorio.FormattingEnabled = True
        Me.ComboBoxLaboratorio.Location = New System.Drawing.Point(577, 72)
        Me.ComboBoxLaboratorio.Name = "ComboBoxLaboratorio"
        Me.ComboBoxLaboratorio.Size = New System.Drawing.Size(260, 24)
        Me.ComboBoxLaboratorio.TabIndex = 34
        '
        'TextBoxTotalregistros
        '
        Me.TextBoxTotalregistros.Location = New System.Drawing.Point(236, 74)
        Me.TextBoxTotalregistros.Name = "TextBoxTotalregistros"
        Me.TextBoxTotalregistros.ReadOnly = True
        Me.TextBoxTotalregistros.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotalregistros.TabIndex = 35
        '
        'LabelRegistro
        '
        Me.LabelRegistro.AutoSize = True
        Me.LabelRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelRegistro.Location = New System.Drawing.Point(53, 74)
        Me.LabelRegistro.Name = "LabelRegistro"
        Me.LabelRegistro.Size = New System.Drawing.Size(162, 20)
        Me.LabelRegistro.TabIndex = 36
        Me.LabelRegistro.Text = "Numero de registros"
        '
        'Producto_Farmaceuticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 660)
        Me.Controls.Add(Me.LabelRegistro)
        Me.Controls.Add(Me.TextBoxTotalregistros)
        Me.Controls.Add(Me.ComboBoxLaboratorio)
        Me.Controls.Add(Me.DataGridProductos)
        Me.Controls.Add(Me.LabelProductosFarma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Producto_Farmaceuticos"
        Me.Text = "Producto_Farmaceuticos"
        CType(Me.DataGridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelProductosFarma As Label
    Friend WithEvents DataGridProductos As DataGridView
    Friend WithEvents ComboBoxLaboratorio As ComboBox
    Friend WithEvents TextBoxTotalregistros As TextBox
    Friend WithEvents LabelRegistro As Label
End Class
