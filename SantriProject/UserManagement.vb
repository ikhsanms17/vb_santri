Imports MySql.Data.MySqlClient

Public Class UserManagement
    Dim i As Integer
    Dim reader As MySqlDataReader

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub DGV_load()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                DataGridView1.Rows.Add(reader.Item("nama"), reader.Item("email"), reader.Item("nis"), reader.Item("kelas_id"), reader.Item("jenis_kelamin"), reader.Item("tanggal_lahir"), reader.Item("nama_ayah"), reader.Item("nama_ibu"), reader.Item("alamat"))
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DGV_load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class