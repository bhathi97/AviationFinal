
Imports System.Globalization

Module TTCheckBoxModule
    Public Sub checkBoxValueSet(dgvMain As DataGridView, lblTime As Label, lblDate As Label)

        Dim lblTimeValue As DateTime = DateTime.Now 'to get the current time
        Dim lblDateValue As DateTime = DateTime.Now.Date 'to get the current date without the time component

        For i As Integer = 0 To dgvMain.Rows.Count - 1 'Loop through all the rows in the DataGridView

            Dim cellValue As String = dgvMain.Rows(i).Cells("Column4").Value.ToString() 'Get fourth column as a string
            Dim dateValue As String = dgvMain.Rows(i).Cells("Column5").Value.ToString() 'Get fifth column as a string

            Dim rowTime As DateTime = DateTime.Parse(cellValue) 'to store the time value in the row
            Dim rowDate As DateTime = DateTime.Parse(dateValue) 'to store the date value in the row

            'compare the current date and time with the row date and time
            If rowDate = lblDateValue AndAlso rowTime.TimeOfDay < lblTimeValue.TimeOfDay Then
                'if the row date matches the current date and the row time is earlier than the current time
                dgvMain.Rows(i).Cells("Column2").Value = True 'Check the checkbox
            Else
                dgvMain.Rows(i).Cells("Column2").Value = False 'Uncheck the checkbox
            End If

        Next
    End Sub

End Module
