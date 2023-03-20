Imports System.Data.SqlClient

Module ALLoadToGridModule

    Public Sub showInGrid(connsql As SqlConnection, dgvAir As DataGridView)
        Try
            connsql.Open()
            Dim cmdsql As New SqlCommand("SELECT * FROM [AIRLINE_MASTER_TABLE]", connsql)
            Dim dasql As New SqlDataAdapter
            dasql.SelectCommand = cmdsql
            Dim dtsql As New DataTable

            dasql.Fill(dtsql)
            dgvAir.Columns("Column1").DataPropertyName = "AIRLINE_CODE"
            dgvAir.Columns("Column2").DataPropertyName = "AIRLINE_NAME"

            dgvAir.DataSource = dtsql.DefaultView
            dgvAir.AllowUserToAddRows = False
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
