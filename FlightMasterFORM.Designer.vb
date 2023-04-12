<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightMasterFORM
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        dgvAir = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        lblCode = New Label()
        Panel4 = New Panel()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label6 = New Label()
        btnDelete = New FontAwesome.Sharp.IconButton()
        tbName = New TextBox()
        btnUpdate = New FontAwesome.Sharp.IconButton()
        btnSave = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        Label2 = New Label()
        tbCode = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvAir, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(484, 561)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dgvAir)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(5)
        Panel3.Size = New Size(284, 561)
        Panel3.TabIndex = 1
        ' 
        ' dgvAir
        ' 
        dgvAir.AllowUserToAddRows = False
        dgvAir.AllowUserToDeleteRows = False
        dgvAir.BackgroundColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAir.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAir.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvAir.Dock = DockStyle.Fill
        dgvAir.Location = New Point(5, 5)
        dgvAir.Name = "dgvAir"
        dgvAir.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvAir.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvAir.RowHeadersWidth = 4
        dgvAir.RowTemplate.Height = 25
        dgvAir.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAir.Size = New Size(274, 551)
        dgvAir.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "AIRLINE CODE"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "AIRLINE NAME"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 168
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(lblCode)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(tbName)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(tbCode)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 561)
        Panel2.TabIndex = 0
        ' 
        ' lblCode
        ' 
        lblCode.AutoSize = True
        lblCode.ForeColor = SystemColors.ActiveCaptionText
        lblCode.Location = New Point(139, 373)
        lblCode.Name = "lblCode"
        lblCode.Size = New Size(0, 15)
        lblCode.TabIndex = 24
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Panel4.Controls.Add(IconPictureBox2)
        Panel4.Controls.Add(IconPictureBox1)
        Panel4.Controls.Add(Label6)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 35)
        Panel4.TabIndex = 23
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Gear
        IconPictureBox2.IconColor = Color.White
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconPictureBox2.IconSize = 21
        IconPictureBox2.Location = New Point(177, 9)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(21, 26)
        IconPictureBox2.TabIndex = 10
        IconPictureBox2.TabStop = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        IconPictureBox1.IconColor = Color.White
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 21
        IconPictureBox1.Location = New Point(373, 7)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(21, 26)
        IconPictureBox1.TabIndex = 9
        IconPictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(25, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 0
        Label6.Text = "AIRLINES "' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.White
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDelete.IconColor = Color.White
        btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnDelete.IconSize = 20
        btnDelete.Location = New Point(22, 306)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(150, 35)
        btnDelete.TabIndex = 22
        btnDelete.Text = "DELETE"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(22, 151)
        tbName.Name = "tbName"
        tbName.Size = New Size(153, 23)
        tbName.TabIndex = 4
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.White
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        btnUpdate.IconColor = Color.White
        btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnUpdate.IconSize = 20
        btnUpdate.Location = New Point(22, 262)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(150, 35)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "UPDATE"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.White
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        btnSave.IconColor = Color.White
        btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSave.IconSize = 20
        btnSave.Location = New Point(22, 218)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 35)
        btnSave.TabIndex = 20
        btnSave.Text = "SAVE"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 3
        Label3.Text = "AIRLINE NAME"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 2
        Label2.Text = "AIRLINE CODE"' 
        ' tbCode
        ' 
        tbCode.Location = New Point(22, 86)
        tbCode.Name = "tbCode"
        tbCode.Size = New Size(153, 23)
        tbCode.TabIndex = 1
        ' 
        ' FlightMasterFORM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 561)
        Controls.Add(Panel1)
        Name = "FlightMasterFORM"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "AIRLINES DETAILS SETTINGS"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(dgvAir, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCode As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents dgvAir As DataGridView
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblCode As Label
End Class
