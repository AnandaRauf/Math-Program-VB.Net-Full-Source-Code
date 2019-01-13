Public Class LuasPermukaanKerucut
    Private Sub HslBlkBut_Click(sender As Object, e As EventArgs) Handles HslKrctBut.Click
        If PhiKrctBox.Text = "" Or rJariJariKrctBox.Text = "" Then
            MsgBox("Maaf Data Sisi Persegi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PhiKrctBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim rjarijarikerucut, sgarispelukiskerucut, hasilluaspermukaankerucut As Integer
        Dim phikerucut As Decimal
        phikerucut = PhiKrctBox.Text
        rjarijarikerucut = rJariJariKrctBox.Text
        sgarispelukiskerucut = SGRSPBOX.Text
        hasilluaspermukaankerucut = phikerucut * rjarijarikerucut * sgarispelukiskerucut + rjarijarikerucut
        HslLsPrmknKrctBox.Text = hasilluaspermukaankerucut
    End Sub

    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelKrctBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PhiKrctBox.Text = ""
        rJariJariKrctBox.Text = ""
        HslLsPrmknKrctBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtKrctBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class