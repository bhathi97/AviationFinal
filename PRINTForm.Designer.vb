<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINTForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        shiftShower = New Label()
        dayShower = New Label()
        Label4 = New Label()
        Label3 = New Label()
        shiftTimeShower = New Label()
        dateShower = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgPrint = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Label7 = New Label()
        btnPrintDoc = New FontAwesome.Sharp.IconButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPrint, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(78, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(454, 19)
        Label5.TabIndex = 49
        Label5.Text = "CEYLON PETROLEUM CORPORATION - AVIATION FUNCTION"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.Location = New Point(189, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(242, 22)
        Label6.TabIndex = 50
        Label6.Text = "DAILY WORK SCHEDULE"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(12, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 51
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.logo
        PictureBox2.Location = New Point(508, 31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 52
        PictureBox2.TabStop = False
        ' 
        ' shiftShower
        ' 
        shiftShower.AutoSize = True
        shiftShower.Location = New Point(428, 97)
        shiftShower.Name = "shiftShower"
        shiftShower.Size = New Size(41, 15)
        shiftShower.TabIndex = 66
        shiftShower.Text = "Label7"' 
        ' dayShower
        ' 
        dayShower.AutoSize = True
        dayShower.Location = New Point(428, 78)
        dayShower.Name = "dayShower"
        dayShower.Size = New Size(41, 15)
        dayShower.TabIndex = 65
        dayShower.Text = "Label7"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(368, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 64
        Label4.Text = "SHIFT :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(368, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 63
        Label3.Text = "DAY :"' 
        ' shiftTimeShower
        ' 
        shiftTimeShower.AutoSize = True
        shiftTimeShower.Location = New Point(214, 97)
        shiftTimeShower.Name = "shiftTimeShower"
        shiftTimeShower.Size = New Size(41, 15)
        shiftTimeShower.TabIndex = 62
        shiftTimeShower.Text = "Label3"' 
        ' dateShower
        ' 
        dateShower.AutoSize = True
        dateShower.Location = New Point(214, 78)
        dateShower.Name = "dateShower"
        dateShower.Size = New Size(41, 15)
        dateShower.TabIndex = 61
        dateShower.Text = "Label3"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(126, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 60
        Label2.Text = "SHIFT TIME :"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(126, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 59
        Label1.Text = "DATE  :"' 
        ' dgPrint
        ' 
        dgPrint.AllowUserToAddRows = False
        dgPrint.AllowUserToDeleteRows = False
        dgPrint.BackgroundColor = SystemColors.Window
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgPrint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPrint.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column10, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgPrint.DefaultCellStyle = DataGridViewCellStyle2
        dgPrint.Location = New Point(0, 120)
        dgPrint.Name = "dgPrint"
        dgPrint.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgPrint.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgPrint.RowHeadersWidth = 5
        dgPrint.RowTemplate.Height = 20
        dgPrint.Size = New Size(618, 517)
        dgPrint.TabIndex = 67
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.HeaderText = "BAY NO"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 40
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NO"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 30
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "FLIGHT"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 60
        ' 
        ' Column10
        ' 
        Column10.FillWeight = 60F
        Column10.HeaderText = "ROUTE"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 60
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "E.T.A"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 50
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "AIRLINES"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "RIC"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 55
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "OPERATOR"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 70
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "CREWMAN"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 70
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "REMARKS"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 80
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 650)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 15)
        Label7.TabIndex = 68
        Label7.Text = "Ready to Print?"' 
        ' btnPrintDoc
        ' 
        btnPrintDoc.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnPrintDoc.Cursor = Cursors.Hand
        btnPrintDoc.FlatAppearance.BorderSize = 0
        btnPrintDoc.FlatAppearance.MouseDownBackColor = Color.White
        btnPrintDoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnPrintDoc.FlatStyle = FlatStyle.Flat
        btnPrintDoc.IconChar = FontAwesome.Sharp.IconChar.Print
        btnPrintDoc.IconColor = Color.White
        btnPrintDoc.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPrintDoc.IconSize = 25
        btnPrintDoc.Location = New Point(206, 664)
        btnPrintDoc.Name = "btnPrintDoc"
        btnPrintDoc.Size = New Size(213, 45)
        btnPrintDoc.TabIndex = 69
        btnPrintDoc.UseVisualStyleBackColor = False
        ' 
        ' PRINTForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(620, 735)
        Controls.Add(btnPrintDoc)
        Controls.Add(Label7)
        Controls.Add(dgPrint)
        Controls.Add(shiftShower)
        Controls.Add(dayShower)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(shiftTimeShower)
        Controls.Add(dateShower)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        MaximumSize = New Size(636, 774)
        Name = "PRINTForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRINT PREVIEW"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPrint, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents shiftShower As Label
    Friend WithEvents dayShower As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents shiftTimeShower As Label
    Friend WithEvents dateShower As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgPrint As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPrintDoc As FontAwesome.Sharp.IconButton
End Class
