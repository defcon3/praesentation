Public Class clsTab3
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""
    Public dt As New DataTable


    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr


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

        dt = k.Copy



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
        Dim rr As DataRow

        For Each rw In dt.Rows
            row.AddCell(New HtmlTableCell(rw(1).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(2).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(3).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(4).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(5).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(6).ToString, IIf(rw(0) Mod 2 = 1, Color.White, Color.LightGray)))
            'row.AddCell(New HtmlTableCell(rw(0).ToString, , Color.White))
            innertab.AddRow(row)
            row = New HtmlTableRow
        Next

        row.AddCell(New HtmlTableCell("    (EZB = Einzugsbereich",, Color.Gray))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell("9.042"))
        row.AddCell(New HtmlTableCell("11.955"))


        innertab.AddRow(row)

        tab = New HtmlTable(2, "<tr>" & innertab.ToHtml & "</tr>")



        Return tab.ToHtml
    End Function
End Class
