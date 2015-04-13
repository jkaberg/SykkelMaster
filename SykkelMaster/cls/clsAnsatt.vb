Public Class clsAnsatt
    Inherits clsPerson
    Private stilling As Integer ' Daglig leder
    Private provisjon As Integer ' 10 | (%) - burde kanskje vurdere Double med 2 decimaler
    Private passord As String
    Private arbeidssted As Integer
    Private tilgangsniva As Integer

    'start
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal epost As String,
            ByVal stilling As Integer,
            ByVal arbeidssted As Integer,
            ByVal passord As String)

        MyBase.New(id, fnavn, enavn, epost)
        Me.pStilling = stilling
        Me.pArbeidssted = arbeidssted
        Me.pPassord = passord
    End Sub

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As Integer,
            ByVal tnr As Integer,
            ByVal adresse As String,
            ByVal epost As String,
            ByVal stilling As Integer,
            ByVal provisjon As Integer,
            ByVal arbeidssted As Integer)

        MyBase.New(id, fnavn, enavn, pnr, tnr, adresse, epost)
        Me.pStilling = stilling
        Me.pProvisjon = provisjon
        Me.pArbeidssted = arbeidssted
    End Sub

    'legg til
    Sub New(ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As Integer,
            ByVal tnr As Integer,
            ByVal adresse As String,
            ByVal epost As String,
            ByVal stilling As Integer,
            ByVal provisjon As Integer,
            ByVal arbeidssted As Integer,
            ByVal passord As String)

        MyBase.New(fnavn, enavn, pnr, tnr, adresse, epost)
        Me.pStilling = stilling
        Me.pProvisjon = provisjon
        Me.pPassord = passord
        Me.pArbeidssted = arbeidssted
    End Sub

    'fjern
    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String)
        MyBase.New(id, fnavn, enavn)
    End Sub

    Public Property pStilling() As Integer
        Get
            Return stilling
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Du må velg en stillings type.")
            Else
                stilling = value
            End If
        End Set
    End Property

    Public Property pProvisjon() As Integer
        Get
            Return provisjon
        End Get
        Set(ByVal value As Integer)
            If Not IsNumeric(value) Then
                Throw New Exception("Du har ikke satt provisjon.")
            Else
                provisjon = value
            End If
        End Set
    End Property

    Public Property pPassord() As String
        Get
            Return passord
        End Get
        Set(ByVal value As String)
            If value.Length <= 3 Then
                Throw New Exception("Passord kan ikke være mindre enn 3 tegn langt.")
            Else
                passord = value
            End If

        End Set
    End Property

    Public Property pArbeidssted() As Integer
        Get
            Return arbeidssted
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Du må velge ett arbeidssted.")
            Else
                arbeidssted = value
            End If
        End Set
    End Property
End Class
