<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlAF
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
        lblID = New Label()
        lblAddNewAC = New Label()
        PictureBox1 = New PictureBox()
        btnDeleteFlight = New FontAwesome.Sharp.IconButton()
        btnUpdateFlight = New FontAwesome.Sharp.IconButton()
        btnSaveFlight = New FontAwesome.Sharp.IconButton()
        dpDate = New DateTimePicker()
        Label9 = New Label()
        cbDT = New ComboBox()
        Label8 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        cbStd1 = New ComboBox()
        cbStd = New ComboBox()
        Label4 = New Label()
        lblAName = New Label()
        cbairlinecategory = New ComboBox()
        tbflightNo = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        dgvFlight = New DataGridView()
        fid1 = New DataGridViewTextBoxColumn()
        fno = New DataGridViewTextBoxColumn()
        alc = New DataGridViewTextBoxColumn()
        std1 = New DataGridViewTextBoxColumn()
        dipart = New DataGridViewTextBoxColumn()
        eta = New DataGridViewTextBoxColumn()
        dt = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvFlight, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(lblAddNewAC)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnDeleteFlight)
        Panel1.Controls.Add(btnUpdateFlight)
        Panel1.Controls.Add(btnSaveFlight)
        Panel1.Controls.Add(dpDate)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(cbDT)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cbStd1)
        Panel1.Controls.Add(cbStd)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblAName)
        Panel1.Controls.Add(cbairlinecategory)
        Panel1.Controls.Add(tbflightNo)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 531)
        Panel1.TabIndex = 0
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = SystemColors.ControlLight
        lblID.Location = New Point(101, 421)
        lblID.Name = "lblID"
        lblID.Size = New Size(47, 15)
        lblID.TabIndex = 21
        lblID.Text = "Label10"' 
        ' lblAddNewAC
        ' 
        lblAddNewAC.AutoSize = True
        lblAddNewAC.Location = New Point(233, 191)
        lblAddNewAC.Name = "lblAddNewAC"
        lblAddNewAC.Size = New Size(209, 15)
        lblAddNewAC.TabIndex = 20
        lblAddNewAC.Text = "Airline Category Not Found? Add New"' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLight
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(387, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' btnDeleteFlight
        ' 
        btnDeleteFlight.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnDeleteFlight.Cursor = Cursors.Hand
        btnDeleteFlight.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnDeleteFlight.FlatAppearance.BorderSize = 0
        btnDeleteFlight.FlatAppearance.MouseDownBackColor = Color.White
        btnDeleteFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDeleteFlight.FlatStyle = FlatStyle.Flat
        btnDeleteFlight.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteFlight.ForeColor = Color.White
        btnDeleteFlight.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnDeleteFlight.IconColor = Color.White
        btnDeleteFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnDeleteFlight.IconSize = 20
        btnDeleteFlight.Location = New Point(289, 465)
        btnDeleteFlight.Name = "btnDeleteFlight"
        btnDeleteFlight.Size = New Size(150, 35)
        btnDeleteFlight.TabIndex = 19
        btnDeleteFlight.Text = "DELETE"
        btnDeleteFlight.TextAlign = ContentAlignment.MiddleRight
        btnDeleteFlight.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteFlight.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateFlight
        ' 
        btnUpdateFlight.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnUpdateFlight.Cursor = Cursors.Hand
        btnUpdateFlight.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnUpdateFlight.FlatAppearance.BorderSize = 0
        btnUpdateFlight.FlatAppearance.MouseDownBackColor = Color.White
        btnUpdateFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnUpdateFlight.FlatStyle = FlatStyle.Flat
        btnUpdateFlight.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdateFlight.ForeColor = Color.White
        btnUpdateFlight.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        btnUpdateFlight.IconColor = Color.White
        btnUpdateFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnUpdateFlight.IconSize = 20
        btnUpdateFlight.Location = New Point(289, 421)
        btnUpdateFlight.Name = "btnUpdateFlight"
        btnUpdateFlight.Size = New Size(150, 35)
        btnUpdateFlight.TabIndex = 18
        btnUpdateFlight.Text = "UPDATE"
        btnUpdateFlight.TextAlign = ContentAlignment.MiddleRight
        btnUpdateFlight.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdateFlight.UseVisualStyleBackColor = False
        ' 
        ' btnSaveFlight
        ' 
        btnSaveFlight.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnSaveFlight.Cursor = Cursors.Hand
        btnSaveFlight.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnSaveFlight.FlatAppearance.BorderSize = 0
        btnSaveFlight.FlatAppearance.MouseDownBackColor = Color.White
        btnSaveFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnSaveFlight.FlatStyle = FlatStyle.Flat
        btnSaveFlight.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveFlight.ForeColor = Color.White
        btnSaveFlight.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        btnSaveFlight.IconColor = Color.White
        btnSaveFlight.IconFont = FontAwesome.Sharp.IconFont.Solid
        btnSaveFlight.IconSize = 20
        btnSaveFlight.Location = New Point(289, 377)
        btnSaveFlight.Name = "btnSaveFlight"
        btnSaveFlight.Size = New Size(150, 35)
        btnSaveFlight.TabIndex = 17
        btnSaveFlight.Text = "SAVE"
        btnSaveFlight.TextAlign = ContentAlignment.MiddleRight
        btnSaveFlight.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSaveFlight.UseVisualStyleBackColor = False
        ' 
        ' dpDate
        ' 
        dpDate.Format = DateTimePickerFormat.Short
        dpDate.Location = New Point(235, 305)
        dpDate.Name = "dpDate"
        dpDate.Size = New Size(204, 23)
        dpDate.TabIndex = 16
        dpDate.Value = New DateTime(2023, 3, 17, 11, 38, 27, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(99, 311)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 15)
        Label9.TabIndex = 15
        Label9.Text = "DATE"' 
        ' cbDT
        ' 
        cbDT.FormattingEnabled = True
        cbDT.Location = New Point(235, 261)
        cbDT.Name = "cbDT"
        cbDT.Size = New Size(204, 23)
        cbDT.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(98, 266)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 15)
        Label8.TabIndex = 13
        Label8.Text = "DEPARTURE TIME"' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.Window
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(389, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 23)
        Label6.TabIndex = 12
        Label6.Text = "00"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(369, 219)
        Label7.Name = "Label7"
        Label7.Size = New Size(13, 20)
        Label7.TabIndex = 11
        Label7.Text = ":"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(291, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 9
        Label5.Text = ":"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbStd1
        ' 
        cbStd1.FormattingEnabled = True
        cbStd1.Location = New Point(311, 220)
        cbStd1.Name = "cbStd1"
        cbStd1.Size = New Size(50, 23)
        cbStd1.TabIndex = 8
        ' 
        ' cbStd
        ' 
        cbStd.FormattingEnabled = True
        cbStd.Location = New Point(235, 220)
        cbStd.Name = "cbStd"
        cbStd.Size = New Size(50, 23)
        cbStd.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 15)
        Label4.TabIndex = 6
        Label4.Text = "S.T.D (hh:mm:ss)"' 
        ' lblAName
        ' 
        lblAName.BackColor = SystemColors.Window
        lblAName.BorderStyle = BorderStyle.FixedSingle
        lblAName.Location = New Point(235, 159)
        lblAName.Name = "lblAName"
        lblAName.Size = New Size(204, 23)
        lblAName.TabIndex = 5
        lblAName.Text = "Label4"' 
        ' cbairlinecategory
        ' 
        cbairlinecategory.FormattingEnabled = True
        cbairlinecategory.Location = New Point(235, 127)
        cbairlinecategory.Name = "cbairlinecategory"
        cbairlinecategory.Size = New Size(204, 23)
        cbairlinecategory.TabIndex = 4
        ' 
        ' tbflightNo
        ' 
        tbflightNo.Location = New Point(235, 83)
        tbflightNo.Name = "tbflightNo"
        tbflightNo.Size = New Size(204, 23)
        tbflightNo.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 2
        Label3.Text = "AIRLINE CATEGORY"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "FLIGHT NO"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(68, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 24)
        Label1.TabIndex = 0
        Label1.Text = "FLIGHT DETAILS"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(dgvFlight)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(478, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(683, 531)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(10, 10)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(663, 100)
        Panel3.TabIndex = 1
        ' 
        ' dgvFlight
        ' 
        dgvFlight.AllowUserToAddRows = False
        dgvFlight.AllowUserToDeleteRows = False
        dgvFlight.BackgroundColor = SystemColors.ActiveCaption
        dgvFlight.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvFlight.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvFlight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlight.Columns.AddRange(New DataGridViewColumn() {fid1, fno, alc, std1, dipart, eta, dt})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvFlight.DefaultCellStyle = DataGridViewCellStyle2
        dgvFlight.Dock = DockStyle.Fill
        dgvFlight.Location = New Point(10, 110)
        dgvFlight.Name = "dgvFlight"
        dgvFlight.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvFlight.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvFlight.RowHeadersWidth = 4
        dgvFlight.RowTemplate.Height = 25
        dgvFlight.RowTemplate.ReadOnly = True
        dgvFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFlight.Size = New Size(663, 411)
        dgvFlight.TabIndex = 1
        ' 
        ' fid1
        ' 
        fid1.HeaderText = "FID"
        fid1.Name = "fid1"
        fid1.ReadOnly = True
        fid1.Width = 50
        ' 
        ' fno
        ' 
        fno.HeaderText = "FLIGHT NO"
        fno.Name = "fno"
        fno.ReadOnly = True
        ' 
        ' alc
        ' 
        alc.HeaderText = "AIRLINE CATEGORY"
        alc.Name = "alc"
        alc.ReadOnly = True
        alc.Width = 150
        ' 
        ' std1
        ' 
        std1.HeaderText = "STD"
        std1.Name = "std1"
        std1.ReadOnly = True
        std1.Width = 75
        ' 
        ' dipart
        ' 
        dipart.HeaderText = "DEPARTURE TIME"
        dipart.Name = "dipart"
        dipart.ReadOnly = True
        dipart.Width = 150
        ' 
        ' eta
        ' 
        eta.HeaderText = "ETA"
        eta.Name = "eta"
        eta.ReadOnly = True
        eta.Width = 125
        ' 
        ' dt
        ' 
        dt.HeaderText = "DATE"
        dt.Name = "dt"
        dt.ReadOnly = True
        dt.Width = 150
        ' 
        ' UserControlAF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlAF"
        Size = New Size(1161, 531)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgvFlight, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAName As Label
    Friend WithEvents cbairlinecategory As ComboBox
    Friend WithEvents tbflightNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbStd1 As ComboBox
    Friend WithEvents cbStd As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbDT As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dpDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSaveFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAddNewAC As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvFlight As DataGridView
    Friend WithEvents fid1 As DataGridViewTextBoxColumn
    Friend WithEvents fno As DataGridViewTextBoxColumn
    Friend WithEvents alc As DataGridViewTextBoxColumn
    Friend WithEvents std1 As DataGridViewTextBoxColumn
    Friend WithEvents dipart As DataGridViewTextBoxColumn
    Friend WithEvents eta As DataGridViewTextBoxColumn
    Friend WithEvents dt As DataGridViewTextBoxColumn
End Class
