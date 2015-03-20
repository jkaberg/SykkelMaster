Public Class hoved

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kunder.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        utleie.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lokasjon.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sykkelEdit.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bruker.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        innlevering.Show()
    End Sub

    Private Sub hoved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vis navnet på den ansatte som logger inn i Label1 (eksempel: Velkommen, Joel Kåberg)
        Label1.Text += start.bruker.pFnavn & " " & start.bruker.pEnavn

        'Hent ut å vis frem alle lokasjoner (virksomheter) i ComboBox1
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM virksomhet")

        ComboBox1.DataSource = payload
        'Vi velger ut navn kolonnen som den vi har lyst til å vis frem
        ComboBox1.DisplayMember = "navn"

        ' Rettighetsnivå (integer):
        ' Daglig leder: 10
        ' Selger: 5
        ' Lagermedarbeider: 3
        ' Sjekk hvilke tillatelser innloggetburker har ved å enable knapper
        Select Case start.bruker.pStilling
            Case Is >= 3
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Button5.Enabled = True
            Case Is >= 2
                Button1.Enabled = True
                Button2.Enabled = True

        End Select
    End Sub
End Class