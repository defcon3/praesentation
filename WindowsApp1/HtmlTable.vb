
Imports System.IO

Public Class HtmlTable

    Private _rows As New List(Of HtmlTableRow)
    Private _breitenstring As String
    Private _nummer As Integer
    Public anhang As String = ""

    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        _breitenstring = breiten
        _nummer = nr
    End Sub

    Public Sub AddRow(row As HtmlTableRow)
        _rows.Add(row)
    End Sub



    Public Function ToHtml() As String
        Dim tableHtml As New System.Text.StringBuilder()
        'tableHtml.Append("<table border=""1"" width=""100%"">")

        Select Case _nummer
            Case 1
                tableHtml.Append("<table border=""1"" style=""background-color: blue; width: 100%; color: white;"">")
            Case 2
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: gray;"">")
            Case 3
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%;"">")
            Case 4
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%;"">")
            Case 5
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: gray;"">")
            Case 6
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: gray;"">")
            Case 99
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: gray;"">")
        End Select


        If _breitenstring <> "" Then tableHtml.AppendLine(_breitenstring)
        For Each row In _rows
            tableHtml.Append(row.ToHtml())
        Next
        tableHtml.Append("</table>")
        Return tableHtml.ToString()
    End Function

    Public Sub SaveToFile(fileName As String)
        Dim filePath As String = Path.Combine("C:\Temp\report", fileName)
        Using writer As New StreamWriter(filePath)
            writer.Write(ToHtml() & anhang)
        End Using
    End Sub





End Class


