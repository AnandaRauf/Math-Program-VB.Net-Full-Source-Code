Imports System.Data.SqlClient
Module Sql_Server_2014_Connect
    Public koneksiSQL As SqlConnection

    Sub konekdatabase()
        Try
            koneksiSQL = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Penting\Math Programs VBNET\DB SQL Server\db_math.mdf;Integrated Security=True;Connect Timeout=30")
            koneksiSQL.Open()
        Catch ex As Exception
            MsgBox("Maaf, anda tidak terhung dengan server !", MsgBoxStyle.Critical, “Gagal koneksi server !”)
        End Try
    End Sub
    Public Sub jalankansql(ByVal sql As String)
        Dim SQLCmd As New SqlCommand
        konekdatabase()
        Try
            SQLCmd.Connection = koneksiSQL
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sql
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            koneksiSQL.Close()

            MsgBox("Data  anda berhasil disimpan ke database", vbInformation)
        Catch ex As Exception
            MsgBox("Maaf, data anda tidak berhasil disimpan ke database " + "Data ke server database" & ex.Message)
        End Try
    End Sub
End Module
