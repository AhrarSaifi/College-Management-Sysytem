Imports System.Data.SqlClient
Public Class Fees_Deposit
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\College Management System\College Management System\College Management System\CMSDB.mdf;Integrated Security=True")
    Private Sub FillStudent()
        con.open()
        Dim query = " select * from StudentsTbl "
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        con.close()
    End Sub
    Private Sub DisplayPayments()
        con.open()
        Dim query = "Select * from FeesTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVFeesDeposit.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub Reset()
        StAmountTb.Text = ""
        StNameTb.Text = ""
        StIdCb.SelectedIndex = -1
    End Sub
    Private Sub UpdateStudents()
        Try
            con.open()
            Dim query = "update StudentsTbl set StFees = " & StAmountTb.Text & " where StId = " & StIdCb.SelectedValue.ToString() & ""
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Fees Info Updated Successfuly")
            con.close()
            DisplayPayments()
            Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetStName()
        con.open()
        Dim query = "select * from StudentsTbl where StId = " & StIdCb.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = reader(1).ToString()
        End While
        con.close()
    End Sub
    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If StNameTb.Text = "" Or StAmountTb.Text = "" Then
            MsgBox(" Missing Information.... !")
        Else
            Try
                con.open()
                Dim query = "insert into FeesTbl values(" & StIdCb.SelectedValue.ToString() & " , '" & StNameTb.Text & "' , '" & Period.Value.Date & "', " & StAmountTb.Text & ")"
                Dim adapter As SqlDataAdapter
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Fees Paid Successfully")
                con.close()
                DisplayPayments()
                UpdateStudents()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStName()
    End Sub

    Private Sub Fees_Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPayments()
        FillStudent()
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

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class