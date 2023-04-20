Public Class clsTab15
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public wert As Integer
    Public resultat As String



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr
        resultat = CStr("Strecke scheidet aus, da Verkehrspotential ""gering"" und mindestens ein weiteres Ausschlusskriterium zutrifft")
        wert = 44

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(15, "<tr><td width=""100%"" align=""left"" bgcolor=""white"" color=""black"">" & resultat & "</td><td width=""10%"" align=""middle"" rowspan=""1"" border=""1"" bordercolor=""black"">" & "" & "</td></tr>")

        'Dim row1 As New HtmlTableRow()
        'row1.AddCell(New HtmlTableCell("&nbsp;&nbsp;&nbspkein stündlicher Anschluss am Verknüpfungsbahnhof möglich"))
        'tab.AddRow(row1)



        Return tab.ToHtml
    End Function

End Class
