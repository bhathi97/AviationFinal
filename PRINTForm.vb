Public Class PRINTForm

    Public Property Data As DataTable

    ' Handles MyBase.Load
    Private Sub PRINTForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PFLoadDataModule.loadPassedDataToGrid(dgPrint, Data)

    End Sub

    'Handles btnPrintDoc.Click
    Private Sub btnPrintDoc_Click(sender As Object, e As EventArgs) Handles btnPrintDoc.Click
        Try
            'print
            PFPrintDocModule.CreatePDFDOcument(dgPrint, PictureBox2, dateShower, shiftShower, dayShower, shiftTimeShower)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class