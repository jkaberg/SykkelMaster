Public Class innlevering
    Private payload As DataTable
    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avtaleInnehold()

        With lokasjoner
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
    End Sub

    Private Sub txtSokKunde_TextChanged(sender As Object, e As EventArgs) Handles txtSokKunde.TextChanged
        If txtSokKunde.Text = "" Then
            avtaleInnehold() 'Viser alle leie avtaler om man ikke søkt etter kunde
        Else
            sokKunde(txtSokKunde.Text)
        End If
    End Sub

    Private Sub cbxKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxKunde.SelectedIndexChanged
        Dim kunde_id As String = cbxKunde.SelectedValue

        If kunde_id > 0 Then
            With cbxLeieAvtaler
                .DisplayMember = "ordre_nr"
                .ValueMember = "ordre_nr"
                .DataSource = daoInnlevering.hentLeieAvtaler(kunde_id)
            End With

            txtTelefon.Text = daoDelt.finnTlfNummer(kunde_id)
        End If
    End Sub

    Private Sub Avslutt_leie(sender As Object, e As EventArgs) Handles AvsluttLeie.Click
        Dim ordre_nr As Integer = Me.oversiktGrid.Rows(Me.oversiktGrid.CurrentRow.Index).Cells("ordre_nr").Value

        If lokasjoner.SelectedValue <> 0 Then
            Try
                daoInnlevering.avsluttLeieAvtale(ordre_nr,
                                                 lokasjoner.SelectedValue)

                MsgBox(ordre_nr & " er levert inn!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                avtaleInnehold()
            End Try
        Else
            MsgBox("Du må velge en plass å levere inn ordren på.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles oversiktGrid.CellClick
        With tilbehorGrid
            .DataSource = daoInnlevering.hentTilbehor(Me.oversiktGrid.Rows(Me.oversiktGrid.CurrentRow.Index).Cells("ordre_nr").Value)
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("navn").HeaderText = "Navn"
        End With
    End Sub

    Private Sub cbxLeieAvtaler_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxLeieAvtaler.SelectedIndexChanged
        avtaleInnehold(cbxLeieAvtaler.SelectedValue)
    End Sub

    Private Sub sokKunde(ByVal sok As String)
        payload = daoDelt.finnKunde(sok)

        payload.Columns.Add("kunde_navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count > 0 Then
            With cbxKunde
                .DisplayMember = "kunde_navn"
                .ValueMember = "id"
                .DataSource = payload
            End With
        Else
            Me.cbxKunde.DataSource = Nothing
            Me.oversiktGrid.DataSource = Nothing
            Me.tilbehorGrid.DataSource = Nothing
        End If
    End Sub

    Private Sub avtaleInnehold(Optional ByVal id As Integer = Nothing)
        If id = Nothing Then
            cbxKunde.DataSource = Nothing
            cbxLeieAvtaler.DataSource = Nothing
            txtSokKunde.Text = ""
        End If

        With Me.oversiktGrid
            .DataSource = daoInnlevering.hentAvtaleInnehold(id)
            'Endrer navn på headere for å gi en bedre visuell opplevelse
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("frist").HeaderText = "Frist"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("rammenr").HeaderText = "Rammenummer"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("id").Visible = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub Rediger_kunde_Click(sender As Object, e As EventArgs) Handles Rediger_kunde.Click
        person.Show()
        person.oppdaterGridView(id:=cbxKunde.SelectedValue)
    End Sub

    Private Sub cbxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStatus.SelectedIndexChanged
        Select Case cbxStatus.Text
            Case "Leid ut"
                avtaleInnehold()
            Case "Tidsfrist gått ut"
                fristGattUt("<")
            Case "Tidsfrist ikke gått ut"
                fristGattUt(">=")
        End Select
    End Sub

    Public Sub fristGattUt(ByVal sok As String)
        'Får opp de som ikke har levert inn sykkelen innen fristen
        With Me.oversiktGrid
            .DataSource = daoInnlevering.hentLeieFrister(sok)
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("frist").HeaderText = "Frist"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("rammenr").HeaderText = "Rammenummer"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("id").Visible = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
End Class