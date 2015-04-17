<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statistikk
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbxStats = New System.Windows.Forms.ComboBox()
        CType(Me.graf,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'graf
        '
        Me.graf.BackColor = System.Drawing.Color.Transparent
        Me.graf.BorderlineColor = System.Drawing.Color.Transparent
        Me.graf.BorderlineWidth = 0
        ChartArea1.Area3DStyle.Enable3D = true
        ChartArea1.Area3DStyle.IsClustered = true
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.PointDepth = 30
        ChartArea1.Area3DStyle.PointGapDepth = 30
        ChartArea1.Area3DStyle.WallWidth = 1
        ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.DarkGray
        Me.graf.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend1.Enabled = false
        Legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent
        Legend1.InterlacedRows = true
        Legend1.IsEquallySpacedItems = true
        Legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend1.Name = "Legend1"
        Legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend1.TitleBackColor = System.Drawing.Color.Black
        Me.graf.Legends.Add(Legend1)
        Me.graf.Location = New System.Drawing.Point(9, 10)
        Me.graf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.graf.Name = "graf"
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!)
        Series1.IsValueShownAsLabel = true
        Series1.LabelBackColor = System.Drawing.Color.LightGray
        Series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.LabelBorderWidth = 0
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.Transparent
        Series1.MarkerColor = System.Drawing.Color.Transparent
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series1.ShadowColor = System.Drawing.Color.Beige
        Series1.SmartLabelStyle.Enabled = false
        Me.graf.Series.Add(Series1)
        Me.graf.Size = New System.Drawing.Size(673, 380)
        Me.graf.TabIndex = 0
        Me.graf.Text = "Chart1"
        '
        'cbxStats
        '
        Me.cbxStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStats.FormattingEnabled = true
        Me.cbxStats.Items.AddRange(New Object() {"Antal sykkler per sykkeltype", "Mest populære syklene", "Hvor mange sykler per ""lagerplass""", "Hvilke type sykler er ødelagt"})
        Me.cbxStats.Location = New System.Drawing.Point(9, 394)
        Me.cbxStats.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxStats.Name = "cbxStats"
        Me.cbxStats.Size = New System.Drawing.Size(216, 21)
        Me.cbxStats.TabIndex = 1
        '
        'statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 428)
        Me.Controls.Add(Me.cbxStats)
        Me.Controls.Add(Me.graf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "statistikk"
        Me.Text = "Statistikk"
        CType(Me.graf,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents graf As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cbxStats As System.Windows.Forms.ComboBox
End Class
