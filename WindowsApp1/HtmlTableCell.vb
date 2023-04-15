Public Class HtmlTableCell
    Private _text As String

    Public Sub New(text As String)
        _text = text
    End Sub

    Public Function ToHtml() As String
        Return "<td>" & _text & "</td>"
    End Function
End Class
