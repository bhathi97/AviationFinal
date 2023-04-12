Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module ALSaveModule

    'save ailine names and codes to the table
    Public Sub saveAirLine(tbName As TextBox, tbCode As TextBox, connsql As SqlConnection)

        'check whether all the fields are empty
        If String.IsNullOrEmpty(tbCode.Text) Then
            MsgBox("Fill The Code Field")
            tbCode.Focus()

        ElseIf String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The Name Field")
            tbName.Focus()

        ElseIf Not Regex.IsMatch(tbCode.Text, "^[A-Z]{1,10}$") Then
            MsgBox("Airline code should be uppercase letters only with maximum length of 10.")
            tbCode.Focus()

        ElseIf Not Regex.IsMatch(tbName.Text, "^[A-Z ]{1,50}$") Then
            MsgBox("Airline name should be uppercase letters only with maximum length of 50.")
            tbName.Focus()

        Else
            'when all the fields are filled and validated
            'Open database connection 
            connsql.Open()
            Dim name As String = tbName.Text
            Dim code As String = tbCode.Text

            'check whether the airline code already exists in the database
            Dim queryString As String = "SELECT COUNT(*) FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @Input1"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@Input1", code)

            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("Airline already exists in database")
            Else

                ' Prompt the user with a message box and ask for confirmation
                Dim result As DialogResult = MessageBox.Show("Do You Want To Add  " & code & "  Airline Category and " & name & " Airline Name ?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If result = DialogResult.OK Then

                    connsql.Open()
                    'insert data to the database

                    Dim sql As String = "INSERT INTO [AIRLINE_MASTER_TABLE] ([AIRLINE_CODE], [AIRLINE_NAME]) VALUES (@code, @name)"
                    Dim command As New SqlCommand(sql, connsql)
                    command.Parameters.AddWithValue("@code", code)
                    command.Parameters.AddWithValue("@name", name)

                    command.ExecuteNonQuery()
                    'connection close
                    connsql.Close()

                    ' Clear the textboxes for the next entry
                    tbCode.Clear()
                    tbName.Clear()
                    tbCode.Focus()

                Else
                    ' Close the form or do nothing
                End If

            End If

        End If
    End Sub






End Module
