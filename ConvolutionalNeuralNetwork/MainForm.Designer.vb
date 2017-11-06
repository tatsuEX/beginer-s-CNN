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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFileRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonSetting = New System.Windows.Forms.Button()
        Me.ChartLine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelElapsed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        CType(Me.ChartLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(782, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileRead, Me.MenuQuit})
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
        ChartArea8.Name = "ChartArea1"
        Me.ChartLine.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.ChartLine.Legends.Add(Legend8)
        Me.ChartLine.Location = New System.Drawing.Point(16, 80)
        Me.ChartLine.Name = "ChartLine"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Me.ChartLine.Series.Add(Series8)
        Me.ChartLine.Size = New System.Drawing.Size(752, 376)
        Me.ChartLine.TabIndex = 3
        Me.ChartLine.Text = "Chart1"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabelElapsed})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(782, 25)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabelElapsed
        '
        Me.StatusLabelElapsed.Name = "StatusLabelElapsed"
        Me.StatusLabelElapsed.Size = New System.Drawing.Size(152, 20)
        Me.StatusLabelElapsed.Text = "ToolStripStatusLabel1"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.StatusStrip)
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
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
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
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusLabelElapsed As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Timer As Timer
End Class
