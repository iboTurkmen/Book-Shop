<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBUserName = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(120, 81)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(153, 20)
        Me.TBPassword.TabIndex = 7
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'TBUserName
        '
        Me.TBUserName.Location = New System.Drawing.Point(120, 51)
        Me.TBUserName.Name = "TBUserName"
        Me.TBUserName.Size = New System.Drawing.Size(153, 20)
        Me.TBUserName.TabIndex = 6
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(39, 84)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 5
        Me.LblPassword.Text = "Password"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(39, 54)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(60, 13)
        Me.LblUserName.TabIndex = 4
        Me.LblUserName.Text = "User Name"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(42, 131)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 8
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(123, 131)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.BtnSignUp.TabIndex = 9
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(204, 131)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 198)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBUserName)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUserName)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBUserName As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents BtnExit As Button
End Class
