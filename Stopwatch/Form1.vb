Public Class Form1
    Private stopwatch As New Diagnostics.Stopwatch

    Private Sub BtnStart_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        TimerStopwatch.Start()
        Me.stopwatch.Start()
        BtnReset.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As System.Object, e As System.EventArgs) Handles BtnReset.Click
        Me.stopwatch.Reset()
        LbTime.Text = "00:00:00:000"
        LsMark.Items.Clear()
    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click
        TimerStopwatch.Stop()
        Me.stopwatch.Stop()
        BtnReset.Enabled = True
    End Sub

    Private Sub BtnMark_Click(sender As System.Object, e As System.EventArgs) Handles BtnMark.Click
        LsMark.Items.Add(LsMark.Items.Count + 1 & " - " & LbTime.Text)
    End Sub

    Private Sub TimerStopwatch_Tick(sender As System.Object, e As System.EventArgs) Handles TimerStopwatch.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        LbTime.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub
End Class
