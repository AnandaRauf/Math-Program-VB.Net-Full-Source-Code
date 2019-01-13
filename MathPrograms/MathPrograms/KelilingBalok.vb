Public Class KelilingBalok
    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtBlkBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelBlkBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PngBlkBox.Text = ""
        LbrBlkBox.Text = ""
        TngBlkBox.Text = ""
        HslKlBlkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub HslBlkBut_Click(sender As Object, e As EventArgs) Handles HslBlkBut.Click
        If PngBlkBox.Text = "" Or LbrBlkBox.Text = "" Or TngBlkBox.Text = "" Then
            MsgBox("Maaf Data Panjang, Lebar, Dan Tinggi Belum Diisi !", MsgBoxStyle.Critical, "Data Kosong")
            PngBlkBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If

        Dim panjangbalok, lebarbalok, tinggibalok, hasilkelilingbalok As Integer
        panjangbalok = PngBlkBox.Text
        lebarbalok = LbrBlkBox.Text
        tinggibalok = TngBlkBox.Text
        hasilkelilingbalok = 4 * panjangbalok + lebarbalok + tinggibalok
        HslKlBlkBox.Text = hasilkelilingbalok

    End Sub
End Class