﻿
Imports System.Windows

Public Class MAINFORM

    'Define a string variable to store the state of the sidebar (open or close)
    Dim sidebarState As String = "Open"

    'Handles MyBase.Load
    Private Sub MAINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        PanelMenu.Width = 50
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


End Class