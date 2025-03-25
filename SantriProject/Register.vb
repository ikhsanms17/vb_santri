Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim name As String = txtNama.Text
        Dim username As String = txtUsername.Text
        Dim email As String = txtEMail.Text
        Dim password As String = txtPassword.Text
        Dim i As Integer

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO `users` (`nama`,`nama_pengguna`,`email`,`kata_sandi`) VALUES (@name,@username,@email,@password)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil Disimpan", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal Disimpan", "Error_Register", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            Me.Hide()
            Dim login As New Form1()
            login.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class