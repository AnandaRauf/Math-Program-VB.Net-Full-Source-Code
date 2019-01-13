Public Class SisipanBarisanAritmatika
    Private Sub HasilButSIBAR_Click(sender As Object, e As EventArgs) Handles HasilButSIBAR.Click
        If PSukuPertamaBOX.Text = "" Or ASukuTerakhirBOX.Text = "" Or SSisipanBox.Text = "" Or SkYgDcrBox.Text = "" Then
            MsgBox("Maaf Data P Suku Pertama,A Suku Terakhir, S Sisipan Dan Suku Yang Dicari Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PSukuPertamaBOX.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim sukupertama, sukuterakhir, sisipan, masukansukuyangakandicari, hasilmencarisuku As Integer
        sukupertama =
        PSukuPertamaBOX.Text = sukupertama
        sukuterakhir =
        ASukuTerakhirBOX.Text = sukuterakhir
        sisipan =
        SSisipanBox.Text = sisipan
        HslMncrBdSkBox.Text = sukupertama - sukuterakhir
        masukansukuyangakandicari =
        SkYgDcrBox.Text = masukansukuyangakandicari
        hasilmencarisuku = sukupertama + masukansukuyangakandicari - 1
        HsMncrSkBox.Text = hasilmencarisuku
    End Sub

    Private Sub DelButSIBAR_Click(sender As Object, e As EventArgs) Handles DelButSIBAR.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PSukuPertamaBOX.Text = ""
        ASukuTerakhirBOX.Text = ""
        SSisipanBox.Text = ""
        HslMncrBdSkBox.Text = ""
        SkYgDcrBox.Text = ""
        HsMncrSkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)

    End Sub

    Private Sub QtButSIBAR_Click(sender As Object, e As EventArgs) Handles QtButSIBAR.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class