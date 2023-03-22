
Imports System.Data.SqlClient

Module LFLoginModule

    'login
    Public Sub login(tbUName As TextBox, tbPS As TextBox, connsql As SqlConnection, obj As Form)

        ' check whether all the fields are empty
        If String.IsNullOrEmpty(tbUName.Text) Then
            MsgBox("Fill The Name Field")
            tbUName.Focus()

        ElseIf String.IsNullOrEmpty(tbPS.Text) Then
            MsgBox("Fill The Password Field")
            tbPS.Focus()

        Else
            'when all the fields are filled
            'Open database connection 
            connsql.Open()
            Dim namen As String
            Dim pass As String
            namen = tbUName.Text
            pass = tbPS.Text

            'check whether the USER name and PASSWORD are correct
            Dim queryString As String = "SELECT COUNT(*) FROM LOGIN_TABLE WHERE USERNAME = @user AND PASSWORD = @password"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@user", namen)
            commandc.Parameters.AddWithValue("@password", pass)
            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())

            If count > 0 Then
                Dim cString As String = "SELECT TYPE FROM LOGIN_TABLE WHERE USERNAME = @user AND PASSWORD = @password"
                Dim comType As New SqlCommand(cString, connsql)
                comType.Parameters.AddWithValue("@user", namen)
                comType.Parameters.AddWithValue("@password", pass)
                Dim typeValue As String = comType.ExecuteScalar().ToString()

                If typeValue = "USER" Then
                    'login successful
                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.btnCrew.Hide()
                    form.btnFlight.Hide()
                    form.Show()
                    obj.Hide()
                ElseIf typeValue = "ADMIN" Then
                    'login successful
                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.Show()
                    obj.Hide()

                End If












            Else
                'login failed
                Dim queryString2 As String = "SELECT COUNT(*) FROM LOGIN_TABLE WHERE USERNAME = @user"
                Dim commandc2 As New SqlCommand(queryString2, connsql)
                commandc2.Parameters.AddWithValue("@user", namen)
                Dim count2 As Integer = Convert.ToInt32(commandc2.ExecuteScalar())

                If count2 > 0 Then
                    'username is correct but password is wrong
                    MsgBox("Incorrect password. Please try again.")
                    tbPS.Focus()
                    tbPS.SelectAll()
                Else
                    'username is incorrect
                    MsgBox("Username or password is wrong. Please try again.")
                    tbUName.Focus()
                End If
            End If

            connsql.Close()
        End If

    End Sub

End Module
