Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient

Module FLLoadToGridModule

    Public Sub load(connsql As SqlConnection, dgv As DataGridView)

        Try
            connsql.Open()

            'Create a SQL command to select all the rows from the FLIGHT_MASTER_TABLE
            Dim cmd As New SqlCommand("SELECT * FROM FLIGHT_MASTER_TABLE", connsql)

            'Create a SQL data adapter and set its select command to the SQL command
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = cmd

            dgv.Columns("fno").DataPropertyName = "Flight_No"
            dgv.Columns("alc").DataPropertyName = "Airline_Code"
            dgv.Columns("fid1").DataPropertyName = "FID"

            'Create a new DataTable object to hold the data
            Dim table As New DataTable()

            'Fill the DataTable with the data from the SQL data adapter
            adapter.Fill(table)

            'Add new columns to the DataTable
            table.Columns.Add("std1", GetType(TimeSpan))
            table.Columns.Add("dipart", GetType(TimeSpan))
            table.Columns.Add("eta", GetType(TimeSpan))
            table.Columns.Add("dt", GetType(DateTime))

            'Loop through each row in the DataTable
            For Each row As DataRow In table.Rows
                'Get the FID value from the current row
                Dim fid As Integer = row("FID")

                'Create a SQL command to select the STD, DIP TIME, Date, and ETA values from the FLIGHT_TIME_TABLE where the FID matches
                Dim query As String = "SELECT * FROM FLIGHT_TIME_TABLE WHERE FID = @FID"
                Dim cmd2 As New SqlCommand(query, connsql)

                'Add a parameter for the FID value
                cmd2.Parameters.AddWithValue("@FID", fid)

                'Execute the SQL command and get a SqlDataReader object
                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                'If the reader has rows, read the first row and get the values for the std, dTime, eta, and dt columns
                If reader.HasRows Then
                    reader.Read()

                    Dim std As TimeSpan = reader("STD")
                    Dim dTime As TimeSpan = reader("DIP_TIME")
                    Dim eta As TimeSpan = reader("ETA")
                    Dim dt As DateTime = reader("Date")

                    'Assign the values to the std1, dipart, eta, and dt columns in the current row of the DataTable
                    row("std1") = std
                    row("dipart") = dTime
                    row("eta") = eta
                    row("dt") = dt

                    'Close the reader
                    reader.Close()
                End If

                reader.Close()
            Next

            'Set the DataPropertyName of the std1 column
            dgv.Columns("std1").DataPropertyName = "std1"
            dgv.Columns("dipart").DataPropertyName = "dipart"
            dgv.Columns("dt").DataPropertyName = "dt"
            dgv.Columns("eta").DataPropertyName = "eta"

            'Set the DataSource of the DataGridView to a DataView of the DataTable
            dgv.DataSource = table.DefaultView
            dgv.AutoGenerateColumns = False

        Catch ex As Exception
            'Handle any exceptions that may occur
            MessageBox.Show("Error: " & ex.Message)
        Finally
            'Close the connection
            connsql.Close()
        End Try




















    End Sub







End Module
