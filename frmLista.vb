Public Class frmLista

    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Show()
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim itm As ListViewItem

        da.Fill(ds, SchemaType.Mapped)

        For i = 0 To ds.Tables("Fakturor").Rows.Count - 1
            'itm = lvwFakturor.Items.Add(ds.Tables("Fakturor").Rows(i)("id"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Fornamn"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Efternamn"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Adress"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Postnr"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Ort"))
            'itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Datum"))
        Next
    End Sub
End Class