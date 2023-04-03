<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharterAddForm
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
        btnNewChar = New FontAwesome.Sharp.IconButton()
        lblAirLineChar = New Label()
        Label21 = New Label()
        cbAirCodeCha = New ComboBox()
        Label22 = New Label()
        cbEtaMCha = New ComboBox()
        cbEtaHCha = New ComboBox()
        Label23 = New Label()
        Label24 = New Label()
        tbFlightCha = New TextBox()
        Label1 = New Label()
        lblDateCha = New Label()
        Label2 = New Label()
        cbDipTimeCha = New ComboBox()
        SuspendLayout()
        ' 
        ' btnNewChar
        ' 
        btnNewChar.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnNewChar.BackgroundImageLayout = ImageLayout.None
        btnNewChar.Cursor = Cursors.Hand
        btnNewChar.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnNewChar.FlatAppearance.BorderSize = 0
        btnNewChar.FlatAppearance.MouseDownBackColor = Color.White
        btnNewChar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnNewChar.FlatStyle = FlatStyle.Flat
        btnNewChar.ForeColor = Color.WhiteSmoke
        btnNewChar.IconChar = FontAwesome.Sharp.IconChar.Plane
        btnNewChar.IconColor = Color.White
        btnNewChar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNewChar.IconSize = 25
        btnNewChar.Location = New Point(122, 322)
        btnNewChar.Name = "btnNewChar"
        btnNewChar.Size = New Size(166, 29)
        btnNewChar.TabIndex = 41
        btnNewChar.Text = "SAVE"
        btnNewChar.TextAlign = ContentAlignment.MiddleRight
        btnNewChar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNewChar.UseVisualStyleBackColor = False
        ' 
        ' lblAirLineChar
        ' 
        lblAirLineChar.BackColor = SystemColors.ControlLightLight
        lblAirLineChar.BorderStyle = BorderStyle.FixedSingle
        lblAirLineChar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblAirLineChar.Location = New Point(182, 133)
        lblAirLineChar.Name = "lblAirLineChar"
        lblAirLineChar.Size = New Size(164, 23)
        lblAirLineChar.TabIndex = 40
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(50, 261)
        Label21.Name = "Label21"
        Label21.Size = New Size(36, 15)
        Label21.TabIndex = 38
        Label21.Text = "DATE"' 
        ' cbAirCodeCha
        ' 
        cbAirCodeCha.FormattingEnabled = True
        cbAirCodeCha.Location = New Point(182, 104)
        cbAirCodeCha.Name = "cbAirCodeCha"
        cbAirCodeCha.Size = New Size(164, 23)
        cbAirCodeCha.TabIndex = 37
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(259, 176)
        Label22.Name = "Label22"
        Label22.Size = New Size(10, 15)
        Label22.TabIndex = 36
        Label22.Text = ":"' 
        ' cbEtaMCha
        ' 
        cbEtaMCha.FormattingEnabled = True
        cbEtaMCha.Location = New Point(275, 173)
        cbEtaMCha.Name = "cbEtaMCha"
        cbEtaMCha.Size = New Size(71, 23)
        cbEtaMCha.TabIndex = 35
        ' 
        ' cbEtaHCha
        ' 
        cbEtaHCha.FormattingEnabled = True
        cbEtaHCha.Location = New Point(182, 173)
        cbEtaHCha.Name = "cbEtaHCha"
        cbEtaHCha.Size = New Size(71, 23)
        cbEtaHCha.TabIndex = 34
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(50, 178)
        Label23.Name = "Label23"
        Label23.Size = New Size(91, 15)
        Label23.TabIndex = 33
        Label23.Text = "S.T.D (hh : mm)"' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(48, 109)
        Label24.Name = "Label24"
        Label24.Size = New Size(115, 15)
        Label24.TabIndex = 30
        Label24.Text = "AIRLINE CATEGORY"' 
        ' tbFlightCha
        ' 
        tbFlightCha.Location = New Point(182, 58)
        tbFlightCha.Name = "tbFlightCha"
        tbFlightCha.Size = New Size(165, 23)
        tbFlightCha.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(49, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 42
        Label1.Text = "FLIGHT NO"' 
        ' lblDateCha
        ' 
        lblDateCha.BackColor = SystemColors.ControlLightLight
        lblDateCha.BorderStyle = BorderStyle.FixedSingle
        lblDateCha.FlatStyle = FlatStyle.Flat
        lblDateCha.Location = New Point(182, 260)
        lblDateCha.Name = "lblDateCha"
        lblDateCha.Size = New Size(164, 23)
        lblDateCha.TabIndex = 44
        lblDateCha.Text = "date"
        lblDateCha.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(50, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 45
        Label2.Text = "DEPARTURE TIME"' 
        ' cbDipTimeCha
        ' 
        cbDipTimeCha.FormattingEnabled = True
        cbDipTimeCha.Location = New Point(182, 219)
        cbDipTimeCha.Name = "cbDipTimeCha"
        cbDipTimeCha.Size = New Size(164, 23)
        cbDipTimeCha.TabIndex = 46
        ' 
        ' CharterAddForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 411)
        Controls.Add(cbDipTimeCha)
        Controls.Add(Label2)
        Controls.Add(lblDateCha)
        Controls.Add(tbFlightCha)
        Controls.Add(Label1)
        Controls.Add(btnNewChar)
        Controls.Add(lblAirLineChar)
        Controls.Add(Label21)
        Controls.Add(cbAirCodeCha)
        Controls.Add(Label22)
        Controls.Add(cbEtaMCha)
        Controls.Add(cbEtaHCha)
        Controls.Add(Label23)
        Controls.Add(Label24)
        MaximumSize = New Size(420, 450)
        Name = "CharterAddForm"
        Opacity = 0.9R
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "CHARTER FLIGHT ADD"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNewChar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblAirLineChar As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbAirCodeCha As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbEtaMCha As ComboBox
    Friend WithEvents cbEtaHCha As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents tbFlightCha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateCha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDipTimeCha As ComboBox
End Class
