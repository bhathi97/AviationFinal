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
        btnMenu = New FontAwesome.Sharp.IconButton()
        btnCrew = New FontAwesome.Sharp.IconButton()
        btnFlight = New FontAwesome.Sharp.IconButton()
        btnShedule = New FontAwesome.Sharp.IconButton()
        PanelLoad = New Panel()
        TimerMenu = New Timer(components)
        PanelUC = New Panel()
        PanelMenu.SuspendLayout()
        Panel3.SuspendLayout()
        PanelLoad.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
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
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnMenu.BackgroundImageLayout = ImageLayout.None
        btnMenu.Cursor = Cursors.Hand
        btnMenu.Dock = DockStyle.Right
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.ForeColor = Color.White
        btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon
        btnMenu.IconColor = Color.White
        btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMenu.IconSize = 37
        btnMenu.Location = New Point(150, 0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(50, 49)
        btnMenu.TabIndex = 1
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnCrew
        ' 
        btnCrew.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnCrew.FlatAppearance.BorderSize = 0
        btnCrew.FlatStyle = FlatStyle.Flat
        btnCrew.ForeColor = Color.White
        btnCrew.IconChar = FontAwesome.Sharp.IconChar.User
        btnCrew.IconColor = Color.White
        btnCrew.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCrew.IconSize = 28
        btnCrew.ImageAlign = ContentAlignment.MiddleLeft
        btnCrew.Location = New Point(7, 167)
        btnCrew.Name = "btnCrew"
        btnCrew.Size = New Size(180, 50)
        btnCrew.TabIndex = 4
        btnCrew.Text = "    CREWMEN"
        btnCrew.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCrew.UseVisualStyleBackColor = False
        ' 
        ' btnFlight
        ' 
        btnFlight.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnFlight.FlatAppearance.BorderSize = 0
        btnFlight.FlatStyle = FlatStyle.Flat
        btnFlight.ForeColor = Color.White
        btnFlight.IconChar = FontAwesome.Sharp.IconChar.Plane
        btnFlight.IconColor = Color.White
        btnFlight.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFlight.IconSize = 30
        btnFlight.ImageAlign = ContentAlignment.MiddleLeft
        btnFlight.Location = New Point(7, 111)
        btnFlight.Name = "btnFlight"
        btnFlight.Size = New Size(180, 50)
        btnFlight.TabIndex = 3
        btnFlight.Text = "    FLIGHT"
        btnFlight.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFlight.UseVisualStyleBackColor = False
        ' 
        ' btnShedule
        ' 
        btnShedule.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnShedule.FlatAppearance.BorderSize = 0
        btnShedule.FlatStyle = FlatStyle.Flat
        btnShedule.ForeColor = Color.White
        btnShedule.IconChar = FontAwesome.Sharp.IconChar.Columns
        btnShedule.IconColor = Color.White
        btnShedule.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnShedule.IconSize = 30
        btnShedule.ImageAlign = ContentAlignment.MiddleLeft
        btnShedule.Location = New Point(6, 55)
        btnShedule.Name = "btnShedule"
        btnShedule.Size = New Size(181, 50)
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
        ' TimerMenu
        ' 
        TimerMenu.Interval = 50
        ' 
        ' PanelUC
        ' 
        PanelUC.Dock = DockStyle.Fill
        PanelUC.Location = New Point(0, 0)
        PanelUC.Name = "PanelUC"
        PanelUC.Size = New Size(800, 450)
        PanelUC.TabIndex = 0
        ' 
        ' MAINFORM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PanelMenu)
        Controls.Add(PanelLoad)
        Name = "MAINFORM"
        Text = "CPC | AVIATION"
        PanelMenu.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        PanelLoad.ResumeLayout(False)
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
End Class
