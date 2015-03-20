Public Class util
    Function validerEpost(ByVal epost As String) As Boolean
        Dim regx As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim ep As System.Text.RegularExpressions.Match = regx.Match(epost)
        Return ep.Success
    End Function


    Function validerNummer(ByVal nummer As String, ByVal lengde As Integer) As Boolean
        If nummer.Length = lengde And IsNumeric(CInt(nummer)) Then
            Return True
        End If
        Return False
    End Function


    Function validerStreng(ByVal Streng As String) As Boolean
        For i = 0 To Streng.Length - 1
            If Not Char.IsLetter(Streng.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function




    Function RandomPassordGenerator() As String 'Funksjon som skal returnere et tilfeldig passord som skal brukes til "glemt passord"

        'Lager variabel for alle mulige tegn som kan brukes i tilfeldig passord
        Dim tegnsett As String = "0123456789abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        'Teller som brukes til å gå igjennom while løkken for å generere 8 tall.
        Dim passord_teller = 0
        'Lager variabel passord som en tom streng, før den blir lagt til i while løkken som genererer tilfeldige tall.
        Dim passord As String = ""

        'Lager variabel random som ny random funksjon 
        Dim random As New Random

        'Stringposisjon holder styr på hvor random befinner seg
        Dim stringposisjon = ""

        'Løkken som genererer tall helt til telleren har 8 characters, og deretter legger til characters i Passord variabelen.
        While passord_teller <= 8
            stringposisjon = random.Next(8, tegnsett.Length)

            passord &= tegnsett(stringposisjon)
            passord_teller = passord_teller + 1

        End While
        'Returnerer det nye genererte tilfeldige passord
        Return passord

    End Function


End Class
