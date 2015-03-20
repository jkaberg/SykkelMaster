Public Class person
    Private fornavn, etternavn, epost As String ' Ola | Nordmann | ola.nordmann@epost.com
    Private id, postnr, telefonnr As Integer ' 1 | 7070 | 12345678
    Private gate As String 'Olav Tryggvasonsgate 10
    Private sted As String 'Trondheim

    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer, ByVal tnr As Integer, ByVal gate As String, ByVal sted As String, ByVal epost As String)
        If sjekkepost(epost) And sjekktlf(tnr) Then
            Me.id = id
            Me.fornavn = fnavn
            Me.etternavn = enavn
            Me.postnr = pnr
            Me.telefonnr = tnr
            Me.gate = gate
            Me.sted = sted
            Me.epost = epost
        End If
    End Sub

    Public Property pId() As String
        Get
            Return id
        End Get
        Set(ByVal value As String)
            id = value
        End Set
    End Property

    Public Property pFnavn() As String
        Get
            Return fornavn
        End Get
        Set(ByVal value As String)
            fornavn = value
        End Set
    End Property

    Public Property pEnavn() As String
        Get
            Return etternavn
        End Get
        Set(ByVal value As String)
            etternavn = value
        End Set
    End Property

    Public Property pPostnr() As Integer
        Get
            Return postnr
        End Get
        Set(ByVal value As Integer)
            postnr = value
        End Set
    End Property

    Public Property pTlfnr() As Integer
        Get
            Return telefonnr
        End Get
        Set(ByVal value As Integer)
            telefonnr = value
        End Set
    End Property

    Public Property pGate() As String
        Get
            Return gate
        End Get
        Set(ByVal value As String)
            gate = value
        End Set
    End Property

    Public Property pSted() As String
        Get
            Return sted
        End Get
        Set(ByVal value As String)
            sted = value
        End Set
    End Property

    Public Property pEpost() As String
        Get
            Return epost
        End Get
        Set(ByVal value As String)
            epost = value
        End Set
    End Property

    Private Function sjekktlf(ByVal tlf As Integer)
        If Not tlf.ToString.Length = 8 Then
            MsgBox("Du må angi ett korrekt telefonnummer!", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Function sjekkepost(ByVal epost As String)
        If Not epost.Contains("@") Then
            MsgBox("Du må angi en korrekt e-post adresse!", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
End Class
