Imports System.Data.SqlClient

Public Class FlightMasterFORM


    Private _selectedCode As String

    Public Property SelectedCode As String
        Get
            Return _selectedCode
        End Get
        Set(value As String)
            _selectedCode = value
        End Set
    End Property


    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    'Handles btnSave.Click
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ALSaveModule.saveAirLine(tbName, tbCode, connsql)
            'load data
            ALLoadToGridModule.showInGrid(connsql, dgvAir)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles MyBase.Load
    Private Sub FlightMasterFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ALLoadToGridModule.showInGrid(connsql, dgvAir)

        ' Loop through all the open forms in the application
        For Each form As Form In Application.OpenForms
            ' Check if the form is not the topmost form
            If form IsNot Me Then
                ' Disable the form
                form.Enabled = False
            End If
        Next


    End Sub

    'Handles dgvAir.CellClick
    Private Sub dgvAir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAir.CellClick
        Try
            ALSelectModule.selectDataRow(dgvAir, tbCode, tbName)
            SelectedCode = ALSelectModule.SelectedCode
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnUpdate.Click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update table
            ALUpdateModule.UpdateAirLineDetail(tbCode, tbName, SelectedCode, connsql)

            'load to grid
            ALLoadToGridModule.showInGrid(connsql, dgvAir)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles btnDelete.Click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'delete
            deleteAirLineDetail(connsql, tbCode, tbName, lblCode)
            'load to grid
            ALLoadToGridModule.showInGrid(connsql, dgvAir)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles MyBase.FormClosed
    Private Sub FlightMasterFORM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Loop through all the open forms in the application
        For Each form As Form In Application.OpenForms
            ' Check if the form is not the topmost form and if it was previously disabled
            If form IsNot Me AndAlso Not form.Enabled Then
                ' Enable the form
                form.Enabled = True
            End If
        Next

    End Sub
End Class