<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_teacher))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_edit_profile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_class = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_teaching_schedule = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'btn_edit_profile
        '
        Me.btn_edit_profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_profile.Image = CType(resources.GetObject("btn_edit_profile.Image"), System.Drawing.Image)
        Me.btn_edit_profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_edit_profile.Location = New System.Drawing.Point(133, 259)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_edit_profile.Size = New System.Drawing.Size(350, 233)
        Me.btn_edit_profile.TabIndex = 1
        Me.btn_edit_profile.Text = "EDIT PROFILE"
        Me.btn_edit_profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_edit_profile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(882, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TEACHER OF"
        '
        'lbl_class
        '
        Me.lbl_class.AutoSize = True
        Me.lbl_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class.ForeColor = System.Drawing.Color.White
        Me.lbl_class.Location = New System.Drawing.Point(1098, 30)
        Me.lbl_class.Name = "lbl_class"
        Me.lbl_class.Size = New System.Drawing.Size(102, 33)
        Me.lbl_class.TabIndex = 3
        Me.lbl_class.Text = "Label3"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.Color.White
        Me.lbl_nama.Location = New System.Drawing.Point(236, 30)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(102, 33)
        Me.lbl_nama.TabIndex = 4
        Me.lbl_nama.Text = "Label4"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lbl_class)
        Me.Panel1.Controls.Add(Me.lbl_nama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 96)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.btn_log_out)
        Me.Panel2.Controls.Add(Me.btn_teaching_schedule)
        Me.Panel2.Controls.Add(Me.btn_edit_profile)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 741)
        Me.Panel2.TabIndex = 6
        '
        'btn_log_out
        '
        Me.btn_log_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.Image = CType(resources.GetObject("btn_log_out.Image"), System.Drawing.Image)
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_log_out.Location = New System.Drawing.Point(894, 258)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_log_out.Size = New System.Drawing.Size(350, 233)
        Me.btn_log_out.TabIndex = 3
        Me.btn_log_out.Text = "LOG OUT"
        Me.btn_log_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_log_out.UseVisualStyleBackColor = True
        '
        'btn_teaching_schedule
        '
        Me.btn_teaching_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_teaching_schedule.Image = CType(resources.GetObject("btn_teaching_schedule.Image"), System.Drawing.Image)
        Me.btn_teaching_schedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_teaching_schedule.Location = New System.Drawing.Point(512, 258)
        Me.btn_teaching_schedule.Name = "btn_teaching_schedule"
        Me.btn_teaching_schedule.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.btn_teaching_schedule.Size = New System.Drawing.Size(350, 233)
        Me.btn_teaching_schedule.TabIndex = 2
        Me.btn_teaching_schedule.Text = "TEACHING SCHEDULE"
        Me.btn_teaching_schedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_teaching_schedule.UseVisualStyleBackColor = True
        '
        'form_teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "form_teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "teacher_from"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_class As System.Windows.Forms.Label
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_log_out As System.Windows.Forms.Button
    Friend WithEvents btn_teaching_schedule As System.Windows.Forms.Button
End Class
