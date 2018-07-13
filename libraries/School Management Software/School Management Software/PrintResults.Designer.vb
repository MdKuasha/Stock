<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintResults
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bncomputeresults = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosubject = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SMS = New School_Management_Software.SMS()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentsTableAdapter = New School_Management_Software.SMSTableAdapters.AssessmentsTableAdapter()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bncomputeresults
        '
        Me.bncomputeresults.Location = New System.Drawing.Point(506, 22)
        Me.bncomputeresults.Name = "bncomputeresults"
        Me.bncomputeresults.Size = New System.Drawing.Size(121, 83)
        Me.bncomputeresults.TabIndex = 54
        Me.bncomputeresults.Text = "Print Results"
        Me.bncomputeresults.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Subject"
        '
        'cbosubject
        '
        Me.cbosubject.Enabled = False
        Me.cbosubject.FormattingEnabled = True
        Me.cbosubject.Location = New System.Drawing.Point(12, 85)
        Me.cbosubject.Name = "cbosubject"
        Me.cbosubject.Size = New System.Drawing.Size(477, 21)
        Me.cbosubject.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Stream"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Class"
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(279, 33)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(210, 21)
        Me.cbostream.TabIndex = 49
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(12, 33)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(210, 21)
        Me.cboclass.TabIndex = 48
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "ResultsDS"
        ReportDataSource2.Value = Me.AssessmentsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "School_Management_Software.ResultsReportTabular.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 123)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(613, 339)
        Me.ReportViewer1.TabIndex = 55
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
        'PrintResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.bncomputeresults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbosubject)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbostream)
        Me.Controls.Add(Me.cboclass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "PrintResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Results"
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bncomputeresults As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbosubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SMS As School_Management_Software.SMS
    Friend WithEvents AssessmentsTableAdapter As School_Management_Software.SMSTableAdapters.AssessmentsTableAdapter
End Class
