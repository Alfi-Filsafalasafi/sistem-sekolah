<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Teaching_schedule
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lv_teaching = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_student = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_view = New System.Windows.Forms.Button()
        Me.lbl_subject = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEACHING SCHEDULE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teaching Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1019, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student List"
        '
        'lv_teaching
        '
        Me.lv_teaching.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_teaching.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lv_teaching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_teaching.FullRowSelect = True
        Me.lv_teaching.GridLines = True
        Me.lv_teaching.Location = New System.Drawing.Point(34, 153)
        Me.lv_teaching.Name = "lv_teaching"
        Me.lv_teaching.Size = New System.Drawing.Size(723, 555)
        Me.lv_teaching.TabIndex = 1
        Me.lv_teaching.UseCompatibleStateImageBehavior = False
        Me.lv_teaching.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject Id"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject"
        Me.ColumnHeader2.Width = 193
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Class Name"
        Me.ColumnHeader3.Width = 171
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Day"
        Me.ColumnHeader4.Width = 122
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Time"
        Me.ColumnHeader5.Width = 125
        '
        'lv_student
        '
        Me.lv_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_student.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_student.FullRowSelect = True
        Me.lv_student.GridLines = True
        Me.lv_student.Location = New System.Drawing.Point(870, 153)
        Me.lv_student.Name = "lv_student"
        Me.lv_student.Size = New System.Drawing.Size(466, 434)
        Me.lv_student.TabIndex = 2
        Me.lv_student.UseCompatibleStateImageBehavior = False
        Me.lv_student.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Student ID"
        Me.ColumnHeader6.Width = 129
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Student Name"
        Me.ColumnHeader7.Width = 206
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Gender"
        Me.ColumnHeader8.Width = 126
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Location = New System.Drawing.Point(1032, 599)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(150, 47)
        Me.btn_view.TabIndex = 3
        Me.btn_view.Text = "View Subject Info"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'lbl_subject
        '
        Me.lbl_subject.AutoSize = True
        Me.lbl_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subject.Location = New System.Drawing.Point(867, 605)
        Me.lbl_subject.Name = "lbl_subject"
        Me.lbl_subject.Size = New System.Drawing.Size(21, 29)
        Me.lbl_subject.TabIndex = 4
        Me.lbl_subject.Text = "-"
        Me.lbl_subject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_subject.Visible = False
        '
        'form_Teaching_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lbl_subject)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.lv_student)
        Me.Controls.Add(Me.lv_teaching)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_Teaching_schedule"
        Me.Text = "form_Teaching_schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lv_teaching As System.Windows.Forms.ListView
    Friend WithEvents lv_student As System.Windows.Forms.ListView
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_subject As System.Windows.Forms.Label
End Class
