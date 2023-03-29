<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlTimeTable
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel7 = New Panel()
        cbGroup = New ComboBox()
        Label7 = New Label()
        Panel6 = New Panel()
        btnAddRICToTable = New FontAwesome.Sharp.IconButton()
        btnAddAgainRIC = New FontAwesome.Sharp.IconButton()
        Label12 = New Label()
        lbRemovedRIC = New ListBox()
        Label13 = New Label()
        btnRICRemove = New FontAwesome.Sharp.IconButton()
        lbRIC = New ListBox()
        pnlRIC = New Panel()
        IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Label9 = New Label()
        pnlCM = New Panel()
        btnAddCMToTable = New FontAwesome.Sharp.IconButton()
        btnAddAgainCM = New FontAwesome.Sharp.IconButton()
        Label11 = New Label()
        lbRemovedCM = New ListBox()
        Label10 = New Label()
        btnCMRemove = New FontAwesome.Sharp.IconButton()
        lbCM = New ListBox()
        Panel8 = New Panel()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Label8 = New Label()
        Panel3 = New Panel()
        btnPlaneAdd = New FontAwesome.Sharp.IconButton()
        lblShift = New Label()
        lblDay = New Label()
        cbShiftTime = New ComboBox()
        dtpDate = New DateTimePicker()
        Label5 = New Label()
        Panel4 = New Panel()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label6 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel11 = New Panel()
        Panel9 = New Panel()
        dgvMain = New DataGridView()
        Column2 = New DataGridViewCheckBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        noo = New DataGridViewTextBoxColumn()
        fli = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        lines = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewComboBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel12 = New Panel()
        tbRoute = New TextBox()
        Label18 = New Label()
        lblETAShow = New Label()
        Label16 = New Label()
        Label17 = New Label()
        lblSelectedFlight = New Label()
        cbOPerater = New ComboBox()
        btnUpdateData = New FontAwesome.Sharp.IconButton()
        Label19 = New Label()
        cboxremarks = New ComboBox()
        tbBayNo = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        btnResizePnl = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        lbltoday = New Label()
        lblTime = New Label()
        Panel10 = New Panel()
        btnPrint = New FontAwesome.Sharp.IconButton()
        Timer1 = New Timer(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        pnlRIC.SuspendLayout()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlCM.SuspendLayout()
        Panel8.SuspendLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel11.SuspendLayout()
        Panel9.SuspendLayout()
        CType(dgvMain, ComponentModel.ISupportInitialize).BeginInit()
        Panel12.SuspendLayout()
        Panel5.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 24)
        Label1.TabIndex = 4
        Label1.Text = "DAILY WORK SCHEDULE"' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(pnlCM)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(320, 752)
        Panel1.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.WhiteSmoke
        Panel7.Controls.Add(cbGroup)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(55, 252)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(255, 48)
        Panel7.TabIndex = 7
        ' 
        ' cbGroup
        ' 
        cbGroup.FormattingEnabled = True
        cbGroup.Location = New Point(106, 14)
        cbGroup.Name = "cbGroup"
        cbGroup.Size = New Size(121, 23)
        cbGroup.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 48)
        Label7.TabIndex = 0
        Label7.Text = "GROUP"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.WhiteSmoke
        Panel6.Controls.Add(btnAddRICToTable)
        Panel6.Controls.Add(btnAddAgainRIC)
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(lbRemovedRIC)
        Panel6.Controls.Add(Label13)
        Panel6.Controls.Add(btnRICRemove)
        Panel6.Controls.Add(lbRIC)
        Panel6.Controls.Add(pnlRIC)
        Panel6.Location = New Point(56, 527)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(255, 217)
        Panel6.TabIndex = 7
        ' 
        ' btnAddRICToTable
        ' 
        btnAddRICToTable.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnAddRICToTable.BackgroundImageLayout = ImageLayout.None
        btnAddRICToTable.Cursor = Cursors.Hand
        btnAddRICToTable.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnAddRICToTable.FlatAppearance.BorderSize = 0
        btnAddRICToTable.FlatAppearance.MouseDownBackColor = Color.White
        btnAddRICToTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnAddRICToTable.FlatStyle = FlatStyle.Flat
        btnAddRICToTable.IconChar = FontAwesome.Sharp.IconChar.UserLock
        btnAddRICToTable.IconColor = Color.White
        btnAddRICToTable.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddRICToTable.IconSize = 25
        btnAddRICToTable.Location = New Point(98, 177)
        btnAddRICToTable.Name = "btnAddRICToTable"
        btnAddRICToTable.Size = New Size(140, 29)
        btnAddRICToTable.TabIndex = 21
        btnAddRICToTable.TextAlign = ContentAlignment.MiddleRight
        btnAddRICToTable.UseVisualStyleBackColor = False
        ' 
        ' btnAddAgainRIC
        ' 
        btnAddAgainRIC.BackColor = Color.White
        btnAddAgainRIC.Cursor = Cursors.Hand
        btnAddAgainRIC.FlatAppearance.BorderSize = 0
        btnAddAgainRIC.FlatAppearance.MouseDownBackColor = Color.White
        btnAddAgainRIC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnAddAgainRIC.FlatStyle = FlatStyle.Flat
        btnAddAgainRIC.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        btnAddAgainRIC.IconColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnAddAgainRIC.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddAgainRIC.IconSize = 25
        btnAddAgainRIC.Location = New Point(106, 108)
        btnAddAgainRIC.Name = "btnAddAgainRIC"
        btnAddAgainRIC.Size = New Size(40, 40)
        btnAddAgainRIC.TabIndex = 20
        btnAddAgainRIC.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(152, 27)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 15)
        Label12.TabIndex = 19
        Label12.Text = "OUT"' 
        ' lbRemovedRIC
        ' 
        lbRemovedRIC.BackColor = SystemColors.ButtonHighlight
        lbRemovedRIC.Cursor = Cursors.Hand
        lbRemovedRIC.FormattingEnabled = True
        lbRemovedRIC.ItemHeight = 15
        lbRemovedRIC.Location = New Point(151, 45)
        lbRemovedRIC.Name = "lbRemovedRIC"
        lbRemovedRIC.Size = New Size(87, 124)
        lbRemovedRIC.TabIndex = 18
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(14, 27)
        Label13.Name = "Label13"
        Label13.Size = New Size(66, 15)
        Label13.TabIndex = 17
        Label13.Text = "IN"' 
        ' btnRICRemove
        ' 
        btnRICRemove.BackColor = Color.White
        btnRICRemove.Cursor = Cursors.Hand
        btnRICRemove.FlatAppearance.BorderSize = 0
        btnRICRemove.FlatAppearance.MouseDownBackColor = Color.White
        btnRICRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnRICRemove.FlatStyle = FlatStyle.Flat
        btnRICRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        btnRICRemove.IconColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnRICRemove.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRICRemove.IconSize = 25
        btnRICRemove.Location = New Point(106, 62)
        btnRICRemove.Name = "btnRICRemove"
        btnRICRemove.Size = New Size(40, 40)
        btnRICRemove.TabIndex = 16
        btnRICRemove.UseVisualStyleBackColor = False
        ' 
        ' lbRIC
        ' 
        lbRIC.AllowDrop = True
        lbRIC.BackColor = SystemColors.ButtonHighlight
        lbRIC.Cursor = Cursors.Hand
        lbRIC.FormattingEnabled = True
        lbRIC.ItemHeight = 15
        lbRIC.Location = New Point(14, 45)
        lbRIC.Name = "lbRIC"
        lbRIC.Size = New Size(87, 124)
        lbRIC.TabIndex = 15
        ' 
        ' pnlRIC
        ' 
        pnlRIC.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        pnlRIC.Controls.Add(IconPictureBox3)
        pnlRIC.Controls.Add(Label9)
        pnlRIC.Dock = DockStyle.Top
        pnlRIC.Location = New Point(0, 0)
        pnlRIC.Name = "pnlRIC"
        pnlRIC.Size = New Size(255, 23)
        pnlRIC.TabIndex = 2
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        IconPictureBox3.IconColor = Color.White
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 21
        IconPictureBox3.Location = New Point(229, 3)
        IconPictureBox3.Name = "IconPictureBox3"
        IconPictureBox3.Size = New Size(21, 26)
        IconPictureBox3.TabIndex = 9
        IconPictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(6, 5)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 15)
        Label9.TabIndex = 0
        Label9.Text = "RIC"' 
        ' pnlCM
        ' 
        pnlCM.BackColor = Color.WhiteSmoke
        pnlCM.Controls.Add(btnAddCMToTable)
        pnlCM.Controls.Add(btnAddAgainCM)
        pnlCM.Controls.Add(Label11)
        pnlCM.Controls.Add(lbRemovedCM)
        pnlCM.Controls.Add(Label10)
        pnlCM.Controls.Add(btnCMRemove)
        pnlCM.Controls.Add(lbCM)
        pnlCM.Controls.Add(Panel8)
        pnlCM.Location = New Point(55, 305)
        pnlCM.Name = "pnlCM"
        pnlCM.Size = New Size(255, 217)
        pnlCM.TabIndex = 6
        ' 
        ' btnAddCMToTable
        ' 
        btnAddCMToTable.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnAddCMToTable.BackgroundImageLayout = ImageLayout.None
        btnAddCMToTable.Cursor = Cursors.Hand
        btnAddCMToTable.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnAddCMToTable.FlatAppearance.BorderSize = 0
        btnAddCMToTable.FlatAppearance.MouseDownBackColor = Color.White
        btnAddCMToTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnAddCMToTable.FlatStyle = FlatStyle.Flat
        btnAddCMToTable.IconChar = FontAwesome.Sharp.IconChar.UserLock
        btnAddCMToTable.IconColor = Color.White
        btnAddCMToTable.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddCMToTable.IconSize = 25
        btnAddCMToTable.Location = New Point(99, 177)
        btnAddCMToTable.Name = "btnAddCMToTable"
        btnAddCMToTable.Size = New Size(140, 29)
        btnAddCMToTable.TabIndex = 14
        btnAddCMToTable.TextAlign = ContentAlignment.MiddleRight
        btnAddCMToTable.UseVisualStyleBackColor = False
        ' 
        ' btnAddAgainCM
        ' 
        btnAddAgainCM.BackColor = Color.White
        btnAddAgainCM.Cursor = Cursors.Hand
        btnAddAgainCM.FlatAppearance.BorderSize = 0
        btnAddAgainCM.FlatAppearance.MouseDownBackColor = Color.White
        btnAddAgainCM.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(155), CByte(50))
        btnAddAgainCM.FlatStyle = FlatStyle.Flat
        btnAddAgainCM.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        btnAddAgainCM.IconColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnAddAgainCM.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddAgainCM.IconSize = 25
        btnAddAgainCM.Location = New Point(106, 108)
        btnAddAgainCM.Name = "btnAddAgainCM"
        btnAddAgainCM.Size = New Size(40, 40)
        btnAddAgainCM.TabIndex = 9
        btnAddAgainCM.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(152, 27)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 15)
        Label11.TabIndex = 8
        Label11.Text = "OUT"' 
        ' lbRemovedCM
        ' 
        lbRemovedCM.BackColor = SystemColors.ButtonHighlight
        lbRemovedCM.Cursor = Cursors.Hand
        lbRemovedCM.FormattingEnabled = True
        lbRemovedCM.ItemHeight = 15
        lbRemovedCM.Location = New Point(152, 45)
        lbRemovedCM.Name = "lbRemovedCM"
        lbRemovedCM.Size = New Size(87, 124)
        lbRemovedCM.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(15, 27)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 15)
        Label10.TabIndex = 6
        Label10.Text = "IN"' 
        ' btnCMRemove
        ' 
        btnCMRemove.BackColor = Color.White
        btnCMRemove.Cursor = Cursors.Hand
        btnCMRemove.FlatAppearance.BorderSize = 0
        btnCMRemove.FlatAppearance.MouseDownBackColor = Color.White
        btnCMRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnCMRemove.FlatStyle = FlatStyle.Flat
        btnCMRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        btnCMRemove.IconColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnCMRemove.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCMRemove.IconSize = 25
        btnCMRemove.Location = New Point(106, 62)
        btnCMRemove.Name = "btnCMRemove"
        btnCMRemove.Size = New Size(40, 40)
        btnCMRemove.TabIndex = 3
        btnCMRemove.UseVisualStyleBackColor = False
        ' 
        ' lbCM
        ' 
        lbCM.AllowDrop = True
        lbCM.BackColor = SystemColors.ButtonHighlight
        lbCM.Cursor = Cursors.Hand
        lbCM.FormattingEnabled = True
        lbCM.ItemHeight = 15
        lbCM.Location = New Point(15, 45)
        lbCM.Name = "lbCM"
        lbCM.Size = New Size(87, 124)
        lbCM.TabIndex = 2
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Panel8.Controls.Add(IconPictureBox2)
        Panel8.Controls.Add(Label8)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(255, 23)
        Panel8.TabIndex = 1
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        IconPictureBox2.IconColor = Color.White
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 21
        IconPictureBox2.Location = New Point(230, 3)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(21, 26)
        IconPictureBox2.TabIndex = 9
        IconPictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(5, 4)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 15)
        Label8.TabIndex = 0
        Label8.Text = "CREWMAN"' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(btnPlaneAdd)
        Panel3.Controls.Add(lblShift)
        Panel3.Controls.Add(lblDay)
        Panel3.Controls.Add(cbShiftTime)
        Panel3.Controls.Add(dtpDate)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(55, 59)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(255, 187)
        Panel3.TabIndex = 5
        ' 
        ' btnPlaneAdd
        ' 
        btnPlaneAdd.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnPlaneAdd.BackgroundImageLayout = ImageLayout.None
        btnPlaneAdd.Cursor = Cursors.Hand
        btnPlaneAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnPlaneAdd.FlatAppearance.BorderSize = 0
        btnPlaneAdd.FlatAppearance.MouseDownBackColor = Color.White
        btnPlaneAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnPlaneAdd.FlatStyle = FlatStyle.Flat
        btnPlaneAdd.IconChar = FontAwesome.Sharp.IconChar.PlaneLock
        btnPlaneAdd.IconColor = Color.White
        btnPlaneAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPlaneAdd.IconSize = 25
        btnPlaneAdd.Location = New Point(90, 144)
        btnPlaneAdd.Name = "btnPlaneAdd"
        btnPlaneAdd.Size = New Size(140, 29)
        btnPlaneAdd.TabIndex = 13
        btnPlaneAdd.TextAlign = ContentAlignment.MiddleRight
        btnPlaneAdd.UseVisualStyleBackColor = False
        ' 
        ' lblShift
        ' 
        lblShift.BackColor = Color.White
        lblShift.BorderStyle = BorderStyle.FixedSingle
        lblShift.FlatStyle = FlatStyle.Flat
        lblShift.Location = New Point(90, 114)
        lblShift.Name = "lblShift"
        lblShift.Size = New Size(140, 23)
        lblShift.TabIndex = 12
        ' 
        ' lblDay
        ' 
        lblDay.BackColor = SystemColors.Window
        lblDay.BorderStyle = BorderStyle.FixedSingle
        lblDay.Location = New Point(90, 87)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(140, 21)
        lblDay.TabIndex = 11
        ' 
        ' cbShiftTime
        ' 
        cbShiftTime.FormattingEnabled = True
        cbShiftTime.Location = New Point(90, 58)
        cbShiftTime.Name = "cbShiftTime"
        cbShiftTime.Size = New Size(140, 23)
        cbShiftTime.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.Cursor = Cursors.Hand
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(91, 28)
        dtpDate.MaxDate = New DateTime(2123, 3, 17, 0, 0, 0, 0)
        dtpDate.MinDate = New DateTime(2000, 1, 1, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(139, 23)
        dtpDate.TabIndex = 9
        dtpDate.Value = New DateTime(2023, 3, 17, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 8
        Label5.Text = "SHIFT "' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Panel4.Controls.Add(IconPictureBox1)
        Panel4.Controls.Add(Label6)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(255, 23)
        Panel4.TabIndex = 0
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        IconPictureBox1.IconColor = Color.White
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 21
        IconPictureBox1.Location = New Point(230, 1)
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
        Label6.Location = New Point(5, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 0
        Label6.Text = "SHIFT TIME"' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 6
        Label3.Text = "SHIFT TIME"' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 13)
        Label4.TabIndex = 7
        Label4.Text = "DAY"' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 5
        Label2.Text = "DATE"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(Panel5)
        Panel2.Dock = DockStyle.Fill
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(320, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(713, 752)
        Panel2.TabIndex = 6
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = SystemColors.ControlLight
        Panel11.Controls.Add(Panel9)
        Panel11.Controls.Add(Panel12)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(0, 56)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(713, 696)
        Panel11.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.ActiveCaption
        Panel9.Controls.Add(dgvMain)
        Panel9.Dock = DockStyle.Fill
        Panel9.ForeColor = Color.Black
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(5)
        Panel9.Size = New Size(463, 696)
        Panel9.TabIndex = 2
        ' 
        ' dgvMain
        ' 
        dgvMain.AllowUserToAddRows = False
        dgvMain.AllowUserToDeleteRows = False
        dgvMain.BackgroundColor = SystemColors.ActiveCaption
        dgvMain.BorderStyle = BorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMain.Columns.AddRange(New DataGridViewColumn() {Column2, Column1, noo, fli, Column10, Column4, lines, Column6, Column7, Column8, Column9, Column3, Column5})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvMain.DefaultCellStyle = DataGridViewCellStyle5
        dgvMain.Dock = DockStyle.Fill
        dgvMain.Location = New Point(5, 5)
        dgvMain.Name = "dgvMain"
        dgvMain.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvMain.RowHeadersWidth = 4
        dgvMain.RowTemplate.Height = 25
        dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMain.Size = New Size(453, 686)
        dgvMain.TabIndex = 0
        ' 
        ' Column2
        ' 
        Column2.HeaderText = ""
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.True
        Column2.SortMode = DataGridViewColumnSortMode.Automatic
        Column2.Width = 20
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "BAY NO"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' noo
        ' 
        noo.HeaderText = "NO"
        noo.Name = "noo"
        noo.ReadOnly = True
        noo.SortMode = DataGridViewColumnSortMode.NotSortable
        noo.Width = 40
        ' 
        ' fli
        ' 
        fli.HeaderText = "FLIGHT"
        fli.Name = "fli"
        fli.ReadOnly = True
        fli.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "ROUTE"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.SortMode = DataGridViewColumnSortMode.NotSortable
        Column10.Width = 70
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "E.T.A"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' lines
        ' 
        lines.HeaderText = "AIRLINE"
        lines.Name = "lines"
        lines.ReadOnly = True
        lines.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "RIC"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.SortMode = DataGridViewColumnSortMode.NotSortable
        Column6.Width = 70
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "OPERATOR"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.SortMode = DataGridViewColumnSortMode.NotSortable
        Column7.Width = 70
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "CREWMAN"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.SortMode = DataGridViewColumnSortMode.NotSortable
        Column8.Width = 70
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "REMARKS"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.SortMode = DataGridViewColumnSortMode.NotSortable
        Column9.Width = 80
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Is Confirm"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "DATE"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = SystemColors.ControlLight
        Panel12.Controls.Add(tbRoute)
        Panel12.Controls.Add(Label18)
        Panel12.Controls.Add(lblETAShow)
        Panel12.Controls.Add(Label16)
        Panel12.Controls.Add(Label17)
        Panel12.Controls.Add(lblSelectedFlight)
        Panel12.Controls.Add(cbOPerater)
        Panel12.Controls.Add(btnUpdateData)
        Panel12.Controls.Add(Label19)
        Panel12.Controls.Add(cboxremarks)
        Panel12.Controls.Add(tbBayNo)
        Panel12.Controls.Add(Label15)
        Panel12.Controls.Add(Label14)
        Panel12.Controls.Add(btnResizePnl)
        Panel12.Dock = DockStyle.Right
        Panel12.ForeColor = Color.Black
        Panel12.Location = New Point(463, 0)
        Panel12.Name = "Panel12"
        Panel12.Padding = New Padding(3)
        Panel12.Size = New Size(250, 696)
        Panel12.TabIndex = 2
        ' 
        ' tbRoute
        ' 
        tbRoute.Location = New Point(43, 165)
        tbRoute.Name = "tbRoute"
        tbRoute.Size = New Size(165, 23)
        tbRoute.TabIndex = 37
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(41, 147)
        Label18.Name = "Label18"
        Label18.Size = New Size(46, 15)
        Label18.TabIndex = 36
        Label18.Text = "ROUTE"' 
        ' lblETAShow
        ' 
        lblETAShow.AutoSize = True
        lblETAShow.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblETAShow.Location = New Point(120, 68)
        lblETAShow.Name = "lblETAShow"
        lblETAShow.Size = New Size(33, 15)
        lblETAShow.TabIndex = 35
        lblETAShow.Text = "E.T.A"' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(92, 68)
        Label16.Name = "Label16"
        Label16.Size = New Size(27, 15)
        Label16.TabIndex = 34
        Label16.Text = "AT :"' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(40, 45)
        Label17.Name = "Label17"
        Label17.Size = New Size(48, 15)
        Label17.TabIndex = 31
        Label17.Text = "FLIGHT"' 
        ' lblSelectedFlight
        ' 
        lblSelectedFlight.BackColor = SystemColors.ControlLightLight
        lblSelectedFlight.FlatStyle = FlatStyle.Flat
        lblSelectedFlight.Location = New Point(94, 41)
        lblSelectedFlight.Name = "lblSelectedFlight"
        lblSelectedFlight.Size = New Size(113, 23)
        lblSelectedFlight.TabIndex = 30
        lblSelectedFlight.Text = "Selected Flight"
        lblSelectedFlight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbOPerater
        ' 
        cbOPerater.FormattingEnabled = True
        cbOPerater.Location = New Point(42, 217)
        cbOPerater.Name = "cbOPerater"
        cbOPerater.Size = New Size(166, 23)
        cbOPerater.TabIndex = 29
        ' 
        ' btnUpdateData
        ' 
        btnUpdateData.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnUpdateData.BackgroundImageLayout = ImageLayout.None
        btnUpdateData.Cursor = Cursors.Hand
        btnUpdateData.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnUpdateData.FlatAppearance.BorderSize = 0
        btnUpdateData.FlatAppearance.MouseDownBackColor = Color.White
        btnUpdateData.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnUpdateData.FlatStyle = FlatStyle.Flat
        btnUpdateData.IconChar = FontAwesome.Sharp.IconChar.Rotate
        btnUpdateData.IconColor = Color.White
        btnUpdateData.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUpdateData.IconSize = 25
        btnUpdateData.Location = New Point(43, 315)
        btnUpdateData.Name = "btnUpdateData"
        btnUpdateData.Size = New Size(166, 29)
        btnUpdateData.TabIndex = 14
        btnUpdateData.TextAlign = ContentAlignment.MiddleRight
        btnUpdateData.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(40, 250)
        Label19.Name = "Label19"
        Label19.Size = New Size(63, 15)
        Label19.TabIndex = 12
        Label19.Text = "REMARKS"' 
        ' cboxremarks
        ' 
        cboxremarks.FormattingEnabled = True
        cboxremarks.Location = New Point(43, 269)
        cboxremarks.Name = "cboxremarks"
        cboxremarks.Size = New Size(166, 23)
        cboxremarks.TabIndex = 11
        ' 
        ' tbBayNo
        ' 
        tbBayNo.Location = New Point(43, 114)
        tbBayNo.Name = "tbBayNo"
        tbBayNo.Size = New Size(165, 23)
        tbBayNo.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(40, 198)
        Label15.Name = "Label15"
        Label15.Size = New Size(68, 15)
        Label15.TabIndex = 2
        Label15.Text = "OPERATOR"' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(41, 95)
        Label14.Name = "Label14"
        Label14.Size = New Size(50, 15)
        Label14.TabIndex = 1
        Label14.Text = "BAY NO"' 
        ' btnResizePnl
        ' 
        btnResizePnl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnResizePnl.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnResizePnl.FlatAppearance.BorderSize = 0
        btnResizePnl.FlatStyle = FlatStyle.Flat
        btnResizePnl.ForeColor = Color.WhiteSmoke
        btnResizePnl.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        btnResizePnl.IconColor = Color.WhiteSmoke
        btnResizePnl.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnResizePnl.IconSize = 20
        btnResizePnl.ImageAlign = ContentAlignment.MiddleLeft
        btnResizePnl.Location = New Point(3, 3)
        btnResizePnl.Margin = New Padding(0)
        btnResizePnl.Name = "btnResizePnl"
        btnResizePnl.Size = New Size(244, 27)
        btnResizePnl.TabIndex = 0
        btnResizePnl.Text = "UPDATE"
        btnResizePnl.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaption
        Panel5.Controls.Add(lbltoday)
        Panel5.Controls.Add(lblTime)
        Panel5.Controls.Add(Panel10)
        Panel5.Dock = DockStyle.Top
        Panel5.ForeColor = Color.Black
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(713, 56)
        Panel5.TabIndex = 0
        ' 
        ' lbltoday
        ' 
        lbltoday.AutoSize = True
        lbltoday.ForeColor = Color.Black
        lbltoday.Location = New Point(24, 10)
        lbltoday.Name = "lbltoday"
        lbltoday.Size = New Size(65, 15)
        lbltoday.TabIndex = 6
        lbltoday.Text = "22/03/2023"' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.ForeColor = Color.Black
        lblTime.Location = New Point(24, 31)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(33, 15)
        lblTime.TabIndex = 5
        lblTime.Text = "TIME"' 
        ' Panel10
        ' 
        Panel10.Controls.Add(btnPrint)
        Panel10.Dock = DockStyle.Right
        Panel10.Location = New Point(503, 10)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(200, 36)
        Panel10.TabIndex = 4
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatAppearance.MouseDownBackColor = Color.White
        btnPrint.FlatAppearance.MouseOverBackColor = Color.Maroon
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        btnPrint.IconColor = Color.White
        btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPrint.IconSize = 25
        btnPrint.Location = New Point(61, 1)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(138, 34)
        btnPrint.TabIndex = 0
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' UserControlTimeTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlTimeTable"
        Size = New Size(1033, 752)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        pnlRIC.ResumeLayout(False)
        pnlRIC.PerformLayout()
        CType(IconPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlCM.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        CType(dgvMain, ComponentModel.ISupportInitialize).EndInit()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel10.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cbShiftTime As ComboBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblShift As Label
    Friend WithEvents btnPlaneAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlCM As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlRIC As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbCM As ListBox
    Friend WithEvents btnCMRemove As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddAgainCM As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents lbRemovedCM As ListBox
    Friend WithEvents btnAddCMToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddRICToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddAgainRIC As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents lbRemovedRIC As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnRICRemove As FontAwesome.Sharp.IconButton
    Friend WithEvents lbRIC As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnResizePnl As FontAwesome.Sharp.IconButton
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents noo As DataGridViewTextBoxColumn
    Friend WithEvents fli As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lines As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents tbBayNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboxremarks As ComboBox
    Friend WithEvents btnUpdateData As FontAwesome.Sharp.IconButton
    Friend WithEvents cbOPerater As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblSelectedFlight As Label
    Friend WithEvents lblETAShow As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lbltoday As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tbRoute As TextBox
End Class
