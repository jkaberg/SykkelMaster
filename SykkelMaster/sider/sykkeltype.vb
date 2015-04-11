Public Class sykkeltype

    Private payload As New DataTable

    Private Sub sykkeltype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oppdaterGridView()
    End Sub

    Private Sub oppdaterGridView()
        With Me.sykkeltypeGrid
            .DataSource = daoDelt.hentSykkelType
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("sykkeltype").HeaderText = "Sykkletype"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles sykkeltypeGrid.CellClick
        txtNavn.Text = Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        Dim st As New clsSykkelType(txtNavn.Text)
        'Legge til en ny sykkeltype i systemet
        Try
            daoSykkelType.leggTilSykkelType(st)
            MsgBox(txtNavn.Text & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere person i databasen
        Dim st As New clsSykkelType(Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("id").Value, txtNavn.Text)
        Dim sykkeltype As String = Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value

        'Oppdater sykkeltype
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & sykkeltype & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    daoSykkelType.oppdaterSykkelType(st)
                    MsgBox(sykkeltype & " oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkeltype i databasen
        Dim st As New clsSykkelType(Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("id").Value, txtNavn.Text)

        Dim sykkeltype As String = Me.sykkeltypeGrid.Rows(Me.sykkeltypeGrid.CurrentRow.Index).Cells("sykkeltype").Value
        'Slett sykkeltype
        Select Case MsgBox("Er du sikker på at du vil fjern " & sykkeltype & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    daoSykkelType.fjernSykkelType(st)
                    MsgBox(sykkeltype & " fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub
End Class