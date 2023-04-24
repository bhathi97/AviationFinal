
Imports System.Data.SqlClient

Module CMUpdateModule

    Public Sub UpdateCrewmanDetail(selectID As Integer, tbName As TextBox, cbGroup As ComboBox, cbPosition As ComboBox, connsql As SqlConnection, user As String)

        Dim _editr As String = user
        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today

        'Check whether id is null or empty
        If String.IsNullOrEmpty(selectID) Then

            'check whether all the fields are empty
        ElseIf String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The Name Field")
            tbName.Focus()

        ElseIf String.IsNullOrEmpty(cbGroup.Text) Then
            MsgBox("Select The Group")
            cbGroup.Focus()

        ElseIf String.IsNullOrEmpty(cbPosition.Text) Then
            MsgBox("Select The Position")
            cbPosition.Focus()

        Else
            ' open database connection 

            Dim namen As String
            namen = tbName.Text


            'validate the name field
            If Not System.Text.RegularExpressions.Regex.IsMatch(namen, "^[A-Z]{1,10}$") Then
                MsgBox("Name should be in uppercase letters only and maximum length is 10 characters")
                tbName.Focus()
                Exit Sub
            End If

            connsql.Open()
            Dim queryString As String = "SELECT COUNT(*) FROM CREWMEMBERS_MASTER_TABLE WHERE Name = @userInput and ID != @id "
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@userInput", namen)
            commandc.Parameters.AddWithValue("@id", selectID)
            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 1 Then
                MsgBox("Crewmen name already exists in database")
            Else
                connsql.Open()

                Dim Uname As String = tbName.Text
                Dim Ugroup As String = cbGroup.Text
                Dim Uposition As String = cbPosition.Text

                Dim cmd As New SqlCommand("UPDATE CREWMEMBERS_MASTER_TABLE SET Name = @Name,[Group] = @Group ,  position = @Position  WHERE ID = @lblSelectedID", connsql)
                cmd.Parameters.AddWithValue("@Name", Uname)
                cmd.Parameters.AddWithValue("@Group", Ugroup)
                cmd.Parameters.AddWithValue("@Position", Uposition)
                cmd.Parameters.AddWithValue("@lblSelectedID", selectID)
                'confirmation DialogBox
                Dim result As DialogResult = MessageBox.Show("Do you want to change Crewmen Name ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    'if User clicked Yes

                    cmd.ExecuteNonQuery()

                    Dim sqlSv As String = "INSERT INTO CREWMEMBERS_HISTORY_TABLE (ID, NAME, [GROUP], POSITION, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@id, @name, @group, @position, @editor, @time, @date, @edit)"
                    Dim command2 As New SqlCommand(sqlSv, connsql)

                    command2.Parameters.AddWithValue("@id", selectID)
                    command2.Parameters.AddWithValue("@name", Uname)
                    command2.Parameters.AddWithValue("@group", Ugroup)
                    command2.Parameters.AddWithValue("@position", Uposition)
                    command2.Parameters.AddWithValue("@editor", _editr)
                    command2.Parameters.AddWithValue("@time", _time)
                    command2.Parameters.AddWithValue("@date", _date)
                    command2.Parameters.AddWithValue("@edit", "UPDATE")

                    command2.ExecuteNonQuery()

                    MsgBox(tbName.Text & "Successfully Updated")

                End If
                connsql.Close()
            End If
        End If

    End Sub

End Module
