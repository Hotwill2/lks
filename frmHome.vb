Public Class frmHome

    Private Sub btnKeluarAplikasi_Click(sender As Object, e As EventArgs) Handles btnKeluarAplikasi.Click
        Dim close As DialogResult

        close = MessageBox.Show("Yakin Mau Keluar Aplikasi?", "Konfirmasi", MessageBoxButtons.OKCancel)
        If close Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'di buat dialog biar freeze
        Dim f As New frmMenu
        f.ShowDialog()
    End Sub

    Private Sub btnPemesanan_Click(sender As Object, e As EventArgs) Handles btnPemesanan.Click
        Dim f As New frmPemesanan
        f.ShowDialog()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        Dim f As New frmPembayaran
        f.ShowDialog()
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If roleuser = "user" Then
            Button1.Visible = False
            btnPembayaran.Visible = True
            btnPemesanan.Visible = True

        End If
    End Sub
End Class
