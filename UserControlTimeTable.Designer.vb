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
        PictureBox1 = New PictureBox()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(68, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 24)
        Label1.TabIndex = 4
        Label1.Text = "DAILY WORK SCHEDULE"' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(pnlCM)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 752)
        Panel1.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.Control
        Panel7.Controls.Add(cbGroup)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(62, 265)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(399, 59)
        Panel7.TabIndex = 7
        ' 
        ' cbGroup
        ' 
        cbGroup.FormattingEnabled = True
        cbGroup.Location = New Point(170, 17)
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
        Label7.Size = New Size(76, 59)
        Label7.TabIndex = 0
        Label7.Text = "GROUP"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(btnAddRICToTable)
        Panel6.Controls.Add(btnAddAgainRIC)
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(lbRemovedRIC)
        Panel6.Controls.Add(Label13)
        Panel6.Controls.Add(btnRICRemove)
        Panel6.Controls.Add(lbRIC)
        Panel6.Controls.Add(pnlRIC)
        Panel6.Location = New Point(62, 537)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(399, 201)
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
        btnAddRICToTable.IconSize = 30
        btnAddRICToTable.Location = New Point(335, 46)
        btnAddRICToTable.Name = "btnAddRICToTable"
        btnAddRICToTable.Size = New Size(50, 50)
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
        btnAddAgainRIC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(155), CByte(50))
        btnAddAgainRIC.FlatStyle = FlatStyle.Flat
        btnAddAgainRIC.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        btnAddAgainRIC.IconColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnAddAgainRIC.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddAgainRIC.IconSize = 25
        btnAddAgainRIC.Location = New Point(124, 126)
        btnAddAgainRIC.Name = "btnAddAgainRIC"
        btnAddAgainRIC.Size = New Size(40, 40)
        btnAddAgainRIC.TabIndex = 20
        btnAddAgainRIC.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(170, 45)
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
        lbRemovedRIC.Location = New Point(170, 63)
        lbRemovedRIC.Name = "lbRemovedRIC"
        lbRemovedRIC.Size = New Size(103, 124)
        lbRemovedRIC.TabIndex = 18
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(15, 45)
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
        btnRICRemove.Location = New Point(124, 80)
        btnRICRemove.Name = "btnRICRemove"
        btnRICRemove.Size = New Size(40, 40)
        btnRICRemove.TabIndex = 16
        btnRICRemove.UseVisualStyleBackColor = False
        ' 
        ' lbRIC
        ' 
        lbRIC.BackColor = SystemColors.ButtonHighlight
        lbRIC.Cursor = Cursors.Hand
        lbRIC.FormattingEnabled = True
        lbRIC.ItemHeight = 15
        lbRIC.Location = New Point(15, 63)
        lbRIC.Name = "lbRIC"
        lbRIC.Size = New Size(103, 124)
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
        pnlRIC.Size = New Size(399, 35)
        pnlRIC.TabIndex = 2
        ' 
        ' IconPictureBox3
        ' 
        IconPictureBox3.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        IconPictureBox3.IconColor = Color.White
        IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox3.IconSize = 21
        IconPictureBox3.Location = New Point(373, 7)
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
        Label9.Location = New Point(23, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 15)
        Label9.TabIndex = 0
        Label9.Text = "RIC"' 
        ' pnlCM
        ' 
        pnlCM.BackColor = SystemColors.Control
        pnlCM.Controls.Add(btnAddCMToTable)
        pnlCM.Controls.Add(btnAddAgainCM)
        pnlCM.Controls.Add(Label11)
        pnlCM.Controls.Add(lbRemovedCM)
        pnlCM.Controls.Add(Label10)
        pnlCM.Controls.Add(btnCMRemove)
        pnlCM.Controls.Add(lbCM)
        pnlCM.Controls.Add(Panel8)
        pnlCM.Location = New Point(62, 330)
        pnlCM.Name = "pnlCM"
        pnlCM.Size = New Size(399, 201)
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
        btnAddCMToTable.IconSize = 30
        btnAddCMToTable.Location = New Point(335, 45)
        btnAddCMToTable.Name = "btnAddCMToTable"
        btnAddCMToTable.Size = New Size(50, 50)
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
        btnAddAgainCM.Location = New Point(124, 125)
        btnAddAgainCM.Name = "btnAddAgainCM"
        btnAddAgainCM.Size = New Size(40, 40)
        btnAddAgainCM.TabIndex = 9
        btnAddAgainCM.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(170, 44)
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
        lbRemovedCM.Location = New Point(170, 62)
        lbRemovedCM.Name = "lbRemovedCM"
        lbRemovedCM.Size = New Size(103, 124)
        lbRemovedCM.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(15, 44)
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
        btnCMRemove.Location = New Point(124, 79)
        btnCMRemove.Name = "btnCMRemove"
        btnCMRemove.Size = New Size(40, 40)
        btnCMRemove.TabIndex = 3
        btnCMRemove.UseVisualStyleBackColor = False
        ' 
        ' lbCM
        ' 
        lbCM.BackColor = SystemColors.ButtonHighlight
        lbCM.Cursor = Cursors.Hand
        lbCM.FormattingEnabled = True
        lbCM.ItemHeight = 15
        lbCM.Location = New Point(15, 62)
        lbCM.Name = "lbCM"
        lbCM.Size = New Size(103, 124)
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
        Panel8.Size = New Size(399, 35)
        Panel8.TabIndex = 1
        ' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        IconPictureBox2.IconColor = Color.White
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 21
        IconPictureBox2.Location = New Point(373, 7)
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
        Label8.Location = New Point(23, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 15)
        Label8.TabIndex = 0
        Label8.Text = "CREWMAN"' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
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
        Panel3.Location = New Point(62, 69)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(399, 189)
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
        btnPlaneAdd.IconSize = 30
        btnPlaneAdd.Location = New Point(335, 44)
        btnPlaneAdd.Name = "btnPlaneAdd"
        btnPlaneAdd.Size = New Size(50, 50)
        btnPlaneAdd.TabIndex = 13
        btnPlaneAdd.TextAlign = ContentAlignment.MiddleRight
        btnPlaneAdd.UseVisualStyleBackColor = False
        ' 
        ' lblShift
        ' 
        lblShift.BackColor = Color.White
        lblShift.BorderStyle = BorderStyle.FixedSingle
        lblShift.FlatStyle = FlatStyle.Flat
        lblShift.Location = New Point(107, 140)
        lblShift.Name = "lblShift"
        lblShift.Size = New Size(140, 23)
        lblShift.TabIndex = 12
        ' 
        ' lblDay
        ' 
        lblDay.BackColor = SystemColors.Window
        lblDay.BorderStyle = BorderStyle.FixedSingle
        lblDay.Location = New Point(107, 109)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(140, 23)
        lblDay.TabIndex = 11
        ' 
        ' cbShiftTime
        ' 
        cbShiftTime.FormattingEnabled = True
        cbShiftTime.Location = New Point(107, 77)
        cbShiftTime.Name = "cbShiftTime"
        cbShiftTime.Size = New Size(140, 23)
        cbShiftTime.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(108, 44)
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
        Label5.Location = New Point(25, 144)
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
        Panel4.Size = New Size(399, 35)
        Panel4.TabIndex = 0
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
        Label6.Location = New Point(23, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 0
        Label6.Text = "SHIFT TIME"' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(25, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 6
        Label3.Text = "SHIFT TIME"' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(25, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 7
        Label4.Text = "DAY"' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 5
        Label2.Text = "DATE"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Dock = DockStyle.Fill
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(478, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(555, 752)
        Panel2.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLight
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(387, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
