
Imports System.Data.SqlClient

Public Class UserControlCREW

    Private _SelectedID As Integer

    Public Property SelectedId As Integer
        Get
            Return _SelectedID
        End Get
        Set(value As Integer)
            _SelectedID = value
        End Set
    End Property

    '*************************
    Public Property UserCrew As String
        Get
            Return _userCrew
        End Get
        Set(value As String)
            _userCrew = value
        End Set
    End Property

    Private _userCrew As String
    '*************************



    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    ' Handles MyBase.Load
    Private Sub UserControlCREW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ItemsModule.CrewmanAddingSelectGroup(cbGroup) 'load groups
        ItemsModule.CrewmanAddingSelectPosistion(cbPosition) 'load position
        CMLoadToGridModule.showInGrid(connsql, dgvCrew) 'load data to the grid

    End Sub

    ' Handles btnSaveCM.Click
    Private Sub btnSaveCM_Click(sender As Object, e As EventArgs) Handles btnSaveCM.Click

        Try
            'add data to the database table
            CMSaveModule.saveCrewman(tbName, cbGroup, cbPosition, connsql, _userCrew)
            'load data to the grid
            CMLoadToGridModule.showInGrid(connsql, dgvCrew)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try


    End Sub

    'Handles btnUpdateCM.Click
    Private Sub btnUpdateCM_Click(sender As Object, e As EventArgs) Handles btnUpdateCM.Click

        Try
            'save data 
            CMUpdateModule.UpdateCrewmanDetail(SelectedId, tbName, cbGroup, cbPosition, connsql, _userCrew)
            'load data to the grid
            CMLoadToGridModule.showInGrid(connsql, dgvCrew)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub


    'Handles dgvCrew.CellClick
    Private Sub dgvCrew_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrew.CellClick
        Try
            CMIDSelectModule.SelectID(dgvCrew, tbName, cbGroup, cbPosition)
            _SelectedID = CMIDSelectModule.SelectedId
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnDeleteCM.Click
    Private Sub btnDeleteCM_Click(sender As Object, e As EventArgs) Handles btnDeleteCM.Click
        Try
            'delete the selected
            CMDeleteModule.deleteCrewmanDetail(connsql, SelectedId, tbName, cbGroup, cbPosition, _userCrew)
            'load data to the grid
            CMLoadToGridModule.showInGrid(connsql, dgvCrew)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub
End Class
