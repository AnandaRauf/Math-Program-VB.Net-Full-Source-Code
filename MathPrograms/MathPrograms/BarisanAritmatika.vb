Public Class BarisanAritmatika
    Private Sub DelButBAR_Click(sender As Object, e As EventArgs) Handles DelButBAR.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        UAWALBOX.Text = ""
        UAKHIRBOX.Text = ""
        UTENGAHBOX.Text = ""
        HslBARBOX.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtButBAR_Click(sender As Object, e As EventArgs) Handles QtButBAR.Click

        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub HasilButBAR_Click(sender As Object, e As EventArgs) Handles HasilButBAR.Click

        If UAWALBOX.Text = "" Or UAKHIRBOX.Text = "" Then
            MsgBox("Maaf Data Harga Barang,Dp Barang, Dan Bunga Barang Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            UAWALBOX.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim uawal, uakhir, utengah, hasil As Integer
        uawal = UAWALBOX.Text
        uakhir = UAKHIRBOX.Text
        utengah = uawal + uakhir
        UTENGAHBOX.Text = utengah
        hasil = utengah / 2
        HslBARBOX.Text = hasil
    End Sub
End Class