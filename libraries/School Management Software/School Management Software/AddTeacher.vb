Public Class AddTeacher

    Private Sub bnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclear.Click
        imgpic.Image = Nothing
    End Sub

    Private Sub bnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnload.Click
        With OpenFileDialog1
            .Title = "Select a Staff Image"
            .Multiselect = False
            .Filter = "Jpeg Images Only|*.jpg"
            .FileName = ""
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                imgpic.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub bnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnsave.Click
        If txtstaffid.Text = "" Or txtfullname.Text = "" Or cbogender.Text = "" Or txtphone.Text = "" Or cbodesignation.Text = "" Then
            MsgBox("Staff ID, Full Name, Gender, Phone Number and Designation are required fields!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckTeacher = From p In db.Teachers
                           Where p.Staff_ID = txtstaffid.Text
                           Select p

        If CheckTeacher.Count <> 0 Then
            MsgBox("A staff with the same ID already exists, please review the staff ID and try again!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim NewTeacher As New Teacher With {.Address = txtaddress.Text, .Age = cboage.Text, .Designation = cbodesignation.Text, .Email_Address = txtemail.Text, .Full_Name = txtfullname.Text, .Gender = cbogender.Text, .Phone_Number = txtphone.Text, .Picture = imgpic.ImageLocation, .Staff_ID = txtstaffid.Text}
        db.Teachers.InsertOnSubmit(NewTeacher)
        db.SubmitChanges()
        MsgBox("Staff Details Saved Successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

End Class