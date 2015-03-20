
Public Class innlevering

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim payload As New DataTable
        payload = db.query("SELECT * FROM salg_leie")

        DataGridView1.DataSource = payload
    End Sub

    Public telefon As Integer


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim payload As New DataTable
        Dim rad As DataRow
        Dim sqlNavnCombo As String = "SELECT * FROM person WHERE fornavn LIKE '" & TextBox3.Text & "%' OR etternavn LIKE '" & TextBox3.Text & "%' OR telefon LIKE '" & TextBox3.Text & "%' "
        If TextBox3.Text <> "" Then
            payload = db.query(sqlNavnCombo)
        End If

        Dim fornavn, etternavn As String
        Dim id As Integer
        ComboBox1.Items.Clear()
        'Kunder blir lagt ut i ComboBox
        For Each rad In payload.Rows
            fornavn = rad("fornavn")
            etternavn = rad("etternavn")
            telefon = rad("telefon")
            id = rad("id")
            ComboBox1.Items.Add(id & " " & fornavn & " " & etternavn)
            ComboBox1.SelectedIndex = ComboBox1.FindString(rad.Item(id))

        Next

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Telefon blir vist for vertifisering av kunde
        TextBox2.Text = telefon
        Dim payload As New DataTable
        Dim rad As DataRow
        Dim sqlOrdreCombo As String = "SELECT * FROM salg_leie, person WHERE salg_leie.person_id_kunde = person.id AND person.id = '" & ComboBox1.SelectedItem() & "'"
        Dim ordrenr As Integer

        payload = db.query(sqlOrdreCombo)
        DataGridView1.DataSource = payload 'Ordrene til kunden som er valgt blir lagt ut i DataGrid

        ComboBox2.Items.Clear()
        For Each rad In payload.Rows

            ordrenr = rad("ordre_nr")
            ComboBox2.Items.Add(ordrenr)
        Next
        'Hver ordre blir listet opp i ComboBox for å lett kan velge hvilken ordre som leien skal bli avsluttet.
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class