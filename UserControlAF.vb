
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Wordprocessing
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

        'load to the grid
        FLLoadToGridModule.load(connsql, dgvFlight)



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

    'Handles btnSaveFlight.Click
    Private Sub btnSaveFlight_Click(sender As Object, e As EventArgs) Handles btnSaveFlight.Click
        Try
            'save data to the database tables
            FLSaveModule.flightSave(tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate, connsql)
            'load to the grid
            FLLoadToGridModule.load(connsql, dgvFlight)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles dgvFlight.CellClick
    Private Sub dgvFlight_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFlight.CellClick
        Try
            'select and load to the form
            FLSelectModule.selectDataLoad(dgvFlight, lblID, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles btnUpdateFlight.Click
    Private Sub btnUpdateFlight_Click(sender As Object, e As EventArgs) Handles btnUpdateFlight.Click
        Try
            'update
            FLUpdateModule.updateFlight(connsql, lblID, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate)
            'load to the grid
            FLLoadToGridModule.load(connsql, dgvFlight)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    Private Sub btnDeleteFlight_Click(sender As Object, e As EventArgs) Handles btnDeleteFlight.Click
        Try
            'delete
            FLDeleteModule.deleteFlight(connsql, lblID, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate)
            'load to the grid
            FLLoadToGridModule.load(connsql, dgvFlight)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub
End Class
