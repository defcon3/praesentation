Public Class clsTab10
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""
    Public dt As New DataTable
    Public e1, e2, e3, e4, e5, e6 As Int16


    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr


        Dim k As New DataTable
        k.Columns.Add("< 1.000")
        k.Columns.Add("1.000 - 1.999")
        k.Columns.Add("2.000 - 4.999")
        k.Columns.Add("5.000 - 9.999")
        k.Columns.Add("10.000 - 19.999")
        k.Columns.Add("> 20.000")

        dt = k.Copy



    End Sub

    Public Overrides Function ToString() As String

        Dim r As DataRow
        r = dt.NewRow
        r(0) = e1
        r(1) = e2
        r(2) = e3
        r(3) = e4
        r(4) = e5
        r(5) = e6
        dt.Rows.Add(r)



        Dim row As New HtmlTableRow()
        'Dim innertab As New HtmlTable(99, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        'Dim innertab As New HtmlTable(99, "<tr><th width=""50%"" align=""left"" bgcolor=""white"" color=""gray"">Verwaltungseinheit</th>
        Dim innertab As New HtmlTable(99, "<tr><th width=""10%"" align=""center"">< 1.000</th>
<!-- <th width=""10%"" align=""center"">< 1.000</th> -->
<th width=""10%"" align=""center"">1.000 - 1.999</th>
<th width=""10%"" align=""center"">2.000 - 4.999</th>
<th width=""10%"" align=""center"">5.000 - 9.999</th>
<th width=""10%"" align=""center"">10.000 - 19.999</th>
<th width=""10%"" align=""center"">>20.000</th>
<th width=""0%"" align=""center"" color=""white""></th>")

        For Each rw In dt.Rows
            row.AddCell(New HtmlTableCell(rw(0).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(1).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(2).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(3).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(4).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(5).ToString, IIf(rw(0) Mod 2 = 1, Color.MistyRose, Color.LightGray)))
            'row.AddCell(New HtmlTableCell(rw(0).ToString, , Color.White))
            innertab.AddRow(row)
            row = New HtmlTableRow
        Next

        'row.AddCell(New HtmlTableCell("    (EZB = Einzugsbereich",, Color.Gray))
        'row.AddCell(New HtmlTableCell(""))
        'row.AddCell(New HtmlTableCell(""))
        'row.AddCell(New HtmlTableCell(""))
        'row.AddCell(New HtmlTableCell("9.042"))
        'row.AddCell(New HtmlTableCell("11.955"))


        'innertab.AddRow(row)

        tab = New HtmlTable(2, "<tr>" & innertab.ToHtml & "</tr>")



        Return tab.ToHtml
    End Function
End Class
