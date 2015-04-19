Public Class utleieOversikt
    Public Sub lastInn(ByVal sykkler As DataTable,
                       ByVal utstyr As DataTable,
                       ByVal kunde As clsPerson)

        With lbOversikt
            .Items.Add("Kunde:")
            .Items.Add(vbTab & kunde.pFnavn & " " & kunde.pEnavn)
            .Items.Add(vbTab & kunde.pAdresse)
            .Items.Add(vbTab & kunde.pPostnr & ", " & kunde.pSted)

            If Not sykkler.Rows.Count = 0 Then
                .Items.Add("Sykler:")
                .Items.Add("---------------------")
                For Each rad As DataRow In sykkler.Rows
                    .Items.Add(vbTab & "Rammenr: " & rad.Item("rammenr"))
                    .Items.Add(vbTab & "Sykeltype: " & rad.Item("sykkelnavn"))
                    .Items.Add(vbTab & "Leiepris")
                    .Items.Add("")
                Next
            End If

            If Not utstyr.Rows.Count = 0 Then
                .Items.Add("Utstyr:")
                .Items.Add("---------------------")
                For Each rad As DataRow In utstyr.Rows
                    .Items.Add(vbTab & rad.Item("navn"))
                    .Items.Add("")
                Next
            End If
            .Items.Add("Leieperiode:")
            .Items.Add("---------------------")
            .Items.Add("Start: ")
            .Items.Add("Stop: ")
            .Items.Add("---------------------")
            .Items.Add("Total pris: ")
        End With
    End Sub

    Private Sub utleieOversikt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        utleie.tomKundevogn()
    End Sub

End Class