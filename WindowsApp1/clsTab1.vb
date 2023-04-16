Public Class clsTab1

    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)

    End Sub

    Public Overrides Function ToString() As String
        tab = New HtmlTable(1, "<tr><th width=""2%"" align=""left"" bgcolor=""blue"" color=""white"">Nr:</th><th width=""5%"" align=""left"">" & nummer & "</th><th width=""13%"" align=""left"">Strecke:</th><th width=""80%"" align=""left"">" & strecke & "</th></tr>")
        Return tab.ToHtml
    End Function

End Class
