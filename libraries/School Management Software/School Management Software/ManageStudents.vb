Public Class ManageStudents

    Private Sub ManageStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StudentsTableAdapter.Fill(Me.SMS.Students)
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        If txtsearch.Text = "" Then
            ManageStudents_Load(sender, e)
        Else
            Me.StudentsTableAdapter.FillByFullname(Me.SMS.Students, txtsearch.Text & "%")
        End If
    End Sub

    Private Sub bnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnew.Click
        AddStudent.ShowDialog()
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub bnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnrefresh.Click
        ManageStudents_Load(sender, e)
    End Sub

    Private Sub bndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndelete.Click
        Try
            Dim db As New SMSDataContext
            Dim SelectedStudent = From p In db.Students
                                  Where p.ID = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                  Select p

            db.Students.DeleteOnSubmit(SelectedStudent.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Student record successfully deleted!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageStudents_Load(sender, e)
        Catch ex As Exception
            MsgBox("Please select a student record from the list first!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class