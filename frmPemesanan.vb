Imports MySql.Data.MySqlClient
Imports MySqlConnector.MySqlCommand

Imports Mysqlx.XDevAPI.Common
Public Class frmPemesanan

    Sub DisabledForm()

        '
        txtbMenu.Enabled = False
        txtbItem.Enabled = False
        txtbHarga.Enabled = False
        txtbStock.Enabled = False
    End Sub


    'hitung total harga
    Sub HitungTotal()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In dgKeranjang.Rows
            total += CInt(row.Cells(4).Value)
        Next

        txtbTotal.Text = total.ToString()
    End Sub

    'auto generate id pemesanan dll
    Sub GenerateIdPesanan()
        Try
            OpenKoneksi()

            Dim cmd As New MySqlCommand("SELECT id_pemesanan FROM pemesanan ORDER BY id_pemesanan DESC LIMIT 1", conn)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim lastId As String = result.ToString()
                Dim number As Integer = CInt(lastId.Substring(2)) + 1
                txtbidpemesanan.Text = "PS" & number.ToString("D3")
            Else
                txtbidpemesanan.Text = "PS001"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseKoneksi()
        End Try
    End Sub

    'buat mode
    Dim mode As String '  WAJIB

    Sub ClearForm()

        'Keterangan 
        txtbMenu.Text = ""
        txtbItem.Text = ""
        txtbHarga.Text = ""
        txtbStock.Text = ""
        btnKirim.Enabled = False

        'Pemesanan
        cboJenis.Text = ""
        txtbidpemesanan.Text = ""
        txtbJumlah.Text = ""
        txtbTotal.Text = ""
    End Sub

    Sub TampilData()
        Try
            OpenKoneksi()

            Dim da As New MySqlDataAdapter("SELECT * FROM list_menu", conn)
            Dim dt As New DataTable
            da.Fill(dt)

            dgMenu.DataSource = dt

            CloseKoneksi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnKeluarPemesanan_Click(sender As Object, e As EventArgs)
        Close()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMenu.CellContentClick
        TampilData()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtbJumlah.Text = "" Then
            MessageBox.Show("Jumlah kosong!")
            Exit Sub
        End If

        Dim jumlah As Integer = txtbJumlah.Text
        Dim harga As Integer = txtbHarga.Text
        Dim subtotal = jumlah * harga

        dgKeranjang.Rows.Add(
            txtbMenu.Text,
            harga,
            jumlah,
            subtotal
        )

        HitungTotal()
    End Sub

    Private Sub frmPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisabledForm()

        txtbJumlah.Enabled = False
        cboJenis.Enabled = False
        txtbidpemesanan.Enabled = False
        dtPemesanan.Enabled = False
        txtbTotal.Enabled = False

        cboJenis.Items.Add("Makanan")
        cboJenis.Items.Add("Minuman")
        cboJenis.Items.Add("Snack")

        TampilData()

        ' setup dgKeranjang
        dgKeranjang.Columns.Add("id_menu", "ID Menu")
        dgKeranjang.Columns.Add("nama", "Nama")
        dgKeranjang.Columns.Add("harga", "Harga")
        dgKeranjang.Columns.Add("jumlah", "Jumlah")
        dgKeranjang.Columns.Add("subtotal", "Subtotal")

        dgKeranjang.AllowUserToAddRows = False
    End Sub

    Private Sub cboPilihMenu_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbHarga_TextChanged(sender As Object, e As EventArgs) Handles txtbHarga.TextChanged

    End Sub

    Private Sub dgBawah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMenu.CellClick
        Try
            'start dari 0 yaitu id_menu
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgMenu.Rows(e.RowIndex)

                'menampilkan data di combo box dan textbox saat di klik pada datagridview
                txtbMenu.Text = row.Cells(0).Value.ToString()
                txtbItem.Text = row.Cells(2).Value.ToString()
                txtbHarga.Text = row.Cells(3).Value.ToString()
                txtbStock.Text = row.Cells(4).Value.ToString()

                ' Aktifin tombol edit & hapus
                btnKirim.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenis.SelectedIndexChanged
        Try
            OpenKoneksi()

            Dim query As String = "SELECT * FROM list_menu WHERE jenis='" & cboJenis.Text & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            dgMenu.DataSource = dt

            CloseKoneksi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        GenerateIdPesanan()
        dtPemesanan.Value = DateTime.Now
        txtbTotal.Text = ""

        dtPemesanan.Enabled = True
        txtbJumlah.Enabled = True
        cboJenis.Enabled = True
        txtbTotal.Enabled = False
        txtbidpemesanan.Enabled = True





        dgKeranjang.Rows.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnKirim.Click

        Try
            If conn.State = ConnectionState.Closed Then OpenKoneksi()

            ' VALIDASI SEDERHANA
            If txtbidpemesanan.Text = "" Then
                MessageBox.Show("Klik ADD dulu!")
                Exit Sub
            End If

            If dgKeranjang.Rows.Count = 0 Then
                MessageBox.Show("Keranjang kosong!")
                Exit Sub
            End If

            ' =========================
            ' 1. SIMPAN KE PEMESANAN
            ' =========================
            Dim cmd1 As New MySqlCommand("INSERT INTO pemesanan (id_pemesanan, tanggal, total) VALUES (@id, @tgl, @total)", conn)

            cmd1.Parameters.AddWithValue("@id", txtbidpemesanan.Text)
            cmd1.Parameters.AddWithValue("@tgl", dtPemesanan.Value)
            cmd1.Parameters.AddWithValue("@total", Val(txtbTotal.Text))

            cmd1.ExecuteNonQuery()

            ' =========================
            ' 2. SIMPAN KE DETAIL
            ' =========================
            For Each row As DataGridViewRow In dgKeranjang.Rows

                If Not row.IsNewRow Then
                    Dim cmd2 As New MySqlCommand("INSERT INTO detail_pemesanan (id_pemesanan, id_menu, jumlah, subtotal) VALUES (@idp, @idm, @jml, @sub)", conn)

                    cmd2.Parameters.AddWithValue("@idp", txtbidpemesanan.Text)
                    cmd2.Parameters.AddWithValue("@idm", row.Cells(0).Value.ToString())
                    cmd2.Parameters.AddWithValue("@jml", Val(row.Cells(2).Value))
                    cmd2.Parameters.AddWithValue("@sub", Val(row.Cells(3).Value))

                    cmd2.ExecuteNonQuery()
                End If

            Next

            MessageBox.Show("Transaksi berhasil!")

            CloseKoneksi()

            ' RESET
            dgKeranjang.Rows.Clear()
            txtbTotal.Text = "0"
            txtbidpemesanan.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click


        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau batal?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ClearForm()

        End If
    End Sub

    Private Sub txtbJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtbJumlah.TextChanged
        Try
            If txtbHarga.Text <> "" And txtbJumlah.Text <> "" Then
                Dim harga As Integer = Val(txtbHarga.Text)
                Dim jumlah As Integer = Val(txtbJumlah.Text)

                txtbTotal.Text = (harga * jumlah).ToString()
            Else
                txtbTotal.Text = ""
            End If
        Catch ex As Exception
            txtbTotal.Text = ""
        End Try
    End Sub

    Private Sub dtPemesanan_ValueChanged(sender As Object, e As EventArgs) Handles dtPemesanan.ValueChanged

    End Sub
End Class