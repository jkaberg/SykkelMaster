Public Class historie
    Private payload As DataTable
    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avtaleInnehold()
    End Sub

    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles oversiktGrid.CellClick
        With tilbehorGrid
            .DataSource = daoInnlevering.hentTilbehor(Me.oversiktGrid.Rows(Me.oversiktGrid.CurrentRow.Index).Cells("ordre_nr").Value)
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("navn").HeaderText = "Navn"
        End With
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

    Public Sub avtaleInnehold(Optional ByVal id As Integer = Nothing)
        payload = daoInnlevering.hentAvtaleHistorie(id)

        With Me.oversiktGrid
            .DataSource = payload
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