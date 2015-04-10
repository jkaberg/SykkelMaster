Public Class hoved

    Public lokasjoner As DataTable

    Private Sub Vis_Kunder(sender As Object, e As EventArgs) Handles btnVis_Kunder.Click
        kunder.Show()
    End Sub

    Private Sub Vis_Utleie(sender As Object, e As EventArgs) Handles btnVis_Utleie.Click
        utleie.Show()
    End Sub

    Private Sub Vis_Lokasjoner(sender As Object, e As EventArgs) Handles btnVis_Lokasjoner.Click
        lokasjon.Show()
    End Sub

    Private Sub Vis_Sykler(sender As Object, e As EventArgs) Handles btnVis_Sykler.Click
        sykkelEdit.Show()
    End Sub

    Private Sub Vis_Brukere(sender As Object, e As EventArgs) Handles btnVis_Brukere.Click
        bruker.Show()
    End Sub

    Private Sub Vis_Innelvering(sender As Object, e As EventArgs) Handles btnVis_innlevering.Click
        innlevering.Show()
    End Sub

    Private Sub Vis_Statistikk(sender As Object, e As EventArgs) Handles btnStatistikk.Click
        statistikk.Show()
    End Sub

    Private Sub hoved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vis navnet på den ansatte som logger inn i Label1 (eksempel: Velkommen, Joel Kåberg)
        Label1.Text += start.bruker.pFnavn & " " & start.bruker.pEnavn

        'Hent ut å vis frem alle lokasjoner (virksomheter) i ComboBox1
        lokasjoner = New DataTable
        lokasjoner = db.query("SELECT * FROM virksomhet")

        With cbxPlassering
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = lokasjoner
        End With

        'Dim table As DataTable = DirectCast(Me.cbxPlassering.DataSource, DataTable)
        'For i As Integer = 0 To payload.Rows.Count - 1
        '    If payload.Rows(i)(cbxPlassering.DisplayMember).ToString() = table.Rows(gridIndex).Cells("stilling").Value Then
        '        Me.cbxPlassering.SelectedIndex = i
        '    End If
        'Next yo

        ' Rettighetsnivå (integer):
        ' Daglig leder: 10
        ' Selger: 5
        ' Lagermedarbeider: 3
        ' Sjekk hvilke tillatelser innloggetburker har ved å enable knapper
        Select Case start.bruker.pTilgangsniva
            Case Is >= 3
                btnVis_Kunder.Enabled = True
                btnVis_Utleie.Enabled = True
                btnVis_Lokasjoner.Enabled = True
                btnVis_Brukere.Enabled = True
            Case Is >= 2
                btnVis_Kunder.Enabled = True
                btnVis_Utleie.Enabled = True

        End Select
    End Sub

    Private Sub Bytt_Passord(sender As Object, e As EventArgs) Handles btnBytt_Passord.Click
        EndrePassord.Show()
    End Sub

    Private Sub Logg_ut(sender As Object, e As EventArgs) Handles btnLogg_ut.Click
        Me.Close()
        start.bruker = Nothing
        start.Show()
    End Sub
End Class