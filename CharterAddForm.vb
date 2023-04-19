Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports System.Globalization
Imports DocumentFormat.OpenXml.Drawing
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class CharterAddForm

    Public Property MyDataGridView As DataGridView

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    ' Handles MyBase.Load
    Private Sub CharterAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Loop through all the open forms in the application
        For Each form As Form In Application.OpenForms
            ' Check if the form is not the topmost form
            If form IsNot Me Then
                ' Disable the form
                form.Enabled = False
            End If
        Next

        lblAirLineChar.Visible = False
        cbEtaMCha.Enabled = False

        'load charter details combo boxes
        AirlineCategoryLoad(connsql, cbAirCodeCha)
        loadHoursAfterNow(cbEtaHCha)

        loadDipTime(cbDipTimeCha)

        'load date
        Dim currentDate As Date = Date.Today
        lblDateCha.Text = currentDate.ToString("MM/dd/yyyy") ' Displays the current date in the format "dd/MM/yyyy" on a label control


    End Sub

    'Handles MyBase.FormClosing
    Private Sub CharterAddForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private _dgv As DataGridView

    ''pass by reference
    Public Sub New(ByRef dgvMain As DataGridView)
        InitializeComponent()
        '_dv = dv
        _dgv = dgvMain
    End Sub

    'Handles btnNewCharter.Click
    Private Sub btnNewCharter_Click(sender As Object, e As EventArgs) Handles btnNewChar.Click
        Try
            CAInsertCharterModule.charterInsert(_dgv, Me, connsql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()

            ' Get the row count of the DataGridView control
            Dim rowCount As Integer = _dgv.RowCount
            ' Loop through each row in the DataGridView control and add the number to the column
            For i As Integer = 0 To rowCount - 1
                _dgv.Rows(i).Cells("noo").Value = i + 1
            Next


        End Try

    End Sub

    ' Handles cbAirCodeCha.SelectedIndexChanged
    Private Sub cbAirCodeCha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAirCodeCha.SelectedIndexChanged
        lblAirLineChar.Visible = True
        Try
            AirLineLoadWhenCategorySelect(connsql, cbAirCodeCha, lblAirLineChar)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles cbEtaHCha.SelectedIndexChanged
    Private Sub cbEtaHCha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEtaHCha.SelectedIndexChanged
        cbEtaMCha.Enabled = True
        cbEtaMCha.Items.Clear()
        Dim currentMin As Integer = DateTime.Now.Minute
        Dim currntH As Integer = DateTime.Now.Hour
        If cbEtaHCha.Text = currntH.ToString() Then
            cbEtaMCha.Text = currentMin
            cbEtaMCha.SelectAll()
            loadMinutesAfterNow(cbEtaMCha)

        Else
            loadcbSTD1(cbEtaMCha)
        End If

    End Sub

    'Handles MyBase.FormClosed
    Private Sub CharterAddForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Loop through all the open forms in the application
        For Each form As Form In Application.OpenForms
            ' Check if the form is not the topmost form and if it was previously disabled
            If form IsNot Me AndAlso Not form.Enabled Then
                ' Enable the form
                form.Enabled = True
            End If
        Next
    End Sub

    '    Private Function loadBack(dgv As DataGridView)




    '   Return
    '
    '  End Function



End Class