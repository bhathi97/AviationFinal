<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGINForm
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
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        tbUName = New TextBox()
        tbPS = New TextBox()
        cbSP = New CheckBox()
        btnLogin = New FontAwesome.Sharp.IconButton()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(266, 474)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 15)
        Label4.TabIndex = 4
        Label4.Text = "Ceylon Petroleum Corporation - Aviation Function "' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(84, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 0
        Label2.Text = "USERNAME"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(84, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 1
        Label3.Text = "PASSWORD"' 
        ' tbUName
        ' 
        tbUName.Location = New Point(84, 163)
        tbUName.Name = "tbUName"
        tbUName.Size = New Size(200, 23)
        tbUName.TabIndex = 2
        ' 
        ' tbPS
        ' 
        tbPS.Location = New Point(84, 226)
        tbPS.Name = "tbPS"
        tbPS.Size = New Size(200, 23)
        tbPS.TabIndex = 3
        ' 
        ' cbSP
        ' 
        cbSP.AutoSize = True
        cbSP.ForeColor = Color.White
        cbSP.Location = New Point(85, 251)
        cbSP.Name = "cbSP"
        cbSP.Size = New Size(108, 19)
        cbSP.TabIndex = 4
        cbSP.Text = "Show Password"
        cbSP.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnLogin.FlatAppearance.BorderColor = SystemColors.ButtonFace
        btnLogin.FlatAppearance.MouseDownBackColor = Color.White
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(60), CByte(179))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.IconChar = FontAwesome.Sharp.IconChar.None
        btnLogin.IconColor = Color.Black
        btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogin.Location = New Point(84, 303)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(200, 30)
        btnLogin.TabIndex = 5
        btnLogin.Text = "SIGN IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        IconPictureBox1.ForeColor = SystemColors.ButtonHighlight
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserShield
        IconPictureBox1.IconColor = SystemColors.ButtonHighlight
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 61
        IconPictureBox1.Location = New Point(155, 55)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(63, 61)
        IconPictureBox1.TabIndex = 6
        IconPictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(119, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 30)
        Label1.TabIndex = 1
        Label1.Text = "USER LOGIN "' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(cbSP)
        Panel2.Controls.Add(tbPS)
        Panel2.Controls.Add(tbUName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(231, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(366, 386)
        Panel2.TabIndex = 3
        ' 
        ' LOGINForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.LOGIN
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 561)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        DoubleBuffered = True
        ForeColor = Color.White
        MaximumSize = New Size(800, 600)
        Name = "LOGINForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN - DAILY WORK SCHEDULE"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUName As TextBox
    Friend WithEvents tbPS As TextBox
    Friend WithEvents cbSP As CheckBox
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
