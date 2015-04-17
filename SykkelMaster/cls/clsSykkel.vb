Public Class clsSykkel
    Private rammenr, avviksmelding, status, innkjopt As String
    Private sykkeltype, hjulstr, rammestr, pris, innkjopspris, posisjon, virksomhet As Integer

    'Oppdater/legg til
    Sub New(ByVal rammenr As String,
            ByVal avviksmld As String,
            ByVal sykkeltype As Integer,
            ByVal hjulstr As Integer,
            ByVal rammestr As Integer,
            ByVal status As String,
            ByVal innkjopt As Object,
            ByVal pris As Object,
            ByVal innkjopspris As String,
            ByVal posisjon As Integer,
            ByVal virksomhet As Integer)

        Me.pRammenr = rammenr
        Me.pAvviksmld = avviksmld
        Me.pSykkelType = sykkeltype
        Me.pHjulstr = hjulstr
        Me.pRammestr = rammestr
        Me.pStatus = status
        Me.pInnkjopt = innkjopt
        Me.pPris = pris
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
            sykkeltype = value
        End Set
    End Property
    Public Property pHjulstr() As Integer
        Get
            Return hjulstr
        End Get
        Set(ByVal value As Integer)
            hjulstr = value
        End Set
    End Property
    Public Property pRammestr() As Integer
        Get
            Return rammestr
        End Get
        Set(ByVal value As Integer)
            rammestr = value
        End Set
    End Property
    Public Property pStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            status = value
        End Set
    End Property
    Public Property pInnkjopt() As String
        Get
            Return innkjopt
        End Get
        Set(ByVal value As String)
            innkjopt = value
        End Set
    End Property
    Public Property pPris() As Object
        Get
            Return pris
        End Get
        Set(ByVal value As Object)
            If Not IsNumeric(value) Then
                Throw New Exception("Pris kan kun bestå av tall.")
            Else
                pris = value
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
    Public Property pPosisjon() As Integer
        Get
            Return posisjon
        End Get
        Set(ByVal value As Integer)
            If IsNothing(value) Then
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
            If IsNothing(value) Then
                Throw New Exception("Du må angi virksomhet.")
            Else
                virksomhet = value
            End If
        End Set
    End Property
End Class
