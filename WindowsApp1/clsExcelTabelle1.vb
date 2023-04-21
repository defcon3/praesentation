Public Class clsExcelTabelle1
    Property dt As DataTable

    Public Sub getnewtab()
        Dim dta As New DataTable()
        dta.Columns.Add("Nr", GetType(String))
        dta.Columns.Add("Strecke", GetType(String))
        dta.Columns.Add("Zahl1", GetType(String))
        dta.Columns.Add("Zahl2", GetType(String))
        dta.Columns.Add("Zahl3", GetType(String))
        dta.Columns.Add("Zahl4", GetType(String))
        dta.Columns.Add("Zahl5", GetType(String))
        dta.Columns.Add("Resultat1", GetType(String))
        dta.Columns.Add("Prozent2", GetType(String))
        dta.Columns.Add("Resultat2", GetType(String))
        dta.Columns.Add("Resultat3", GetType(String))
        dta.Columns.Add("Resultat4", GetType(String))
        dta.Columns.Add("Einwohner1", GetType(String))
        dta.Columns.Add("Einwohner2", GetType(String))
        dta.Columns.Add("Einwohner3", GetType(String))
        dta.Columns.Add("Einwohner4", GetType(String))
        dta.Columns.Add("Einwohner5", GetType(String))
        dta.Columns.Add("Einwohner6", GetType(String))
        dta.Columns.Add("Resultat5", GetType(String))
        dta.Columns.Add("Resultat6", GetType(String))
        dta.Columns.Add("Bemerkung6", GetType(String))
        dta.Columns.Add("Ergebnis", GetType(String))
        Me.dt = dta

    End Sub


End Class
