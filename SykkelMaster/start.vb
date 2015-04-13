Public Class start
    Public bruker As clsAnsatt

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEpost.Text = "ddd@ddd"
        txtPassord.Text = "dddd"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            bruker = daoStart.sjekkLogin(txtEpost.Text, txtPassord.Text)
            Me.Hide()
            hoved.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Sendnyttpassord_click(sender As Object, e As EventArgs) Handles SendNyttPassord.Click
        Dim passord As String = verktoy.tilfeldigStreng()

        If verktoy.validerEpost(byttEpost.Text) Then
            If daoDelt.sjekkMailEksisterer(byttEpost.Text) Then
                If daoStart.oppdaterPassord(passord, byttEpost.Text) Then
                    verktoy.sendMail(byttEpost.Text, "Nytt Passord", "Her er ditt nye passord: " & passord)
                    MsgBox("Ditt nye passord er sendt til deg på mail.", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("E-post adressen eksisterer ikke.", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("E-post adressen har ikke en korrekt formatering.", MsgBoxStyle.Critical)
        End If
        byttEpost.Text = ""
    End Sub
End Class
