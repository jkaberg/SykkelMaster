Public Class statistikk
    Private payload As DataTable
    ' Antal sykkler per sykkeltype
    ' Mest populære sykklene
    ' Hvor mange sykkler per "lagerplass"
    ' Hvilke sykkler blir mest ødelagd

    Private Sub cbxStats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStats.SelectedIndexChanged
        Dim sql As String
        ' Rens ut nuvarende informasjon som evt er i grafen
        graf.Series(0).Points.Clear()
        graf.DataSource = ""

        Select Case cbxStats.SelectedIndex
            Case 0
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 1
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 2
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case 3
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
            Case Else
                sql = "SELECT sykkeltype.sykkeltype AS navn, count(*) AS num " &
                      "FROM sykkel " &
                      "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                      "GROUP BY sykkeltype.sykkeltype;"
        End Select

        payload = db.query(sql)
        graf.DataSource = payload

        graf.Series("Series1").XValueMember = "navn"
        graf.Series("Series1").YValueMembers = "num"
    End Sub
End Class