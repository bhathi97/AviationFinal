Module FLSelectModule

    Public Sub selectDataLoad(dgv As DataGridView,
                              lbselectID As Label,
                              tbflightNo As TextBox,
                              cbarlinecategory As ComboBox,
                              cbStd As ComboBox,
                              cbStd1 As ComboBox,
                              cbDT As ComboBox,
                              dtpDate As DateTimePicker)
        Dim selectedRow As DataGridViewRow = dgv.CurrentRow

        ' Get the values of the cells in the selected row
        Dim Sid As Object = selectedRow.Cells(0).Value
        Dim flightNo As Object = selectedRow.Cells(1).Value
        Dim ACateogry As Object = selectedRow.Cells(2).Value
        'Dim std As Object = selectedRow.Cells(3).Value
        Dim std1 As Object = selectedRow.Cells(3).Value

        Dim selectedDate As Object = selectedRow.Cells(6).Value

        Dim std As TimeOnly = TimeOnly.Parse(selectedRow.Cells(3).Value.ToString())
        Dim hours As String = std.Hour().ToString("D2")
        Dim min As String = std.Minute().ToString("D2")


        Dim fullDip As TimeOnly = TimeOnly.Parse(selectedRow.Cells(4).Value.ToString())
        Dim dipH As String = fullDip.Hour().ToString("D2")
        Dim dipM As String = fullDip.Minute().ToString("D2")
        Dim dipartime As String = dipH & ":" & dipM

        ' Populate the form controls with the selected row data
        lbselectID.Text = Sid.ToString()
        tbflightNo.Text = flightNo.ToString()
        cbarlinecategory.Text = ACateogry.ToString()

        cbStd.Text = hours ' Get the time in hours
        cbStd1.Text = min ' Get the minutes

        cbDT.Text = dipartime.ToString()
        dtpDate.Value = Date.Parse(selectedDate.ToString()) ' Set the date only to the DateTimePicker

    End Sub




End Module
