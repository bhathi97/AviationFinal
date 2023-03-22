Imports System.Data.SqlClient

Module ASSaveModule
    'AS=Admin Setting
    'save ailine names and codes to the table
    Public Sub saveUser(tbName As TextBox, tbPW As TextBox, cbType As ComboBox, connsql As SqlConnection)

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
            'when all the fields are filled
            'Open database connection 
            connsql.Open()
            Dim name As String = tbName.Text
            Dim password As String = tbPW.Text
            Dim type As String = cbType.Text

            'check whether the name is already there.becoz name should be unique
            Dim queryString As String = "SELECT COUNT(*) FROM [LOGIN_TABLE] WHERE [USERNAME] = @name"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@name", name)
            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("UserName already exists in the database")
            Else

                connsql.Open()
                'insert data to the database

                Dim sql As String = "INSERT INTO [LOGIN_TABLE] (USERNAME, PASSWORD,TYPE) VALUES (@name, @pw,@type)"
                Dim command As New SqlCommand(sql, connsql)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@pw", password)
                command.Parameters.AddWithValue("@type", type)

                command.ExecuteNonQuery()
                'connection close
                connsql.Close()
                MsgBox(name & " Successfully Added To The Table")

            End If

        End If

    End Sub

End Module
