Public Class LuasPersegiEmpat
    Private Sub HslButPrsg_Click(sender As Object, e As EventArgs) Handles HslButPrsg.Click
        If SSPrsgBox.Text = "" Then
            MsgBox("Maaf Data Sisi Persegi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            SSPrsgBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim sisipersegi, hasilluaspersegi As Integer
        sisipersegi = SSPrsgBox.Text
        hasilluaspersegi = sisipersegi * sisipersegi
        HslLsPrsgBox.Text = hasilluaspersegi
    End Sub

    Private Sub DelPrsgBut_Click(sender As Object, e As EventArgs) Handles DelPrsgBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        SSPrsgBox.Text = ""
        HslLsPrsgBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtPrsgBut_Click(sender As Object, e As EventArgs) Handles QtPrsgBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class