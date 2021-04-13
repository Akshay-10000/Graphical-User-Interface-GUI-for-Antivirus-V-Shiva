Public Class profile

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub

    Dim PImage As Object
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.name = txtName.Text
        My.Settings.email = txtEmail.Text
        My.Settings.image = PImage
        My.Settings.Save()
        lblName.Text = My.Settings.name
        lblEmail.Text = My.Settings.email
        MsgBox("All Settings Updated Successfully!", MsgBoxStyle.Information, "Updated")


    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgProfile.Image = Image.FromFile(ofd.FileName)
            PImage = ofd.FileName.ToString

        End If
    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = My.Settings.name
        lblEmail.Text = My.Settings.email
        lblkey.Text = My.Settings.key
        lblversion.Text = My.Settings.status
        txtEmail.Text = My.Settings.email
        txtName.Text = My.Settings.name

        Try
            imgProfile.Image = Image.FromFile(My.Settings.image.ToString)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub imgProfile_Click(sender As Object, e As EventArgs) Handles imgProfile.Click

    End Sub
End Class