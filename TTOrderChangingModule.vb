Module TTOrderChangingModule

    'when the left mouse click happen  drag the item
    Public Sub dragWantedItem(e As MouseEventArgs, lb As ListBox)
        If e.Button = MouseButtons.Left AndAlso lb.SelectedIndex >= 0 Then
            lb.DoDragDrop(lb.SelectedItem, DragDropEffects.Move)
        End If

    End Sub

    Public Sub dragOverOtherItems(e As DragEventArgs)
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", True) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    'When drop the dragged item
    Public Sub dropWantedItem(e As DragEventArgs, lb As ListBox)

        'for Crewman
        If e.Data.GetDataPresent(GetType(String)) Then
            Dim dragItem As String = CType(e.Data.GetData(GetType(String)), String)
            Dim targetIndex As Integer = lb.IndexFromPoint(lb.PointToClient(New Point(e.X, e.Y)))
            If targetIndex >= 0 AndAlso targetIndex <> lb.Items.IndexOf(dragItem) Then
                lb.Items.Remove(dragItem)
                lb.Items.Insert(targetIndex, dragItem)
                lb.SetSelected(targetIndex, True)
            End If
        End If

    End Sub

End Module
