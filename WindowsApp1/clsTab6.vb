Public Class clsTab6
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public dreieck1, dreieck2, dreieck3, dreieck4 As Decimal



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(6, "<tr><td width=""90%"" align=""left"" bgcolor=""white"" color=""black"">Einwohner im 3,0 EZB je km Streckenlänge:</td><td width=""10%"" align=""middle"" rowspan=""1"">1</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("1. Geringes Verkehrspotential"))
        tab.AddRow(row1)


        Return tab.ToHtml
    End Function

End Class
