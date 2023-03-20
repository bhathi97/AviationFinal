
Imports System.Data.SqlClient
Imports PdfSharpCore.Pdf.Content.Objects

Public Class UserControlAF

    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Dim connsql As New SqlConnection(str)
    'Handles MyBase.Load
    Private Sub UserControlAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAName.Visible = False
        AirlineCategoryLoad(connsql, cbairlinecategory)
        loadcbSTD(cbStd)
        loadcbSTD1(cbStd1)
        loadDipTime(cbDT)

    End Sub

    ' Handles lblAddNewAC.Click
    Private Sub lblAddNewAC_Click(sender As Object, e As EventArgs) Handles lblAddNewAC.Click
        Try
            Dim Form As New FlightMasterFORM()
            Form.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles cbairlinecategory.SelectedIndexChanged
    Private Sub cbairlinecategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbairlinecategory.SelectedIndexChanged
        lblAName.Visible = True
        Try
            AirLineLoadWhenCategorySelect(connsql, cbairlinecategory, lblAName)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub
End Class
