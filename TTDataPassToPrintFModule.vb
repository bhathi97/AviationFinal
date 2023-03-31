
Imports System.DirectoryServices.ActiveDirectory

Module TTDataPassToPrintFModule

    Public Sub loadPrint(dtpDate As DateTimePicker,
                         cbShiftTime As ComboBox,
                         lblDay As Label,
                         lblShift As Label,
                         dgvMain As DataGridView)

        Dim Form As New PRINTForm()
        Form.dateShower.Text = dtpDate.Text 'load date from home form
        Form.shiftTimeShower.Text = cbShiftTime.Text 'load shift time from home form 
        Form.dayShower.Text = lblDay.Text 'load day from home form
        Form.shiftShower.Text = lblShift.Text 'load shift from home form


        Dim data As New DataTable()
        ' Add columns to the DataTable
        data.Columns.Add("Column1")
        data.Columns.Add("Column2")
        data.Columns.Add("Column3")
        data.Columns.Add("Column4")
        data.Columns.Add("Column5")
        data.Columns.Add("Column6")
        data.Columns.Add("Column7")
        data.Columns.Add("Column8")
        data.Columns.Add("Column9")
        data.Columns.Add("Column10")

        ' Add rows to the DataTable and load data into the existing columns of the DataTable
        For Each row As DataGridViewRow In dgvMain.Rows


            If row.Cells("Column3").Value <> "YES" Then
                ' Set the values for each column in the new row

                ' Add a new row to the DataTable
                Dim newRow As DataRow = data.Rows.Add()

                newRow("Column1") = row.Cells("Column1").Value
                newRow("Column2") = row.Cells("noo").Value
                newRow("Column3") = row.Cells("fli").Value
                newRow("Column4") = row.Cells("Column4").Value
                newRow("Column5") = row.Cells("lines").Value
                newRow("Column6") = row.Cells("Column6").Value
                newRow("Column7") = row.Cells("Column7").Value
                newRow("Column8") = row.Cells("Column8").Value
                newRow("Column9") = row.Cells("Column9").Value
                newRow("Column10") = row.Cells("Column10").Value

            End If



        Next




        Form.Data = data 'datatable in printformWindow 
        Form.Show()

    End Sub

End Module
