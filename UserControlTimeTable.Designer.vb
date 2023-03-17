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
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 611)
        Panel1.TabIndex = 5
        ' 
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
        Panel3.Size = New Size(399, 199)
        Panel3.TabIndex = 5
        ' 
        ' btnPlaneAdd
        ' 
        btnPlaneAdd.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnPlaneAdd.BackgroundImageLayout = ImageLayout.None
        btnPlaneAdd.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnPlaneAdd.FlatAppearance.BorderSize = 0
        btnPlaneAdd.FlatAppearance.MouseDownBackColor = Color.White
        btnPlaneAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnPlaneAdd.FlatStyle = FlatStyle.Flat
        btnPlaneAdd.IconChar = FontAwesome.Sharp.IconChar.PlaneLock
        btnPlaneAdd.IconColor = Color.White
        btnPlaneAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPlaneAdd.IconSize = 30
        btnPlaneAdd.Location = New Point(329, 53)
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
        lblShift.Location = New Point(102, 149)
        lblShift.Name = "lblShift"
        lblShift.Size = New Size(140, 23)
        lblShift.TabIndex = 12
        ' 
        ' lblDay
        ' 
        lblDay.BackColor = SystemColors.Window
        lblDay.BorderStyle = BorderStyle.FixedSingle
        lblDay.Location = New Point(102, 118)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(140, 23)
        lblDay.TabIndex = 11
        ' 
        ' cbShiftTime
        ' 
        cbShiftTime.FormattingEnabled = True
        cbShiftTime.Location = New Point(102, 86)
        cbShiftTime.Name = "cbShiftTime"
        cbShiftTime.Size = New Size(140, 23)
        cbShiftTime.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(103, 53)
        dtpDate.MaxDate = New DateTime(2023, 3, 17, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(139, 23)
        dtpDate.TabIndex = 9
        dtpDate.Value = New DateTime(2023, 3, 17, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(20, 153)
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
        Label3.Location = New Point(20, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 6
        Label3.Text = "SHIFT TIME"' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 7
        Label4.Text = "DAY"' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(20, 57)
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
        Panel2.Size = New Size(555, 611)
        Panel2.TabIndex = 6
        ' 
        ' UserControlTimeTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlTimeTable"
        Size = New Size(1033, 611)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
End Class
