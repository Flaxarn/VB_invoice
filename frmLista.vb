Public Class frmLista
    Dim recordCount As Integer
    Dim postNr As Integer
    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Show()
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim itm As ListViewItem
        Dim sql As String



        ' ny sql för fakturarader
        sql = "SELECT fr.ID, fr.Beskrivning, fr.Summa from fakturaRader fr inner join fakturor f on fr.fakturaID = f.ID where f.ID = " & fakturaID
        'sql = "SELECT id, beskrivning, summa from fakturaRader;"

        ' Koppla och fyll dataadaptern
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Fakturarader")
        da.Fill(ds, SchemaType.Mapped)


        'räkna antalet poster
        recordCount = ds.Tables("Fakturarader").Rows.Count

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
    End Sub
End Class