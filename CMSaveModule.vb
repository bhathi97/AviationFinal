Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module CMSaveModule



    Public Sub saveCrewman(tbName As TextBox, cbGroup As ComboBox, cbPosition As ComboBox, connsql As SqlConnection, user As String)

        Dim _editr As String = user
        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today


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



                    Dim sql As String = "INSERT INTO CREWMEMBERS_MASTER_TABLE (NAME, [GROUP], POSITION) VALUES (@Name, @Group, @Position)"
                    Dim command As New SqlCommand(sql, connsql)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Group", group)
                    command.Parameters.AddWithValue("@Position", position)


                    command.ExecuteNonQuery()

                    Dim sqlId As String = "SELECT TOP 1 ID FROM CREWMEMBERS_MASTER_TABLE ORDER BY ID DESC"
                    Dim command1 As New SqlCommand(sqlId, connsql)
                    Dim idSave As String = command1.ExecuteScalar.ToString 'load id
                    'Dim editby As String = MAINFORM.lblUser.Text 'assuming editor is the logged user
                    'MsgBox(idSave)

                    Dim sqlSv As String = "INSERT INTO CREWMEMBERS_HISTORY_TABLE (ID, NAME, [GROUP], POSITION, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@id, @name, @group, @position, @editor, @time, @date, @edit)"
                    Dim command2 As New SqlCommand(sqlSv, connsql)
                    command2.Parameters.AddWithValue("@id", idSave)
                    command2.Parameters.AddWithValue("@name", name)
                    command2.Parameters.AddWithValue("@group", group)
                    command2.Parameters.AddWithValue("@position", position)
                    command2.Parameters.AddWithValue("@editor", _editr)
                    command2.Parameters.AddWithValue("@time", _time)
                    command2.Parameters.AddWithValue("@date", _date)
                    command2.Parameters.AddWithValue("@edit", "NEW")

                    command2.ExecuteNonQuery()


                    'connection close
                    connsql.Close()
                    MsgBox(name & " Successfully Added To The Table")
                End If

            End If

        End If
    End Sub



End Module
