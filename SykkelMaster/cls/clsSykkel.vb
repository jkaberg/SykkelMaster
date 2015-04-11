Public Class clsSykkel
    Private rammenr, avviksmelding, status As String
    Private id, sykkeltype, hjulstr, rammestr, posisjon, virksomhet As Integer

    'oppdater
    Sub New(ByVal id As Integer, ByVal rammenr As Integer, ByVal avviksmld As String, ByVal sykkeltype As Integer, ByVal hjulstr As Integer, ByVal rammestr As Integer, ByVal status As String, ByVal posisjon As Integer, ByVal virksomhet As Integer)
        Me.pID = id
        Me.pRammenr = rammenr
        Me.pAvviksmld = avviksmelding
        Me.pSykkeltype = sykkeltype
        Me.pHjulstr = hjulstr
        Me.pRammestr = rammestr
        Me.pStatus = status
        Me.pPosisjon = posisjon
        Me.pVirksomhet = virksomhet
    End Sub

    'legg til
    Sub New(ByVal rammenr As Integer, ByVal avviksmld As String, ByVal sykkeltype As Integer, ByVal hjulstr As Integer, ByVal rammestr As Integer, ByVal status As String, ByVal posisjon As Integer, ByVal virksomhet As Integer)
        Me.pRammenr = rammenr
        Me.pAvviksmld = avviksmelding
        Me.pSykkeltype = sykkeltype
        Me.pHjulstr = hjulstr
        Me.pRammestr = rammestr
        Me.pStatus = status
        Me.pPosisjon = posisjon
        Me.pVirksomhet = virksomhet
    End Sub

    'fjern
    Sub New(ByVal id As Integer)
        Me.pID = id
    End Sub

    Public Property pID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Public Property pRammenr() As Integer
        Get
            Return rammenr
        End Get
        Set(ByVal value As Integer)
            rammenr = value
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
    Public Property pSykkeltype() As Integer
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
    Public Property pStatus() As Integer
        Get
            Return status
        End Get
        Set(ByVal value As Integer)
            status = value
        End Set
    End Property
    Public Property pPosisjon() As Integer
        Get
            Return posisjon
        End Get
        Set(ByVal value As Integer)
            posisjon = value
        End Set
    End Property
    Public Property pVirksomhet() As Integer
        Get
            Return virksomhet
        End Get
        Set(ByVal value As Integer)
            virksomhet = value
        End Set
    End Property
End Class
