﻿Public Class utleie
    Private payload As DataTable
    Private kundevogn_sykkler As DataTable = daoUtleie.lagSykklerDataTable
    Private kundevogn_utstyr As DataTable = daoUtleie.lagUtstyrDataTable

    Private Sub utleie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        utleieOversikt.Close()
        tomKundevogn(stengerned:=True)
    End Sub
    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cbxRabattAvtale
            .DisplayMember = "type_rabatt"
            .ValueMember = "prosent"
            .DataSource = daoUtleie.hentRabattAvtaler
        End With

        With Me.sykkelGrid
            .DataSource = daoUtleie.hentSykkler
            .Columns("sykkeltype").Visible = False
            .Columns("innkjopspris").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.vognSykkel
            .DataSource = kundevogn_sykkler
            .Columns("sykkeltype").Visible = False
            .Columns("innkjopspris").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.utstyrGrid
            .DataSource = daoUtleie.hentUtstyr
            .Columns("id").Visible = False
            .Columns("innkjopspris").Visible = False
            .Columns("navn").HeaderText = "Navn"
            .Columns("storrelse").HeaderText = "Størrelse"
        End With

        With Me.vognStyr
            .DataSource = kundevogn_utstyr
            .Columns("id").Visible = False
            .Columns("innkjopspris").Visible = False
            .Columns("navn").HeaderText = "Navn"
            .Columns("storrelse").HeaderText = "Størrelse"
        End With
    End Sub
    Private Sub btnKunde_Click(sender As Object, e As EventArgs) Handles btnKunde.Click
        person.Show()
    End Sub
    Private Sub btnRedigerKunde_Click(sender As Object, e As EventArgs) Handles btnRedigerKunde.Click
        person.Show()
        person.oppdaterGridView(id:=cbxNavn.SelectedValue)
    End Sub
    Private Sub txtSokKunde_TextChanged(sender As Object, e As EventArgs) Handles txtSokKunde.TextChanged
        payload = daoDelt.finnKunde(txtSokKunde.Text)

        payload.Columns.Add("kunde_navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count > 0 Then
            With cbxNavn
                .DisplayMember = "kunde_navn"
                .ValueMember = "id"
                .DataSource = payload
            End With

            txtTelefon.Text = daoDelt.finnTlfNummer(cbxNavn.SelectedValue)
        Else
            Me.cbxNavn.DataSource = Nothing
        End If
    End Sub
    Private Sub rbTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbTime.CheckedChanged
        fraTid.Format = DateTimePickerFormat.Time
        fraTid.ShowUpDown = True
        tilTid.Format = DateTimePickerFormat.Time
        tilTid.ShowUpDown = True
    End Sub
    Private Sub rbDag_CheckedChanged(sender As Object, e As EventArgs) Handles rbDag.CheckedChanged, rbHelg.CheckedChanged
        fraTid.Format = DateTimePickerFormat.Short
        fraTid.ShowUpDown = False
        tilTid.Format = DateTimePickerFormat.Short
        tilTid.ShowUpDown = False
    End Sub
    Private Sub btnOprettAvtale_Click(sender As Object, e As EventArgs) Handles btnOprettAvtale.Click
        Dim fra As Date = fraTid.Value
        Dim til As Date = tilTid.Value

        If cbxNavn.SelectedValue Then
            If Not sjekkLeieTid(fraTid.Value, tilTid.Value) And (rbDag.Checked Or rbTime.Checked) Then
                MsgBox("Til tid kan ikke være mindre enn fra tid", MsgBoxStyle.Exclamation)
            ElseIf Not helgLeie(fra.Date, til.Date) And rbHelg.Checked Then
                MsgBox("Helg leie må foregå på helg dager (Lørdag, Søndag) og kan kun være 2 dager.", MsgBoxStyle.Exclamation)
            Else
                If kundevogn_sykkler.Rows.Count > 0 Or kundevogn_utstyr.Rows.Count > 0 Then
                    Try
                        utleieOversikt.ordre = New clsUtleie(fraTid.Value,
                                                             tilTid.Value,
                                                             start.bruker.pID,
                                                             cbxRabattAvtale.SelectedValue,
                                                             regnTotalPris,
                                                             kundevogn_sykkler,
                                                             kundevogn_utstyr,
                                                             daoUtleie.hentPerson(cbxNavn.SelectedValue))
                        utleieOversikt.Show()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    MsgBox("Du må legg til produkter i kundevognen.", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Du må velge en kunde.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub sykkelGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles sykkelGrid.MouseDoubleClick
        If Not IsNothing(Me.sykkelGrid.CurrentRow) Then
            kundevogn_sykkler = daoUtleie.leggTilSykkelKundevogn(kundevogn_sykkler,
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "rammenr"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "sykkelnavn"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "sykkeltype"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "hjulstr"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "rammestr"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "innkjopspris"))

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Reservert",
                                                               daoDelt.finnDGWVerdi(sykkelGrid, "rammenr"))
        Else
            MsgBox("Du må velg en gyldig rad i sykkel oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub FjernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FjernToolStripMenuSykkel.Click
        If Not IsNothing(Me.vognSykkel.CurrentRow) Then
            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Tilgjengelig",
                                                               CStr(daoDelt.finnDGWVerdi(vognSykkel, "rammenr")))

            kundevogn_sykkler = daoUtleie.fjernFraKundevogn(Me.vognSykkel.CurrentRow.Index,
                                                               kundevogn_sykkler)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub utstyrGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles utstyrGrid.MouseDoubleClick
        If Not IsNothing(Me.utstyrGrid.CurrentRow) Then
            kundevogn_utstyr = daoUtleie.leggTilUtstyrKundevogn(kundevogn_utstyr,
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "id"),
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "navn"),
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "innkjopspris"),
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "storrelse"))

            utstyrGrid.DataSource = daoUtleie.settUtstyrStatus("Reservert",
                                                               daoDelt.finnDGWVerdi(utstyrGrid, "id"))

        Else
            MsgBox("Du må velg en gyldig rad i utstyr oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub FjernToolStripMenuUtstyr_Click(sender As Object, e As EventArgs) Handles FjernToolStripMenuUtstyr.Click
        If Not IsNothing(Me.vognStyr.CurrentRow) Then
            utstyrGrid.DataSource = daoUtleie.settUtstyrStatus("Tilgjengelig",
                                                             daoDelt.finnDGWVerdi(vognStyr, "id"))

            kundevogn_utstyr = daoUtleie.fjernFraKundevogn(Me.vognStyr.CurrentRow.Index,
                                                           kundevogn_utstyr)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnTomKundevogn_Click(sender As Object, e As EventArgs) Handles btnTomKundevogn.Click
        tomKundevogn()
    End Sub
    Private Sub vognSykkel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vognSykkel.CellClick
        If Not IsNothing(e.RowIndex) Then
            sykkelPris.Text = finnPris(daoDelt.finnDGWVerdi(vognSykkel, "innkjopspris"), "Sykkel")
        End If
    End Sub
    Private Sub utstyrGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles utstyrGrid.CellClick
        If Not IsNothing(e.RowIndex) Then
            utstyrPris.Text = finnPris(daoDelt.finnDGWVerdi(utstyrGrid, "innkjopspris"), "Utstyr")
        End If
    End Sub
    Private Sub finnTotalPris(sender As Object, e As DataGridViewCellEventArgs) Handles sykkelGrid.CellClick,
                                                                                        utstyrGrid.CellClick,
                                                                                        vognSykkel.CellClick,
                                                                                        vognStyr.CellClick
        totalPris.Text = "Totalpris: " & regnTotalPris() & " kr"
    End Sub
    Public Sub tomKundevogn(Optional ByVal stengerned As Boolean = False)
        If Not IsNothing(kundevogn_sykkler.Rows) Then
            For Each sykkel As DataRow In kundevogn_sykkler.Rows
                daoUtleie.settSykkelStatus("Tilgjengelig", sykkel.Item("rammenr"))
            Next sykkel
        End If
        If Not IsNothing(kundevogn_sykkler.Rows) Then
            For Each utstyr As DataRow In kundevogn_utstyr.Rows
                daoUtleie.settUtstyrStatus("Tilgjengelig", utstyr.Item("id"))
            Next utstyr
        End If

        If Not stengerned Then
            kundevogn_sykkler = daoUtleie.lagSykklerDataTable
            kundevogn_utstyr = daoUtleie.lagUtstyrDataTable

            vognSykkel.DataSource = kundevogn_sykkler
            vognStyr.DataSource = kundevogn_utstyr

            sykkelGrid.DataSource = daoUtleie.hentSykkler
            utstyrGrid.DataSource = daoUtleie.hentUtstyr
        Else
            kundevogn_sykkler = Nothing
            kundevogn_utstyr = Nothing
        End If
    End Sub
    Private Function finnPris(ByVal pris As Integer, ByVal type As String) As String
        If rbDag.Checked Then
            Return type & "pris: " & regnPris.dag(pris) & " kr/dag"
        ElseIf rbTime.Checked Then
            Return type & "pris: " & regnPris.time(pris) & " kr/dag"
        Else
            Return "Du må velg en leie type."
        End If
    End Function
    Private Function regnTotalPris() As Double
        Dim pris As Double = 0
        Dim rabatt As Double = cbxRabattAvtale.SelectedValue

        For Each rad As DataGridViewRow In vognSykkel.Rows
            If rbDag.Checked Then
                pris += regnPris.dag(rad.Cells(4).Value)
            ElseIf rbTime.Checked Then
                pris += regnPris.time(rad.Cells(4).Value)
            End If
        Next rad

        For Each rad As DataGridViewRow In vognStyr.Rows
            If rbDag.Checked Then
                pris += regnPris.dag(rad.Cells(0).Value)
            ElseIf rbTime.Checked Then
                pris += regnPris.time(rad.Cells(0).Value)
            End If
        Next rad

        If rabatt > 0 Then
            Return (pris * rabatt)
        Else
            Return pris
        End If
    End Function
    Private Function sjekkLeieTid(ByVal fra As Date, ByVal til As Date) As Boolean
        If rbDag.Checked And til.Date < fra.Date Then
            Return False
        ElseIf rbTime.Checked And til.Hour < fra.Hour Then
            Return False
        End If
        Return True
    End Function
    Private Function helgLeie(ByVal fra As Date, ByVal til As Date)
        If dagErHelg(fra) And dagErHelg(til) Then
            If DateDiff(DateInterval.Day, fra, til) = 1 Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Function dagErHelg(ByVal dag As Date)
        Select Case dag.DayOfWeek
            Case DayOfWeek.Saturday
                Return True
            Case DayOfWeek.Sunday
                Return True
            Case Else
                Return False
        End Select
    End Function
End Class