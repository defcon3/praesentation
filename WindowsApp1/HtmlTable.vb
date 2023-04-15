
Imports System.IO

Public Class HtmlTable

    Private _rows As New List(Of HtmlTableRow)

    Public Sub AddRow(row As HtmlTableRow)
        _rows.Add(row)
    End Sub

    Public Function ToHtml() As String
        Dim tableHtml As New System.Text.StringBuilder()
        tableHtml.Append("<table border=""1"">")
        For Each row In _rows
            tableHtml.Append(row.ToHtml())
        Next
        tableHtml.Append("</table>")
        Return tableHtml.ToString()
    End Function

    Public Sub SaveToFile(fileName As String)
        Dim filePath As String = Path.Combine("C:\Temp\report", fileName)
        Using writer As New StreamWriter(filePath)
            writer.Write(ToHtml())
        End Using
    End Sub

End Class


