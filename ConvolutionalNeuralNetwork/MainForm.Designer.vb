<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFileRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonSetting = New System.Windows.Forms.Button()
        Me.ChartLine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextCalcCount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ChartLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(882, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileRead, Me.MenuToClipboard, Me.MenuQuit})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'MenuFileRead
        '
        Me.MenuFileRead.Name = "MenuFileRead"
        Me.MenuFileRead.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuFileRead.Size = New System.Drawing.Size(226, 26)
        Me.MenuFileRead.Text = "ファイル読込(&R)"
        '
        'MenuToClipboard
        '
        Me.MenuToClipboard.Name = "MenuToClipboard"
        Me.MenuToClipboard.Size = New System.Drawing.Size(226, 26)
        Me.MenuToClipboard.Text = "ｸﾘｯﾌﾟﾎﾞｰﾄﾞ転送(&C)"
        '
        'MenuQuit
        '
        Me.MenuQuit.Name = "MenuQuit"
        Me.MenuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MenuQuit.Size = New System.Drawing.Size(226, 26)
        Me.MenuQuit.Text = "終了(&X)"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(16, 40)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(104, 32)
        Me.ButtonStart.TabIndex = 1
        Me.ButtonStart.Text = "開始"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonSetting
        '
        Me.ButtonSetting.Location = New System.Drawing.Point(144, 40)
        Me.ButtonSetting.Name = "ButtonSetting"
        Me.ButtonSetting.Size = New System.Drawing.Size(104, 32)
        Me.ButtonSetting.TabIndex = 2
        Me.ButtonSetting.Text = "設定変更"
        Me.ButtonSetting.UseVisualStyleBackColor = True
        '
        'ChartLine
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartLine.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.ChartLine.Legends.Add(Legend3)
        Me.ChartLine.Location = New System.Drawing.Point(16, 80)
        Me.ChartLine.Name = "ChartLine"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.ChartLine.Series.Add(Series3)
        Me.ChartLine.Size = New System.Drawing.Size(850, 480)
        Me.ChartLine.TabIndex = 3
        Me.ChartLine.Text = "Chart1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextCalcCount
        '
        Me.TextCalcCount.BackColor = System.Drawing.Color.White
        Me.TextCalcCount.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextCalcCount.Location = New System.Drawing.Point(728, 40)
        Me.TextCalcCount.Name = "TextCalcCount"
        Me.TextCalcCount.ReadOnly = True
        Me.TextCalcCount.Size = New System.Drawing.Size(100, 27)
        Me.TextCalcCount.TabIndex = 5
        Me.TextCalcCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(624, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "計算回数"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(840, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "回"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 603)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextCalcCount)
        Me.Controls.Add(Me.ChartLine)
        Me.Controls.Add(Me.ButtonSetting)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "ConvolutionaNeuralNetwork"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ChartLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuFileRead As ToolStripMenuItem
    Friend WithEvents MenuQuit As ToolStripMenuItem
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonSetting As Button
    Friend WithEvents ChartLine As DataVisualization.Charting.Chart
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuToClipboard As ToolStripMenuItem
    Friend WithEvents TextCalcCount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
