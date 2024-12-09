Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUserName.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Please Enter Username & Password")
        ElseIf TxtUserName.Text = "AhrarSaifi" And TxtPassword.Text = "Ahrar786" Then
            Dim obj = New Dashboards
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username & Password")
            TxtUserName.Text = ""
            TxtPassword.Text = ""

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class