Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblVS.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Full_check1.computerName.Text = My.Computer.Name
        Full_check1.computerVersion.Text = My.Computer.Info.OSFullName
        Full_check1.osPlatform.Text = My.Computer.Info.OSPlatform
        Full_check1.SystemType.Text = My.Computer.Info.OSVersion
        Full_check1.UserName.Text = SystemInformation.UserName


        If My.Settings.key = "0123-4567-8901-2345-6789" Then

            Label4.Text = "V Shiva Anti-Virus Software - Activated"
            btnPremium.Visible = False
            Label2.Location = New Point(9, 53)
            Label3.Location = New Point(106, 53)
        End If



        If Timer1.Enabled = True Then
            Timer2.Enabled = False
        Else
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles HeaderPanel.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Full_check1.BringToFront()
        'Button1.BackColor = Color.Silver
        'Button2.BackColor = Color.WhiteSmoke
        'Button3.BackColor = Color.WhiteSmoke
        'Button4.BackColor = Color.WhiteSmoke
        'Button5.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Close1_Load(sender As Object, e As EventArgs) Handles Close1.Load

    End Sub

    Private Sub Welcome1_Load(sender As Object, e As EventArgs) Handles Welcome1.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Scan1.BringToFront()
        'Button2.BackColor = Color.Silver
        'Button1.BackColor = Color.WhiteSmoke
        'Button3.BackColor = Color.WhiteSmoke
        'Button4.BackColor = Color.WhiteSmoke
        'Button5.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close1.Visible = True
        Close1.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnQuickScan.Click
        Me.Hide()
        quickscan.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Speedup1.BringToFront()
        'Button3.BackColor = Color.Silver
        'Button2.BackColor = Color.WhiteSmoke
        'Button1.BackColor = Color.WhiteSmoke
        'Button4.BackColor = Color.WhiteSmoke
        'Button5.BackColor = Color.WhiteSmoke


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cleanup1.BringToFront()
        'Button4.BackColor = Color.Silver
        'Button1.BackColor = Color.WhiteSmoke
        'Button2.BackColor = Color.WhiteSmoke
        'Button3.BackColor = Color.WhiteSmoke
        'Button5.BackColor = Color.WhiteSmoke


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Tools1.BringToFront()
        'Button5.BackColor = Color.Silver
        'Button1.BackColor = Color.WhiteSmoke
        'Button2.BackColor = Color.WhiteSmoke
        'Button3.BackColor = Color.WhiteSmoke
        'Button4.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            notification.Show()


        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)

        If ProgressBar2.Value = 100 Then
            Timer2.Stop()
            notification.Timer1.Start()
            notification.Timer2.Start()

        End If

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles btnTimer.Tick

    End Sub

    Private Sub Full_check1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPremium_Click(sender As Object, e As EventArgs) Handles btnPremium.Click
        register.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        profile.ShowDialog()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.key = Nothing
        My.Settings.email = Nothing
        My.Settings.Save()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class
