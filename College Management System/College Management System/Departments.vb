Imports System.Data.SqlClient
Public Class Departments
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\College Management System\College Management System\College Management System\CMSDB.mdf;Integrated Security=True")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub DisplayDeparments()
        con.open()
        Dim query = "Select * from DepartmentsTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVDepartments.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub Reset()
        DeptNameTb.Text = ""
        DeptDescTb.Text = ""
        DeptDescTb.Text = ""

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DeptNameTb.Text = "" Or DeptDescTb.Text = "" Or DeptDurTb.Text = "" Then
            MsgBox("Please fill In All fields")
        Else
            Try
                con.open()
                Dim query = "insert into DepartmentsTbl values('" & DeptNameTb.Text & "', '" & DeptDescTb.Text & "', '" & DeptDurTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox(" Departments Info Saved Successfully")
                con.close()
                DisplayDeparments()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DeptNameTb.Text = "" Or DeptDescTb.Text = "" Or DeptDurTb.Text = "" Then
            MsgBox("Please fill in all fields")
        Else
            Try
                Dim query = "update DepartmentsTbl set  DeptName = '" & DeptNameTb.Text & "', DeptDesc = '" & DeptDescTb.Text & "', DeptDur =  '" & DeptDurTb.Text & "' where DeptId = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Departments Info Updated Successfully")
                con.close()
                DisplayDeparments()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
       If Key = 0 Then
            MsgBox("Please Select The Department To Delete")
        Else
            Try
                con.open()
                Dim query = "delete from DepartmentsTbl where DeptId =  " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Info Deleted Successfully")
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Reset()
    End Sub
    Dim Key = 0
    Private Sub DGVDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDepartments.CellContentClick
        Dim row As DataGridViewRow = DGVDepartments.Rows(e.RowIndex)
        DeptNameTb.Text = row.Cells(1).Value.ToString
        DeptDescTb.Text = row.Cells(2).Value.ToString
        DeptDescTb.Text = row.Cells(3).Value.ToString
        If DeptNameTb.Text = "" Then
            key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
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
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Dim Obj = New Dashboards()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblDashboard_Click(sender As Object, e As EventArgs) Handles LblDashboard.Click
        Dim Obj = New Dashboards()
        Obj.Show()
        Me.Hide()
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

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CollegeManagementDataSet.DepartmentsTb1' table. You can move, or remove it, as needed.
        Me.DepartmentsTb1TableAdapter.Fill(Me.CollegeManagementDataSet.DepartmentsTb1)
        DisplayDeparments()
    End Sub
End Class