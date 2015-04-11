Public Class sykkeltype

    Private payload As New DataTable

    Private Sub sykkeltype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oppdaterGridView()
    End Sub

    Private Sub oppdaterGridView()
        sykkeltypeGrid.DataSource = delt.hentSykkeltype

        With Me.sykkeltypeGrid
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("sykkeltype").HeaderText = "Sykkletype"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles sykkeltypeGrid.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksen
        With Me.sykkeltypeGrid
            txtNavn.Text = .Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value
        End With
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkeltype i systemet
        database.query("INSERT INTO sykkeltype (sykkeltype) VALUES('" & txtNavn.Text & "');")
        oppdaterGridView()
        oppdaterTxtbox()
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere person i databasen
        Dim sql As String = "UPDATE sykkeltype SET sykkeltype = '" & txtNavn.Text & "' WHERE id =" & Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("id").Value

        Dim sykkeltype As String = Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value
        'Oppdater sykkeltype
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & sykkeltype & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                payload = database.dt_query(sql)
                oppdaterGridView()
                oppdaterTxtbox()
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkeltype i databasen
        Dim sql As String = "DELETE FROM sykkelmaster2015.sykkeltype WHERE sykkeltype.id = " & Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("id").Value

        Dim sykkeltype As String = Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value
        'Slett sykkeltype
        Select Case MsgBox("Er du sikker på at du vil fjern " & sykkeltype & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                database.query(sql)
        End Select
        oppdaterGridView()
    End Sub
End Class