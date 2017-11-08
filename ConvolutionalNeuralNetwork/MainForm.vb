' *****************************************************************************
' メインフォーム
' *****************************************************************************
Public Class MainForm
    Private timeCount As Integer
    Private input(,,) As Double
    Private teacher() As Double
    Private cnn As ConvolutionalNeuralNetwork

    ' *************************************************************************
    Private Sub MainForm_Load(sender As Object, e As EventArgs) _
    Handles MyBase.Load
        TextCalcCount.Text = 0
        ChangeEnabled(False, False)
    End Sub

    ' *************************************************************************
    ' コントロールの Enabled 変更
    ' btnEnabled  : 開始ボタン
    ' menuEnabled : CNN 学習後有効になるメニュー項目
    Private Sub ChangeEnabled(btnEnabled As Boolean, menuEnabled As Boolean)
        ButtonStart.Enabled = btnEnabled
        MenuToClipboard.Enabled = menuEnabled
    End Sub

#Region "Button"
    ' *************************************************************************
    ' 「開始」
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) _
    Handles ButtonStart.Click
        timeCount = 0
        cnn = New ConvolutionalNeuralNetwork(input, teacher)

        Dim err() As Double

        err = cnn.DeepLearning()
        TextCalcCount.Text = err.Length()
        Dim lineChart As New DrawChart(ChartLine, err)
        lineChart.DrawLineChart()

        ChangeEnabled(False, True)
    End Sub

    ' *************************************************************************
    ' 「設定変更」
    Private Sub ButtonSetting_Click(sender As Object, e As EventArgs) _
    Handles ButtonSetting.Click
        Dim settingFrm As New SettingForm
        With settingFrm
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .MinimizeBox = False
            .MaximizeBox = False
            .ShowDialog(Me)
        End With
    End Sub
#End Region

#Region "Menu"
    ' *************************************************************************
    ' 「ファイル読み込み」
    Private Sub MenuFileRead_Click(sender As Object, e As EventArgs) _
    Handles MenuFileRead.Click
        Dim read As New ReadData(OpenFileDialog1)
        If read.GetData(input, teacher) Then
            ChangeEnabled(True, False)
            TextCalcCount.Text = 0
            ActiveControl = ButtonStart
        End If
    End Sub

    ' *************************************************************************
    ' 「ｸﾘｯﾌﾟﾎﾞｰﾄﾞ転送」
    Private Sub MenuToClipboard_Click(sender As Object, e As EventArgs) _
    Handles MenuToClipboard.Click
        Utility.ToClipBoard(ChartLine)
    End Sub

    ' *************************************************************************
    ' 「終了」
    Private Sub MenuQuit_Click(sender As Object, e As EventArgs) _
    Handles MenuQuit.Click
        Me.Dispose()
        Environment.Exit(0)
    End Sub
#End Region
End Class
