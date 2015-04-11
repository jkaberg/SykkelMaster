Public Class statistikk
    Private Sub statistikk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxStats.SelectedIndex = 0
    End Sub

    Private Sub cbxStats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStats.SelectedIndexChanged
        ' Rens ut nuvarende informasjon som evt er i grafen
        graf.Series(0).Points.Clear()
        graf.DataSource = ""

        graf.DataSource = daoStatistikk.hentStats(cbxStats.SelectedIndex)

        graf.Series("Series1").XValueMember = "navn"
        graf.Series("Series1").YValueMembers = "num"
    End Sub
End Class