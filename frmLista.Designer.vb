<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvwFakturaRader = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRaderaRad = New System.Windows.Forms.Button()
        Me.btnSparaRad = New System.Windows.Forms.Button()
        Me.btnNyRad = New System.Windows.Forms.Button()
        Me.txtSumma = New System.Windows.Forms.TextBox()
        Me.txtBeskrivning = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lvwFakturaRader
        '
        Me.lvwFakturaRader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFakturaRader.FullRowSelect = True
        Me.lvwFakturaRader.GridLines = True
        Me.lvwFakturaRader.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwFakturaRader.HideSelection = False
        Me.lvwFakturaRader.Location = New System.Drawing.Point(12, 80)
        Me.lvwFakturaRader.MultiSelect = False
        Me.lvwFakturaRader.Name = "lvwFakturaRader"
        Me.lvwFakturaRader.Size = New System.Drawing.Size(948, 721)
        Me.lvwFakturaRader.TabIndex = 20
        Me.lvwFakturaRader.UseCompatibleStateImageBehavior = False
        Me.lvwFakturaRader.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Summa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Beskrivning"
        '
        'btnRaderaRad
        '
        Me.btnRaderaRad.Location = New System.Drawing.Point(848, 12)
        Me.btnRaderaRad.Name = "btnRaderaRad"
        Me.btnRaderaRad.Size = New System.Drawing.Size(112, 34)
        Me.btnRaderaRad.TabIndex = 31
        Me.btnRaderaRad.Text = "Radera"
        Me.btnRaderaRad.UseVisualStyleBackColor = True
        '
        'btnSparaRad
        '
        Me.btnSparaRad.Location = New System.Drawing.Point(730, 12)
        Me.btnSparaRad.Name = "btnSparaRad"
        Me.btnSparaRad.Size = New System.Drawing.Size(112, 34)
        Me.btnSparaRad.TabIndex = 30
        Me.btnSparaRad.Text = "Spara"
        Me.btnSparaRad.UseVisualStyleBackColor = True
        '
        'btnNyRad
        '
        Me.btnNyRad.Location = New System.Drawing.Point(612, 12)
        Me.btnNyRad.Name = "btnNyRad"
        Me.btnNyRad.Size = New System.Drawing.Size(112, 34)
        Me.btnNyRad.TabIndex = 29
        Me.btnNyRad.Text = "Ny Rad"
        Me.btnNyRad.UseVisualStyleBackColor = True
        '
        'txtSumma
        '
        Me.txtSumma.Location = New System.Drawing.Point(131, 43)
        Me.txtSumma.Name = "txtSumma"
        Me.txtSumma.Size = New System.Drawing.Size(459, 31)
        Me.txtSumma.TabIndex = 28
        '
        'txtBeskrivning
        '
        Me.txtBeskrivning.Location = New System.Drawing.Point(131, 12)
        Me.txtBeskrivning.Name = "txtBeskrivning"
        Me.txtBeskrivning.Size = New System.Drawing.Size(459, 31)
        Me.txtBeskrivning.TabIndex = 27
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 813)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRaderaRad)
        Me.Controls.Add(Me.btnSparaRad)
        Me.Controls.Add(Me.btnNyRad)
        Me.Controls.Add(Me.txtSumma)
        Me.Controls.Add(Me.txtBeskrivning)
        Me.Controls.Add(Me.lvwFakturaRader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLista"
        Me.Text = "frmLista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwFakturaRader As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRaderaRad As Button
    Friend WithEvents btnSparaRad As Button
    Friend WithEvents btnNyRad As Button
    Friend WithEvents txtSumma As TextBox
    Friend WithEvents txtBeskrivning As TextBox
End Class
