Public Class clsPerson
    Private fornavn, etternavn, epost, gate, sted As String ' Ola | Nordmann | ola.nordmann@epost.com | Olav Tryggvasonsgate 10 | Trondheim
    Private id, postnr, telefonnr As Integer ' 1 | 7070 | 12345678

    'oppdater / opprett kunde avtale
    ''' <summary>
    ''' konstruktør for å oppdatere person i databasen
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="fnavn"></param>
    ''' <param name="enavn"></param>
    ''' <param name="pnr"></param>
    ''' <param name="tnr"></param>
    ''' <param name="adresse"></param>
    ''' <param name="epost"></param>
    ''' <param name="sted"></param>
    ''' <remarks>tar 8 parametere</remarks>
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As String,
            ByVal tnr As Object,
            ByVal adresse As String,
            ByVal epost As String,
            ByVal sted As String)

        Me.pID = id
        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pPostnr = pnr
        Me.pTlfnr = tnr
        Me.pAdresse = adresse
        Me.pEpost = epost
        Me.pSted = sted
    End Sub

    ''' <summary>
    ''' konstruktører for å legge til person i databasen
    ''' </summary>
    ''' <param name="fnavn"></param>
    ''' <param name="enavn"></param>
    ''' <param name="pnr"></param>
    ''' <param name="tnr"></param>
    ''' <param name="adresse"></param>
    ''' <param name="epost"></param>
    ''' <remarks>tar 8 parametere</remarks>
    Sub New(ByVal fnavn As String,
            ByVal enavn As String,
            ByVal pnr As String,
            ByVal tnr As Object,
            ByVal adresse As String,
            ByVal epost As String)

        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pPostnr = pnr
        Me.pTlfnr = tnr
        Me.pAdresse = adresse
        Me.pEpost = epost
    End Sub

    ''' <summary>
    ''' konstruktør som henter opp data fra person når man logger inn
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="fnavn"></param>
    ''' <param name="enavn"></param>
    ''' <param name="epost"></param>
    ''' <remarks>tar 4 parametere</remarks>
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String,
            ByVal epost As String)

        Me.pID = id
        Me.pFnavn = fnavn
        Me.pEnavn = enavn
        Me.pEpost = epost
    End Sub

    ''' <summary>
    ''' konstruktør for å slette person fra databasen
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="fnavn"></param>
    ''' <param name="enavn"></param>
    ''' <remarks>tar 3 konstruktører</remarks>
    Sub New(ByVal id As Integer,
            ByVal fnavn As String,
            ByVal enavn As String)

        Me.pID = id
        Me.pFnavn = fnavn
        Me.pEnavn = enavn
    End Sub
    ''' <summary>
    ''' egenskaper pID
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen id</returns>
    Public Property pID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    ''' <summary>
    ''' egenskaper til pFnavn, sjekker om verdien inneholder 3 tegn
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen fornavn</returns>
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
    ''' <summary>
    ''' egaenskaper til pEnavn, sjekker om verdien inneholder 3 tegn
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen etternavn</returns>
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
    ''' <summary>
    ''' egenskaper til pPostnr, sjekker at verdien er numerisk og at lengden er 4 tall
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen postnr som integer</returns>
    Public Property pPostnr() As String
        Get
            Return postnr
        End Get
        Set(ByVal value As String)
            If Not value.Length = 4 Then
                Throw New Exception("Post nummeret kan kun bestå av 4 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Post nummeret må bestå av kun tall.")
            Else
                postnr = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' egenskaper til pTlfnr, sjekker om verdien er numerisk og at den inneholder 8 tall
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen telefinnr som integer</returns>
    Public Property pTlfnr() As Object
        Get
            Return telefonnr
        End Get
        Set(ByVal value As Object)
            If Not value.ToString.Length = 8 Then
                Throw New Exception("Telefon nummeret må bestå av 8 tall.")
            ElseIf Not IsNumeric(value) Then
                Throw New Exception("Telefonnummer kan kun bestå av tall.")
            Else
                telefonnr = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' egenskaper for pAdresse, sjekker om verdien er lenger enn 3 tegn
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen gate</returns>
    Public Property pAdresse() As String
        Get
            Return gate
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Adress må være minst 3 tegn langt.")
            Else
                gate = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' egenskaper for pSted, sjekker om verdien er lenger enn 3 tegn
    ''' </summary>
    ''' <value></value>
    ''' <returns> variablen sted</returns>
    Public Property pSted() As String
        Get
            Return sted
        End Get
        Set(ByVal value As String)
            If value.Length < 3 Then
                Throw New Exception("Sted må være minst 3 tegn langt.")
            Else
                sted = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' egenskaper for pEpost, sjekker om verdien har tegn forran og bak @
    ''' </summary>
    ''' <value></value>
    ''' <returns>variablen epost</returns>
    Public Property pEpost() As String
        Get
            Return epost
        End Get
        Set(ByVal value As String)
            If Not verktoy.validerEpost(value) Then
                Throw New Exception("Du må angi en korrekt e-post adresse.")
            Else
                epost = value
            End If
        End Set
    End Property
End Class
