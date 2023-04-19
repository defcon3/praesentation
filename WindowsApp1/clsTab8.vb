Public Class clsTab8
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public wert As String



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

        wert = "Nein"

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(nummer, "<tr><td width=""90%"" align=""left"" bgcolor=""white"" color=""black""></td><td width=""10%"" align=""middle"" rowspan=""2"" border=""1"">" & wert & "</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("3. Verkehrsströme weichen von Linienführung ab"))
        tab.AddRow(row1)


        Return tab.ToHtml
    End Function

End Class
