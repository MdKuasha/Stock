Public Class PrintResults

    Private Sub bncomputeresults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bncomputeresults.Click
        If cboclass.Text = "" Or cbostream.Text = "" Or cbosubject.Text = "" Then
            MsgBox("Select all options to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.AssessmentsTableAdapter.FillByClassStreamSubject(Me.SMS.Assessments, cboclass.Text, cbostream.Text, cbosubject.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class