Imports DocumentFormat.OpenXml.Wordprocessing
Imports PdfSharpCore.Drawing
Imports PdfSharpCore.Pdf
Imports System.IO

Module PFPrintDocModule
    Public Sub CreatePDFDOcument(dgPrint As DataGridView,
                                 PictureBox2 As PictureBox,
                                 dateShower As Label,
                                 shiftShower As Label,
                                 dayShower As Label,
                                 shiftTimeShower As Label)

        ' Create a new PDF document
        Dim document As New PdfDocument()

        Dim rowCountOfGrid As Integer = dgPrint.RowCount
        'MsgBox(rowCountOfGrid)

        Dim pageCount As Integer = Math.Ceiling(rowCountOfGrid / 20)
        'MsgBox(pageCount)
        'loop throgh to make pages containing 20 rows in each


        For pc As Integer = 1 To pageCount
            ' Add a new page to the document
            Dim page As PdfPage = document.AddPage()

            ' Set the page size to A4
            page.Width = XUnit.FromMillimeter(210)
            page.Height = XUnit.FromMillimeter(297)

            ' Create a PDF graphics object to draw on the page
            Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

            ' Add some text to the page
            Dim font As New XFont("Times New Roman", 16.5)
            gfx.DrawString("CEYLON PETROLEUM CORPORATION - AVIATION FUNCTION", font, XBrushes.Black, New XRect(45, 10, page.Width.Point - 100, 50), XStringFormats.Center)

            Dim font1 As New XFont("Times New Roman", 14, XFontStyle.Bold Or XFontStyle.Underline)
            gfx.DrawString("DAILY WORK SCHEDULE", font1, XBrushes.Black, New XRect(55, 32, page.Width.Point - 100, 50), XStringFormats.Center)

            ' Get the image from the picture box (Here PicturBox2)
            Dim image As System.Drawing.Image = PictureBox2.Image

            ' Convert the image to a byte array
            Dim ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Dim imageBytes() As Byte = ms.ToArray()

            ' Create a new XImage object from the byte array
            Dim xImage As XImage = XImage.FromStream(Function() New MemoryStream(imageBytes))

            ' Draw the image on the page
            gfx.DrawImage(xImage, New XRect(10, 40, 100, 50))
            gfx.DrawImage(xImage, New XRect(480, 40, 100, 50))


            '------------
            ' Draw the dateShower label text on the page
            Dim fontLbl As New XFont("Times New Roman", 13)

            Dim dateText As String = "Date:           " + dateShower.Text '  Label control data of date
            gfx.DrawString(dateText, fontLbl, XBrushes.Black, New XRect(100, 75, page.Width.Point - 20, 50), XStringFormats.TopLeft)


            Dim shiftTimeText As String = "Shift Time: " + shiftTimeShower.Text '  Label control of shift time 
            gfx.DrawString(shiftTimeText, fontLbl, XBrushes.Black, New XRect(100, 90, page.Width.Point - 20, 50), XStringFormats.TopLeft)

            Dim dayText As String = "Day:  " + dayShower.Text '  Label control of day 
            gfx.DrawString(dayText, fontLbl, XBrushes.Black, New XRect(400, 75, page.Width.Point - 20, 50), XStringFormats.TopLeft)

            Dim shiftText As String = "Shift: " + shiftShower.Text '  Label control of day 
            gfx.DrawString(shiftText, fontLbl, XBrushes.Black, New XRect(400, 90, page.Width.Point - 20, 50), XStringFormats.TopLeft)


            'draw datagridview----------------------------------
            ' Define the table layout
            Dim tableWidth As Double = 570
            Dim columnWidths As Double() = {50, 20, 60, 55, 50, 80, 65, 65, 65, 60}
            Dim rowHeight As Double = 30
            Dim tableTop As Double = 110


            ' Draw the table header
            Dim tableHeaderFont As New XFont("Times New Roman", 9, XFontStyle.Bold)
            Dim tableHeaderPen As New XPen(XColors.Black, 1) ' Set the border color and width
            Dim tableHeaderRect As XRect


            ' Draw the header cells and their borders
            tableHeaderRect = New XRect(10, tableTop, 50, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("BAY NO", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 50, tableTop, 20, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("NO", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 70, tableTop, 60, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("FLIGHT", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 130, tableTop, 50, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("ROUTE", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 180, tableTop, 55, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("ETA", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 235, tableTop, 80, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("AIRLINES", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 315, tableTop, 65, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("RIC", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 380, tableTop, 65, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("OPERATOR", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 445, tableTop, 65, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("CREWMAN", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)

            tableHeaderRect = New XRect(10 + 510, tableTop, 60, rowHeight)
            gfx.DrawRectangle(tableHeaderPen, tableHeaderRect)
            gfx.DrawString("REMARKS", tableHeaderFont, XBrushes.Black, tableHeaderRect, XStringFormats.Center)


            ' Draw the table data
            Dim tableFont As New XFont("Times New Roman", 9)
            Dim tableLeft As Double = 10
            Dim tableBottom As Double = tableTop + (20 * rowHeight) ' Only draw first 16 rows
            Dim currentRow As Integer = 0

            Dim numDataRows As Integer = dgPrint.Rows.Count ' number of rows with data


            ' Draw the table border
            Dim pen As New XPen(XColors.Black, 0.5)
            Dim x1 As Double = tableLeft
            Dim x2 As Double = tableLeft + tableWidth
            Dim y1 As Double = tableTop
            Dim y2 As Double = tableBottom

            ' Draw the rows
            Dim rowPen As New XPen(XColors.Black, 0.2) ' Set the border color and width
            Dim startIndex As Integer = pc * 20 - 20
            Dim stopIndex As Integer = pc * 20 - 1

            For k As Integer = 0 To 20

                For i As Integer = startIndex To stopIndex ' loop through rows 

                    If i <= numDataRows - 1 Then

                        For j As Integer = 1 To 2
                            Dim cellRect1 As New XRect(tableLeft, 110 + (k + 1) * rowHeight, 50, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect1)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column1").Value.ToString(), tableFont, XBrushes.Black, cellRect1, XStringFormats.Center)
                            j += 1

                            Dim cellRect2 As New XRect(tableLeft + 50, 110 + (k + 1) * rowHeight, 20, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect2)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column2").Value.ToString(), tableFont, XBrushes.Black, cellRect2, XStringFormats.Center)
                            j += 1

                            Dim cellRect3 As New XRect(tableLeft + 70, 110 + (k + 1) * rowHeight, 60, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect3)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column3").Value.ToString(), tableFont, XBrushes.Black, cellRect3, XStringFormats.Center)

                            Dim cellRect4 As New XRect(tableLeft + 130, 110 + (k + 1) * rowHeight, 50, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect4)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column10").Value.ToString(), tableFont, XBrushes.Black, cellRect4, XStringFormats.Center)
                            j += 1

                            Dim cellRect5 As New XRect(tableLeft + 180, 110 + (k + 1) * rowHeight, 55, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect5)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column4").Value.ToString(), tableFont, XBrushes.Black, cellRect5, XStringFormats.Center)
                            j += 1

                            Dim cellRect6 As New XRect(tableLeft + 235, 110 + (k + 1) * rowHeight, 80, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect6)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column5").Value.ToString(), tableFont, XBrushes.Black, cellRect6, XStringFormats.Center)
                            j += 1

                            Dim cellRect7 As New XRect(tableLeft + 315, 110 + (k + 1) * rowHeight, 65, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect7)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column6").Value.ToString(), tableFont, XBrushes.Black, cellRect7, XStringFormats.Center)
                            j += 1

                            Dim cellRect8 As New XRect(tableLeft + 380, 110 + (k + 1) * rowHeight, 65, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect8)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column7").Value.ToString(), tableFont, XBrushes.Black, cellRect8, XStringFormats.Center)
                            j += 1

                            Dim cellRect9 As New XRect(tableLeft + 445, 110 + (k + 1) * rowHeight, 65, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect9)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column8").Value.ToString(), tableFont, XBrushes.Black, cellRect9, XStringFormats.Center)
                            j += 1

                            Dim cellRect10 As New XRect(tableLeft + 510, 110 + (k + 1) * rowHeight, 60, rowHeight)
                            gfx.DrawRectangle(rowPen, cellRect10)
                            gfx.DrawString(dgPrint.Rows(i).Cells("Column9").Value.ToString(), tableFont, XBrushes.Black, cellRect10, XStringFormats.Center)
                            j += 1

                        Next j

                    Else
                        k = 20
                        Exit For

                    End If

                    k += 1
                    If k = 20 Then
                        Exit For
                    End If

                Next i

            Next k

            Dim font4 As New XFont("Times New Roman", 10)
            gfx.DrawString("SHIFT SUPERINTENDENT (AVIATION OPERATIONS)", font4, XBrushes.Black, New XRect(30, 750, page.Width.Point - 100, 50), XStringFormats.BottomLeft)
            gfx.DrawString("...................................................................................", font4, XBrushes.Black, New XRect(330, 760, page.Width.Point - 100, 50), XStringFormats.BottomLeft)

            ' Add footer to the page
            Dim font5 As New XFont("Times New Roman", 8)
            Dim footerText As String = String.Format("Page {0} of {1}", pc, pageCount)
            Dim footerRect As New XRect(20, 800 + 10, tableWidth, 20)
            gfx.DrawString(footerText, font5, XBrushes.Black, footerRect, XStringFormats.CenterLeft)

        Next

        ' Save the document to the desktop
        Dim desktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim filename As String = desktopFolder + "\test.pdf"
        document.Save(filename)


        MsgBox("The PDF document has been successfully created in the following directory: " + filename)

    End Sub

End Module
