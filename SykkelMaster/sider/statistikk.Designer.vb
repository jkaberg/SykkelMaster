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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbxStats = New System.Windows.Forms.ComboBox()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graf
        '
        Me.graf.BackColor = System.Drawing.Color.Transparent
        Me.graf.BorderlineColor = System.Drawing.Color.Transparent
        Me.graf.BorderlineWidth = 0
        ChartArea4.Area3DStyle.Enable3D = True
        ChartArea4.Area3DStyle.IsClustered = True
        ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea4.Area3DStyle.PointDepth = 30
        ChartArea4.Area3DStyle.PointGapDepth = 30
        ChartArea4.Area3DStyle.WallWidth = 1
        ChartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        ChartArea4.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea4.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea4.Name = "ChartArea1"
        ChartArea4.ShadowColor = System.Drawing.Color.DarkGray
        Me.graf.ChartAreas.Add(ChartArea4)
        Legend4.Alignment = System.Drawing.StringAlignment.Far
        Legend4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend4.Enabled = False
        Legend4.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Legend4.HeaderSeparatorColor = System.Drawing.Color.Transparent
        Legend4.InterlacedRows = True
        Legend4.IsEquallySpacedItems = True
        Legend4.ItemColumnSeparatorColor = System.Drawing.Color.Transparent
        Legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend4.Name = "Legend1"
        Legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend4.TitleBackColor = System.Drawing.Color.Black
        Me.graf.Legends.Add(Legend4)
        Me.graf.Location = New System.Drawing.Point(12, 12)
        Me.graf.Name = "graf"
        Series4.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series4.BackSecondaryColor = System.Drawing.Color.Transparent
        Series4.BorderColor = System.Drawing.Color.Black
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Series4.IsValueShownAsLabel = True
        Series4.LabelBackColor = System.Drawing.Color.LightGray
        Series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series4.LabelBorderWidth = 0
        Series4.Legend = "Legend1"
        Series4.MarkerBorderColor = System.Drawing.Color.Transparent
        Series4.MarkerColor = System.Drawing.Color.Transparent
        Series4.Name = "Series1"
        Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series4.ShadowColor = System.Drawing.Color.Beige
        Series4.SmartLabelStyle.Enabled = False
        Me.graf.Series.Add(Series4)
        Me.graf.Size = New System.Drawing.Size(897, 467)
        Me.graf.TabIndex = 0
        Me.graf.Text = "Chart1"
        '
        'cbxStats
        '
        Me.cbxStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStats.FormattingEnabled = True
        Me.cbxStats.Items.AddRange(New Object() {"Antal sykkler per sykkeltype", "Mest populære sykklene", "Hvor mange sykkler per ""lagerplass""", "Hvilke sykkler blir mest ødelagd"})
        Me.cbxStats.Location = New System.Drawing.Point(12, 485)
        Me.cbxStats.Name = "cbxStats"
        Me.cbxStats.Size = New System.Drawing.Size(287, 24)
        Me.cbxStats.TabIndex = 1
        '
        'statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 526)
        Me.Controls.Add(Me.cbxStats)
        Me.Controls.Add(Me.graf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "statistikk"
        Me.Text = "Statistikk"
        CType(Me.graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents graf As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cbxStats As System.Windows.Forms.ComboBox
End Class
