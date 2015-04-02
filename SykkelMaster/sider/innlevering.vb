
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
            avtaleInnehold()
        Else
            sokKunde(txtSokKunde.Text)
        End If
    End Sub

    Private Sub cbxKunde_DataSourceChanged(sender As Object, e As EventArgs) Handles cbxKunde.DataSourceChanged
        If txtSokKunde.Text = "" Then
            avtaleInnehold(cbxKunde.SelectedValue())
            txtTelefon.Text = cbxKunde.SelectedValue
        Else
            avtaleInnehold()
        End If
    End Sub

    Private Sub sokKunde(ByVal sok As String)
        Dim payload As New DataTable
        Dim sql As String = "SELECT id, fornavn, etternavn, telefon FROM person " &
                            "WHERE fornavn LIKE '" & sok & "%' " &
                            "OR etternavn LIKE '" & sok & "%' " &
                            "OR telefon LIKE '" & sok & "%' "

        payload = db.query(sql)

        payload.Columns.Add("navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count >= 1 Then
            With cbxKunde
                .DisplayMember = "navn"
                .ValueMember = "telefon"
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
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype "

            cbxKunde.DataSource = Nothing
            txtTelefon.Text = ""
            'cbxLeieAvtaler.DataSource = Nothing
            'cbxLeieAvtaler.Items.Clear()
        End If

        payload = db.query(sql)
        oversiktGrid.DataSource = payload 'Ordrene til kunden som er valgt blir lagt ut i DataGrid

        With cbxLeieAvtaler
            .DisplayMember = "ordre_nr"
            .ValueMember = "ordre_nr"
            .DataSource = payload
        End With

        'With Me.oversiktGrid
        '    'Unngår å vise enkelte kolonner 
        '    .Columns("person_id_selger").Visible = False
        '    .Columns("id").Visible = False
        '    .Columns("person_id_kunde").Visible = False
        '    .Columns("rabatt_id").Visible = False
        '    'Endrer navn på headere for å gi en bedre visuell opplevelse
        '    .Columns("ordre_nr").HeaderText = "Order nummer"
        '    .Columns("dato").HeaderText = "Dato"
        '    .Columns("frist").HeaderText = "Frist"
        '    .Columns("person_id_selger").HeaderText = "Etternavn"
        '    .Columns("fornavn").HeaderText = "Fornavn"
        '    .Columns("etternavn").HeaderText = "Etternavn"
        '    .Columns("telefon").HeaderText = "Telefon"
        '    .Columns("adresse").HeaderText = "Adresse"
        '    .Columns("post_nr").HeaderText = "Post nummer"
        '    '.Columns("post_sted").HeaderText = "Post sted"
        '    .Columns("sum").HeaderText = "Betalt sum"
        '    .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'End With
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

    Private Sub oversiktGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles oversiktGrid.CellContentClick
        '"JOIN utstyr_leid_ut ON utstyr_leid_ut.ordre_nr = salg_leie.ordre_nr " &
        '"JOIN sykkelutstyr ON utstyr_leid_ut.utstyr_id = sykkelutstyr.id " &
    End Sub
End Class