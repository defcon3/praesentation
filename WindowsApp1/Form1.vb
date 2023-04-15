Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim table As New HtmlTable()
        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("Name"))
        row1.AddCell(New HtmlTableCell("Alter"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        table.AddRow(row1)
        Dim row2 As New HtmlTableRow()
        row2.AddCell(New HtmlTableCell("Max Mustermann"))
        row2.AddCell(New HtmlTableCell("35"))
        row2.AddCell(New HtmlTableCell("Berlin"))
        table.AddRow(row2)
        Dim row3 As New HtmlTableRow()
        row3.AddCell(New HtmlTableCell("Erika Msustermann"))
        row3.AddCell(New HtmlTableCell("Hamburg"))
        table.AddRow(row3)
        Dim row4 As New HtmlTableRow()
        row4.AddCell(New HtmlTableCell("Max Mustermann"))
        row4.AddCell(New HtmlTableCell("35"))
        row4.AddCell(New HtmlTableCell("Berlin"))
        table.AddRow(row4)
        Dim htmlString As String = table.ToHtml()

        Console.WriteLine(htmlString)

        table.SaveToFile("table.html")



    End Sub
End Class
