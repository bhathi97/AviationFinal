Imports System.Data.SqlClient

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

        Else
            'when all the fields are filled
            'Open database connection 
            connsql.Open()
            Dim name As String = tbName.Text
            Dim code As String = tbCode.Text

            'check whether the crewman name is already there. crewamn name should be unique
            Dim queryString As String = "SELECT COUNT(*) FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @Input1"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@Input1", code)

            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("Airline already exists in database")
            Else

                connsql.Open()
                'insert data to the database

                Dim sql As String = "INSERT INTO [AIRLINE_MASTER_TABLE] ([AIRLINE_CODE], [AIRLINE_NAME]) VALUES (@code, @name)"
                Dim command As New SqlCommand(sql, connsql)
                command.Parameters.AddWithValue("@code", code)
                command.Parameters.AddWithValue("@name", name)

                command.ExecuteNonQuery()
                'connection close
                connsql.Close()
                MsgBox(name & " Successfully Added To The Table")

            End If

        End If

    End Sub





End Module
