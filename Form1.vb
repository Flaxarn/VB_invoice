Public Class frmStart
    ' Globala variabler
    Dim recordCount As Integer
    Dim postNr As Integer

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Koppla databas 
        dbConnect()

        ' Räkna antal poster
        recordCount = ds.Tables("Fakturor").Rows.Count
        txtPost.MaxLength = Math.Ceiling(Math.Log10(recordCount)) ' Ändra längd på inmatning av textruta efter hur många poster som finns
        postNr = 0
        fyllFormular(postNr)
        fyllLista()
    End Sub

    Public Sub fyllLista()
        Dim itm As ListViewItem

        lvwFakturor.Items.Clear()
        da.Fill(ds, SchemaType.Mapped)

        For i = 0 To ds.Tables("Fakturor").Rows.Count - 1
            itm = lvwFakturor.Items.Add(ds.Tables("Fakturor").Rows(i)("id"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Fornamn"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Efternamn"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Adress"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Postnr"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Ort"))
            itm.SubItems.Add(ds.Tables("Fakturor").Rows(i)("Datum"))
        Next
    End Sub
    Public Sub fyllFormular(postNr As Integer)

        ' Hantera felaktiga postinmatningar
        If postNr > recordCount - 1 Then
            postNr = recordCount - 1
        ElseIf postNr < 0 Then
            postNr = 0
        End If

        ' Sätt globala variablen
        Me.postNr = postNr ' me.posNr

        ' Fyll formulär
        txtFornamn.Text = ds.Tables("Fakturor").Rows(postNr)("Fornamn")
        txtEfternamn.Text = ds.Tables("Fakturor").Rows(postNr)("Efternamn")
        txtAdress.Text = ds.Tables("Fakturor").Rows(postNr)("Adress")
        txtPostnr.Text = ds.Tables("Fakturor").Rows(postNr)("Postnr")
        txtOrt.Text = ds.Tables("Fakturor").Rows(postNr)("Ort")
        DateTimePicker1.Text = ds.Tables("Fakturor").Rows(postNr)("Datum")

        ' Visa aktuellt postNr ( svåra varianten ^^ )
        txtPost.Text = postNr + 1

        ' Hantera knappar
        hanteraKnappar(postNr)


        'fakturaID = ds.Tables("Fakturor").Rows(postNr)("Id")
    End Sub

    Private Sub hanteraKnappar(postNr As Integer)

        ' Hantera enable/disable för knappar
        btnForsta.Enabled = Not (postNr = 0)
        btnForegaende.Enabled = Not (postNr = 0)

        btnSista.Enabled = Not (postNr = (recordCount - 1))
        btnNasta.Enabled = Not (postNr = (recordCount - 1))

        If postNr = -1 Then
            btnRadera.Enabled = False
        Else
            btnRadera.Enabled = True
        End If
    End Sub

    Private Sub btnForsta_Click(sender As Object, e As EventArgs) Handles btnForsta.Click

        postNr = 0
        fyllFormular(postNr)
    End Sub

    Private Sub btnForegaende_Click(sender As Object, e As EventArgs) Handles btnForegaende.Click

        postNr = postNr - 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnNasta_Click(sender As Object, e As EventArgs) Handles btnNasta.Click

        postNr = postNr + 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnSista_Click(sender As Object, e As EventArgs) Handles btnSista.Click

        postNr = recordCount - 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_Leave(sender As Object, e As EventArgs) Handles txtPost.Leave

        Dim input As Integer
        input = Val(txtPost.Text)
        postNr = input - 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtPost_Leave(sender, e)
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        saveData()
    End Sub

    Private Sub saveData()

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dbRow As DataRow

        ' Kontroller om ny post eller befintlig
        If postNr = -1 Then
            dbRow = ds.Tables("Fakturor").NewRow
            dbRow.Item("Datum") = Now
        Else
            dbRow = ds.Tables("Fakturor").Rows(postNr)
        End If

        ' Tilldela databasraden nya värden
        dbRow.Item("Fornamn") = txtFornamn.Text
        dbRow.Item("Efternamn") = txtEfternamn.Text
        dbRow.Item("Adress") = txtAdress.Text
        dbRow.Item("Ort") = txtOrt.Text
        dbRow.Item("Postnr") = txtPostnr.Text

        ' Uppdatera databasadaptern om ny post
        If postNr = -1 Then
            ds.Tables("Fakturor").Rows.Add(dbRow)
            postNr = ds.Tables("Fakturor").Rows.Count - 1
            recordCount = ds.Tables("Fakturor").Rows.Count
        End If

        ' Uppdatera databasraden
        da.Update(ds, "Fakturor")

        ' Visa posten
        fyllFormular(postNr)
        fyllLista()
    End Sub

    Private Sub btnNy_Click(sender As Object, e As EventArgs) Handles btnNy.Click

        ' Töm formulär
        txtFornamn.Text = ""
        txtEfternamn.Text = ""
        txtAdress.Text = ""
        txtPostnr.Text = ""
        txtOrt.Text = ""
        DateTimePicker1.Text = Now

        ' Indikera ny post
        postNr = -1

        ' Släck alla knappar
        hanteraKnappar(postNr)
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click

        If MsgBox("Vill du radera posten?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Radera FAktura!") = MsgBoxResult.Yes Then
            raderaPost()
        End If
    End Sub

    Private Sub raderaPost()

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ' Ta bort posten från datasetet och uppdatera dataadaptern
        ds.Tables("Fakturor").Rows(postNr).Delete()
        da.Update(ds, "Fakturor")

        recordCount = ds.Tables("Fakturor").Rows.Count
        If postNr >= recordCount Then
            postNr = recordCount - 1
        End If

        ' Visa följande post
        fyllFormular(postNr)
        fyllLista()

        MsgBox("Borta!")
    End Sub

    Private Sub btnVisarader_Click(sender As Object, e As EventArgs) Handles btnVisarader.Click
        fakturaID = ds.Tables("Fakturor").Rows(postNr)("Id")
        frmLista.Show()
        Me.Hide()
    End Sub

    Private Sub lvwFakturor_DoubleClick(sender As Object, e As EventArgs) Handles lvwFakturor.DoubleClick
        andraPost()
        visaFakturarader()
    End Sub

    Private Sub lvwFakturor_Click(sender As Object, e As EventArgs) Handles lvwFakturor.Click
        andraPost()
    End Sub

    Private Sub andraPost()
        Dim rad As Integer = lvwFakturor.SelectedIndices(0)

        postNr = rad
        fyllFormular(postNr)
    End Sub

    Private Sub visaFakturarader()
        fakturaID = ds.Tables("Fakturor").Rows(postNr)("Id")
        frmLista.Show()
        Me.Hide()
    End Sub
End Class
