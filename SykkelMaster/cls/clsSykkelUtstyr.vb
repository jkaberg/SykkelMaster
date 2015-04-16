Public Class clsSykkelUtstyr
    Private id, utstyrstype, passer_sykkel_id, pris, innkjopspris As Integer
    Private storrelse, s_u_status As String
    Private innkjopt As Date

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal utstyrstype As Integer,
            ByVal pris As Object,
            ByVal innkjopspris As Object,
            ByVal storrelse As String,
            ByVal s_u_status As String,
            ByVal innkjopt As Date,
            ByVal passer_sykkel_id As Integer)

        Me.pID = id
        Me.pUtstyrstype = utstyrstype
        Me.pStorrelse = storrelse
        Me.pS_u_status = s_u_status
        Me.pPris = pris
        Me.pInnkjopspris = innkjopspris
        Me.pInnkjopt = innkjopt
        Me.pPasserSykkelID = passer_sykkel_id
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
    Public Property pUtstyrstype() As Integer
        Get
            Return utstyrstype
        End Get
        Set(ByVal value As Integer)
            utstyrstype = value
        End Set
    End Property
    Public Property pStorrelse() As Integer
        Get
            Return storrelse
        End Get
        Set(ByVal value As Integer)
            storrelse = value
        End Set
    End Property
    Public Property pS_u_status() As String
        Get
            Return s_u_status
        End Get
        Set(ByVal value As String)
            s_u_status = value
        End Set
    End Property
    Public Property pPris() As Object
        Get
            Return pris
        End Get
        Set(ByVal value As Object)
            pris = value
        End Set
    End Property
    Public Property pInnkjopspris() As Object
        Get
            Return innkjopspris
        End Get
        Set(ByVal value As Object)
            innkjopspris = value
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
    Public Property pPasserSykkelID() As Integer
        Get
            Return passer_sykkel_id
        End Get
        Set(ByVal value As Integer)
            passer_sykkel_id = value
        End Set
    End Property

End Class
