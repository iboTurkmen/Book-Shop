<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.LblAuthorName = New System.Windows.Forms.Label()
        Me.LblCompany = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.TBBookName = New System.Windows.Forms.TextBox()
        Me.TBAuthorName = New System.Windows.Forms.TextBox()
        Me.TBCompany = New System.Windows.Forms.TextBox()
        Me.TBPrice = New System.Windows.Forms.TextBox()
        Me.GBAddBook = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TBBookID = New System.Windows.Forms.TextBox()
        Me.LblBookID = New System.Windows.Forms.Label()
        Me.BtnUpdateBook = New System.Windows.Forms.Button()
        Me.BtnDeleteBook = New System.Windows.Forms.Button()
        Me.BtnSearchBook = New System.Windows.Forms.Button()
        Me.BtnAddBook = New System.Windows.Forms.Button()
        Me.GBAddBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBookName
        '
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Location = New System.Drawing.Point(21, 72)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(63, 13)
        Me.LblBookName.TabIndex = 0
        Me.LblBookName.Text = "Book Name"
        '
        'LblAuthorName
        '
        Me.LblAuthorName.AutoSize = True
        Me.LblAuthorName.Location = New System.Drawing.Point(21, 98)
        Me.LblAuthorName.Name = "LblAuthorName"
        Me.LblAuthorName.Size = New System.Drawing.Size(69, 13)
        Me.LblAuthorName.TabIndex = 1
        Me.LblAuthorName.Text = "Author Name"
        '
        'LblCompany
        '
        Me.LblCompany.AutoSize = True
        Me.LblCompany.Location = New System.Drawing.Point(21, 124)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(51, 13)
        Me.LblCompany.TabIndex = 2
        Me.LblCompany.Text = "Company"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(21, 150)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(31, 13)
        Me.LblPrice.TabIndex = 3
        Me.LblPrice.Text = "Price"
        '
        'TBBookName
        '
        Me.TBBookName.Location = New System.Drawing.Point(91, 69)
        Me.TBBookName.Name = "TBBookName"
        Me.TBBookName.Size = New System.Drawing.Size(130, 20)
        Me.TBBookName.TabIndex = 4
        '
        'TBAuthorName
        '
        Me.TBAuthorName.Location = New System.Drawing.Point(91, 95)
        Me.TBAuthorName.Name = "TBAuthorName"
        Me.TBAuthorName.Size = New System.Drawing.Size(130, 20)
        Me.TBAuthorName.TabIndex = 5
        '
        'TBCompany
        '
        Me.TBCompany.Location = New System.Drawing.Point(91, 121)
        Me.TBCompany.Name = "TBCompany"
        Me.TBCompany.Size = New System.Drawing.Size(130, 20)
        Me.TBCompany.TabIndex = 6
        '
        'TBPrice
        '
        Me.TBPrice.Location = New System.Drawing.Point(91, 147)
        Me.TBPrice.Name = "TBPrice"
        Me.TBPrice.Size = New System.Drawing.Size(130, 20)
        Me.TBPrice.TabIndex = 7
        '
        'GBAddBook
        '
        Me.GBAddBook.Controls.Add(Me.BtnClose)
        Me.GBAddBook.Controls.Add(Me.TBBookID)
        Me.GBAddBook.Controls.Add(Me.LblBookID)
        Me.GBAddBook.Controls.Add(Me.BtnUpdateBook)
        Me.GBAddBook.Controls.Add(Me.BtnDeleteBook)
        Me.GBAddBook.Controls.Add(Me.BtnSearchBook)
        Me.GBAddBook.Controls.Add(Me.BtnAddBook)
        Me.GBAddBook.Location = New System.Drawing.Point(12, 12)
        Me.GBAddBook.Name = "GBAddBook"
        Me.GBAddBook.Size = New System.Drawing.Size(294, 346)
        Me.GBAddBook.TabIndex = 17
        Me.GBAddBook.TabStop = False
        Me.GBAddBook.Text = "Book Information"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnClose.Location = New System.Drawing.Point(12, 309)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(130, 31)
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TBBookID
        '
        Me.TBBookID.Location = New System.Drawing.Point(78, 31)
        Me.TBBookID.Name = "TBBookID"
        Me.TBBookID.Size = New System.Drawing.Size(130, 20)
        Me.TBBookID.TabIndex = 19
        '
        'LblBookID
        '
        Me.LblBookID.AutoSize = True
        Me.LblBookID.Location = New System.Drawing.Point(9, 34)
        Me.LblBookID.Name = "LblBookID"
        Me.LblBookID.Size = New System.Drawing.Size(46, 13)
        Me.LblBookID.TabIndex = 18
        Me.LblBookID.Text = "Book ID"
        '
        'BtnUpdateBook
        '
        Me.BtnUpdateBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnUpdateBook.Location = New System.Drawing.Point(12, 272)
        Me.BtnUpdateBook.Name = "BtnUpdateBook"
        Me.BtnUpdateBook.Size = New System.Drawing.Size(130, 31)
        Me.BtnUpdateBook.TabIndex = 19
        Me.BtnUpdateBook.Text = "Update Book"
        Me.BtnUpdateBook.UseVisualStyleBackColor = False
        '
        'BtnDeleteBook
        '
        Me.BtnDeleteBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnDeleteBook.Location = New System.Drawing.Point(12, 235)
        Me.BtnDeleteBook.Name = "BtnDeleteBook"
        Me.BtnDeleteBook.Size = New System.Drawing.Size(130, 31)
        Me.BtnDeleteBook.TabIndex = 18
        Me.BtnDeleteBook.Text = "Delete Book"
        Me.BtnDeleteBook.UseVisualStyleBackColor = False
        '
        'BtnSearchBook
        '
        Me.BtnSearchBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnSearchBook.Location = New System.Drawing.Point(12, 161)
        Me.BtnSearchBook.Name = "BtnSearchBook"
        Me.BtnSearchBook.Size = New System.Drawing.Size(130, 31)
        Me.BtnSearchBook.TabIndex = 18
        Me.BtnSearchBook.Text = "Search Book"
        Me.BtnSearchBook.UseVisualStyleBackColor = False
        '
        'BtnAddBook
        '
        Me.BtnAddBook.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnAddBook.Location = New System.Drawing.Point(12, 198)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(130, 31)
        Me.BtnAddBook.TabIndex = 17
        Me.BtnAddBook.Text = "Add Book"
        Me.BtnAddBook.UseVisualStyleBackColor = False
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 380)
        Me.Controls.Add(Me.TBPrice)
        Me.Controls.Add(Me.TBCompany)
        Me.Controls.Add(Me.TBAuthorName)
        Me.Controls.Add(Me.TBBookName)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblCompany)
        Me.Controls.Add(Me.LblAuthorName)
        Me.Controls.Add(Me.LblBookName)
        Me.Controls.Add(Me.GBAddBook)
        Me.Name = "FrmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Shop"
        Me.GBAddBook.ResumeLayout(False)
        Me.GBAddBook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBookName As Label
    Friend WithEvents LblAuthorName As Label
    Friend WithEvents LblCompany As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents TBBookName As TextBox
    Friend WithEvents TBAuthorName As TextBox
    Friend WithEvents TBCompany As TextBox
    Friend WithEvents TBPrice As TextBox
    Friend WithEvents GBAddBook As GroupBox
    Friend WithEvents BtnSearchBook As Button
    Friend WithEvents BtnAddBook As Button
    Friend WithEvents BtnUpdateBook As Button
    Friend WithEvents BtnDeleteBook As Button
    Friend WithEvents TBBookID As TextBox
    Friend WithEvents LblBookID As Label
    Friend WithEvents BtnClose As Button
End Class
