Public Class speedup
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.SendToBack()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Timer1.Interval = 50
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgressBar2.Increment(1)
        ProgressBar3.Increment(1)
        ProgressBar4.Increment(1)
        ProgressBar5.Increment(1)

        If ProgressBar1.Value = 100 And ProgressBar2.Value = 100 And ProgressBar3.Value = 100 And ProgressBar4.Value = 100 And ProgressBar5.Value = 100 Then
            Timer1.Stop()
            MsgBox("Scan Completed Successfully!", MsgBoxStyle.Information, "Completed")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 25

    End Sub
End Class
