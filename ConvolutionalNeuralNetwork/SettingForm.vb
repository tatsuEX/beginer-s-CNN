' *****************************************************************************
' 設定変更フォーム
' *****************************************************************************
Public Class SettingForm
    Private validMessage As String = ""

    ' *************************************************************************
    Private Sub SettingForm_Load(sender As Object, e As EventArgs) _
    Handles MyBase.Load
        TextSeed.Text = Setting.SEED.ToString()
        TextErrorLimit.Text = Setting.ERROR_LIMIT.ToString()
        TextHiddenNum.Text = Setting.HIDDEN_NO.ToString()
        TextAlpha.Text = Setting.ALPHA.ToString()
        TextMaxCalculation.Text = Setting.MAX_CALCULATION.ToString()
    End Sub

    ' *************************************************************************
    ' バリデーションチェック
    ' validMessage : 数値変換に失敗した項目
    ' Return isSuccess : True - 成功 / False - 失敗
    Private Function CheckValidation() As Boolean
        Dim isSuccess As Boolean = True
        Dim tmpi As Integer
        Dim tmpd As Double
        If Integer.TryParse(TextSeed.Text, tmpi) Then
            Setting.SEED = tmpi
        Else
            validMessage += "乱数シード" + vbCrLf
            isSuccess = False
        End If
        If Double.TryParse(TextErrorLimit.Text, tmpd) Then
            Setting.ERROR_LIMIT = tmpd
        Else
            validMessage += "誤差上限" + vbCrLf
            isSuccess = False
        End If
        If Integer.TryParse(TextHiddenNum.Text, tmpi) Then
            Setting.HIDDEN_NO = tmpi
        Else
            validMessage += "中間層のニューロン" + vbCrLf
            isSuccess = False
        End If
        If Double.TryParse(TextAlpha.Text, tmpd) Then
            Setting.ALPHA = tmpd
        Else
            validMessage += "学習係数" + vbCrLf
            isSuccess = False
        End If
        If Integer.TryParse(TextMaxCalculation.Text, tmpi) Then
            Setting.MAX_CALCULATION = tmpi
        Else
            validMessage += "最大計算回数" + vbCrLf
            isSuccess = False
        End If
        Return isSuccess
    End Function

#Region "Button"
    ' *************************************************************************
    ' 「確定」
    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) _
    Handles ButtonConfirm.Click
        If Not CheckValidation() Then
            MessageBox.Show(validMessage + vbCrLf +
                            "の項目は入力値が不正のため更新されませんでした。",
                            "警告", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End If

        Me.Close()
    End Sub

    ' *************************************************************************
    ' 「キャンセル」
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) _
    Handles ButtonCancel.Click
        Me.Close()
    End Sub
#End Region
End Class