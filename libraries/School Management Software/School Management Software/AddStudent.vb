Public Class AddStudent

    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        txtaddress.Clear()
        txtemail.Clear()
        txtfullname.Clear()
        txtphone.Clear()
        txtregno.Clear()
        cboclass.Text = ""
        cbogender.Text = ""
        cbostream.Text = ""
        nudage.Value = 0
        PictureBox1.Image = Nothing
        txtregno.Focus()
    End Sub

    Private Sub bnclearpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclearpicture.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub bnloadpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnloadpicture.Click
        With OpenFileDialog1
            .Title = "Select a Jpeg Image"
            .Filter = "Jpeg Images Only|*.jpg"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub bnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsave.Click
        If txtregno.Text = "" Or txtfullname.Text = "" Or cbogender.Text = "" Or cboclass.Text = "" Or cbostream.Text = "" Then
            MsgBox("Registration Number, Full Name, Gender, Class and Stream are Required Fields! Complete them to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckStudentDetails = From p In db.Students
                                  Where p.Registration_Number = txtregno.Text
                                  Select p

        If CheckStudentDetails.Count <> 0 Then
            MsgBox("A Student is already registered with the registration number you have specified! Please correct the registration number to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim NewStudent As New Student With {.Address = txtaddress.Text, .Age = nudage.Value, .Class = cboclass.Text, .Contact_Phone_Number = txtphone.Text, .Email_Address = txtemail.Text, .Full_Name = txtfullname.Text, .Gender = cbogender.Text, .Picture = PictureBox1.ImageLocation, .Registration_Number = txtregno.Text, .Stream = cbostream.Text}
        db.Students.InsertOnSubmit(NewStudent)
        db.SubmitChanges()
        MsgBox("Student Record Successfully Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        bnclear_Click(sender, e)
    End Sub

End Class