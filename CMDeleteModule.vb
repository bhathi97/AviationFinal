Imports DocumentFormat.OpenXml.Bibliography
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Irony
Imports PdfSharpCore.Pdf.Content.Objects
Imports System.Data.SqlClient

Module CMDeleteModule

    Public Sub deleteCrewmanDetail(connsql As SqlConnection, selecID As Integer, name As TextBox, group As ComboBox, position As ComboBox, user As String)

        Dim _editr As String = user
        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today

        If String.IsNullOrEmpty(selecID) Then
        Else 'if seleced id is not null
            connsql.Open()
            Dim cmd As New SqlCommand("DELETE FROM CREWMEMBERS_MASTER_TABLE WHERE ID = @ID", connsql)
            cmd.Parameters.AddWithValue("@ID", selecID)

            Dim result As DialogResult = MessageBox.Show("Do you want to delete Crewman  " + name.Text + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'if User clicked Yes
                cmd.ExecuteNonQuery()


                Dim sqlSv As String = "INSERT INTO CREWMEMBERS_HISTORY_TABLE (ID, NAME, [GROUP], POSITION, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@id, @name, @group, @position, @editor, @time, @date, @edit)"
                Dim command2 As New SqlCommand(sqlSv, connsql)

                command2.Parameters.AddWithValue("@id", selecID)
                command2.Parameters.AddWithValue("@name", name.Text)
                command2.Parameters.AddWithValue("@group", group.Text)
                command2.Parameters.AddWithValue("@position", position.Text)
                command2.Parameters.AddWithValue("@editor", _editr)
                command2.Parameters.AddWithValue("@time", _time)
                command2.Parameters.AddWithValue("@date", _date)
                command2.Parameters.AddWithValue("@edit", "DELETE")

                command2.ExecuteNonQuery()

                MsgBox(name.Text & "  IS Successfully Deleted ")

                'Clear the values in text boxes, combo boxes, and label
                name.Text = ""
                group.SelectedIndex = -1
                position.SelectedIndex = -1


            End If

            connsql.Close()

        End If

    End Sub

End Module
