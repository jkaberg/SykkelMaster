Public Class EndrePassord
    Private Sub Bytt_Passord(sender As Object, e As EventArgs) Handles btnBytt_Passord.Click
        'Knappen sjekker først input om tekstfeltene er under 30 karakterer
        'Så kjøres sjekkpassord om det finnes i databasen
        'Deretter kjører prosedyren endrepassord og endrer passordet. 
        If sjekkPassord(start.bruker.pEpost, nåværendePassordtxt.Text) = True Then
            If nyttPassordtxt.Text.Length > 30 Or nåværendePassordtxt.Text.Length > 30 Then
                MsgBox("Passord må inneholde mindre enn 30 tegn")
            Else
                endrePassord(nyttPassordtxt.Text)
                MsgBox("Passordet er endret til: " & nyttPassordtxt.Text)
                nåværendePassordtxt.Text = ""
                nyttPassordtxt.Text = ""
            End If
        Else
            MsgBox("E-post eller nåværende passord er feil, eller ikke funnet i databasen.")
        End If
    End Sub

    Private Sub endrePassord(ByVal passord As String)
        'Prosedyre som setter ny verdi i databasen for ansatt.passord der eposten er lik innlogget epost.
        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & passord & "' " &
                            "WHERE person.mail = '" & start.bruker.pEpost & "'"
        db.query(sql)
    End Sub

    Private Function sjekkPassord(ByVal mail As String, ByVal current As String)
        'Funksjon som sjekker at epost tilsvarer passord, slik at dersom flere har samme passord vil det alltid høre til kun én epost.
        Dim payload As New DataTable
        Dim sql As String = "SELECT person.mail, ansatt.passord " &
                            "FROM ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "WHERE mail = '" & mail & "' " &
                            "AND passord = '" & current & "'"
        payload = db.query(sql)

        If payload.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class