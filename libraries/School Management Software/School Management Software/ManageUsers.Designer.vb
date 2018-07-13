<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Me.lstexistingusers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnremove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtretypepasssword = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.imgpicture = New System.Windows.Forms.PictureBox()
        Me.bnloadpicture = New System.Windows.Forms.Button()
        Me.bnadduser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstexistingusers
        '
        Me.lstexistingusers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstexistingusers.FormattingEnabled = True
        Me.lstexistingusers.ItemHeight = 25
        Me.lstexistingusers.Location = New System.Drawing.Point(24, 35)
        Me.lstexistingusers.Name = "lstexistingusers"
        Me.lstexistingusers.Size = New System.Drawing.Size(283, 304)
        Me.lstexistingusers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Existing Users"
        '
        'bnremove
        '
        Me.bnremove.Location = New System.Drawing.Point(24, 351)
        Me.bnremove.Name = "bnremove"
        Me.bnremove.Size = New System.Drawing.Size(282, 53)
        Me.bnremove.TabIndex = 2
        Me.bnremove.Text = "Remove Selected User"
        Me.bnremove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bnadduser)
        Me.GroupBox1.Controls.Add(Me.bnloadpicture)
        Me.GroupBox1.Controls.Add(Me.imgpicture)
        Me.GroupBox1.Controls.Add(Me.txtfullname)
        Me.GroupBox1.Controls.Add(Me.txtretypepasssword)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Location = New System.Drawing.Point(330, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 370)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a New User"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(106, 29)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(207, 20)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(106, 66)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(207, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtretypepasssword
        '
        Me.txtretypepasssword.Location = New System.Drawing.Point(106, 106)
        Me.txtretypepasssword.Name = "txtretypepasssword"
        Me.txtretypepasssword.Size = New System.Drawing.Size(207, 20)
        Me.txtretypepasssword.TabIndex = 2
        Me.txtretypepasssword.UseSystemPasswordChar = True
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(106, 150)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(207, 20)
        Me.txtfullname.TabIndex = 3
        '
        'imgpicture
        '
        Me.imgpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgpicture.Location = New System.Drawing.Point(108, 195)
        Me.imgpicture.Name = "imgpicture"
        Me.imgpicture.Size = New System.Drawing.Size(102, 115)
        Me.imgpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpicture.TabIndex = 4
        Me.imgpicture.TabStop = False
        '
        'bnloadpicture
        '
        Me.bnloadpicture.Location = New System.Drawing.Point(222, 195)
        Me.bnloadpicture.Name = "bnloadpicture"
        Me.bnloadpicture.Size = New System.Drawing.Size(90, 115)
        Me.bnloadpicture.TabIndex = 5
        Me.bnloadpicture.Text = "Load Picture"
        Me.bnloadpicture.UseVisualStyleBackColor = True
        '
        'bnadduser
        '
        Me.bnadduser.Location = New System.Drawing.Point(108, 321)
        Me.bnadduser.Name = "bnadduser"
        Me.bnadduser.Size = New System.Drawing.Size(203, 35)
        Me.bnadduser.TabIndex = 6
        Me.bnadduser.Text = "Save New User Details"
        Me.bnadduser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Retype Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Full Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "User Picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bnremove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstexistingusers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstexistingusers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bnadduser As System.Windows.Forms.Button
    Friend WithEvents bnloadpicture As System.Windows.Forms.Button
    Friend WithEvents imgpicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents txtretypepasssword As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
