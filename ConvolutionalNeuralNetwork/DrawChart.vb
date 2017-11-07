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
            ' x軸の設定
            With .ChartAreas(0).AxisX
                .Minimum = 1                        ' 最小値
                .Title = "学習の繰り返し回数"       ' 軸ラベル
                .MajorGrid.Enabled = False          ' 縦線を非表示
                .LabelStyle.Interval = 5            ' 軸に表示する値の間隔
            End With
            ' y軸の設定
            .ChartAreas(0).AxisY.Title = dataName   ' 軸ラベル
            For i As Integer = 0 To vector.GetUpperBound(0)
                .Series(dataName).Points.AddXY(i, vector(i))
            Next
        End With
    End Sub
End Class
