Imports System.Data.SqlClient
Imports System.Windows.Interop
Imports PdfSharpCore.Pdf.Content.Objects

Public Class LOGINForm



    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(Str)


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


End Class