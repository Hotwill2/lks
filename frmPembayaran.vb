Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient
Imports MySqlConnector.MySqlCommand

Public Class frmPembayaran

    'clear form
    Sub ClearForm()
        txtbIdPemesanan.Text = ""
        txtbTotal.Text = ""
        txtbUangBayar.Text = ""
        txtbKembalian.Text = ""
        txtbRingkasan.Text = ""
    End Sub



    'load data pembayaran
    Sub LoadDataPembayaran()


        Try
            OpenKoneksi()

            ' reset tampilan
            txtbRingkasan.Text = "Pesanan:" & vbCrLf
            Dim total As Integer = 0

            ' query ambil data
            Dim query As String = "SELECT d.jumlah, m.harga 
                               FROM detail_pemesanan d
                               JOIN list_menu m ON d.id_menu = m.id_menu
                               WHERE d.id_pemesanan = @id"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtbIdPemesanan.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' looping data
            While reader.Read()
                Dim nama As String = reader("nama_menu").ToString()
                Dim jumlah As Integer = reader("jumlah")
                Dim harga As Integer = reader("harga")

                total += jumlah * harga

                txtbRingkasan.Text &= nama & " x" & jumlah & vbCrLf
            End While

            reader.Close()

            ' set total ke textbox
            txtbTotal.Text = total.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseKoneksi()
        End Try

    End Sub

    'buat mode
    Dim mode As String '  WAJIB

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        'if statement untuk validasi input
        If txtbKembalian.Text = "" Then
            MessageBox.Show("Hitung dulu!")
            Exit Sub
        End If

        Dim total As Integer = Val(txtbTotal.Text)
        Dim bayar As Integer = Val(txtbUangBayar.Text)

        If bayar < total Then
            MessageBox.Show("Uang kurang!")
            Exit Sub
        End If

        Try
            OpenKoneksi()

            Dim query As String = "INSERT INTO pembayaran 
                              (id_pemesanan, total_bayar, uang_bayar, kembalian)
                              VALUES (@id, @total, @bayar, @kembali)"

            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", txtbIdPemesanan.Text)
            cmd.Parameters.AddWithValue("@total", txtbTotal.Text)
            cmd.Parameters.AddWithValue("@bayar", txtbUangBayar.Text)
            cmd.Parameters.AddWithValue("@kembali", txtbKembalian.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Pembayaran berhasil!")

            ClearForm()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseKoneksi()
        End Try

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtbPemesanan_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataPembayaran()
    End Sub

    Private Sub txtbRingkasan_TextChanged(sender As Object, e As EventArgs) Handles txtbRingkasan.TextChanged

    End Sub

    Private Sub btnDataPesanan_Click(sender As Object, e As EventArgs) Handles btnDataPesanan.Click
        If txtbIdPemesanan.Text = "" Then
            MessageBox.Show("Masukkan ID Pemesanan dulu!")
            Exit Sub
        End If

        Try
            OpenKoneksi()

            txtbRingkasan.Text = "Pesanan:" & vbCrLf
            Dim total As Integer = 0

            Dim query As String = "SELECT id_menu, jumlah, subtotal 
                              FROM detail_pemesanan 
                              WHERE id_pemesanan = @id"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtbIdPemesanan.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If Not reader.HasRows Then
                MessageBox.Show("Data tidak ditemukan!")
            End If

            While reader.Read()
                Dim menu = reader("id_menu").ToString()
                Dim jumlah = reader("jumlah")
                Dim subtotal = reader("subtotal")

                total += subtotal

                txtbRingkasan.Text &= menu & " x" & jumlah & " = " & subtotal & vbCrLf
            End While

            reader.Close()

            txtbTotal.Text = total.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseKoneksi()
        End Try
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        'if statement untuk validasi input
        If txtbTotal.Text = "" Or txtbUangBayar.Text = "" Then
            MessageBox.Show("Isi total & uang bayar dulu!")
            Exit Sub
        End If

        Dim total As Integer = Val(txtbTotal.Text)
        Dim bayar As Integer = Val(txtbUangBayar.Text)

        'if statement untuk validasi uang bayar
        If bayar < total Then
            MessageBox.Show("Uang kurang!")
            Exit Sub
        End If

        Dim kembalian As Integer = bayar - total
        txtbKembalian.Text = kembalian.ToString()
    End Sub



    Private Sub txtbUangBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbUangBayar.KeyPress
        'validasi input hanya angka
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau Batal?", "Konfirmasi", MessageBoxButtons.OKCancel)
        If result Then
            ClearForm()
        End If

    End Sub
End Class