Imports SykkelMaster.db
Imports SykkelMaster.ansatt
Public Class start

    Private bruker As New ansatt

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sjekkLogin(TextBox1.Text, TextBox2.Text) Then
            hoved.Show()
            Me.Hide()
        Else
            MsgBox("Feil e-post eller brukernavn.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function sjekkLogin(ByVal epost As String, ByVal passord As String)
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM ansatt WHERE epost ='" & epost & "' AND passord ='" & passord & "'")

        Console.WriteLine(payload)

        If payload.Rows.Count = 1 Then
            Dim row As DataRow = payload.Rows(0)
            If row("epost") = epost And row("passord") = passord Then
                Dim bruker As New ansatt(row("id"), row("fornavn"), row("etternavn"), row("postnr"), row("telefonnr"), row("gate"), row("sted"), row("stilling"), row("provisjon"))
                Return True
            End If
        End If
        Return False
    End Function
End Class
