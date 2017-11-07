<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.TextMaxCalculation = New System.Windows.Forms.TextBox()
        Me.TextAlpha = New System.Windows.Forms.TextBox()
        Me.TextHiddenNum = New System.Windows.Forms.TextBox()
        Me.TextErrorLimit = New System.Windows.Forms.TextBox()
        Me.TextSeed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.TextMaxCalculation)
        Me.GroupBox.Controls.Add(Me.TextAlpha)
        Me.GroupBox.Controls.Add(Me.TextHiddenNum)
        Me.GroupBox.Controls.Add(Me.TextErrorLimit)
        Me.GroupBox.Controls.Add(Me.TextSeed)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(288, 272)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "設定"
        '
        'TextMaxCalculation
        '
        Me.TextMaxCalculation.Location = New System.Drawing.Point(168, 224)
        Me.TextMaxCalculation.Name = "TextMaxCalculation"
        Me.TextMaxCalculation.Size = New System.Drawing.Size(100, 22)
        Me.TextMaxCalculation.TabIndex = 9
        Me.TextMaxCalculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextAlpha
        '
        Me.TextAlpha.Location = New System.Drawing.Point(168, 176)
        Me.TextAlpha.Name = "TextAlpha"
        Me.TextAlpha.Size = New System.Drawing.Size(100, 22)
        Me.TextAlpha.TabIndex = 8
        Me.TextAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextHiddenNum
        '
        Me.TextHiddenNum.Location = New System.Drawing.Point(168, 128)
        Me.TextHiddenNum.Name = "TextHiddenNum"
        Me.TextHiddenNum.Size = New System.Drawing.Size(100, 22)
        Me.TextHiddenNum.TabIndex = 7
        Me.TextHiddenNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextErrorLimit
        '
        Me.TextErrorLimit.Location = New System.Drawing.Point(168, 80)
        Me.TextErrorLimit.Name = "TextErrorLimit"
        Me.TextErrorLimit.Size = New System.Drawing.Size(100, 22)
        Me.TextErrorLimit.TabIndex = 6
        Me.TextErrorLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextSeed
        '
        Me.TextSeed.Location = New System.Drawing.Point(168, 32)
        Me.TextSeed.Name = "TextSeed"
        Me.TextSeed.Size = New System.Drawing.Size(100, 22)
        Me.TextSeed.TabIndex = 5
        Me.TextSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "最大計算回数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "学習係数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "中間層のニューロン"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "誤差上限"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "乱数シード"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(328, 32)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(88, 31)
        Me.ButtonConfirm.TabIndex = 1
        Me.ButtonConfirm.Text = "確定"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(328, 88)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(88, 31)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 312)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "SettingForm"
        Me.Text = "各種設定変更"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents TextMaxCalculation As TextBox
    Friend WithEvents TextAlpha As TextBox
    Friend WithEvents TextHiddenNum As TextBox
    Friend WithEvents TextErrorLimit As TextBox
    Friend WithEvents TextSeed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonConfirm As Button
    Friend WithEvents ButtonCancel As Button
End Class
