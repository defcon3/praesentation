Public Class clsExcelTabelle3
    Property dt As DataTable

    Public Sub getnewtab()
        Dim dta As New DataTable
        dta.Columns.Add("Nr", GetType(String))
        dta.Columns.Add("Streckennr", GetType(String))
        dta.Columns.Add("Abschnitt", GetType(String))
        dta.Columns.Add("Status", GetType(String))
        dta.Columns.Add("Betreiber", GetType(String))
        dta.Columns.Add("km", GetType(String))
        Me.dt = dta

    End Sub
End Class
