Imports System.Data.SqlClient

Public Class PRINTForm

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    Public Property Data As DataTable

    ' Handles MyBase.Load
    Private Sub PRINTForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PFLoadDataModule.loadPassedDataToGrid(dgPrint, Data)

        ' Loop through all the open forms in the application
        For Each form As Form In Application.OpenForms
            ' Check if the form is not the topmost form
            If form IsNot Me Then
                ' Disable the form
                form.Enabled = False
            End If
        Next


    End Sub

    'Handles btnPrintDoc.Click
    Private Sub btnPrintDoc_Click(sender As Object, e As EventArgs) Handles btnPrintDoc.Click
        Try
            'print
            PFPrintDocModule.CreatePDFDOcument(dgPrint, PictureBox2, dateShower, shiftShower, dayShower, shiftTimeShower)
            PFLoadDataToDatabaseModule.LoadGridDataToDatabaseTable(dgPrint, connsql, dateShower)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Handles MyBase.FormClosed
    Private Sub PRINTForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            ' Loop through all the open forms in the application
            For Each form As Form In Application.OpenForms
                ' Check if the form is not the topmost form and if it was previously disabled
                If form IsNot Me AndAlso Not form.Enabled Then
                    ' Enable the form
                    form.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class