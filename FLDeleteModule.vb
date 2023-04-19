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

                    Try

                        Dim cmd As New SqlCommand("DELETE FROM FLIGHT_TIME_TABLE WHERE FID = @FID", connsql)
                        cmd.Parameters.AddWithValue("@FID", lbselectID)
                        cmd.ExecuteNonQuery()


                        Dim cmd0 As New SqlCommand("DELETE FROM FLIGHT_MASTER_TABLE WHERE FID = @FID", connsql)
                        cmd0.Parameters.AddWithValue("@FID", lbselectID)
                        cmd0.ExecuteNonQuery()

                        MsgBox("Record deleted successfully.")

                    Catch ex As SqlException
                        MsgBox("SQL Error occurred: " & ex.Message)
                    End Try

                    connsql.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("SQL Error occurred: " & ex.Message)
        Finally
            connsql.Close()
        End Try




        'clear data entering fields

        tbflightNo.Text = ""
        cbarlinecategory.SelectedIndex = -1
        cbStd.SelectedIndex = -1
        cbStd1.SelectedIndex = -1
        cbDT.SelectedIndex = -1
        'dtp.Value = DateTime.MinValue


    End Sub



End Module
