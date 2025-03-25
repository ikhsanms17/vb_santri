<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        SplitContainer1 = New SplitContainer()
        PictureBox1 = New PictureBox()
        BtnLogin = New Button()
        TxtPassword = New TextBox()
        TxtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblRegister = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(12, 12)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        SplitContainer1.Panel2.Controls.Add(lblRegister)
        SplitContainer1.Panel2.Controls.Add(BtnLogin)
        SplitContainer1.Panel2.Controls.Add(TxtPassword)
        SplitContainer1.Panel2.Controls.Add(TxtUsername)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Size = New Size(1256, 696)
        SplitContainer1.SplitterDistance = 519
        SplitContainer1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(513, 690)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Green
        BtnLogin.Font = New Font("SansSerif", 15F, FontStyle.Bold)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(323, 556)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(86, 39)
        BtnLogin.TabIndex = 7
        BtnLogin.Text = "Masuk"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("SansSerif", 15F)
        TxtPassword.Location = New Point(191, 428)
        TxtPassword.Multiline = True
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(351, 48)
        TxtPassword.TabIndex = 6
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TxtUsername.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtUsername.Font = New Font("SansSerif", 15F, FontStyle.Bold)
        TxtUsername.Location = New Point(191, 320)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.PlaceholderText = "Username"
        TxtUsername.Size = New Size(351, 48)
        TxtUsername.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SansSerif", 20F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(191, 394)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 31)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SansSerif", 20F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(191, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 31)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SansSerif", 30F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(162, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(408, 47)
        Label1.TabIndex = 2
        Label1.Text = "SELAMAT DATANG!"
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.Location = New Point(191, 494)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(49, 15)
        lblRegister.TabIndex = 8
        lblRegister.Text = "Register"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "LoginForm"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents lblRegister As Label

End Class
