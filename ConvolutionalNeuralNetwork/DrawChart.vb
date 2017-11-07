' *****************************************************************************
' グラフ描画用クラス
' *****************************************************************************
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DrawChart
    Private graph As Chart
    Private vector() As Double

    ' *************************************************************************
    ' コンストラクタ
    Public Sub New(ByRef graph As Chart, ByRef vector() As Double)
        Me.graph = graph
        Me.vector = vector
    End Sub

    ' *************************************************************************
    ' 折れ線グラフ描画
    Public Sub DrawLineChart()
        With graph
            Dim dataName As String = "誤差"
            .Series.Clear()
            .Legends.Clear()
            .Series.Add(dataName)
            .Series(dataName).ChartType = SeriesChartType.Line
            With .ChartAreas(0).AxisX
                .Minimum = 1
                .Title = "学習の繰り返し回数"
                .MajorGrid.Enabled = False
                .LabelStyle.Interval = 5
            End With
            .ChartAreas(0).AxisY.Title = dataName
            For i As Integer = 0 To vector.GetUpperBound(0)
                .Series(dataName).Points.AddXY(i, vector(i))
            Next
        End With
    End Sub
End Class
