
Module ALSelectModule

    Private _selectedCode As String

    Public Property SelectedCode As String
        Get
            Return _selectedCode
        End Get
        Set(value As String)
            _selectedCode = value
        End Set
    End Property


    Public Sub selectDataRow(dgvAir As DataGridView, tbCode As TextBox, tbName As TextBox)

        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = dgvAir.CurrentRow

        ' Get the values of the cells in the selected row
        Dim ACode As Object = selectedRow.Cells(0).Value
        Dim AName As Object = selectedRow.Cells(1).Value

        tbCode.Text = ACode
        tbName.Text = AName

        SelectedCode = ACode

    End Sub

End Module
