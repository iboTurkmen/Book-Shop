<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmResult
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnClearList = New System.Windows.Forms.Button()
        Me.GBList = New System.Windows.Forms.GroupBox()
        Me.RTBBookID = New System.Windows.Forms.RichTextBox()
        Me.LblListBI = New System.Windows.Forms.Label()
        Me.LblListP = New System.Windows.Forms.Label()
        Me.RTBBookName = New System.Windows.Forms.RichTextBox()
        Me.LblListC = New System.Windows.Forms.Label()
        Me.RTBAuthorName = New System.Windows.Forms.RichTextBox()
        Me.LblListAN = New System.Windows.Forms.Label()
        Me.RTBCompany = New System.Windows.Forms.RichTextBox()
        Me.LblListBN = New System.Windows.Forms.Label()
        Me.RTBPrice = New System.Windows.Forms.RichTextBox()
        Me.GBList.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnClose.Location = New System.Drawing.Point(469, 299)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(130, 31)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnClearList
        '
        Me.BtnClearList.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnClearList.Location = New System.Drawing.Point(333, 299)
        Me.BtnClearList.Name = "BtnClearList"
        Me.BtnClearList.Size = New System.Drawing.Size(130, 31)
        Me.BtnClearList.TabIndex = 20
        Me.BtnClearList.Text = "Clear List"
        Me.BtnClearList.UseVisualStyleBackColor = False
        '
        'GBList
        '
        Me.GBList.Controls.Add(Me.RTBBookID)
        Me.GBList.Controls.Add(Me.LblListBI)
        Me.GBList.Controls.Add(Me.LblListP)
        Me.GBList.Controls.Add(Me.RTBBookName)
        Me.GBList.Controls.Add(Me.LblListC)
        Me.GBList.Controls.Add(Me.RTBAuthorName)
        Me.GBList.Controls.Add(Me.LblListAN)
        Me.GBList.Controls.Add(Me.RTBCompany)
        Me.GBList.Controls.Add(Me.LblListBN)
        Me.GBList.Controls.Add(Me.RTBPrice)
        Me.GBList.Location = New System.Drawing.Point(12, 12)
        Me.GBList.Name = "GBList"
        Me.GBList.Size = New System.Drawing.Size(587, 281)
        Me.GBList.TabIndex = 19
        Me.GBList.TabStop = False
        '
        'RTBBookID
        '
        Me.RTBBookID.BackColor = System.Drawing.SystemColors.Window
        Me.RTBBookID.Location = New System.Drawing.Point(9, 15)
        Me.RTBBookID.Name = "RTBBookID"
        Me.RTBBookID.Size = New System.Drawing.Size(86, 260)
        Me.RTBBookID.TabIndex = 18
        Me.RTBBookID.Text = ""
        '
        'LblListBI
        '
        Me.LblListBI.AutoSize = True
        Me.LblListBI.Location = New System.Drawing.Point(24, -1)
        Me.LblListBI.Name = "LblListBI"
        Me.LblListBI.Size = New System.Drawing.Size(46, 13)
        Me.LblListBI.TabIndex = 19
        Me.LblListBI.Text = "Book ID"
        '
        'LblListP
        '
        Me.LblListP.AutoSize = True
        Me.LblListP.Location = New System.Drawing.Point(517, -1)
        Me.LblListP.Name = "LblListP"
        Me.LblListP.Size = New System.Drawing.Size(31, 13)
        Me.LblListP.TabIndex = 15
        Me.LblListP.Text = "Price"
        '
        'RTBBookName
        '
        Me.RTBBookName.Location = New System.Drawing.Point(101, 15)
        Me.RTBBookName.Name = "RTBBookName"
        Me.RTBBookName.Size = New System.Drawing.Size(126, 260)
        Me.RTBBookName.TabIndex = 8
        Me.RTBBookName.Text = ""
        '
        'LblListC
        '
        Me.LblListC.AutoSize = True
        Me.LblListC.Location = New System.Drawing.Point(408, -1)
        Me.LblListC.Name = "LblListC"
        Me.LblListC.Size = New System.Drawing.Size(51, 13)
        Me.LblListC.TabIndex = 14
        Me.LblListC.Text = "Company"
        '
        'RTBAuthorName
        '
        Me.RTBAuthorName.Location = New System.Drawing.Point(236, 15)
        Me.RTBAuthorName.Name = "RTBAuthorName"
        Me.RTBAuthorName.Size = New System.Drawing.Size(129, 260)
        Me.RTBAuthorName.TabIndex = 9
        Me.RTBAuthorName.Text = ""
        '
        'LblListAN
        '
        Me.LblListAN.AutoSize = True
        Me.LblListAN.Location = New System.Drawing.Point(269, -1)
        Me.LblListAN.Name = "LblListAN"
        Me.LblListAN.Size = New System.Drawing.Size(69, 13)
        Me.LblListAN.TabIndex = 13
        Me.LblListAN.Text = "Author Name"
        '
        'RTBCompany
        '
        Me.RTBCompany.Location = New System.Drawing.Point(371, 15)
        Me.RTBCompany.Name = "RTBCompany"
        Me.RTBCompany.Size = New System.Drawing.Size(128, 260)
        Me.RTBCompany.TabIndex = 10
        Me.RTBCompany.Text = ""
        '
        'LblListBN
        '
        Me.LblListBN.AutoSize = True
        Me.LblListBN.Location = New System.Drawing.Point(141, -1)
        Me.LblListBN.Name = "LblListBN"
        Me.LblListBN.Size = New System.Drawing.Size(63, 13)
        Me.LblListBN.TabIndex = 12
        Me.LblListBN.Text = "Book Name"
        '
        'RTBPrice
        '
        Me.RTBPrice.Location = New System.Drawing.Point(509, 15)
        Me.RTBPrice.Name = "RTBPrice"
        Me.RTBPrice.Size = New System.Drawing.Size(69, 260)
        Me.RTBPrice.TabIndex = 11
        Me.RTBPrice.Text = ""
        '
        'FrmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 340)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnClearList)
        Me.Controls.Add(Me.GBList)
        Me.Name = "FrmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result"
        Me.GBList.ResumeLayout(False)
        Me.GBList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnClearList As Button
    Friend WithEvents GBList As GroupBox
    Friend WithEvents RTBBookID As RichTextBox
    Friend WithEvents LblListBI As Label
    Friend WithEvents LblListP As Label
    Friend WithEvents RTBBookName As RichTextBox
    Friend WithEvents LblListC As Label
    Friend WithEvents RTBAuthorName As RichTextBox
    Friend WithEvents LblListAN As Label
    Friend WithEvents RTBCompany As RichTextBox
    Friend WithEvents LblListBN As Label
    Friend WithEvents RTBPrice As RichTextBox
End Class
