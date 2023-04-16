Imports Microsoft.VisualBasic

Public Class clsTab3
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

    End Sub

    Public Overrides Function ToString() As String

        Dim innertab As New htmltable





        tab = New HtmlTable(3, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Verkehrspotenzial</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("Name"))
        row1.AddCell(New HtmlTableCell("Alter"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        row1.AddCell(New HtmlTableCell("Stadt"))
        'table1.AddRow(row1)



        Return tab.ToHtml
    End Function
End Class
