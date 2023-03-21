

Imports System.Data.SqlClient
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

    ' Handles lbRIC.DragOver
    Private Sub lbRIC_DragOver(sender As Object, e As DragEventArgs) Handles lbRIC.DragOver
        Try
            dropWantedItem(e, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbRIC_DragEnter(sender As Object, e As DragEventArgs) Handles lbRIC.DragEnter
        Try
            dragOverOtherItems(e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbRIC_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles lbRIC.GiveFeedback
        e.UseDefaultCursors = False ' Change the cursor to the drag cursor during the drag operation.
        Cursor.Current = Cursors.NoMoveVert ' Change this to the cursor you want to use.
    End Sub

    '--------------------------------------------------------


End Class
