' *****************************************************************************
' メインフォーム
' *****************************************************************************
Public Class MainForm
    Private timeCount As Integer

    ' *************************************************************************
    Private Sub MainForm_Load(sender As Object, e As EventArgs) _
    Handles MyBase.Load
        StatusLabelElapsed.Text =
            String.Format("{0, 8}  {1, 2:00} : {2, 2:00}", "Elapsed",
                          0, 0)
    End Sub

    ' *************************************************************************
    ' 経過時間の表示
    Private Sub Timer_Tick(sender As Object, e As EventArgs) _
    Handles Timer.Tick
        StatusLabelElapsed.Text =
            String.Format("{0, 8}  {1, 2:00} : {2, 2:00}", "Elapsed",
                          timeCount \ 60, timeCount Mod 60)
        timeCount += 1
    End Sub

#Region "Button"
    ' *************************************************************************
    ' 「開始」
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) _
    Handles ButtonStart.Click
        timeCount = 0
        Timer.Start()
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
