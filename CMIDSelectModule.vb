
Module CMIDSelectModule

    Private _selectedId As Integer

    Public Property SelectedId As Integer
        Get
            Return _selectedId
        End Get
        Set(value As Integer)
            _selectedId = value
        End Set
    End Property

    Public Sub SelectID(ByVal dataGridView As DataGridView, ByVal nameTextBox As TextBox, ByVal groupComboBox As ComboBox, ByVal positionComboBox As ComboBox)
        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = dataGridView.CurrentRow

        ' Get the values of the cells in the selected row
        Dim idValue As Object = selectedRow.Cells(0).Value
        Dim nameValue As Object = selectedRow.Cells(1).Value
        Dim groupValue As Object = selectedRow.Cells(2).Value
        Dim positionValue As Object = selectedRow.Cells(3).Value

        ' Set the values of the TextBox and ComboBox controls
        nameTextBox.Text = nameValue
        groupComboBox.Text = groupValue
        positionComboBox.Text = positionValue

        ' Save the selected ID value for later use
        SelectedId = CInt(idValue)
    End Sub


End Module
