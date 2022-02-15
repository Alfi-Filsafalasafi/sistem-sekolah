<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_manage_subject
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_final_exam = New System.Windows.Forms.TextBox()
        Me.txt_mid_exam = New System.Windows.Forms.TextBox()
        Me.txt_assignment = New System.Windows.Forms.TextBox()
        Me.txt_descripsi = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_subject_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv_subject = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_search_subject = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Text = "MANAGE SUBJECT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 80)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.txt_final_exam)
        Me.Panel2.Controls.Add(Me.txt_mid_exam)
        Me.Panel2.Controls.Add(Me.txt_assignment)
        Me.Panel2.Controls.Add(Me.txt_descripsi)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_subject_id)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 669)
        Me.Panel2.TabIndex = 38
        '
        'txt_final_exam
        '
        Me.txt_final_exam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_final_exam.Location = New System.Drawing.Point(120, 469)
        Me.txt_final_exam.Name = "txt_final_exam"
        Me.txt_final_exam.Size = New System.Drawing.Size(146, 26)
        Me.txt_final_exam.TabIndex = 5
        '
        'txt_mid_exam
        '
        Me.txt_mid_exam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mid_exam.Location = New System.Drawing.Point(120, 421)
        Me.txt_mid_exam.Name = "txt_mid_exam"
        Me.txt_mid_exam.Size = New System.Drawing.Size(146, 26)
        Me.txt_mid_exam.TabIndex = 4
        '
        'txt_assignment
        '
        Me.txt_assignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assignment.Location = New System.Drawing.Point(120, 374)
        Me.txt_assignment.Name = "txt_assignment"
        Me.txt_assignment.Size = New System.Drawing.Size(146, 26)
        Me.txt_assignment.TabIndex = 3
        '
        'txt_descripsi
        '
        Me.txt_descripsi.Location = New System.Drawing.Point(120, 153)
        Me.txt_descripsi.Name = "txt_descripsi"
        Me.txt_descripsi.Size = New System.Drawing.Size(316, 200)
        Me.txt_descripsi.TabIndex = 2
        Me.txt_descripsi.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Final Exam"
        '
        'txt_subject_id
        '
        Me.txt_subject_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subject_id.Location = New System.Drawing.Point(120, 64)
        Me.txt_subject_id.Name = "txt_subject_id"
        Me.txt_subject_id.Size = New System.Drawing.Size(316, 26)
        Me.txt_subject_id.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Subject ID"
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(100, 524)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 35)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(14, 524)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 35)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(272, 524)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 35)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(358, 524)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 35)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(186, 524)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 35)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Mid Exam"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(120, 109)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(316, 26)
        Me.txt_name.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Assignment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "SUBJECT PROSSERERS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv_subject
        '
        Me.lv_subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_subject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lv_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_subject.FullRowSelect = True
        Me.lv_subject.GridLines = True
        Me.lv_subject.Location = New System.Drawing.Point(480, 130)
        Me.lv_subject.Name = "lv_subject"
        Me.lv_subject.Size = New System.Drawing.Size(866, 605)
        Me.lv_subject.TabIndex = 75
        Me.lv_subject.UseCompatibleStateImageBehavior = False
        Me.lv_subject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject ID"
        Me.ColumnHeader1.Width = 144
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject Name"
        Me.ColumnHeader2.Width = 303
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Assignment"
        Me.ColumnHeader3.Width = 147
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mid Exam"
        Me.ColumnHeader4.Width = 138
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Final Exam"
        Me.ColumnHeader5.Width = 130
        '
        'txt_search_subject
        '
        Me.txt_search_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_subject.Location = New System.Drawing.Point(617, 94)
        Me.txt_search_subject.Name = "txt_search_subject"
        Me.txt_search_subject.Size = New System.Drawing.Size(316, 26)
        Me.txt_search_subject.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(479, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Search Subject"
        '
        'Form_manage_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.txt_search_subject)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lv_subject)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_manage_subject"
        Me.Text = "Form1_manage_subject"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_subject_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_descripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_final_exam As System.Windows.Forms.TextBox
    Friend WithEvents txt_mid_exam As System.Windows.Forms.TextBox
    Friend WithEvents txt_assignment As System.Windows.Forms.TextBox
    Friend WithEvents lv_subject As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_search_subject As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
