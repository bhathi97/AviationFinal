Imports System.Data.SqlClient
Imports System.Globalization

Module TTAddChaToDBModule

    Public Sub saveChar(tbFlightCha As TextBox,
                        cbAirCodeCha As ComboBox,
                        cbEtaHCha As ComboBox,
                        cbEtaMCha As ComboBox,
                        cbDipTimeCha As ComboBox,
                        lblDateCha As Label,
                        connsql As SqlConnection
                         )

        'check whether all the fields are empty
        If String.IsNullOrEmpty(tbFlightCha.Text) Then
            MsgBox("Fill The Field")
            tbFlightCha.Focus()

        ElseIf String.IsNullOrEmpty(cbAirCodeCha.Text) Then
            MsgBox("Fill The Airline Field")
            cbAirCodeCha.Focus()


        ElseIf String.IsNullOrEmpty(cbEtaHCha.Text) Then
            MsgBox("Select The STD hh")
            cbEtaHCha.Focus()


        ElseIf String.IsNullOrEmpty(cbEtaMCha.Text) Then
            MsgBox("Select The STD mm")
            cbEtaMCha.Focus()


        ElseIf String.IsNullOrEmpty(cbDipTimeCha.Text) Then
            MsgBox("Select The Dipature Time")
            cbDipTimeCha.Focus()

        ElseIf String.IsNullOrEmpty(lblDateCha.Text) Then
            MsgBox("Select The Date")
            lblDateCha.Focus()


        Else
            'insert data to the database
            Dim flightNo As Integer
            Dim ACateogry As String
            flightNo = Integer.Parse(tbFlightCha.Text)
            ACateogry = cbAirCodeCha.Text

            'insert flight no, airline code to the flight master table + generate fid
            'open database connection 
            connsql.Open()
            Dim sql As String = "INSERT INTO FLIGHT_MASTER_TABLE (FLIGHT_NO, AIRLINE_CODE) VALUES (@Flight_No, @Airline_Code)"
            Dim command1 As New SqlCommand(sql, connsql)
            command1.Parameters.AddWithValue("@Flight_No", flightNo)
            command1.Parameters.AddWithValue("@Airline_Code", ACateogry)
            command1.ExecuteNonQuery()
            connsql.Close()

            'retrieve fid 
            Dim command2 As New SqlCommand("SELECT TOP 1 FID FROM FLIGHT_MASTER_TABLE ORDER BY FID DESC", connsql)
            connsql.Open()
            Dim fid As String = command2.ExecuteScalar().ToString()
            connsql.Close()
            'insert std,dep time,date to the flight time table
            ' Create a query to retrieve the rows of the selected id from both tables
            Dim query As String = "SELECT * FROM FLIGHT_MASTER_TABLE INNER JOIN FLIGHT_TIME_TABLE ON FLIGHT_MASTER_TABLE.FID = FLIGHT_TIME_TABLE.FID WHERE 
                                        FLIGHT_MASTER_TABLE.FID = @FID"

            'Execute the query and retrieve the data into a DataTable object
            Dim cmdd As New SqlCommand(query, connsql)
            ' Dim selectId As New Integer
            cmdd.Parameters.AddWithValue("@FID", fid)
            Dim adapter As New SqlDataAdapter(cmdd)


            Dim std As String = cbEtaHCha.Text & ":" & cbEtaMCha.Text & ":00"
            Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim stdTime As TimeSpan = dt.TimeOfDay ' std

            Dim dipT As String = cbDipTimeCha.Text & ":00"
            Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim sTime As TimeSpan = dipTime.TimeOfDay

            Dim eta As TimeSpan
            If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
            Else ' if the standard time is later than the dip time, subtract the two times
                eta = stdTime - sTime
            End If

            Dim dipartime As TimeSpan = TimeSpan.Parse(cbDipTimeCha.Text) '[DIP TIME]

            ' Get the selected date value from the DateTimePicker control
            Dim selectedDate As Date = Date.Parse(lblDateCha.Text)    'date

            Dim sql1 As String = "INSERT INTO FLIGHT_TIME_TABLE (FID, STD, [DIP_TIME], Date, ETA) values (@FID, @STD, @DIP, @Date, @ETA)"
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




        End If

    End Sub


End Module
