Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports System.Data

Public Class index
    Private dataTable As DataTable

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            ' Pastikan koneksi tertutup sebelum dibuka
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Query untuk mengambil data dari tabel users
            Dim query As String = "SELECT id, nama, nama_pengguna, email, jenis_kelamin, tanggal_lahir, alamat FROM users"
            Dim adapter As New MySqlDataAdapter(query, conn)

            dataTable = New DataTable()
            adapter.Fill(dataTable)

            ' Tampilkan di DataGridView
            dataGridView.DataSource = dataTable

            ' Menambahkan tombol Edit dan Delete di dalam DataGridView
            If dataGridView.Columns.Contains("Aksi") = False Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                dataGridView.Columns.Add(editButton)

                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Delete"
                deleteButton.HeaderText = "Delete"
                deleteButton.Text = "Delete"
                deleteButton.UseColumnTextForButtonValue = True
                dataGridView.Columns.Add(deleteButton)
            End If

            ' Konfigurasi tampilan DataGridView
            dataGridView.ReadOnly = True
            dataGridView.RowHeadersVisible = False
            dataGridView.AllowUserToAddRows = False
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor
            AddHandler dataGridView.MouseClick, AddressOf DeselectRowOnEmptyClick
            AddHandler dataGridView.CellClick, AddressOf DataGridView_CellClick

            ' Tutup koneksi setelah selesai
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Fungsi pencarian data berdasarkan Nama atau Email
    Private Sub SearchData(sender As Object, e As EventArgs)
        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = String.Format("nama LIKE '%{0}%' OR email LIKE '%{0}%'", txtSearch.Text)
        End If
    End Sub

    ' Menghapus seleksi jika klik di area kosong
    Private Sub DeselectRowOnEmptyClick(sender As Object, e As MouseEventArgs)
        Dim hit As DataGridView.HitTestInfo = dataGridView.HitTest(e.X, e.Y)
        If hit.RowIndex = -1 Then ' Jika klik di luar baris data
            dataGridView.ClearSelection()
        End If
    End Sub

    ' Menangani klik tombol Edit dan Delete
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dataGridView.Rows(e.RowIndex)
            Dim userId As Integer = selectedRow.Cells("id").Value

            If e.ColumnIndex = dataGridView.Columns("Edit").Index Then
                ' Aksi Edit
                Dim updateForm As New Update(userId)
                updateForm.ShowDialog()
                LoadData()
            ElseIf e.ColumnIndex = dataGridView.Columns("Delete").Index Then
                ' Aksi Delete
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    DeleteUser(userId)
                    LoadData()
                End If
            End If
        End If
    End Sub

    ' Fungsi untuk menghapus pengguna dari database
    Private Sub DeleteUser(userId As Integer)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "DELETE FROM users WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userId)
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
