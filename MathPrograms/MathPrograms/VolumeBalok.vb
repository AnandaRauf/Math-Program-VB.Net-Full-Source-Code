Public Class VolumeBalok
    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtBlkBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelBlkBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PnjgBlkBox.Text = ""
        LbrBlkBox.Text = ""
        TngBlkBox.Text = ""
        HslVlBlkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub HslButBlk_Click(sender As Object, e As EventArgs) Handles HslButBlk.Click
        If PnjgBlkBox.Text = "" Or LbrBlkBox.Text = "" Or TngBlkBox.Text = "" Then
            MsgBox("Maaf Data Panjang, Lebar, Dan Tinggi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PnjgBlkBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If

        Dim panjangbalok, lebarbalok, tinggibalok, hasilvolumebalok As Integer
        panjangbalok = PnjgBlkBox.Text
        lebarbalok = LbrBlkBox.Text
        tinggibalok = TngBlkBox.Text
        hasilvolumebalok = panjangbalok * lebarbalok * tinggibalok
        HslVlBlkBox.Text = hasilvolumebalok
    End Sub
End Class