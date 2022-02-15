<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_manage_teacher
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
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lv_teacher = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_id_subject = New System.Windows.Forms.TextBox()
        Me.cb_subject = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.btn_id_user = New System.Windows.Forms.Button()
        Me.txt_id_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rd_female = New System.Windows.Forms.RadioButton()
        Me.rd_male = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_search_teacher = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.open_photo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(107, 616)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(85, 35)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Teacher ID"
        Me.ColumnHeader1.Width = 105
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(17, 616)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(85, 35)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lv_teacher
        '
        Me.lv_teacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_teacher.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_teacher.FullRowSelect = True
        Me.lv_teacher.GridLines = True
        Me.lv_teacher.Location = New System.Drawing.Point(506, 134)
        Me.lv_teacher.Name = "lv_teacher"
        Me.lv_teacher.Size = New System.Drawing.Size(839, 599)
        Me.lv_teacher.TabIndex = 13
        Me.lv_teacher.UseCompatibleStateImageBehavior = False
        Me.lv_teacher.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 167
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 239
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gender"
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date of Birth"
        Me.ColumnHeader5.Width = 103
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Phone Number"
        Me.ColumnHeader6.Width = 118
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(351, 93)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(95, 20)
        Me.lbl_photo.TabIndex = 30
        Me.lbl_photo.Text = "Picture 3 x 4"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1362, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE TEACHER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(145, 450)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(261, 26)
        Me.txt_date.TabIndex = 6
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(145, 297)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(317, 106)
        Me.txt_address.TabIndex = 3
        Me.txt_address.Text = ""
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.Location = New System.Drawing.Point(145, 491)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(317, 26)
        Me.txt_number.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(146, 253)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(316, 26)
        Me.txt_name.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(146, 212)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(316, 26)
        Me.txt_id.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(289, 616)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(85, 35)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(380, 616)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 35)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(198, 616)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(85, 35)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Phone Number"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.btn_cari)
        Me.Panel2.Controls.Add(Me.txt_photo)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_id_subject)
        Me.Panel2.Controls.Add(Me.cb_subject)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_gender)
        Me.Panel2.Controls.Add(Me.btn_id_user)
        Me.Panel2.Controls.Add(Me.txt_id_user)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.rd_female)
        Me.Panel2.Controls.Add(Me.rd_male)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.lbl_photo)
        Me.Panel2.Controls.Add(Me.txt_date)
        Me.Panel2.Controls.Add(Me.txt_address)
        Me.Panel2.Controls.Add(Me.txt_number)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.picture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 661)
        Me.Panel2.TabIndex = 35
        '
        'btn_cari
        '
        Me.btn_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari.Location = New System.Drawing.Point(216, 46)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(85, 35)
        Me.btn_cari.TabIndex = 45
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txt_photo
        '
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(144, 14)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(157, 26)
        Me.txt_photo.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Photo"
        '
        'txt_id_subject
        '
        Me.txt_id_subject.Enabled = False
        Me.txt_id_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_subject.Location = New System.Drawing.Point(426, 571)
        Me.txt_id_subject.Name = "txt_id_subject"
        Me.txt_id_subject.Size = New System.Drawing.Size(39, 26)
        Me.txt_id_subject.TabIndex = 42
        Me.txt_id_subject.Visible = False
        '
        'cb_subject
        '
        Me.cb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_subject.FormattingEnabled = True
        Me.cb_subject.Location = New System.Drawing.Point(145, 571)
        Me.cb_subject.Name = "cb_subject"
        Me.cb_subject.Size = New System.Drawing.Size(268, 28)
        Me.cb_subject.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Subject"
        '
        'txt_gender
        '
        Me.txt_gender.Enabled = False
        Me.txt_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gender.Location = New System.Drawing.Point(352, 413)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(110, 26)
        Me.txt_gender.TabIndex = 38
        Me.txt_gender.Visible = False
        '
        'btn_id_user
        '
        Me.btn_id_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_id_user.Location = New System.Drawing.Point(271, 529)
        Me.btn_id_user.Name = "btn_id_user"
        Me.btn_id_user.Size = New System.Drawing.Size(50, 32)
        Me.btn_id_user.TabIndex = 36
        Me.btn_id_user.Text = "..."
        Me.btn_id_user.UseVisualStyleBackColor = True
        '
        'txt_id_user
        '
        Me.txt_id_user.Enabled = False
        Me.txt_id_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_user.Location = New System.Drawing.Point(146, 532)
        Me.txt_id_user.Name = "txt_id_user"
        Me.txt_id_user.Size = New System.Drawing.Size(110, 26)
        Me.txt_id_user.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 535)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ID User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Gender"
        '
        'rd_female
        '
        Me.rd_female.AutoSize = True
        Me.rd_female.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_female.ForeColor = System.Drawing.Color.White
        Me.rd_female.Location = New System.Drawing.Point(255, 415)
        Me.rd_female.Name = "rd_female"
        Me.rd_female.Size = New System.Drawing.Size(80, 24)
        Me.rd_female.TabIndex = 5
        Me.rd_female.TabStop = True
        Me.rd_female.Text = "Female"
        Me.rd_female.UseVisualStyleBackColor = True
        '
        'rd_male
        '
        Me.rd_male.AutoSize = True
        Me.rd_male.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_male.ForeColor = System.Drawing.Color.White
        Me.rd_male.Location = New System.Drawing.Point(146, 415)
        Me.rd_male.Name = "rd_male"
        Me.rd_male.Size = New System.Drawing.Size(61, 24)
        Me.rd_male.TabIndex = 4
        Me.rd_male.TabStop = True
        Me.rd_male.Text = "Male"
        Me.rd_male.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 452)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Teacher Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Teacher ID"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.DarkGray
        Me.picture.Location = New System.Drawing.Point(322, 14)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(140, 183)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 46
        Me.picture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 80)
        Me.Panel1.TabIndex = 34
        '
        'txt_search_teacher
        '
        Me.txt_search_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_teacher.Location = New System.Drawing.Point(650, 97)
        Me.txt_search_teacher.Name = "txt_search_teacher"
        Me.txt_search_teacher.Size = New System.Drawing.Size(316, 26)
        Me.txt_search_teacher.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(507, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Search Teacher"
        '
        'open_photo
        '
        Me.open_photo.FileName = "OpenFileDialog1"
        '
        'Form_manage_teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_search_teacher)
        Me.Controls.Add(Me.lv_teacher)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_manage_teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_manage_teacher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents lv_teacher As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_photo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_number As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rd_female As System.Windows.Forms.RadioButton
    Friend WithEvents rd_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_id_user As System.Windows.Forms.Button
    Friend WithEvents txt_id_user As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_gender As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_subject As System.Windows.Forms.TextBox
    Friend WithEvents txt_search_teacher As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents txt_photo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents open_photo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picture As System.Windows.Forms.PictureBox
End Class
