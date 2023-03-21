﻿Imports DocumentFormat.OpenXml.VariantTypes
Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory

Module TTAddFlightsModule

    Public Sub addToTable(con As SqlConnection,
                          lblShiftShowing As Label,
                          tpDate As DateTimePicker,
                          dgvMain As DataGridView)
        'get the time range
        Dim Criteria As String
        Criteria = lblShiftShowing.Text

        Dim today As Date
        today = tpDate.Text

        Try
            con.Open()

            If Criteria.Length <> 0 Then

                'if select Day
                If Criteria = "Day" Then

                    Dim table As DataTable = New DataTable()
                    Dim cmd As New SqlCommand("SELECT FID, ETA FROM [FLIGHT_TIME_TABLE] WHERE [ETA] BETWEEN '07:00:00' AND '19:00:00' AND [DATE] = @date ", con)
                    cmd.Parameters.AddWithValue("@date", today)

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using

                    ' Add the "Flight" column to the DataTable, using the name of the corresponding column in the DataGridView
                    table.Columns.Add("fli", GetType(String))
                    table.Columns.Add("lines", GetType(String))

                    For Each row As DataRow In table.Rows
                        ' Store FID
                        Dim fid As Integer = row("FID")

                        ' Load second table to get flight information
                        Dim cmd2 As New SqlCommand("SELECT [FLIGHT_NO], [AIRLINE_CODE] FROM [FLIGHT_MASTER_TABLE] WHERE FID = @fid", con)
                        cmd2.Parameters.AddWithValue("@fid", fid)
                        Dim reader As SqlDataReader = cmd2.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()

                            ' Get flight information
                            Dim fNo As Integer = reader("FLIGHT_NO")
                            Dim fCode As String = reader("AIRLINE_CODE")
                            Dim flight As String = fNo.ToString + "-" + fCode

                            ' Set the value of the "Flight" column in the current row
                            row("Fli") = flight

                            reader.Close()
                            ' Get airline name from AIRLINE_MASTER_TABLE
                            Dim cmd3 As New SqlCommand("SELECT [AIRLINE_NAME] FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @code", con)
                            cmd3.Parameters.AddWithValue("@code", fCode)
                            Dim airlineName As String = cmd3.ExecuteScalar().ToString()

                            row("lines") = airlineName
                            reader.Close()
                        End If
                    Next

                    dgvMain.AutoGenerateColumns = False ' disable auto-generation of columns

                    dgvMain.Columns("Column4").DataPropertyName = "ETA"
                    dgvMain.Columns("fli").DataPropertyName = "fli"
                    dgvMain.Columns("lines").DataPropertyName = "lines"

                    ' Set the DataSource of the DataGridView to the DataTable
                    dgvMain.DataSource = table.DefaultView

                    ' Get the row count of the DataGridView control
                    Dim rowCount As Integer = dgvMain.RowCount
                    ' Loop through each row in the DataGridView control and add the number to the column
                    For i As Integer = 0 To rowCount - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next

                End If

                'If select Night
                If Criteria = "Night" Then

                    Dim table As DataTable = New DataTable()
                    Dim cmd As New SqlCommand("SELECT FID, ETA FROM [FLIGHT_TIME_TABLE]WHERE [ETA] BETWEEN '00:00:00' AND '07:00:00' OR [ETA] BETWEEN '19:00:00' AND '23:59:59' AND [DATE] = @date ", con)
                    cmd.Parameters.AddWithValue("@date", today)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using

                    ' Add the "Flight" column to the DataTable, using the name of the corresponding column in the DataGridView
                    table.Columns.Add("fli", GetType(String))
                    table.Columns.Add("lines", GetType(String))

                    For Each row As DataRow In table.Rows
                        ' Store FID
                        Dim fid As Integer = row("FID")

                        ' Load second table to get flight information
                        Dim cmd2 As New SqlCommand("SELECT [FLIGHT_NO], [AIRLINE_CODE] FROM [FLIGHT_MASTER_TABLE] WHERE FID = @fid", con)
                        cmd2.Parameters.AddWithValue("@fid", fid)
                        Dim reader As SqlDataReader = cmd2.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()

                            ' Get flight information
                            Dim fNo As Integer = reader("FLIGHT_NO")
                            Dim fCode As String = reader("AIRLINE_CODE")
                            Dim flight As String = fNo.ToString + "-" + fCode

                            ' Set the value of the "Flight" column in the current row
                            row("Fli") = flight

                            reader.Close()
                            ' Get airline name from AIRLINE_MASTER_TABLE
                            Dim cmd3 As New SqlCommand("SELECT [AIRLINE_NAME] FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @code", con)
                            cmd3.Parameters.AddWithValue("@code", fCode)
                            Dim airlineName As String = cmd3.ExecuteScalar().ToString()

                            row("lines") = airlineName
                            reader.Close()

                        End If
                    Next

                    dgvMain.AutoGenerateColumns = False ' disable auto-generation of columns

                    dgvMain.Columns("Column4").DataPropertyName = "ETA"
                    dgvMain.Columns("fli").DataPropertyName = "fli"
                    dgvMain.Columns("lines").DataPropertyName = "lines"

                    ' Set the DataSource of the DataGridView to the DataTable
                    dgvMain.DataSource = table.DefaultView

                    'get row count
                    Dim rowCount As Integer = dgvMain.RowCount
                    ' Loop through each row in the DataGridView control and add the number to the column
                    For i As Integer = 0 To rowCount - 1
                        dgvMain.Rows(i).Cells("noo").Value = i + 1
                    Next
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

End Module
