Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient

Module FLDeleteModule

    Public Sub deleteFlight(connsql As SqlConnection,
                            lbselectID As Integer,
                            tbflightNo As TextBox,
                            cbarlinecategory As ComboBox,
                            cbStd As ComboBox,
                            cbStd1 As ComboBox,
                            cbDT As ComboBox,
                            dtp As DateTimePicker)

        Try
            If String.IsNullOrWhiteSpace(lbselectID) Then
                ' No ID selected
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    connsql.Open()
                    Using transaction As SqlTransaction = connsql.BeginTransaction()
                        Try
                            Dim cmd As New SqlCommand()
                            cmd.Connection = connsql
                            cmd.Transaction = transaction

                            cmd.CommandText = "DELETE FROM FLIGHT_MASTER_TABLE WHERE FID = @FID"
                            cmd.Parameters.AddWithValue("@FID", lbselectID)
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "DELETE FROM FLIGHT_TIME_TABLE WHERE FID = @FID"
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MsgBox("Record deleted successfully.")
                        Catch ex As SqlException
                            transaction.Rollback()
                            MsgBox("SQL Error occurred: " & ex.Message)
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox("SQL Error occurred: " & ex.Message)
                        End Try
                    End Using
                    connsql.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("SQL Error occurred: " & ex.Message)
        End Try




        'clear data entering fields
        lbselectID = 0
        tbflightNo.Text = ""
        cbarlinecategory.SelectedIndex = -1
        cbStd.SelectedIndex = -1
        cbStd1.SelectedIndex = -1
        cbDT.SelectedIndex = -1
        'dtp.Value = DateTime.MinValue


    End Sub



End Module
