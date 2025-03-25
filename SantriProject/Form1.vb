Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM users WHERE nama_pengguna=@username AND kata_sandi=SHA2(@password, 256)"
            Dim cmd As New MySqlCommand(query, conn)

            With cmd.Parameters
                .AddWithValue("@username", username.Trim())
                .AddWithValue("@password", password.Trim())
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Login Berhasil! Selamat Datang, " & reader("nama").ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Dim dashboard As New UserManagement()
                dashboard.Show()
            Else
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        Dim register As New Register()
        register.Show()
    End Sub
End Class
