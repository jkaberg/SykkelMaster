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
        Me.dtpInnkjop = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInnkjopspris = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSykkeltype = New System.Windows.Forms.Button()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxSokStatus = New System.Windows.Forms.ComboBox()
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
        Me.GroupBox1.Controls.Add(Me.dtpInnkjop)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtInnkjopspris)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnSykkeltype)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(238, 405)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legg til/Redigere"
        '
        'dtpInnkjop
        '
        Me.dtpInnkjop.Location = New System.Drawing.Point(77, 133)
        Me.dtpInnkjop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpInnkjop.Name = "dtpInnkjop"
        Me.dtpInnkjop.Size = New System.Drawing.Size(152, 20)
        Me.dtpInnkjop.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 136)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Innkjøpsdato"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(156, 116)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Kr"
        '
        'txtInnkjopspris
        '
        Me.txtInnkjopspris.Location = New System.Drawing.Point(77, 112)
        Me.txtInnkjopspris.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtInnkjopspris.Name = "txtInnkjopspris"
        Me.txtInnkjopspris.Size = New System.Drawing.Size(76, 20)
        Me.txtInnkjopspris.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Innkjøpspris"
        '
        'btnSykkeltype
        '
        Me.btnSykkeltype.Location = New System.Drawing.Point(161, 88)
        Me.btnSykkeltype.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSykkeltype.Name = "btnSykkeltype"
        Me.btnSykkeltype.Size = New System.Drawing.Size(73, 23)
        Me.btnSykkeltype.TabIndex = 5
        Me.btnSykkeltype.Text = "Legg til"
        Me.btnSykkeltype.UseVisualStyleBackColor = True
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(7, 280)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(222, 25)
        Me.btnTom.TabIndex = 12
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'cbxPosisjon
        '
        Me.cbxPosisjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPosisjon.FormattingEnabled = True
        Me.cbxPosisjon.Location = New System.Drawing.Point(60, 65)
        Me.cbxPosisjon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbxPosisjon.Name = "cbxPosisjon"
        Me.cbxPosisjon.Size = New System.Drawing.Size(169, 21)
        Me.cbxPosisjon.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 68)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Posisjon"
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(6, 374)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(222, 25)
        Me.btnSlett.TabIndex = 15
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(7, 343)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(222, 25)
        Me.btnOppdater.TabIndex = 14
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(7, 311)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(222, 25)
        Me.btnLeggTil.TabIndex = 13
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'txtAvvik
        '
        Me.txtAvvik.Location = New System.Drawing.Point(60, 205)
        Me.txtAvvik.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAvvik.Multiline = True
        Me.txtAvvik.Name = "txtAvvik"
        Me.txtAvvik.Size = New System.Drawing.Size(169, 70)
        Me.txtAvvik.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Avviksmld"
        '
        'cbxStatus
        '
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Tilgjengelig", "Leid ut", "Reparasjon", "Reservert"})
        Me.cbxStatus.Location = New System.Drawing.Point(60, 180)
        Me.cbxStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(169, 21)
        Me.cbxStatus.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Status"
        '
        'cbxHjul
        '
        Me.cbxHjul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHjul.FormattingEnabled = True
        Me.cbxHjul.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "24"})
        Me.cbxHjul.Location = New System.Drawing.Point(60, 155)
        Me.cbxHjul.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxHjul.Name = "cbxHjul"
        Me.cbxHjul.Size = New System.Drawing.Size(53, 21)
        Me.cbxHjul.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hjulstr"
        '
        'cbxRamme
        '
        Me.cbxRamme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRamme.FormattingEnabled = True
        Me.cbxRamme.Items.AddRange(New Object() {"13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbxRamme.Location = New System.Drawing.Point(176, 155)
        Me.cbxRamme.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxRamme.Name = "cbxRamme"
        Me.cbxRamme.Size = New System.Drawing.Size(53, 21)
        Me.cbxRamme.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rammestr"
        '
        'txtRammenr
        '
        Me.txtRammenr.Location = New System.Drawing.Point(60, 19)
        Me.txtRammenr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRammenr.Name = "txtRammenr"
        Me.txtRammenr.Size = New System.Drawing.Size(169, 20)
        Me.txtRammenr.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rammenr"
        '
        'cbxTilhorer
        '
        Me.cbxTilhorer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTilhorer.FormattingEnabled = True
        Me.cbxTilhorer.Location = New System.Drawing.Point(60, 42)
        Me.cbxTilhorer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxTilhorer.Name = "cbxTilhorer"
        Me.cbxTilhorer.Size = New System.Drawing.Size(169, 21)
        Me.cbxTilhorer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tilhører"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Location = New System.Drawing.Point(61, 88)
        Me.cbxType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(93, 21)
        Me.cbxType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbxSokStatus)
        Me.GroupBox2.Controls.Add(Me.txtSok)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxLokasjon)
        Me.GroupBox2.Controls.Add(Me.SykkelGridView)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(661, 405)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Status:"
        '
        'cbxSokStatus
        '
        Me.cbxSokStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSokStatus.FormattingEnabled = True
        Me.cbxSokStatus.Items.AddRange(New Object() {"Tilgjengelig", "Leid ut", "Reparasjon", "Reservert"})
        Me.cbxSokStatus.Location = New System.Drawing.Point(385, 13)
        Me.cbxSokStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxSokStatus.Name = "cbxSokStatus"
        Me.cbxSokStatus.Size = New System.Drawing.Size(99, 21)
        Me.cbxSokStatus.TabIndex = 18
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(227, 13)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(100, 20)
        Me.txtSok.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Rammenr:"
        '
        'cbxLokasjon
        '
        Me.cbxLokasjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLokasjon.FormattingEnabled = True
        Me.cbxLokasjon.Location = New System.Drawing.Point(58, 13)
        Me.cbxLokasjon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxLokasjon.Name = "cbxLokasjon"
        Me.cbxLokasjon.Size = New System.Drawing.Size(99, 21)
        Me.cbxLokasjon.TabIndex = 16
        '
        'SykkelGridView
        '
        Me.SykkelGridView.AllowUserToAddRows = False
        Me.SykkelGridView.AllowUserToDeleteRows = False
        Me.SykkelGridView.AllowUserToResizeRows = False
        Me.SykkelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SykkelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SykkelGridView.Location = New System.Drawing.Point(7, 38)
        Me.SykkelGridView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SykkelGridView.MultiSelect = False
        Me.SykkelGridView.Name = "SykkelGridView"
        Me.SykkelGridView.ReadOnly = True
        Me.SykkelGridView.RowHeadersVisible = False
        Me.SykkelGridView.RowTemplate.Height = 24
        Me.SykkelGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SykkelGridView.Size = New System.Drawing.Size(649, 361)
        Me.SykkelGridView.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Posisjon"
        '
        'sykkelEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 421)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxSokStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSykkeltype As System.Windows.Forms.Button
    Friend WithEvents dtpInnkjop As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInnkjopspris As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
