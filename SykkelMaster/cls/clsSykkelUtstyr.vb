Public Class clsSykkelUtstyr
    Private id, passer_sykkel_id As Integer
    Private navn As String

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal passer_sykkel_id As Integer,
            ByVal navn As String)
        Me.pID = id
        Me.pPasserSykkelID = passer_sykkel_id
        Me.pNavn = navn
    End Sub

    'legg til
    Sub New(ByVal passer_sykkel_id As Integer,
            ByVal navn As String)
        Me.pPasserSykkelID = passer_sykkel_id
        Me.pNavn = navn
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
    Public Property pPasserSykkelID() As Integer
        Get
            Return passer_sykkel_id
        End Get
        Set(ByVal value As Integer)
            passer_sykkel_id = value
        End Set
    End Property
    Public Property pNavn() As Integer
        Get
            Return navn
        End Get
        Set(ByVal value As Integer)
            navn = value
        End Set
    End Property
End Class
