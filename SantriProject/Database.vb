Imports MySql.Data.MySqlClient


Module Database

    Public conn As New MySqlConnection()
    Dim status As Boolean = False

    Public i As Integer

    Dim connString = "server=localhost;database=example;user=root;password="

    Public Function dbConnect() As Boolean

        If (conn.State = ConnectionState.Closed) Then
            conn.ConnectionString = connString

            status = True
        End If

        Return status
    End Function

End Module
