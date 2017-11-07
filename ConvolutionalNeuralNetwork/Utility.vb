' *****************************************************************************
' ユーティリティクラス
' *****************************************************************************
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Utility
    ' rand オブジェクトの生成は一度きりにする
    Private Shared rand As Random = Nothing

    ' *************************************************************************
    ' -1 ～ 1 の実数値乱数
    Public Shared Function DRand() As Double
        If rand Is Nothing Then rand = New Random(Setting.SEED)
        Return rand.NextDouble() * 2 - 1
    End Function

    ' *****************************************************************************
    ' a ～ b の実数値乱数
    Public Shared Function DRand(ByVal a As Integer, ByVal b As Integer) As Double
        If rand Is Nothing Then rand = New Random(Setting.SEED)
        Return rand.NextDouble() * (b - a) + a
    End Function

    ' *************************************************************************
    ' クリップボードへグラフのコピー
    Public Shared Sub ToClipBoard(ByRef graph As Chart)
        Using memstr As MemoryStream = New MemoryStream()
            ' Stream へグラフのイメージを一時保存
            graph.SaveImage(memstr, ImageFormat.Bmp)
            Dim bmp As Bitmap = New Bitmap(memstr)
            Clipboard.SetDataObject(bmp)
        End Using
    End Sub
End Class
