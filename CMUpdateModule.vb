Imports DocumentFormat.OpenXml.Bibliography
Imports PdfSharpCore.Pdf.Content.Objects
Imports System.Data.SqlClient

Module CMUpdateModule

    Public Sub UpdateCrewmanDetail(lbl As Label, tbName As TextBox, cbGroup As ComboBox, cbPosition As ComboBox, connsql As SqlConnection)

        'Check whether id is null or empty
        If String.IsNullOrEmpty(lbl.ToString) Then

            'check whether all the fields are empty
        ElseIf String.IsNullOrEmpty(tbName.Text) Then
            MsgBox("Fill The Name Field")
            tbName.Focus()

        ElseIf String.IsNullOrEmpty(cbGroup.Text) Then
            MsgBox("Select The Group")
            cbGroup.Focus()

        ElseIf String.IsNullOrEmpty(cbPosition.Text) Then
            MsgBox("Select The Position")
            cbPosition.Focus()

        Else
            ' open database connection 
            connsql.Open()
            Dim namen As String
            namen = tbName.Text
            Dim idn As Integer = Integer.Parse(lbl.Text)

            Dim queryString As String = "SELECT COUNT(*) FROM CREWMEMBERS_MASTER_TABLE WHERE Name = @userInput and ID != @id "
            Dim commandc As New SqlCommand(queryString, connsql)
            commandc.Parameters.AddWithValue("@userInput", namen)
            commandc.Parameters.AddWithValue("@id", idn)
            Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
            connsql.Close()

            If count > 0 Then
                MsgBox("Crewmen name already exists in database")
            Else
                connsql.Open()
                Dim cmd As New SqlCommand("UPDATE CREWMEMBERS_MASTER_TABLE SET Name = @Name,[Group] = @Group ,  position = @Position  WHERE ID = @lblSelectedID", connsql)
                cmd.Parameters.AddWithValue("@Name", tbName.Text)
                cmd.Parameters.AddWithValue("@Group", cbGroup.Text)
                cmd.Parameters.AddWithValue("@Position", cbPosition.Text)
                cmd.Parameters.AddWithValue("@lblSelectedID", lbl.Text)
                'confirmation DialogBox
                Dim result As DialogResult = MessageBox.Show("Do you want to change Crewmen Name ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    'if User clicked Yes
                    MsgBox(tbName.Text & "Successfully Updated")
                    cmd.ExecuteNonQuery()

                End If
                connsql.Close()
            End If
        End If

    End Sub

End Module
