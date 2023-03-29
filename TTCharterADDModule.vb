Imports System.Data.SqlClient
Imports System.Globalization
Imports DocumentFormat.OpenXml.Drawing

Module TTCharterADDModule

    Public Sub addCharterToTable(connsql As SqlConnection,
                                 tbFlightCharter As TextBox,
                                 cbEtaMCharter As ComboBox,
                                 cbEtaHCharter As ComboBox,
                                 cbAirCharter As ComboBox,
                                 tbBayNoCharter As TextBox,
                                 cbRemarkCharter As ComboBox)

        'check whether all the fields are empty
        If String.IsNullOrEmpty(tbFlightCharter.Text) Then
            MsgBox("Fill The Field")
            tbFlightCharter.Focus()

        ElseIf String.IsNullOrEmpty(cbEtaMCharter.Text) Then
            MsgBox("Fill The Field")
            cbEtaMCharter.Focus()

        ElseIf String.IsNullOrEmpty(cbEtaHCharter.Text) Then
            MsgBox("Fill The Field")
            cbEtaHCharter.Focus()

        ElseIf String.IsNullOrEmpty(cbAirCharter.Text) Then
            MsgBox("Fill The Field")
            cbAirCharter.Focus()
        Else

            Dim flight As String = tbFlightCharter.Text 'flightNo
            Dim bay As String = tbBayNoCharter.Text 'bay

            'eta
            Dim eta1 As String = cbEtaHCharter.Text & ":" & cbEtaMCharter.Text & ":00"
            Dim eta2 As DateTime = DateTime.ParseExact(eta1, "HH:mm:ss", CultureInfo.InvariantCulture)
            Dim eta As TimeSpan = eta2.TimeOfDay

            Dim air As String = cbAirCharter.Text 'airline
            Dim remark As String = cbRemarkCharter.Text 'remarks

            Dim sql As String = "INSERT INTO CHARTER_TIME_TABLE (ETA, FLIGHT, BAYNO, AIRLINE, REMARKS) values (@eta, @fli, @bay, @air, @rem)"
            connsql.Open()
            Dim com As New SqlCommand(sql, connsql)
            com.Parameters.AddWithValue("@eta", eta)
            com.Parameters.AddWithValue("@fli", flight)
            com.Parameters.AddWithValue("@bay", bay)
            com.Parameters.AddWithValue("@air", air)
            com.Parameters.AddWithValue("@rem", remark)
            com.ExecuteNonQuery()

            'connection close
            connsql.Close()
            MsgBox("Successfully Added To The Table")


        End If



    End Sub

End Module
