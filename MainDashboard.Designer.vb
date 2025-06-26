<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ltbTaskList = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cbStudent = New System.Windows.Forms.CheckBox()
        Me.cbTeacher = New System.Windows.Forms.CheckBox()
        Me.cbEmployee = New System.Windows.Forms.CheckBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAddTask = New System.Windows.Forms.Label()
        Me.lblYourTask = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblSelectRole = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Bell MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(462, 22)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(371, 52)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome Aboard!"
        '
        'btnAddTask
        '
        Me.btnAddTask.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.Location = New System.Drawing.Point(610, 515)
        Me.btnAddTask.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(158, 39)
        Me.btnAddTask.TabIndex = 3
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(132, 515)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(139, 39)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Task"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(290, 515)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(150, 39)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit Task"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1047, 22)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(208, 39)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'ltbTaskList
        '
        Me.ltbTaskList.FormattingEnabled = True
        Me.ltbTaskList.ItemHeight = 16
        Me.ltbTaskList.Items.AddRange(New Object() {"Task1", "Task2", "Task3"})
        Me.ltbTaskList.Location = New System.Drawing.Point(121, 261)
        Me.ltbTaskList.Margin = New System.Windows.Forms.Padding(4)
        Me.ltbTaskList.Name = "ltbTaskList"
        Me.ltbTaskList.Size = New System.Drawing.Size(352, 244)
        Me.ltbTaskList.TabIndex = 7
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Items.AddRange(New Object() {"Task1", "Task2", "Task3"})
        Me.ListBox3.Location = New System.Drawing.Point(915, 263)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(296, 244)
        Me.ListBox3.TabIndex = 13
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.BackColor = System.Drawing.SystemColors.Info
        Me.lblHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHistory.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHistory.Location = New System.Drawing.Point(987, 207)
        Me.lblHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(170, 31)
        Me.lblHistory.TabIndex = 14
        Me.lblHistory.Text = "Task History"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1081, 108)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(149, 39)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search Task"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(864, 116)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 22)
        Me.TextBox1.TabIndex = 16
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTaskName.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTaskName.Location = New System.Drawing.Point(523, 282)
        Me.lblTaskName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(133, 28)
        Me.lblTaskName.TabIndex = 17
        Me.lblTaskName.Text = "Task Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(677, 288)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 22)
        Me.TextBox2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 324)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Task Date:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(677, 330)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(175, 22)
        Me.TextBox3.TabIndex = 20
        '
        'cbStudent
        '
        Me.cbStudent.AutoSize = True
        Me.cbStudent.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cbStudent.Location = New System.Drawing.Point(677, 380)
        Me.cbStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStudent.Name = "cbStudent"
        Me.cbStudent.Size = New System.Drawing.Size(74, 20)
        Me.cbStudent.TabIndex = 21
        Me.cbStudent.Text = "Student"
        Me.cbStudent.UseVisualStyleBackColor = False
        '
        'cbTeacher
        '
        Me.cbTeacher.AutoSize = True
        Me.cbTeacher.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cbTeacher.Location = New System.Drawing.Point(677, 408)
        Me.cbTeacher.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(80, 20)
        Me.cbTeacher.TabIndex = 22
        Me.cbTeacher.Text = "Teacher"
        Me.cbTeacher.UseVisualStyleBackColor = False
        '
        'cbEmployee
        '
        Me.cbEmployee.AutoSize = True
        Me.cbEmployee.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cbEmployee.Location = New System.Drawing.Point(677, 436)
        Me.cbEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEmployee.Name = "cbEmployee"
        Me.cbEmployee.Size = New System.Drawing.Size(91, 20)
        Me.cbEmployee.TabIndex = 23
        Me.cbEmployee.Text = "Employee"
        Me.cbEmployee.UseVisualStyleBackColor = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(434, 261)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(39, 244)
        Me.HScrollBar1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Info
        Me.PictureBox1.Location = New System.Drawing.Point(52, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1203, 546)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'lblAddTask
        '
        Me.lblAddTask.AutoSize = True
        Me.lblAddTask.BackColor = System.Drawing.SystemColors.Info
        Me.lblAddTask.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTask.Location = New System.Drawing.Point(633, 207)
        Me.lblAddTask.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddTask.Name = "lblAddTask"
        Me.lblAddTask.Size = New System.Drawing.Size(129, 31)
        Me.lblAddTask.TabIndex = 11
        Me.lblAddTask.Text = "Add Task"
        '
        'lblYourTask
        '
        Me.lblYourTask.AutoSize = True
        Me.lblYourTask.BackColor = System.Drawing.SystemColors.Info
        Me.lblYourTask.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourTask.Location = New System.Drawing.Point(219, 207)
        Me.lblYourTask.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYourTask.Name = "lblYourTask"
        Me.lblYourTask.Size = New System.Drawing.Size(140, 31)
        Me.lblYourTask.TabIndex = 10
        Me.lblYourTask.Text = "Your Task"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(506, 261)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(369, 247)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'lblSelectRole
        '
        Me.lblSelectRole.AutoSize = True
        Me.lblSelectRole.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblSelectRole.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectRole.Location = New System.Drawing.Point(532, 372)
        Me.lblSelectRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectRole.Name = "lblSelectRole"
        Me.lblSelectRole.Size = New System.Drawing.Size(131, 28)
        Me.lblSelectRole.TabIndex = 29
        Me.lblSelectRole.Text = "Select Role:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnDelete.Location = New System.Drawing.Point(915, 515)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 39)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "Delete History"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnRestore.Location = New System.Drawing.Point(1081, 515)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(130, 39)
        Me.btnRestore.TabIndex = 31
        Me.btnRestore.Text = "Restore Task"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1296, 710)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblSelectRole)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.cbEmployee)
        Me.Controls.Add(Me.cbTeacher)
        Me.Controls.Add(Me.cbStudent)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblTaskName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.lblAddTask)
        Me.Controls.Add(Me.lblYourTask)
        Me.Controls.Add(Me.ltbTaskList)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainDashboard"
        Me.Text = "MainDashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ltbTaskList As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents lblHistory As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTaskName As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cbStudent As CheckBox
    Friend WithEvents cbTeacher As CheckBox
    Friend WithEvents cbEmployee As CheckBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAddTask As Label
    Friend WithEvents lblYourTask As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblSelectRole As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRestore As Button
End Class
