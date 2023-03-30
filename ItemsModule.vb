

Imports DocumentFormat.OpenXml.Bibliography
Imports PdfSharpCore.Pdf.Content.Objects
Imports System.Data.SqlClient
Imports System.Text

Module ItemsModule


    Public Sub CrewmanAddingSelectGroup(cb As ComboBox) 'Load simple choices A, B, C, D into combo box
        cb.Items.Add("A")
        cb.Items.Add("B")
        cb.Items.Add("C")
        cb.Items.Add("D")
    End Sub

    Public Sub TTAddingshift(cb As ComboBox) ''load shift time

        cb.Items.Add("07.00 - 19.00")
        cb.Items.Add("19.00 - 07.00")
    End Sub

    Public Sub changeDayLbl(tpDate As DateTimePicker, lblForShowingDay As Label)
        ' Get the selected date from the DateTimePicker
        Dim selectedDate As Date = tpDate.Value
        Dim dayName As String = selectedDate.ToString("dddd")
        ' Extract the day from the selected date
        Dim day As Integer = selectedDate.Day
        ' Display the day in a Label
        lblForShowingDay.Text = dayName.ToString()

    End Sub

    Public Sub changeShift(cb As ComboBox, lbl As Label)
        If cb.SelectedItem = "07.00 - 19.00" Then
            lbl.Text = "Day"
        ElseIf cb.SelectedItem = "19.00 - 07.00" Then
            lbl.Text = "Night"
        End If
    End Sub

    Public Sub CrewmanAddingSelectPosistion(cb As ComboBox) 'Load positions into combo box
        cb.Items.Add("CREWMEN")
        cb.Items.Add("RIC")
        cb.Items.Add("OPERATOR")
    End Sub


    Public Sub AirlineCategoryLoad(connsql As SqlConnection, cb As ComboBox) 'Load Airline Categories into combo box
        Try

            Dim cmd As New SqlCommand("SELECT * FROM AIRLINE_MASTER_TABLE", connsql)
            connsql.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cb.Items.Add(reader("AIRLINE_CODE").ToString())
            End While

            reader.Close()
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub

    Public Sub AirLineLoadWhenCategorySelect(connsql As SqlConnection, cb As ComboBox, tbName As Label) 'Load Airline Names into lable
        Try
            connsql.Open()

            Dim cmd As New SqlCommand("SELECT Airline_Name FROM AIRLINE_MASTER_TABLE where Airline_Code = @cd ", connsql)

            cmd.Parameters.AddWithValue("@cd", cb.Text)
            Dim airline = cmd.ExecuteScalar()
            tbName.Text = airline
            connsql.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try


    End Sub

    Public Sub loadcbSTD(cb As ComboBox) 'load std / hh of std

        Try

            For i As Integer = 0 To 24
                Dim formattedNumber As String = i.ToString("D2")
                cb.Items.Add(formattedNumber.ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadcbSTD1(cb As ComboBox) 'load std / mm of std

        Try

            For j As Integer = 0 To 59
                Dim formattedNumber As String = j.ToString("D2")
                cb.Items.Add(formattedNumber.ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadDipTime(cb As ComboBox) 'load Diparture time

        Try
            cb.Items.Add("00:30") 'add to combo box
            cb.Items.Add("01:00")
            cb.Items.Add("01:30")
            cb.Items.Add("02:00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadUserTypes(cb As ComboBox)
        Try
            cb.Items.Add("USER") 'add to combo box
            cb.Items.Add("ADMIN")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'add operators to TT selected data update form

    Public Sub addOperators(connsql As SqlConnection, cb As ComboBox)
        Try
            connsql.Open()

            Dim cmd As New SqlCommand("SELECT NAME FROM CREWMEMBERS_MASTER_TABLE WHERE POSITION = 'OPERATOR'", connsql)
            Dim oper = cmd.ExecuteScalar()
            cb.Items.Add(oper.ToString())
            connsql.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub


    'remarks for update
    Public Sub remarkAdd(cb As ComboBox)
        cb.Items.Add("HY/Y")
        cb.Items.Add("REF-24")
        cb.Items.Add("REF-11")
        cb.Items.Add("TATA")

    End Sub

    'load airlines
    Public Sub AirLineLoad(connsql As SqlConnection, cb As ComboBox)

        Dim cmd As New SqlCommand("SELECT * FROM AIRLINE_MASTER_TABLE", connsql)
        connsql.Open()

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cb.Items.Add(reader("Airline_Name").ToString())
        End While

        reader.Close()
        connsql.Close()


    End Sub

    Public Sub loadHoursAfterNow(cb As ComboBox) 'load std / hh of std
        Dim currentHour As Integer = DateTime.Now.Hour
        'Dim currentHour As Integer = 20

        Try
            'assuming add charters only its shift time range
            Dim sb As New StringBuilder()

            Select Case True
                Case currentHour > 7 AndAlso currentHour < 19 'morning shift
                    For i As Integer = currentHour To 18
                        sb.Clear()
                        sb.Append(i.ToString("D2"))
                        cb.Items.Add(sb.ToString())
                    Next
                Case currentHour >= 0 AndAlso currentHour < 7 'evening shift | morning part
                    For i As Integer = currentHour To 6
                        sb.Clear()
                        sb.Append(i.ToString("D2"))
                        cb.Items.Add(sb.ToString())
                    Next
                    For i As Integer = 19 To 24
                        sb.Clear()
                        sb.Append(i.ToString("D2"))
                        cb.Items.Add(sb.ToString())
                    Next
                Case currentHour >= 19 AndAlso currentHour < 24 'evening shift | evening part
                    For i As Integer = currentHour To 24
                        sb.Clear()
                        sb.Append(i.ToString("D2"))
                        cb.Items.Add(sb.ToString())
                    Next
                    For i As Integer = 0 To 6
                        sb.Clear()
                        sb.Append(i.ToString("D2"))
                        cb.Items.Add(sb.ToString())
                    Next


            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadMinutesAfterNow(cb As ComboBox) 'load std / mm of std

        Dim currentMin As Integer = DateTime.Now.Minute

        Try

            For j As Integer = currentMin To 59
                Dim formattedNumber As String = j.ToString("D2")
                cb.Items.Add(formattedNumber.ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



End Module
