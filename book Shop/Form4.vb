Public Class FrmResult
    Private Sub FrmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RTBBookID.Enabled = False
        RTBBookName.Enabled = False
        RTBAuthorName.Enabled = False
        RTBCompany.Enabled = False
        RTBPrice.Enabled = False
    End Sub

    Private Sub BtnClearList_Click(sender As Object, e As EventArgs) Handles BtnClearList.Click
        RTBBookID.Clear()
        RTBBookName.Clear()
        RTBAuthorName.Clear()
        RTBCompany.Clear()
        RTBPrice.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class