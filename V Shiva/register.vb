Public Class register

    Dim key As String = "0123-4567-8901-2345-6789"



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtEmail.Text = Nothing And MtxtKey.Text = Nothing Then
            MsgBox("No Email/Key Found! Please fill all the details before continue.", MsgBoxStyle.Critical, "Error")
        Else
            If txtEmail.Text = Nothing Then
                MsgBox("No Email Found!", MsgBoxStyle.Critical, "Error")
            Else
                If MtxtKey.Text = Nothing Then
                    MsgBox("No Activation Key Found!", MsgBoxStyle.Critical, "Error")
                Else
                    If MtxtKey.Text = key Then
                        My.Settings.email = txtEmail.Text
                        My.Settings.key = MtxtKey.Text
                        profile.lblversion.Text = "Premium Version"
                        My.Settings.status = profile.lblversion.Text

                        My.Settings.Save()
                        Form1.Label4.Text = "V Shiva Anti-Virus Software - Activated"
                        Form1.btnPremium.Visible = False
                        Form1.Label2.Location = New Point(9, 53)
                        Form1.Label3.Location = New Point(106, 53)
                        MsgBox("Activation Key Accepteed! Thank You for purchasing our Software! Enjoy", MsgBoxStyle.Information, "Activated")
                        Me.Hide()
                        Form1.Show()


                    Else
                        MsgBox("Invalid Activatiion Key Provided! Please try again!", MsgBoxStyle.Critical, "Error")
                    End If

                End If
            End If

        End If
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class