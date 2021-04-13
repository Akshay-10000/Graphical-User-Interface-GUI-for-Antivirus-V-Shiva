Public Class tools
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.SendToBack()

    End Sub

    Private Sub comboItems()
        cmbThemes.Items.Add("Default Theme")

        cmbThemes.Items.Add("Pink Theme")


    End Sub


    Private Sub Default_Theme()
        Form1.HeaderPanel.BackColor = Color.Silver

        Form1.Scan1.BackColor = Color.Silver
        Form1.Scan1.Label1.BackColor = Color.Silver
        Form1.Scan1.Label1.ForeColor = Color.Indigo
        Form1.Scan1.GroupBox2.BackColor = Color.Indigo
        Form1.Scan1.Label9.BackColor = Color.Indigo
        Form1.Scan1.Label10.BackColor = Color.Indigo
        Form1.Scan1.Label11.BackColor = Color.Indigo
        Form1.Scan1.Label12.BackColor = Color.Indigo

        Form1.SidePanel.BackColor = Color.Indigo

        Form1.Welcome1.BackColor = Color.Black

        Form1.Speedup1.BackColor = Color.Silver
        Form1.Speedup1.Label1.BackColor = Color.Silver
        Form1.Speedup1.Label1.ForeColor = Color.Indigo
        Form1.Speedup1.GroupBox2.BackColor = Color.Indigo
        Form1.Speedup1.Label9.BackColor = Color.Indigo
        Form1.Speedup1.Label10.BackColor = Color.Indigo
        Form1.Speedup1.Label11.BackColor = Color.Indigo
        Form1.Speedup1.Label12.BackColor = Color.Indigo



        Form1.Full_check1.BackColor = Color.Silver
        Form1.Full_check1.GroupBox2.BackColor = Color.Indigo
        Form1.Full_check1.GroupBox1.BackColor = Color.Indigo
        Form1.Full_check1.Label17.BackColor = Color.Silver
        Form1.Full_check1.Label17.ForeColor = Color.Indigo
        Form1.Full_check1.Label10.BackColor = Color.Indigo
        Form1.Full_check1.Label11.BackColor = Color.Indigo
        Form1.Full_check1.Label12.BackColor = Color.Indigo
        Form1.Full_check1.Label9.BackColor = Color.Indigo
        Form1.Full_check1.PictureBox1.BackColor = Color.Indigo
        Form1.Full_check1.PictureBox2.BackColor = Color.Indigo



        Form1.Cleanup1.BackColor = Color.Silver
        Form1.Cleanup1.Label2.BackColor = Color.Silver
        Form1.Cleanup1.Label2.ForeColor = Color.Indigo
        Form1.Cleanup1.Button1.BackColor = Color.Indigo
        Form1.Cleanup1.Button2.BackColor = Color.Indigo



        Form1.Close1.Panel1.BackColor = Color.Silver
        Form1.Close1.Label1.ForeColor = Color.Indigo

        quickscan.BackColor = Color.Silver
        quickscan.GroupBox2.BackColor = Color.Indigo
        quickscan.Label10.BackColor = Color.Indigo
        quickscan.Label11.BackColor = Color.Indigo
        quickscan.Label12.BackColor = Color.Indigo
        quickscan.Label9.BackColor = Color.Indigo
        Form1.btnQuickScan.BackColor = Color.Silver
        Form1.btnPremium.BackColor = Color.Silver
        'Form1.btnTrialVersion.BackColor = Color.Silver



        Me.BackColor = Color.Silver
        GroupBox1.BackColor = Color.Indigo
        Label2.BackColor = Color.Silver
        Label2.ForeColor = Color.Indigo

        notification.BackColor = Color.Silver
        notification.Panel1.BackColor = Color.Indigo

        ThemePic.Image = My.Resources.vs_indigo_th


        Form1.Button1.BackColor = Color.WhiteSmoke
        Form1.Button2.BackColor = Color.WhiteSmoke
        Form1.Button3.BackColor = Color.WhiteSmoke
        Form1.Button4.BackColor = Color.WhiteSmoke
        Form1.Button5.BackColor = Color.WhiteSmoke

        register.BackColor = Color.WhiteSmoke
        register.Panel1.BackColor = Color.Silver
        register.Label1.BackColor = Color.Silver
        register.Label3.BackColor = Color.Silver
        register.Label4.BackColor = Color.Silver

        Form1.Button6.ForeColor = Color.Indigo
        Form1.Button6.BackColor = Color.WhiteSmoke

        profile.BackColor = Color.Silver
        profile.Panel1.BackColor = Color.Indigo
        profile.GroupBox1.BackColor = Color.Indigo
        profile.Label4.BackColor = Color.Indigo
        profile.Label5.BackColor = Color.Indigo
        profile.Label7.BackColor = Color.Indigo
        profile.Label8.BackColor = Color.Indigo
        profile.lblEmail.BackColor = Color.Indigo
        profile.lblName.BackColor = Color.Indigo
        profile.lblversion.BackColor = Color.Indigo
        profile.lblkey.BackColor = Color.Indigo
        profile.Label3.BackColor = Color.Silver
        profile.Label6.BackColor = Color.Silver



        profile.Label5.ForeColor = Color.Silver
        profile.Label4.ForeColor = Color.Silver
        profile.Label7.ForeColor = Color.Silver
        profile.Label8.ForeColor = Color.Silver
        profile.lblEmail.ForeColor = Color.Silver
        profile.lblName.ForeColor = Color.Silver
        profile.lblversion.ForeColor = Color.Silver
        profile.lblkey.ForeColor = Color.Silver
        profile.Label3.ForeColor = Color.Indigo
        profile.Label6.ForeColor = Color.Indigo

    End Sub

    Private Sub Pink_Theme()
        Form1.HeaderPanel.BackColor = Color.DeepPink

        Form1.Scan1.BackColor = Color.White
        Form1.Scan1.Label1.BackColor = Color.White
        Form1.Scan1.Label1.ForeColor = Color.Indigo
        Form1.Scan1.GroupBox2.BackColor = Color.DeepPink
        Form1.Scan1.Label9.BackColor = Color.DeepPink
        Form1.Scan1.Label10.BackColor = Color.DeepPink
        Form1.Scan1.Label11.BackColor = Color.DeepPink
        Form1.Scan1.Label12.BackColor = Color.DeepPink




        Form1.SidePanel.BackColor = Color.HotPink

        Form1.Welcome1.BackColor = Color.Black

        Form1.Speedup1.BackColor = Color.White
        Form1.Speedup1.GroupBox2.BackColor = Color.DeepPink
        Form1.Speedup1.Label1.BackColor = Color.White
        Form1.Speedup1.Label1.ForeColor = Color.Indigo
        Form1.Speedup1.GroupBox2.BackColor = Color.DeepPink
        Form1.Speedup1.Label9.BackColor = Color.DeepPink
        Form1.Speedup1.Label10.BackColor = Color.DeepPink
        Form1.Speedup1.Label11.BackColor = Color.DeepPink
        Form1.Speedup1.Label12.BackColor = Color.DeepPink
        Form1.Speedup1.PictureBox2.BackColor = Color.DeepPink


        Form1.Full_check1.BackColor = Color.White
        Form1.Full_check1.GroupBox2.BackColor = Color.DeepPink
        Form1.Full_check1.GroupBox1.BackColor = Color.DeepPink
        Form1.Full_check1.Label17.BackColor = Color.White
        Form1.Full_check1.Label17.ForeColor = Color.Indigo
        Form1.Full_check1.Label10.BackColor = Color.DeepPink
        Form1.Full_check1.Label11.BackColor = Color.DeepPink
        Form1.Full_check1.Label12.BackColor = Color.DeepPink
        Form1.Full_check1.Label9.BackColor = Color.DeepPink
        Form1.Full_check1.PictureBox2.BackColor = Color.DeepPink
        Form1.Full_check1.PictureBox1.BackColor = Color.DeepPink





        Form1.Cleanup1.BackColor = Color.White
        Form1.Cleanup1.Label2.BackColor = Color.White
        Form1.Cleanup1.Label2.ForeColor = Color.Indigo
        Form1.Cleanup1.Button1.BackColor = Color.DeepPink
        Form1.Cleanup1.Button2.BackColor = Color.DeepPink



        Form1.Close1.Panel1.BackColor = Color.DeepPink
        Form1.Close1.Label1.ForeColor = Color.Indigo

        quickscan.BackColor = Color.White
        quickscan.GroupBox2.BackColor = Color.DeepPink
        quickscan.Label9.BackColor = Color.DeepPink
        quickscan.Label10.BackColor = Color.DeepPink
        quickscan.Label11.BackColor = Color.DeepPink
        quickscan.Label12.BackColor = Color.DeepPink
        Form1.btnQuickScan.BackColor = Color.White
        Form1.btnPremium.BackColor = Color.White
        'Form1.btnTrialVersion.BackColor = Color.White



        Me.BackColor = Color.White
        GroupBox1.BackColor = Color.DeepPink
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.Indigo


        Form1.Button1.BackColor = Color.White
        Form1.Button2.BackColor = Color.White
        Form1.Button3.BackColor = Color.White
        Form1.Button4.BackColor = Color.White
        Form1.Button5.BackColor = Color.White

        notification.BackColor = Color.White
        notification.Panel1.BackColor = Color.DeepPink

        ThemePic.Image = My.Resources.vs_pink_th


        register.BackColor = Color.White
        register.Panel1.BackColor = Color.DeepPink
        register.Label1.BackColor = Color.DeepPink
        register.Label3.BackColor = Color.DeepPink
        register.Label4.BackColor = Color.DeepPink


        Form1.Button6.ForeColor = Color.DeepPink
        Form1.Button6.BackColor = Color.White



        profile.BackColor = Color.White
        profile.Panel1.BackColor = Color.DeepPink
        profile.GroupBox1.BackColor = Color.DeepPink
        profile.Label4.BackColor = Color.DeepPink
        profile.Label5.BackColor = Color.DeepPink
        profile.Label7.BackColor = Color.DeepPink
        profile.Label8.BackColor = Color.DeepPink
        profile.lblEmail.BackColor = Color.DeepPink
        profile.lblName.BackColor = Color.DeepPink
        profile.lblversion.BackColor = Color.DeepPink
        profile.lblkey.BackColor = Color.DeepPink
        profile.Label3.BackColor = Color.White
        profile.Label6.BackColor = Color.White



        profile.Label5.ForeColor = Color.White
        profile.Label4.ForeColor = Color.White
        profile.Label7.ForeColor = Color.White
        profile.Label8.ForeColor = Color.White
        profile.lblEmail.ForeColor = Color.White
        profile.lblName.ForeColor = Color.White
        profile.lblversion.ForeColor = Color.White
        profile.lblkey.ForeColor = Color.White
        profile.Label3.ForeColor = Color.DeepPink
        profile.Label6.ForeColor = Color.DeepPink




    End Sub



    Private Sub tools_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cmbThemes.SelectedIndex = 1
        Catch ex As Exception

        End Try


        comboItems()


    End Sub

    Private Sub cmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        If cmbThemes.Text = "Default Theme" Then
            Default_Theme()
        Else
            If cmbThemes.Text = "Pink Theme" Then
                Pink_Theme()

            End If
        End If
    End Sub


End Class
