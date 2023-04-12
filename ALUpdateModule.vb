Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module ALUpdateModule

    Public Sub UpdateAirLineDetail(tbCode As TextBox, tbName As TextBox, selected As String, connsql As SqlConnection)

        Try
            ' Check whether id is null or empty
            If String.IsNullOrEmpty(selected) Then
                MsgBox("Please select an airline.")
                Return
            End If

            ' Check whether all the fields are empty
            If String.IsNullOrEmpty(tbName.Text) Then
                MsgBox("Please fill the Name field.")
                tbName.Focus()
                Return
            End If

            If String.IsNullOrEmpty(tbCode.Text) Then
                MsgBox("Please fill the Code field.")
                tbCode.Focus()
                Return
            End If

            ' Validate airline code
            If Not Regex.IsMatch(tbCode.Text, "^[A-Z]{1,10}$") Then
                MsgBox("Airline Code should be only uppercase letters and max length 10 letters")
                tbCode.Focus()
                Return
            End If

            ' Validate airline name
            If Not Regex.IsMatch(tbName.Text, "^[A-Z]{1,50}$") Then
                MsgBox("Airline Name should be only uppercase letters and max length 50 letters")
                tbName.Focus()
                Return
            End If

            ' Open database connection 
            ' Using connsql As New SqlConnection("your connection string")
            connsql.Open()


            ' Check if the airline already exists
            Dim queryString As String = "SELECT COUNT(*) FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @Input1"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@Input1", selected)

            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())

            If count > 1 Then
                MsgBox("Airline already exists in the database.")
                Return
            End If

            ' Confirmation DialogBox
            Dim result As DialogResult = MessageBox.Show("Do you want to update Airline Details?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If User clicked Yes
                Dim cmd As New SqlCommand("UPDATE [AIRLINE_MASTER_TABLE] SET [AIRLINE_CODE] = @code, [AIRLINE_NAME] = @name WHERE [AIRLINE_CODE] = @lbl", connsql)
                cmd.Parameters.AddWithValue("@code", tbCode.Text)
                cmd.Parameters.AddWithValue("@name", tbName.Text)
                cmd.Parameters.AddWithValue("@lbl", selected)

                cmd.ExecuteNonQuery()

                MsgBox("Airline details updated successfully.")
            Else
                ' If User clicked No
                MsgBox("No changes made to the airline details.")
            End If
            ' End Using

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            connsql.Close()
        End Try


    End Sub

End Module
