<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAINFORM
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
        components = New ComponentModel.Container()
        PanelMenu = New Panel()
        Panel3 = New Panel()
        lblUser = New Label()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        btnMenu = New FontAwesome.Sharp.IconButton()
        btnCrew = New FontAwesome.Sharp.IconButton()
        btnFlight = New FontAwesome.Sharp.IconButton()
        btnShedule = New FontAwesome.Sharp.IconButton()
        PanelLoad = New Panel()
        PanelUC = New Panel()
        TimerMenu = New Timer(components)
        Panel1 = New Panel()
        PanelMenu.SuspendLayout()
        Panel3.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PanelLoad.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        PanelMenu.Controls.Add(Panel1)
        PanelMenu.Controls.Add(Panel3)
        PanelMenu.Controls.Add(btnCrew)
        PanelMenu.Controls.Add(btnFlight)
        PanelMenu.Controls.Add(btnShedule)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(200, 450)
        PanelMenu.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnMenu)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 49)
        Panel3.TabIndex = 5
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(25, 30)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(42, 17)
        lblUser.TabIndex = 4
        lblUser.Text = "User1"' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.Transparent
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        IconPictureBox4.IconColor = Color.White
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 19
        IconPictureBox4.Location = New Point(6, 28)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Size = New Size(19, 21)
        IconPictureBox4.TabIndex = 3
        IconPictureBox4.TabStop = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnMenu.BackgroundImageLayout = ImageLayout.None
        btnMenu.Cursor = Cursors.Hand
        btnMenu.Dock = DockStyle.Right
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.ForeColor = Color.White
        btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon
        btnMenu.IconColor = Color.White
        btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMenu.IconSize = 37
        btnMenu.Location = New Point(146, 0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(54, 49)
        btnMenu.TabIndex = 1
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnCrew
        ' 
        btnCrew.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnCrew.FlatAppearance.BorderSize = 0
        btnCrew.FlatAppearance.MouseDownBackColor = Color.White
        btnCrew.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnCrew.FlatStyle = FlatStyle.Flat
        btnCrew.ForeColor = Color.White
        btnCrew.IconChar = FontAwesome.Sharp.IconChar.User
        btnCrew.IconColor = Color.White
        btnCrew.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCrew.IconSize = 25
        btnCrew.Location = New Point(-20, 167)
        btnCrew.Name = "btnCrew"
        btnCrew.Size = New Size(225, 50)
        btnCrew.TabIndex = 4
        btnCrew.Text = "    CREWMEN"
        btnCrew.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCrew.UseVisualStyleBackColor = False
        ' 
        ' btnFlight
        ' 
        btnFlight.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnFlight.FlatAppearance.BorderSize = 0
        btnFlight.FlatAppearance.MouseDownBackColor = Color.White
        btnFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnFlight.FlatStyle = FlatStyle.Flat
        btnFlight.ForeColor = Color.White
        btnFlight.IconChar = FontAwesome.Sharp.IconChar.Plane
        btnFlight.IconColor = Color.White
        btnFlight.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFlight.IconSize = 30
        btnFlight.Location = New Point(-25, 111)
        btnFlight.Name = "btnFlight"
        btnFlight.Size = New Size(225, 50)
        btnFlight.TabIndex = 3
        btnFlight.Text = "    FLIGHT"
        btnFlight.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFlight.UseVisualStyleBackColor = False
        ' 
        ' btnShedule
        ' 
        btnShedule.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnShedule.FlatAppearance.BorderSize = 0
        btnShedule.FlatAppearance.MouseDownBackColor = Color.White
        btnShedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnShedule.FlatStyle = FlatStyle.Flat
        btnShedule.ForeColor = Color.White
        btnShedule.IconChar = FontAwesome.Sharp.IconChar.Columns
        btnShedule.IconColor = Color.White
        btnShedule.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnShedule.IconSize = 30
        btnShedule.Location = New Point(-10, 55)
        btnShedule.Name = "btnShedule"
        btnShedule.Size = New Size(210, 50)
        btnShedule.TabIndex = 2
        btnShedule.Text = "    WORK SCHEDULE"
        btnShedule.TextImageRelation = TextImageRelation.ImageBeforeText
        btnShedule.UseVisualStyleBackColor = False
        ' 
        ' PanelLoad
        ' 
        PanelLoad.BackColor = SystemColors.ButtonFace
        PanelLoad.Controls.Add(PanelUC)
        PanelLoad.Dock = DockStyle.Fill
        PanelLoad.Location = New Point(0, 0)
        PanelLoad.Name = "PanelLoad"
        PanelLoad.Size = New Size(800, 450)
        PanelLoad.TabIndex = 0
        ' 
        ' PanelUC
        ' 
        PanelUC.Dock = DockStyle.Fill
        PanelUC.Location = New Point(0, 0)
        PanelUC.Name = "PanelUC"
        PanelUC.Size = New Size(800, 450)
        PanelUC.TabIndex = 0
        ' 
        ' TimerMenu
        ' 
        TimerMenu.Interval = 50
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblUser)
        Panel1.Controls.Add(IconPictureBox4)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 396)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 54)
        Panel1.TabIndex = 6
        ' 
        ' MAINFORM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PanelMenu)
        Controls.Add(PanelLoad)
        Name = "MAINFORM"
        Text = "CPC | AVIATION"
        PanelMenu.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PanelLoad.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLoad As Panel
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCrew As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnShedule As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TimerMenu As Timer
    Friend WithEvents PanelUC As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
End Class
