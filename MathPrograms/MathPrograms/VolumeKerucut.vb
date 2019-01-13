Public Class VolumeKerucut
    Private Sub HslBlkBut_Click(sender As Object, e As EventArgs) Handles HslKrctBut.Click
        If PhiKrctBox.Text = "" Or rJariJariKrctBox.Text = "" Or tTinggiKrctBox.Text = "" Then
            MsgBox("Maaf Data Sisi Persegi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PhiKrctBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim rjarijarikerucut, tTinggikerucut, hasilvolumekerucut As Integer
        Dim phikerucut As Decimal
        phikerucut = PhiKrctBox.Text
        rjarijarikerucut = rJariJariKrctBox.Text
        tTinggikerucut = tTinggiKrctBox.Text
        hasilvolumekerucut = 1 / 3 * phikerucut * rjarijarikerucut * rjarijarikerucut * tTinggikerucut
        HslVlKrctBox.Text = hasilvolumekerucut

    End Sub

    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelKrctBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PhiKrctBox.Text = ""
        rJariJariKrctBox.Text = ""
        tTinggiKrctBox.Text = ""
        HslVlKrctBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtKrctBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class