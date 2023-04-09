Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Module TTCharterLoadModule
    Public Sub loadToGrid(connsql As SqlConnection, dgv As DataGridView)
        Try
            Dim dt As New DataTable
            'Add new columns to the DataTable
            dt.Columns.Add("Column4", GetType(TimeSpan))

            ' Load the new data into a DataTable
            connsql.Open()
            Dim newCmd As New SqlCommand("SELECT * FROM NEW_TABLE", connsql)
            connsql.Close()
            Dim newDa As New SqlDataAdapter(newCmd)
            Dim newDt As New DataTable
            newDa.Fill(newDt)

            ' Merge the new DataTable with the existing DataTable
            dt.Merge(newDt)

            ' Bind the merged DataTable to the DataGridView
            dgv.DataSource = dt.DefaultView

            ' Update the column mappings for the DataGridView
            dgv.Columns("Column4").DataPropertyName = "ETA"
            dgv.Columns("fli").DataPropertyName = "FLIGHT"
            dgv.Columns("Column1").DataPropertyName = "BAYNO"
            dgv.Columns("lines").DataPropertyName = "AIRLINE"
            dgv.Columns("Column9").DataPropertyName = "REMARKS"

            ' Set the DataGridView to disallow adding new rows
            dgv.AllowUserToAddRows = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
