
Imports System.Data.SqlClient
Imports System.Globalization

Module FLUpdateModule
    '========================================> Update flight details
    Public Sub updateFlight(connsql As SqlConnection,
                            lbselectID As Label,
                            tbflightNo As TextBox,
                            cbarlinecategory As ComboBox,
                            cbStd As ComboBox,
                            cbStd1 As ComboBox,
                            cbDT As ComboBox,
                            dtp As DateTimePicker)

        ' Open database connection 
        connsql.Open()

        Using transaction1 As SqlTransaction = connsql.BeginTransaction()
            Try
                ' Create command object
                Dim cmd As New SqlCommand()
                cmd.Connection = connsql
                cmd.Transaction = transaction1
                cmd.CommandType = CommandType.Text

                ' Update first table
                cmd.CommandText = "UPDATE FLIGHT_MASTER_TABLE SET FLIGHT_NO = @Flight_No,AIRLINE_CODE = @Airline_Code  WHERE FID = @FID"

                cmd.Parameters.AddWithValue("@FID", lbselectID.Text)
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

                Console.WriteLine("ETA: " & eta.ToString("hh\:mm\:ss")) ' output the ETA in the format hh:mm:ss

                cmd.Parameters.AddWithValue("@FID", lbselectID.Text)
                cmd.Parameters.AddWithValue("@STD", stdTime)
                cmd.Parameters.AddWithValue("@DIP", dipartime)
                cmd.Parameters.AddWithValue("@Date", selectedDate)
                cmd.Parameters.AddWithValue("@ETA", eta)

                cmd.ExecuteNonQuery()

                ' Commit transaction if all commands succeed
                transaction1.Commit()

                ' Show success message
                Dim result As DialogResult = MessageBox.Show("Do you want to change ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' User clicked Yes
                    MsgBox("Successfully Updated ")
                End If
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
        lbselectID.Text = ""
        tbflightNo.Text = ""
        cbarlinecategory.SelectedIndex = -1
        cbStd.SelectedIndex = -1
        cbStd1.SelectedIndex = -1
        cbDT.SelectedIndex = -1
        'dtp.Value = DateTime.MinValue


    End Sub

End Module
