Public Class frmLista
    Dim recordCount As Integer
    Dim postNr As Integer ' Behövs detta?

    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Show()
        ds.Tables.Remove("Fakturarader")
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        postNr = 0
        fyllFormular()
    End Sub
    Private Sub fyllFormular()
        Dim itm As ListViewItem
        Dim sql As String
        Dim daLocal As OleDb.OleDbDataAdapter            ' Uppdatera tabeller


        ' ny sql för fakturarader
        sql = "SELECT fr.ID, fr.Beskrivning, fr.Summa from fakturaRader fr inner join fakturor f on fr.fakturaID = f.ID where f.ID = " & fakturaID
        'sql = "SELECT id, beskrivning, summa from fakturaRader;"

        ' Koppla och fyll dataadaptern
        daLocal = New OleDb.OleDbDataAdapter(sql, con)
        daLocal.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daLocal.Fill(ds, "Fakturarader")
        daLocal.Fill(ds, SchemaType.Mapped)


        'räkna antalet poster
        recordCount = ds.Tables("Fakturarader").Rows.Count


        '''  Behövs detta?
        ' Hantera felaktiga postinmatningar
        If postNr > recordCount - 1 Then
            postNr = recordCount - 1
        ElseIf postNr < 0 Then
            postNr = 0
        End If


        ' Rensa listan
        lvwFakturaRader.Items.Clear()

        ' Fyll listan
        For i = 0 To ds.Tables("FakturaRader").Rows.Count - 1
            itm = lvwFakturaRader.Items.Add(ds.Tables("Fakturarader").Rows(i)("id"))
            itm.SubItems.Add(ds.Tables("Fakturarader").Rows(i)("Beskrivning"))
            itm.SubItems.Add(ds.Tables("Fakturarader").Rows(i)("Summa"))

        Next

        recordCount = ds.Tables("Fakturarader").Rows.Count
    End Sub

    Private Sub btnSparaRad_Click(sender As Object, e As EventArgs) Handles btnSparaRad.Click
        saveData()
    End Sub

    Private Sub saveData()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dbRow As DataRow

        ' Kontroller om ny post eller befintlig
        If postNr = -1 Then
            dbRow = ds.Tables("Fakturarader").NewRow
        Else
            dbRow = ds.Tables("Fakturarader").Rows()("ID")
        End If

        ' Tilldela databasraden nya värden
        dbRow.Item("Beskrivning") = txtBeskrivning.Text
        dbRow.Item("Summa") = txtSumma.Text

        ' Uppdatera databasadaptern om ny post
        If postNr = -1 Then
            ds.Tables("Fakturarader").Rows.Add(dbRow)
            postNr = ds.Tables("Fakturarader").Rows.Count - 1
            recordCount = ds.Tables("Fakturarader").Rows.Count
        End If

        ' Uppdatera databasraden
        da.Update(ds, "Fakturarader")

        ' Visa posten
        fyllFormular()
    End Sub
End Class