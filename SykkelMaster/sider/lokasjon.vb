Public Class lokasjon
    Private gridIndex As Integer
    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT navn, telefon, mail, adresse, virksomhet.post_nr, sted.post_sted FROM virksomhet JOIN sted ON sted.post_nr = virksomhet.post_nr")

        Oppdaterlokasjon.DataSource = payload
    End Sub
    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        Dim payload As New DataTable
        Dim sql As String
        If Not sok = Nothing Then
            sql = "SELECT * FROM virksomhet WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%'"
        Else
            sql = "SELECT * FROM virksomhet"
        End If
        payload = db.query(sql)
        Oppdaterlokasjon.DataSource = payload

        With Me.Oppdaterlokasjon
            ' Kolonne vises ikke 
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("navn").HeaderText = "Lokasjon"
            .Columns("telefon").HeaderText = "Telefonnummer"
            .Columns("mail").HeaderText = "Epost"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .Columns("post_sted").HeaderText = "Poststed"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Oppdaterlokasjon.CellClick
        Dim payload As New DataTable
        Dim sql As String = "SELECT * FROM virksomhet WHERE navn = '" & Me.Oppdaterlokasjon.Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("navn").Value & "'"
        payload = db.query(sql)
        gridIndex = Oppdaterlokasjon.CurrentRow.Index()

        With Me.Oppdaterlokasjon
            txtLokasjon.Text = .Rows(gridIndex).Cells("navn").Value
            txtTelefon.Text = .Rows(gridIndex).Cells("telefon").Value
            txtMail.Text = .Rows(gridIndex).Cells("mail").Value
            txtAdresse.Text = .Rows(gridIndex).Cells("adresse").Value
            txtpostnr.Text = .Rows(gridIndex).Cells("post_nr").Value
        End With
    End Sub


    Private Sub btnAddlocation_Click(sender As Object, e As EventArgs) Handles btnAddLocation.Click
        Dim payload As New DataTable
        Dim sql As String
        sql = "INSERT INTO virksomhet(navn, telefon, mail, adresse, post_nr) VALUES ('" & txtLokasjon.Text & "', '" & txtTelefon.Text & "', '" & txtMail.Text & "', '" & txtAdresse.Text & "', " & txtpostnr.Text & ")"

        payload = db.query(sql)
        Oppdaterlokasjon.DataSource = payload
        oppdaterGridView()
    End Sub


    Private Sub txtpostnr_TextChanged(sender As Object, e As EventArgs) Handles txtpostnr.TextChanged
        Dim payload As New DataTable
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = " & txtpostnr.Text)
        'Oppdaterer poststedet når post nummer blir skrevet inn
        If payload.Rows.Count = 1 Then
            txtPoststed.Text = payload.Rows(0).Item(0)
        Else
            txtPoststed.Text = ""
        End If
    End Sub
End Class