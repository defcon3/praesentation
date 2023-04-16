Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim table1 As New HtmlTable("<tr><th width=""5%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""20%"" align=""left"">Strecke:</th><th width=""70%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("Name"))
        row1.AddCell(New HtmlTableCell("Alter"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        row1.AddCell(New HtmlTableCell("Stadt"))

        table1.AddRow(row1)
        Dim row2 As New HtmlTableRow()
        row2.AddCell(New HtmlTableCell("Max Mustermann"))
        row2.AddCell(New HtmlTableCell("35"))
        row2.AddCell(New HtmlTableCell("Berlin"))
        table1.AddRow(row2)
        Dim row3 As New HtmlTableRow()
        row3.AddCell(New HtmlTableCell("Erika Msustermann", Color.Red, Color.Violet))
        row3.AddCell(New HtmlTableCell("<svg width=""200"" height=""200""><rect x=""0"" y=""0"" width=""150"" height=""150"" fill=""#eaeaea"" /><rect x=""50"" y=""50"" width=""100"" height=""100"" fill=""red"" transform=""matrix(0.5, -0.5, 0.5, 0.5, 0, 0)""/></svg>"))
        table1.AddRow(row3)
        Dim row4 As New HtmlTableRow()
        row4.AddCell(New HtmlTableCell("Max Mustermann"))
        row4.AddCell(New HtmlTableCell("35"))
        row4.AddCell(New HtmlTableCell("Berlin"))
        table1.AddRow(row4)
        Dim htmlString As String = table1.ToHtml()

        Console.WriteLine(htmlString)

        table1.SaveToFile("table.html")



    End Sub
End Class
