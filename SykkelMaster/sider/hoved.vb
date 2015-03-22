Public Class hoved

    Public lokasjoner As DataTable

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
        'Next

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EndrePassord.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        start.Show()
    End Sub
End Class