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
        Panel1 = New Panel()
        btnCrew = New FontAwesome.Sharp.IconButton()
        btnFlight = New FontAwesome.Sharp.IconButton()
        btnShedule = New FontAwesome.Sharp.IconButton()
        btnMenu = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Panel1.Controls.Add(btnCrew)
        Panel1.Controls.Add(btnFlight)
        Panel1.Controls.Add(btnShedule)
        Panel1.Controls.Add(btnMenu)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(209, 450)
        Panel1.TabIndex = 0
        ' 
        ' btnCrew
        ' 
        btnCrew.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnCrew.FlatAppearance.BorderSize = 0
        btnCrew.FlatStyle = FlatStyle.Flat
        btnCrew.ForeColor = Color.White
        btnCrew.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnCrew.IconColor = Color.White
        btnCrew.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCrew.IconSize = 40
        btnCrew.ImageAlign = ContentAlignment.MiddleLeft
        btnCrew.Location = New Point(5, 181)
        btnCrew.Name = "btnCrew"
        btnCrew.Size = New Size(200, 50)
        btnCrew.TabIndex = 4
        btnCrew.Text = "IconButton3"
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
        btnFlight.IconSize = 40
        btnFlight.ImageAlign = ContentAlignment.MiddleLeft
        btnFlight.Location = New Point(5, 125)
        btnFlight.Name = "btnFlight"
        btnFlight.Size = New Size(200, 50)
        btnFlight.TabIndex = 3
        btnFlight.Text = "IconButton2"
        btnFlight.UseVisualStyleBackColor = False
        ' 
        ' btnShedule
        ' 
        btnShedule.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnShedule.FlatAppearance.BorderSize = 0
        btnShedule.FlatStyle = FlatStyle.Flat
        btnShedule.ForeColor = Color.White
        btnShedule.IconChar = FontAwesome.Sharp.IconChar.Table
        btnShedule.IconColor = Color.White
        btnShedule.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnShedule.IconSize = 40
        btnShedule.ImageAlign = ContentAlignment.MiddleLeft
        btnShedule.Location = New Point(5, 69)
        btnShedule.Name = "btnShedule"
        btnShedule.Size = New Size(200, 50)
        btnShedule.TabIndex = 2
        btnShedule.Text = "IconButton1"
        btnShedule.UseVisualStyleBackColor = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnMenu.BackgroundImageLayout = ImageLayout.None
        btnMenu.Cursor = Cursors.Hand
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.ForeColor = Color.White
        btnMenu.IconChar = FontAwesome.Sharp.IconChar.List
        btnMenu.IconColor = Color.White
        btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMenu.IconSize = 38
        btnMenu.Location = New Point(162, 7)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(41, 42)
        btnMenu.TabIndex = 1
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 450)
        Panel2.TabIndex = 0
        ' 
        ' MAINFORM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "MAINFORM"
        Text = "MAINFORM"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCrew As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFlight As FontAwesome.Sharp.IconButton
    Friend WithEvents btnShedule As FontAwesome.Sharp.IconButton
End Class
