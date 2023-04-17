Public Class clsTab4
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(4, "<tr><td width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</td><td width=""40%"" align=""left"" rowspan=""4"">vdxd</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("Einwohner im 3,0 EZB je km Streckenlänge:"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("Einwohner im 3,0 EZB je km Streckenlänge:"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("Einwohner im 3,0 EZB je km Streckenlänge:"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("Einwohner im 3,0 EZB je km Streckenlänge:"))
        tab.AddRow(row1)


        Return tab.ToHtml
    End Function
End Class
