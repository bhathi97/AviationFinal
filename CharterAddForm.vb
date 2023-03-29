Imports System.Data.SqlClient




Public Class CharterAddForm

    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Dim connsql As New SqlConnection(str)

    ' Handles MyBase.Load
    Private Sub CharterAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'load charter details combo boxes
        AirLineLoad(connsql, cbAirCha)
        remarkAdd(cbRemarkCha)
        loadcbSTD(cbEtaHCha)
        loadcbSTD1(cbEtaMCha)

        'load date
        Dim currentDate As Date = Date.Today
        lblDate.Text = currentDate.ToString("dd/MM/yyyy") ' Displays the current date in the format "dd/MM/yyyy" on a label control


    End Sub

    'Handles MyBase.FormClosing
    Private Sub CharterAddForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub


    'the DataGridView, create a reference To the user control Object

    'Private _dv As DataView
    ' Private _dgv As DataGridView

    ''pass by reference
    'ByRef dv As DataView
    ' Public Sub New(ByRef dgvMain As DataGridView)
    '     InitializeComponent()
    '     '_dv = dv
    '     _dgv = dgvMain
    ' End Sub

    'Handles btnNewCharter.Click
    Private Sub btnNewCharter_Click(sender As Object, e As EventArgs) Handles btnNewCharter.Click
        Try
            'Dim eta1 As String = cbEtaHCha.Text & ":" & cbEtaMCha.Text & ":00"
            '  Dim eta2 As DateTime = DateTime.ParseExact(eta1, "HH:mm:ss", CultureInfo.InvariantCulture)
            '  Dim eta3 As TimeSpan = eta2.TimeOfDay ' ETA

            'Dim newRow As DataRowView = CType(_dgv.DataSource, DataView).AddNew()
            ' Dim rowIndex As Integer = _dgv.Rows.Add(newRow)
            ' _dgv.Rows(rowIndex).Selected = True

            '            newRow.EndEdit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class