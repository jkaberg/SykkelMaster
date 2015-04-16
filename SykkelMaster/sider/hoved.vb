Public Class hoved
    Private Sub Vis_Kunder(sender As Object, e As EventArgs) Handles btnVis_Kunder.Click
        person.Show()
    End Sub

    Private Sub Vis_Utleie(sender As Object, e As EventArgs) Handles btnVis_Utleie.Click
        utleie.Show()
    End Sub

    Private Sub Vis_Lokasjoner(sender As Object, e As EventArgs) Handles btnVis_Lokasjoner.Click
        lokasjoner.Show()
    End Sub

    Private Sub Vis_Sykler(sender As Object, e As EventArgs) Handles btnVis_Sykler.Click
        sykkelEdit.Show()
    End Sub

    Private Sub Vis_Brukere(sender As Object, e As EventArgs) Handles btnVis_Brukere.Click
        ansatte.Show()
    End Sub

    Private Sub Vis_Innelvering(sender As Object, e As EventArgs) Handles btnVis_innlevering.Click
        innlevering.Show()
    End Sub

    Private Sub Vis_Statistikk(sender As Object, e As EventArgs) Handles btnStatistikk.Click
        statistikk.Show()
    End Sub

    Private Sub Bytt_Passord(sender As Object, e As EventArgs) Handles btnBytt_Passord.Click
        EndrePassord.Show()
    End Sub

    Private Sub Logg_ut(sender As Object, e As EventArgs) Handles btnLogg_ut.Click
        Me.Close()
        start.bruker = Nothing
        start.Show()
    End Sub

    Private Sub hoved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vis navnet på den ansatte som logger inn i Label1 (eksempel: Velkommen, Joel Kåberg)
        lblNavn.Text += start.bruker.pFnavn & " " & start.bruker.pEnavn

        With cbxPlassering
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With

        ' Rettighetsnivå (integer):
        ' Daglig leder: 10
        ' Selger: 5
        ' Lagermedarbeider: 3
        ' Sjekk hvilke tillatelser innloggetburker har ved å enable groupboxer
        Select Case start.bruker.pStilling
            Case Is = 1
                grpVirksomhet.Enabled = True
                grpOrdre.Enabled = True
            Case Is = 2
                grpOrdre.Enabled = True
        End Select
    End Sub

    Private Sub btnUtstyr_Click(sender As Object, e As EventArgs) Handles btnUtstyr.Click
        utstyrEdit.Show()
    End Sub
End Class