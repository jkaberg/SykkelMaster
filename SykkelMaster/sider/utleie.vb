Public Class utleie
    Private payload As DataTable
    Private kundevogn_sykkler As DataTable = daoUtleie.lagSykklerDataTable

    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vognGrid.DataSource = kundevogn_sykkler

        sykkelGrid.DataSource = daoUtleie.hentSykkler

        With cbxRabattAvtale
            .DisplayMember = "type_rabatt"
            .ValueMember = "id"
            .DataSource = daoUtleie.hentRabattAvtaler
        End With

        With Me.sykkelGrid
            .Columns("sykkeltype").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.vognGrid
            .Columns("sykkeltype").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("fratid").HeaderText = "Fra"
            .Columns("tiltid").HeaderText = "Til"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
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
    Private Sub rbDag_CheckedChanged(sender As Object, e As EventArgs) Handles rbDag.CheckedChanged
        fraTid.Format = DateTimePickerFormat.Short
        fraTid.ShowUpDown = False
        tilTid.Format = DateTimePickerFormat.Short
        tilTid.ShowUpDown = False
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        If Not IsNothing(Me.sykkelGrid.CurrentRow) Then
            kundevogn_sykkler = daoUtleie.leggTilSykkelKundevogn(kundevogn_sykkler,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammenr").Value,
                                                                 fraTid.Value,
                                                                 tilTid.Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("sykkeltype").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("hjulstr").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammestr").Value)

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Reservert",
                                                               Me.sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammenr").Value)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        If Not IsNothing(Me.vognGrid.CurrentRow) Then
            'Me.vognGrid.Rows.Remove(Me.vognGrid.CurrentRow)
            kundevogn_sykkler = daoUtleie.fjernSykkelKundevogn(Me.vognGrid.CurrentRow.Index, kundevogn_sykkler)

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Tilgjengelig",
                                                               Me.vognGrid.Rows(Me.vognGrid.CurrentRow.Index).Cells("rammenr").Value)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnOprettAvtale_Click(sender As Object, e As EventArgs) Handles btnOprettAvtale.Click

    End Sub
End Class