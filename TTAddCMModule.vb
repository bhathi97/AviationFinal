﻿

Module TTAddCMModule
    Public Sub addCM(lb As ListBox, dgv As DataGridView)

        Dim itemCount As Integer = lb.Items.Count 'listview column count
        Dim flag As Integer = 0

        'loop thruogh the table rows
        If itemCount <> 1 Then

            For i As Integer = 0 To dgv.Rows.Count - 1

                If dgv.Rows(i).Cells("Column3") IsNot Nothing AndAlso dgv.Rows(i).Cells("Column3").Value <> "YES" AndAlso dgv.Rows(i).Cells("Column2").Value <> True Then

                    If flag < itemCount Then
                        dgv.Rows(i).Cells("Column8").Value = lb.Items(flag).ToString()
                        flag += 1
                        If flag = itemCount Then flag = 0 ' reset flag if it reaches the end of the ListView

                    End If

                ElseIf dgv.Rows(i).Cells("Column2").Value = True Then

                Else
                    dgv.Rows(i).Cells("Column8").Value = ""
                End If

            Next

            'loop thruogh the table rows

            'if there is only one item 

        ElseIf itemCount = 1 Then

            For i As Integer = 0 To dgv.RowCount - 1

                If dgv.Rows(i).Cells("Column3") IsNot Nothing AndAlso dgv.Rows(i).Cells("Column3").Value <> "YES" Then

                    dgv.Rows(i).Cells("Column8").Value = lb.Items(0).ToString()

                Else
                    dgv.Rows(i).Cells("Column8").Value = ""
                End If

            Next

        End If

    End Sub



End Module
