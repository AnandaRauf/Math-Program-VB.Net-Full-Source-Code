Public Class LuasSegitigaSikuSiku
    Private Sub HasilButSgtSkSk_Click(sender As Object, e As EventArgs) Handles HasilButSgtSkSk.Click
        If AlasSgtSkSkBox.Text = "" Or TinggiSgtSkSkBox.Text = "" Then
            MsgBox("Maaf Alas, Dan Tinggi Belum Diisi ! ", MsgBoxStyle.Critical, "Data Kosong")
            AlasSgtSkSkBox.Focus()
        Else
            MessageBox.Show("Penghitungan Selesai, Silahkan Melihat Hasil !")
        End If

        Dim alassegitigasikusiku, tinggisegitigasikusiku, hasilluas As Integer
        alassegitigasikusiku = AlasSgtSkSkBox.Text
        tinggisegitigasikusiku = TinggiSgtSkSkBox.Text
        hasilluas = alassegitigasikusiku * tinggisegitigasikusiku / 2
        HslLuasSgtSkSkBox.Text = hasilluas
    End Sub

    Private Sub DltDtSgtSKSKBut_Click(sender As Object, e As EventArgs) Handles DltDtSgtSKSKBut.Click
        MsgBox("Anda yakin ingin menghapus data ?", vbQuestion + vbYesNo, "Konfirmasi")
        AlasSgtSkSkBox.Text = ""
        TinggiSgtSkSkBox.Text = ""
        HslLuasSgtSkSkBox.Text = ""
        MsgBox("Data Berhasil Dihapus !", vbInformation)
    End Sub

    Private Sub QtButSgtSKSK_Click(sender As Object, e As EventArgs) Handles QtButSgtSKSK.Click
        MsgBox("Anda yakin ingin keluar ?", vbQuestion + vbYesNo, "Konfirmasi")

        Close()
    End Sub
End Class