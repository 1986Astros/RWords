<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Console
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbPuzzles = New System.Windows.Forms.ListBox()
        Me.lblPuzzle = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.cbNewWindow = New System.Windows.Forms.CheckBox()
        Me.cbFile = New System.Windows.Forms.CheckBox()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPuzzles = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpInputOutput = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpOutputFile = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDictionaries = New System.Windows.Forms.Label()
        Me.cbTWL06 = New System.Windows.Forms.CheckBox()
        Me.cbSOWPODS = New System.Windows.Forms.CheckBox()
        Me.cbOther = New System.Windows.Forms.CheckBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.tlpProgress = New System.Windows.Forms.TableLayoutPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.tlpMain.SuspendLayout()
        Me.tlpPuzzles.SuspendLayout()
        Me.tlpInputOutput.SuspendLayout()
        Me.tlpOutputFile.SuspendLayout()
        Me.tlpProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPuzzles
        '
        Me.lbPuzzles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPuzzles.FormattingEnabled = True
        Me.lbPuzzles.Location = New System.Drawing.Point(3, 16)
        Me.lbPuzzles.Name = "lbPuzzles"
        Me.lbPuzzles.Size = New System.Drawing.Size(497, 192)
        Me.lbPuzzles.TabIndex = 1
        '
        'lblPuzzle
        '
        Me.lblPuzzle.AutoSize = True
        Me.lblPuzzle.Location = New System.Drawing.Point(3, 0)
        Me.lblPuzzle.Name = "lblPuzzle"
        Me.lblPuzzle.Size = New System.Drawing.Size(38, 13)
        Me.lblPuzzle.TabIndex = 0
        Me.lblPuzzle.Text = "Puzzle"
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(3, 85)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Output"
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.Location = New System.Drawing.Point(3, 101)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(64, 17)
        Me.cbDebug.TabIndex = 5
        Me.cbDebug.Text = "DEBUG"
        Me.cbDebug.UseVisualStyleBackColor = True
        '
        'cbNewWindow
        '
        Me.cbNewWindow.AutoSize = True
        Me.cbNewWindow.Checked = True
        Me.cbNewWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNewWindow.Location = New System.Drawing.Point(3, 124)
        Me.cbNewWindow.Name = "cbNewWindow"
        Me.cbNewWindow.Size = New System.Drawing.Size(87, 17)
        Me.cbNewWindow.TabIndex = 6
        Me.cbNewWindow.Text = "New window"
        Me.cbNewWindow.UseVisualStyleBackColor = True
        '
        'cbFile
        '
        Me.cbFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbFile.AutoSize = True
        Me.cbFile.Location = New System.Drawing.Point(3, 4)
        Me.cbFile.Name = "cbFile"
        Me.cbFile.Size = New System.Drawing.Size(45, 17)
        Me.cbFile.TabIndex = 7
        Me.cbFile.Text = "File:"
        Me.cbFile.UseVisualStyleBackColor = True
        '
        'tbFileName
        '
        Me.tbFileName.Location = New System.Drawing.Point(54, 3)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(135, 20)
        Me.tbFileName.TabIndex = 8
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.tlpPuzzles, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpInputOutput, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(707, 217)
        Me.tlpMain.TabIndex = 7
        '
        'tlpPuzzles
        '
        Me.tlpPuzzles.ColumnCount = 1
        Me.tlpPuzzles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPuzzles.Controls.Add(Me.lblPuzzle, 0, 0)
        Me.tlpPuzzles.Controls.Add(Me.lbPuzzles, 0, 1)
        Me.tlpPuzzles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPuzzles.Location = New System.Drawing.Point(3, 3)
        Me.tlpPuzzles.Name = "tlpPuzzles"
        Me.tlpPuzzles.RowCount = 2
        Me.tlpPuzzles.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPuzzles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPuzzles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPuzzles.Size = New System.Drawing.Size(503, 211)
        Me.tlpPuzzles.TabIndex = 0
        '
        'tlpInputOutput
        '
        Me.tlpInputOutput.AutoSize = True
        Me.tlpInputOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpInputOutput.ColumnCount = 1
        Me.tlpInputOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInputOutput.Controls.Add(Me.lblOutput, 0, 4)
        Me.tlpInputOutput.Controls.Add(Me.cbDebug, 0, 5)
        Me.tlpInputOutput.Controls.Add(Me.cbNewWindow, 0, 6)
        Me.tlpInputOutput.Controls.Add(Me.tlpOutputFile, 0, 7)
        Me.tlpInputOutput.Controls.Add(Me.lblDictionaries, 0, 0)
        Me.tlpInputOutput.Controls.Add(Me.cbTWL06, 0, 1)
        Me.tlpInputOutput.Controls.Add(Me.cbSOWPODS, 0, 2)
        Me.tlpInputOutput.Controls.Add(Me.cbOther, 0, 3)
        Me.tlpInputOutput.Controls.Add(Me.btnGenerate, 0, 8)
        Me.tlpInputOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInputOutput.Location = New System.Drawing.Point(512, 3)
        Me.tlpInputOutput.Name = "tlpInputOutput"
        Me.tlpInputOutput.RowCount = 9
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInputOutput.Size = New System.Drawing.Size(192, 211)
        Me.tlpInputOutput.TabIndex = 1
        '
        'tlpOutputFile
        '
        Me.tlpOutputFile.AutoSize = True
        Me.tlpOutputFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpOutputFile.ColumnCount = 2
        Me.tlpOutputFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpOutputFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpOutputFile.Controls.Add(Me.cbFile, 0, 0)
        Me.tlpOutputFile.Controls.Add(Me.tbFileName, 1, 0)
        Me.tlpOutputFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOutputFile.Location = New System.Drawing.Point(0, 144)
        Me.tlpOutputFile.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpOutputFile.Name = "tlpOutputFile"
        Me.tlpOutputFile.RowCount = 1
        Me.tlpOutputFile.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOutputFile.Size = New System.Drawing.Size(192, 26)
        Me.tlpOutputFile.TabIndex = 5
        '
        'lblDictionaries
        '
        Me.lblDictionaries.AutoSize = True
        Me.lblDictionaries.Location = New System.Drawing.Point(3, 0)
        Me.lblDictionaries.Name = "lblDictionaries"
        Me.lblDictionaries.Size = New System.Drawing.Size(62, 13)
        Me.lblDictionaries.TabIndex = 0
        Me.lblDictionaries.Text = "Dictionaries"
        '
        'cbTWL06
        '
        Me.cbTWL06.AutoSize = True
        Me.cbTWL06.Checked = True
        Me.cbTWL06.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTWL06.Location = New System.Drawing.Point(3, 16)
        Me.cbTWL06.Name = "cbTWL06"
        Me.cbTWL06.Size = New System.Drawing.Size(62, 17)
        Me.cbTWL06.TabIndex = 1
        Me.cbTWL06.Text = "TWL06"
        Me.cbTWL06.UseVisualStyleBackColor = True
        '
        'cbSOWPODS
        '
        Me.cbSOWPODS.AutoSize = True
        Me.cbSOWPODS.Location = New System.Drawing.Point(3, 39)
        Me.cbSOWPODS.Name = "cbSOWPODS"
        Me.cbSOWPODS.Size = New System.Drawing.Size(82, 17)
        Me.cbSOWPODS.TabIndex = 2
        Me.cbSOWPODS.Text = "SOWPODS"
        Me.cbSOWPODS.UseVisualStyleBackColor = True
        '
        'cbOther
        '
        Me.cbOther.AutoSize = True
        Me.cbOther.Location = New System.Drawing.Point(3, 62)
        Me.cbOther.Name = "cbOther"
        Me.cbOther.Size = New System.Drawing.Size(50, 17)
        Me.cbOther.TabIndex = 3
        Me.cbOther.Text = "other"
        Me.cbOther.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Location = New System.Drawing.Point(128, 185)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(61, 23)
        Me.btnGenerate.TabIndex = 9
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'tlpProgress
        '
        Me.tlpProgress.AutoSize = True
        Me.tlpProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpProgress.ColumnCount = 3
        Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProgress.Controls.Add(Me.ProgressBar1, 0, 0)
        Me.tlpProgress.Controls.Add(Me.ProgressBar2, 1, 0)
        Me.tlpProgress.Controls.Add(Me.ProgressBar3, 2, 0)
        Me.tlpProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpProgress.Location = New System.Drawing.Point(0, 217)
        Me.tlpProgress.Name = "tlpProgress"
        Me.tlpProgress.RowCount = 1
        Me.tlpProgress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProgress.Size = New System.Drawing.Size(707, 29)
        Me.tlpProgress.TabIndex = 8
        Me.tlpProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(229, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar2.Location = New System.Drawing.Point(238, 3)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(229, 23)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 1
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar3.Location = New System.Drawing.Point(473, 3)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(231, 23)
        Me.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar3.TabIndex = 2
        '
        'Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 246)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.tlpProgress)
        Me.Name = "Console"
        Me.Text = "r/Words"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpPuzzles.ResumeLayout(False)
        Me.tlpPuzzles.PerformLayout()
        Me.tlpInputOutput.ResumeLayout(False)
        Me.tlpInputOutput.PerformLayout()
        Me.tlpOutputFile.ResumeLayout(False)
        Me.tlpOutputFile.PerformLayout()
        Me.tlpProgress.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPuzzles As ListBox
    Friend WithEvents lblPuzzle As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents cbDebug As CheckBox
    Friend WithEvents cbNewWindow As CheckBox
    Friend WithEvents cbFile As CheckBox
    Friend WithEvents tbFileName As TextBox
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpPuzzles As TableLayoutPanel
    Friend WithEvents tlpInputOutput As TableLayoutPanel
    Friend WithEvents tlpOutputFile As TableLayoutPanel
    Friend WithEvents lblDictionaries As Label
    Friend WithEvents cbTWL06 As CheckBox
    Friend WithEvents cbSOWPODS As CheckBox
    Friend WithEvents cbOther As CheckBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents tlpProgress As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
End Class
