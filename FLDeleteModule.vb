Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Globalization

Module FLDeleteModule


    Public Sub deleteFlight(connsql As SqlConnection,
                            lbselectID As Integer,
                            tbflightNo As TextBox,
                            cbarlinecategory As ComboBox,
                            cbStd As ComboBox,
                            cbStd1 As ComboBox,
                            cbDT As ComboBox,
                            users As String)

        Dim _time As TimeSpan = DateTime.Now.TimeOfDay
        Dim _date As DateTime = DateTime.Today


        Dim sflightNumber As String
        Dim sAirLineCat As String
        Dim sSTD As TimeSpan
        Dim sDipTime As TimeSpan
        Dim sETA As TimeSpan
        Dim sDate As DateTime

        Try
            If String.IsNullOrWhiteSpace(lbselectID) Then
                ' No ID selected
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the record? " & lbselectID, "Confirmation", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    connsql.Open()

                    Try

                        'get data from the datatable
                        'flight time table
                        Dim getFromFTTable As String = "SELECT a.FLIGHT_NO, a.AIRLINE_CODE, b.STD, b.DIP_TIME, b.ETA, b.DATE FROM FLIGHT_MASTER_TABLE AS a INNER JOIN FLIGHT_TIME_TABLE AS b ON a.FID = b.FID WHERE a.FID = @FID"

                        'command object to execute the query
                        Dim getFromFTTablecommand As New SqlCommand(getFromFTTable, connsql)
                        getFromFTTablecommand.Parameters.AddWithValue("@FID", lbselectID)
                        'execute the query
                        Dim getFromFTTableReader As SqlDataReader = getFromFTTablecommand.ExecuteReader()

                        getFromFTTableReader.Read()
                        sflightNumber = getFromFTTableReader.GetString(0)
                        sAirLineCat = getFromFTTableReader.GetString(1)
                        sSTD = getFromFTTableReader.GetTimeSpan(2)
                        sDipTime = getFromFTTableReader.GetTimeSpan(3)
                        sETA = getFromFTTableReader.GetTimeSpan(4)
                        sDate = getFromFTTableReader.GetDateTime(5)

                        getFromFTTableReader.Close()

                        '********************************** save in the history table

                        Dim sqlSv As String = "INSERT INTO FLIGHT_MASTER_HISTORY_TABLE (FID, FLIGHT_NO, AIRLINE_CODE, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@fid, @fno, @ac, @editor, @time, @date, @edit)"
                        Dim commandSv As New SqlCommand(sqlSv, connsql)
                        commandSv.Parameters.AddWithValue("@fid", lbselectID)
                        commandSv.Parameters.AddWithValue("@fno", sflightNumber)
                        commandSv.Parameters.AddWithValue("@ac", sAirLineCat)
                        commandSv.Parameters.AddWithValue("@editor", users)
                        commandSv.Parameters.AddWithValue("@time", _time)
                        commandSv.Parameters.AddWithValue("@date", _date)
                        commandSv.Parameters.AddWithValue("@edit", "DELETE")

                        commandSv.ExecuteNonQuery()

                        '************************************************************

                        '********************************************** history save
                        Dim sqlSv1 As String = "INSERT INTO FLIGHT_TIME_HISTORY_TABLE (FID, STD, [DIP_TIME], DATE, ETA, EDITOR, EDIT_TIME, EDIT_DATE, EDIT) VALUES (@fid, @std, @dtime, @date, @eta, @editor, @etime, @edate, @edit)"
                        Dim commandSv1 As New SqlCommand(sqlSv1, connsql)
                        commandSv1.Parameters.AddWithValue("@fid", lbselectID)
                        commandSv1.Parameters.AddWithValue("@std", sSTD)
                        commandSv1.Parameters.AddWithValue("@dtime", sDipTime)
                        commandSv1.Parameters.AddWithValue("@date", sDate)
                        commandSv1.Parameters.AddWithValue("@eta", sETA)
                        commandSv1.Parameters.AddWithValue("@editor", users)
                        commandSv1.Parameters.AddWithValue("@etime", _time)
                        commandSv1.Parameters.AddWithValue("@edate", _date)
                        commandSv1.Parameters.AddWithValue("@edit", "DELETE")
                        commandSv1.ExecuteNonQuery()
                        '***********************************************************

                        Dim cmd As New SqlCommand("DELETE FROM FLIGHT_TIME_TABLE WHERE FID = @FID", connsql)
                        cmd.Parameters.AddWithValue("@FID", lbselectID)
                        cmd.ExecuteNonQuery()


                        Dim cmd0 As New SqlCommand("DELETE FROM FLIGHT_MASTER_TABLE WHERE FID = @FID", connsql)
                        cmd0.Parameters.AddWithValue("@FID", lbselectID)
                        cmd0.ExecuteNonQuery()

                        MsgBox("Record deleted successfully.")

                    Catch ex As SqlException
                        MsgBox("SQL Error occurred: " & ex.Message)
                    End Try

                    connsql.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("SQL Error occurred: " & ex.Message)
        Finally
            connsql.Close()
        End Try


        'clear data entering fields

        tbflightNo.Text = ""
        cbarlinecategory.SelectedIndex = -1
        cbStd.SelectedIndex = -1
        cbStd1.SelectedIndex = -1
        cbDT.SelectedIndex = -1
        'dtp.Value = DateTime.MinValue


    End Sub



End Module
