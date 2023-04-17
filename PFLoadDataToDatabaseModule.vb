Module PFLoadDataToDatabaseModule

    Public Sub LoadGridDataToDatabaseTable(dgv As DataGridView)
        'get grid data to virtual data table
        Dim dt As New DataTable
        For Each column As DataGridViewColumn In dgv.Columns

            'dt.Columns.Add(column.Name, column.ValueType)
            dt.Columns.Add("column1", GetType(String))
            dt.Columns.Add("column2", GetType(String))
            dt.Columns.Add("column3", GetType(String))
            dt.Columns.Add("column1", GetType(String))



        Next





    End Sub

End Module
