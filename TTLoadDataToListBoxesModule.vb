Imports System.Data.SqlClient

Module TTLoadDataToListBoxesModule
    Public Sub LoadDataToListBoxes(cbGroupPicker As ComboBox, lvCrewman As ListBox, lvRic As ListBox, con As SqlConnection, cbOPerater As ComboBox)

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

            'OPERATOR
            Dim cmdToLoadOP As New SqlCommand("SELECT * FROM [CREWMEMBERS_MASTER_TABLE] WHERE [GROUP] = @GroupName AND POSITION = 'OPERATOR'", con)
            cmdToLoadOP.Parameters.AddWithValue("@GroupName", var_GroupName)

            Dim readerOP As SqlDataReader = cmdToLoadOP.ExecuteReader()
            While readerOP.Read()
                Dim valueOP As String = readerOP("NAME").ToString() 'get values
                cbOPerater.Items.Add(valueOP)
            End While
            readerOP.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Module
