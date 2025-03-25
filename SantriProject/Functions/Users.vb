Imports MySql.Data.MySqlClient

Public Class Users
    ' Koneksi ke database MySQL
    'Private Shared conn As New MySqlConnection("server=localhost;userid=root;password=;database=mydatabase")

    ' 🔹 Fungsi untuk mendapatkan semua user
    Public Shared Function GetUsers() As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT id, nama_pengguna, email FROM users"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    ' 🔹 Fungsi untuk menambahkan user
    Public Shared Sub AddUser(username As String, email As String, password As String)
        Try
            conn.Open()
            Dim query As String = "INSERT INTO users (nama_pengguna, email, kata_sandi) VALUES (@username, @email, SHA2(@password, 256))"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' 🔹 Fungsi untuk menghapus user
    Public Shared Sub DeleteUser(userId As Integer)
        Try
            conn.Open()
            Dim query As String = "DELETE FROM users WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userId)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' 🔹 Fungsi untuk mengupdate user
    Public Shared Sub UpdateUser(userId As Integer, username As String, email As String)
        Try
            conn.Open()
            Dim query As String = "UPDATE users SET nama_pengguna = @username, email = @email WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userId)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
