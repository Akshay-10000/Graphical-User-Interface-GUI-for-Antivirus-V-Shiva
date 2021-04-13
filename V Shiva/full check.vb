Public Class full_check
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'quickscan
        Timer1.Enabled = True
        Timer1.Interval = 50
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        Me.SendToBack()

    End Sub

    Private Sub full_check_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub computerVersion_Click(sender As Object, e As EventArgs) Handles computerVersion.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgressBar2.Increment(1)
        If ProgressBar1.Value = 100 And ProgressBar2.Value = 100 Then
            Timer1.Stop()
            MsgBox("Scan Completed Successfully!", MsgBoxStyle.Information, "Completed")
        End If
    End Sub

    Private Sub computerName_Click(sender As Object, e As EventArgs) Handles computerName.Click

    End Sub
End Class
