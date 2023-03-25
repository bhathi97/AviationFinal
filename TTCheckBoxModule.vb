
Imports System.Globalization

Module TTCheckBoxModule
    Public Sub checkBoxValueSet(dgvMain As DataGridView, lblTime As Label)
        For i As Integer = 0 To dgvMain.Rows.Count - 1 'Loop through all the rows in the DataGridView
            Dim cellValue As String = dgvMain.Rows(i).Cells("Column4").Value.ToString() 'Get fourth column as a string
            Dim rowTime As DateTime 'to store the time value in the row

            If DateTime.TryParse(cellValue, rowTime) Then 'parse the string value as a time
                Dim lblTimeValue As DateTime 'to store the value of the label

                If DateTime.TryParseExact(lblTime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, lblTimeValue) Then 'parse the label value as a time in the "HH:mm" format
                    If rowTime < lblTimeValue Then 'Compare the row time value with the label time value
                        dgvMain.Rows(i).Cells("Column2").Value = True 'Check the checkbox
                    Else
                        dgvMain.Rows(i).Cells("Column2").Value = False 'Uncheck the checkbox
                    End If
                End If
            End If
        Next
    End Sub

End Module
