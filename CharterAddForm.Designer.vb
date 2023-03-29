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
        btnNewCharter = New FontAwesome.Sharp.IconButton()
        Label20 = New Label()
        Label21 = New Label()
        cbAirCha = New ComboBox()
        Label22 = New Label()
        cbEtaMCha = New ComboBox()
        cbEtaHCha = New ComboBox()
        Label23 = New Label()
        Label24 = New Label()
        tbFlightCha = New TextBox()
        Label1 = New Label()
        lblDate = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' btnNewCharter
        ' 
        btnNewCharter.BackColor = Color.FromArgb(CByte(0), CByte(40), CByte(77))
        btnNewCharter.BackgroundImageLayout = ImageLayout.None
        btnNewCharter.Cursor = Cursors.Hand
        btnNewCharter.FlatAppearance.BorderColor = Color.FromArgb(CByte(230), CByte(230), CByte(0))
        btnNewCharter.FlatAppearance.BorderSize = 0
        btnNewCharter.FlatAppearance.MouseDownBackColor = Color.White
        btnNewCharter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(77), CByte(153), CByte(0))
        btnNewCharter.FlatStyle = FlatStyle.Flat
        btnNewCharter.ForeColor = Color.WhiteSmoke
        btnNewCharter.IconChar = FontAwesome.Sharp.IconChar.Plane
        btnNewCharter.IconColor = Color.White
        btnNewCharter.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNewCharter.IconSize = 25
        btnNewCharter.Location = New Point(46, 315)
        btnNewCharter.Name = "btnNewCharter"
        btnNewCharter.Size = New Size(166, 29)
        btnNewCharter.TabIndex = 41
        btnNewCharter.Text = "SAVE"
        btnNewCharter.TextAlign = ContentAlignment.MiddleRight
        btnNewCharter.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNewCharter.UseVisualStyleBackColor = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(44, 256)
        Label20.Name = "Label20"
        Label20.Size = New Size(63, 15)
        Label20.TabIndex = 40
        Label20.Text = "REMARKS"' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(77, 208)
        Label21.Name = "Label21"
        Label21.Size = New Size(36, 15)
        Label21.TabIndex = 38
        Label21.Text = "DATE"' 
        ' cbAirCha
        ' 
        cbAirCha.FormattingEnabled = True
        cbAirCha.Location = New Point(209, 74)
        cbAirCha.Name = "cbAirCha"
        cbAirCha.Size = New Size(164, 23)
        cbAirCha.TabIndex = 37
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(286, 124)
        Label22.Name = "Label22"
        Label22.Size = New Size(10, 15)
        Label22.TabIndex = 36
        Label22.Text = ":"' 
        ' cbEtaMCha
        ' 
        cbEtaMCha.FormattingEnabled = True
        cbEtaMCha.Location = New Point(302, 121)
        cbEtaMCha.Name = "cbEtaMCha"
        cbEtaMCha.Size = New Size(71, 23)
        cbEtaMCha.TabIndex = 35
        ' 
        ' cbEtaHCha
        ' 
        cbEtaHCha.FormattingEnabled = True
        cbEtaHCha.Location = New Point(209, 121)
        cbEtaHCha.Name = "cbEtaHCha"
        cbEtaHCha.Size = New Size(71, 23)
        cbEtaHCha.TabIndex = 34
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(77, 126)
        Label23.Name = "Label23"
        Label23.Size = New Size(89, 15)
        Label23.TabIndex = 33
        Label23.Text = "E.T.A (hh : mm)"' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(75, 79)
        Label24.Name = "Label24"
        Label24.Size = New Size(115, 15)
        Label24.TabIndex = 30
        Label24.Text = "AIRLINE CATEGORY"' 
        ' tbFlightCha
        ' 
        tbFlightCha.Location = New Point(209, 28)
        tbFlightCha.Name = "tbFlightCha"
        tbFlightCha.Size = New Size(165, 23)
        tbFlightCha.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(76, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 42
        Label1.Text = "FLIGHT NO"' 
        ' lblDate
        ' 
        lblDate.BackColor = SystemColors.ControlLightLight
        lblDate.BorderStyle = BorderStyle.FixedSingle
        lblDate.FlatStyle = FlatStyle.Flat
        lblDate.Location = New Point(209, 208)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(164, 23)
        lblDate.TabIndex = 44
        lblDate.Text = "date"
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(77, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 45
        Label2.Text = "DEPARTURE TIME"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(209, 167)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(164, 23)
        ComboBox1.TabIndex = 46
        ' 
        ' CharterAddForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(492, 411)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(lblDate)
        Controls.Add(tbFlightCha)
        Controls.Add(Label1)
        Controls.Add(btnNewCharter)
        Controls.Add(Label20)
        Controls.Add(Label21)
        Controls.Add(cbAirCha)
        Controls.Add(Label22)
        Controls.Add(cbEtaMCha)
        Controls.Add(cbEtaHCha)
        Controls.Add(Label23)
        Controls.Add(Label24)
        Name = "CharterAddForm"
        Text = "CHARTER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNewCharter As FontAwesome.Sharp.IconButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbAirCha As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbEtaMCha As ComboBox
    Friend WithEvents cbEtaHCha As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents tbFlightCha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
