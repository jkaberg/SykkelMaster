Public Class sykkelEdit
    Private gridIndex As Integer

    Private Sub sykkelEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()

        Dim payload As New DataTable

        payload = db.query("SELECT * FROM virksomhet")
        With cbxSted
            .DisplayMember = "navn"
            .DataSource = payload
        End With

        payload = db.query("SELECT * FROM sykkeltype")
        With cbxType
            .DisplayMember = "sykkeltype"
            .DataSource = payload
        End With

    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SykkelGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim payload As New DataTable
        Dim sql As String
        If Not sok = Nothing Then
            sql = "SELECT * FROM sykkel WHERE rammenr LIKE '%" & sok & "%'"
        Else
            sql = "SELECT * FROM sykkel"
        End If
        payload = db.query(sql)
        SykkelGridView.DataSource = payload

        With Me.SykkelGridView
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("status").HeaderText = "Status"
            .Columns("avviksmelding").HeaderText = "Avviksmelding"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("virksomhet_id").Visible = False
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub oppdaterTxtbox()
        gridIndex = SykkelGridView.CurrentRow.Index()

        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.SykkelGridView
            txtRammenr.Text = .Rows(gridIndex).Cells("rammenr").Value
            
            txtAvvik.Text = .Rows(gridIndex).Cells("avviksmelding").Value

        End With
    End Sub



    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        oppdaterGridView(txtSok.Text)
    End Sub
End Class