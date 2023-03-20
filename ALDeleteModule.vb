Imports System.Data.SqlClient

Module ALDeleteModule

    Public Sub deleteAirLineDetail(connsql As SqlConnection, tbCode As TextBox, tbName As TextBox, lblCode As Label)
        If String.IsNullOrEmpty(lblCode.ToString) Then
        Else 'if seleced id is not null
            connsql.Open()
            Dim cmd As New SqlCommand("DELETE FROM [AIRLINE_MASTER_TABLE] WHERE [AIRLINE_CODE] = @code", connsql)
            cmd.Parameters.AddWithValue("@code", lblCode.Text)

            Dim result As DialogResult = MessageBox.Show("Do you want to delete Crewman " + tbCode.Text + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'if User clicked Yes
                cmd.ExecuteNonQuery()
                MsgBox(tbCode.Text & " IS Successfully Deleted ")

                'Clear the values in text boxes, combo boxes, and label
                tbCode.Text = ""
                tbName.Text = ""
                lblCode.Text = ""

            End If

            connsql.Close()

        End If

    End Sub


End Module
