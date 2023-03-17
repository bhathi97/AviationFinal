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
        Panel1 = New Panel()
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
        Label8 = New Label()
        cbDT = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
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
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 475)
        Panel1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.Window
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(389, 182)
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
        Label7.Location = New Point(369, 181)
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
        Label5.Location = New Point(291, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 20)
        Label5.TabIndex = 9
        Label5.Text = ":"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbStd1
        ' 
        cbStd1.FormattingEnabled = True
        cbStd1.Location = New Point(311, 182)
        cbStd1.Name = "cbStd1"
        cbStd1.Size = New Size(50, 23)
        cbStd1.TabIndex = 8
        ' 
        ' cbStd
        ' 
        cbStd.FormattingEnabled = True
        cbStd.Location = New Point(235, 182)
        cbStd.Name = "cbStd"
        cbStd.Size = New Size(50, 23)
        cbStd.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 15)
        Label4.TabIndex = 6
        Label4.Text = "S.T.D (hh:mm:ss)" ' 
        ' lblAName
        ' 
        lblAName.BackColor = SystemColors.Window
        lblAName.BorderStyle = BorderStyle.FixedSingle
        lblAName.Location = New Point(235, 141)
        lblAName.Name = "lblAName"
        lblAName.Size = New Size(204, 23)
        lblAName.TabIndex = 5
        lblAName.Text = "Label4" ' 
        ' cbairlinecategory
        ' 
        cbairlinecategory.FormattingEnabled = True
        cbairlinecategory.Location = New Point(235, 109)
        cbairlinecategory.Name = "cbairlinecategory"
        cbairlinecategory.Size = New Size(204, 23)
        cbairlinecategory.TabIndex = 4
        ' 
        ' tbflightNo
        ' 
        tbflightNo.Location = New Point(235, 65)
        tbflightNo.Name = "tbflightNo"
        tbflightNo.Size = New Size(204, 23)
        tbflightNo.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 2
        Label3.Text = "AIRLINE CATEGORY" ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(99, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "FLIGHT NO" ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(68, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 24)
        Label1.TabIndex = 0
        Label1.Text = "FLIGHT DETAILS" ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(478, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(276, 475)
        Panel2.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(99, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 15)
        Label8.TabIndex = 13
        Label8.Text = "DEPARTURE TIME" ' 
        ' cbDT
        ' 
        cbDT.FormattingEnabled = True
        cbDT.Location = New Point(235, 223)
        cbDT.Name = "cbDT"
        cbDT.Size = New Size(204, 23)
        cbDT.TabIndex = 14
        ' 
        ' UserControlAF
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UserControlAF"
        Size = New Size(754, 475)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
End Class
