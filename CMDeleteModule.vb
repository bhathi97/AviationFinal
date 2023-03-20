Imports DocumentFormat.OpenXml.Bibliography
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Irony
Imports PdfSharpCore.Pdf.Content.Objects
Imports System.Data.SqlClient

Module CMDeleteModule

    Public Sub deleteCrewmanDetail(connsql As SqlConnection, lbl As Label, name As TextBox, group As ComboBox, position As ComboBox)
        If String.IsNullOrEmpty(lbl.ToString) Then
        Else 'if seleced id is not null
            connsql.Open()
            Dim cmd As New SqlCommand("DELETE FROM CREWMEMBERS_MASTER_TABLE WHERE ID = @ID", connsql)
            cmd.Parameters.AddWithValue("@ID", lbl.Text)

            Dim result As DialogResult = MessageBox.Show("Do you want to delete Crewman " + name.Text + "?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'if User clicked Yes
                cmd.ExecuteNonQuery()
                MsgBox(name.Text & " IS Successfully Deleted ")

                'Clear the values in text boxes, combo boxes, and label
                name.Text = ""
                group.SelectedIndex = -1
                position.SelectedIndex = -1
                lbl.Text = ""

            End If

            connsql.Close()

        End If

    End Sub

End Module
