Public Class clsTab7
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public wert As Integer
    Public resultat As String



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr
        'resultat = "Ja"
        'wert = 44

    End Sub

    Public Overrides Function ToString() As String



        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(7, "<tr><td width=""90%"" align=""left"" bgcolor=""white"" color=""black"">2. Haltestellen abseits Siedlungsschwerpunkte</td><td width=""10%"" align=""middle"" rowspan=""2""  style=""border: 1px solid black;"">" & resultat & "</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("&nbsp;&nbsp;&nbspVerhältnis Einwohner 1,5 EZB zu 3,0 EZB: " & wert.ToString & "%"))
        tab.AddRow(row1)



        Return tab.ToHtml
    End Function
End Class
