Imports DocumentFormat.OpenXml.Bibliography
Imports DocumentFormat.OpenXml.VariantTypes
Imports System.Data.SqlClient
Imports System.Globalization

Module FLSaveModule

    Public Sub flightSave(tbFlightNo As TextBox,
                          cbarlinecategory As ComboBox,
                          cbStd As ComboBox,
                          cbStd1 As ComboBox,
                          cbDT As ComboBox,
                          dtpDate As DateTimePicker,
                          connsql As SqlConnection,
                          lblID As Label)




        'check whether all the fields are empty
        If String.IsNullOrEmpty(tbFlightNo.Text) Then
            MsgBox("FILL The Field")
            tbFlightNo.Focus()

        ElseIf String.IsNullOrEmpty(cbarlinecategory.Text) Then
            MsgBox("FILL The Field")
            cbarlinecategory.Focus()


        ElseIf String.IsNullOrEmpty(cbStd.Text) Then
            MsgBox("FILL The Field")
            cbStd.Focus()


        ElseIf String.IsNullOrEmpty(cbStd1.Text) Then
            MsgBox("FILL The Field")
            cbStd1.Focus()


        ElseIf String.IsNullOrEmpty(cbDT.Text) Then
            MsgBox("FILL The Field")
            cbDT.Focus()

        ElseIf String.IsNullOrEmpty(dtpDate.Text) Then
            dtpDate.Focus()


        Else

            'open database connection 

            connsql.Open()
            Dim fno As Integer
            fno = tbFlightNo.Text

            'chek entered data already exist
            Dim queryString As String = "SELECT COUNT(*) FROM [FLIGHT_MASTER_TABLE] WHERE Flight_No = @userInput1"
            Dim commandD As New SqlCommand(queryString, connsql)
            commandD.Parameters.AddWithValue("@userInput1", fno)
            Dim countC As Integer = Convert.ToInt32(commandD.ExecuteScalar())
            connsql.Close()
            If countC > 0 Then

                MsgBox("fligh no already exists in database")

            Else

                connsql.Open()
                ' insert data to the database

                Dim flightNo As Integer
                Dim ACateogry As String
                flightNo = Integer.Parse(tbFlightNo.Text)
                ACateogry = cbarlinecategory.Text

                'insert flight no, airline code to the flight master table + generate fid


                Dim sql As String = "INSERT INTO FLIGHT_MASTER_TABLE (Flight_No, Airline_Code) VALUES (@Flight_No, @Airline_Code)"
                Dim command1 As New SqlCommand(sql, connsql)
                command1.Parameters.AddWithValue("@Flight_No", flightNo)
                command1.Parameters.AddWithValue("@Airline_Code", ACateogry)
                command1.ExecuteNonQuery()
                connsql.Close()

                'retrieve fid 
                Dim command2 As New SqlCommand("SELECT TOP 1 FID  FROM FLIGHT_MASTER_TABLE ORDER BY FID DESC", connsql)
                connsql.Open()
                Dim fid As String = command2.ExecuteScalar().ToString() '======================================================
                connsql.Close()
                'insert std,dep time,date to the flight time table



                ' Create a query to retrieve the rows of the selected id from both tables
                Dim query As String = "SELECT * FROM FLIGHT_MASTER_TABLE INNER JOIN FLIGHT_TIME_TABLE ON FLIGHT_MASTER_TABLE.FID = FLIGHT_TIME_TABLE.FID WHERE 
                                            FLIGHT_MASTER_TABLE.FID = @FID"

                'Execute the query and retrieve the data into a DataTable object
                Dim cmdd As New SqlCommand(query, connsql)
                ' Dim selectId As New Integer
                cmdd.Parameters.AddWithValue("@FID", lblID.Text)
                Dim adapter As New SqlDataAdapter(cmdd)


                Dim std As String = cbStd.Text & ":" & cbStd1.Text & ":00"
                Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim stdTime As TimeSpan = dt.TimeOfDay '==========================================================> std

                Dim dipT As String = cbDT.Text & ":00"
                Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim sTime As TimeSpan = dipTime.TimeOfDay

                Dim eta As TimeSpan
                If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                    eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
                Else ' if the standard time is later than the dip time, subtract the two times
                    eta = stdTime - sTime
                End If

                Console.WriteLine("ETA: " & eta.ToString("hh\:mm\:ss")) ' output the ETA in the format hh:mm:ss

                Dim dipartime As TimeSpan = TimeSpan.Parse(cbDT.Text) '==========================> [DIP TIME]

                ' Get the selected date value from the DateTimePicker control
                Dim selectedDate As DateTime = dtpDate.Value    '======================> date

                Dim sql1 As String = "INSERT INTO FLIGHT_TIME_TABLE (FID, STD, [DIP TIME], Date, ETA) values (@FID, @STD, @DIP, @Date, @ETA)"
                connsql.Open()
                Dim com As New SqlCommand(sql1, connsql)
                com.Parameters.AddWithValue("@FID", fid)
                com.Parameters.AddWithValue("@STD", stdTime)
                com.Parameters.AddWithValue("@DIP", dipartime)
                com.Parameters.AddWithValue("@Date", selectedDate)
                com.Parameters.AddWithValue("@ETA", eta)
                com.ExecuteNonQuery()

                'connection close
                connsql.Close()
                MsgBox(" Successfully Added To The Table")
                'loadToGrid1()
            End If

        End If












    End Sub



End Module
