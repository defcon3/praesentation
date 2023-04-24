Public Class HtmlTableCell
    Private _text As String
    Private hintergrundfarbe As Color = Color.White
    Private vordergrundfarbe As Color = Color.Black
    Private _hAusrichtung As String
    Private _rahmen As String

    Public Sub New(text As String, Optional ByVal hf As Color? = Nothing, Optional ByVal vf As Color? = Nothing, Optional ByVal hAusrichtung As String = "left", Optional rahmen As Boolean = False)
        If hf IsNot Nothing Then hintergrundfarbe = hf
        If vf IsNot Nothing Then vordergrundfarbe = vf

        _hAusrichtung = hAusrichtung


        _rahmen = " style=""border: 1px solid black;"""

        If rahmen Then
            _hAusrichtung = _hAusrichtung & _rahmen
        End If

        _text = "<font color=""" & ColorTranslator.ToHtml(vordergrundfarbe) & """>" & text & "</font>"
    End Sub



    Public Function ToHtml() As String

        Return "<td bgcolor=""" & ColorTranslator.ToHtml(hintergrundfarbe) & """ align=""" & _hAusrichtung & """>" & _text & "</td>"

    End Function
End Class
