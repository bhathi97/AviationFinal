
Imports System.Windows
Imports System.Windows.Controls
Imports DocumentFormat.OpenXml.Drawing.Diagrams

Public Class MAINFORM

    Private gridDataOfTTUserControl As DataTable ' to store grid data of TT user control 

    'Define a string variable to store the state of the sidebar (open or close)
    Dim sidebarState As String = "Open"

    'Handles MyBase.Load
    Private Sub MAINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        PanelMenu.Width = 50

        'load USER CONTROL when open the form
        Dim userControlTT As New UserControlTimeTable()
        userControlTT.Dock = DockStyle.Fill
        PanelLoad.Controls.Add(userControlTT)
        userControlTT.BringToFront()

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
            Dim userControlAF As New UserControlAF()
            userControlAF.Dock = DockStyle.Fill
            PanelLoad.Controls.Add(userControlAF)
            userControlAF.BringToFront()

            btnShedule.Enabled = True
            btnFlight.Enabled = False
            btnCrew.Enabled = True
            btnAdminSetting.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Handles btnCrew.Click
    Private Sub btnCrew_Click(sender As Object, e As EventArgs) Handles btnCrew.Click

        Try
            Dim userControlC As New UserControlCREW()
            userControlC.Dock = DockStyle.Fill
            PanelLoad.Controls.Add(userControlC)
            userControlC.BringToFront()


            btnShedule.Enabled = True
            btnFlight.Enabled = True
            btnCrew.Enabled = False
            btnAdminSetting.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnShedule.Click
    Private Sub btnShedule_Click(sender As Object, e As EventArgs) Handles btnShedule.Click
        Try

            Dim userControlTT As New UserControlTimeTable()
            userControlTT.Dock = DockStyle.Fill
            PanelLoad.Controls.Add(userControlTT)
            userControlTT.BringToFront()

            btnShedule.Enabled = False
            btnFlight.Enabled = True
            btnCrew.Enabled = True
            btnAdminSetting.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Handles btnAdminSetting.Click
    Private Sub btnAdminSetting_Click(sender As Object, e As EventArgs) Handles btnAdminSetting.Click
        Try
            Dim userControlAD As New UserControlAdminSetting()
            userControlAD.Dock = DockStyle.Fill
            PanelLoad.Controls.Add(userControlAD)
            userControlAD.BringToFront()

            btnShedule.Enabled = True
            btnFlight.Enabled = True
            btnCrew.Enabled = True
            btnAdminSetting.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnLogout.Click
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to Log Out?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                LOGINForm.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Handles MyBase.FormClosing
    Private Sub MAINFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Prompt the user to confirm the application shutdown.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks Yes, exit the application.
        If result = DialogResult.Yes Then
            LOGINForm.Show()
            Me.Close()

        Else
            ' If the user clicks No, cancel the form closing event.
            e.Cancel = True
        End If
    End Sub
End Class