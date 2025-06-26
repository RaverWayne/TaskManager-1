Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUserName.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim newForm As New MainDashboard()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblTaskManager.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Label1_Click_4(sender As Object, e As EventArgs)

    End Sub
End Class
