<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterExams
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
        Me.components = New System.ComponentModel.Container()
        Me.lblcurrentstudent = New System.Windows.Forms.Label()
        Me.bnenter = New System.Windows.Forms.Button()
        Me.txtscore = New System.Windows.Forms.TextBox()
        Me.bnloadrecords = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosubject = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SMS = New School_Management_Software.SMS()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentsTableAdapter = New School_Management_Software.SMSTableAdapters.AssessmentsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcurrentstudent
        '
        Me.lblcurrentstudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcurrentstudent.Location = New System.Drawing.Point(295, 119)
        Me.lblcurrentstudent.Name = "lblcurrentstudent"
        Me.lblcurrentstudent.Size = New System.Drawing.Size(334, 37)
        Me.lblcurrentstudent.TabIndex = 43
        Me.lblcurrentstudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnenter
        '
        Me.bnenter.Location = New System.Drawing.Point(164, 119)
        Me.bnenter.Name = "bnenter"
        Me.bnenter.Size = New System.Drawing.Size(118, 37)
        Me.bnenter.TabIndex = 42
        Me.bnenter.Text = "Enter Exams"
        Me.bnenter.UseVisualStyleBackColor = True
        '
        'txtscore
        '
        Me.txtscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscore.Location = New System.Drawing.Point(16, 119)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.Size = New System.Drawing.Size(131, 38)
        Me.txtscore.TabIndex = 41
        Me.txtscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bnloadrecords
        '
        Me.bnloadrecords.Location = New System.Drawing.Point(509, 24)
        Me.bnloadrecords.Name = "bnloadrecords"
        Me.bnloadrecords.Size = New System.Drawing.Size(121, 83)
        Me.bnloadrecords.TabIndex = 40
        Me.bnloadrecords.Text = "Load Records"
        Me.bnloadrecords.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Subject"
        '
        'cbosubject
        '
        Me.cbosubject.FormattingEnabled = True
        Me.cbosubject.Location = New System.Drawing.Point(15, 87)
        Me.cbosubject.Name = "cbosubject"
        Me.cbosubject.Size = New System.Drawing.Size(477, 21)
        Me.cbosubject.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(279, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Stream"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Class"
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(282, 35)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(210, 21)
        Me.cbostream.TabIndex = 35
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(15, 35)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(210, 21)
        Me.cboclass.TabIndex = 34
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RegistrationNumberDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.ExamsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AssessmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(616, 243)
        Me.DataGridView1.TabIndex = 33
        '
        'SMS
        '
        Me.SMS.DataSetName = "SMS"
        Me.SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'RegistrationNumberDataGridViewTextBoxColumn
        '
        Me.RegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "Registration Number"
        Me.RegistrationNumberDataGridViewTextBoxColumn.HeaderText = "Reg #"
        Me.RegistrationNumberDataGridViewTextBoxColumn.Name = "RegistrationNumberDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'StreamDataGridViewTextBoxColumn
        '
        Me.StreamDataGridViewTextBoxColumn.DataPropertyName = "Stream"
        Me.StreamDataGridViewTextBoxColumn.HeaderText = "Stream"
        Me.StreamDataGridViewTextBoxColumn.Name = "StreamDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'ExamsDataGridViewTextBoxColumn
        '
        Me.ExamsDataGridViewTextBoxColumn.DataPropertyName = "Exams"
        Me.ExamsDataGridViewTextBoxColumn.HeaderText = "Exams"
        Me.ExamsDataGridViewTextBoxColumn.Name = "ExamsDataGridViewTextBoxColumn"
        '
        'EnterExams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.lblcurrentstudent)
        Me.Controls.Add(Me.bnenter)
        Me.Controls.Add(Me.txtscore)
        Me.Controls.Add(Me.bnloadrecords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbosubject)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EnterExams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Exams"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcurrentstudent As System.Windows.Forms.Label
    Friend WithEvents bnenter As System.Windows.Forms.Button
    Friend WithEvents txtscore As System.Windows.Forms.TextBox
    Friend WithEvents bnloadrecords As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbosubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SMS As School_Management_Software.SMS
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssessmentsTableAdapter As School_Management_Software.SMSTableAdapters.AssessmentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExamsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
