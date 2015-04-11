Public Class lokasjon
    Private navn, mail, adresse As String
    Private id, telefon, post_nr As Integer

    Sub New(ByVal id As Integer, ByVal navn As String, ByVal mail As String, ByVal adresse As String, ByVal telefon As Integer, ByVal post_nr As String)
        Me.pID = id
        Me.pNavn = navn
        Me.pMail = mail
        Me.pAdresse = adresse
        Me.pTlfnr = telefon
        Me.pPostnr = post_nr
    End Sub

    Sub New(ByVal navn As String, ByVal mail As String, ByVal adresse As String, ByVal telefon As Integer, ByVal post_nr As String)
        Me.pNavn = navn
        Me.pMail = mail
        Me.pAdresse = adresse
        Me.pTlfnr = telefon
        Me.pPostnr = post_nr
    End Sub

    Public Property pID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Public Property pNavn() As String
        Get
            Return navn
        End Get
        Set(ByVal value As String)
            navn = value
        End Set
    End Property
    Public Property pMail() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            mail = value
        End Set
    End Property
    Public Property pAdresse() As String
        Get
            Return adresse
        End Get
        Set(ByVal value As String)
            adresse = value
        End Set
    End Property
    Public Property pTlfnr() As Integer
        Get
            Return telefon
        End Get
        Set(ByVal value As Integer)
            telefon = value
        End Set
    End Property
    Public Property pPostnr() As Integer
        Get
            Return post_nr
        End Get
        Set(ByVal value As Integer)
            post_nr = value
        End Set
    End Property
End Class
