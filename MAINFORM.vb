
'Imports System.Windows
Imports System.Windows.Controls
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports System.Windows.Forms

Public Class MAINFORM

    '*********************************
    'to seperate logout and close function
    'when logout, pass some value
    Private _logout As Boolean = False ' Initialize to False by default

    Public Property Logout As Boolean
        Get
            Return _logout
        End Get
        Set(ByVal value As Boolean)
            _logout = value
        End Set
    End Property

    '**********************************

    Private gridDataOfTTUserControl As DataTable ' to store grid data of TT user control 

    'Define a string variable to store the state of the sidebar (open or close)
    Dim sidebarState As String = "Open"


    '***************************************************************
    Private UserControlTT As New UserControlTimeTable()
    Private UserControlC As New UserControlCREW()
    Private UserControlAS As New UserControlAdminSetting()
    Private USerControlAF As New UserControlAF()
    '***************************************************************



    'Handles MyBase.Load
    Private Sub MAINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        PanelMenu.Width = 50

        If Not Me.Controls.Contains(UserControlTT) Then
            Me.Controls.Add(UserControlTT)
            UserControlTT.Dock = DockStyle.Fill
            PanelLoad.Controls.Add(UserControlTT)
        End If


        UserControlTT.BringToFront()


    End Sub

    'Handles btnMenu.Click
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        TimerMenu.Start()
    End Sub

    'Handles TimerMenu.Tick
    Private Sub TimerMenu_Tick(sender As Object, e As EventArgs) Handles TimerMenu.Tick

        'If the sidebar is currently open, increase its width by 50 pixels
        If sidebarState = "Open" Then
            PanelMenu.Width += 50

            'If the sidebar has reached its maximum width of 200 pixels, stop the Timer and change the sidebar state to close
            If PanelMenu.Width >= 200 Then
                sidebarState = "Close"
                TimerMenu.Stop()
            End If
        Else
            'If the sidebar is currently close, decrease its width by 50 pixels
            PanelMenu.Width -= 50

            'If the sidebar has reached its minimum width of 50 pixels, stop the Timer and change the sidebar state to open
            If PanelMenu.Width <= 50 Then
                sidebarState = "Open"
                TimerMenu.Stop()
            End If
        End If

    End Sub
    'Handles btnFlight.Click
    Private Sub btnFlight_Click(sender As Object, e As EventArgs) Handles btnFlight.Click

        Try

            If Not Me.Controls.Contains(USerControlAF) Then
                Me.Controls.Add(USerControlAF)
                USerControlAF.Dock = DockStyle.Fill
                PanelLoad.Controls.Add(USerControlAF)
            End If

            USerControlAF.BringToFront()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Handles btnCrew.Click
    Private Sub btnCrew_Click(sender As Object, e As EventArgs) Handles btnCrew.Click

        Try

            If Not Me.Controls.Contains(UserControlC) Then
                Me.Controls.Add(UserControlC)
                UserControlC.Dock = DockStyle.Fill
                PanelLoad.Controls.Add(UserControlC)
            End If

            UserControlC.BringToFront()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Handles btnAdminSetting.Click
    Private Sub btnAdminSetting_Click(sender As Object, e As EventArgs) Handles btnAdminSetting.Click
        Try
            If Not Me.Controls.Contains(UserControlAS) Then
                Me.Controls.Add(UserControlAS)
                UserControlAS.Dock = DockStyle.Fill
                PanelLoad.Controls.Add(UserControlAS)
            End If

            UserControlAS.BringToFront()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnLogout.Click
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to Log Out?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                Logout = True

                LOGINForm.Show()
                LOGINForm.tbUName.Text = ""
                LOGINForm.tbPS.Text = ""
                LOGINForm.tbUName.Focus()

                For Each form As Form In Application.OpenForms
                    If form.Name <> "LOGINForm" Then
                        form.Close()
                    End If
                Next


            End If
        Catch ex As Exception

        End Try

    End Sub

    'Handles MyBase.FormClosing
    Private Sub MAINFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Prompt the user to confirm the application shutdown.
        If Logout <> True Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Try
                ' If the user clicks Yes, exit the application.
                If result = DialogResult.OK Then

                    For Each f As Form In Application.OpenForms
                        f.Close()
                    Next

                Else
                    ' If the user clicks No, cancel the form closing event.
                    e.Cancel = True
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    'Handles btnShedule.Click
    Private Sub btnShedule_Click(sender As Object, e As EventArgs) Handles btnShedule.Click
        Try

            If Not Me.Controls.Contains(UserControlTT) Then
                Me.Controls.Add(UserControlTT)
                UserControlTT.Dock = DockStyle.Fill
                PanelLoad.Controls.Add(UserControlTT)
            End If

            UserControlTT.BringToFront()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class