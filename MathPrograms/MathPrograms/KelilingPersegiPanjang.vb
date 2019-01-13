Public Class KelilingPersegiPanjang
    Private Sub DelBlkBut_Click(sender As Object, e As EventArgs) Handles DelBlkBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        PnjgPrsgPnjngBox.Text = ""
        LbrPrsgPnjngBox.Text = ""
        HslPrsgPnjngBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtBlkBut_Click(sender As Object, e As EventArgs) Handles QtBlkBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub HslButBlk_Click(sender As Object, e As EventArgs) Handles HslButBlk.Click
        If PnjgPrsgPnjngBox.Text = "" Or LbrPrsgPnjngBox.Text = "" Then
            MsgBox("Maaf Data Panjang, Dan Lebar Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            PnjgPrsgPnjngBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If

        Dim panjangpersegi, lebarpersegi, hasilkelilingpersegipanjang As Integer
        panjangpersegi = PnjgPrsgPnjngBox.Text
        lebarpersegi = LbrPrsgPnjngBox.Text
        hasilkelilingpersegipanjang = 2 * panjangpersegi + lebarpersegi
        HslPrsgPnjngBox.Text = hasilkelilingpersegipanjang
    End Sub
End Class