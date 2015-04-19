Public Class utleieOversikt
    Public Sub lastInn(ByVal sykkler As DataTable,
                              ByVal utstyr As DataTable)

        With lbOversikt
            .Items.Add("PERSON")
            .Items.Add("---------------------")
            .Items.Add("Sykler:")
            .Items.Add("---------------------")
            For Each rad As DataRow In sykkler.Rows
                .Items.Add(rad.Item("rammenr") & " " &
                           rad.Item("sykkelnavn"))

            Next
            .Items.Add("---------------------")
            .Items.Add("Utstyr:")
            .Items.Add("---------------------")
            For Each rad As DataRow In utstyr.Rows
                .Items.Add(rad.Item("navn"))
            Next
        End With
    End Sub

    Private Sub utleieOversikt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        utleie.tomKundevogn()
    End Sub

End Class