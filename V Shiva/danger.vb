Imports System.IO



Public Class danger
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'browse
        Dim result As DialogResult = OpenFileDialog1.ShowDialog
        If result = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'upload selected file
        Dim FilenameName As String()
        FilenameName = OpenFileDialog1.FileName.Split("\"c)
        File.Copy(OpenFileDialog1.FileName, "Upload\" + FilenameName(FilenameName.Length - 1))
        MessageBox.Show("File Uploaded")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class