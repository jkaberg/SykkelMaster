
Public Class innlevering
    Public telefon As Integer

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avtaleInnehold()

        With lokasjoner
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = hoved.lokasjoner
        End With
    End Sub

    Private Sub txtSokKunde_TextChanged(sender As Object, e As EventArgs) Handles txtSokKunde.TextChanged
        If txtSokKunde.Text = "" Then
            avtaleInnehold() 'Viser alle leie avtaler om man ikke søkt etter kunde
        Else
            sokKunde(txtSokKunde.Text)
        End If
    End Sub

    Private Sub cbxKunde_DataSourceChanged(sender As Object, e As EventArgs) Handles cbxKunde.SelectedIndexChanged
        Dim payload As DataTable
        If cbxKunde.SelectedValue > 0 Then
            Dim sql As String = "SELECT ordre_nr " &
                                "FROM salg_leie " &
                                "WHERE salg_leie.person_id_kunde = " & cbxKunde.SelectedValue

            payload = db.query(sql)

            With cbxLeieAvtaler
                .DisplayMember = "ordre_nr"
                .ValueMember = "ordre_nr"
                .DataSource = payload
            End With
        End If
    End Sub

    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles oversiktGrid.CellClick
        Dim payload As New DataTable
        Dim sql As String = "SELECT utstyr_leid_ut.ordre_nr, " &
                            "sykkelutstyr.navn " &
                            "FROM utstyr_leid_ut " &
                            "JOIN sykkelutstyr ON utstyr_leid_ut.utstyr_id = sykkelutstyr.id " &
                            "WHERE utstyr_leid_ut.ordre_nr = " & Me.oversiktGrid.Rows(Me.oversiktGrid.CurrentRow.Index).Cells("ordre_nr").Value

        payload = db.query(sql)

        tilbehorGrid.DataSource = payload

        With tilbehorGrid
            'Unngår å vise enkelte kolonner 
            .Columns("ordre_nr").Visible = False
            'Endrer navn på headere for å gi en bedre visuell opplevelse
            .Columns("navn").HeaderText = "Navn"
        End With
    End Sub

    Private Sub sokKunde(ByVal sok As String)
        Dim payload As New DataTable
        Dim sql As String = "SELECT id, fornavn, etternavn, telefon FROM person " &
                            "WHERE fornavn LIKE '" & sok & "%' " &
                            "OR etternavn LIKE '" & sok & "%' " &
                            "OR telefon LIKE '" & sok & "%' "

        payload = db.query(sql)

        payload.Columns.Add("kunde_navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count >= 1 Then
            With cbxKunde
                .DisplayMember = "kunde_navn"
                .ValueMember = "id"
                .DataSource = payload
            End With
        End If
    End Sub

    Private Sub avtaleInnehold(Optional ByVal id As Integer = Nothing)
        Dim payload As New DataTable
        Dim sql As String

        If id Then
            sql = "SELECT salg_leie.ordre_nr, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "WHERE salg_leie.ordre_nr = " & id
        Else
            sql = "SELECT salg_leie.ordre_nr, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype"

            cbxKunde.DataSource = Nothing
            cbxLeieAvtaler.DataSource = Nothing
        End If

        payload = db.query(sql)
        oversiktGrid.DataSource = payload 'Ordrene til kunden som er valgt blir lagt ut i DataGrid

        With Me.oversiktGrid
            'Unngår å vise enkelte kolonner 
            .Columns("ordre_nr").Visible = False
            'Endrer navn på headere for å gi en bedre visuell opplevelse
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("rammenr").HeaderText = "Rammenummer"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub Avslutt_leie(sender As Object, e As EventArgs) Handles AvsluttLeie.Click
        'If TextBox1.Text = "" Then
        'Endre status fra utleid til levert
        '"UPDATE sykkel_leid_ut" &
        'JOIN ordre_nr ON  
        'SET status.status = 1
        'Else 
        '"UPDATE sykkel_leid_ut" &
        'JOIN ordre_nr ON  
        'SET status.status = 3
    End Sub

    Private Sub cbxLeieAvtaler_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxLeieAvtaler.SelectedIndexChanged
        avtaleInnehold(cbxLeieAvtaler.SelectedValue)
    End Sub
End Class