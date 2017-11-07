' *****************************************************************************
' ファイル読み込みクラス
' *****************************************************************************
Imports System.IO

Public Class ReadData
    Private openDlg As OpenFileDialog
    Private inputs As Integer
    Private rows As Integer
    Private cols As Integer

    ' *************************************************************************
    ' コンストラクタ
    Public Sub New(ByRef openDlg As OpenFileDialog)
        Me.openDlg = openDlg
    End Sub

    ' *************************************************************************
    ' ファイルを読み込みデータの数をカウント
    ' Return : ファイル名 / Nothing（ファイルが読み込まれなかったとき）
    Private Function GetFileName() As String
        Static Dim readFirst As Boolean = True
        Dim fname As String = Nothing
        With openDlg
            .Filter = "txt ﾌｧｲﾙ(*.txt)|*.txt"
            If readFirst Then
                .FileName = vbNullChar
                readFirst = True
            End If
            If .ShowDialog() = DialogResult.OK Then
                fname = .FileName
                Using str As StreamReader = New StreamReader(fname)
                    Dim firstMatrix As Boolean = False
                    inputs = 0
                    rows = 0
                    cols = 0
                    ' ファイルの終端まで繰り返し
                    While Not str.EndOfStream
                        ' 一行読み込み
                        Dim line As String = str.ReadLine()
                        If line.Length = 0 Then

                        Else
                            ' 読み込んだ行の値の数、スペースで分割
                            Dim splitLen As Integer = Split(line).Length
                            If splitLen = 1 Then
                                inputs += 1     ' 入力数は教師データで判断
                                firstMatrix = rows > 0 AndAlso cols > 0
                            Else
                                ' 入力データ１つ目の時のみ行数、列数のカウント
                                If Not firstMatrix Then
                                    ' 教師データ１つ目と２つ目の間の行数、列数
                                    If inputs = 1 Then
                                        rows += 1
                                        cols = splitLen
                                    End If
                                End If
                            End If
                        End If
                    End While
                End Using
            End If
            Return fname
        End With
    End Function

    ' *************************************************************************
    ' 読み込みデータを反映（参照渡し）
    ' Return : True / False（処理の完了 / 失敗）
    Public Function GetData(ByRef data(,,) As Double, ByRef t() As Double) _
    As Boolean
        Dim index As Integer = 0
        Dim _matrix As Boolean = False
        Dim _teacher As Boolean = False
        Dim fname As String = GetFileName()

        If fname Is Nothing Then
            Return False
        End If

        data = New Double(inputs - 1, rows - 1, cols - 1) {}
        t = New Double(inputs - 1) {}

        Using str As StreamReader = New StreamReader(fname)
            While Not str.EndOfStream
                Dim line As String = str.ReadLine()
                If line.Length = 0 Then

                Else
                    Dim splits() As String = Split(line)
                    If splits.Length = 1 Then
                        t(index) = Double.Parse(splits(0))
                        _teacher = True
                    Else
                        For i As Integer = 0 To data.GetUpperBound(1)
                            For j As Integer = 0 To data.GetUpperBound(2)
                                data(index, i, j) = Double.Parse(splits(j))
                            Next j

                            If i < data.GetUpperBound(1) Then
                                line = str.ReadLine()
                                splits = Split(line)
                            End If
                        Next i
                        _matrix = True
                    End If
                    ' 教師データと入力データが交互に並んでいれば
                    ' 入力できるようにするため
                    If _teacher AndAlso _matrix Then
                        index += 1
                        _teacher = False
                        _matrix = False
                    End If
                End If
            End While
        End Using

        Return True
    End Function
End Class
