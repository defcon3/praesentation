Public Class HtmlTableCell
    Private _text As String
    Private hintergrundfarbe As Color = Color.White
    Private vordergrundfarbe As Color = Color.Black

    Public Sub New(text As String, Optional ByVal hf As Color? = Nothing, Optional ByVal vf As Color? = Nothing)
        If hf IsNot Nothing Then hintergrundfarbe = hf
        If vf IsNot Nothing Then vordergrundfarbe = vf




        _text = "<font color=""" & ColorTranslator.ToHtml(vordergrundfarbe) & """>" & text & "</font>"
    End Sub



    Public Function ToHtml() As String

        If hintergrundfarbe = Color.MistyRose Then
            Return "<td align=""center""" & ColorTranslator.ToHtml(hintergrundfarbe) & """>" & _text & "</td>"
        End If


        Return "<td bgcolor=""" & ColorTranslator.ToHtml(hintergrundfarbe) & """>" & _text & "</td>"
    End Function
End Class
