

Imports DocumentFormat.OpenXml.Bibliography
Imports System.Data.SqlClient

Module ItemsModule


    Public Sub CrewmanAddingSelectGroup(cb As ComboBox) 'Load simple choices A, B, C, D into combo box
        cb.Items.Add("A")
        cb.Items.Add("B")
        cb.Items.Add("C")
        cb.Items.Add("D")
    End Sub




    Public Sub CrewmanAddingSelectPosistion(cb As ComboBox) 'Load positions into combo box
        cb.Items.Add("CREWMEN")
        cb.Items.Add("RIC")
    End Sub


    Public Sub AirlineCategoryLoad(connsql As SqlConnection, cb As ComboBox) 'Load Airline Categories into combo box
        Try

            Dim cmd As New SqlCommand("SELECT * FROM AIRLINE_MASTER_TABLE", connsql)
            connsql.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cb.Items.Add(reader("AIRLINE_CODE").ToString())
            End While

            reader.Close()
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub

    Public Sub AirLineLoadWhenCategorySelect(connsql As SqlConnection, cb As ComboBox, tbName As Label) 'Load Airline Names into lable
        Try
            connsql.Open()

            Dim cmd As New SqlCommand("SELECT Airline_Name FROM AIRLINE_MASTER_TABLE where Airline_Code = @cd ", connsql)

            cmd.Parameters.AddWithValue("@cd", cb.Text)
            Dim airline = cmd.ExecuteScalar()
            tbName.Text = airline
            connsql.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try


    End Sub

    Public Sub loadcbSTD(cb As ComboBox) 'load std / hh of std

        Try

            For i As Integer = 0 To 24
                Dim formattedNumber As String = i.ToString("D2")
                cb.Items.Add(formattedNumber.ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadcbSTD1(cb As ComboBox) 'load std / mm of std

        Try

            For j As Integer = 0 To 60
                Dim formattedNumber As String = j.ToString("D2")
                cb.Items.Add(formattedNumber.ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loadDipTime(cb As ComboBox) 'load Diparture time

        Try
            cb.Items.Add("00:30") 'add to combo box
            cb.Items.Add("01:00")
            cb.Items.Add("01:30")
            cb.Items.Add("02:00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Module
