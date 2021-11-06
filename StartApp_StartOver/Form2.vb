Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username, Password As String
        Username = TextBox1.Text
        Password = TextBox2.Text
        If TextBox1.Text = "start" And TextBox2.Text = "over" Then
            MessageBox.Show("Login Success")
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Failed Login ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class