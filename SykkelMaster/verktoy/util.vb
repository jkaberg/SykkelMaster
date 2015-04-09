Imports System.Net.Mail
Imports System.Configuration

Public Class util
    Public Shared Function validerEpost(ByVal epost As String) As Boolean
        Dim regx As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim ep As System.Text.RegularExpressions.Match = regx.Match(epost)
        Return ep.Success
    End Function


    Public Shared Function validerNummer(ByVal nummer As String, ByVal lengde As Integer) As Boolean
        If nummer.Length = lengde And IsNumeric(nummer) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Shared Function validerStreng(ByVal Streng As String) As Boolean
        If Streng = "" Then
            Return False
        Else
            For i = 0 To Streng.Length - 1
                If Not Char.IsLetter(Streng.Chars(i)) Then
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Public Shared Function validerRammenr(ByVal rammenr As String) As Boolean
       

    End Function


    Public Shared Function tilfeldigStreng() As String 'Funksjon som skal returnere et tilfeldig passord som skal brukes til "glemt passord"
        'Lager variabel random som ny random funksjon 
        Dim random As New Random
        'Lager variabel for alle mulige tegn som kan brukes i tilfeldig passord
        Dim tegnsett As String = "0123456789abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        'Lager variabel passord som en tom streng, før den blir lagt til i while løkken som genererer tilfeldige tall.
        Dim randString As String = ""
        'Stringposisjon holder styr på hvor random befinner seg
        Dim stringposisjon As Integer = 0

        'Løkken som genererer tall helt til telleren har 8 characters, og deretter legger til characters i Passord variabelen.
        For t As Integer = 0 To 7
            stringposisjon = random.Next(8, tegnsett.Length)
            randString &= tegnsett(stringposisjon)
        Next
        'Returnerer det nye genererte tilfeldige passord
        Return randString
    End Function

    Public Shared Function sendMail(ByVal mottaker As String, ByVal emne As String, ByVal hovedtekst As String)

        Dim epostmelding As New MailMessage()
        Try
            epostmelding.From = New MailAddress("Granlieirik3@gmail.com")
            epostmelding.To.Add(mottaker)
            epostmelding.Subject = emne
            epostmelding.Body = hovedtekst

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("granlieirik3@gmail.com", "eirik12345")

            smtp.Send(epostmelding)
            Return True

        Catch ex As Exception
            MsgBox("Noe gikk galt med sending av e-post: " & ex.Message)
        End Try
        Return False
    End Function


    Public Shared Function Finn_Poststed(sender As Object, e As EventArgs) As String
        Dim poststed_sql As New DataTable
        Dim post_sted As String = ""
        Dim postnr As String = ""
        poststed_sql = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & postnr & "'")
        'Oppdaterer poststedet når post nummer blir skrevet inn
        Return post_sted

    End Function

    Public Shared Function sjekkBrukerEksisterer(ByVal epost As String)
        Dim payload As New DataTable
        Dim sql As String = "SELECT COUNT(mail) FROM person WHERE mail = '" & epost & "'"
        payload = db.query(sql)

        If payload.Rows.Count > 0 And CInt(payload.Rows(0)(0)) >= 1 Then
            Return True
        End If
        Return False
    End Function


    

End Class
