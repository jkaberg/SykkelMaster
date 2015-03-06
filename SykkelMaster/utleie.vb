Public Class utleie


    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolTip1.SetToolTip(Me.Label5, "Du kan søk på navn eller telefonnr.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kunder.Show()
    End Sub
End Class