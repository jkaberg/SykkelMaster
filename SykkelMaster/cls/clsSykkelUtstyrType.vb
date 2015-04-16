Public Class clsSykkelUtstyrType
    Private navn As String
    Private id As Integer

    'oppdater/fjern
    Sub New(ByVal id As Integer,
            ByVal navn As String)
        Me.pID = id
        Me.pNavn = navn
    End Sub

    'legg til
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
            If value.Length < 3 Then
                Throw New ArgumentException("Navn må være minst 3 tegn langt.")
            Else
                navn = value
            End If
        End Set
    End Property
End Class
