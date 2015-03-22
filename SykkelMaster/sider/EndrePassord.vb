Public Class EndrePassord

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim payload As New DataTable
        Dim sql As String = "SELECT mail from person WHERE mail='" & eposttxt.Text & "'"

        payload = db.query(sql)

        If nyttPassordtxt.Text.Length > 30 Or nåværendePassordtxt.Text.Length > 30 Then
            MsgBox("Passord må inneholde mindre enn 30 tegn")
        Else
            If payload.Rows.Count = 1 Then
                endrePassord()
                MsgBox("Passordet er endret til: " & nyttPassordtxt.Text)

                eposttxt.Text = ""
                nåværendePassordtxt.Text = ""
                nyttPassordtxt.Text = ""

            Else
                MsgBox("Finner ikke: " & eposttxt.Text & " i databasen.")
            End If
        End If
        
    End Sub


    Private Sub endrePassord()

        Dim payload As New DataTable
        Dim sql As String = "UPDATE ansatt " &
                            "JOIN person ON ansatt.person_id = person.id " &
                            "SET ansatt.passord = '" & nyttPassordtxt.Text & "' " &
                            "WHERE person.mail = '" & eposttxt.Text & "'"
        payload = db.query(sql)
    End Sub

    Private Function sjekkPassord()




        'Trenger SQL spørring som joiner ansatt & person og sjekker at epost er lik epostTxt, og at nåværendePassord.text matcher passordet til den eposten i databasen. HOW???
        Return False
    End Function
End Class