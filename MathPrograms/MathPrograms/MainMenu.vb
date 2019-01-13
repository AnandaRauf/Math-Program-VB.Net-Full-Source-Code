Public Class MainMenu
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        MsgBox("Are you sure exit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub

    Private Sub AboutAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Powered  By PT.Tech Media Development")
        MessageBox.Show("Developed Date: 06 January 2019")
    End Sub

    Private Sub AnutiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnutiasToolStripMenuItem.Click
        Anutias.Show()
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.Instagram.com/tmd.indo")
    End Sub

    Private Sub FacebookCompanyPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookCompanyPageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/tmd.indo/")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBugToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=6283879627956&text=Hai,%20Owner%20PT.TechMediaDevelopment%20Terhormat,%20Saya%20Menemukan%20Bug%20Di%20Aplikasi%20Dekstop%20Anda%20")
    End Sub

    Private Sub BarisanAritmatikaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarisanAritmatikaToolStripMenuItem.Click
        BarisanAritmatika.Show()
    End Sub

    Private Sub AddNewFiturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewFiturToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=6283879627956&text=Hai,%20Owner%20PT.TechMediaDevelopment%20Terhormat,%20Boleh%20Tambahkan%20Fitur%20Di%20MathProgram%20Tidak%20?%20")
    End Sub

    Private Sub SisipanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SisipanToolStripMenuItem.Click
        SisipanBarisanAritmatika.Show()
    End Sub

    Private Sub KelilingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelilingToolStripMenuItem.Click
        KelilingSegitigaSikuSiku.Show()
    End Sub

    Private Sub LuasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasToolStripMenuItem.Click
        LuasSegitigaSikuSiku.Show()
    End Sub

    Private Sub KelilingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KelilingToolStripMenuItem1.Click
        KelilingBalok.Show()
    End Sub

    Private Sub LuasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LuasToolStripMenuItem1.Click
        LuasBalok.Show()
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        VolumeBalok.Show()
    End Sub

    Private Sub KelilingToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles KelilingToolStripMenuItem2.Click
        KelilingPersegiPanjang.Show()
    End Sub

    Private Sub LuasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LuasToolStripMenuItem2.Click
        LuasPersegiPanjang.Show()
    End Sub

    Private Sub LuasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles LuasToolStripMenuItem3.Click
        LuasPersegiEmpat.Show()
    End Sub
    Private Sub KelilingToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles KelilingToolStripMenuItem3.Click
        KelilingPersegiEmpat.Show()
    End Sub

    Private Sub VolumeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem1.Click
        VolumeKerucut.Show()
    End Sub

    Private Sub LuasAlasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasAlasToolStripMenuItem.Click
        LuasAlasKerucut.Show()
    End Sub

    Private Sub LuasPermukaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasPermukaanToolStripMenuItem.Click
        LuasPermukaanKerucut.Show()
    End Sub

    Private Sub SelimutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelimutToolStripMenuItem.Click
        LuasSelimutKerucut.Show()
    End Sub

    Private Sub VolumeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem2.Click
        VolumeKubus.Show()
    End Sub

    Private Sub KelilingToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles KelilingToolStripMenuItem4.Click
        KelilingKubus.Show()
    End Sub
End Class