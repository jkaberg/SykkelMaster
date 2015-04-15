<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oversiktGrid = New System.Windows.Forms.DataGridView()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tilbehorGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.oversiktGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.tilbehorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.oversiktGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(979, 280)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avtale"
        '
        'oversiktGrid
        '
        Me.oversiktGrid.AllowUserToAddRows = False
        Me.oversiktGrid.AllowUserToDeleteRows = False
        Me.oversiktGrid.AllowUserToResizeRows = False
        Me.oversiktGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.oversiktGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oversiktGrid.Location = New System.Drawing.Point(6, 21)
        Me.oversiktGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oversiktGrid.MultiSelect = False
        Me.oversiktGrid.Name = "oversiktGrid"
        Me.oversiktGrid.ReadOnly = True
        Me.oversiktGrid.RowHeadersVisible = False
        Me.oversiktGrid.RowTemplate.Height = 24
        Me.oversiktGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.oversiktGrid.Size = New System.Drawing.Size(964, 245)
        Me.oversiktGrid.TabIndex = 0
        '
        'cbxStatus
        '
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Leid ut", "Innlevert"})
        Me.cbxStatus.Location = New System.Drawing.Point(796, 7)
        Me.cbxStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(186, 28)
        Me.cbxStatus.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(749, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Søk:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tilbehorGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 319)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(979, 208)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tilbehør"
        '
        'tilbehorGrid
        '
        Me.tilbehorGrid.AllowUserToAddRows = False
        Me.tilbehorGrid.AllowUserToDeleteRows = False
        Me.tilbehorGrid.AllowUserToResizeRows = False
        Me.tilbehorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tilbehorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tilbehorGrid.Location = New System.Drawing.Point(8, 22)
        Me.tilbehorGrid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tilbehorGrid.MultiSelect = False
        Me.tilbehorGrid.Name = "tilbehorGrid"
        Me.tilbehorGrid.ReadOnly = True
        Me.tilbehorGrid.RowHeadersVisible = False
        Me.tilbehorGrid.RowTemplate.Height = 24
        Me.tilbehorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tilbehorGrid.Size = New System.Drawing.Size(962, 180)
        Me.tilbehorGrid.TabIndex = 0
        '
        'historie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 532)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "historie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historie"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.oversiktGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.tilbehorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents oversiktGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tilbehorGrid As System.Windows.Forms.DataGridView
End Class
