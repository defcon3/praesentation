Public Class clsTab9
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public wert As Integer
    Public resultat As String



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr


    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(9, "<tr><td width=""90%"" align=""left"" bgcolor=""white"" color=""black"">4. Busverkehr wegen zersplitterter Siedlungsstruktur nicht zu ersetzen</td><td width=""10%"" align=""middle"" rowspan=""2"" border=""1"">" & resultat & "</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("&nbsp;&nbsp;&nbspAnzahl Orte nach Einwohnerklassen"))
        tab.AddRow(row1)



        Return tab.ToHtml
    End Function
End Class
