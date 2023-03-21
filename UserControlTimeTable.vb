Public Class UserControlTimeTable
    'Handles MyBase.Load
    Private Sub UserControlTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = DateTime.Today 'load today
        CrewmanAddingSelectGroup(cbGroup) 'load group

    End Sub


End Class
