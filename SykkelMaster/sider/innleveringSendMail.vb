Public Class innleveringSendMail
    Public mailAdresse As String

    Private Sub innleveringSendMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If daoDelt.sjekkMailEksisterer(mailAdresse) Then
            txtMottaker.Text = mailAdresse
        Else
            txtMottaker.Enabled = True
        End If
    End Sub


    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click

        Dim emne As String = txtEmne.Text
        Dim brodtekst As String = rtbBrodtekst.Text


        If emne <> "" And brodtekst <> "" Then
            verktoy.sendMail(mailAdresse, txtEmne.Text, rtbBrodtekst.Text)
            MsgBox("Mailen er sendt til " & mailAdresse)
        Else
            MsgBox("Du må fylle ut emne og brødtekst", MsgBoxStyle.Critical)
        End If
    End Sub
End Class