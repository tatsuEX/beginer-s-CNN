Public Class MainForm
    Private timeCount As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLabelElapsed.Text =
            String.Format("{0, 8}  {1, 2:00} : {2, 2:00}", "Elapsed",
                          0, 0)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        StatusLabelElapsed.Text =
            String.Format("{0, 8}  {1, 2:00} : {2, 2:00}", "Elapsed",
                          timeCount \ 60, timeCount Mod 60)
        timeCount += 1
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        timeCount = 0
        Timer.Start()
    End Sub

    Private Sub ButtonSetting_Click(sender As Object, e As EventArgs) Handles ButtonSetting.Click
        Dim settingFrm As New SettingForm
        With settingFrm
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .MinimizeBox = False
            .MaximizeBox = False
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub MenuFileRead_Click(sender As Object, e As EventArgs) Handles MenuFileRead.Click

    End Sub

    Private Sub MenuQuit_Click(sender As Object, e As EventArgs) Handles MenuQuit.Click
        Me.Dispose()
        Environment.Exit(0)
    End Sub
End Class
