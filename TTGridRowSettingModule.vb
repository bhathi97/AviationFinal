

Imports System.DirectoryServices.ActiveDirectory
Imports ClosedXML

Module TTGridRowSettingModule

    Private myUserControlTimeTable As UserControlTimeTable

    Public Sub clickEvent(e As ToolStripItemClickedEventArgs, dgvMain As DataGridView)

        Select Case e.ClickedItem.Name

            Case "AddRow"
                Dim Form As New CharterAddForm()
                Form.MyDataGridView = dgvMain 'pass the datagrid view as a property
                Form.Show()





                ' Update the NO column values
                For i As Integer = 0 To dgvMain.Rows.Count - 1
                    dgvMain.Rows(i).Cells("noo").Value = i + 1
                Next

            Case "DeleteRow"
                Dim dv As DataView = CType(dgvMain.DataSource, DataView)
                For Each row As DataGridViewRow In dgvMain.SelectedRows
                    dv.Delete(row.Index) ' Remove the selected rows from the data source
                Next

                ' Update the NO column values
                For i As Integer = 0 To dgvMain.Rows.Count - 1
                    dgvMain.Rows(i).Cells("noo").Value = i + 1
                Next
        End Select
        dgvMain.Refresh()
    End Sub




End Module
