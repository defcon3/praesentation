Public Class clsTab3
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""
    Public dt As New DataTable


    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "", Optional d As DataTable = Nothing)
        MyBase.New(nr, breiten)
        nummer = nr

        dt = d


    End Sub

    Public Overrides Function ToString() As String

        Dim row As New HtmlTableRow()
        'Dim innertab As New HtmlTable(99, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        Dim innertab As New HtmlTable(99, "<tr><th width=""50%"" align=""left"" bgcolor=""white"" color=""gray"">Verwaltungseinheit</th>
<th width=""10%"" align=""center"">Zentraler Ort</th>
<th width=""10%"" align=""center"">Einwohner, Gesamt</th>
<th width=""10%"" align=""center"">Gästeankünfte</th>
<th width=""10%"" align=""center"">Einwohner (1,5 km EZB)</th>
<th width=""10%"" align=""center"">Einwohner (3,0 km EZB)</th>
<th width=""0%"" align=""center"" color=""white""></th>")

        Dim z As Integer = 1
        Dim summe1 As Integer
        Dim summe2 As Integer

        For Each rw In dt.Rows

            row.AddCell(New HtmlTableCell(rw(1).ToString, IIf(z Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(2).ToString, IIf(z Mod 2 = 1, Color.Moccasin, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(3).ToString, IIf(z Mod 2 = 1, Color.Moccasin, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(4).ToString, IIf(z Mod 2 = 1, Color.Moccasin, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(5).ToString, IIf(z Mod 2 = 1, Color.Moccasin, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(6).ToString, IIf(z Mod 2 = 1, Color.Moccasin, Color.LightGray)))
            'row.AddCell(New HtmlTableCell(rw(0).ToString, , Color.White))

            summe1 += rw(5)
            summe2 += rw(6)
            z += 1
            innertab.AddRow(row)
            row = New HtmlTableRow
        Next


        row.AddCell(New HtmlTableCell("    (EZB = Einzugsbereich",, Color.Gray))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(summe1.ToString))
        row.AddCell(New HtmlTableCell(summe2.ToString))


        innertab.AddRow(row)

        tab = New HtmlTable(2, "<tr>" & innertab.ToHtml & "</tr>")



        Return tab.ToHtml
    End Function
End Class
