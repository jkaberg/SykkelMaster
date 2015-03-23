Public Class EndrePassord

<<<<<<< HEAD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sjekkPassord(start.bruker.pEpost, nåværendePassordtxt.Text) Then
=======
    Private Sub Bytt_Passord(sender As Object, e As EventArgs) Handles btnBytt_Passord.Click


        If sjekkPassord(eposttxt.Text, nåværendePassordtxt.Text) = True Then
>>>>>>> origin/master
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
        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & passord & "' " &
                            "WHERE person.mail = '" & start.bruker.pEpost & "'"
        db.query(sql)
    End Sub

    Private Function sjekkPassord(ByVal mail As String, ByVal current As String)
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