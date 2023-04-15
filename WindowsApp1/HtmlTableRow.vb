Imports System.Text

Public Class HtmlTableRow
    Private _cells As New List(Of HtmlTableCell)

    Public Sub AddCell(cell As HtmlTableCell)
        _cells.Add(cell)
    End Sub

    Public Function ToHtml() As String
        Dim rowHtml As New StringBuilder()
        rowHtml.AppendLine("<tr>")
        For Each cell In _cells
            rowHtml.Append(cell.ToHtml())
        Next
        rowHtml.Append("</tr>")
        Return rowHtml.ToString()
    End Function
End Class
