<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtbUserName = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.txtbAge = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtbBirthday = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbOther = New System.Windows.Forms.RadioButton()
        Me.cbStudent = New System.Windows.Forms.CheckBox()
        Me.cbTeacher = New System.Windows.Forms.CheckBox()
        Me.cbEmployee = New System.Windows.Forms.CheckBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblTaskManager = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Info
        Me.PictureBox2.Location = New System.Drawing.Point(811, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(440, 697)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AccessibleName = ""
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.Info
        Me.lblWelcome.Font = New System.Drawing.Font("Bell MT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(917, 79)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(257, 42)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Welcome User"
        '
        'lblUserName
        '
        Me.lblUserName.AccessibleName = ""
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Info
        Me.lblUserName.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(865, 199)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(102, 24)
        Me.lblUserName.TabIndex = 11
        Me.lblUserName.Text = "UserName:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Info
        Me.lblPassword.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(873, 238)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(94, 24)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        '
        'txtbUserName
        '
        Me.txtbUserName.Location = New System.Drawing.Point(985, 201)
        Me.txtbUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbUserName.Name = "txtbUserName"
        Me.txtbUserName.Size = New System.Drawing.Size(205, 22)
        Me.txtbUserName.TabIndex = 13
        '
        'txtbPassword
        '
        Me.txtbPassword.Location = New System.Drawing.Point(985, 240)
        Me.txtbPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(205, 22)
        Me.txtbPassword.TabIndex = 14
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.SystemColors.Info
        Me.lblAge.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(919, 285)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(48, 24)
        Me.lblAge.TabIndex = 15
        Me.lblAge.Text = "Age:"
        '
        'lblRoles
        '
        Me.lblRoles.AutoSize = True
        Me.lblRoles.BackColor = System.Drawing.SystemColors.Info
        Me.lblRoles.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoles.ForeColor = System.Drawing.Color.Black
        Me.lblRoles.Location = New System.Drawing.Point(859, 484)
        Me.lblRoles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(108, 24)
        Me.lblRoles.TabIndex = 16
        Me.lblRoles.Text = "Select Role:"
        '
        'txtbAge
        '
        Me.txtbAge.Location = New System.Drawing.Point(985, 287)
        Me.txtbAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbAge.Name = "txtbAge"
        Me.txtbAge.Size = New System.Drawing.Size(205, 22)
        Me.txtbAge.TabIndex = 17
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.BackColor = System.Drawing.SystemColors.Info
        Me.lblBirthday.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.Black
        Me.lblBirthday.Location = New System.Drawing.Point(880, 332)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBirthday.Size = New System.Drawing.Size(87, 24)
        Me.lblBirthday.TabIndex = 18
        Me.lblBirthday.Text = "Birthday:"
        '
        'txtbBirthday
        '
        Me.txtbBirthday.Location = New System.Drawing.Point(985, 332)
        Me.txtbBirthday.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbBirthday.Name = "txtbBirthday"
        Me.txtbBirthday.Size = New System.Drawing.Size(205, 22)
        Me.txtbBirthday.TabIndex = 19
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.SystemColors.Info
        Me.lblGender.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(891, 385)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(76, 24)
        Me.lblGender.TabIndex = 20
        Me.lblGender.Text = "Gender:"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.BackColor = System.Drawing.SystemColors.Info
        Me.rbMale.ForeColor = System.Drawing.Color.Black
        Me.rbMale.Location = New System.Drawing.Point(985, 385)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(58, 20)
        Me.rbMale.TabIndex = 21
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.BackColor = System.Drawing.SystemColors.Info
        Me.rbFemale.Location = New System.Drawing.Point(985, 411)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(74, 20)
        Me.rbFemale.TabIndex = 22
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = False
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.BackColor = System.Drawing.SystemColors.Info
        Me.rbOther.Location = New System.Drawing.Point(985, 437)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(60, 20)
        Me.rbOther.TabIndex = 23
        Me.rbOther.TabStop = True
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = False
        '
        'cbStudent
        '
        Me.cbStudent.AutoSize = True
        Me.cbStudent.BackColor = System.Drawing.SystemColors.Info
        Me.cbStudent.Location = New System.Drawing.Point(985, 488)
        Me.cbStudent.Name = "cbStudent"
        Me.cbStudent.Size = New System.Drawing.Size(74, 20)
        Me.cbStudent.TabIndex = 24
        Me.cbStudent.Text = "Student"
        Me.cbStudent.UseVisualStyleBackColor = False
        '
        'cbTeacher
        '
        Me.cbTeacher.AutoSize = True
        Me.cbTeacher.BackColor = System.Drawing.SystemColors.Info
        Me.cbTeacher.Location = New System.Drawing.Point(985, 514)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(80, 20)
        Me.cbTeacher.TabIndex = 25
        Me.cbTeacher.Text = "Teacher"
        Me.cbTeacher.UseVisualStyleBackColor = False
        '
        'cbEmployee
        '
        Me.cbEmployee.AutoSize = True
        Me.cbEmployee.BackColor = System.Drawing.SystemColors.Info
        Me.cbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbEmployee.Location = New System.Drawing.Point(985, 540)
        Me.cbEmployee.Name = "cbEmployee"
        Me.cbEmployee.Size = New System.Drawing.Size(91, 20)
        Me.cbEmployee.TabIndex = 26
        Me.cbEmployee.Text = "Employee"
        Me.cbEmployee.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegister.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(863, 593)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(127, 36)
        Me.btnRegister.TabIndex = 27
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(1024, 593)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 33)
        Me.btnLogin.TabIndex = 28
        Me.btnLogin.Text = "Back to Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblTaskManager
        '
        Me.lblTaskManager.AutoSize = True
        Me.lblTaskManager.Font = New System.Drawing.Font("Bell MT", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskManager.ForeColor = System.Drawing.SystemColors.Info
        Me.lblTaskManager.Location = New System.Drawing.Point(158, 79)
        Me.lblTaskManager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskManager.Name = "lblTaskManager"
        Me.lblTaskManager.Size = New System.Drawing.Size(496, 49)
        Me.lblTaskManager.TabIndex = 29
        Me.lblTaskManager.Text = "Role-Base Task Manager"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Info
        Me.PictureBox1.Location = New System.Drawing.Point(51, 210)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(658, 419)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1247, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTaskManager)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cbEmployee)
        Me.Controls.Add(Me.cbTeacher)
        Me.Controls.Add(Me.cbStudent)
        Me.Controls.Add(Me.rbOther)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtbBirthday)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtbAge)
        Me.Controls.Add(Me.lblRoles)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtbUserName As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblRoles As Label
    Friend WithEvents txtbAge As TextBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtbBirthday As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbOther As RadioButton
    Friend WithEvents cbStudent As CheckBox
    Friend WithEvents cbTeacher As CheckBox
    Friend WithEvents cbEmployee As CheckBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblTaskManager As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
