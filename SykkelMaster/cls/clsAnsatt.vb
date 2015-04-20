Public Class clsAnsatt
    Inherits clsPerson
    Private stilling As Integer ' Daglig leder
    Private provisjon As Integer ' 10 | (%) - burde kanskje vurdere Double med 2 decimaler
    Private passord As String
    Private arbeidssted As Integer
    Private tilgangsniva As Integer
    ''' <summary>
    ''' konstruktør for å lag objektet clsPerson, brukes når man logger inn i sykkelmaster
    ''' </summary>
    ''' <remarks>tar 7 paramterer, hvert å merk seg ID som brukes for å "finn" noen i databasen</remarks>
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
    ''' <summary>
    ''' konstruktør for å lag objektet clsPerson, brukes for å oppdatere en ansatt
    ''' </summary>
    ''' <param name="id">integer</param>
    ''' <param name="fnavn">string</param>
    ''' <param name="enavn">string</param>
    ''' <param name="pnr">object</param>
    ''' <param name="tnr">object</param>
    ''' <param name="adresse">string</param>
    ''' <param name="epost">string</param>
    ''' <param name="sted">string</param>
    ''' <param name="stilling">integer</param>
    ''' <param name="provisjon">integer</param>
    ''' <param name="arbeidssted">integer</param>
    ''' <remarks>tar 11 paramterer, hvert å merk seg ID som brukes for å "finn" noen i databasen</remarks>
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As Object,
            ByVal tnr As Object,
            ByVal adresse As String,
            ByVal epost As String,
            ByVal sted As String,
            ByVal stilling As Integer,
            ByVal provisjon As Integer,
            ByVal arbeidssted As Integer)

        MyBase.New(id, fnavn, enavn, pnr, tnr, adresse, epost, sted)
        Me.pStilling = stilling
        Me.pProvisjon = provisjon
        Me.pArbeidssted = arbeidssted
    End Sub
    ''' <summary>
    ''' konstruktør for å lag objektet clsPerson, brukes for å legg til en ansatt i databasen
    ''' </summary>
    ''' <param name="fnavn">string</param>
    ''' <param name="enavn">string</param>
    ''' <param name="pnr">string</param>
    ''' <param name="tnr">object</param>
    ''' <param name="adresse">string</param>
    ''' <param name="epost">string</param>
    ''' <param name="stilling">integer</param>
    ''' <param name="provisjon">integer</param>
    ''' <param name="arbeidssted">integer</param>
    ''' <param name="passord">string</param>
    ''' <remarks>tar 10 parametrer</remarks>
    Sub New(ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As String,
            ByVal tnr As Object,
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

    ''' <summary>
    ''' konstruktør for å lag objektet clsPerson, brukes for å fjern til en ansatt i databasen
    ''' </summary>
    ''' <param name="id">integer</param>
    ''' <param name="fnavn">string</param>
    ''' <param name="enavn">string</param>
    ''' <remarks>tar 3 paramterer</remarks>
    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String)
        MyBase.New(id, fnavn, enavn)
    End Sub
    ''' <summary>
    ''' egenskapen pStilling
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property pStilling() As Integer
        Get
            Return stilling
        End Get
        Set(ByVal value As Integer)
            If value = -1 Then
                Throw New Exception("Du må velg en stillings type.")
            Else
                stilling = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' henter eller setter provisjon, sjekker om veriden er numerisk
    ''' </summary>
    ''' <returns>variablen provisjon som integer</returns>
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
    ''' <summary>
    ''' henter eller setter provisjon, sjekker om lengden på veriden er mindre enn 3 tegn
    ''' </summary>
    ''' <returns>variablen passord som streng</returns>
    Public Property pPassord() As String
        Get
            Return passord
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Passord kan ikke være mindre enn 3 tegn langt.")
            Else
                passord = value
            End If

        End Set
    End Property
    ''' <summary>
    ''' henter eller setter arbeidssted, sjekker at veriden ikke er 0
    ''' </summary>
    ''' <returns>variablen arbeidssted</returns>
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
