Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports System.Globalization
Imports DocumentFormat.OpenXml.Drawing

Public Class CharterAddForm

    Public Property MyDataGridView As DataGridView

    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
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


    'the DataGridView, create a reference To the user control Object

    'Private _dv As DataView
    Private _dgv As DataGridView

    ''pass by reference
    'ByRef dv As DataView
    Public Sub New(ByRef dgvMain As DataGridView)
        InitializeComponent()
        '_dv = dv
        _dgv = dgvMain
    End Sub

    'Handles btnNewCharter.Click
    Private Sub btnNewCharter_Click(sender As Object, e As EventArgs) Handles btnNewChar.Click
        Try
            Dim dataView As DataView = DirectCast(_dgv.DataSource, DataView)

            ' Get the DataTable from the DataView
            Dim table As DataTable = dataView.Table

            ' Create a new row
            Dim newRow As DataRow = table.NewRow()

            newRow("DATE") = DateTime.Now.Date 'add date
            newRow("fli") = tbFlightCha.Text & "-" & cbAirCodeCha.Text 'add fligth no

            Dim std As String = cbEtaHCha.Text & ":" & cbEtaMCha.Text & ":00"
            Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim stdTime As TimeSpan = dt.TimeOfDay

            Dim dipT As String = cbDipTimeCha.Text & ":00"
            Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim sTime As TimeSpan = dipTime.TimeOfDay

            Dim eta As TimeSpan
            If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
            Else ' if the standard time is later than the dip time, subtract the two times
                eta = stdTime - sTime
            End If

            newRow("ETA") = eta 'add eta
            newRow("lines") = lblAirLineChar.Text 'airlines

            ' Add the new row to the DataTable
            table.Rows.Add(newRow)

            'save aded data to database
            TTAddChaToDBModule.saveChar(tbFlightCha, cbAirCodeCha, cbEtaHCha, cbEtaMCha, cbDipTimeCha, lblDateCha, connsql)

            'clear data to add new 
            cbAirCodeCha.SelectedIndex = -1
            cbEtaHCha.SelectedIndex = -1
            cbEtaMCha.SelectedIndex = -1
            cbDipTimeCha.SelectedIndex = -1
            'lblDateCha.Text = String.Empty
            tbFlightCha.Text = String.Empty
            cbEtaHCha.SelectedIndex = -1


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
        Try





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            ' Loop through all the open forms in the application
            For Each form As Form In Application.OpenForms
                ' Check if the form is not the topmost form and if it was previously disabled
                If form IsNot Me AndAlso Not form.Enabled Then
                    ' Enable the form
                    form.Enabled = True
                End If
            Next

        End Try
    End Sub

    '    Private Function loadBack(dgv As DataGridView)




    '   Return
    '
    '  End Function



End Class