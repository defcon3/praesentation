Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Public Class Form1

    Private xslTab1 As New DataTable
    Private xslTab2 As New DataTable
    Private xslTab3 As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim table1 As New HtmlTable(1, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        'Dim table2 As New HtmlTable(2, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Verkehrspotenzial</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")




        Dim tab1 As New clsTab1(1) With {.nummer = 949, .strecke = "Trakehnerweg"}
        Dim tab2 As New clsTab2(2)
        Dim tab3 As New clsTab3(3)
        Dim tab4 As New clsTab4(4) With {.z1 = 0, .z2 = 1, .z3 = 2, .z4 = 3, .z5 = 4}

        Dim tab5 As New clsTab2(5)
        Dim tab6 As New clsTab6(6)
        Dim tab7 As New clsTab7(7)
        Dim tab8 As New clsTab8(8)
        Dim tab9 As New clsTab9(9)
        Dim tab10 As New clsTab10(10)
        Dim tab11 As New clsTab11(11)
        Dim tab12 As New clsTab12(12)
        Dim tab13 As New clsTab13(13)
        Dim tab14 As New clsTab2(14)
        Dim tab15 As New clsTab15(15)
        Dim tab16 As New clsTab2(16)
        Dim tab17 As New clsTab17(17)

        Dim temptable As New DataTable

        For i = 0 To xslTab1.Rows.Count - 1

            tab1 = New clsTab1(1) With {.nummer = xslTab1.Rows(i)("Nr"), .strecke = xslTab1.Rows(i)("Strecke")}
            tab2 = New clsTab2(2)
            tab3 = New clsTab3(3,, xslTab2.Select("Nr=" & xslTab1.Rows(i)("Nr")).ToList.CopyToDataTable)
            tab4 = New clsTab4(4) With {.z1 = xslTab1.Rows(i)("Zahl1"), .z2 = xslTab1.Rows(i)("Zahl2"), .z3 = xslTab1.Rows(i)("Zahl3"), .z4 = xslTab1.Rows(i)("Zahl4"), .z5 = xslTab1.Rows(i)("Zahl5")}
            tab5 = New clsTab2(5)
            tab6 = New clsTab6(6) With {.wert = xslTab1.Rows(i)("Resultat1")}
            tab7 = New clsTab7(7) With {.resultat = xslTab1.Rows(i)("Resultat2"), .wert = xslTab1.Rows(i)("Prozent2")}
            tab8 = New clsTab8(8) With {.wert = xslTab1.Rows(i)("Resultat3")}
            tab9 = New clsTab9(9) With {.resultat = xslTab1.Rows(i)("Resultat4")}
            tab10 = New clsTab10(10) With {.e1 = xslTab1.Rows(i)("Einwohner1"), .e2 = xslTab1.Rows(i)("Einwohner2"), .e3 = xslTab1.Rows(i)("Einwohner3"), .e4 = xslTab1.Rows(i)("Einwohner4"), .e5 = xslTab1.Rows(i)("Einwohner5"), .e6 = xslTab1.Rows(i)("Einwohner6")}
            tab11 = New clsTab11(11) With {.resultat = xslTab1.Rows(i)("Resultat5")}
            tab12 = New clsTab12(12,, xslTab3.Select("Nr=" & xslTab1.Rows(i)("Nr")).ToList.CopyToDataTable)
            tab15 = New clsTab15(15) With {.resultat = xslTab1.Rows(i)("Ergebnis")}




        Next







        Dim k As New DataTable
        k.Columns.Add("Zeile")
        k.Columns.Add("Verwaltungseinheit")
        k.Columns.Add("Zentraler Ort")
        k.Columns.Add("Einwohner, Gesamt")
        k.Columns.Add("Gästeankünfte")
        k.Columns.Add("Einwohner (1,5 km EZB)")
        k.Columns.Add("Einwohner (3,0 km EZB)")
        Dim r As DataRow
        r = k.NewRow
        r(0) = "1"
        r(1) = "Dannenberg (Elbe)"
        r(2) = ""
        r(3) = "8.089"
        r(4) = "4859"
        r(5) = "2.360"
        r(6) = "2.754"
        k.Rows.Add(r)
        r = k.NewRow
        r(0) = "2"
        r(1) = "Jameln"
        r(2) = ""
        r(3) = "1.072"
        r(4) = ""
        r(5) = "720"
        r(6) = "865"
        k.Rows.Add(r)
        r = k.NewRow
        r(0) = "3"
        r(1) = "Küsten"
        r(2) = ""
        r(3) = "1.374"
        r(4) = "-"
        r(5) = ""
        r(6) = "215"
        k.Rows.Add(r)
        r = k.NewRow
        r(0) = "4"
        r(1) = "Lüchow (Wendland)"
        r(2) = "MZ"
        r(3) = "9.467"
        r(4) = "13664"
        r(5) = "5.962"
        r(6) = "8.121"
        k.Rows.Add(r)


        'Dim table1 As New HtmlTable(1, "<tr width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</tr><tr width=""5%"" align=""left"">1</tr><tr width=""23%"" align=""left"">Strecke:</tr><tr width=""70%"" align=""left"">Dannenberg-Lüchow</tr>")
        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("Name"))
        row1.AddCell(New HtmlTableCell("Alter"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        'table1.AddRow(row1)

        Dim row2 As New HtmlTableRow()
        row2.AddCell(New HtmlTableCell("Max Musterman5n"))
        row2.AddCell(New HtmlTableCell("35"))
        row2.AddCell(New HtmlTableCell("Berlin"))
        'table1.AddRow(row2)
        Dim row3 As New HtmlTableRow()
        row3.AddCell(New HtmlTableCell("Erika Msustermann", Color.Red, Color.Violet))
        row3.AddCell(New HtmlTableCell("<svg width=""200"" height=""200""><rect x=""0"" y=""0"" width=""150"" height=""150"" fill=""#eaeaea"" /><rect x=""50"" y=""50"" width=""100"" height=""100"" fill=""red"" transform=""matrix(0.5, -0.5, 0.5, 0.5, 0, 0)""/></svg>"))
        'table1.AddRow(row3)
        Dim row4 As New HtmlTableRow()
        row4.AddCell(New HtmlTableCell("Max Mustermann"))
        row4.AddCell(New HtmlTableCell("35"))
        row4.AddCell(New HtmlTableCell("Berlin"))
        'table1.AddRow(row4)

        'Dim htmlString As String = tab1.ToString
        'htmlString.Append(table2.ToHtml)

        'Console.WriteLine(htmlString)


        ' Zusammenkleben
        tab1.anhang = tab1.ToString & tab2.ToString & tab3.ToString & tab4.ToString & tab5.ToString & tab6.ToString & tab7.ToString & tab8.ToString & tab9.ToString & tab10.ToString & tab11.ToString & tab12.ToString & tab13.ToString &
            "<div style=""page-break-before: always;"">" & tab1.ToString & "</div>" & tab2.ToString & tab14.ToString & tab15.ToString & tab16.ToString & tab17.ToString


        tab1.SaveToFile("table.html")



        'table1.anhang = table2.ToHtml
        'table1.SaveToFile("table.html")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkbook As Excel.Workbook = Nothing
        Dim xlWorksheet As Excel.Worksheet = Nothing
        Dim excelTabelle1 As New clsExcelTabelle1

        Try
            ' Pfad und Dateiname des Excel-Files
            Dim path As String = "C:\Temp\report\Zahlenbeispiel.xlsx"

            ' Excel-Application starten und Excel-File öffnen
            xlWorkbook = xlApp.Workbooks.Open(path)

            ' Tabellenblatt auswählen
            xlWorksheet = CType(xlWorkbook.Sheets("Tabelle1"), Excel.Worksheet)

            ' Daten aus der Zelle A1 lesen
            'Dim cellValue As String = xlWorksheet.Range("A1").Value.ToString()
            Dim range As Excel.Range = xlWorksheet.Range("A2:V5")
            Dim data As Object(,) = range.Value

            Dim newtab As New clsExcelTabelle1
            newtab.getnewtab()
            Dim dr As DataRow

            ' Schleife über die Zeilen des Arrays
            For i As Integer = 1 To data.GetLength(0)

                dr = newtab.dt.NewRow
                ' Schleife über die Spalten des Arrays
                For j As Integer = 1 To data.GetLength(1)


                    dr(j - 1) = data(i, j)


                    ' Datenverarbeitung für die Zelle in Zeile i, Spalte j...
                    ' ...
                    ' Beispiel: Ausgabe des Zelleninhalts für die Zelle in Zeile i, Spalte j
                    Console.WriteLine(data(i, j))
                Next
                newtab.dt.Rows.Add(dr)

            Next



            xslTab1 = newtab.dt

#Region "tabelle2"


            ' Tabellenblatt auswählen
            xlWorksheet = CType(xlWorkbook.Sheets("Tabelle2"), Excel.Worksheet)

            ' Daten aus der Zelle A1 lesen
            'Dim cellValue As String = xlWorksheet.Range("A1").Value.ToString()
            range = xlWorksheet.Range("A2:G32")
            data = range.Value

            Dim newtab2 = New clsExcelTabelle2
            newtab2.getnewtab()
            Dim dr2 As DataRow

            ' Schleife über die Zeilen des Arrays
            For i As Integer = 1 To data.GetLength(0)

                dr2 = newtab2.dt.NewRow
                ' Schleife über die Spalten des Arrays
                For j As Integer = 1 To data.GetLength(1)


                    dr2(j - 1) = data(i, j)


                    ' Datenverarbeitung für die Zelle in Zeile i, Spalte j...
                    ' ...
                    ' Beispiel: Ausgabe des Zelleninhalts für die Zelle in Zeile i, Spalte j
                    Console.WriteLine(data(i, j))
                Next
                newtab2.dt.Rows.Add(dr2)

            Next



            xslTab2 = newtab2.dt

#End Region


#Region "tabelle3"


            ' Tabellenblatt auswählen
            xlWorksheet = CType(xlWorkbook.Sheets("Tabelle3"), Excel.Worksheet)

            ' Daten aus der Zelle A1 lesen
            'Dim cellValue As String = xlWorksheet.Range("A1").Value.ToString()
            range = xlWorksheet.Range("A2:F7")
            data = range.Value

            Dim newtab3 = New clsExcelTabelle3
            newtab3.getnewtab()
            Dim dr3 As DataRow

            ' Schleife über die Zeilen des Arrays
            For i As Integer = 1 To data.GetLength(0)

                dr3 = newtab3.dt.NewRow
                ' Schleife über die Spalten des Arrays
                For j As Integer = 1 To data.GetLength(1)


                    dr3(j - 1) = data(i, j)


                    ' Datenverarbeitung für die Zelle in Zeile i, Spalte j...
                    ' ...
                    ' Beispiel: Ausgabe des Zelleninhalts für die Zelle in Zeile i, Spalte j
                    Console.WriteLine(data(i, j))
                Next
                newtab3.dt.Rows.Add(dr3)

            Next



            xslTab3 = newtab3.dt

#End Region


            ' Datenverarbeitung...
            ' ...

        Catch ex As Exception
            ' Fehlerbehandlung...
        Finally
            ' Excel-Workbook und -Application schließen
            If xlWorkbook IsNot Nothing Then
                xlWorkbook.Close(False)
                Marshal.ReleaseComObject(xlWorkbook)
            End If
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                Marshal.ReleaseComObject(xlApp)
            End If
        End Try




    End Sub
End Class
