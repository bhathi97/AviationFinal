Imports System.Data.SqlClient
Imports PdfSharpCore.Pdf.Content.Objects

Public Class UserControlAdminSetting

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    'Handles MyBase.Load
    Private Sub UserControlAdminSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ASLoadModule.show(connsql, dgvUserDetails) 'load table data
        ItemsModule.loadUserTypes(cbType) 'load type combo box items
    End Sub

    'Handles btnSaveUL.Click
    Private Sub btnSaveUL_Click(sender As Object, e As EventArgs) Handles btnSaveUL.Click
        Try
            'save
            ASSaveModule.saveUser(tbUserName, tbPassword, cbType, connsql)
            'load
            ASLoadModule.show(connsql, dgvUserDetails)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub

    'Handles btnUpdateUL.Click
    Private Sub btnUpdateUL_Click(sender As Object, e As EventArgs) Handles btnUpdateUL.Click
        Try
            'update
            ASUpdateModule.UpdateUser(tbUserName, tbPassword, cbType, connsql, lblS)
            'load
            ASLoadModule.show(connsql, dgvUserDetails)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnDeleteUL.Click
    Private Sub btnDeleteUL_Click(sender As Object, e As EventArgs) Handles btnDeleteUL.Click
        Try
            'delete
            ASDeleteModule.deleteUser(tbUserName, tbPassword, cbType, connsql, lblS)
            'load
            ASLoadModule.show(connsql, dgvUserDetails)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles dgvUserDetails.CellClick
    Private Sub dgvUserDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserDetails.CellClick
        Try
            ASSelectModule.selectDataRow(tbUserName, tbPassword, cbType, dgvUserDetails, lblS)
        Catch ex As Exception

        End Try
    End Sub
End Class
