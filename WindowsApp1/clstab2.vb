Public Class clsTab2
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

    End Sub

    Public Overrides Function ToString() As String

        tab = New HtmlTable(2, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""green"">Verkehrspotenzial</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")
        If nummer = 5 Then
            tab = New HtmlTable(5, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Ausschlusskriterien</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")
        End If
        If nummer = 14 Then
            tab = New HtmlTable(14, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Ergebnis</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")
        End If
        If nummer = 16 Then
            tab = New HtmlTable(16, "<tr><th width=""20%"" align=""left"" bgcolor=""white"" color=""gray"">Lageplan</th><th width=""80%"" align=""left"">______________________________________________________________________________________________________</th></tr>")
        End If


        Return tab.ToHtml
    End Function
End Class
