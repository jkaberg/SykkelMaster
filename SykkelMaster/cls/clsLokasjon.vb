Public Class clsLokasjon
    Private navn, mail, adresse As String
    Private id, telefon, post_nr As Integer

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal navn As String,
            ByVal mail As String,
            ByVal adresse As String,
            ByVal telefon As String,
            ByVal post_nr As String)

        Me.pID = id
        Me.pNavn = navn
        Me.pMail = mail
        Me.pAdresse = adresse
        Me.pTlfnr = telefon
        Me.pPostnr = post_nr
    End Sub

    'legg til
    Sub New(ByVal navn As String,
            ByVal mail As String,
            ByVal adresse As String,
            ByVal telefon As String,
            ByVal post_nr As String)

        Me.pNavn = navn
        Me.pMail = mail
        Me.pAdresse = adresse
        Me.pTlfnr = telefon
        Me.pPostnr = post_nr
    End Sub

    'fjern
    Sub New(ByVal id As Integer,
            ByVal navn As String)
        Me.pID = id
        Me.pNavn = navn
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
            If value.Length < 3 Then
                Throw New Exception("Navn må være minst 3 tegn langt.")
            Else
                navn = value
            End If
        End Set
    End Property
    Public Property pMail() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            If Not verktoy.validerEpost(value) Then
                Throw New Exception("Du må angi en korrekt e-post adresse.")
            Else
                mail = value
            End If
        End Set
    End Property
    Public Property pAdresse() As String
        Get
            Return adresse
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Adress må være minst 3 tegn langt.")
            Else
                adresse = value
            End If
        End Set
    End Property
    Public Property pTlfnr() As String
        Get
            Return telefon
        End Get
        Set(ByVal value As String)
            If Not value.ToString.Length = 8 Then
                Throw New Exception("Telefon nummeret må bestå av 8 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Telefon nummeret kan kun bestå av tall.")
            Else
                telefon = value
            End If
        End Set
    End Property
    Public Property pPostnr() As String
        Get
            Return post_nr
        End Get
        Set(ByVal value As String)
            If Not value.Length = 4 Then
                Throw New Exception("Post nummeret kan kun bestå av 4 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Post nummeret må bestå av kun tall.")
            Else
                post_nr = value
            End If
        End Set
    End Property
End Class
