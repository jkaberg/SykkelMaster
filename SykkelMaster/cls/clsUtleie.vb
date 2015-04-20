Public Class clsUtleie
    Private fra, til As Date
    Private sykler, utstyr As DataTable
    Private kunde As clsPerson

    Sub New(ByVal fra As Date,
            ByVal til As Date,
            ByVal sykler As DataTable,
            ByVal utstyr As DataTable,
            ByVal kunde As clsPerson)

    End Sub
    Public Property pFra() As Date
        Get
            Return fra
        End Get
        Set(ByVal value As Date)
            fra = value
        End Set
    End Property
    Public Property pTil() As Date
        Get
            Return til
        End Get
        Set(ByVal value As Date)
            til = value
        End Set
    End Property
    Public Property pSykler() As DataTable
        Get
            Return sykler
        End Get
        Set(ByVal value As DataTable)
            If IsNothing(value.Rows) Then
                Throw New Exception("Du må legg til sykler i kundevognen.")
            Else
                sykler = value
            End If
        End Set
    End Property
    Public Property pUtstyr() As DataTable
        Get
            Return utstyr
        End Get
        Set(ByVal value As DataTable)
            If IsNothing(value) Then
                Throw New Exception("Du må legg til utstyr i kundevognen.")
            Else
                utstyr = value
            End If
        End Set
    End Property
    Public Property pKunde() As clsPerson
        Get
            Return kunde
        End Get
        Set(ByVal value As clsPerson)
                kunde = value
        End Set
    End Property

End Class
