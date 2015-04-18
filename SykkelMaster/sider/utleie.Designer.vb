<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class utleie
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbHelg = New System.Windows.Forms.RadioButton()
        Me.tilTid = New System.Windows.Forms.DateTimePicker()
        Me.fraTid = New System.Windows.Forms.DateTimePicker()
        Me.rbDag = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbTime = New System.Windows.Forms.RadioButton()
        Me.sykkelGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRabattAvtale = New System.Windows.Forms.ComboBox()
        Me.txtSokKunde = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxNavn = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKunde = New System.Windows.Forms.Button()
        Me.btnRedigerKunde = New System.Windows.Forms.Button()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vognSykkel = New System.Windows.Forms.DataGridView()
        Me.fjernSykkelKundevogn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FjernToolStripMenuSykkel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOprettAvtale = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.utstyrGrid = New System.Windows.Forms.DataGridView()
        Me.vognStyr = New System.Windows.Forms.DataGridView()
        Me.fjernUtstyrKundevogn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FjernToolStripMenuUtstyr = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTomKundevogn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.utstyrPris = New System.Windows.Forms.Label()
        Me.sykkelPris = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sykkelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.vognSykkel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fjernSykkelKundevogn.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.utstyrGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vognStyr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fjernUtstyrKundevogn.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHelg)
        Me.GroupBox1.Controls.Add(Me.tilTid)
        Me.GroupBox1.Controls.Add(Me.fraTid)
        Me.GroupBox1.Controls.Add(Me.rbDag)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbTime)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(259, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tid"
        '
        'rbHelg
        '
        Me.rbHelg.AutoSize = True
        Me.rbHelg.Location = New System.Drawing.Point(133, 20)
        Me.rbHelg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbHelg.Name = "rbHelg"
        Me.rbHelg.Size = New System.Drawing.Size(58, 21)
        Me.rbHelg.TabIndex = 24
        Me.rbHelg.TabStop = True
        Me.rbHelg.Text = "Helg"
        Me.rbHelg.UseVisualStyleBackColor = True
        '
        'tilTid
        '
        Me.tilTid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tilTid.Location = New System.Drawing.Point(101, 78)
        Me.tilTid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tilTid.Name = "tilTid"
        Me.tilTid.Size = New System.Drawing.Size(145, 22)
        Me.tilTid.TabIndex = 10
        '
        'fraTid
        '
        Me.fraTid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fraTid.Location = New System.Drawing.Point(101, 48)
        Me.fraTid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fraTid.Name = "fraTid"
        Me.fraTid.Size = New System.Drawing.Size(145, 22)
        Me.fraTid.TabIndex = 9
        '
        'rbDag
        '
        Me.rbDag.AutoSize = True
        Me.rbDag.Location = New System.Drawing.Point(5, 20)
        Me.rbDag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbDag.Name = "rbDag"
        Me.rbDag.Size = New System.Drawing.Size(55, 21)
        Me.rbDag.TabIndex = 8
        Me.rbDag.TabStop = True
        Me.rbDag.Text = "Dag"
        Me.rbDag.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Til tidspunkt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fra tidspunkt"
        '
        'rbTime
        '
        Me.rbTime.AutoSize = True
        Me.rbTime.Location = New System.Drawing.Point(67, 20)
        Me.rbTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbTime.Name = "rbTime"
        Me.rbTime.Size = New System.Drawing.Size(60, 21)
        Me.rbTime.TabIndex = 7
        Me.rbTime.TabStop = True
        Me.rbTime.Text = "Time"
        Me.rbTime.UseVisualStyleBackColor = True
        '
        'sykkelGrid
        '
        Me.sykkelGrid.AllowUserToAddRows = False
        Me.sykkelGrid.AllowUserToDeleteRows = False
        Me.sykkelGrid.AllowUserToResizeRows = False
        Me.sykkelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sykkelGrid.Location = New System.Drawing.Point(5, 33)
        Me.sykkelGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sykkelGrid.MultiSelect = False
        Me.sykkelGrid.Name = "sykkelGrid"
        Me.sykkelGrid.ReadOnly = True
        Me.sykkelGrid.RowHeadersVisible = False
        Me.sykkelGrid.RowTemplate.Height = 24
        Me.sykkelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sykkelGrid.Size = New System.Drawing.Size(401, 139)
        Me.sykkelGrid.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxRabattAvtale)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 130)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(259, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rabatt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Avtale"
        '
        'cbxRabattAvtale
        '
        Me.cbxRabattAvtale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRabattAvtale.FormattingEnabled = True
        Me.cbxRabattAvtale.Items.AddRange(New Object() {"10% Enkeltperson", "20% Enkeltperson", "99% Gruppe"})
        Me.cbxRabattAvtale.Location = New System.Drawing.Point(64, 17)
        Me.cbxRabattAvtale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxRabattAvtale.Name = "cbxRabattAvtale"
        Me.cbxRabattAvtale.Size = New System.Drawing.Size(184, 24)
        Me.cbxRabattAvtale.TabIndex = 6
        '
        'txtSokKunde
        '
        Me.txtSokKunde.Location = New System.Drawing.Point(87, 21)
        Me.txtSokKunde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSokKunde.Name = "txtSokKunde"
        Me.txtSokKunde.Size = New System.Drawing.Size(215, 22)
        Me.txtSokKunde.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Søk"
        '
        'cbxNavn
        '
        Me.cbxNavn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNavn.FormattingEnabled = True
        Me.cbxNavn.Location = New System.Drawing.Point(87, 50)
        Me.cbxNavn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxNavn.Name = "cbxNavn"
        Me.cbxNavn.Size = New System.Drawing.Size(215, 24)
        Me.cbxNavn.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Navn"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKunde)
        Me.GroupBox3.Controls.Add(Me.btnRedigerKunde)
        Me.GroupBox3.Controls.Add(Me.txtTelefon)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSokKunde)
        Me.GroupBox3.Controls.Add(Me.cbxNavn)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(309, 165)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kunde"
        '
        'btnKunde
        '
        Me.btnKunde.Location = New System.Drawing.Point(13, 108)
        Me.btnKunde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKunde.Name = "btnKunde"
        Me.btnKunde.Size = New System.Drawing.Size(149, 49)
        Me.btnKunde.TabIndex = 4
        Me.btnKunde.Text = "Legg til ny kunde"
        Me.btnKunde.UseVisualStyleBackColor = True
        '
        'btnRedigerKunde
        '
        Me.btnRedigerKunde.Location = New System.Drawing.Point(171, 108)
        Me.btnRedigerKunde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRedigerKunde.Name = "btnRedigerKunde"
        Me.btnRedigerKunde.Size = New System.Drawing.Size(132, 49)
        Me.btnRedigerKunde.TabIndex = 5
        Me.btnRedigerKunde.Text = "Rediger kunde"
        Me.btnRedigerKunde.UseVisualStyleBackColor = True
        '
        'txtTelefon
        '
        Me.txtTelefon.Enabled = False
        Me.txtTelefon.Location = New System.Drawing.Point(87, 80)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(215, 22)
        Me.txtTelefon.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telefonnr"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.sykkelGrid)
        Me.GroupBox4.Controls.Add(Me.vognSykkel)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(419, 367)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sykkel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 15)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ledige sykkler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sykkler i kundevognen"
        '
        'vognSykkel
        '
        Me.vognSykkel.AllowUserToAddRows = False
        Me.vognSykkel.AllowUserToDeleteRows = False
        Me.vognSykkel.AllowUserToResizeRows = False
        Me.vognSykkel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vognSykkel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vognSykkel.ContextMenuStrip = Me.fjernSykkelKundevogn
        Me.vognSykkel.Location = New System.Drawing.Point(5, 196)
        Me.vognSykkel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vognSykkel.MultiSelect = False
        Me.vognSykkel.Name = "vognSykkel"
        Me.vognSykkel.ReadOnly = True
        Me.vognSykkel.RowHeadersVisible = False
        Me.vognSykkel.RowTemplate.Height = 24
        Me.vognSykkel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.vognSykkel.Size = New System.Drawing.Size(401, 161)
        Me.vognSykkel.TabIndex = 0
        '
        'fjernSykkelKundevogn
        '
        Me.fjernSykkelKundevogn.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.fjernSykkelKundevogn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FjernToolStripMenuSykkel})
        Me.fjernSykkelKundevogn.Name = "ContextMenuStrip1"
        Me.fjernSykkelKundevogn.Size = New System.Drawing.Size(111, 28)
        '
        'FjernToolStripMenuSykkel
        '
        Me.FjernToolStripMenuSykkel.Name = "FjernToolStripMenuSykkel"
        Me.FjernToolStripMenuSykkel.Size = New System.Drawing.Size(110, 24)
        Me.FjernToolStripMenuSykkel.Text = "Fjern"
        '
        'btnOprettAvtale
        '
        Me.btnOprettAvtale.Location = New System.Drawing.Point(737, 556)
        Me.btnOprettAvtale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOprettAvtale.Name = "btnOprettAvtale"
        Me.btnOprettAvtale.Size = New System.Drawing.Size(117, 49)
        Me.btnOprettAvtale.TabIndex = 40
        Me.btnOprettAvtale.Text = "Opprett avtale"
        Me.btnOprettAvtale.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.utstyrGrid)
        Me.GroupBox5.Controls.Add(Me.vognStyr)
        Me.GroupBox5.Location = New System.Drawing.Point(436, 185)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(419, 367)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Utstyr"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Ledigt utstyr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 177)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Utstyr i kundevognen"
        '
        'utstyrGrid
        '
        Me.utstyrGrid.AllowUserToAddRows = False
        Me.utstyrGrid.AllowUserToDeleteRows = False
        Me.utstyrGrid.AllowUserToResizeRows = False
        Me.utstyrGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.utstyrGrid.Location = New System.Drawing.Point(5, 33)
        Me.utstyrGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.utstyrGrid.MultiSelect = False
        Me.utstyrGrid.Name = "utstyrGrid"
        Me.utstyrGrid.ReadOnly = True
        Me.utstyrGrid.RowHeadersVisible = False
        Me.utstyrGrid.RowTemplate.Height = 24
        Me.utstyrGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.utstyrGrid.Size = New System.Drawing.Size(401, 139)
        Me.utstyrGrid.TabIndex = 23
        '
        'vognStyr
        '
        Me.vognStyr.AllowUserToAddRows = False
        Me.vognStyr.AllowUserToDeleteRows = False
        Me.vognStyr.AllowUserToResizeRows = False
        Me.vognStyr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vognStyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vognStyr.ContextMenuStrip = Me.fjernUtstyrKundevogn
        Me.vognStyr.Location = New System.Drawing.Point(5, 196)
        Me.vognStyr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vognStyr.MultiSelect = False
        Me.vognStyr.Name = "vognStyr"
        Me.vognStyr.ReadOnly = True
        Me.vognStyr.RowHeadersVisible = False
        Me.vognStyr.RowTemplate.Height = 24
        Me.vognStyr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.vognStyr.Size = New System.Drawing.Size(401, 161)
        Me.vognStyr.TabIndex = 0
        '
        'fjernUtstyrKundevogn
        '
        Me.fjernUtstyrKundevogn.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.fjernUtstyrKundevogn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FjernToolStripMenuUtstyr})
        Me.fjernUtstyrKundevogn.Name = "fjernUtstyrKundevogn"
        Me.fjernUtstyrKundevogn.Size = New System.Drawing.Size(111, 28)
        '
        'FjernToolStripMenuUtstyr
        '
        Me.FjernToolStripMenuUtstyr.Name = "FjernToolStripMenuUtstyr"
        Me.FjernToolStripMenuUtstyr.Size = New System.Drawing.Size(110, 24)
        Me.FjernToolStripMenuUtstyr.Text = "Fjern"
        '
        'btnTomKundevogn
        '
        Me.btnTomKundevogn.Location = New System.Drawing.Point(607, 556)
        Me.btnTomKundevogn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTomKundevogn.Name = "btnTomKundevogn"
        Me.btnTomKundevogn.Size = New System.Drawing.Size(125, 49)
        Me.btnTomKundevogn.TabIndex = 41
        Me.btnTomKundevogn.Text = "Tøm kundevogner"
        Me.btnTomKundevogn.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.utstyrPris)
        Me.GroupBox6.Controls.Add(Me.sykkelPris)
        Me.GroupBox6.Location = New System.Drawing.Point(593, 14)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(261, 165)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Informasjon"
        '
        'utstyrPris
        '
        Me.utstyrPris.AutoSize = True
        Me.utstyrPris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.utstyrPris.Location = New System.Drawing.Point(1, 141)
        Me.utstyrPris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.utstyrPris.Name = "utstyrPris"
        Me.utstyrPris.Size = New System.Drawing.Size(162, 20)
        Me.utstyrPris.TabIndex = 2
        Me.utstyrPris.Text = "Utstyrpris: 0 kr /time"
        '
        'sykkelPris
        '
        Me.sykkelPris.AutoSize = True
        Me.sykkelPris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sykkelPris.Location = New System.Drawing.Point(1, 116)
        Me.sykkelPris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sykkelPris.Name = "sykkelPris"
        Me.sykkelPris.Size = New System.Drawing.Size(165, 20)
        Me.sykkelPris.TabIndex = 1
        Me.sykkelPris.Text = "Sykkelpris: 0 kr /time"
        '
        'utleie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 612)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnOprettAvtale)
        Me.Controls.Add(Me.btnTomKundevogn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "utleie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utleie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sykkelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.vognSykkel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fjernSykkelKundevogn.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.utstyrGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vognStyr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fjernUtstyrKundevogn.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSokKunde As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbxNavn As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKunde As System.Windows.Forms.Button
    Friend WithEvents btnRedigerKunde As System.Windows.Forms.Button
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tilTid As System.Windows.Forms.DateTimePicker
    Friend WithEvents fraTid As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbDag As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbTime As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents vognSykkel As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxRabattAvtale As System.Windows.Forms.ComboBox
    Friend WithEvents btnOprettAvtale As System.Windows.Forms.Button
    Friend WithEvents sykkelGrid As System.Windows.Forms.DataGridView
    Friend WithEvents rbHelg As System.Windows.Forms.RadioButton
    Friend WithEvents fjernSykkelKundevogn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FjernToolStripMenuSykkel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents utstyrGrid As System.Windows.Forms.DataGridView
    Friend WithEvents vognStyr As System.Windows.Forms.DataGridView
    Friend WithEvents fjernUtstyrKundevogn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FjernToolStripMenuUtstyr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTomKundevogn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents sykkelPris As System.Windows.Forms.Label
    Friend WithEvents utstyrPris As System.Windows.Forms.Label
End Class
