Public Class EnterCA

    Private Sub EnterCA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnloadrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnloadrecords.Click
        If cboclass.Text = "" Or cbostream.Text = "" Or cbosubject.Text = "" Then
            MsgBox("Please select a class, stream and subject to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                                Where p.Class = cboclass.Text And p.Stream = cbostream.Text And p.Subject = cbosubject.Text
                                Select p

        If AssessmentRecords.Count <> 0 Then
            Me.AssessmentsTableAdapter.FillByClass(Me.SMS.Assessments, cboclass.Text, cbostream.Text, cbosubject.Text)
        Else
            Dim StudentRecords = From p In db.Students
                                 Where p.Class = cboclass.Text And p.Stream = cbostream.Text
                                 Select p

            If StudentRecords.Count = 0 Then
                MsgBox("No students' records in the system that match your criteria!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            Else
                For j = 1 To StudentRecords.Count
                    Dim NewAssessmentRecord As New Assessment With {.CA = 0, .Class = cboclass.Text, .Exams = 0, .Full_Name = StudentRecords.ToList(j - 1).Full_Name, .Registration_Number = StudentRecords.ToList(j - 1).Registration_Number, .Stream = cbostream.Text, .Subject = cbosubject.Text}
                    db.Assessments.InsertOnSubmit(NewAssessmentRecord)
                    db.SubmitChanges()
                Next
                Me.AssessmentsTableAdapter.FillByClass(Me.SMS.Assessments, cboclass.Text, cbostream.Text, cbosubject.Text)
                lblcurrentstudent.Text = AssessmentRecords.FirstOrDefault.Full_Name
                RecordPosition = 0
                txtscore.Focus()
            End If
        End If
    End Sub

    Dim RecordPosition As Integer

    Private Sub bnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnenter.Click
        If txtscore.Text = "" Then
            MsgBox("Continuous Assessment Score cannot be empty!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Not IsNumeric(txtscore.Text) Then
            MsgBox("Score must be numeric!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Val(txtscore.Text) > 40 Then
            MsgBox("CA Score cannot be above 40 marks!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim AssessmentRecord = From p In db.Assessments
                               Where p.Class = cboclass.Text And p.Stream = cbostream.Text And p.Subject = cbosubject.Text
                               Select p

        If RecordPosition < (AssessmentRecord.Count - 1) Then
            MsgBox("End of Records Reached!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        AssessmentRecord.ToList(RecordPosition).CA = Val(txtscore.Text)
        db.SubmitChanges()
        RecordPosition += 1
        If RecordPosition = (AssessmentRecord.Count - 1) Then
            MsgBox("End of Record Reached!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        txtscore.Clear()
        txtscore.Focus()
    End Sub

End Class