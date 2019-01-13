Public Class Anutias
    Private Sub QtButAnu_Click(sender As Object, e As EventArgs) Handles QtButAnu.Click

        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub

    Private Sub TotButAnu_Click(sender As Object, e As EventArgs) Handles TotButAnu.Click
        If HrgBAnuBox.Text = "" Or DpBrngAnuBox.Text = "" Or BngBrngBox.Text = "" Then
            MsgBox("Maaf Data Harga Barang,Dp Barang, Dan Bunga Barang Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            HrgBAnuBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim hargabarang, dpbarang, sisacicilanbarang, bungabarang, jumlahbungabarang, totaltagihanbarang As Integer
        hargabarang = HrgBAnuBox.Text
        dpbarang = DpBrngAnuBox.Text
        bungabarang = BngBrngBox.Text
        sisacicilanbarang = hargabarang - dpbarang
        SisaClnBAnuBox.Text = sisacicilanbarang
        jumlahbungabarang = sisacicilanbarang * bungabarang / 100
        JmlhBngAnuBox.Text = jumlahbungabarang
        totaltagihanbarang = jumlahbungabarang + sisacicilanbarang
        TotTagAnuBox.Text = totaltagihanbarang
        TagBuAnuBox.Text = totaltagihanbarang
        TokAnuBox.Text = sisacicilanbarang + jumlahbungabarang + totaltagihanbarang


    End Sub

    Private Sub DelButAnu_Click(sender As Object, e As EventArgs) Handles DelButAnu.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        HrgBAnuBox.Text = ""
        DpBrngAnuBox.Text = ""
        SisaClnBAnuBox.Text = ""
        JmlhBngAnuBox.Text = ""
        TotTagAnuBox.Text = ""
        TagBuAnuBox.Text = ""
        TokAnuBox.Text = ""
        JmlhBngAnuBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub
End Class