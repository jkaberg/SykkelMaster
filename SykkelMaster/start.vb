﻿Imports SykkelMaster.database
Imports SykkelMaster.verktoy
Imports SykkelMaster.ansatt
Imports System.Net.Mail
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class start
    Public bruker As ansatt

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEpost.Text = "ddd@ddd"
        txtPassord.Text = "d"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            bruker = startDAO.sjekkLogin(txtEpost.Text, txtPassord.Text)
            Me.Hide()
            hoved.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sendnyttpassord_click(sender As Object, e As EventArgs) Handles SendNyttPassord.Click
        Dim passord As String = verktoy.tilfeldigStreng()

        If verktoy.validerEpost(byttEpost.Text) Then
            If delt.sjekkMailEksisterer(byttEpost.Text) Then
                If startDAO.oppdaterPassord(passord, byttEpost.Text) Then
                    verktoy.sendMail(byttEpost.Text, "Nytt Passord", "Her er ditt nye passord: " & passord)
                    MsgBox("Ditt nye passord er sendt til deg på mail.", MsgBoxStyle.Information)
                End If
            End If
            byttEpost.Text = ""
        Else
            MsgBox("Feil E-post validering")
            byttEpost.Text = ""
        End If
    End Sub
End Class
