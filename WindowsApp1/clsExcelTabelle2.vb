Public Class clsExcelTabelle2
    Property dt As DataTable

    Public Sub getnewtab()
        Dim dta As New DataTable
        dta.Columns.Add("Nr", GetType(String))
        dta.Columns.Add("Verwaltungseinheit", GetType(String))
        dta.Columns.Add("Zentraler Ort", GetType(String))
        dta.Columns.Add("Einwohner, Gesamt", GetType(String))
        dta.Columns.Add("Gästeankünfte", GetType(String))
        dta.Columns.Add("Einwohner (1,5 km EZB)", GetType(String))
        dta.Columns.Add("Einwohner (3,0 km EZB)", GetType(String))
        Me.dt = dta

    End Sub
End Class
