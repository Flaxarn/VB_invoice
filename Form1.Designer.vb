<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFornamn = New System.Windows.Forms.TextBox()
        Me.txtEfternamn = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnNy = New System.Windows.Forms.Button()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.btnForegaende = New System.Windows.Forms.Button()
        Me.btnSista = New System.Windows.Forms.Button()
        Me.btnNasta = New System.Windows.Forms.Button()
        Me.btnForsta = New System.Windows.Forms.Button()
        Me.lvwFakturarader = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.CI1 = New System.Windows.Forms.ColumnHeader()
        Me.CI2 = New System.Windows.Forms.ColumnHeader()
        Me.CI4 = New System.Windows.Forms.ColumnHeader()
        Me.CI3 = New System.Windows.Forms.ColumnHeader()
        Me.CI5 = New System.Windows.Forms.ColumnHeader()
        Me.CI6 = New System.Windows.Forms.ColumnHeader()
        Me.btnRadera = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Förnamn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Efternamn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ort"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PostNr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Datum"
        '
        'txtFornamn
        '
        Me.txtFornamn.Location = New System.Drawing.Point(116, 9)
        Me.txtFornamn.Name = "txtFornamn"
        Me.txtFornamn.Size = New System.Drawing.Size(300, 31)
        Me.txtFornamn.TabIndex = 6
        '
        'txtEfternamn
        '
        Me.txtEfternamn.Location = New System.Drawing.Point(116, 46)
        Me.txtEfternamn.Name = "txtEfternamn"
        Me.txtEfternamn.Size = New System.Drawing.Size(300, 31)
        Me.txtEfternamn.TabIndex = 8
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(116, 83)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(300, 31)
        Me.txtAdress.TabIndex = 10
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(116, 120)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(300, 31)
        Me.txtOrt.TabIndex = 11
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(116, 157)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(300, 31)
        Me.txtPostnr.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 197)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePicker1.TabIndex = 13
        '
        'btnNy
        '
        Me.btnNy.Location = New System.Drawing.Point(540, 12)
        Me.btnNy.Name = "btnNy"
        Me.btnNy.Size = New System.Drawing.Size(112, 34)
        Me.btnNy.TabIndex = 14
        Me.btnNy.Text = "Ny"
        Me.btnNy.UseVisualStyleBackColor = True
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(540, 52)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(112, 34)
        Me.btnSpara.TabIndex = 15
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPost)
        Me.GroupBox1.Controls.Add(Me.btnForegaende)
        Me.GroupBox1.Controls.Add(Me.btnSista)
        Me.GroupBox1.Controls.Add(Me.btnNasta)
        Me.GroupBox1.Controls.Add(Me.btnForsta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 631)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 111)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(303, 45)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(150, 31)
        Me.txtPost.TabIndex = 4
        Me.txtPost.Text = "txtPost"
        '
        'btnForegaende
        '
        Me.btnForegaende.Location = New System.Drawing.Point(89, 30)
        Me.btnForegaende.Name = "btnForegaende"
        Me.btnForegaende.Size = New System.Drawing.Size(60, 60)
        Me.btnForegaende.TabIndex = 3
        Me.btnForegaende.Text = "<"
        Me.btnForegaende.UseVisualStyleBackColor = True
        '
        'btnSista
        '
        Me.btnSista.Location = New System.Drawing.Point(710, 30)
        Me.btnSista.Name = "btnSista"
        Me.btnSista.Size = New System.Drawing.Size(60, 60)
        Me.btnSista.TabIndex = 2
        Me.btnSista.Text = ">>"
        Me.btnSista.UseVisualStyleBackColor = True
        '
        'btnNasta
        '
        Me.btnNasta.Location = New System.Drawing.Point(644, 30)
        Me.btnNasta.Name = "btnNasta"
        Me.btnNasta.Size = New System.Drawing.Size(60, 60)
        Me.btnNasta.TabIndex = 1
        Me.btnNasta.Text = ">"
        Me.btnNasta.UseVisualStyleBackColor = True
        '
        'btnForsta
        '
        Me.btnForsta.Location = New System.Drawing.Point(23, 30)
        Me.btnForsta.Name = "btnForsta"
        Me.btnForsta.Size = New System.Drawing.Size(60, 60)
        Me.btnForsta.TabIndex = 0
        Me.btnForsta.Text = "<<"
        Me.btnForsta.UseVisualStyleBackColor = True
        '
        'lvwFakturarader
        '
        Me.lvwFakturarader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFakturarader.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.CI1, Me.CI2, Me.CI4, Me.CI3, Me.CI5, Me.CI6})
        Me.lvwFakturarader.FullRowSelect = True
        Me.lvwFakturarader.GridLines = True
        Me.lvwFakturarader.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwFakturarader.HideSelection = False
        Me.lvwFakturarader.Location = New System.Drawing.Point(12, 234)
        Me.lvwFakturarader.MultiSelect = False
        Me.lvwFakturarader.Name = "lvwFakturarader"
        Me.lvwFakturarader.Size = New System.Drawing.Size(776, 391)
        Me.lvwFakturarader.TabIndex = 17
        Me.lvwFakturarader.UseCompatibleStateImageBehavior = False
        Me.lvwFakturarader.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 30
        '
        'CI1
        '
        Me.CI1.Text = "Förnamn"
        Me.CI1.Width = 123
        '
        'CI2
        '
        Me.CI2.Text = "Efternamn"
        Me.CI2.Width = 123
        '
        'CI4
        '
        Me.CI4.Text = "Adress"
        Me.CI4.Width = 123
        '
        'CI3
        '
        Me.CI3.Text = "Ort"
        Me.CI3.Width = 123
        '
        'CI5
        '
        Me.CI5.Text = "PostNr"
        Me.CI5.Width = 123
        '
        'CI6
        '
        Me.CI6.Text = "Datum"
        Me.CI6.Width = 123
        '
        'btnRadera
        '
        Me.btnRadera.Location = New System.Drawing.Point(540, 93)
        Me.btnRadera.Name = "btnRadera"
        Me.btnRadera.Size = New System.Drawing.Size(112, 34)
        Me.btnRadera.TabIndex = 18
        Me.btnRadera.Text = "Radera"
        Me.btnRadera.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 754)
        Me.Controls.Add(Me.btnRadera)
        Me.Controls.Add(Me.lvwFakturarader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.btnNy)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtEfternamn)
        Me.Controls.Add(Me.txtFornamn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmStart"
        Me.Text = "Faktura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFornamn As TextBox
    Friend WithEvents txtEfternamn As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnNy As Button
    Friend WithEvents btnSpara As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPost As TextBox
    Friend WithEvents btnForegaende As Button
    Friend WithEvents btnSista As Button
    Friend WithEvents btnNasta As Button
    Friend WithEvents btnForsta As Button
    Friend WithEvents lvwFakturarader As ListView
    Friend WithEvents btnRadera As Button
    Friend WithEvents CI1 As ColumnHeader
    Friend WithEvents CI2 As ColumnHeader
    Friend WithEvents CI4 As ColumnHeader
    Friend WithEvents CI3 As ColumnHeader
    Friend WithEvents CI5 As ColumnHeader
    Friend WithEvents CI6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
