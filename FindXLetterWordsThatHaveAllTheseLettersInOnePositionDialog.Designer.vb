<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLetters = New System.Windows.Forms.TextBox()
        Me.gbWordSize = New System.Windows.Forms.GroupBox()
        Me.tlpWordSize = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMinLetters = New System.Windows.Forms.Label()
        Me.nudMinLetters = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMaxLetters = New System.Windows.Forms.Label()
        Me.nudMaxLetters = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.gbWordSize.SuspendLayout()
        Me.tlpWordSize.SuspendLayout()
        CType(Me.nudMinLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Letters:"
        '
        'tbLetters
        '
        Me.tbLetters.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbLetters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLetters.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLetters.Location = New System.Drawing.Point(3, 19)
        Me.tbLetters.Name = "tbLetters"
        Me.tbLetters.Size = New System.Drawing.Size(270, 26)
        Me.tbLetters.TabIndex = 1
        Me.tbLetters.Text = "aeiou"
        '
        'gbWordSize
        '
        Me.gbWordSize.AutoSize = True
        Me.gbWordSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbWordSize.Controls.Add(Me.tlpWordSize)
        Me.gbWordSize.Location = New System.Drawing.Point(3, 63)
        Me.gbWordSize.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.gbWordSize.Name = "gbWordSize"
        Me.gbWordSize.Size = New System.Drawing.Size(148, 71)
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
        Me.tlpWordSize.Name = "tlpWordSize"
        Me.tlpWordSize.RowCount = 2
        Me.tlpWordSize.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWordSize.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWordSize.Size = New System.Drawing.Size(142, 52)
        Me.tlpWordSize.TabIndex = 0
        '
        'lblMinLetters
        '
        Me.lblMinLetters.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMinLetters.AutoSize = True
        Me.lblMinLetters.Location = New System.Drawing.Point(6, 6)
        Me.lblMinLetters.Name = "lblMinLetters"
        Me.lblMinLetters.Size = New System.Drawing.Size(51, 13)
        Me.lblMinLetters.TabIndex = 0
        Me.lblMinLetters.Text = "Minimum:"
        '
        'nudMinLetters
        '
        Me.nudMinLetters.AutoSize = True
        Me.nudMinLetters.Location = New System.Drawing.Point(63, 3)
        Me.nudMinLetters.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMinLetters.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudMinLetters.Name = "nudMinLetters"
        Me.nudMinLetters.Size = New System.Drawing.Size(35, 20)
        Me.nudMinLetters.TabIndex = 1
        Me.nudMinLetters.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 6)
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
        Me.lblMaxLetters.Name = "lblMaxLetters"
        Me.lblMaxLetters.Size = New System.Drawing.Size(54, 13)
        Me.lblMaxLetters.TabIndex = 3
        Me.lblMaxLetters.Text = "Maximum:"
        '
        'nudMaxLetters
        '
        Me.nudMaxLetters.AutoSize = True
        Me.nudMaxLetters.Location = New System.Drawing.Point(63, 29)
        Me.nudMaxLetters.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMaxLetters.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudMaxLetters.Name = "nudMaxLetters"
        Me.nudMaxLetters.Size = New System.Drawing.Size(35, 20)
        Me.nudMaxLetters.TabIndex = 4
        Me.nudMaxLetters.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "letters"
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
        Me.tlpMain.Controls.Add(Me.Label1, 0, 0)
        Me.tlpMain.Controls.Add(Me.tbLetters, 0, 1)
        Me.tlpMain.Controls.Add(Me.gbWordSize, 0, 2)
        Me.tlpMain.Controls.Add(Me.tlpButtons, 0, 3)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(276, 191)
        Me.tlpMain.TabIndex = 5
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
        Me.tlpButtons.Location = New System.Drawing.Point(3, 152)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(270, 36)
        Me.tlpButtons.TabIndex = 3
        '
        'FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(276, 191)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FindXLetterWordsThatHaveAllTheseLettersInOnePositionDialog"
        Me.gbWordSize.ResumeLayout(False)
        Me.gbWordSize.PerformLayout()
        Me.tlpWordSize.ResumeLayout(False)
        Me.tlpWordSize.PerformLayout()
        CType(Me.nudMinLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxLetters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbLetters As TextBox
    Friend WithEvents gbWordSize As GroupBox
    Friend WithEvents tlpWordSize As TableLayoutPanel
    Friend WithEvents lblMinLetters As Label
    Friend WithEvents nudMinLetters As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMaxLetters As Label
    Friend WithEvents nudMaxLetters As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
End Class
