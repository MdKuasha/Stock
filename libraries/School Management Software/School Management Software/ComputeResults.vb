Public Class ComputeResults

    Private Sub bncomputeresults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bncomputeresults.Click
        If cboclass.Text = "" Or cbostream.Text = "" Then
            MsgBox("Select a class and stream to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                                Where p.Class = cboclass.Text And p.Stream = cbostream.Text
                                Select p

        If AssessmentRecords.Count = 0 Then
            MsgBox("No records found!, Please select a new set of options to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        For j = 1 To AssessmentRecords.Count
            AssessmentRecords.ToList(j - 1).Exams = Val(AssessmentRecords.ToList(j - 1).CA) + Val(AssessmentRecords.ToList(j - 1).Exams)
            If Val(AssessmentRecords.ToList(j - 1).Exams) >= 70 Then
                AssessmentRecords.ToList(j - 1).Grade = "A"
                AssessmentRecords.ToList(j - 1).Remarks = "Excellent"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 60 Then
                AssessmentRecords.ToList(j - 1).Grade = "B"
                AssessmentRecords.ToList(j - 1).Remarks = "Very Good"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 50 Then
                AssessmentRecords.ToList(j - 1).Grade = "C"
                AssessmentRecords.ToList(j - 1).Remarks = "Good"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 40 Then
                AssessmentRecords.ToList(j - 1).Grade = "D"
                AssessmentRecords.ToList(j - 1).Remarks = "Fair"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 35 Then
                AssessmentRecords.ToList(j - 1).Grade = "E"
                AssessmentRecords.ToList(j - 1).Remarks = "Poor"
            Else
                AssessmentRecords.ToList(j - 1).Grade = "F"
                AssessmentRecords.ToList(j - 1).Remarks = "Failed"
            End If
        Next
        db.SubmitChanges()

        Dim TotaledRecords = From p In db.Assessments
                             Where p.Class = cboclass.Text And p.Stream = cbostream.Text
                             Select p
                             Order By p.Total Descending

        For j = 1 To TotaledRecords.Count
            TotaledRecords.ToList(j - 1).Position = j
        Next
        db.SubmitChanges()
        Me.AssessmentsTableAdapter.FillByClassStream(Me.SMS.Assessments, cboclass.Text, cbostream.Text)
    End Sub

End Class