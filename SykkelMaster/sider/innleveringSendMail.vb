Public Class innleveringSendMail
    Public mailAdresse As String
    
    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click

        Dim emne As String = txtEmne.Text
        Dim brodtekst As String = rtbBrodtekst.Text


        If emne <> "" And brodtekst <> "" Then
            verktoy.sendMail(mailAdresse, txtEmne.Text, rtbBrodtekst.Text)
            MsgBox("Mailen er sendt til " & mailAdresse)
        Else
            MsgBox("Du må fylle ut Emne & Brødtekst", MsgBoxStyle.Critical)
        End If




    End Sub
End Class