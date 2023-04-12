<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlCREW
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        lblSelectedID = New Label()
        PictureBox1 = New PictureBox()
        btnDeleteCM = New FontAwesome.Sharp.IconButton()
        btnUpdateCM = New FontAwesome.Sharp.IconButton()
        btnSaveCM = New FontAwesome.Sharp.IconButton()
        cbPosition = New ComboBox()
        cbGroup = New ComboBox()
        tbName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        dgvCrew = New DataGridView()
        AID = New DataGridViewTextBoxColumn()
        AName = New DataGridViewTextBoxColumn()
        AGroup = New DataGridViewTextBoxColumn()
        APosition = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvCrew, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(lblSelectedID)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnDeleteCM)
        Panel1.Controls.Add(btnUpdateCM)
        Panel1.Controls.Add(btnSaveCM)
        Panel1.Controls.Add(cbPosition)
        Panel1.Controls.Add(cbGroup)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(478, 632)
        Panel1.TabIndex = 0
        ' 
        ' lblSelectedID
        ' 
        lblSelectedID.AutoSize = True
        lblSelectedID.BackColor = Color.Transparent
        lblSelectedID.ForeColor = Color.IndianRed
        lblSelectedID.Location = New Point(385, 449)
        lblSelectedID.Name = "lblSelectedID"
        lblSelectedID.Size = New Size(0, 15)
        lblSelectedID.TabIndex = 24
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
        ' btnDeleteCM
        ' 
        btnDeleteCM.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnDeleteCM.Cursor = Cursors.Hand
        btnDeleteCM.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnDeleteCM.FlatAppearance.BorderSize = 0
        btnDeleteCM.FlatAppearance.MouseDownBackColor = Color.White
        btnDeleteCM.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDeleteCM.FlatStyle = FlatStyle.Flat
        btnDeleteCM.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteCM.ForeColor = Color.White
        btnDeleteCM.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDeleteCM.IconColor = Color.White
        btnDeleteCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnDeleteCM.IconSize = 20
        btnDeleteCM.Location = New Point(289, 345)
        btnDeleteCM.Name = "btnDeleteCM"
        btnDeleteCM.Size = New Size(150, 35)
        btnDeleteCM.TabIndex = 22
        btnDeleteCM.Text = "DELETE"
        btnDeleteCM.TextAlign = ContentAlignment.MiddleRight
        btnDeleteCM.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteCM.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCM
        ' 
        btnUpdateCM.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnUpdateCM.Cursor = Cursors.Hand
        btnUpdateCM.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnUpdateCM.FlatAppearance.BorderSize = 0
        btnUpdateCM.FlatAppearance.MouseDownBackColor = Color.White
        btnUpdateCM.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnUpdateCM.FlatStyle = FlatStyle.Flat
        btnUpdateCM.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdateCM.ForeColor = Color.White
        btnUpdateCM.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        btnUpdateCM.IconColor = Color.White
        btnUpdateCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnUpdateCM.IconSize = 20
        btnUpdateCM.Location = New Point(289, 301)
        btnUpdateCM.Name = "btnUpdateCM"
        btnUpdateCM.Size = New Size(150, 35)
        btnUpdateCM.TabIndex = 21
        btnUpdateCM.Text = "UPDATE"
        btnUpdateCM.TextAlign = ContentAlignment.MiddleRight
        btnUpdateCM.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdateCM.UseVisualStyleBackColor = False
        ' 
        ' btnSaveCM
        ' 
        btnSaveCM.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnSaveCM.Cursor = Cursors.Hand
        btnSaveCM.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnSaveCM.FlatAppearance.BorderSize = 0
        btnSaveCM.FlatAppearance.MouseDownBackColor = Color.White
        btnSaveCM.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnSaveCM.FlatStyle = FlatStyle.Flat
        btnSaveCM.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveCM.ForeColor = Color.White
        btnSaveCM.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        btnSaveCM.IconColor = Color.White
        btnSaveCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSaveCM.IconSize = 20
        btnSaveCM.Location = New Point(289, 257)
        btnSaveCM.Name = "btnSaveCM"
        btnSaveCM.Size = New Size(150, 35)
        btnSaveCM.TabIndex = 20
        btnSaveCM.Text = "SAVE"
        btnSaveCM.TextAlign = ContentAlignment.MiddleRight
        btnSaveCM.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSaveCM.UseVisualStyleBackColor = False
        ' 
        ' cbPosition
        ' 
        cbPosition.FormattingEnabled = True
        cbPosition.Location = New Point(235, 179)
        cbPosition.Name = "cbPosition"
        cbPosition.Size = New Size(204, 23)
        cbPosition.TabIndex = 9
        ' 
        ' cbGroup
        ' 
        cbGroup.FormattingEnabled = True
        cbGroup.Location = New Point(235, 131)
        cbGroup.Name = "cbGroup"
        cbGroup.Size = New Size(204, 23)
        cbGroup.TabIndex = 8
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(235, 83)
        tbName.Name = "tbName"
        tbName.Size = New Size(204, 23)
        tbName.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(99, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 15)
        Label4.TabIndex = 6
        Label4.Text = "POSITION"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(99, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 5
        Label3.Text = "GROUP"' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 4
        Label2.Text = "NAME"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(68, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 24)
        Label1.TabIndex = 3
        Label1.Text = "CREWMEN DETAILS"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(dgvCrew)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(478, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(578, 632)
        Panel2.TabIndex = 1
        ' 
        ' dgvCrew
        ' 
        dgvCrew.AllowUserToAddRows = False
        dgvCrew.AllowUserToDeleteRows = False
        dgvCrew.BackgroundColor = SystemColors.ActiveCaption
        dgvCrew.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCrew.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCrew.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCrew.Columns.AddRange(New DataGridViewColumn() {AID, AName, AGroup, APosition})
        dgvCrew.Dock = DockStyle.Fill
        dgvCrew.Location = New Point(10, 10)
        dgvCrew.Name = "dgvCrew"
        dgvCrew.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCrew.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCrew.RowHeadersWidth = 4
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCrew.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvCrew.RowTemplate.Height = 25
        dgvCrew.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCrew.Size = New Size(558, 612)
        dgvCrew.TabIndex = 0
        ' 
        ' AID
        ' 
        AID.HeaderText = "ID"
        AID.Name = "AID"
        AID.ReadOnly = True
        AID.Width = 180
        ' 
        ' AName
        ' 
        AName.HeaderText = "NAME"
        AName.Name = "AName"
        AName.ReadOnly = True
        AName.Width = 200
        ' 
        ' AGroup
        ' 
        AGroup.HeaderText = "GROUP"
        AGroup.Name = "AGroup"
        AGroup.ReadOnly = True
        AGroup.Width = 200
        ' 
        ' APosition
        ' 
        APosition.HeaderText = "POSITION"
        APosition.Name = "APosition"
        APosition.ReadOnly = True
        APosition.Width = 200
        ' 
        ' UserControlCREW
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlCREW"
        Size = New Size(1056, 632)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgvCrew, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents btnDeleteCM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateCM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveCM As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvCrew As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSelectedID As Label
    Friend WithEvents AID As DataGridViewTextBoxColumn
    Friend WithEvents AName As DataGridViewTextBoxColumn
    Friend WithEvents AGroup As DataGridViewTextBoxColumn
    Friend WithEvents APosition As DataGridViewTextBoxColumn
End Class
