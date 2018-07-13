Public Class ManageTeachers

    Private Sub ManageTeachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TeachersTableAdapter.Fill(Me.SMS.Teachers)
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Me.TeachersTableAdapter.FillBySearchString(Me.SMS.Teachers, TextBox1.Text & "%", TextBox1.Text)
    End Sub

    Private Sub bnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnew.Click
        AddTeacher.ShowDialog()
        ManageTeachers_Load(sender, e)
    End Sub

    Private Sub bnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnrefresh.Click
        ManageTeachers_Load(sender, e)
    End Sub

    Private Sub bndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndelete.Click
        Try
            Dim db As New SMSDataContext
            Dim SelectedTeacher = From p In db.Teachers
                                  Where p.ID = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                  Select p

            db.Teachers.DeleteOnSubmit(SelectedTeacher.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Teacher Record Successfully Deleted!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ManageTeachers_Load(sender, e)
        Catch ex As Exception
            MsgBox("Select a Teacher Record from the list First!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class