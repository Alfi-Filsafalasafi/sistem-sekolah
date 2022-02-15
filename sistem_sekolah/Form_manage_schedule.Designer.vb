<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_manage_schedule
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_schedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Schedule_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_day = New System.Windows.Forms.ComboBox()
        Me.txt_time = New System.Windows.Forms.TextBox()
        Me.cb_class = New System.Windows.Forms.ComboBox()
        Me.txt_id_subject = New System.Windows.Forms.TextBox()
        Me.txt_id_teacher = New System.Windows.Forms.TextBox()
        Me.txt_id_class = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_teacher = New System.Windows.Forms.ComboBox()
        Me.cb_subject = New System.Windows.Forms.ComboBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 80)
        Me.Panel1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE SCHEDULE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Day"
        Me.ColumnHeader6.Width = 98
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject ID"
        Me.ColumnHeader1.Width = 94
        '
        'lv_schedule
        '
        Me.lv_schedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_schedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.Schedule_ID})
        Me.lv_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_schedule.FullRowSelect = True
        Me.lv_schedule.GridLines = True
        Me.lv_schedule.Location = New System.Drawing.Point(476, 126)
        Me.lv_schedule.Name = "lv_schedule"
        Me.lv_schedule.Size = New System.Drawing.Size(882, 606)
        Me.lv_schedule.TabIndex = 10
        Me.lv_schedule.UseCompatibleStateImageBehavior = False
        Me.lv_schedule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject "
        Me.ColumnHeader2.Width = 171
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Teacher ID"
        Me.ColumnHeader3.Width = 123
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Teacher Name"
        Me.ColumnHeader4.Width = 154
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Class Name"
        Me.ColumnHeader5.Width = 129
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Time"
        Me.ColumnHeader7.Width = 108
        '
        'Schedule_ID
        '
        Me.Schedule_ID.Text = "Schedule_ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.cb_day)
        Me.Panel2.Controls.Add(Me.txt_time)
        Me.Panel2.Controls.Add(Me.cb_class)
        Me.Panel2.Controls.Add(Me.txt_id_subject)
        Me.Panel2.Controls.Add(Me.txt_id_teacher)
        Me.Panel2.Controls.Add(Me.txt_id_class)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cb_teacher)
        Me.Panel2.Controls.Add(Me.cb_subject)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 669)
        Me.Panel2.TabIndex = 1
        '
        'cb_day
        '
        Me.cb_day.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_day.FormattingEnabled = True
        Me.cb_day.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cb_day.Location = New System.Drawing.Point(124, 201)
        Me.cb_day.Name = "cb_day"
        Me.cb_day.Size = New System.Drawing.Size(229, 28)
        Me.cb_day.TabIndex = 80
        '
        'txt_time
        '
        Me.txt_time.Enabled = False
        Me.txt_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_time.Location = New System.Drawing.Point(125, 248)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(228, 26)
        Me.txt_time.TabIndex = 79
        '
        'cb_class
        '
        Me.cb_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_class.FormattingEnabled = True
        Me.cb_class.Location = New System.Drawing.Point(125, 150)
        Me.cb_class.Name = "cb_class"
        Me.cb_class.Size = New System.Drawing.Size(229, 28)
        Me.cb_class.TabIndex = 77
        '
        'txt_id_subject
        '
        Me.txt_id_subject.Enabled = False
        Me.txt_id_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_subject.Location = New System.Drawing.Point(392, 64)
        Me.txt_id_subject.Name = "txt_id_subject"
        Me.txt_id_subject.Size = New System.Drawing.Size(42, 26)
        Me.txt_id_subject.TabIndex = 76
        Me.txt_id_subject.Visible = False
        '
        'txt_id_teacher
        '
        Me.txt_id_teacher.Enabled = False
        Me.txt_id_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_teacher.Location = New System.Drawing.Point(392, 109)
        Me.txt_id_teacher.Name = "txt_id_teacher"
        Me.txt_id_teacher.Size = New System.Drawing.Size(42, 26)
        Me.txt_id_teacher.TabIndex = 75
        Me.txt_id_teacher.Visible = False
        '
        'txt_id_class
        '
        Me.txt_id_class.Enabled = False
        Me.txt_id_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_class.Location = New System.Drawing.Point(392, 150)
        Me.txt_id_class.Name = "txt_id_class"
        Me.txt_id_class.Size = New System.Drawing.Size(42, 26)
        Me.txt_id_class.TabIndex = 74
        Me.txt_id_class.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Subject "
        '
        'cb_teacher
        '
        Me.cb_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_teacher.FormattingEnabled = True
        Me.cb_teacher.Location = New System.Drawing.Point(125, 109)
        Me.cb_teacher.Name = "cb_teacher"
        Me.cb_teacher.Size = New System.Drawing.Size(229, 28)
        Me.cb_teacher.TabIndex = 4
        '
        'cb_subject
        '
        Me.cb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subject.FormattingEnabled = True
        Me.cb_subject.Location = New System.Drawing.Point(124, 64)
        Me.cb_subject.Name = "cb_subject"
        Me.cb_subject.Size = New System.Drawing.Size(229, 28)
        Me.cb_subject.TabIndex = 3
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(100, 307)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 35)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(14, 307)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 35)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(272, 307)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 35)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(358, 307)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 35)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(186, 307)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 35)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Class "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Teacher "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "SCHEDULE PROSSERERS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(602, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(229, 28)
        Me.ComboBox1.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(487, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Search Class"
        '
        'Form_manage_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lv_schedule)
        Me.Name = "Form_manage_schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_manage_schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv_schedule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_teacher As System.Windows.Forms.ComboBox
    Friend WithEvents cb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_id_subject As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_teacher As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_class As System.Windows.Forms.TextBox
    Friend WithEvents txt_time As System.Windows.Forms.TextBox
    Friend WithEvents cb_class As System.Windows.Forms.ComboBox
    Friend WithEvents cb_day As System.Windows.Forms.ComboBox
    Friend WithEvents Schedule_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
