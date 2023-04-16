Public Class HtmlTableRowHeaderCell
    Private _text As String
    Private b As Integer = 55

    Public Sub New(text As String, breite As Integer)
        _text = text

    End Sub

    Public Function ToHtml() As String
        Return "<th width=""" & b & """></th>"
    End Function


End Class
