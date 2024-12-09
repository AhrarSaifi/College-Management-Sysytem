Imports System.Data.SqlClient
Public Class Dashboards
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\College Management System\College Management System\College Management System\CMSDB.mdf;Integrated Security=True")
    Private Sub CountStudents()
        Dim StNum As Integer
        con.open()
        Dim sql = "select COUNT(*) from StudentsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        StNum = cmd.ExecuteScalar
        NOSLbl.Text = StNum
        con.close()
    End Sub
    Private Sub CountTeachers()
        Dim TNum As Integer
        con.open()
        Dim sql = "select COUNT(*) from TeachersTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        TNum = cmd.ExecuteScalar
        NOTLbl.Text = TNum
        con.close()
    End Sub
    Private Sub CountDepartments()
        Dim DeptNum As Integer
        con.open()
        Dim sql = "select COUNT(*) from DepartmentsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        DeptNum = cmd.ExecuteScalar
        NODLbl.Text = DeptNum
        con.close()
    End Sub
    Private Sub SumFees()
        Dim FeesAmount As Integer
        con.open()
        Dim sql = "select Sum (Amount) from FeesTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        FeesAmount = cmd.ExecuteScalar
        SOPLbl.Text = FeesAmount
        con.close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Dashboards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountStudents()
        CountDepartments()
        CountTeachers()
        SumFees()
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        Dim Obj = New Students()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblStudents_Click(sender As Object, e As EventArgs) Handles LblStudents.Click
        Dim Obj = New Students()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs) Handles BtnTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblTeachers_Click(sender As Object, e As EventArgs) Handles LblTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFees_Click(sender As Object, e As EventArgs) Handles BtnFees.Click
        Dim Obj = New Fees_Deposit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblFees_Click(sender As Object, e As EventArgs) Handles LblFees.Click
        Dim Obj = New Fees_Deposit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblDepartments_Click(sender As Object, e As EventArgs) Handles LblDepartments.Click
        Dim Obj = New Departments()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDepartments_Click(sender As Object, e As EventArgs) Handles BtnDepartments.Click
        Dim Obj = New Departments()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class