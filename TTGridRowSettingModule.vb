

Imports System.DirectoryServices.ActiveDirectory
Imports ClosedXML

Module TTGridRowSettingModule

    Public Sub clickEvent(e As ToolStripItemClickedEventArgs, dgvMain As DataGridView)
        Select Case e.ClickedItem.Name

            Case "AddRow"
                Dim dv As DataView = CType(dgvMain.DataSource, DataView)
                Dim newRow As DataRowView = dv.AddNew()
                Dim selectedIndex As Integer = dgvMain.SelectedRows(0).Index ' Get the index of the selected row
                dv.Table.Rows.InsertAt(newRow.Row, selectedIndex + 1) ' Insert the new row below the selected row
                newRow.EndEdit()

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
