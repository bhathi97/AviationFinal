

Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Wordprocessing
Imports PdfSharpCore.Pdf.Content.Objects

Public Class UserControlTimeTable

    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Dim connsql As New SqlConnection(str)

    'Handles MyBase.Load
    Private Sub UserControlTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = DateTime.Today 'load today
        CrewmanAddingSelectGroup(cbGroup) 'load group
        TTAddingshift(cbShiftTime) 'load shift Time
        changeDayLbl(dtpDate, lblDay) 'load day



    End Sub

    'Handles dtpDate.ValueChanged
    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        changeDayLbl(dtpDate, lblDay) 'load day
    End Sub

    'Handles cbShiftTime.SelectedIndexChanged
    Private Sub cbShiftTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbShiftTime.SelectedIndexChanged
        changeShift(cbShiftTime, lblShift)
    End Sub

    'Handles cbGroup.SelectedIndexChanged
    Private Sub cbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroup.SelectedIndexChanged

        Try
            TTLoadDataToListBoxesModule.LoadDataToListBoxes(cbGroup, lbCM, lbRIC, connsql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub

    'CREWMEN order change ------------------------------
    'Handles lbCM.MouseDown
    Private Sub lbCM_MouseDown(sender As Object, e As MouseEventArgs) Handles lbCM.MouseDown
        Try
            TTOrderChangingModule.dragWantedItem(e, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbCM.DragEnter
    Private Sub lbCM_DragEnter(sender As Object, e As DragEventArgs) Handles lbCM.DragEnter
        Try
            dragOverOtherItems(e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles lbCM.DragOver
    Private Sub lbCM_DragOver(sender As Object, e As DragEventArgs) Handles lbCM.DragOver
        Try
            dropWantedItem(e, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbCM.GiveFeedback
    Private Sub lbCM_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles lbCM.GiveFeedback
        e.UseDefaultCursors = False ' Change the cursor to the drag cursor during the drag operation.
        Cursor.Current = Cursors.NoMoveVert ' Change this to the cursor you want to use.
    End Sub

    'RIC order change ------------------------------
    'Handles lbRIC.MouseDown
    Private Sub lbRIC_MouseDown(sender As Object, e As MouseEventArgs) Handles lbRIC.MouseDown
        Try
            dragWantedItem(e, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles lbRIC.DragEnter
    Private Sub lbRIC_DragEnter(sender As Object, e As DragEventArgs) Handles lbRIC.DragEnter
        Try
            dragOverOtherItems(e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbRIC.DragOver
    Private Sub lbRIC_DragOver(sender As Object, e As DragEventArgs) Handles lbRIC.DragOver
        Try
            dropWantedItem(e, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Handles lbRIC.GiveFeedback
    Private Sub lbRIC_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles lbRIC.GiveFeedback
        e.UseDefaultCursors = False ' Change the cursor to the drag cursor during the drag operation.
        Cursor.Current = Cursors.NoMoveVert ' Change this to the cursor you want to use.
    End Sub


    '--------------------------------------------------------


    'Handles btnCMRemove.Click
    Private Sub btnCMRemove_Click(sender As Object, e As EventArgs) Handles btnCMRemove.Click
        Try
            TTAddOrRemoveModule.remove(lbCM, lbRemovedCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnAddAgainCM.Click
    Private Sub btnAddAgainCM_Click(sender As Object, e As EventArgs) Handles btnAddAgainCM.Click
        Try
            TTAddOrRemoveModule.remove(lbRemovedCM, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles btnRICRemove.Click
    Private Sub btnRICRemove_Click(sender As Object, e As EventArgs) Handles btnRICRemove.Click
        Try
            TTAddOrRemoveModule.remove(lbRIC, lbRemovedRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles btnAddAgainRIC.Click
    Private Sub btnAddAgainRIC_Click(sender As Object, e As EventArgs) Handles btnAddAgainRIC.Click
        Try
            TTAddOrRemoveModule.remove(lbRemovedRIC, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles btnPlaneAdd.Click
    Private Sub btnPlaneAdd_Click(sender As Object, e As EventArgs) Handles btnPlaneAdd.Click
        Try
            TTAddFlightsModule.addToTable(connsql, lblShift, dtpDate, dgvMain)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub



    '------------------------------------------------------
    'add crewman
    'Handles btnAddCMToTable.Click
    Private Sub btnAddCMToTable_Click(sender As Object, e As EventArgs) Handles btnAddCMToTable.Click
        Try
            addCM(lbCM, dgvMain)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnAddRICToTable.Click
    Private Sub btnAddRICToTable_Click(sender As Object, e As EventArgs) Handles btnAddRICToTable.Click
        Try
            addRIC(lbRIC, dgvMain)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnPrint.Click
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            TTDataPassToPrintFModule.loadPrint(dtpDate, cbShiftTime, lblDay, lblShift, dgvMain)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles dgvMain.MouseUp
    Private Sub dgvMain_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvMain.MouseUp
        If e.Button = MouseButtons.Right Then ' Check if the right mouse button was clicked
            Dim hti As DataGridView.HitTestInfo = dgvMain.HitTest(e.X, e.Y)
            If hti.RowIndex >= 0 Then ' Check if the clicked area is in a valid row
                dgvMain.ClearSelection() ' Clear any existing row selection
                dgvMain.Rows(hti.RowIndex).Selected = True ' Select the clicked row

                Dim menu As New ContextMenuStrip() ' Create a new context menu strip
                menu.Items.Add("Add New Row").Name = "AddRow" ' Add an item to add a new row
                menu.Items.Add("Delete Selected Row").Name = "DeleteRow" ' Add an item to delete the selected row

                AddHandler menu.ItemClicked, AddressOf ContextMenuStrip1_ItemClicked ' Add a handler for the menu item clicked event
                menu.Show(dgvMain, e.Location) ' Show the context menu strip at the clicked location
            End If
        End If
        dgvMain.Refresh()

    End Sub

    'Handles ContextMenuStrip1.ItemClicked
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
