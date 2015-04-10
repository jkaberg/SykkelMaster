Public Class person
    Private fornavn, etternavn, epost As String ' Ola | Nordmann | ola.nordmann@epost.com
    Private id, postnr, telefonnr As Integer ' 1 | 7070 | 12345678
    Private gate As String 'Olav Tryggvasonsgate 10
    Private sted As String 'Trondheim

    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer, ByVal tnr As Integer, ByVal gate As String, ByVal sted As String, ByVal epost As String)
        If sjekkEpost(epost) And sjekkTelefon(tnr) Then
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
            If sjekkNavn("For", value) Then
                fornavn = value
            End If
        End Set
    End Property

    Public Property pEnavn() As String
        Get
            Return etternavn
        End Get
        Set(ByVal value As String)
            If sjekkNavn("Etter", value) Then
                etternavn = value
            End If
        End Set
    End Property

    Public Property pPostnr() As Integer
        Get
            Return postnr
        End Get
        Set(ByVal value As Integer)
            If sjekkPostnr(value) Then
                postnr = value
            End If
        End Set
    End Property

    Public Property pTlfnr() As Integer
        Get
            Return telefonnr
        End Get
        Set(ByVal value As Integer)
            If sjekkTelefon(value) Then
                telefonnr = value
            End If
        End Set
    End Property

    Public Property pGate() As String
        Get
            Return gate
        End Get
        Set(ByVal value As String)
            If sjekkGate(value) Then
                gate = value
            End If
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
            If sjekkEpost(value) Then
                epost = value
            End If
        End Set
    End Property
    Private Function sjekkNavn(ByVal navntype As String, ByVal navn As String) As Boolean
        If navn.ToString.Length <= 2 Then
            MsgBox(navntype & "navn må være minst 3 tegn langt.", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Function sjekkGate(ByVal gate As String) As Boolean
        If gate.ToString.Length <= 3 Then
            MsgBox("Gate må være minst 3 tegn langt.", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function sjekkPostnr(ByVal postnr As Integer) As Boolean
        If postnr.ToString.Length <> 4 Then
            MsgBox("Post nummeret kan kun bestå av 4 tall.", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(postnr) Then
            MsgBox("Post nummeret må bestå av kun tall.", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function sjekkTelefon(ByVal tlf As Integer) As Boolean
        If Not tlf.ToString.Length = 8 Then
            MsgBox("Telefon nummeret må bestå av 8 tall.", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(tlf) Then
            MsgBox("Telefon nummeret kan kun bestå av tall.", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function sjekkEpost(ByVal epost As String) As Boolean
        Dim regx As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim ep As System.Text.RegularExpressions.Match = regx.Match(epost)
        If Not ep.Success Then
            MsgBox("Du må angi en korrekt e-post adresse!", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function
End Class
