Public Class utleieOversikt
    Private total_pris As Double
    Private fra As Date = utleie.fraTid.Value
    Private til As Date = utleie.tilTid.Value
    Private total_leie_tid As Integer
    Public Sub lastInn(ByVal sykkler As DataTable,
                       ByVal utstyr As DataTable,
                       ByVal kunde As clsPerson)
        Dim pris As Double
        Dim dags_leie As Boolean = utleie.rbDag.Checked


        With lbOversikt
            .Items.Add("Kunde:")
            .Items.Add(vbTab & kunde.pFnavn & " " & kunde.pEnavn)
            .Items.Add(vbTab & kunde.pAdresse)
            .Items.Add(vbTab & kunde.pPostnr & ", " & kunde.pSted)

            If Not sykkler.Rows.Count = 0 Then
                .Items.Add("Sykler:")
                .Items.Add("---------------------")
                For Each rad As DataRow In sykkler.Rows
                    'regn ut time/dag pris
                    If dags_leie Then
                        pris = regnPris.dag(rad.Item("innkjopspris"))
                    Else
                        pris = regnPris.time(rad.Item("innkjopspris"))
                    End If

                    'lagre totale prisen
                    total_pris += pris

                    .Items.Add(vbTab & "Rammenr: " & rad.Item("rammenr"))
                    .Items.Add(vbTab & "Sykeltype: " & rad.Item("sykkelnavn"))
                    .Items.Add(vbTab & "Leiepris: " & pris & "kr")
                Next
            End If

            If Not utstyr.Rows.Count = 0 Then
                .Items.Add("Utstyr:")
                .Items.Add("---------------------")
                For Each rad As DataRow In utstyr.Rows
                    .Items.Add(vbTab & "Navn: " & rad.Item("navn"))
                    .Items.Add(vbTab & "Størrelse: " & rad.Item("storrelse"))
                Next
            End If
            .Items.Add("Leieperiode:")
            .Items.Add("---------------------")
            .Items.Add("Start: " & fra)
            .Items.Add("Stop: " & til)

            'regn ut leie tid
            If dags_leie Then
                total_leie_tid = DateDiff(DateInterval.Day, fra, til)
                .Items.Add("Totalt dager: " & total_leie_tid)
            Else
                total_leie_tid = DateDiff(DateInterval.Day, fra, til)
                .Items.Add("Totalt timer: " & total_leie_tid)
            End If

            'gange med antalet timer/dager å total pris, men ikke hvis at d DateDiff returnerer 0
            If Not total_leie_tid = 0 Then
                total_pris *= total_leie_tid
            End If

            .Items.Add("---------------------")
            .Items.Add("Total pris: " & total_pris & "kr")
        End With
    End Sub

    Private Sub opprettAvtale()

    End Sub

    Private Sub utleieOversikt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        utleie.tomKundevogn()
    End Sub
End Class