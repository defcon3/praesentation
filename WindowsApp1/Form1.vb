Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim table1 As New HtmlTable(1, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        'Dim table2 As New HtmlTable(2, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Verkehrspotenzial</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")




        Dim tab1 As New clsTab1(1) With {.nummer = 949, .strecke = "Trakehnerweg"}
        Dim tab2 As New clstab2(2)
        Dim tab3 As New clsTab3(3)
        Dim tab4 As New clsTab4(4)

        Dim tab5 As New clstab2(5)
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



End Class
