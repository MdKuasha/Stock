<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeacher
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
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.cboage = New System.Windows.Forms.ComboBox()
        Me.cbodesignation = New System.Windows.Forms.ComboBox()
        Me.imgpic = New System.Windows.Forms.PictureBox()
        Me.bnload = New System.Windows.Forms.Button()
        Me.bnclear = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.bnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.imgpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtstaffid
        '
        Me.txtstaffid.Location = New System.Drawing.Point(197, 23)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(186, 20)
        Me.txtstaffid.TabIndex = 0
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(197, 66)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(186, 20)
        Me.txtfullname.TabIndex = 1
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Location = New System.Drawing.Point(197, 114)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(127, 21)
        Me.cbogender.TabIndex = 2
        '
        'cboage
        '
        Me.cboage.FormattingEnabled = True
        Me.cboage.Location = New System.Drawing.Point(197, 159)
        Me.cboage.Name = "cboage"
        Me.cboage.Size = New System.Drawing.Size(127, 21)
        Me.cboage.TabIndex = 3
        '
        'cbodesignation
        '
        Me.cbodesignation.FormattingEnabled = True
        Me.cbodesignation.Location = New System.Drawing.Point(197, 206)
        Me.cbodesignation.Name = "cbodesignation"
        Me.cbodesignation.Size = New System.Drawing.Size(186, 21)
        Me.cbodesignation.TabIndex = 4
        '
        'imgpic
        '
        Me.imgpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgpic.Location = New System.Drawing.Point(409, 23)
        Me.imgpic.Name = "imgpic"
        Me.imgpic.Size = New System.Drawing.Size(134, 156)
        Me.imgpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpic.TabIndex = 5
        Me.imgpic.TabStop = False
        '
        'bnload
        '
        Me.bnload.Location = New System.Drawing.Point(409, 190)
        Me.bnload.Name = "bnload"
        Me.bnload.Size = New System.Drawing.Size(98, 36)
        Me.bnload.TabIndex = 6
        Me.bnload.Text = "Load Image"
        Me.bnload.UseVisualStyleBackColor = True
        '
        'bnclear
        '
        Me.bnclear.Location = New System.Drawing.Point(513, 190)
        Me.bnclear.Name = "bnclear"
        Me.bnclear.Size = New System.Drawing.Size(29, 35)
        Me.bnclear.TabIndex = 7
        Me.bnclear.Text = "X"
        Me.bnclear.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(197, 247)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(346, 51)
        Me.txtaddress.TabIndex = 8
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(197, 316)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(186, 20)
        Me.txtphone.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(197, 358)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(186, 20)
        Me.txtemail.TabIndex = 10
        '
        'bnsave
        '
        Me.bnsave.Location = New System.Drawing.Point(197, 397)
        Me.bnsave.Name = "bnsave"
        Me.bnsave.Size = New System.Drawing.Size(210, 41)
        Me.bnsave.TabIndex = 11
        Me.bnsave.Text = "Save Details"
        Me.bnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Designation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contact Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email Address"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 460)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnsave)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.bnclear)
        Me.Controls.Add(Me.bnload)
        Me.Controls.Add(Me.imgpic)
        Me.Controls.Add(Me.cbodesignation)
        Me.Controls.Add(Me.cboage)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtstaffid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "AddTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Teacher"
        CType(Me.imgpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents cboage As System.Windows.Forms.ComboBox
    Friend WithEvents cbodesignation As System.Windows.Forms.ComboBox
    Friend WithEvents imgpic As System.Windows.Forms.PictureBox
    Friend WithEvents bnload As System.Windows.Forms.Button
    Friend WithEvents bnclear As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents bnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
