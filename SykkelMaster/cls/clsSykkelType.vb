Public Class clsSykkelType
    Private navn As String
    Private id As Integer

    Sub New(ByVal id As Integer, ByVal navn As String)
        Me.pID = id
        Me.pNavn = navn
    End Sub

    Sub New(ByVal navn As String)
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
            navn = value
        End Set
    End Property
End Class
