Imports System.Data.SqlClient

Module TTLoadDataToListBoxesModule
    Public Sub LoadDataToListBoxes(cbGroupPicker As ComboBox, lvCrewman As ListBox, lvRic As ListBox, con As SqlConnection)

        'get selected data to a variable'
        Dim var_GroupName As String
        var_GroupName = cbGroupPicker.Text

        ' Clear the existing items in the ListView control
        lvCrewman.Items.Clear()
        lvRic.Items.Clear()

        ' Clear the existing items in the ListView control
        lvCrewman.Items.Clear()
        lvRic.Items.Clear()



        Try
            con.Open()
            'CREWMEN
            Dim cmd As New SqlCommand("SELECT * FROM [CREWMEMBERS_MASTER_TABLE] WHERE [GROUP] = @GroupName AND POSITION = 'CREWMEN'", con)
            cmd.Parameters.AddWithValue("@GroupName", var_GroupName)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim value As String = reader("Name").ToString() 'get value from the table
                lvCrewman.Items.Add(value)
            End While
            reader.Close()

            'RIC
            Dim cmdToLoadRIC As New SqlCommand("SELECT * FROM [CREWMEMBERS_MASTER_TABLE] WHERE [GROUP] = @GroupName AND POSITION = 'RIC'", con)
            cmdToLoadRIC.Parameters.AddWithValue("@GroupName", var_GroupName)

            Dim readerRics As SqlDataReader = cmdToLoadRIC.ExecuteReader()
            While readerRics.Read()
                Dim valueRIC As String = readerRics("Name").ToString() 'get values
                lvRic.Items.Add(valueRIC)
            End While
            readerRics.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Module
