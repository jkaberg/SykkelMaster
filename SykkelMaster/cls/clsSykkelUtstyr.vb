﻿Public Class clsSykkelUtstyr
    Private id, virksomhet, posisjon, utstyrstype, innkjopspris As Integer
    Private status, storrelse As String
    Private innkjopt As Date

    'Oppdater
    Sub New(ByVal virksomhet As Integer,
            ByVal posisjon As Integer,
            ByVal utstyrstype As Integer,
            ByVal innkjopspris As Object,
            ByVal innkjopt As Date,
            ByVal status As String,
            ByVal storrelse As String)

        Me.pID = id
        Me.pVirksomhet = virksomhet
        Me.pPosisjon = posisjon
        Me.pUtstyrstype = utstyrstype
        Me.pInnkjopspris = innkjopspris
        Me.pInnkjopt = innkjopt
        Me.pStatus = status
        Me.pStorrelse = storrelse
    End Sub

    'Legg til
    Sub New(ByVal id As Integer,
            ByVal virksomhet As Integer,
            ByVal posisjon As Integer,
            ByVal utstyrstype As Integer,
            ByVal innkjopspris As Object,
            ByVal innkjopt As Date,
            ByVal status As String,
            ByVal storrelse As String)

        Me.pID = id
        Me.pVirksomhet = virksomhet
        Me.pPosisjon = posisjon
        Me.pUtstyrstype = utstyrstype
        Me.pInnkjopspris = innkjopspris
        Me.pInnkjopt = innkjopt
        Me.pStatus = status
        Me.pStorrelse = storrelse
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
    Public Property pVirksomhet() As Integer
        Get
            Return virksomhet
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må velge en posisjon som utstyret tilhører.")
            Else
                virksomhet = value
            End If
        End Set
    End Property
    Public Property pPosisjon() As Integer
        Get
            Return posisjon
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må velge en posisjon.")
            Else
                posisjon = value
            End If

        End Set
    End Property
    Public Property pUtstyrstype() As Integer
        Get
            Return utstyrstype
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Du må velge hva slags type utstyret er.")
            Else
                utstyrstype = value
            End If
        End Set
    End Property
    Public Property pStorrelse() As String
        Get
            Return storrelse
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Du må velge en størrelse.")
            Else
                storrelse = value
            End If

        End Set
    End Property
    Public Property pStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Du må velge en status.")
            Else
                status = value
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
    Public Property pInnkjopt() As Date
        Get
            Return innkjopt
        End Get
        Set(ByVal value As Date)
            innkjopt = value
        End Set
    End Property

End Class
