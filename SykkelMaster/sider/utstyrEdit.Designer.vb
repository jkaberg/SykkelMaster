<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class utstyrEdit
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxStorrelse = New System.Windows.Forms.ComboBox()
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
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.utstyrGridView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.utstyrGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxStorrelse)
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
        Me.GroupBox1.Controls.Add(Me.cbxStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxTilhorer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 467)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legg til/Redigere"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Størrelse"
        '
        'cbxStorrelse
        '
        Me.cbxStorrelse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStorrelse.FormattingEnabled = True
        Me.cbxStorrelse.Items.AddRange(New Object() {"En størrelse", "XXS", "XS", "S", "M", "L", "XL", "XXL"})
        Me.cbxStorrelse.Location = New System.Drawing.Point(90, 244)
        Me.cbxStorrelse.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxStorrelse.Name = "cbxStorrelse"
        Me.cbxStorrelse.Size = New System.Drawing.Size(252, 28)
        Me.cbxStorrelse.TabIndex = 8
        '
        'dtpInnkjop
        '
        Me.dtpInnkjop.Location = New System.Drawing.Point(116, 172)
        Me.dtpInnkjop.Name = "dtpInnkjop"
        Me.dtpInnkjop.Size = New System.Drawing.Size(226, 26)
        Me.dtpInnkjop.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Innkjøpsdato"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(234, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Kr"
        '
        'txtInnkjopspris
        '
        Me.txtInnkjopspris.Location = New System.Drawing.Point(116, 140)
        Me.txtInnkjopspris.Name = "txtInnkjopspris"
        Me.txtInnkjopspris.Size = New System.Drawing.Size(112, 26)
        Me.txtInnkjopspris.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 20)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Innkjøpspris"
        '
        'btnSykkeltype
        '
        Me.btnSykkeltype.Location = New System.Drawing.Point(232, 99)
        Me.btnSykkeltype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSykkeltype.Name = "btnSykkeltype"
        Me.btnSykkeltype.Size = New System.Drawing.Size(110, 32)
        Me.btnSykkeltype.TabIndex = 4
        Me.btnSykkeltype.Text = "Legg til"
        Me.btnSykkeltype.UseVisualStyleBackColor = True
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(13, 282)
        Me.btnTom.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(329, 38)
        Me.btnTom.TabIndex = 9
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'cbxPosisjon
        '
        Me.cbxPosisjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPosisjon.FormattingEnabled = True
        Me.cbxPosisjon.Location = New System.Drawing.Point(90, 66)
        Me.cbxPosisjon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPosisjon.Name = "cbxPosisjon"
        Me.cbxPosisjon.Size = New System.Drawing.Size(252, 28)
        Me.cbxPosisjon.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Posisjon"
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(13, 419)
        Me.btnSlett.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(329, 38)
        Me.btnSlett.TabIndex = 12
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(13, 371)
        Me.btnOppdater.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(329, 38)
        Me.btnOppdater.TabIndex = 11
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(12, 328)
        Me.btnLeggTil.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(329, 38)
        Me.btnLeggTil.TabIndex = 10
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'cbxStatus
        '
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Tilgjengelig", "Leid ut", "Reservert"})
        Me.cbxStatus.Location = New System.Drawing.Point(90, 206)
        Me.cbxStatus.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(252, 28)
        Me.cbxStatus.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Status"
        '
        'cbxTilhorer
        '
        Me.cbxTilhorer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTilhorer.FormattingEnabled = True
        Me.cbxTilhorer.Location = New System.Drawing.Point(90, 32)
        Me.cbxTilhorer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxTilhorer.Name = "cbxTilhorer"
        Me.cbxTilhorer.Size = New System.Drawing.Size(252, 28)
        Me.cbxTilhorer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tilhører"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Location = New System.Drawing.Point(90, 102)
        Me.cbxType.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(138, 28)
        Me.cbxType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
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
        Me.GroupBox2.Controls.Add(Me.utstyrGridView)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(992, 467)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(512, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Status:"
        '
        'cbxSokStatus
        '
        Me.cbxSokStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSokStatus.FormattingEnabled = True
        Me.cbxSokStatus.Items.AddRange(New Object() {"Tilgjengelig", "Leid ut", "Reparasjon", "Reservert"})
        Me.cbxSokStatus.Location = New System.Drawing.Point(578, 20)
        Me.cbxSokStatus.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxSokStatus.Name = "cbxSokStatus"
        Me.cbxSokStatus.Size = New System.Drawing.Size(146, 28)
        Me.cbxSokStatus.TabIndex = 15
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(358, 19)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(148, 26)
        Me.txtSok.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Utstyrstype:"
        '
        'cbxLokasjon
        '
        Me.cbxLokasjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLokasjon.FormattingEnabled = True
        Me.cbxLokasjon.Location = New System.Drawing.Point(87, 20)
        Me.cbxLokasjon.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbxLokasjon.Name = "cbxLokasjon"
        Me.cbxLokasjon.Size = New System.Drawing.Size(146, 28)
        Me.cbxLokasjon.TabIndex = 13
        '
        'utstyrGridView
        '
        Me.utstyrGridView.AllowUserToAddRows = False
        Me.utstyrGridView.AllowUserToDeleteRows = False
        Me.utstyrGridView.AllowUserToResizeRows = False
        Me.utstyrGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.utstyrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.utstyrGridView.Location = New System.Drawing.Point(10, 58)
        Me.utstyrGridView.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.utstyrGridView.MultiSelect = False
        Me.utstyrGridView.Name = "utstyrGridView"
        Me.utstyrGridView.ReadOnly = True
        Me.utstyrGridView.RowHeadersVisible = False
        Me.utstyrGridView.RowTemplate.Height = 24
        Me.utstyrGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.utstyrGridView.Size = New System.Drawing.Size(974, 399)
        Me.utstyrGridView.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Posisjon"
        '
        'utstyrEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "utstyrEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utstyr"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.utstyrGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxTilhorer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLokasjon As System.Windows.Forms.ComboBox
    Friend WithEvents utstyrGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxStorrelse As System.Windows.Forms.ComboBox
End Class
