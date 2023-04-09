
Imports System.Data.SqlClient
Imports System.Globalization

Module CAInsertCharterModule

    Public Sub charterInsert(dgv As DataGridView, obj As CharterAddForm, connsql As SqlConnection)
        Dim dataView As DataView = DirectCast(dgv.DataSource, DataView)

        ' Get the DataTable from the DataView
        Dim table As DataTable = dataView.Table

        ' Create a new row
        Dim newRow As DataRow = table.NewRow()

        newRow("DATE") = DateTime.Now.Date 'add date
        newRow("fli") = obj.tbFlightCha.Text & "-" & obj.cbAirCodeCha.Text 'add fligth no

        Dim std As String = obj.cbEtaHCha.Text & ":" & obj.cbEtaMCha.Text & ":00"
        Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim stdTime As TimeSpan = dt.TimeOfDay

        Dim dipT As String = obj.cbDipTimeCha.Text & ":00"
        Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
        Dim sTime As TimeSpan = dipTime.TimeOfDay

        Dim eta As TimeSpan
        If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
            eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
        Else ' if the standard time is later than the dip time, subtract the two times
            eta = stdTime - sTime
        End If

        newRow("ETA") = eta 'add eta
        newRow("lines") = obj.lblAirLineChar.Text 'airlines

        ' Add the new row to the DataTable
        table.Rows.Add(newRow)

        'save aded data to database
        TTAddChaToDBModule.saveChar(obj.tbFlightCha, obj.cbAirCodeCha, obj.cbEtaHCha, obj.cbEtaMCha, obj.cbDipTimeCha, obj.lblDateCha, connsql)

        'clear data to add new 
        obj.cbAirCodeCha.SelectedIndex = -1
        obj.cbEtaHCha.SelectedIndex = -1
        obj.cbEtaMCha.SelectedIndex = -1
        obj.cbDipTimeCha.SelectedIndex = -1

        obj.tbFlightCha.Text = String.Empty
        obj.cbEtaHCha.SelectedIndex = -1
    End Sub
End Module
