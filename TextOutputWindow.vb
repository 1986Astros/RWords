Public Class TextOutputWindow
    Public Output As IEnumerable(Of String)

    Private Sub TextOutputWindow_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim InitialSecs As Double = 1
        Dim secs As Double = InitialSecs
        Dim dsecs As Double = 1
        Dim msecs As Double = 10
        Dim NextUpdate As DateTime = Now.AddSeconds(secs)
        For Each s As String In Output
            tbOutput.Text &= s & vbCrLf
            If Now >= NextUpdate Then
                If Closed Then
                    Exit Sub
                End If
                tbOutput.SelectionStart = Integer.MaxValue
                tbOutput.ScrollToCaret()
                Application.DoEvents()
                secs += dsecs
                If secs > msecs Then
                    secs = InitialSecs
                End If
                NextUpdate = Now.AddSeconds(secs)
            End If
        Next
        tbOutput.SelectionStart = 0
        tbOutput.ScrollToCaret()
    End Sub

    Private Sub TimerDoEvents_Tick(sender As Object, e As EventArgs) Handles TimerDoEvents.Tick
        Application.DoEvents()
        TimerDoEvents.Interval = 1000
    End Sub

    Private Closed As Boolean = False
    Private Sub Form_Closing(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Closed = Me.Visible
        TimerDoEvents.Enabled = False
    End Sub
End Class