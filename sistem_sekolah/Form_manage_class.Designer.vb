<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_manage_class
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
        Me.lv_participan_student = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_masuk = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_class_name = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_search_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lv_student_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_id_class = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(1370, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Clarendon Blk BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv_participan_student
        '
        Me.lv_participan_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_participan_student.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_participan_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_participan_student.FullRowSelect = True
        Me.lv_participan_student.GridLines = True
        Me.lv_participan_student.Location = New System.Drawing.Point(753, 165)
        Me.lv_participan_student.Name = "lv_participan_student"
        Me.lv_participan_student.Size = New System.Drawing.Size(580, 555)
        Me.lv_participan_student.TabIndex = 4
        Me.lv_participan_student.UseCompatibleStateImageBehavior = False
        Me.lv_participan_student.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STUDENT ID"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STUDENT NAME"
        Me.ColumnHeader2.Width = 203
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GENDER"
        Me.ColumnHeader3.Width = 124
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PHONE NUMBER"
        Me.ColumnHeader4.Width = 138
        '
        'btn_masuk
        '
        Me.btn_masuk.Enabled = False
        Me.btn_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_masuk.Location = New System.Drawing.Point(639, 278)
        Me.btn_masuk.Name = "btn_masuk"
        Me.btn_masuk.Size = New System.Drawing.Size(89, 40)
        Me.btn_masuk.TabIndex = 3
        Me.btn_masuk.Text = ">>"
        Me.btn_masuk.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Enabled = False
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(639, 368)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(89, 40)
        Me.btn_keluar.TabIndex = 5
        Me.btn_keluar.Text = "<<"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(749, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Participate Student"
        '
        'txt_class_name
        '
        Me.txt_class_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_class_name.FormattingEnabled = True
        Me.txt_class_name.Location = New System.Drawing.Point(1032, 120)
        Me.txt_class_name.Name = "txt_class_name"
        Me.txt_class_name.Size = New System.Drawing.Size(292, 28)
        Me.txt_class_name.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(919, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Class Name"
        '
        'txt_search_name
        '
        Me.txt_search_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_name.Location = New System.Drawing.Point(314, 120)
        Me.txt_search_name.Name = "txt_search_name"
        Me.txt_search_name.Size = New System.Drawing.Size(296, 26)
        Me.txt_search_name.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Search Name"
        '
        'lv_student_list
        '
        Me.lv_student_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_student_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv_student_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_student_list.FullRowSelect = True
        Me.lv_student_list.GridLines = True
        Me.lv_student_list.Location = New System.Drawing.Point(30, 164)
        Me.lv_student_list.Name = "lv_student_list"
        Me.lv_student_list.Size = New System.Drawing.Size(580, 555)
        Me.lv_student_list.TabIndex = 2
        Me.lv_student_list.UseCompatibleStateImageBehavior = False
        Me.lv_student_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "STUDENT ID"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "STUDENT NAME"
        Me.ColumnHeader6.Width = 203
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "GENDER"
        Me.ColumnHeader7.Width = 124
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PHONE NUMBER"
        Me.ColumnHeader8.Width = 138
        '
        'txt_id_class
        '
        Me.txt_id_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_class.Location = New System.Drawing.Point(1160, 88)
        Me.txt_id_class.Name = "txt_id_class"
        Me.txt_id_class.Size = New System.Drawing.Size(45, 26)
        Me.txt_id_class.TabIndex = 11
        Me.txt_id_class.Visible = False
        '
        'Form_manage_class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.txt_id_class)
        Me.Controls.Add(Me.lv_student_list)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_search_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_class_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_masuk)
        Me.Controls.Add(Me.lv_participan_student)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_manage_class"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv_participan_student As System.Windows.Forms.ListView
    Friend WithEvents btn_masuk As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_class_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_search_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv_student_list As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_id_class As System.Windows.Forms.TextBox
End Class
