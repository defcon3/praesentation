﻿
Imports System.IO

Public Class HtmlTable

    Private _rows As New List(Of HtmlTableRow)
    Private _breitenstring As String
    Private _nummer As Integer
    Public anhang As String = ""
    Private farbe As String

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
                tableHtml.Append("<table border=""0"" style=""background-color: blue; width: 100%; color: white;"" font=""Arial, sans-serif"" size=""14"" color=""red"">")
            Case 2, 5, 14
                'farbe = ColorTranslator.ToHtml(Color.Brown)
                'tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: " & ColorTranslator.ToHtml(Color.Brown) & ";"" font=""Arial, sans-serif"" size=""26"">")
                tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: " & ColorTranslator.ToHtml(Color.Yellow) & ";>")
            Case 3, 4
                tableHtml.Append("<table border=""0"" style=""background-color: white; width: 100%;"">")
                'Case 4
                'tableHtml.Append("<table border=""0"" style=""background-color: white; width: 100%;"">")
                'Case 5
                'tableHtml.Append("<table border=""1"" style=""background-color: white; width: 100%; color: gray;"">")
            Case 6
                tableHtml.Append("<table border=""0"" style=""background-color: white; width: 100%; color: black;"">")
            Case 7, 8, 9, 11, 13, 15, 17
                tableHtml.Append("<table border=""0"" style=""background-color: white; width: 100%; color: black;"">")
            Case 10
                tableHtml.Append("<table border=""0"" align=""center"" style=""background-color: white; width: 100%; color: black;"">")
            Case 12
                tableHtml.Append("<table border=""0"" align=""left"" style=""background-color: white; width: 80%; color: black;"">")
            Case 99
                tableHtml.Append("<table border=""0"" style=""background-color: white; width: 100%; color: gray;"">")
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


