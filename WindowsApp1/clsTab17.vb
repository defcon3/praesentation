Public Class clsTab17
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public wert As Integer
    Public resultat As String



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr
        resultat = CStr("C:\Temp\report\bild" & nr & ".jpg")
        wert = 44

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(17, "<tr><td width=""100%"" height=""100%""  align=""center"" valign=""middle"" bgcolor=""white"" color=""black""><br></br><img src=""" & resultat & """ alt=""Mein Bild""  style=""max-width: 100%; max-height: 100%;""></td><td width=""10%"" align=""middle"" rowspan=""1"" border=""1"" bordercolor=""black"">" & "" & "</td></tr>")





        Return tab.ToHtml
    End Function
End Class
