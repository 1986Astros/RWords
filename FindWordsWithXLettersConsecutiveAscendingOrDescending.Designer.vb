<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindWordsWithXLettersConsecutiveAscendingOrDescending
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tllplDirection = New System.Windows.Forms.TableLayoutPanel()
        Me.rbDescending = New System.Windows.Forms.RadioButton()
        Me.rbAscending = New System.Windows.Forms.RadioButton()
        Me.tlpLengths = New System.Windows.Forms.TableLayoutPanel()
        Me.gbConsecutive = New System.Windows.Forms.GroupBox()
        Me.tlpMatches = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMinConseq = New System.Windows.Forms.Label()
        Me.nudMinConseq = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMaxConseq = New System.Windows.Forms.Label()
        Me.nudMaxConseq = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbWordSize = New System.Windows.Forms.GroupBox()
        Me.tlpWordSize = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMinLetters = New System.Windows.Forms.Label()
        Me.nudMinLetters = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMaxLetters = New System.Windows.Forms.Label()
        Me.nudMaxLetters = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tllplDirection.SuspendLayout()
        Me.tlpLengths.SuspendLayout()
        Me.gbConsecutive.SuspendLayout()
        Me.tlpMatches.SuspendLayout()
        CType(Me.nudMinConseq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxConseq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbWordSize.SuspendLayout()
        Me.tlpWordSize.SuspendLayout()
        CType(Me.nudMinLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpButtons.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tllplDirection
        '
        Me.tllplDirection.AutoSize = True
        Me.tllplDirection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tllplDirection.ColumnCount = 2
        Me.tllplDirection.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tllplDirection.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tllplDirection.Controls.Add(Me.rbDescending, 1, 0)
        Me.tllplDirection.Controls.Add(Me.rbAscending, 0, 0)
        Me.tllplDirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tllplDirection.Location = New System.Drawing.Point(3, 3)
        Me.tllplDirection.Name = "tllplDirection"
        Me.tllplDirection.RowCount = 2
        Me.tllplDirection.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tllplDirection.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tllplDirection.Size = New System.Drawing.Size(270, 23)
        Me.tllplDirection.TabIndex = 5
        '
        'rbDescending
        '
        Me.rbDescending.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDescending.AutoSize = True
        Me.rbDescending.Location = New System.Drawing.Point(185, 3)
        Me.rbDescending.Name = "rbDescending"
        Me.rbDescending.Size = New System.Drawing.Size(82, 17)
        Me.rbDescending.TabIndex = 2
        Me.rbDescending.Text = "Descending"
        Me.rbDescending.UseVisualStyleBackColor = True
        '
        'rbAscending
        '
        Me.rbAscending.AutoSize = True
        Me.rbAscending.Checked = True
        Me.rbAscending.Location = New System.Drawing.Point(3, 3)
        Me.rbAscending.Name = "rbAscending"
        Me.rbAscending.Size = New System.Drawing.Size(75, 17)
        Me.rbAscending.TabIndex = 0
        Me.rbAscending.TabStop = True
        Me.rbAscending.Text = "Ascending"
        Me.rbAscending.UseVisualStyleBackColor = True
        '
        'tlpLengths
        '
        Me.tlpLengths.AutoSize = True
        Me.tlpLengths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpLengths.ColumnCount = 2
        Me.tlpLengths.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLengths.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLengths.Controls.Add(Me.gbConsecutive, 1, 0)
        Me.tlpLengths.Controls.Add(Me.gbWordSize, 0, 0)
        Me.tlpLengths.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLengths.Location = New System.Drawing.Point(3, 32)
        Me.tlpLengths.Name = "tlpLengths"
        Me.tlpLengths.RowCount = 1
        Me.tlpLengths.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLengths.Size = New System.Drawing.Size(270, 89)
        Me.tlpLengths.TabIndex = 4
        '
        'gbConsecutive
        '
        Me.gbConsecutive.AutoSize = True
        Me.gbConsecutive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbConsecutive.Controls.Add(Me.tlpMatches)
        Me.gbConsecutive.Location = New System.Drawing.Point(138, 15)
        Me.gbConsecutive.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.gbConsecutive.Name = "gbConsecutive"
        Me.gbConsecutive.Size = New System.Drawing.Size(129, 71)
        Me.gbConsecutive.TabIndex = 3
        Me.gbConsecutive.TabStop = False
        Me.gbConsecutive.Text = "Consecutive"
        '
        'tlpMatches
        '
        Me.tlpMatches.AutoSize = True
        Me.tlpMatches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMatches.ColumnCount = 3
        Me.tlpMatches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMatches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMatches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMatches.Controls.Add(Me.lblMinConseq, 0, 0)
        Me.tlpMatches.Controls.Add(Me.nudMinConseq, 1, 0)
        Me.tlpMatches.Controls.Add(Me.Label4, 2, 0)
        Me.tlpMatches.Controls.Add(Me.lblMaxConseq, 0, 1)
        Me.tlpMatches.Controls.Add(Me.nudMaxConseq, 1, 1)
        Me.tlpMatches.Controls.Add(Me.Label7, 2, 1)
        Me.tlpMatches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMatches.Location = New System.Drawing.Point(3, 16)
        Me.tlpMatches.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMatches.Name = "tlpMatches"
        Me.tlpMatches.RowCount = 2
        Me.tlpMatches.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMatches.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMatches.Size = New System.Drawing.Size(123, 52)
        Me.tlpMatches.TabIndex = 0
        '
        'lblMinConsec
        '
        Me.lblMinConseq.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMinConseq.AutoSize = True
        Me.lblMinConseq.Location = New System.Drawing.Point(6, 6)
        Me.lblMinConseq.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblMinConseq.Name = "lblMinConsec"
        Me.lblMinConseq.Size = New System.Drawing.Size(51, 13)
        Me.lblMinConseq.TabIndex = 0
        Me.lblMinConseq.Text = "Minimum:"
        '
        'nudMinConseq
        '
        Me.nudMinConseq.AutoSize = True
        Me.nudMinConseq.Location = New System.Drawing.Point(60, 3)
        Me.nudMinConseq.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMinConseq.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudMinConseq.Name = "nudMinConseq"
        Me.nudMinConseq.Size = New System.Drawing.Size(35, 20)
        Me.nudMinConseq.TabIndex = 1
        Me.nudMinConseq.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "letters"
        '
        'lblMaxConsec
        '
        Me.lblMaxConseq.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMaxConseq.AutoSize = True
        Me.lblMaxConseq.Location = New System.Drawing.Point(3, 32)
        Me.lblMaxConseq.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblMaxConseq.Name = "lblMaxConsec"
        Me.lblMaxConseq.Size = New System.Drawing.Size(54, 13)
        Me.lblMaxConseq.TabIndex = 3
        Me.lblMaxConseq.Text = "Maximum:"
        '
        'nudMaxConseq
        '
        Me.nudMaxConseq.AutoSize = True
        Me.nudMaxConseq.Location = New System.Drawing.Point(60, 29)
        Me.nudMaxConseq.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.nudMaxConseq.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudMaxConseq.Name = "nudMaxConseq"
        Me.nudMaxConseq.Size = New System.Drawing.Size(35, 20)
        Me.nudMaxConseq.TabIndex = 4
        Me.nudMaxConseq.Value = New Decimal(New Integer() {26, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "letters"
        '
        'gbWordSize
        '
        Me.gbWordSize.AutoSize = True
        Me.gbWordSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbWordSize.Controls.Add(Me.tlpWordSize)
        Me.gbWordSize.Location = New System.Drawing.Point(3, 15)
        Me.gbWordSize.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.gbWordSize.Name = "gbWordSize"
        Me.gbWordSize.Size = New System.Drawing.Size(129, 71)
        Me.gbWordSize.TabIndex = 2
        Me.gbWordSize.TabStop = False
        Me.gbWordSize.Text = "Word size"
        '
        'tlpWordSize
        '
        Me.tlpWordSize.AutoSize = True
        Me.tlpWordSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpWordSize.ColumnCount = 3
        Me.tlpWordSize.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWordSize.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWordSize.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWordSize.Controls.Add(Me.lblMinLetters, 0, 0)
        Me.tlpWordSize.Controls.Add(Me.nudMinLetters, 1, 0)
        Me.tlpWordSize.Controls.Add(Me.Label3, 2, 0)
        Me.tlpWordSize.Controls.Add(Me.lblMaxLetters, 0, 1)
        Me.tlpWordSize.Controls.Add(Me.nudMaxLetters, 1, 1)
        Me.tlpWordSize.Controls.Add(Me.Label5, 2, 1)
        Me.tlpWordSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWordSize.Location = New System.Drawing.Point(3, 16)
        Me.tlpWordSize.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpWordSize.Name = "tlpWordSize"
        Me.tlpWordSize.RowCount = 2
        Me.tlpWordSize.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWordSize.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWordSize.Size = New System.Drawing.Size(123, 52)
        Me.tlpWordSize.TabIndex = 0
        '
        'lblMinLetters
        '
        Me.lblMinLetters.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMinLetters.AutoSize = True
        Me.lblMinLetters.Location = New System.Drawing.Point(6, 6)
        Me.lblMinLetters.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblMinLetters.Name = "lblMinLetters"
        Me.lblMinLetters.Size = New System.Drawing.Size(51, 13)
        Me.lblMinLetters.TabIndex = 0
        Me.lblMinLetters.Text = "Minimum:"
        '
        'nudMinLetters
        '
        Me.nudMinLetters.AutoSize = True
        Me.nudMinLetters.Location = New System.Drawing.Point(60, 3)
        Me.nudMinLetters.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMinLetters.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudMinLetters.Name = "nudMinLetters"
        Me.nudMinLetters.Size = New System.Drawing.Size(35, 20)
        Me.nudMinLetters.TabIndex = 1
        Me.nudMinLetters.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "letters"
        '
        'lblMaxLetters
        '
        Me.lblMaxLetters.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMaxLetters.AutoSize = True
        Me.lblMaxLetters.Location = New System.Drawing.Point(3, 32)
        Me.lblMaxLetters.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblMaxLetters.Name = "lblMaxLetters"
        Me.lblMaxLetters.Size = New System.Drawing.Size(54, 13)
        Me.lblMaxLetters.TabIndex = 3
        Me.lblMaxLetters.Text = "Maximum:"
        '
        'nudMaxLetters
        '
        Me.nudMaxLetters.AutoSize = True
        Me.nudMaxLetters.Location = New System.Drawing.Point(60, 29)
        Me.nudMaxLetters.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.nudMaxLetters.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudMaxLetters.Name = "nudMaxLetters"
        Me.nudMaxLetters.Size = New System.Drawing.Size(35, 20)
        Me.nudMaxLetters.TabIndex = 4
        Me.nudMaxLetters.Value = New Decimal(New Integer() {26, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "letters"
        '
        'tlpButtons
        '
        Me.tlpButtons.AutoSize = True
        Me.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpButtons.ColumnCount = 5
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpButtons.Controls.Add(Me.btnOK, 1, 0)
        Me.tlpButtons.Controls.Add(Me.btnCancel, 3, 0)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(3, 139)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(270, 37)
        Me.tlpButtons.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(35, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(159, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpButtons, 0, 3)
        Me.tlpMain.Controls.Add(Me.tlpLengths, 0, 1)
        Me.tlpMain.Controls.Add(Me.tllplDirection, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(276, 179)
        Me.tlpMain.TabIndex = 6
        '
        'FindWordsWithXLettersConsecutiveAscendingOrDescending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 179)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FindWordsWithXLettersConsecutiveAscendingOrDescending"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FindWordsWithXLettersConsecutiveAscendingOrDescending"
        Me.tllplDirection.ResumeLayout(False)
        Me.tllplDirection.PerformLayout()
        Me.tlpLengths.ResumeLayout(False)
        Me.tlpLengths.PerformLayout()
        Me.gbConsecutive.ResumeLayout(False)
        Me.gbConsecutive.PerformLayout()
        Me.tlpMatches.ResumeLayout(False)
        Me.tlpMatches.PerformLayout()
        CType(Me.nudMinConseq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxConseq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbWordSize.ResumeLayout(False)
        Me.gbWordSize.PerformLayout()
        Me.tlpWordSize.ResumeLayout(False)
        Me.tlpWordSize.PerformLayout()
        CType(Me.nudMinLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxLetters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tllplDirection As TableLayoutPanel
    Friend WithEvents rbAscending As RadioButton
    Friend WithEvents tlpLengths As TableLayoutPanel
    Friend WithEvents gbConsecutive As GroupBox
    Friend WithEvents tlpMatches As TableLayoutPanel
    Friend WithEvents lblMinConseq As Label
    Friend WithEvents nudMinConseq As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMaxConseq As Label
    Friend WithEvents nudMaxConseq As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents gbWordSize As GroupBox
    Friend WithEvents tlpWordSize As TableLayoutPanel
    Friend WithEvents lblMinLetters As Label
    Friend WithEvents nudMinLetters As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMaxLetters As Label
    Friend WithEvents nudMaxLetters As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents rbDescending As RadioButton
End Class
