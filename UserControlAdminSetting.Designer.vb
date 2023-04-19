<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlAdminSetting
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        PictureBox1 = New PictureBox()
        btnDeleteUL = New FontAwesome.Sharp.IconButton()
        btnUpdateUL = New FontAwesome.Sharp.IconButton()
        btnSaveUL = New FontAwesome.Sharp.IconButton()
        tbUserName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        lblS = New Label()
        tbPassword = New TextBox()
        lblSelectedID = New Label()
        cbType = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        dgvUserDetails = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvUserDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLight
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(387, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' btnDeleteUL
        ' 
        btnDeleteUL.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnDeleteUL.Cursor = Cursors.Hand
        btnDeleteUL.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnDeleteUL.FlatAppearance.BorderSize = 0
        btnDeleteUL.FlatAppearance.MouseDownBackColor = Color.White
        btnDeleteUL.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDeleteUL.FlatStyle = FlatStyle.Flat
        btnDeleteUL.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteUL.ForeColor = Color.White
        btnDeleteUL.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDeleteUL.IconColor = Color.White
        btnDeleteUL.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnDeleteUL.IconSize = 20
        btnDeleteUL.Location = New Point(289, 345)
        btnDeleteUL.Name = "btnDeleteUL"
        btnDeleteUL.Size = New Size(150, 35)
        btnDeleteUL.TabIndex = 22
        btnDeleteUL.Text = "DELETE"
        btnDeleteUL.TextAlign = ContentAlignment.MiddleRight
        btnDeleteUL.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteUL.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateUL
        ' 
        btnUpdateUL.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnUpdateUL.Cursor = Cursors.Hand
        btnUpdateUL.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnUpdateUL.FlatAppearance.BorderSize = 0
        btnUpdateUL.FlatAppearance.MouseDownBackColor = Color.White
        btnUpdateUL.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnUpdateUL.FlatStyle = FlatStyle.Flat
        btnUpdateUL.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdateUL.ForeColor = Color.White
        btnUpdateUL.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        btnUpdateUL.IconColor = Color.White
        btnUpdateUL.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnUpdateUL.IconSize = 20
        btnUpdateUL.Location = New Point(289, 301)
        btnUpdateUL.Name = "btnUpdateUL"
        btnUpdateUL.Size = New Size(150, 35)
        btnUpdateUL.TabIndex = 21
        btnUpdateUL.Text = "UPDATE"
        btnUpdateUL.TextAlign = ContentAlignment.MiddleRight
        btnUpdateUL.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdateUL.UseVisualStyleBackColor = False
        ' 
        ' btnSaveUL
        ' 
        btnSaveUL.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnSaveUL.Cursor = Cursors.Hand
        btnSaveUL.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnSaveUL.FlatAppearance.BorderSize = 0
        btnSaveUL.FlatAppearance.MouseDownBackColor = Color.White
        btnSaveUL.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnSaveUL.FlatStyle = FlatStyle.Flat
        btnSaveUL.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveUL.ForeColor = Color.White
        btnSaveUL.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        btnSaveUL.IconColor = Color.White
        btnSaveUL.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSaveUL.IconSize = 20
        btnSaveUL.Location = New Point(289, 257)
        btnSaveUL.Name = "btnSaveUL"
        btnSaveUL.Size = New Size(150, 35)
        btnSaveUL.TabIndex = 20
        btnSaveUL.Text = "SAVE"
        btnSaveUL.TextAlign = ContentAlignment.MiddleRight
        btnSaveUL.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSaveUL.UseVisualStyleBackColor = False
        ' 
        ' tbUserName
        ' 
        tbUserName.Location = New Point(235, 83)
        tbUserName.Name = "tbUserName"
        tbUserName.Size = New Size(204, 23)
        tbUserName.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 4
        Label2.Text = "USERNAME"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(78, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 24)
        Label1.TabIndex = 3
        Label1.Text = "USER LOGIN"' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(lblS)
        Panel1.Controls.Add(tbPassword)
        Panel1.Controls.Add(lblSelectedID)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnDeleteUL)
        Panel1.Controls.Add(btnUpdateUL)
        Panel1.Controls.Add(btnSaveUL)
        Panel1.Controls.Add(cbType)
        Panel1.Controls.Add(tbUserName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(478, 661)
        Panel1.TabIndex = 1
        ' 
        ' lblS
        ' 
        lblS.AutoSize = True
        lblS.ForeColor = SystemColors.ControlLight
        lblS.Location = New Point(170, 311)
        lblS.Name = "lblS"
        lblS.Size = New Size(41, 15)
        lblS.TabIndex = 26
        lblS.Text = "Label5"' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(235, 131)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(204, 23)
        tbPassword.TabIndex = 25
        ' 
        ' lblSelectedID
        ' 
        lblSelectedID.AutoSize = True
        lblSelectedID.BackColor = Color.Transparent
        lblSelectedID.ForeColor = Color.Transparent
        lblSelectedID.Location = New Point(395, 459)
        lblSelectedID.Name = "lblSelectedID"
        lblSelectedID.Size = New Size(0, 15)
        lblSelectedID.TabIndex = 24
        ' 
        ' cbType
        ' 
        cbType.FormattingEnabled = True
        cbType.Location = New Point(235, 179)
        cbType.Name = "cbType"
        cbType.Size = New Size(204, 23)
        cbType.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(99, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 15)
        Label4.TabIndex = 6
        Label4.Text = "TYPE"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(99, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 5
        Label3.Text = "PASSWORD"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(dgvUserDetails)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(478, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(668, 661)
        Panel2.TabIndex = 2
        ' 
        ' dgvUserDetails
        ' 
        dgvUserDetails.AllowUserToAddRows = False
        dgvUserDetails.AllowUserToDeleteRows = False
        dgvUserDetails.BackgroundColor = SystemColors.ActiveCaption
        dgvUserDetails.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUserDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUserDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUserDetails.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUserDetails.DefaultCellStyle = DataGridViewCellStyle2
        dgvUserDetails.GridColor = SystemColors.ActiveCaption
        dgvUserDetails.Location = New Point(23, 24)
        dgvUserDetails.Name = "dgvUserDetails"
        dgvUserDetails.ReadOnly = True
        dgvUserDetails.RowHeadersWidth = 4
        dgvUserDetails.RowTemplate.Height = 25
        dgvUserDetails.Size = New Size(608, 624)
        dgvUserDetails.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "USERNAME"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "PASSWORD"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "TYPE"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 200
        ' 
        ' UserControlAdminSetting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlAdminSetting"
        Size = New Size(1146, 661)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvUserDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeleteUL As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateUL As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveUL As FontAwesome.Sharp.IconButton
    Friend WithEvents tbUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelectedID As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvUserDetails As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblS As Label
End Class
