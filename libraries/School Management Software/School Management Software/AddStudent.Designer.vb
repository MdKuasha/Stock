<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.txtregno = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.nudage = New System.Windows.Forms.NumericUpDown()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bnloadpicture = New System.Windows.Forms.Button()
        Me.bnclearpicture = New System.Windows.Forms.Button()
        Me.bnclear = New System.Windows.Forms.Button()
        Me.bnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.nudage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtregno
        '
        Me.txtregno.Location = New System.Drawing.Point(26, 67)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(210, 20)
        Me.txtregno.TabIndex = 0
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(293, 67)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(428, 20)
        Me.txtfullname.TabIndex = 1
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Location = New System.Drawing.Point(26, 126)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(125, 21)
        Me.cbogender.TabIndex = 2
        '
        'nudage
        '
        Me.nudage.Location = New System.Drawing.Point(175, 126)
        Me.nudage.Name = "nudage"
        Me.nudage.Size = New System.Drawing.Size(61, 20)
        Me.nudage.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(293, 127)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(428, 51)
        Me.txtaddress.TabIndex = 4
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(26, 217)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(210, 20)
        Me.txtphone.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(293, 217)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(428, 20)
        Me.txtemail.TabIndex = 6
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(26, 281)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(210, 21)
        Me.cboclass.TabIndex = 7
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(293, 281)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(210, 21)
        Me.cbostream.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(542, 281)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 108)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'bnloadpicture
        '
        Me.bnloadpicture.Location = New System.Drawing.Point(655, 281)
        Me.bnloadpicture.Name = "bnloadpicture"
        Me.bnloadpicture.Size = New System.Drawing.Size(65, 72)
        Me.bnloadpicture.TabIndex = 10
        Me.bnloadpicture.Text = "Load"
        Me.bnloadpicture.UseVisualStyleBackColor = True
        '
        'bnclearpicture
        '
        Me.bnclearpicture.Location = New System.Drawing.Point(655, 362)
        Me.bnclearpicture.Name = "bnclearpicture"
        Me.bnclearpicture.Size = New System.Drawing.Size(65, 27)
        Me.bnclearpicture.TabIndex = 11
        Me.bnclearpicture.Text = "Clear"
        Me.bnclearpicture.UseVisualStyleBackColor = True
        '
        'bnclear
        '
        Me.bnclear.Location = New System.Drawing.Point(26, 339)
        Me.bnclear.Name = "bnclear"
        Me.bnclear.Size = New System.Drawing.Size(211, 41)
        Me.bnclear.TabIndex = 12
        Me.bnclear.Text = "Clear"
        Me.bnclear.UseVisualStyleBackColor = True
        '
        'bnsave
        '
        Me.bnsave.Location = New System.Drawing.Point(293, 339)
        Me.bnsave.Name = "bnsave"
        Me.bnsave.Size = New System.Drawing.Size(211, 41)
        Me.bnsave.TabIndex = 13
        Me.bnsave.Text = "Save"
        Me.bnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Registration Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Full Name of Student"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Contact Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Contact Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Class"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Stream"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(539, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Student Picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(217, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(299, 37)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Add New Students"
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 409)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnsave)
        Me.Controls.Add(Me.bnclear)
        Me.Controls.Add(Me.bnclearpicture)
        Me.Controls.Add(Me.bnloadpicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.nudage)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtregno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Students"
        CType(Me.nudage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtregno As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents nudage As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bnloadpicture As System.Windows.Forms.Button
    Friend WithEvents bnclearpicture As System.Windows.Forms.Button
    Friend WithEvents bnclear As System.Windows.Forms.Button
    Friend WithEvents bnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
