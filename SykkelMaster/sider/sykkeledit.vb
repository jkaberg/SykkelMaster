Public Class sykkelEdit
    Private sykkel As clsSykkel

    Private Sub sykkelEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SykkelGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing,
                                 Optional ByVal posisjon As String = Nothing,
                                 Optional ByVal status As String = Nothing)

        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        SykkelGridView.DataSource = daoSykkel.hentSykkler(sok, posisjon, status)

        With Me.SykkelGridView
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("s_status").HeaderText = "Status"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("avviksmelding").HeaderText = "Avviksmelding"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.SykkelGridView
            cbxTilhorer.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("navn").Value
            cbxPosisjon.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("posisjon").Value
            cbxType.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("sykkeltype").Value
            txtRammenr.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("rammenr").Value
            cbxHjul.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("hjulstr").Value
            cbxRamme.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("rammestr").Value
            cbxStatus.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("s_status").Value
            txtAvvik.Text = .Rows(Me.SykkelGridView.CurrentRow.Index).Cells("avviksmelding").Value
        End With
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        'Nulstiller alle textBox'ene og comboBox'ene
        cbxTilhorer.SelectedIndex = -1
        cbxPosisjon.SelectedIndex = -1
        cbxType.SelectedIndex = -1
        cbxHjul.SelectedIndex = -1
        cbxRamme.SelectedIndex = -1
        cbxStatus.SelectedIndex = -1
        txtRammenr.Text = ""
        txtAvvik.Text = ""
        oppdaterGridView()
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkel i databasen
        Try
            Dim sykkel As New clsSykkel(txtRammenr.Text,
                                        txtAvvik.Text,
                                        cbxType.SelectedValue,
                                        cbxHjul.Text,
                                        cbxRamme.Text,
                                        cbxStatus.Text,
                                        cbxPosisjon.SelectedValue,
                                        cbxTilhorer.SelectedValue)

            daoSykkel.leggTilSykkel(sykkel)
            MsgBox(sykkel_navn() & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
            oppdaterTxtbox()
        End Try

    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere sykkel i databasen
        Dim sykkel As New clsSykkel(txtRammenr.Text,
                                                txtAvvik.Text,
                                                cbxType.SelectedValue,
                                                cbxHjul.Text, cbxRamme.Text,
                                                cbxStatus.Text,
                                                cbxPosisjon.SelectedValue,
                                                cbxTilhorer.SelectedValue)
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & sykkel_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try


                    daoSykkel.oppdaterSykkel(sykkel)
                    MsgBox(sykkel_navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                    oppdaterTxtbox()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkel i databasen
        Select Case MsgBox("Er du sikker på at du vil fjerne " & sykkel_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim sykkel As New clsSykkel(Me.SykkelGridView.Rows(Me.SykkelGridView.CurrentRow.Index).Cells("id").Value)

                    daoSykkel.fjernSykkel(sykkel)
                    MsgBox(sykkel_navn() & " er fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
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
        sykkeltype.Show()
    End Sub

    Private Sub cbxType_Click(sender As Object, e As EventArgs) Handles cbxType.Click
        With cbxType
            .DisplayMember = "sykkeltype"
            .ValueMember = "id"
            .DataSource = daoDelt.hentSykkelType
        End With
        cbxType.SelectedIndex = -1
    End Sub

    Private Function sykkel_navn() As String
        Return txtRammenr.Text & " " & cbxType.SelectedText
    End Function
End Class