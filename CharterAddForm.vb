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
            'Dim eta1 As String = cbEtaHCha.Text & ":" & cbEtaMCha.Text & ":00"
            '  Dim eta2 As DateTime = DateTime.ParseExact(eta1, "HH:mm:ss", CultureInfo.InvariantCulture)
            '  Dim eta3 As TimeSpan = eta2.TimeOfDay ' ETA
            ' Cast the DataSource to a DataView
            Dim dataView As DataView = DirectCast(_dgv.DataSource, DataView)

            ' Get the DataTable from the DataView
            Dim table As DataTable = dataView.Table













            ' Create a string variable to hold the column names
            '            Dim columnNames As String = ""

            ' Iterate through the columns of the DataTable and add each column name to the string variable
            'For Each column As DataColumn In table.Columns
            '   columnNames += column.ColumnName + vbNewLine 'add column name to string and add newline for formatting
            'Next
            '
            ' Display the column names in a message box
            '        MessageBox.Show("Column names:" & vbNewLine & columnNames)



            '            Dim columnNamesaa As String = ""
            '
            '           For Each column As DataGridViewColumn In _dgv.Columns
            '          columnNamesaa += column.HeaderText + vbCrLf
            '         Next

            ' Display the column names in a message box
            '         MessageBox.Show("Column names:" & vbNewLine & columnNamesaa)










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

            Dim eta As TimeSpan = stdTime - sTime

            newRow("ETA") = eta 'add eta
            newRow("lines") = lblAirLineChar.Text 'airlines

            ' Add the new row to the DataTable
            table.Rows.Add(newRow)

            ' Sort the rows based on column 3 if needed
            ' dataView.Sort = "Column3 ASC"

            'dgvMain.Columns("Column5").DataPropertyName = "DATE"
            'dgvMain.Columns("Column4").DataPropertyName = "ETA"
            'dgvMain.Columns("fli").DataPropertyName = "fli"
            'dgvMain.Columns("lines").DataPropertyName = "lines"
            'Dim rowIndex As Integer = _dgv.Rows.Add(newRow)
            ' _dgv.Rows(rowIndex).Selected = True

            '
            '
            '
            '
            '
            '  newRow.EndEdit()




            'TTAddChaToDBModule.saveChar(tbFlightCha, cbAirCodeCha, cbEtaHCha, cbEtaMCha, cbDipTimeCha, lblDateCha, connsql)











            'add new row






        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
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