Imports System.Data.SqlClient
Public Class Teachers
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\College Management System\College Management System\College Management System\CMSDB.mdf;Integrated Security=True")
    Private Sub FillDepartment()
        con.open()
        Dim query = "select * from DepartmentsTbl"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        TDepartmentsCb.DataSource = Tbl
        TDepartmentsCb.DisplayMember = "DeptName"
        TDepartmentsCb.ValueMember = "DeptName"
        con.close()
    End Sub
    Private Sub DisplayTeachers()
        con.open()
        Dim query = "Select * from TeachersTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVTeachers.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub Reset()
        TNameTb.Text = ""
        TGenderCb.SelectedIndex = 0
        TMobileNo.Text = ""
        TDepartmentsCb.SelectedIndex = 0
        TAddress.Text = ""
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TNameTb.Text = "" Or TAddress.Text = "" Or TMobileNo.Text = "" Or TGenderCb.SelectedIndex = -1 Or TDepartmentsCb.SelectedIndex = -1 Then
            MsgBox("Please fill in all fields")
        Else
            Try
                con.open()
                Dim query = "insert into TeachersTbl values('" & TNameTb.Text & "' ,'" & TGenderCb.SelectedItem.ToString() & "' ,'" & TDOB.Value.Date & "' ,'" & TMobileNo.Text & "' ,'" & TDepartmentsCb.SelectedValue.ToString() & "' ,'" & TAddress.Text & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Teachers Info Saved Successfully")
                con.close()
                DisplayTeachers()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TNameTb.Text = "" Or TAddress.Text = "" Or TMobileNo.Text = "" Or TGenderCb.SelectedIndex = -1 Or TDepartmentsCb.SelectedIndex = -1 Then
            MsgBox("Missing Informations.... !")
        Else
            Try
                con.open()
                Dim query = "update TeachersTbl set TName = '" & TNameTb.Text & "' , TGender = '" & TGenderCb.SelectedItem.ToString() & "' , TDOB = '" & TDOB.Value.Date & "' , TPhone = '" & TMobileNo.Text & "' , TDept = '" & TDepartmentsCb.SelectedValue.ToString() & "' , TAdd = '" & TAddress.Text & "' where TId =" & Key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Teachers Info Updated Successfully")
                con.close()
                DisplayTeachers()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Key = 0 Then
            MsgBox("Please Select The Teacher To Delete")
        Else
            Try
                con.open()
                Dim query = "delete from TeachersTbl where TId =  " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Teachers Info Deleted Successfully")
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub DGVTeachers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTeachers.CellContentClick
        Dim row As DataGridViewRow = DGVTeachers.Rows(e.RowIndex)
        TNameTb.Text = row.Cells(1).Value.ToString
        TGenderCb.Text = row.Cells(2).Value.ToString
        TDOB.Text = row.Cells(3).Value.ToString
        TMobileNo.Text = row.Cells(4).Value.ToString
        TDepartmentsCb.SelectedValue = row.Cells(5).Value.ToString
        TAddress.Text = row.Cells(6).Value.ToString
        If TNameTb.Text = "" Then
            key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If


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

    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTeachers()
        FillDepartment()
    End Sub
End Class