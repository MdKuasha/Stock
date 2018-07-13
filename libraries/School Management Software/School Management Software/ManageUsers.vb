Public Class ManageUsers

    Private Sub ManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim db As New SMSDataContext
        Dim UsersList = From p In db.Users
                        Select p Order By p.Username Ascending

        lstexistingusers.Items.Clear()
        If UsersList.Count <> 0 Then
            For j = 1 To UsersList.Count
                lstexistingusers.Items.Add(UsersList.ToList(j - 1).Username)
            Next
        End If
    End Sub

    Private Sub bnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnremove.Click
        If lstexistingusers.Text = "" Then
            MsgBox("Please select an existing user first!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If lstexistingusers.Items.Count = 1 Then
            MsgBox("You cannot remove all users, one account must be left so that the software can be accessible", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim SelectedUser = From p In db.Users
                           Where p.Username = lstexistingusers.Text
                           Select p

        db.Users.DeleteOnSubmit(SelectedUser.FirstOrDefault)
        db.SubmitChanges()
        MsgBox("Selected User Successfully Removed!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        ManageUsers_Load(sender, e)
        Exit Sub
    End Sub

    Private Sub bnloadpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnloadpicture.Click
        With OpenFileDialog1
            .Title = "select a jpeg image"
            .Filter = "Jpeg Images Only|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                imgpicture.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub bnadduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnadduser.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Or txtretypepasssword.Text = "" Or txtfullname.Text = "" Or imgpicture.ImageLocation = "" Then
            MsgBox("All fields are required! Please complete all information to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If txtpassword.Text <> txtretypepasssword.Text Then
            MsgBox("The passwords you have entered do not match!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New SMSDataContext
        Dim CheckUSer = From p In db.Users
                        Where p.Username = txtusername.Text
                        Select p

        If CheckUSer.Count <> 0 Then
            MsgBox("A user with your selected username already exists, please choose another username!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim NewUserDetails As New User With {.Full_Name = txtfullname.Text, .Password = txtpassword.Text, .Picture = imgpicture.ImageLocation, .Username = txtusername.Text}
        db.Users.InsertOnSubmit(NewUserDetails)
        db.SubmitChanges()
        MsgBox("User details successfully added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        txtfullname.Clear()
        txtpassword.Clear()
        txtretypepasssword.Clear()
        txtusername.Clear()
        imgpicture.Image = Nothing
        txtusername.Focus()
        Exit Sub
    End Sub
End Class