Public Class notification
    Private Sub notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        Form1.Timer2.Start()

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.ShowInTaskbar = False
        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        If Form1.ProgressBar2.Value = 100 Then
            Form1.Timer2.Stop()

            Timer1.Start()
            Timer2.Start()

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0.2 Then
            Me.Close()
            Form1.ProgressBar1.Value = 0
            Form1.Timer1.Interval = 500
            Form1.Timer1.Start()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
        Timer2.Start()
        Form1.Timer2.Stop()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quickscan.Show()
        Form1.Timer2.Stop()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class