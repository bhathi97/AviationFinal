
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports DocumentFormat.OpenXml.Spreadsheet

Module FLUpdateModule
    '========================================> Update flight details
    Public Sub updateFlight(connsql As SqlConnection,
                            lbselectID As Integer,
                            tbflightNo As TextBox,
                            cbarlinecategory As ComboBox,
                            cbStd As ComboBox,
                            cbStd1 As ComboBox,
                            cbDT As ComboBox,
                            dtp As DateTimePicker,
                            users As String)

        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today

        ' Open database connection 
        connsql.Open()

        Using transaction1 As SqlTransaction = connsql.BeginTransaction()
            Try
                ' Create command object
                Dim cmd As New SqlCommand()
                cmd.Connection = connsql
                cmd.Transaction = transaction1
                cmd.CommandType = CommandType.Text

                ' Validate Flight_No
                Dim flightNoRegex As New Regex("^[0-9]+$") ' Only allow digits 0-9
                If Not flightNoRegex.IsMatch(tbflightNo.Text) Then
                    ' Flight_No contains non-numeric characters
                    MessageBox.Show("Flight number should only contain numbers.")
                    Return ' Exit the method without executing the SQL commands
                End If


                ' Update first table
                cmd.CommandText = "UPDATE FLIGHT_MASTER_TABLE SET FLIGHT_NO = @Flight_No,AIRLINE_CODE = @Airline_Code  WHERE FID = @FID"

                cmd.Parameters.AddWithValue("@FID", lbselectID)
                cmd.Parameters.AddWithValue("@Flight_No", tbflightNo.Text)
                cmd.Parameters.AddWithValue("@Airline_Code", cbarlinecategory.Text)

                cmd.ExecuteNonQuery()



                ' Update second table
                cmd.CommandText = "UPDATE FLIGHT_TIME_TABLE SET STD = @STD, [DIP_TIME] = @DIP , DATE = @Date, ETA = @ETA  WHERE FID = @FID"

                ' Clear parameters from previous command
                cmd.Parameters.Clear()

                ' Add parameters for second command
                Dim std As String = cbStd.Text & ":" & cbStd1.Text & ":00"
                Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim stdTime As TimeSpan = dt.TimeOfDay
                Dim dipT As String = cbDT.Text & ":00"
                Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim sTime As TimeSpan = dipTime.TimeOfDay
                'Dim eta As TimeSpan = stdTime - sTime
                Dim dipartime As TimeSpan = TimeSpan.Parse(cbDT.Text)
                Dim selectedDate As DateTime = dtp.Value

                Dim eta As TimeSpan
                If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                    eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
                Else ' if the standard time is later than the dip time, subtract the two times
                    eta = stdTime - sTime
                End If


                cmd.Parameters.AddWithValue("@FID", lbselectID)
                cmd.Parameters.AddWithValue("@STD", stdTime)
                cmd.Parameters.AddWithValue("@DIP", dipartime)
                cmd.Parameters.AddWithValue("@Date", selectedDate)
                cmd.Parameters.AddWithValue("@ETA", eta)

                ' Show confirmation message box
                Dim result As DialogResult = MessageBox.Show("Do you want to update flight details ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Commit transaction if user clicked Yes
                    transaction1.Commit()
                    ' Execute the SQL command
                    cmd.ExecuteNonQuery()


                    '********************************** save in the history table

                    Dim sqlSv As String = "INSERT INTO FLIGHT_MASTER_HISTORY_TABLE (FID, FLIGHT_NO, AIRLINE_CODE, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@fid, @fno, @ac, @editor, @time, @date, @edit)"
                    Dim commandSv As New SqlCommand(sqlSv, connsql)
                    commandSv.Parameters.AddWithValue("@fid", lbselectID)
                    commandSv.Parameters.AddWithValue("@fno", tbflightNo.Text)
                    commandSv.Parameters.AddWithValue("@ac", cbarlinecategory.Text)
                    commandSv.Parameters.AddWithValue("@editor", users)
                    commandSv.Parameters.AddWithValue("@time", _time)
                    commandSv.Parameters.AddWithValue("@date", _date)
                    commandSv.Parameters.AddWithValue("@edit", "UPDATE")

                    commandSv.ExecuteNonQuery()

                    '************************************************************



                    '********************************************** history save
                    Dim sqlSv1 As String = "INSERT INTO FLIGHT_TIME_HISTORY_TABLE (FID, STD, [DIP_TIME], DATE, ETA, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@fid, @std, @dtime, @date, @eta, @editor, @etime, @edate, @edit)"
                    Dim commandSv1 As New SqlCommand(sqlSv1, connsql)
                    commandSv1.Parameters.AddWithValue("@fid", lbselectID)
                    commandSv1.Parameters.AddWithValue("@std", stdTime)
                    commandSv1.Parameters.AddWithValue("@dtime", dipartime)
                    commandSv1.Parameters.AddWithValue("@date", selectedDate)
                    commandSv1.Parameters.AddWithValue("@eta", eta)
                    commandSv1.Parameters.AddWithValue("@editor", users)
                    commandSv1.Parameters.AddWithValue("@etime", _time)
                    commandSv1.Parameters.AddWithValue("@edate", _date)
                    commandSv1.Parameters.AddWithValue("@edit", "UPDATE")

                    commandSv1.ExecuteNonQuery()

                    '***********************************************************



                    ' Show success message
                    MsgBox("Successfully  Updated.")
                ElseIf result = DialogResult.No Then
                    ' Roll back the transaction if user clicked No
                    transaction1.Rollback()

                End If

                ' Close the connection
                connsql.Close()
            Catch ex As Exception
                ' Roll back the transaction if any error occurs
                transaction1.Rollback()
                MsgBox(ex.Message)
            End Try
        End Using

        ' Close the connection
        connsql.Close()

        'clear data entering fields
        lbselectID = 0
        tbflightNo.Text = ""
        cbarlinecategory.SelectedIndex = -1
        cbStd.SelectedIndex = -1
        cbStd1.SelectedIndex = -1
        cbDT.SelectedIndex = -1
        'dtp.Value = DateTime.MinValue


    End Sub

End Module
