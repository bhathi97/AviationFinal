Imports System.Data.SqlClient

Public Class FlightMasterFORM
    Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
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
    End Sub

    'Handles dgvAir.CellClick
    Private Sub dgvAir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAir.CellClick
        Try
            ALSelectModule.selectDataRow(dgvAir, tbCode, tbName, lblCode)
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
            ALUpdateModule.UpdateAirLineDetail(tbCode, tbName, lblCode, connsql)
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

End Class