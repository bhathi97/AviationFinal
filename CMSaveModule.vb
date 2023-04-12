Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module CMSaveModule

    Public Sub saveCrewman(tbName As TextBox, cbGroup As ComboBox, cbPosition As ComboBox, connsql As SqlConnection)

        ' check whether all the fields are empty
        If String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The Name Field")
            tbName.Focus()

        ElseIf String.IsNullOrEmpty(cbGroup.Text) Then
            MsgBox("Select the group")
            cbGroup.Focus()

        ElseIf String.IsNullOrEmpty(cbPosition.Text) Then
            MsgBox("Select the Position")
            cbPosition.Focus()

        ElseIf Not Regex.IsMatch(tbName.Text, "^[A-Z]{1,10}$") Then ' Validate name
            MsgBox("Crewmen name should be in uppercase only and not exceed 10 letters")
            tbName.Focus()

        Else
            'when all the fields are filled
            'Open database connection 
            connsql.Open()
            Dim namen As String
            namen = tbName.Text

            'check whether the crewman name is already there. crewamn name should be unique
            Dim queryString As String = "SELECT COUNT(*) FROM CREWMEMBERS_MASTER_TABLE WHERE Name = @userInput"
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@userInput", namen)
            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("user name already exists in database")
            Else

                connsql.Open()
                'insert data to the database
                Dim name, group, position As String
                name = tbName.Text
                group = cbGroup.Text
                position = cbPosition.Text

                Dim result As DialogResult = MessageBox.Show("Do You Want To Add  " & name & " Crewmen and " & position & " Position ?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If result = DialogResult.OK Then



                    Dim sql As String = "INSERT INTO CREWMEMBERS_MASTER_TABLE (Name, [Group], Position) VALUES (@Name, @Group, @Position)"
                    Dim command As New SqlCommand(sql, connsql)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Group", group)
                    command.Parameters.AddWithValue("@Position", position)

                    command.ExecuteNonQuery()

                    'connection close
                    connsql.Close()
                    MsgBox(name & " Successfully Added To The Table")
                End If

            End If

        End If
    End Sub



End Module
