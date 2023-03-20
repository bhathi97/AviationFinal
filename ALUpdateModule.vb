Imports System.Data.SqlClient

Module ALUpdateModule

    Public Sub UpdateAirLineDetail(tbCode As TextBox, tbName As TextBox, lblCode As Label, connsql As SqlConnection)

        'Check whether id is null or empty
        If String.IsNullOrEmpty(lblCode.ToString) Then

            'check whether all the fields are empty
        ElseIf String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The Name Field")
            tbName.Focus()

        ElseIf String.IsNullOrEmpty(tbCode.Text) Then
            MsgBox("Fill The Code Field")
            tbCode.Focus()

        Else
            ' open database connection 
            connsql.Open()
            Dim cd As String = lblCode.Text

            Dim queryString As String = "SELECT COUNT(*) FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @Input1"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@Input1", cd)

            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("Airline is already exists in database")
            Else
                connsql.Open()
                Dim cmd As New SqlCommand("UPDATE [AIRLINE_MASTER_TABLE] SET [AIRLINE_CODE] = @code, [AIRLINE_NAME] = @name WHERE [AIRLINE_CODE] = @lbl", connsql)
                cmd.Parameters.AddWithValue("@code", tbCode.Text)
                cmd.Parameters.AddWithValue("@name", tbName.Text)
                cmd.Parameters.AddWithValue("@lbl", lblCode.Text)
                'confirmation DialogBox
                Dim result As DialogResult = MessageBox.Show("Do you want to change Airline Details?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    'if User clicked Yes
                    MsgBox(tbName.Text & "Successfully Updated")
                    cmd.ExecuteNonQuery()

                End If
                connsql.Close()
            End If
        End If

    End Sub

End Module
