<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_student))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_class = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_class_schedule = New System.Windows.Forms.Button()
        Me.btn_edit_profile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1370, 96)
        Me.Panel1.TabIndex = 7
        '
        'lbl_class
        '
        Me.lbl_class.AutoSize = True
        Me.lbl_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class.ForeColor = System.Drawing.Color.White
        Me.lbl_class.Location = New System.Drawing.Point(1183, 30)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(880, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STUDENT CLASS OF"
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
        Me.Panel2.Controls.Add(Me.btn_logout)
        Me.Panel2.Controls.Add(Me.btn_class_schedule)
        Me.Panel2.Controls.Add(Me.btn_edit_profile)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 749)
        Me.Panel2.TabIndex = 8
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_logout.Location = New System.Drawing.Point(894, 258)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(0, 60, 0, 65)
        Me.btn_logout.Size = New System.Drawing.Size(350, 233)
        Me.btn_logout.TabIndex = 3
        Me.btn_logout.Text = "LOG OUT"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_class_schedule
        '
        Me.btn_class_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_class_schedule.Image = CType(resources.GetObject("btn_class_schedule.Image"), System.Drawing.Image)
        Me.btn_class_schedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_class_schedule.Location = New System.Drawing.Point(512, 258)
        Me.btn_class_schedule.Name = "btn_class_schedule"
        Me.btn_class_schedule.Padding = New System.Windows.Forms.Padding(10, 60, 10, 65)
        Me.btn_class_schedule.Size = New System.Drawing.Size(350, 233)
        Me.btn_class_schedule.TabIndex = 2
        Me.btn_class_schedule.Text = "CLASS SCHEDULE"
        Me.btn_class_schedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_class_schedule.UseVisualStyleBackColor = True
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
        'Form_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form_student"
        Me.Text = "From_student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_class As System.Windows.Forms.Label
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_class_schedule As System.Windows.Forms.Button
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
End Class
