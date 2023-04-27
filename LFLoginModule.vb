
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System.Windows.Forms.AxHost

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
            Dim namen As String 'login user
            Dim pass As String 'login passward
            namen = tbUName.Text
            pass = tbPS.Text


            Dim _time As TimeSpan = DateTime.Now.TimeOfDay
            Dim _date As DateTime = DateTime.Today


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

                'SUPERVISOR CAN ACCESS TIME TABLE ONLY
                If typeValue = "SUPERVISOR" Then

                    'save in the history table - ******************************
                    Dim sqlSv As String = "INSERT INTO LOGIN_HISTORY_TABLE (USERNAME, TYPE, EDIT_TIME, EDIT_DATE, ACTIVITY) VALUES (@uname, @utype, @etime, @edate, @activity)"
                    Dim commandSv As New SqlCommand(sqlSv, connsql)
                    commandSv.Parameters.AddWithValue("@uname", namen)
                    commandSv.Parameters.AddWithValue("@utype", "SUPERVISOR") '************************************************ logiging user type
                    commandSv.Parameters.AddWithValue("@etime", _time)
                    commandSv.Parameters.AddWithValue("@edate", _date)
                    commandSv.Parameters.AddWithValue("@activity", "LOGIN")
                    commandSv.ExecuteNonQuery()
                    '***********************************************************

                    'login successful

                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.btnCrew.Hide()
                    form.btnFlight.Hide()
                    form.btnAdminSetting.Hide()
                    form.User = namen
                    form.UserTypes = "SUPERVISOR"
                    form.Show()
                    obj.Hide()


                    ' ADMINISTRATOR CAN ACCESS ALL
                ElseIf typeValue = "ADMINISTRATOR" Then


                    'save in the history table - ******************************
                    Dim sqlSv As String = "INSERT INTO LOGIN_HISTORY_TABLE (USERNAME, TYPE, EDIT_TIME, EDIT_DATE, ACTIVITY) VALUES (@uname, @utype, @etime, @edate, @activity)"
                    Dim commandSv As New SqlCommand(sqlSv, connsql)
                    commandSv.Parameters.AddWithValue("@uname", namen)
                    commandSv.Parameters.AddWithValue("@utype", "ADMINISTRATOR") '************************************************ logiging user type
                    commandSv.Parameters.AddWithValue("@etime", _time)
                    commandSv.Parameters.AddWithValue("@edate", _date)
                    commandSv.Parameters.AddWithValue("@activity", "LOGIN")
                    commandSv.ExecuteNonQuery()
                    '***********************************************************

                    'login successful


                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.User = namen
                    form.UserTypes = "ADMINISTRATOR"
                    form.Show()
                    obj.Hide()

                    'SUPORTER CAN ACCESS PLANE AND CREWMEMBERS ONLY

                ElseIf typeValue = "SUPORTER" Then


                    'save in the history table - ******************************
                    Dim sqlSv As String = "INSERT INTO LOGIN_HISTORY_TABLE (USERNAME, TYPE, EDIT_TIME, EDIT_DATE, ACTIVITY) VALUES (@uname, @utype, @etime, @edate, @activity)"
                    Dim commandSv As New SqlCommand(sqlSv, connsql)
                    commandSv.Parameters.AddWithValue("@uname", namen)
                    commandSv.Parameters.AddWithValue("@utype", "SUPORTER") '************************************************ logiging user type
                    commandSv.Parameters.AddWithValue("@etime", _time)
                    commandSv.Parameters.AddWithValue("@edate", _date)
                    commandSv.Parameters.AddWithValue("@activity", "LOGIN")
                    commandSv.ExecuteNonQuery()
                    '***********************************************************

                    'login successful

                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.User = namen
                    form.UserTypes = "SUPORTER"
                    form.btnShedule.Hide()
                    form.btnAdminSetting.Hide()
                    form.Show()
                    obj.Hide()

                    'OPERATOR CAN ACCESS PLANE, CREWMEMBERS, AND LOGIN
                ElseIf typeValue = "OPERATOR" Then


                    'save in the history table - ******************************
                    Dim sqlSv As String = "INSERT INTO LOGIN_HISTORY_TABLE (USERNAME, TYPE, EDIT_TIME, EDIT_DATE, ACTIVITY) VALUES (@uname, @utype, @etime, @edate, @activity)"
                    Dim commandSv As New SqlCommand(sqlSv, connsql)
                    commandSv.Parameters.AddWithValue("@uname", namen)
                    commandSv.Parameters.AddWithValue("@utype", "OPERATOR") '************************************************ logiging user type
                    commandSv.Parameters.AddWithValue("@etime", _time)
                    commandSv.Parameters.AddWithValue("@edate", _date)
                    commandSv.Parameters.AddWithValue("@activity", "LOGIN")
                    commandSv.ExecuteNonQuery()
                    '***********************************************************

                    'login successful

                    Dim form As New MAINFORM()
                    form.lblUser.Text = namen
                    form.User = namen
                    form.UserTypes = "OPERATOR"
                    form.btnShedule.Hide()
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
