Imports System.Data.SqlClient
Imports System.Windows.Interop
Imports PdfSharpCore.Pdf.Content.Objects

Public Class LOGINForm

    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Dim connsql As New SqlConnection(str)

    'Handles MyBase.Load
    Private Sub LOGINForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' hide password when typing
        tbPS.UseSystemPasswordChar = True


    End Sub

    'Handles cbSP.CheckedChanged
    Private Sub cbSP_CheckedChanged(sender As Object, e As EventArgs) Handles cbSP.CheckedChanged
        If cbSP.Checked Then
            tbPS.UseSystemPasswordChar = False
        Else
            tbPS.UseSystemPasswordChar = True
        End If
    End Sub

    ' Handles btnLogin.Click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            LFLoginModule.login(tbUName, tbPS, connsql, Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles MyBase.FormClosing
    Private Sub LOGINForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Prompt the user to confirm the application shutdown.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks Yes, exit the application.
        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            ' If the user clicks No, cancel the form closing event.
            e.Cancel = True
        End If
    End Sub


End Class