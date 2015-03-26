Public Class sykkelEdit
    Private gridIndex As Integer
    Private payload As New DataTable

    Private Sub sykkelEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()

        'Laster inn data til comboBox'ene
        With cbxTilhorer
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = hoved.lokasjoner
        End With
        'Gjør at comboBox'en er tom når programmet starter
        cbxTilhorer.SelectedIndex = -1

        payload = db.query("SELECT * FROM virksomhet")
        With cbxPosisjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = payload
        End With
        cbxPosisjon.SelectedIndex = -1

        payload = db.query("SELECT * FROM virksomhet")
        With cbxLokasjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = payload
        End With
        cbxLokasjon.SelectedIndex = -1

        payload = db.query("SELECT * FROM sykkeltype")
        With cbxType
            .DisplayMember = "sykkeltype"
            .ValueMember = "id"
            .DataSource = payload
        End With
        cbxType.SelectedIndex = -1

        payload = db.query("SELECT * FROM status")
        With cbxStatus
            .DisplayMember = "status"
            .ValueMember = "id"
            .DataSource = payload
        End With
        cbxStatus.SelectedIndex = -1

    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SykkelGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing, Optional ByVal posisjon As String = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim sql As String
        If Not sok = Nothing Or posisjon = Nothing Then
            sql = "SELECT sykkel.rammenr, sykkeltype.sykkeltype, status.status, sykkel.hjulstr, sykkel.rammestr, " & _
                "sykkel.avviksmelding, v1.navn posisjon, v2.navn " & _
                "FROM sykkel JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id JOIN status ON sykkel.status = status.id " & _
                "JOIN virksomhet v1 ON sykkel.posisjon = v1.id JOIN virksomhet v2 ON sykkel.virksomhet_id = v2.id " & _
                "AND rammenr LIKE '%" & sok & "%' AND v1.navn LIKE '%" & posisjon & "%'"
        Else
            sql = "SELECT sykkel.rammenr, sykkeltype.sykkeltype, status.status, sykkel.hjulstr, sykkel.rammestr, " & _
                "sykkel.avviksmelding, v1.navn posisjon, v2.navn " & _
                "FROM sykkel JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id JOIN status ON sykkel.status = status.id " & _
                "JOIN virksomhet v1 ON sykkel.posisjon = v1.id JOIN virksomhet v2 ON sykkel.virksomhet_id = v2.id"
        End If
        payload = db.query(sql)
        SykkelGridView.DataSource = payload

        With Me.SykkelGridView
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("status").HeaderText = "Status"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("avviksmelding").HeaderText = "Avviksmelding"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub oppdaterTxtbox()
        gridIndex = SykkelGridView.CurrentRow.Index()

        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.SykkelGridView
            cbxTilhorer.Text = .Rows(gridIndex).Cells("navn").Value
            cbxPosisjon.Text = .Rows(gridIndex).Cells("posisjon").Value
            cbxType.Text = .Rows(gridIndex).Cells("sykkeltype").Value
            txtRammenr.Text = .Rows(gridIndex).Cells("rammenr").Value
            cbxHjul.Text = .Rows(gridIndex).Cells("hjulstr").Value
            cbxRamme.Text = .Rows(gridIndex).Cells("rammestr").Value
            cbxStatus.Text = .Rows(gridIndex).Cells("status").Value
            txtAvvik.Text = .Rows(gridIndex).Cells("avviksmelding").Value
        End With
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        'Nulstiller alle textBox'ene og comboBox'ene
        cbxTilhorer.SelectedIndex = -1
        cbxPosisjon.SelectedIndex = -1
        cbxType.SelectedIndex = -1
        cbxHjul.SelectedIndex = -1
        cbxRamme.SelectedIndex = -1
        cbxStatus.SelectedIndex = -1
        txtRammenr.Text = ""
        txtAvvik.Text = ""
        oppdaterGridView()
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkel i databasen
        Dim sql As String
        sql = "INSERT INTO sykkel VALUES('" & txtRammenr.Text & "', " & CInt(cbxType.SelectedValue) & ", " & _
            cbxHjul.Text & ", " & cbxRamme.Text & ", " & CInt(cbxStatus.SelectedValue) & ", '" & txtAvvik.Text & _
            "', " & CInt(cbxPosisjon.SelectedValue) & ", " & CInt(cbxTilhorer.SelectedValue) & ")"
        db.query(sql)
        oppdaterGridView()
        oppdaterTxtbox()
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere sykkel i databasen
        Dim sql As String = "UPDATE sykkel SET rammenr = '" & txtRammenr.Text & "', sykkeltype = " & CInt(cbxType.SelectedValue) & _
            ", hjulstr = " & cbxHjul.Text & ", rammestr = " & cbxRamme.Text & ", status = " & CInt(cbxStatus.SelectedValue) & _
            ", avviksmelding = '" & txtAvvik.Text & "', posisjon = " & CInt(cbxPosisjon.SelectedValue) & _
            ", virksomhet_id = " & CInt(cbxTilhorer.SelectedValue) & " WHERE rammenr = '" & Me.SykkelGridView.Rows(gridIndex).Cells("rammenr").Value & "'"

        Dim sykkel As String = Me.SykkelGridView.Rows(gridIndex).Cells("rammenr").Value & " " & Me.SykkelGridView.Rows(gridIndex).Cells("sykkeltype").Value
        'Oppdater bruker
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & sykkel & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                payload = db.query(sql)
                oppdaterGridView()
                oppdaterTxtbox()
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkel i databasen
        Dim sql As String = "DELETE FROM sykkelmaster2015.sykkel WHERE rammenr = '" & Me.SykkelGridView.Rows(gridIndex).Cells("rammenr").Value & "'"

        Dim sykkel As String = Me.SykkelGridView.Rows(gridIndex).Cells("rammenr").Value & " " & Me.SykkelGridView.Rows(gridIndex).Cells("sykkeltype").Value
        'Slett sykkel
        Select Case MsgBox("Er du sikker på at du vil fjern " & sykkel & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    payload = db.query(sql)
                Catch
                    MsgBox("Du kan ikke slette sykkel")
                End Try
        End Select

        oppdaterGridView()
    End Sub


    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        oppdaterGridView(sok:=txtSok.Text)
    End Sub

    Private Sub cbxLokasjon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLokasjon.SelectedIndexChanged
        oppdaterGridView(posisjon:=txtRammenr.Text)
        txtRammenr.Text = cbxLokasjon.Text
    End Sub
End Class