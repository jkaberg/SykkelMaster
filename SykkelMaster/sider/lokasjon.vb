Public Class lokasjon

    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM virksomhet")

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
            .Columns("virksomhet").HeaderText = "Lokasjon"
            .Columns("Telefonnummer").HeaderText = "Telefonnummer"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub


    Private Sub btnAddlocation_Click(sender As Object, e As EventArgs) Handles btnAddlocation.Click
        Dim payload As New DataTable
        Dim sql As String
        sql = "INSERT INTO virksomhet(navn, telefon, adresse, post_nr) VALUES ('" & txtLokasjon.Text & "', '" & txtTelefon.Text & "', '" & txtAdresse.Text & "', '" & txtpostnr.Text & "', '" & )"
        payload = db.query(sql)
        Oppdaterlokasjon.DataSource = payload
        oppdaterGridView()
    End Sub


    Private Sub txtpostnr_TextChanged(sender As Object, e As EventArgs) Handles txtpostnr.TextChanged
        Dim payload As New DataTable
        payload = db.query("SELECT post_sted FROM sted WHERE sted.post_nr = '" & txtpostnr.Text & "'")
        'Oppdaterer poststedet når post nummer blir skrevet inn
        If payload.Rows.Count = 1 Then
            txtPoststed.Text = payload.Rows(0).Item(0)
        Else
            txtPoststed.Text = ""
        End If
    End Sub
End Class