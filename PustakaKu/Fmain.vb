Public Class Fmain
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        fbuku.Show()

    End Sub

    Private Sub Fmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub

    Private Sub PeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamToolStripMenuItem.Click
        FPeminjam.Show()
    End Sub

End Class