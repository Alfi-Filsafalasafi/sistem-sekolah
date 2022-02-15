<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_manage_student
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_id_class = New System.Windows.Forms.TextBox()
        Me.cb_class = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.btn_id_user = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_id_user = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rd_female = New System.Windows.Forms.RadioButton()
        Me.rd_male = New System.Windows.Forms.RadioButton()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lv_student = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cb_class_view = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.open_photo = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_picture = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 80)
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Text = "MANAGE STUDENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.btn_photo)
        Me.Panel2.Controls.Add(Me.txt_photo)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_id_class)
        Me.Panel2.Controls.Add(Me.cb_class)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_gender)
        Me.Panel2.Controls.Add(Me.btn_id_user)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_id_user)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.txt_number)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.rd_female)
        Me.Panel2.Controls.Add(Me.rd_male)
        Me.Panel2.Controls.Add(Me.lbl_picture)
        Me.Panel2.Controls.Add(Me.Picture)
        Me.Panel2.Controls.Add(Me.txt_date)
        Me.Panel2.Controls.Add(Me.txt_address)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 661)
        Me.Panel2.TabIndex = 1
        '
        'btn_photo
        '
        Me.btn_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_photo.Location = New System.Drawing.Point(214, 60)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(85, 35)
        Me.btn_photo.TabIndex = 61
        Me.btn_photo.Text = "Cari"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'txt_photo
        '
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(149, 28)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(150, 26)
        Me.txt_photo.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(17, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Photo"
        '
        'txt_id_class
        '
        Me.txt_id_class.Enabled = False
        Me.txt_id_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_class.Location = New System.Drawing.Point(405, 573)
        Me.txt_id_class.Name = "txt_id_class"
        Me.txt_id_class.Size = New System.Drawing.Size(64, 26)
        Me.txt_id_class.TabIndex = 58
        Me.txt_id_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_class
        '
        Me.cb_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_class.FormattingEnabled = True
        Me.cb_class.Location = New System.Drawing.Point(149, 573)
        Me.cb_class.Name = "cb_class"
        Me.cb_class.Size = New System.Drawing.Size(171, 28)
        Me.cb_class.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 576)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Class"
        '
        'txt_gender
        '
        Me.txt_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gender.Location = New System.Drawing.Point(372, 411)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(97, 26)
        Me.txt_gender.TabIndex = 54
        Me.txt_gender.Visible = False
        '
        'btn_id_user
        '
        Me.btn_id_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_id_user.Location = New System.Drawing.Point(225, 530)
        Me.btn_id_user.Name = "btn_id_user"
        Me.btn_id_user.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.btn_id_user.Size = New System.Drawing.Size(41, 29)
        Me.btn_id_user.TabIndex = 53
        Me.btn_id_user.Text = "..."
        Me.btn_id_user.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 534)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "ID USER"
        '
        'txt_id_user
        '
        Me.txt_id_user.Enabled = False
        Me.txt_id_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_user.Location = New System.Drawing.Point(149, 531)
        Me.txt_id_user.Name = "txt_id_user"
        Me.txt_id_user.Size = New System.Drawing.Size(64, 26)
        Me.txt_id_user.TabIndex = 51
        Me.txt_id_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(111, 615)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(85, 35)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(21, 615)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(85, 35)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.Location = New System.Drawing.Point(149, 489)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(317, 26)
        Me.txt_number.TabIndex = 7
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(293, 615)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(85, 35)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(384, 615)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 35)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(202, 615)
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
        Me.Label8.Location = New System.Drawing.Point(18, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Gender"
        '
        'rd_female
        '
        Me.rd_female.AutoSize = True
        Me.rd_female.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_female.ForeColor = System.Drawing.Color.White
        Me.rd_female.Location = New System.Drawing.Point(261, 412)
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
        Me.rd_male.Location = New System.Drawing.Point(152, 412)
        Me.rd_male.Name = "rd_male"
        Me.rd_male.Size = New System.Drawing.Size(61, 24)
        Me.rd_male.TabIndex = 4
        Me.rd_male.TabStop = True
        Me.rd_male.Text = "Male"
        Me.rd_male.UseVisualStyleBackColor = True
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.DarkGray
        Me.Picture.Location = New System.Drawing.Point(321, 13)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(142, 183)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 45
        Me.Picture.TabStop = False
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(151, 447)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(261, 26)
        Me.txt_date.TabIndex = 6
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(151, 294)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(317, 106)
        Me.txt_address.TabIndex = 3
        Me.txt_address.Text = ""
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(152, 250)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(316, 26)
        Me.txt_name.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(152, 209)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(316, 26)
        Me.txt_id.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Student ID"
        '
        'lv_student
        '
        Me.lv_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv_student.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_student.FullRowSelect = True
        Me.lv_student.GridLines = True
        Me.lv_student.Location = New System.Drawing.Point(507, 129)
        Me.lv_student.Name = "lv_student"
        Me.lv_student.Size = New System.Drawing.Size(839, 600)
        Me.lv_student.TabIndex = 13
        Me.lv_student.UseCompatibleStateImageBehavior = False
        Me.lv_student.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student ID"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 153
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 226
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gender"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date of Birth"
        Me.ColumnHeader5.Width = 103
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Phone Number"
        Me.ColumnHeader6.Width = 112
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Class"
        Me.ColumnHeader7.Width = 77
        '
        'cb_class_view
        '
        Me.cb_class_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_class_view.FormattingEnabled = True
        Me.cb_class_view.Location = New System.Drawing.Point(617, 93)
        Me.cb_class_view.Name = "cb_class_view"
        Me.cb_class_view.Size = New System.Drawing.Size(171, 28)
        Me.cb_class_view.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(506, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Name Class"
        '
        'open_photo
        '
        Me.open_photo.FileName = "OpenFileDialog1"
        '
        'lbl_picture
        '
        Me.lbl_picture.AutoSize = True
        Me.lbl_picture.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_picture.Location = New System.Drawing.Point(344, 87)
        Me.lbl_picture.Name = "lbl_picture"
        Me.lbl_picture.Size = New System.Drawing.Size(95, 20)
        Me.lbl_picture.TabIndex = 46
        Me.lbl_picture.Text = "Picture 3 x 4"
        '
        'form_manage_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.cb_class_view)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lv_student)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_manage_student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_manage_student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lv_student As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rd_female As System.Windows.Forms.RadioButton
    Friend WithEvents rd_male As System.Windows.Forms.RadioButton
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_number As System.Windows.Forms.TextBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_id_user As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_id_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_gender As System.Windows.Forms.TextBox
    Friend WithEvents cb_class As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_class_view As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_id_class As System.Windows.Forms.TextBox
    Friend WithEvents txt_photo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_photo As System.Windows.Forms.Button
    Friend WithEvents open_photo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_picture As System.Windows.Forms.Label
End Class
