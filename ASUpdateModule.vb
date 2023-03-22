Imports System.Data.SqlClient

Module ASUpdateModule


    Public Sub UpdateUser(tbName As TextBox, tbPW As TextBox, cbType As ComboBox, connsql As SqlConnection, lbl As Label)

        'check whether all the fields are empty
        If String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The UserName Field")
            tbName.Focus()

        ElseIf String.IsNullOrEmpty(tbPW.Text) Then
            MsgBox("Fill The password Field")
            tbPW.Focus()

        ElseIf String.IsNullOrEmpty(cbType.Text) Then
            MsgBox("Select The userType")
            cbType.Focus()

        Else
            ' open database connection 
            connsql.Open()

            Dim queryString As String = "SELECT COUNT(*) FROM [LOGIN_TABLE] WHERE [USERNAME] = @name"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@name", tbName.Text)

            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("User already exists in database")
            Else
                connsql.Open()
                Dim cmd As New SqlCommand("UPDATE [LOGIN_TABLE] SET USERNAME = @name, PASSWORD = @pw, TYPE = @type WHERE USERNAME = @SName", connsql)
                cmd.Parameters.AddWithValue("@name", tbName.Text)
                cmd.Parameters.AddWithValue("@pw", tbPW.Text)
                cmd.Parameters.AddWithValue("@type", cbType.Text)
                cmd.Parameters.AddWithValue("@SName", lbl.Text)

                'confirmation DialogBox
                Dim result As DialogResult = MessageBox.Show("Do you want to change USER Details?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    'if User clicked Yes
                    MsgBox(tbName.Text & " Successfully Updated")
                    cmd.ExecuteNonQuery()

                End If
                connsql.Close()
            End If
        End If

    End Sub

End Module
