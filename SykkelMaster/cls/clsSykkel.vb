Public Class clsSykkel
    Private rammenr, avviksmelding, status, innkjopt As String
    Private sykkeltype, hjulstr, rammestr, innkjopspris, posisjon, virksomhet As Integer

    'Oppdater/legg til
    Sub New(ByVal rammenr As String,
            ByVal avviksmld As String,
            ByVal sykkeltype As Integer,
            ByVal hjulstr As Object,
            ByVal rammestr As Object,
            ByVal status As String,
            ByVal innkjopspris As Object,
            ByVal innkjopt As Date,
            ByVal posisjon As Integer,
            ByVal virksomhet As Integer)

        Me.pRammenr = rammenr
        Me.pAvviksmld = avviksmld
        Me.pSykkelType = sykkeltype
        Me.pHjulstr = hjulstr
        Me.pRammestr = rammestr
        Me.pStatus = status
        Me.pInnkjopt = innkjopt
        Me.pInnkjopspris = innkjopspris
        Me.pPosisjon = posisjon
        Me.pVirksomhet = virksomhet
    End Sub

    'fjern
    Sub New(ByVal rammenr As String)
        Me.pRammenr = rammenr
    End Sub

    Public Property pRammenr() As String
        Get
            Return rammenr
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Du må angi et rammenummer.")
            ElseIf daoDelt.sjekkRammeNr(value) Then
                Throw New Exception("Rammenummer eksisterer")
            Else
                rammenr = value
            End If
        End Set
    End Property
    Public Property pAvviksmld() As String
        Get
            Return avviksmelding
        End Get
        Set(ByVal value As String)
            avviksmelding = value
        End Set
    End Property
    Public Property pSykkelType() As Integer
        Get
            Return sykkeltype
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må velge hva slags sykkelsype sykkelen er.")
            Else
                sykkeltype = value
            End If
        End Set
    End Property
    Public Property pHjulstr() As Object
        Get
            Return hjulstr
        End Get
        Set(ByVal value As Object)
            If Not IsNumeric(value) Then
                Throw New Exception("Du må legge inn hjulstørrelse.")
            Else
                hjulstr = value
            End If
        End Set
    End Property
    Public Property pRammestr() As Object
        Get
            Return rammestr
        End Get
        Set(ByVal value As Object)
            If Not IsNumeric(value) Then
                Throw New Exception("Du må legge inn rammestørrelse.")
            Else
                rammestr = value
            End If
        End Set
    End Property
    Public Property pStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Du må sette en status.")
            Else
                status = value
            End If
        End Set
    End Property
    Public Property pInnkjopspris() As Object
        Get
            Return innkjopspris
        End Get
        Set(ByVal value As Object)
            If Not IsNumeric(value) Then
                Throw New Exception("Innkjøpspris kan kun bestå av tall.")
            Else
                innkjopspris = value
            End If
        End Set
    End Property
    Public Property pInnkjopt() As Date
        Get
            Return innkjopt
        End Get
        Set(ByVal value As Date)
            innkjopt = value
        End Set
    End Property
    Public Property pPosisjon() As Integer
        Get
            Return posisjon
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må angi posisjon.")
            Else
                posisjon = value
            End If
        End Set
    End Property
    Public Property pVirksomhet() As Integer
        Get
            Return virksomhet
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må angi virksomhet.")
            Else
                virksomhet = value
            End If
        End Set
    End Property
End Class
