
Imports System.Windows

Public Class MAINFORM

    Dim sidebar As String = "Open"
    Private Sub MAINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        PanelMenu.Width = 50
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        TimerMenu.Start()
    End Sub

    Private Sub TimerMenu_Tick(sender As Object, e As EventArgs) Handles TimerMenu.Tick

        If sidebar = "Open" Then
            PanelMenu.Width += 50
            If PanelMenu.Width >= 200 Then
                sidebar = "Close"
                TimerMenu.Stop()
            End If
        Else
            PanelMenu.Width -= 50
            If PanelMenu.Width <= 50 Then
                sidebar = "Open"
                TimerMenu.Stop()
            End If
        End If

    End Sub


End Class