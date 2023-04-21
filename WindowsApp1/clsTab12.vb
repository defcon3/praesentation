Public Class clsTab12
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""
    Public dt As New DataTable


    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "", Optional ByVal d As DataTable = Nothing)
        MyBase.New(nr, breiten)
        nummer = nr

        dt = d
        If Not dt Is Nothing Then dt.Columns.RemoveAt(0)

    End Sub

    Public Overrides Function ToString() As String

        Dim row As New HtmlTableRow()
        'Dim innertab As New HtmlTable(99, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">1</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">Dannenberg-Lüchow</th></tr>")
        'Dim innertab As New HtmlTable(99, "<tr><th width=""50%"" align=""left"" bgcolor=""white"" color=""gray"">Verwaltungseinheit</th>
        Dim innertab As New HtmlTable(12, "<tr><th width=""10%"" align=""center"">Streckennr</th>
<!-- <th width=""20%"" align=""center"">Abschnitt</br>Status</th> -->
<th width=""55%"" align=""center"">Abschnitt</br>Status</th>
<th width=""10%"" align=""center"">Betreiber</th>
<th width=""5%"" align=""center"">km</th>
<th width=""0%"" align=""center"" color=""white""></th>")


        Dim z As Integer = 1

        Dim summe1 As Double

        For Each rw In dt.Rows
            row.AddCell(New HtmlTableCell(rw(0).ToString, IIf(z Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(1).ToString & "</br>" & rw(2).ToString, IIf(z Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(3).ToString, IIf(z Mod 2 = 1, Color.White, Color.LightGray)))
            row.AddCell(New HtmlTableCell(rw(4).ToString, IIf(z Mod 2 = 1, Color.White, Color.LightGray)))
            z += 1
            summe1 += rw(4)
            innertab.AddRow(row)
            row = New HtmlTableRow
        Next


        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(""))
        row.AddCell(New HtmlTableCell(summe1.ToString))
        'row.AddCell(New HtmlTableCell("11.955"))


        innertab.AddRow(row)

        tab = New HtmlTable(2, "<tr>" & innertab.ToHtml & "</tr>")



        Return tab.ToHtml
    End Function
End Class
