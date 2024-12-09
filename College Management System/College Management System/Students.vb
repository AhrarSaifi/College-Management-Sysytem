Imports System.Data.SqlClient
Public Class Students
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\College Management System\College Management System\College Management System\CMSDB.mdf;Integrated Security=True")
    Private Sub FillDepartments()
        con.open()
        Dim query = "select * from DepartmentsTbl"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StDepartmentsCb.DataSource = Tbl
        StDepartmentsCb.DisplayMember = "DeptName"
        StDepartmentsCb.ValueMember = "DeptName"
        con.close()
    End Sub
    Private Sub DisplayStudents()
        con.open()
        Dim query = "Select * from StudentsTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVStudents.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub DueList()
        con.open()
        Dim query = "Select * from StudentsTbl where StFees < 100000"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVStudents.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub Reset()
        StNameTb.Text = ""
        StFeesTb.Text = ""
        StMobileNoTb.Text = ""
        StGenderCb.SelectedIndex = 0
        StDepartmentsCb.SelectedIndex = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If StNameTb.Text = "" Or StFeesTb.Text = "" Or StMobileNoTb.Text = "" Or StGenderCb.SelectedIndex = -1 Or StDepartmentsCb.SelectedIndex = -1 Then
            MsgBox("Missing Information.... !")
        Else
            Try
                con.open()
                Dim query = "insert into StudentsTbl values('" & StNameTb.Text & "' ,'" & StGenderCb.SelectedItem.ToString() & "' ,'" & StDOB.Value.Date & "' ,'" & StMobileNoTb.Text & "' ,'" & StDepartmentsCb.SelectedValue.ToString() & "' ,'" & StFeesTb.Text & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Students Info Saved Successfully")
                con.close()
                DisplayStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If StNameTb.Text = "" Or StFeesTb.Text = "" Or StMobileNoTb.Text = "" Or StGenderCb.SelectedIndex = -1 Or StDepartmentsCb.SelectedIndex = -1 Then
            MsgBox(" Missing Information.... !")
        Else
            Try
                con.open()
                Dim query = "update StudentsTbl set StName = '" & StNameTb.Text & "' , StGender = '" & StGenderCb.SelectedItem.ToString() & "' , StDOB = '" & StDOB.Value.Date & "' , StPhone = '" & StMobileNoTb.Text & "' , StDept = '" & StDepartmentsCb.SelectedValue.ToString() & "' , StFees = " & StFeesTb.Text & " where StId =" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Students Info Updated Successfully")
                con.close()
                DisplayStudents()
                Reset()
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Key = 0 Then
            MsgBox("Please Select The Student To Delete")
        Else
            Try
                con.open()
                Dim query = "delete from StudentsTbl where StId =  " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Info Deleted Successfully")
                con.close()
                DisplayStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Reset()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        DisplayStudents()
    End Sub

    Private Sub BtnDueList_Click(sender As Object, e As EventArgs) Handles BtnDueList.Click
        DueList()
    End Sub
    Dim key = 0
    Private Sub DGVStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStudents.CellContentClick
        Dim row As DataGridViewRow = DGVStudents.Rows(e.RowIndex)
        StNameTb.Text = row.Cells(1).Value.ToString
        StGenderCb.Text = row.Cells(2).Value.ToString
        StDOB.Text = row.Cells(3).Value.ToString
        StMobileNoTb.Text = row.Cells(4).Value.ToString
        StDepartmentsCb.SelectedValue = row.Cells(5).Value.ToString
        StFeesTb.Text = row.Cells(6).Value.ToString
        If StNameTb.Text = "" Then
            key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudents()
        FillDepartments()
    End Sub

    Private Sub LblTeachers_Click(sender As Object, e As EventArgs) Handles LblTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs) Handles BtnTeachers.Click
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

    Private Sub BtnDepartments_Click(sender As Object, e As EventArgs) Handles BtnDepartments.Click
        Dim Obj = New Departments()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LblDepartments_Click(sender As Object, e As EventArgs) Handles LblDepartments.Click
        Dim Obj = New Departments()
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

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class