Public Class utstyrEdit
    Private utstyr As clsSykkelUtstyr

    Private Sub sykkelutstyr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()

        'Laster inn data til comboBox'ene
        With cbxTilhorer
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        'Gjør at comboBox'en er tom når programmet starter
        cbxTilhorer.SelectedIndex = -1

        With cbxPosisjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        cbxPosisjon.SelectedIndex = -1

        With cbxLokasjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        cbxLokasjon.SelectedIndex = -1

        With cbxType
            .DisplayMember = "utstyrstype"
            .ValueMember = "id"
            .DataSource = daoDelt.hentUtstyrsType
        End With
        cbxType.SelectedIndex = -1

    End Sub

    Private Sub utstyrGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles utstyrGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing,
                                 Optional ByVal posisjon As String = Nothing,
                                 Optional ByVal status As String = Nothing)

        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr(sok, posisjon, status)

        With Me.utstyrGridView
            .Columns("innkjopspris").Visible = False
            .Columns("innkjopt").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("id").HeaderText = "Id"
            .Columns("utstyrstype").HeaderText = "Utstyrstype"
            .Columns("storrelse").HeaderText = "Størrelse"
            .Columns("s_u_status").HeaderText = "Status"
            .Columns("pris").HeaderText = "Pris"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.utstyrGridView
            cbxTilhorer.Text = daoDelt.finnDGWVerdi(utstyrGridView, "navn")
            cbxPosisjon.Text = daoDelt.finnDGWVerdi(utstyrGridView, "posisjon")
            cbxType.Text = daoDelt.finnDGWVerdi(utstyrGridView, "utstyrstype")
            txtRammenr.Text = daoDelt.finnDGWVerdi(utstyrGridView, "id")
            cbxStatus.Text = daoDelt.finnDGWVerdi(utstyrGridView, "s_u_status")
            txtPris.Text = daoDelt.finnDGWVerdi(utstyrGridView, "pris")
            txtInnkjopspris.Text = daoDelt.finnDGWVerdi(utstyrGridView, "innkjopspris")
            dtpInnkjop.Text = daoDelt.finnDGWVerdi(utstyrGridView, "innkjopt")
            cbxStorrelse.Text = daoDelt.finnDGWVerdi(utstyrGridView, "storrelse")
        End With
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        'Nulstiller alle textBox'ene og comboBox'ene
        cbxTilhorer.SelectedIndex = -1
        cbxPosisjon.SelectedIndex = -1
        cbxType.SelectedIndex = -1
        cbxStatus.SelectedIndex = -1
        txtRammenr.Text = ""
        txtPris.Text = ""
        txtInnkjopspris.Text = ""
        cbxStorrelse.SelectedIndex = -1
        dtpInnkjop.Value = DateTime.Now
        oppdaterGridView()
    End Sub


    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        oppdaterGridView(sok:=txtSok.Text)
    End Sub

    Private Sub cbxLokasjon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLokasjon.SelectedIndexChanged
        oppdaterGridView(posisjon:=cbxLokasjon.Text)
    End Sub

    Private Sub cbxSokStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSokStatus.SelectedIndexChanged
        oppdaterGridView(status:=cbxSokStatus.Text)
    End Sub

    Private Sub btnSykkeltype_Click(sender As Object, e As EventArgs) Handles btnSykkeltype.Click
        utstyrstype.Show()
    End Sub

End Class