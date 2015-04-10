Public Class ansatt
    Inherits person
    Private stilling As Integer ' Daglig leder
    Private provisjon As Integer ' 10 | (%) - burde kanskje vurdere Double med 2 decimaler
    Private passord As String
    Private arbeidssted As Integer

    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer, ByVal tnr As Integer, ByVal gate As String, ByVal sted As String, ByVal epost As String, ByVal stilling As Integer, ByVal provisjon As Integer, ByVal passord As String, ByVal arbeidssted As Integer)
        MyBase.New(id, fnavn, enavn, pnr, tnr, gate, sted, epost)
        Me.pStilling = stilling
        Me.pProvisjon = provisjon
        Me.pPassord = passord
        Me.pArbeidssted = arbeidssted
    End Sub

    Sub New(ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer, ByVal tnr As Integer, ByVal gate As String, ByVal sted As String, ByVal epost As String, ByVal stilling As Integer, ByVal provisjon As Integer, ByVal passord As String, ByVal arbsted As Integer)
        MyBase.New(fnavn, enavn, pnr, tnr, gate, sted, epost)
        Me.pStilling = stilling
        Me.pProvisjon = provisjon
        Me.pPassord = passord
        Me.pArbeidssted = arbsted
    End Sub

    Public Property pStilling() As Integer
        Get
            Return stilling
        End Get
        Set(ByVal value As Integer)
            stilling = value
        End Set
    End Property

    Public Property pProvisjon() As Integer
        Get
            Return provisjon
        End Get
        Set(ByVal value As Integer)
            provisjon = value
        End Set
    End Property

    Public Property pPassord() As String
        Get
            Return passord
        End Get
        Set(ByVal value As String)
            passord = value
        End Set
    End Property

    Public Property pArbeidssted() As Integer
        Get
            Return arbeidssted
        End Get
        Set(ByVal value As Integer)
            arbeidssted = value
        End Set
    End Property
End Class
