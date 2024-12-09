<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Departments))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblDashboard = New System.Windows.Forms.Label()
        Me.BtnDashboard = New System.Windows.Forms.PictureBox()
        Me.LblTeachers = New System.Windows.Forms.Label()
        Me.BtnTeachers = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.PictureBox()
        Me.LblFees = New System.Windows.Forms.Label()
        Me.LblDepartments = New System.Windows.Forms.Label()
        Me.BtnFees = New System.Windows.Forms.PictureBox()
        Me.BtnDepartments = New System.Windows.Forms.PictureBox()
        Me.LblStudents = New System.Windows.Forms.Label()
        Me.BtnStudents = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblCollege = New System.Windows.Forms.Label()
        Me.BtnLogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVDepartments = New System.Windows.Forms.DataGridView()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DeptDescTb = New System.Windows.Forms.TextBox()
        Me.DeptDurTb = New System.Windows.Forms.TextBox()
        Me.DeptNameTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DepartmentsTb1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeManagementDataSet = New College_Management_System.CollegeManagementDataSet()
        Me.CMSDBDataSet = New College_Management_System.CMSDBDataSet()
        Me.CMSDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMSDBDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTb1TableAdapter = New College_Management_System.CollegeManagementDataSetTableAdapters.DepartmentsTb1TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DGVDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsTb1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMSDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMSDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.LblDashboard)
        Me.Panel1.Controls.Add(Me.BtnDashboard)
        Me.Panel1.Controls.Add(Me.LblTeachers)
        Me.Panel1.Controls.Add(Me.BtnTeachers)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.LblFees)
        Me.Panel1.Controls.Add(Me.LblDepartments)
        Me.Panel1.Controls.Add(Me.BtnFees)
        Me.Panel1.Controls.Add(Me.BtnDepartments)
        Me.Panel1.Controls.Add(Me.LblStudents)
        Me.Panel1.Controls.Add(Me.BtnStudents)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 796)
        Me.Panel1.TabIndex = 55
        '
        'LblDashboard
        '
        Me.LblDashboard.AutoSize = True
        Me.LblDashboard.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDashboard.ForeColor = System.Drawing.Color.White
        Me.LblDashboard.Location = New System.Drawing.Point(64, 479)
        Me.LblDashboard.Name = "LblDashboard"
        Me.LblDashboard.Size = New System.Drawing.Size(143, 30)
        Me.LblDashboard.TabIndex = 32
        Me.LblDashboard.Text = "Dashboard"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.Location = New System.Drawing.Point(3, 473)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(55, 50)
        Me.BtnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDashboard.TabIndex = 31
        Me.BtnDashboard.TabStop = False
        '
        'LblTeachers
        '
        Me.LblTeachers.AutoSize = True
        Me.LblTeachers.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTeachers.ForeColor = System.Drawing.Color.White
        Me.LblTeachers.Location = New System.Drawing.Point(64, 208)
        Me.LblTeachers.Name = "LblTeachers"
        Me.LblTeachers.Size = New System.Drawing.Size(120, 30)
        Me.LblTeachers.TabIndex = 30
        Me.LblTeachers.Text = "Teachers"
        '
        'BtnTeachers
        '
        Me.BtnTeachers.Image = CType(resources.GetObject("BtnTeachers.Image"), System.Drawing.Image)
        Me.BtnTeachers.Location = New System.Drawing.Point(3, 202)
        Me.BtnTeachers.Name = "BtnTeachers"
        Me.BtnTeachers.Size = New System.Drawing.Size(55, 45)
        Me.BtnTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnTeachers.TabIndex = 29
        Me.BtnTeachers.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.Location = New System.Drawing.Point(105, 741)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(52, 43)
        Me.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLogout.TabIndex = 28
        Me.BtnLogout.TabStop = False
        '
        'LblFees
        '
        Me.LblFees.AutoSize = True
        Me.LblFees.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFees.ForeColor = System.Drawing.Color.White
        Me.LblFees.Location = New System.Drawing.Point(64, 301)
        Me.LblFees.Name = "LblFees"
        Me.LblFees.Size = New System.Drawing.Size(164, 30)
        Me.LblFees.TabIndex = 26
        Me.LblFees.Text = "Fees Deposit"
        '
        'LblDepartments
        '
        Me.LblDepartments.AutoSize = True
        Me.LblDepartments.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartments.ForeColor = System.Drawing.Color.White
        Me.LblDepartments.Location = New System.Drawing.Point(64, 391)
        Me.LblDepartments.Name = "LblDepartments"
        Me.LblDepartments.Size = New System.Drawing.Size(167, 30)
        Me.LblDepartments.TabIndex = 25
        Me.LblDepartments.Text = "Departments"
        '
        'BtnFees
        '
        Me.BtnFees.Image = CType(resources.GetObject("BtnFees.Image"), System.Drawing.Image)
        Me.BtnFees.Location = New System.Drawing.Point(3, 295)
        Me.BtnFees.Name = "BtnFees"
        Me.BtnFees.Size = New System.Drawing.Size(55, 45)
        Me.BtnFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFees.TabIndex = 23
        Me.BtnFees.TabStop = False
        '
        'BtnDepartments
        '
        Me.BtnDepartments.Image = CType(resources.GetObject("BtnDepartments.Image"), System.Drawing.Image)
        Me.BtnDepartments.Location = New System.Drawing.Point(3, 385)
        Me.BtnDepartments.Name = "BtnDepartments"
        Me.BtnDepartments.Size = New System.Drawing.Size(55, 45)
        Me.BtnDepartments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDepartments.TabIndex = 22
        Me.BtnDepartments.TabStop = False
        '
        'LblStudents
        '
        Me.LblStudents.AutoSize = True
        Me.LblStudents.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudents.ForeColor = System.Drawing.Color.White
        Me.LblStudents.Location = New System.Drawing.Point(64, 118)
        Me.LblStudents.Name = "LblStudents"
        Me.LblStudents.Size = New System.Drawing.Size(113, 30)
        Me.LblStudents.TabIndex = 15
        Me.LblStudents.Text = "Students"
        '
        'BtnStudents
        '
        Me.BtnStudents.Image = CType(resources.GetObject("BtnStudents.Image"), System.Drawing.Image)
        Me.BtnStudents.Location = New System.Drawing.Point(3, 112)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(55, 45)
        Me.BtnStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnStudents.TabIndex = 8
        Me.BtnStudents.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Controls.Add(Me.LblCollege)
        Me.Panel2.Controls.Add(Me.BtnLogo)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 66)
        Me.Panel2.TabIndex = 0
        '
        'LblCollege
        '
        Me.LblCollege.AutoSize = True
        Me.LblCollege.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCollege.ForeColor = System.Drawing.Color.White
        Me.LblCollege.Location = New System.Drawing.Point(71, 17)
        Me.LblCollege.Name = "LblCollege"
        Me.LblCollege.Size = New System.Drawing.Size(105, 45)
        Me.LblCollege.TabIndex = 7
        Me.LblCollege.Text = "CMS"
        '
        'BtnLogo
        '
        Me.BtnLogo.Image = CType(resources.GetObject("BtnLogo.Image"), System.Drawing.Image)
        Me.BtnLogo.Location = New System.Drawing.Point(0, 0)
        Me.BtnLogo.Name = "BtnLogo"
        Me.BtnLogo.Size = New System.Drawing.Size(67, 63)
        Me.BtnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLogo.TabIndex = 4
        Me.BtnLogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Location = New System.Drawing.Point(285, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(912, 69)
        Me.Panel3.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(863, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Departments"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 59)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.DGVDepartments)
        Me.Panel4.Controls.Add(Me.BtnReset)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnUpdate)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.DeptDescTb)
        Me.Panel4.Controls.Add(Me.DeptDurTb)
        Me.Panel4.Controls.Add(Me.DeptNameTb)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(285, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(912, 727)
        Me.Panel4.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 23)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Departments List"
        '
        'DGVDepartments
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVDepartments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDepartments.BackgroundColor = System.Drawing.Color.White
        Me.DGVDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDepartments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDepartments.Location = New System.Drawing.Point(28, 253)
        Me.DGVDepartments.Name = "DGVDepartments"
        Me.DGVDepartments.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDepartments.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVDepartments.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DGVDepartments.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVDepartments.RowTemplate.Height = 21
        Me.DGVDepartments.Size = New System.Drawing.Size(854, 402)
        Me.DGVDepartments.TabIndex = 79
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnReset.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(609, 165)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(125, 39)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(472, 165)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(125, 39)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(323, 165)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(125, 39)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(181, 165)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 39)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'DeptDescTb
        '
        Me.DeptDescTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptDescTb.Location = New System.Drawing.Point(323, 43)
        Me.DeptDescTb.Multiline = True
        Me.DeptDescTb.Name = "DeptDescTb"
        Me.DeptDescTb.Size = New System.Drawing.Size(258, 100)
        Me.DeptDescTb.TabIndex = 1
        '
        'DeptDurTb
        '
        Me.DeptDurTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptDurTb.Location = New System.Drawing.Point(621, 40)
        Me.DeptDurTb.Name = "DeptDurTb"
        Me.DeptDurTb.Size = New System.Drawing.Size(230, 30)
        Me.DeptDurTb.TabIndex = 2
        '
        'DeptNameTb
        '
        Me.DeptNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptNameTb.Location = New System.Drawing.Point(68, 43)
        Me.DeptNameTb.Name = "DeptNameTb"
        Me.DeptNameTb.Size = New System.Drawing.Size(209, 30)
        Me.DeptNameTb.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(617, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 23)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Department's Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Department's Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 23)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Department's Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(230, 672)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(430, 34)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Powered By Mohammad Ahrar"
        '
        'DepartmentsTb1BindingSource
        '
        Me.DepartmentsTb1BindingSource.DataMember = "DepartmentsTb1"
        Me.DepartmentsTb1BindingSource.DataSource = Me.CollegeManagementDataSet
        '
        'CollegeManagementDataSet
        '
        Me.CollegeManagementDataSet.DataSetName = "CollegeManagementDataSet"
        Me.CollegeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMSDBDataSet
        '
        Me.CMSDBDataSet.DataSetName = "CMSDBDataSet"
        Me.CMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMSDBDataSetBindingSource
        '
        Me.CMSDBDataSetBindingSource.DataSource = Me.CMSDBDataSet
        Me.CMSDBDataSetBindingSource.Position = 0
        '
        'CMSDBDataSetBindingSource1
        '
        Me.CMSDBDataSetBindingSource1.DataSource = Me.CMSDBDataSet
        Me.CMSDBDataSetBindingSource1.Position = 0
        '
        'DepartmentsTb1TableAdapter
        '
        Me.DepartmentsTb1TableAdapter.ClearBeforeFill = True
        '
        'Departments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 796)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Departments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BtnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGVDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsTb1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMSDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMSDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblDashboard As System.Windows.Forms.Label
    Friend WithEvents BtnDashboard As System.Windows.Forms.PictureBox
    Friend WithEvents LblTeachers As System.Windows.Forms.Label
    Friend WithEvents BtnTeachers As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogout As System.Windows.Forms.PictureBox
    Friend WithEvents LblFees As System.Windows.Forms.Label
    Friend WithEvents LblDepartments As System.Windows.Forms.Label
    Friend WithEvents BtnFees As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDepartments As System.Windows.Forms.PictureBox
    Friend WithEvents LblStudents As System.Windows.Forms.Label
    Friend WithEvents BtnStudents As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblCollege As System.Windows.Forms.Label
    Friend WithEvents BtnLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DeptDescTb As System.Windows.Forms.TextBox
    Friend WithEvents DeptDurTb As System.Windows.Forms.TextBox
    Friend WithEvents DeptNameTb As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGVDepartments As System.Windows.Forms.DataGridView
    Friend WithEvents CMSDBDataSet As College_Management_System.CMSDBDataSet
    Friend WithEvents CMSDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMSDBDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeManagementDataSet As College_Management_System.CollegeManagementDataSet
    Friend WithEvents DepartmentsTb1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentsTb1TableAdapter As College_Management_System.CollegeManagementDataSetTableAdapters.DepartmentsTb1TableAdapter
End Class
