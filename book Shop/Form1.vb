Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If TBUserName.Text = Nothing Then
                MessageBox.Show("check your user name...")
            ElseIf TBUserName.Text = Nothing Then
                MessageBox.Show("check your password...")
            Else
                Dim ConCheck As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\Desktop\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdCheck As New SqlCommand("select * from TblLogin where UserName = @UserName and Password = @Password ", ConCheck)
                CmdCheck.Parameters.Add("@UserName", SqlDbType.VarChar).Value = TBUserName.Text
                CmdCheck.Parameters.Add("@Password", SqlDbType.VarChar).Value = TBPassword.Text
                Dim Found As New SqlDataAdapter(CmdCheck)
                Dim TblFound As New DataTable()
                ConCheck.Open()
                Using RDR = CmdCheck.ExecuteReader
                    If RDR.HasRows Then
                        FrmMenu.Show()
                    Else
                        MessageBox.Show("Invalid account...")
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Try
            If TBUserName.Text = Nothing Then
                MessageBox.Show("You Must Fill User Name To Sign Up...")
            ElseIf TBPassword.Text = Nothing Then
                MessageBox.Show("You Must Fill Password To Sign Up...")
            Else
                Dim ConIns As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\Desktop\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdIns As New SqlCommand(" insert into TblLogin values('" & TBUserName.Text & "','" & TBPassword.Text & "')")
                CmdIns.Connection = ConIns
                ConIns.Open()
                CmdIns.ExecuteNonQuery()
                ConIns.Close()
                MessageBox.Show("You Sign Up successfully...")
                TBUserName.Clear()
                TBPassword.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
