Imports System.Data.SqlClient

Module ASLoadModule


    Public Sub show(connsql As SqlConnection, dgv As DataGridView)
        Try
            connsql.Open()
            Dim cmdsql As New SqlCommand("SELECT * FROM [LOGIN_TABLE]", connsql)
            Dim dasql As New SqlDataAdapter
            dasql.SelectCommand = cmdsql
            Dim dtsql As New DataTable

            dasql.Fill(dtsql)
            dgv.Columns("Column1").DataPropertyName = "USERNAME"
            dgv.Columns("Column2").DataPropertyName = "PASSWORD"
            dgv.Columns("Column3").DataPropertyName = "TYPE"
            dgv.DataSource = dtsql.DefaultView
            dgv.AllowUserToAddRows = False
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub





End Module
