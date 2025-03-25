<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        txtNama = New TextBox()
        txtUsername = New TextBox()
        txtEMail = New TextBox()
        txtPassword = New TextBox()
        btnRegister = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(162, 209)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(162, 266)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtEMail
        ' 
        txtEMail.Location = New Point(162, 325)
        txtEMail.Name = "txtEMail"
        txtEMail.Size = New Size(100, 23)
        txtEMail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(162, 388)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 3
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(407, 349)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Daftar"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(162, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(162, 307)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 8
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(162, 370)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(txtEMail)
        Controls.Add(txtUsername)
        Controls.Add(txtNama)
        Name = "Register"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
