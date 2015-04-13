Public Class clsPerson
    Private fornavn, etternavn, epost, gate, sted As String ' Ola | Nordmann | ola.nordmann@epost.com | Olav Tryggvasonsgate 10 | Trondheim
    Private id, postnr, telefonnr As Integer ' 1 | 7070 | 12345678

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As Integer,
            ByVal tnr As Integer,
            ByVal adresse As String,
            ByVal epost As String)

        Me.pID = id
        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pPostnr = pnr
        Me.pTlfnr = tnr
        Me.pAdresse = adresse
        Me.pEpost = epost
    End Sub

    'legg til
    Sub New(ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer,
            ByVal tnr As Integer, ByVal adresse As String, ByVal epost As String)

        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pPostnr = pnr
        Me.pTlfnr = tnr
        Me.pAdresse = adresse
        Me.pEpost = epost
    End Sub

    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String, ByVal epost As String)
        Me.pID = id
        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pEpost = epost
    End Sub

    Public Property pID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property pFnavn() As String
        Get
            Return fornavn
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Fornavn må være minst 3 tegn langt.")
            Else
                fornavn = value
            End If
        End Set
    End Property

    Public Property pEnavn() As String
        Get
            Return etternavn
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New ArgumentException("Etternavn må være minst 3 tegn langt.")
            Else
                etternavn = value
            End If
        End Set
    End Property

    Public Property pPostnr() As Integer
        Get
            Return postnr
        End Get
        Set(ByVal value As Integer)
            If value.ToString.Length <> 4 Then
                Throw New Exception("Post nummeret kan kun bestå av 4 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Post nummeret må bestå av kun tall.")
            Else
                postnr = value
            End If
        End Set
    End Property

    Public Property pTlfnr() As Integer
        Get
            Return telefonnr
        End Get
        Set(ByVal value As Integer)
            If Not value.ToString.Length = 8 Then
                Throw New Exception("Telefon nummeret må bestå av 8 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Telefon nummeret kan kun bestå av tall.")
            Else
                telefonnr = value
            End If
        End Set
    End Property

    Public Property pAdresse() As String
        Get
            Return gate
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Gate må være minst 3 tegn langt.")
            Else
                gate = value
            End If
        End Set
    End Property

    Public Property pEpost() As String
        Get
            Return epost
        End Get
        Set(ByVal value As String)
            Dim regx As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
            Dim ep As System.Text.RegularExpressions.Match = regx.Match(value)

            If Not ep.Success Then
                Throw New Exception("Du må angi en korrekt e-post adresse.")
            Else
                epost = value
            End If
        End Set
    End Property
End Class
