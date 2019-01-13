Public Class LuasBalok
    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtBlkBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelBlkBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PnjgBlkBox.Text = ""
        LbrBlkBox.Text = ""
        TngBlkBox.Text = ""
        HslLsBlkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub HslButBlk_Click(sender As Object, e As EventArgs) Handles HslButBlk.Click
        If PnjgBlkBox.Text = "" Or LbrBlkBox.Text = "" Or TngBlkBox.Text = "" Then
            MsgBox("Maaf Data Panjang, Lebar, Dan Tinggi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PnjgBlkBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If

        Dim panjangbalok, lebarbalok, tinggibalok, hasilluasbalok As Integer
        panjangbalok = PnjgBlkBox.Text
        lebarbalok = LbrBlkBox.Text
        tinggibalok = TngBlkBox.Text
        hasilluasbalok = 2 * panjangbalok * lebarbalok + panjangbalok * tinggibalok + lebarbalok * tinggibalok
        HslLsBlkBox.Text = hasilluasbalok

    End Sub
End Class
