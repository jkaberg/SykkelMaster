Public Class utstyrEdit
    Private utstyr As clsSykkelUtstyr

    Private Sub sykkelutstyr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        With Me.utstyrGridView
            .DataSource = daoSykkelUtstyr.hentUtstyr
            .Columns("innkjopspris").Visible = False
            .Columns("innkjopt").Visible = False
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("utstyrstype").HeaderText = "Utstyrstype"
            .Columns("storrelse").HeaderText = "Størrelse"
            .Columns("s_u_status").HeaderText = "Status"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

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

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksene
       With Me.utstyrGridView
            cbxTilhorer.Text = daoDelt.finnDGWVerdi(utstyrGridView, "navn")
            cbxPosisjon.Text = daoDelt.finnDGWVerdi(utstyrGridView, "posisjon")
            cbxType.Text = daoDelt.finnDGWVerdi(utstyrGridView, "utstyrstype")
            cbxStatus.Text = daoDelt.finnDGWVerdi(utstyrGridView, "s_u_status")
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
        txtInnkjopspris.Text = ""
        cbxStorrelse.SelectedIndex = -1
        dtpInnkjop.Value = DateTime.Now

        utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkelutstyr i databasen
        Try
            Dim utstyr As New clsSykkelUtstyr(cbxTilhorer.SelectedValue,
                                                cbxPosisjon.SelectedValue,
                                                cbxType.SelectedValue,
                                                txtInnkjopspris.Text,
                                                dtpInnkjop.Value,
                                                cbxStatus.Text,
                                                cbxStorrelse.Text)
            daoSykkelUtstyr.leggTilUtstyr(utstyr)
            MsgBox(utstyr_navn() & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr
            oppdaterTxtbox()
        End Try

    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere sykkelutstyr i databasen
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & utstyr_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim utstyr As New clsSykkelUtstyr(daoDelt.finnDGWVerdi(utstyrGridView, "id"),
                                                cbxTilhorer.SelectedValue,
                                                cbxPosisjon.SelectedValue,
                                                cbxType.SelectedValue,
                                                txtInnkjopspris.Text,
                                                dtpInnkjop.Value,
                                                cbxStatus.Text,
                                                cbxStorrelse.Text)

                    daoSykkelUtstyr.oppdaterUtstyr(utstyr)
                    MsgBox(utstyr_navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr
                    oppdaterTxtbox()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkelutstyr i databasen
        Select Case MsgBox("Er du sikker på at du vil fjerne " & utstyr_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim utstyr As New clsSykkelUtstyr(daoDelt.finnDGWVerdi(utstyrGridView, "id"))

                    daoSykkelUtstyr.fjernUtstyr(utstyr)
                    MsgBox(utstyr_navn() & " er fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr
                End Try
        End Select
    End Sub

    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr(sok:=txtSok.Text)
    End Sub

    Private Sub cbxLokasjon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLokasjon.SelectedIndexChanged
        utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr(posisjon:=cbxLokasjon.Text)
    End Sub

    Private Sub cbxSokStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSokStatus.SelectedIndexChanged
        utstyrGridView.DataSource = daoSykkelUtstyr.hentUtstyr(status:=cbxSokStatus.Text)
    End Sub

    Private Sub btnSykkeltype_Click(sender As Object, e As EventArgs) Handles btnSykkeltype.Click
        utstyrstype.Show()
    End Sub
    Private Function utstyr_navn() As String
        Return cbxType.Text
    End Function

End Class