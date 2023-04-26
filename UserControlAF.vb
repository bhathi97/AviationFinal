
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports DocumentFormat.OpenXml.Wordprocessing
Imports PdfSharpCore.Pdf.Content.Objects

Public Class UserControlAF

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)


    '*************************************id
    Private _selectedID As Integer

    Public Property SelectedID As Integer
        Get
            Return _selectedID
        End Get
        Set(value As Integer)
            _selectedID = value
        End Set
    End Property
    '**************************************

    '************************************** to get user

    Public Property UserAF As String
        Get
            Return _userAF
        End Get
        Set(value As String)
            _userAF = value
        End Set
    End Property

    Private _userAF As String

    '**************************************************

    'Handles MyBase.Load
    Private Sub UserControlAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAName.Visible = False
        ' AirlineCategoryLoad(connsql, cbairlinecategory)
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
            FLSaveModule.flightSave(tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate, connsql, UserAF)
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
            FLSelectModule.selectDataLoad(dgvFlight, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate)
            'SELECTED id load to property
            SelectedID = FLSelectModule.SelectedID

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
            FLUpdateModule.updateFlight(connsql, SelectedID, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, dpDate, UserAF)
            'load to the grid
            FLLoadToGridModule.load(connsql, dgvFlight)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnDeleteFlight.Click
    Private Sub btnDeleteFlight_Click(sender As Object, e As EventArgs) Handles btnDeleteFlight.Click
        Try
            'delete
            FLDeleteModule.deleteFlight(connsql, SelectedID, tbflightNo, cbairlinecategory, cbStd, cbStd1, cbDT, UserAF)
            'load to the grid
            FLLoadToGridModule.load(connsql, dgvFlight)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles cbairlinecategory.DropDown
    Private Sub cbairlinecategory_DropDown(sender As Object, e As EventArgs) Handles cbairlinecategory.DropDown
        Try
            cbairlinecategory.Items.Clear()
            AirlineCategoryLoad(connsql, cbairlinecategory)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    ' Handles btnSearch.Click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            AFSearchModule.SearchbyID(connsql, dgvSearch, tbSearch)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
End Class
