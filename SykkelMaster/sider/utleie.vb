Public Class utleie
    Private payload As DataTable
    Private kundevogn_sykkler As DataTable
    'Private kundevogn_utstyr As DataTable

    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'kundevogn_utstyr = New DataTable("utstyr")
        lagSykkelDataTable()
        vognGrid.DataSource = kundevogn_sykkler

        sykkelGrid.DataSource = daoUtleie.hentSykkler

        With cbxRabattAvtale
            .DisplayMember = "type_rabatt"
            .ValueMember = "id"
            .DataSource = daoUtleie.hentRabattAvtaler
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
        leggTilSykkelKundevogn()
    End Sub

    Private Sub btnRedigere_Click(sender As Object, e As EventArgs) Handles btnRedigere.Click

    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click

    End Sub

    Private Sub btnOprettAvtale_Click(sender As Object, e As EventArgs) Handles btnOprettAvtale.Click

    End Sub

    Private Sub leggTilSykkelKundevogn()
        Dim sykkel As DataRow
        sykkel = kundevogn_sykkler.NewRow()

        sykkel.Item("fratid") = fraTid.Value
        sykkel.Item("tiltid") = tilTid.Value
        sykkel.Item("sykkeltype") = sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("sykkeltype").Value
        sykkel.Item("hjulstr") = sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("hjulstr").Value
        sykkel.Item("rammestr") = sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammestr").Value

        kundevogn_sykkler.Rows.Add(sykkel)
        vognGrid.DataSource = kundevogn_sykkler
    End Sub


    Private Sub lagSykkelDataTable()
        kundevogn_sykkler = New DataTable("sykkler")

        Dim fraTid As DataColumn = New DataColumn("fratid")
        fraTid.DataType = System.Type.GetType("System.String")
        Dim tilTid As DataColumn = New DataColumn("tiltid")
        tilTid.DataType = System.Type.GetType("System.String")
        Dim sykkelType As DataColumn = New DataColumn("sykkeltype")
        sykkelType.DataType = System.Type.GetType("System.Int32")
        Dim hjulStr As DataColumn = New DataColumn("hjulstr")
        hjulStr.DataType = System.Type.GetType("System.Int32")
        Dim rammeStr As DataColumn = New DataColumn("rammestr")
        rammeStr.DataType = System.Type.GetType("System.Int32")

        kundevogn_sykkler.Columns.Add(fraTid)
        kundevogn_sykkler.Columns.Add(tilTid)
        kundevogn_sykkler.Columns.Add(sykkelType)
        kundevogn_sykkler.Columns.Add(hjulStr)
        kundevogn_sykkler.Columns.Add(rammeStr)
    End Sub
End Class