Imports System.Data.SqlClient

Module ASDeleteModule

    Public Sub deleteUser(tbName As TextBox, tbPW As TextBox, cbType As ComboBox, connsql As SqlConnection, lbl As Label)
        If String.IsNullOrEmpty(lbl.ToString) Then
        Else 'if seleced id is not null
            connsql.Open()
            Dim cmd As New SqlCommand("DELETE FROM [LOGIN_TABLE] WHERE [USERNAME] = @name", connsql)
            cmd.Parameters.AddWithValue("@name", lbl.Text)

            Dim result As DialogResult = MessageBox.Show("Do you want to delete USER " + lbl.Text + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'if User clicked Yes
                cmd.ExecuteNonQuery()
                MsgBox(lbl.Text & " IS Successfully Deleted ")

                'Clear the values in text boxes, combo boxes, and label
                lbl.Text = ""
                tbName.Text = ""
                tbPW.Text = ""
                cbType.SelectedText = ""

            End If

            connsql.Close()

        End If

    End Sub

End Module
