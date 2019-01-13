Public Class KelilingSegitigaSikuSiku
    Private Sub HasilButSgtSkSk_Click(sender As Object, e As EventArgs) Handles HasilButSgtSkSk.Click
        If SSPrtmSgtSkSkBox.Text = "" Or SSKduaSgtSkSkBox.Text = "" Or SSKtgSgtSkSkBox.Text = "" Then
            MsgBox("Maaf Sisi Pertama, Sisi Kedua, Dan Sisi Ketiga Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            SSPrtmSgtSkSkBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim sisipertama, sisikedua, sisiketiga, hasilkelilingsegitigasikusiku As Integer
        sisipertama = SSPrtmSgtSkSkBox.Text
        sisikedua = SSKduaSgtSkSkBox.Text
        sisiketiga = SSKtgSgtSkSkBox.Text
        hasilkelilingsegitigasikusiku = sisipertama + sisikedua + sisiketiga
        HslKllngSgtSkSkBox.Text = hasilkelilingsegitigasikusiku
    End Sub

    Private Sub DltDtSgtSKSKBut_Click(sender As Object, e As EventArgs) Handles DltDtSgtSKSKBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        SSPrtmSgtSkSkBox.Text = ""
        SSKduaSgtSkSkBox.Text = ""
        SSKtgSgtSkSkBox.Text = ""
        HslKllngSgtSkSkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)

    End Sub


    Private Sub QtButSgtSKSK_Click(sender As Object, e As EventArgs) Handles QtButSgtSKSK.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class