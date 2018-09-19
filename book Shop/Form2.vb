Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.IO
Public Class FrmInfo
    Private Sub BtnAddBook_Click(sender As Object, e As EventArgs) Handles BtnAddBook.Click
        Try
            If TBBookID.Text = "" And TBBookName.Text = "" Then
                MessageBox.Show("You Must Fill BooK ID And Book Name At Least")
            Else
                Dim ConIns As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\source\repos\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdIns As New SqlCommand(" insert into TblBookShop(Id,BookName,AuthorName,Company,Price) values(@Id,@BookName,@AuthorName,@Company,@Price)", ConIns)
                CmdIns.Parameters.Add("@Id", SqlDbType.Int).Value = TBBookID.Text
                CmdIns.Parameters.Add("@BookName", SqlDbType.VarChar).Value = TBBookName.Text
                CmdIns.Parameters.Add("@AuthorName", SqlDbType.VarChar).Value = TBAuthorName.Text
                CmdIns.Parameters.Add("@Company", SqlDbType.VarChar).Value = TBCompany.Text
                CmdIns.Parameters.Add("@Price", SqlDbType.Int).Value = TBPrice.Text
                CmdIns.Connection = ConIns
                ConIns.Open()
                CmdIns.ExecuteNonQuery()
                ConIns.Close()
                MessageBox.Show("The Book Add successfully...")
                TBBookID.Clear()
                TBBookName.Clear()
                TBAuthorName.Clear()
                TBCompany.Clear()
                TBPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteBook_Click(sender As Object, e As EventArgs) Handles BtnDeleteBook.Click
        Try
            If TBBookID.Text = "" Then
                MessageBox.Show("You Must Write Book ID To Deleted...")
            Else
                Dim ConDel As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\source\repos\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdDel As New SqlCommand(" delete from TblBookShop where Id='" & TBBookID.Text & "'")
                CmdDel.Connection = ConDel
                ConDel.Open()
                CmdDel.ExecuteNonQuery()
                ConDel.Close()
                MessageBox.Show("The Book Deleted Successfully...")
                TBBookID.Clear()
                TBBookName.Clear()
                TBAuthorName.Clear()
                TBCompany.Clear()
                TBPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateBook_Click(sender As Object, e As EventArgs) Handles BtnUpdateBook.Click
        Try
            If TBBookID.Text = "" Then
                MessageBox.Show("You Must Write Book ID To Update...")
            Else
                Dim ConUpdate As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\source\repos\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdUpdate As New SqlCommand("update TblBookShop set BookName = '" & TBBookName.Text & "',AuthorName = '" & TBAuthorName.Text & "',Company = '" & TBCompany.Text & "',Price = '" & TBPrice.Text & "' where Id = '" & TBBookID.Text & "'")
                CmdUpdate.Connection = ConUpdate
                ConUpdate.Open()
                CmdUpdate.ExecuteNonQuery()
                ConUpdate.Close()
                MessageBox.Show("The Book Updated Successfully...")
                TBBookID.Clear()
                TBBookName.Clear()
                TBAuthorName.Clear()
                TBCompany.Clear()
                TBPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSearchBook_Click(sender As Object, e As EventArgs) Handles BtnSearchBook.Click
        Try
            If TBBookID.Text = "" Then
                MessageBox.Show("You Must Write Book ID To Search...")
            Else
                Dim ConSearch As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibo\source\repos\book Shop\book Shop\DB.mdf;Integrated Security=True;Connect Timeout=30")
                Dim CmdSearch As New SqlCommand(" select * from TblBookShop where id = @Id ", ConSearch)
                CmdSearch.Parameters.Add("@Id", SqlDbType.Int).Value = TBBookID.Text
                Dim Found As New SqlDataAdapter(CmdSearch)
                Dim TblFound As New DataTable()
                Found.Fill(TblFound)
                FrmResult.RTBBookID.Text += TblFound.Rows(0)(0).ToString + Environment.NewLine
                FrmResult.RTBBookName.Text += TblFound.Rows(0)(1).ToString + Environment.NewLine
                FrmResult.RTBAuthorName.Text += TblFound.Rows(0)(2).ToString + Environment.NewLine
                FrmResult.RTBCompany.Text += TblFound.Rows(0)(3).ToString + Environment.NewLine
                FrmResult.RTBPrice.Text += TblFound.Rows(0)(4).ToString + " $" + Environment.NewLine

                MessageBox.Show("The Book Found Successfully...")
                FrmResult.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TBBookID.Clear()
        TBBookName.Clear()
        TBAuthorName.Clear()
        TBCompany.Clear()
        TBPrice.Clear()
    End Sub

    Private Sub TBPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBBookID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBookID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class