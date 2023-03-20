
Module CMIDSelectModule

    Public Sub selectID(dgvCrew As DataGridView, tbName As TextBox, cbGroup As ComboBox, cbPosition As ComboBox, lbl As Label)
        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = dgvCrew.CurrentRow

        ' Get the values of the cells in the selected row
        Dim Sid As Object = selectedRow.Cells(0).Value
        Dim Sname As Object = selectedRow.Cells(1).Value
        Dim Sgroup As Object = selectedRow.Cells(2).Value
        Dim Sposition As Object = selectedRow.Cells(3).Value

        tbName.Text = Sname
        cbGroup.Text = Sgroup
        cbPosition.Text = Sposition
        lbl.Text = Sid
    End Sub

End Module
