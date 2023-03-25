
Imports System.Data.SqlClient

Module CMLoadToGridModule

    'Show added crewman data in the datagrid view
    Public Sub showInGrid(connsql As SqlConnection, dgvCrew As DataGridView)
        Try
            connsql.Open()
            Dim cmdsql As New SqlCommand("SELECT * FROM [CREWMEMBERS_MASTER_TABLE] ORDER BY [GROUP]", connsql)
            Dim dasql As New SqlDataAdapter
            dasql.SelectCommand = cmdsql
            Dim dtsql As New DataTable

            dasql.Fill(dtsql)
            dgvCrew.Columns("AID").DataPropertyName = "ID"
            dgvCrew.Columns("AName").DataPropertyName = "Name"
            dgvCrew.Columns("AGroup").DataPropertyName = "Group"
            dgvCrew.Columns("APosition").DataPropertyName = "Position"

            dgvCrew.DataSource = dtsql.DefaultView
            dgvCrew.AllowUserToAddRows = False
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Module
