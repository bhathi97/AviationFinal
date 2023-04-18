Imports System.Data.SqlClient

Module PFLoadDataToDatabaseModule

    Public Sub LoadGridDataToDatabaseTable(dgv As DataGridView, conn As SqlConnection, lbl As Label)
        Try
            'get grid data to virtual data table
            Dim dt As New DataTable
            For Each column As DataGridViewColumn In dgv.Columns
                dt.Columns.Add(column.Name, column.ValueType)
            Next

            ' add new column for lbl data
            dt.Columns.Add("lbl_data", GetType(String))
            dt.Columns.Add("time", GetType(DateTime))
            dt.Columns.Add("super", GetType(String))

            'load data to virtual table
            For Each row As DataGridViewRow In dgv.Rows
                Dim newRow As DataRow = dt.Rows.Add()
                For Each cell As DataGridViewCell In row.Cells
                    newRow(cell.ColumnIndex) = cell.Value
                Next

                ' set lbl data for each row
                newRow("lbl_data") = lbl.Text
                newRow("time") = DateTime.Now
                newRow("super") = MAINFORM.lblUser.Text
            Next

            ' Next, load the data into a database table
            Dim sql As String = "INSERT INTO RECORD_TABLE ([BAY NO], NO, FLIGHT,ROUTE, ETA, AIRLINES, RIC, OPERATOR, CREWMAN, REMARKS, DATE,TIME, SUPERVISOR) VALUES (@Column1, @Column2, @Column3,@Column10, @Column4, @Column5,@Column6, @Column7, @Column8,@Column9, @lbl_data,@time, @super)"
            Using cmd As New SqlCommand(sql, conn)
                For Each row As DataRow In dt.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Column1", row("Column1"))
                    cmd.Parameters.AddWithValue("@Column2", row("Column2"))
                    cmd.Parameters.AddWithValue("@Column3", row("Column3"))
                    cmd.Parameters.AddWithValue("@Column10", row("Column10"))
                    cmd.Parameters.AddWithValue("@Column4", row("Column4"))
                    cmd.Parameters.AddWithValue("@Column5", row("Column5"))
                    cmd.Parameters.AddWithValue("@Column6", row("Column6"))
                    cmd.Parameters.AddWithValue("@Column7", row("Column7"))
                    cmd.Parameters.AddWithValue("@Column8", row("Column8"))
                    cmd.Parameters.AddWithValue("@Column9", row("Column9"))

                    ' add parameter for lbl data
                    cmd.Parameters.AddWithValue("@lbl_data", row("lbl_data"))

                    'add parameter for time now
                    cmd.Parameters.AddWithValue("@time", row("time"))

                    'add supervisor for each
                    cmd.Parameters.AddWithValue("@super", row("super"))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                Next
                MsgBox("Successfully uploaded to the table")
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub


End Module
