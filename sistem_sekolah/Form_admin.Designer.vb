<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_edit_profile = New System.Windows.Forms.Button()
        Me.btn_manage_class = New System.Windows.Forms.Button()
        Me.btn_manage_schedule = New System.Windows.Forms.Button()
        Me.btn_management_teacher = New System.Windows.Forms.Button()
        Me.btn_management_student = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lbl_nama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 96)
        Me.Panel1.TabIndex = 7
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.Color.White
        Me.lbl_nama.Location = New System.Drawing.Point(236, 30)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(68, 33)
        Me.lbl_nama.TabIndex = 4
        Me.lbl_nama.Text = "lask"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(783, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(556, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MY ADMIN  OF INFORMATION SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME , "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_log_out)
        Me.Panel2.Controls.Add(Me.btn_edit_profile)
        Me.Panel2.Controls.Add(Me.btn_manage_class)
        Me.Panel2.Controls.Add(Me.btn_manage_schedule)
        Me.Panel2.Controls.Add(Me.btn_management_teacher)
        Me.Panel2.Controls.Add(Me.btn_management_student)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 749)
        Me.Panel2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(859, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.Button1.Size = New System.Drawing.Size(357, 233)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "MANAGE SUBJECT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_log_out
        '
        Me.btn_log_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.Image = CType(resources.GetObject("btn_log_out.Image"), System.Drawing.Image)
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_log_out.Location = New System.Drawing.Point(946, 429)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_log_out.Size = New System.Drawing.Size(270, 233)
        Me.btn_log_out.TabIndex = 6
        Me.btn_log_out.Text = "LOG OUT"
        Me.btn_log_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_log_out.UseVisualStyleBackColor = True
        '
        'btn_edit_profile
        '
        Me.btn_edit_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_profile.Image = CType(resources.GetObject("btn_edit_profile.Image"), System.Drawing.Image)
        Me.btn_edit_profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_edit_profile.Location = New System.Drawing.Point(676, 429)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.btn_edit_profile.Size = New System.Drawing.Size(270, 233)
        Me.btn_edit_profile.TabIndex = 5
        Me.btn_edit_profile.Text = "EDIT PROFILE"
        Me.btn_edit_profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_edit_profile.UseVisualStyleBackColor = True
        '
        'btn_manage_class
        '
        Me.btn_manage_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manage_class.Image = CType(resources.GetObject("btn_manage_class.Image"), System.Drawing.Image)
        Me.btn_manage_class.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_manage_class.Location = New System.Drawing.Point(136, 429)
        Me.btn_manage_class.Name = "btn_manage_class"
        Me.btn_manage_class.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.btn_manage_class.Size = New System.Drawing.Size(270, 233)
        Me.btn_manage_class.TabIndex = 3
        Me.btn_manage_class.Text = "MANAGE CLASS"
        Me.btn_manage_class.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_manage_class.UseVisualStyleBackColor = True
        '
        'btn_manage_schedule
        '
        Me.btn_manage_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manage_schedule.Image = CType(resources.GetObject("btn_manage_schedule.Image"), System.Drawing.Image)
        Me.btn_manage_schedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_manage_schedule.Location = New System.Drawing.Point(406, 429)
        Me.btn_manage_schedule.Name = "btn_manage_schedule"
        Me.btn_manage_schedule.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_manage_schedule.Size = New System.Drawing.Size(270, 233)
        Me.btn_manage_schedule.TabIndex = 4
        Me.btn_manage_schedule.Text = "MANAGE SCHEDULE"
        Me.btn_manage_schedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_manage_schedule.UseVisualStyleBackColor = True
        '
        'btn_management_teacher
        '
        Me.btn_management_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_management_teacher.Image = CType(resources.GetObject("btn_management_teacher.Image"), System.Drawing.Image)
        Me.btn_management_teacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_management_teacher.Location = New System.Drawing.Point(498, 193)
        Me.btn_management_teacher.Name = "btn_management_teacher"
        Me.btn_management_teacher.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.btn_management_teacher.Size = New System.Drawing.Size(357, 233)
        Me.btn_management_teacher.TabIndex = 1
        Me.btn_management_teacher.Text = "MANAGE TEACHER"
        Me.btn_management_teacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_management_teacher.UseVisualStyleBackColor = True
        '
        'btn_management_student
        '
        Me.btn_management_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_management_student.Image = CType(resources.GetObject("btn_management_student.Image"), System.Drawing.Image)
        Me.btn_management_student.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_management_student.Location = New System.Drawing.Point(136, 193)
        Me.btn_management_student.Name = "btn_management_student"
        Me.btn_management_student.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_management_student.Size = New System.Drawing.Size(357, 233)
        Me.btn_management_student.TabIndex = 0
        Me.btn_management_student.Text = "MANAGE STUDENT"
        Me.btn_management_student.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_management_student.UseVisualStyleBackColor = True
        '
        'Form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_manage_class As System.Windows.Forms.Button
    Friend WithEvents btn_manage_schedule As System.Windows.Forms.Button
    Friend WithEvents btn_management_teacher As System.Windows.Forms.Button
    Friend WithEvents btn_management_student As System.Windows.Forms.Button
    Friend WithEvents btn_log_out As System.Windows.Forms.Button
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
