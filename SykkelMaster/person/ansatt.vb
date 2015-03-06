﻿Public Class ansatt
    Inherits person
    Private stilling As String ' Daglig leder
    Private provisjon As Integer ' 10 | (%) - burde kanskje vurdere Double med 2 decimaler

    Sub New(ByVal id As Integer, ByVal fnavn As String, ByVal enavn As String, ByVal pnr As Integer, ByVal tnr As Integer, ByVal gate As String, ByVal sted As String, ByVal stilling As String, ByVal provisjon As Integer)
        MyBase.New(id, fnavn, enavn, pnr, tnr, gate, sted)
        Me.stilling = stilling
        Me.provisjon = provisjon
    End Sub

    Sub New()
        'MyBase.New()
    End Sub

    Public Property pStilling() As String
        Get
            Return stilling
        End Get
        Set(ByVal value As String)
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

End Class
