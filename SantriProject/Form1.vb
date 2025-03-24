Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConnection_Click(sender As Object, e As EventArgs) Handles BtnConn.Click
        If (dbConnect()) Then
            conn.Open()

            MsgBox("Database Connected!!", vbInformation)
        Else
            MsgBox("Database Not Connected!!", vbCritical)
        End If

        conn.Close()
    End Sub
End Class
