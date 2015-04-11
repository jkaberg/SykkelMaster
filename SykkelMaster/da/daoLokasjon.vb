Public Class daoLokasjon
    Public Shared sql As String

    Public Shared Function leggTilLokasjon(ByVal lokasjon As clsLokasjon) As Boolean
        sql = "INSERT INTO virksomhet(navn, telefon, mail, adresse, post_nr) VALUES ('" & lokasjon.pNavn & "', '" & lokasjon.pTlfnr & "', '" & lokasjon.pMail & "', '" & lokasjon.pAdresse & "', " & lokasjon.pPostnr & ");"

        Return database.query(sql)
    End Function

    Public Shared Function oppdaterLokasjon(ByVal lokasjon As clsLokasjon) As Boolean
        sql = "UPDATE virksomhet SET navn = '" & lokasjon.pNavn & "', telefon = '" & lokasjon.pTlfnr & "', mail = '" & lokasjon.pMail & "', adresse = '" & lokasjon.pAdresse & "', post_nr = '" & lokasjon.pPostnr & "' WHERE id = '" & lokasjon.pID & "';"

        Return database.query(sql)
    End Function

    Public Shared Function fjernLokasjon(ByVal lokasjon As clsLokasjon) As Boolean
        sql = "DELETE FROM sykkelmaster2015.virksomhet WHERE virksomhet.id = '" & lokasjon.pID & "'"

        Return database.query(sql)
    End Function

    Public Shared Function hentLokasjoner(Optional ByVal sok As String = Nothing) As DataTable
        If Not sok = Nothing Then
            sql = "SELECT * FROM virksomhet WHERE fornavn LIKE '%" & sok & "%' OR telefon LIKE '%" & sok & "%'"
        Else
            sql = "SELECT * FROM virksomhet"
        End If

        Return database.dt_query(sql)
    End Function
End Class
