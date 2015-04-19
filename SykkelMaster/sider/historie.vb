Public Class historie
    Private payload As DataTable
    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avtaleInnehold()
    End Sub

    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles oversiktGrid.CellClick
        With tilbehorGrid
            .DataSource = daoInnlevering.hentTilbehor(daoDelt.finnDGWVerdi(oversiktGrid, "ordre_nr"))
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("utstyrstype").HeaderText = "Type"
            .Columns("storrelse").HeaderText = "Størrelse"
            .Columns("id").HeaderText = "Utstyrets id"
        End With
    End Sub

    Public Sub avtaleInnehold(Optional ByVal id As Integer = Nothing)
        payload = daoHistorie.hentAvtaleHistorie(id)

        With Me.oversiktGrid
            .DataSource = payload
            'Endrer navn på headere for å gi en bedre visuell opplevelse
            .Columns("ordre_nr").HeaderText = "Ordrenummer"
            .Columns("frist").HeaderText = "Frist"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("rammenr").HeaderText = "Rammenummer"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("s_l_status").HeaderText = "Status"
            .Columns("id").Visible = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
End Class