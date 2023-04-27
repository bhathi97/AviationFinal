Imports DocumentFormat.OpenXml.Bibliography
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Irony
Imports PdfSharpCore.Pdf.Content.Objects
Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Module CMDeleteModule

    Public Sub deleteCrewmanDetail(connsql As SqlConnection, selecID As Integer, name As TextBox, group As ComboBox, position As ComboBox, user As String)

        Dim _editr As String = user
        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today


        Dim sname As String
        Dim sgroup As String
        Dim sposition As String


        If String.IsNullOrEmpty(selecID) Then
        Else 'if seleced id is not null
            connsql.Open()

            Dim result As DialogResult = MessageBox.Show("Do you want to delete Crewman  " + name.Text + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                'load data from the database  - ***************************

                Dim getFromCMTable As String = "SELECT NAME, [GROUP], POSITION FROM CREWMEMBERS_MASTER_TABLE WHERE ID = @ID"

                'command object to execute the query
                Dim getFromCMTablecommand As New SqlCommand(getFromCMTable, connsql)
                getFromCMTablecommand.Parameters.AddWithValue("@ID", selecID)
                'execute the query
                Dim getFromCMTableReader As SqlDataReader = getFromCMTablecommand.ExecuteReader()

                getFromCMTableReader.Read()
                sname = getFromCMTableReader.GetString(0)
                sgroup = getFromCMTableReader.GetString(1)
                sposition = getFromCMTableReader.GetString(2)

                getFromCMTableReader.Close()

                '**********************************


                Dim sqlSv As String = "INSERT INTO CREWMEMBERS_HISTORY_TABLE (ID, NAME, [GROUP], POSITION, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@id, @name, @group, @position, @editor, @time, @date, @edit)"
                Dim command2 As New SqlCommand(sqlSv, connsql)

                command2.Parameters.AddWithValue("@id", selecID)
                command2.Parameters.AddWithValue("@name", sname)
                command2.Parameters.AddWithValue("@group", sgroup)
                command2.Parameters.AddWithValue("@position", sposition)
                command2.Parameters.AddWithValue("@editor", _editr)
                command2.Parameters.AddWithValue("@time", _time)
                command2.Parameters.AddWithValue("@date", _date)
                command2.Parameters.AddWithValue("@edit", "DELETE")

                command2.ExecuteNonQuery()

                MsgBox(name.Text & "  IS Successfully Deleted ")

                'if User clicked Yes delete from the database ******************************
                Dim cmd As New SqlCommand("DELETE FROM CREWMEMBERS_MASTER_TABLE WHERE ID = @ID", connsql)
                cmd.Parameters.AddWithValue("@ID", selecID)
                cmd.ExecuteNonQuery()

                'Clear the values in text boxes, combo boxes, and label
                name.Text = ""
                group.SelectedIndex = -1
                position.SelectedIndex = -1


            End If

            connsql.Close()

        End If

    End Sub

End Module
