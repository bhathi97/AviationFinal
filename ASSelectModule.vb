Imports System.Data.SqlClient

Module ASSelectModule
    Public Sub selectDataRow(tbName As TextBox, tbPW As TextBox, cbType As ComboBox, dgv As DataGridView, lbl As Label)

        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = dgv.CurrentRow

        ' Get the values of the cells in the selected row
        Dim name As Object = selectedRow.Cells(0).Value
        Dim pw As Object = selectedRow.Cells(1).Value
        Dim type As Object = selectedRow.Cells(2).Value


        tbName.Text = name
        tbPW.Text = pw
        cbType.Text = type
        lbl.Text = name
    End Sub

End Module
