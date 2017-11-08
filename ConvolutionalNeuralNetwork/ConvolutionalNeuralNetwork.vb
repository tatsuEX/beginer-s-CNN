' *****************************************************************************
' 畳み込みニューラルネットワーククラス
' *****************************************************************************
Public Class ConvolutionalNeuralNetwork
    ' 記号定数の定義
    Private Const INPUTSIZE As Integer = 11
    Private Const FILTERSIZE As Integer = 3
    Private Const FILTERNO As Integer = 2
    Private Const POOLSIZE As Integer = 3
    Private Const POOLOUTSIZE As Integer = 3

    Private input(,,) As Double
    Private teacher() As Double
    Private filter(,,) As Double
    Private convOut(,) As Double
    Private poolOut(,) As Double
    Private inputFcl() As Double
    Private hiddenOutput() As Double
    Private hiddenWeight(,) As Double
    Private outputWeight() As Double
    Private output As Double

    Private isSigmoid As Boolean = True

    ' *************************************************************************
    ' 畳み込み層のフィルタ初期化
    Private Sub InitFilter()
        filter = New Double(FILTERNO - 1, FILTERSIZE - 1, FILTERSIZE - 1) {}
        For i As Integer = 0 To filter.GetUpperBound(0)
            For j As Integer = 0 To filter.GetUpperBound(1)
                For k As Integer = 0 To filter.GetUpperBound(2)
                    filter(i, j, k) = Utility.DRand()
                Next k
            Next j
        Next i
    End Sub

    ' *************************************************************************
    ' 中間層の重みと閾値の初期化
    Private Sub InitHiddenWeight()
        Dim hnum As Integer = Setting.HIDDEN_NO
        ' 閾値の分要素が一つ多い
        Dim hw As Integer = POOLOUTSIZE * POOLOUTSIZE * FILTERNO + 1
        hiddenWeight = New Double(hnum - 1, hw - 1) {}
        For i As Integer = 0 To hiddenWeight.GetUpperBound(0)
            For j As Integer = 0 To hiddenWeight.GetUpperBound(1)
                hiddenWeight(i, j) = Utility.DRand()
            Next j
        Next i
    End Sub

    ' *************************************************************************
    ' 出力層の重みと閾値の初期化
    Private Sub InitOutputWeight()
        ' 閾値の分要素が一つ多い
        outputWeight = New Double(Setting.HIDDEN_NO) {}
        For i As Integer = 0 To outputWeight.GetUpperBound(0)
            outputWeight(i) = Utility.DRand()
        Next i
    End Sub

    ' *************************************************************************
    ' コンストラクタ
    Public Sub New(ByRef input(,,) As Double, ByRef t() As Double)
        Me.input = input
        Me.teacher = t

        InitFilter()
        convOut = New Double(INPUTSIZE - 1, INPUTSIZE - 1) {}
        poolOut = New Double(POOLOUTSIZE - 1, POOLOUTSIZE - 1) {}
        inputFcl = New Double(POOLOUTSIZE * POOLOUTSIZE * FILTERNO) {}
        hiddenOutput = New Double(Setting.HIDDEN_NO - 1) {}
        InitHiddenWeight()
        InitOutputWeight()
    End Sub

#Region "Shared"
    ' *************************************************************************
    ' ステップ関数（今回は使用しない）
    Private Shared Function FStep(ByVal o As Double) As Double
        Return IIf(o >= 0, 1.0, 0.0)
    End Function

    ' *************************************************************************
    ' シグモイド関数
    Private Shared Function FSigmoid(ByVal o As Double) As Double
        Return 1.0 / (1.0 + Math.Exp(-o))
    End Function

    ' *************************************************************************
    ' 活性化関数
    Private Shared Function F(ByVal o As Double,
                              Optional isSigmoid As Boolean = True) As Double
        Return IIf(isSigmoid, FSigmoid(o), FStep(o))
    End Function
#End Region

    ' *************************************************************************
    ' フィルタの適用
    Private Function CalcConv(inId As Integer, filId As Integer,
                              m As Integer, n As Integer) As Double
        Dim sum As Double = 0
        Dim half As Integer = FILTERSIZE \ 2
        For i As Integer = 0 To FILTERSIZE - 1
            For j As Integer = 0 To FILTERSIZE - 1
                sum += input(inId, m - half + i, n - half + j) * filter(filId, i, j)
            Next j
        Next i
        Return sum
    End Function

    ' *************************************************************************
    ' 畳み込み計算
    Private Sub Convolution(inId As Integer, filId As Integer)
        Dim stpt As Integer = FILTERSIZE \ 2
        For i As Integer = stpt To INPUTSIZE - stpt - 1
            For j As Integer = stpt To INPUTSIZE - stpt - 1
                convOut(i, j) = CalcConv(inId, filId, i, j)
            Next j
        Next i
    End Sub

    ' *************************************************************************
    ' 最大値プーリング
    Private Function MaxPooling(m As Integer, n As Integer) As Double
        Dim half As Integer = POOLSIZE \ 2
        Dim iMax As Integer = POOLOUTSIZE * m + 1 + (POOLSIZE - half)
        Dim jMax As Integer = POOLOUTSIZE * n + 1 + (POOLSIZE - half)
        Dim max As Double =
            convOut(m * POOLOUTSIZE + 1 + half, n * POOLOUTSIZE + 1 + half)
        For i As Integer = POOLOUTSIZE * m + 1 To iMax
            For j As Integer = POOLOUTSIZE * n + 1 To jMax
                If max < convOut(i, j) Then max = convOut(i, j)
            Next j
        Next i
        Return max
    End Function

    ' *************************************************************************
    ' プーリングの計算
    Private Sub Pooling()
        For i As Integer = 0 To POOLOUTSIZE - 1
            For j As Integer = 0 To POOLOUTSIZE - 1
                poolOut(i, j) = MaxPooling(i, j)
            Next j
        Next i
    End Sub

    ' *************************************************************************
    ' 順方向の計算
    Private Function Forward() As Double
        Dim hOut, oOut As Double
        For i As Integer = 0 To hiddenWeight.GetUpperBound(0)
            hOut = 0
            For j As Integer = 0 To hiddenWeight.GetUpperBound(1) - 1
                hOut += inputFcl(j) * hiddenWeight(i, j)
            Next j
            hOut -=
                hiddenWeight(i, POOLOUTSIZE * POOLOUTSIZE * FILTERNO)
            hiddenOutput(i) = F(hOut)
        Next i
        oOut = 0
        For i As Integer = 0 To outputWeight.GetUpperBound(0) - 1
            oOut += hiddenOutput(i) * outputWeight(i)
        Next i
        oOut -= outputWeight(Setting.HIDDEN_NO)
        Return F(oOut)
    End Function

    ' *************************************************************************
    ' 出力層の重み学習
    Private Sub OutputLearn(ByVal t As Double)
        Dim d As Double = (t - output) * output * (1 - output)
        For i As Integer = 0 To Setting.HIDDEN_NO - 1
            outputWeight(i) += Setting.ALPHA * hiddenOutput(i) * d
        Next i
        outputWeight(Setting.HIDDEN_NO) += Setting.ALPHA * (-1.0) * d
    End Sub

    ' *************************************************************************
    ' 中間層の重み学習
    Private Sub HiddenLearn(ByVal t As Double)
        For i As Integer = 0 To Setting.HIDDEN_NO - 1
            Dim d As Double =
                hiddenOutput(i) * (1 - hiddenOutput(i)) * outputWeight(i) *
                (t - output) * output * (1 - output)
            For j As Integer = 0 To hiddenWeight.GetUpperBound(1) - 1
                hiddenWeight(i, j) += Setting.ALPHA * inputFcl(j) * d
            Next j
            hiddenWeight(i, POOLOUTSIZE * POOLOUTSIZE * FILTERNO) +=
                Setting.ALPHA * (-1.0) * d
        Next i
    End Sub

    ' *************************************************************************
    ' 入力・教師データからネットワーク全体を学習
    Public Function DeepLearning() As Double()
        Dim errors() As Double
        Dim err As Double
        Dim count As Integer = 0
        Do
            err = 0
            For i As Integer = 0 To input.GetUpperBound(0)
                For j As Integer = 0 To FILTERNO - 1
                    Convolution(i, j)
                    Pooling()
                    For m As Integer = 0 To POOLOUTSIZE - 1
                        For n As Integer = 0 To POOLOUTSIZE - 1
                            inputFcl(j * POOLOUTSIZE * POOLOUTSIZE +
                                     POOLOUTSIZE * m + n) _
                            = poolOut(m, n)
                        Next n
                    Next m
                Next j
                output = Forward()
                OutputLearn(teacher(i))
                HiddenLearn(teacher(i))
                err += (output - teacher(i)) * (output - teacher(i))
            Next i

            ReDim Preserve errors(count)
            errors(count) = err
            count += 1
        Loop While count < Setting.MAX_CALCULATION AndAlso
            err > Setting.ERROR_LIMIT
        Return errors
    End Function
End Class
