Public Class clsTab4
    Inherits HtmlTable

    Private tab As HtmlTable
    Public nummer As Int16 = 1
    Public strecke As String = ""

    Public dreieck1, dreieck2, dreieck3, dreieck4 As Decimal



    Public Sub New(ByVal nr As Integer, Optional ByVal breiten As String = "")
        MyBase.New(nr, breiten)
        nummer = nr

    End Sub

    Public Overrides Function ToString() As String

        'tab = New HtmlTable(4, "<tr><th width=""60%"" align=""left"" bgcolor=""white"" color=""black"">asdf</th><th width=""40%"" align=""left"">vdxd</th></tr>")
        tab = New HtmlTable(4, "<tr><td width=""60%"" align=""left"" bgcolor=""white"" color=""black"">Einwohner im 3,0 EZB je km Streckenlänge:</td><td width=""40%"" align=""middle"" rowspan=""5"">" & formatGrafik(New DataTable) & "</td></tr>")

        Dim row1 As New HtmlTableRow()
        row1.AddCell(New HtmlTableCell("+ Strukturelle Bedeutung"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("+ Sonstige relevante Verkehrspotentiale"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("+ Überregionale Verbindungsfunktion"))
        tab.AddRow(row1)
        row1 = New HtmlTableRow
        row1.AddCell(New HtmlTableCell("= 'Geringes Verkehrspotential'"))
        tab.AddRow(row1)





        Return tab.ToHtml
    End Function

    Private Function formatGrafik(ByVal dt As DataTable) As String

        Dim k As New DataTable
        k.Columns.Add("wert1")
        k.Columns.Add("wert2")
        k.Columns.Add("wert3")
        k.Columns.Add("wert4")
        k.Columns.Add("wert5")
        Dim r As DataRow = k.NewRow
        r(0) = 568
        r(1) = 20
        r(2) = 40
        r(3) = 88
        r(4) = 29
        k.Rows.Add(r)

        dt = k


        Dim t As String
        t = "<svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" width=""320"" height=""240"" viewBox=""0 0 320 240"" xml:space=""preserve""><desc>Created with Fabric.js 3.6.6</desc>
<defs>
</defs>
<rect x=""0"" y=""0"" width=""320"" height=""240"" fill=""none"" stroke=""black"" stroke-width=""3""  />
<line x1=""160"" y1=""20"" x2=""160"" y2=""180"" style=""stroke: black; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""60"" y1=""20"" x2=""60"" y2=""200"" style=""stroke: black; stroke-width: 1; stroke-dasharray: 1 10; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""110"" y1=""20"" x2=""110"" y2=""200"" style=""stroke: black; stroke-width: 1; stroke-dasharray: 1 10; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""260"" y1=""20"" x2=""260"" y2=""200"" style=""stroke: black; stroke-width: 1; stroke-dasharray: 1 10; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""210"" y1=""20"" x2=""210"" y2=""200"" style=""stroke: black; stroke-width: 1; stroke-dasharray: 1 10; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""60"" y1=""30"" x2=""260"" y2=""30"" style=""stroke: grey; stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
		<text x=""10"" y=""10"" xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-24"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">a) 0</tspan></text>
<!--
<g transform=""matrix(1 0 0 1 203 189.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-24"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">a) 0</tspan></text>
</g>-->
<text text-anchor=""end""><tspan y=""30"" x=""55"">0</tspan></text>
<text text-anchor=""end""><tspan y=""30"" x=""305"">2000</tspan></text>
<line x1=""120"" y1=""80"" x2=""200"" y2=""80"" style=""stroke: grey; stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""120"" y1=""130"" x2=""200"" y2=""130"" style=""stroke: grey; stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<line x1=""120"" y1=""180"" x2=""200"" y2=""180"" style=""stroke: grey; stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" />
<text text-anchor=""end""><tspan y=""80"" x=""110"">nein</tspan></text>
<text text-anchor=""start""><tspan y=""80"" x=""210"">ja</tspan></text>
<text text-anchor=""end""><tspan y=""130"" x=""110"">gering</tspan></text>
<text text-anchor=""start""><tspan y=""130"" x=""210"">hoch</tspan></text>
<text text-anchor=""end""><tspan y=""180"" x=""110"">nein</tspan></text>
<text text-anchor=""start""><tspan y=""180"" x=""210"">hoch</tspan></text>
<text text-anchor=""middle""><tspan y=""230"" x=""60"">-2</tspan></text>
<text text-anchor=""middle""><tspan y=""230"" x=""110"">-1</tspan></text>
<text text-anchor=""middle""><tspan y=""230"" x=""160"">0</tspan></text>
<text text-anchor=""middle""><tspan y=""230"" x=""210"">1</tspan></text>
<text text-anchor=""middle""><tspan y=""230"" x=""260"">2</tspan></text>
<polygon points=""" & (translateValue(dt.Rows(0)("wert2"), 200, 2000) + 60).ToString & ",60 " & (translateValue(dt.Rows(0)("wert2"), 200, 2000) + 60 + 10).ToString & ",30 " & (translateValue(dt.Rows(0)("wert2"), 200, 2000) + 60 + 20).ToString & ",60"" fill=""#87CEFA"" stroke=""#00008B"" stroke-width=""1"" />
<polygon points=""" & (translateValue(dt.Rows(0)("wert3"), 200, 2000) + 60).ToString & ",110 " & (translateValue(dt.Rows(0)("wert3"), 200, 2000) + 60 + 10).ToString & ",30 " & (translateValue(dt.Rows(0)("wert3"), 200, 2000) + 60 + 20).ToString & ",110"" fill=""#87CEFA"" stroke=""#00008B"" stroke-width=""1"" />
<polygon points=""" & (translateValue(dt.Rows(0)("wert4"), 200, 2000) + 60).ToString & ",160 " & (translateValue(dt.Rows(0)("wert4"), 200, 2000) + 60 + 10).ToString & ",30 " & (translateValue(dt.Rows(0)("wert4"), 200, 2000) + 60 + 20).ToString & ",160"" fill=""#87CEFA"" stroke=""#00008B"" stroke-width=""1"" />
<rect x=""60"" y=""195"" width=""200"" height=""20"" fill=""url(#grad)"" />
<defs>
  <linearGradient id=""grad"" x1=""0%"" y1=""0%"" x2=""100%"" y2=""0%"">
    <stop offset=""0%"" style=""stop-color: lightcoral;"" />
    <stop offset=""100%"" style=""stop-color: lightgreen;"" />
  </linearGradient>
</defs>
<polygon points=""" & (translateValue(dt.Rows(0)("wert5"), 200, 2000) + 60).ToString & ",195 " & (translateValue(dt.Rows(0)("wert5"), 200, 2000) + 60 + 10).ToString & ",215 " & (translateValue(dt.Rows(0)("wert5"), 200, 2000) + 60 + 20).ToString & ",195"" fill=""#87CEFA"" stroke=""#00008B"" stroke-width=""1"" />
<polygon points=""" & (translateValue(dt.Rows(0)("wert1"), 200, 2000) + 60).ToString & ",10 " & (translateValue(dt.Rows(0)("wert1"), 200, 2000) + 60 + 10).ToString & ",30 " & (translateValue(dt.Rows(0)("wert1"), 200, 2000) + 60 + 20).ToString & ",10"" fill=""#87CEFA"" stroke=""#00008B"" stroke-width=""1"" />
<!--
<g transform=""matrix(1.79 0 0 0.28 301.25 342.14)""  >
<linearGradient id=""SVGID_166"" gradientUnits=""userSpaceOnUse"" gradientTransform=""matrix(1 0 0 1 -50 -50)""  x1=""0"" y1=""50"" x2=""100"" y2=""50"">
<stop offset=""0%"" style=""stop-color:rgba(255, 9, 0, 1);""/>
<stop offset=""100%"" style=""stop-color:rgba(54, 255, 0, 1);""/>
</linearGradient>
<polygon style=""stroke: rgb(0,0,0); stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: url(#SVGID_166); fill-rule: nonzero; opacity: 1;""  points=""-50,-50 -50,50 50,50 50,-50 "" />
</g>
<g transform=""matrix(-0.25 0 0 -0.25 279.61 191.72)""  >
<polygon style=""stroke: rgb(0,0,0); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(220,218,51); fill-rule: nonzero; opacity: 1;"" vector-effect=""non-scaling-stroke""  points=""0,-42.5 50,42.5 -50,42.5 "" />
</g>
<g transform=""matrix(1 0 0 1 288.01 204)""  >
<line style=""stroke: rgb(150,150,150); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1;"" vector-effect=""non-scaling-stroke""  x1=""-93.51203131148418"" y1=""0"" x2=""93.51203131148418"" y2=""0"" />
</g>
<g transform=""matrix(-0.25 0 0 -0.25 305.25 233.13)""  >
<polygon style=""stroke: rgb(0,0,0); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(46,221,242); fill-rule: nonzero; opacity: 1;""  points=""0,-42.5 50,42.5 -50,42.5 "" />
</g>
<g transform=""matrix(-0.25 0 0 -0.25 290.25 267.13)""  >
<polygon style=""stroke: rgb(0,0,0); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(201,18,211); fill-rule: nonzero; opacity: 1;""  points=""0,-42.5 50,42.5 -50,42.5 "" />
</g>
<g transform=""matrix(-0.25 0 0 -0.25 337.25 301.13)""  >
<polygon style=""stroke: rgb(0,0,0); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(244,160,19); fill-rule: nonzero; opacity: 1;""  points=""0,-42.5 50,42.5 -50,42.5 "" />
</g>
<g transform=""matrix(-0.35 0 0 -0.35 278.51 343.61)""  >
<polygon style=""stroke: rgb(0,0,0); stroke-width: 2; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,54,255); fill-rule: nonzero; opacity: 1;""  points=""0,-42.5 50,42.5 -50,42.5 "" />
</g>
<g transform=""matrix(1 0 0 1 216.22 373.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-16.22"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">h)-2</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 249.51 372.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-15.02"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">i)-1</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 296.51 368.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-15.02"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">j)0</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 348.17 374.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-17.67"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">k)+1</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 392.72 373.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-15.22"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">l)+2</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 239.33 225.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-25.33"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">c)nein</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 236.55 297.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-24.05"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">f)nein</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 250.96 265.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-34.46"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">d)gering</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 386.51 231.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-23.01"" y=""5.65"" style=""stroke-width: 1; font-family: 'Open Sans', sans-serif; font-size: 18px; font-style: normal; font-weight: normal; fill: rgb(0,0,0); "">d)ja</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 385.97 266.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-28.47"" y=""5.65"" >e)hoch</tspan></text>
</g>
<g transform=""matrix(1 0 0 1 390.81 298.67)"" style=""""  >
		<text xml:space=""preserve"" font-family=""'Open Sans', sans-serif"" font-size=""18"" font-style=""normal"" font-weight=""normal"" style=""stroke: none; stroke-width: 1; stroke-dasharray: none; stroke-linecap: butt; stroke-dashoffset: 0; stroke-linejoin: miter; stroke-miterlimit: 4; fill: rgb(0,0,0); fill-rule: nonzero; opacity: 1; white-space: pre;"" ><tspan x=""-28.31"" y=""5.65"" >g)hoch</tspan></text>
</g>-->
</svg>"


        Return t


    End Function

    Private Function translateValue(ByVal wert As Integer, ByVal achsenlaenge As Integer, ByVal maximalwert As Integer) As Integer

        Dim w As Integer = 1
        Dim a As Integer = 0
        Dim m As Integer = 1


        w = wert
        a = achsenlaenge
        m = maximalwert

        Return CInt(w / m * a)


    End Function

End Class
