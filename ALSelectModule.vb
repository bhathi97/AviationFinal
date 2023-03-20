
Module ALSelectModule

    Public Sub selectDataRow(dgvAir As DataGridView, tbCode As TextBox, tbName As TextBox, lblCode As Label)

        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = dgvAir.CurrentRow

        ' Get the values of the cells in the selected row
        Dim ACode As Object = selectedRow.Cells(0).Value
        Dim AName As Object = selectedRow.Cells(1).Value

        tbCode.Text = ACode
        tbName.Text = AName

        lblCode.Text = ACode

    End Sub

End Module
