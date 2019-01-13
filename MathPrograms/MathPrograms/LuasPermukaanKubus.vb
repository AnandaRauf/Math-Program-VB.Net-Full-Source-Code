Public Class LuasPermukaanKubus
    Private Sub HslBut_Click(sender As Object, e As EventArgs) Handles HslBut.Click
        If SSKbsBox.Text = "" Then
            MsgBox("Maaf Data Sisi Persegi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            SSKbsBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If
        Dim sisikubus, hasilpermukaankubus As Integer
        sisikubus = SSKbsBox.Text
        hasilpermukaankubus = 6 * sisikubus * sisikubus
        HslPrmknKbsBox.Text = hasilpermukaankubus
    End Sub

    Private Sub DelBut_Click(sender As Object, e As EventArgs) Handles DelBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        SSKbsBox.Text = ""
        HslPrmknKbsBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtBut_Click(sender As Object, e As EventArgs) Handles QtBut.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class