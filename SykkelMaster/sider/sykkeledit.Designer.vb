<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sykkelEdit
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
        Me.btnTom = New System.Windows.Forms.Button()
        Me.cbxPosisjon = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.txtAvvik = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxHjul = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxRamme = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRammenr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTilhorer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxLokasjon = New System.Windows.Forms.ComboBox()
        Me.SykkelGridView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SykkelGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTom)
        Me.GroupBox1.Controls.Add(Me.cbxPosisjon)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnSlett)
        Me.GroupBox1.Controls.Add(Me.btnOppdater)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
        Me.GroupBox1.Controls.Add(Me.txtAvvik)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxHjul)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxRamme)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRammenr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxTilhorer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 535)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legg til/Redigere"
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(11, 353)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(333, 38)
        Me.btnTom.TabIndex = 9
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'cbxPosisjon
        '
        Me.cbxPosisjon.FormattingEnabled = True
        Me.cbxPosisjon.Location = New System.Drawing.Point(90, 63)
        Me.cbxPosisjon.Name = "cbxPosisjon"
        Me.cbxPosisjon.Size = New System.Drawing.Size(252, 28)
        Me.cbxPosisjon.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Posisjon"
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(11, 489)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(333, 38)
        Me.btnSlett.TabIndex = 12
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(11, 443)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(333, 38)
        Me.btnOppdater.TabIndex = 11
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(9, 397)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(333, 38)
        Me.btnLeggTil.TabIndex = 10
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'txtAvvik
        '
        Me.txtAvvik.Location = New System.Drawing.Point(90, 240)
        Me.txtAvvik.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAvvik.Multiline = True
        Me.txtAvvik.Name = "txtAvvik"
        Me.txtAvvik.Size = New System.Drawing.Size(252, 105)
        Me.txtAvvik.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Avviksmld"
        '
        'cbxStatus
        '
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Innlevert", "Leid ut", "Reparasjon"})
        Me.cbxStatus.Location = New System.Drawing.Point(90, 204)
        Me.cbxStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(252, 28)
        Me.cbxStatus.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Status"
        '
        'cbxHjul
        '
        Me.cbxHjul.FormattingEnabled = True
        Me.cbxHjul.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "24"})
        Me.cbxHjul.Location = New System.Drawing.Point(90, 168)
        Me.cbxHjul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxHjul.Name = "cbxHjul"
        Me.cbxHjul.Size = New System.Drawing.Size(77, 28)
        Me.cbxHjul.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hjulstr"
        '
        'cbxRamme
        '
        Me.cbxRamme.FormattingEnabled = True
        Me.cbxRamme.Items.AddRange(New Object() {"13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbxRamme.Location = New System.Drawing.Point(264, 168)
        Me.cbxRamme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxRamme.Name = "cbxRamme"
        Me.cbxRamme.Size = New System.Drawing.Size(78, 28)
        Me.cbxRamme.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rammestr"
        '
        'txtRammenr
        '
        Me.txtRammenr.Location = New System.Drawing.Point(90, 134)
        Me.txtRammenr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRammenr.Name = "txtRammenr"
        Me.txtRammenr.Size = New System.Drawing.Size(252, 26)
        Me.txtRammenr.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rammenr"
        '
        'cbxTilhorer
        '
        Me.cbxTilhorer.FormattingEnabled = True
        Me.cbxTilhorer.Location = New System.Drawing.Point(90, 28)
        Me.cbxTilhorer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxTilhorer.Name = "cbxTilhorer"
        Me.cbxTilhorer.Size = New System.Drawing.Size(252, 28)
        Me.cbxTilhorer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tilhører"
        '
        'cbxType
        '
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Mountainbike", "Bysykkel", "Hybridsykkel", "Barnsykkel"})
        Me.cbxType.Location = New System.Drawing.Point(90, 98)
        Me.cbxType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(252, 28)
        Me.cbxType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSok)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxLokasjon)
        Me.GroupBox2.Controls.Add(Me.SykkelGridView)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1035, 535)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(341, 20)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(148, 26)
        Me.txtSok.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Rammenr:"
        '
        'cbxLokasjon
        '
        Me.cbxLokasjon.FormattingEnabled = True
        Me.cbxLokasjon.Location = New System.Drawing.Point(87, 20)
        Me.cbxLokasjon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxLokasjon.Name = "cbxLokasjon"
        Me.cbxLokasjon.Size = New System.Drawing.Size(147, 28)
        Me.cbxLokasjon.TabIndex = 13
        '
        'SykkelGridView
        '
        Me.SykkelGridView.AllowUserToAddRows = False
        Me.SykkelGridView.AllowUserToDeleteRows = False
        Me.SykkelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SykkelGridView.Location = New System.Drawing.Point(10, 58)
        Me.SykkelGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SykkelGridView.Name = "SykkelGridView"
        Me.SykkelGridView.ReadOnly = True
        Me.SykkelGridView.RowTemplate.Height = 24
        Me.SykkelGridView.Size = New System.Drawing.Size(1007, 469)
        Me.SykkelGridView.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Lokasjon"
        '
        'sykkelEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "sykkelEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sykkel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SykkelGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTilhorer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxHjul As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxRamme As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRammenr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLokasjon As System.Windows.Forms.ComboBox
    Friend WithEvents SykkelGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAvvik As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSlett As System.Windows.Forms.Button
    Friend WithEvents btnOppdater As System.Windows.Forms.Button
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSok As System.Windows.Forms.TextBox
    Friend WithEvents cbxPosisjon As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnTom As System.Windows.Forms.Button
End Class
