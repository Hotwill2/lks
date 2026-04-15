Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Engines.SM2Engine

Public Class frmMenu
    Private Sub LoadPencarian()
        dgBawah.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgBawah.DataSource = TampilRecord("SELECT * FROM list_menu WHERE item LIKE '%" & txtbcari.Text & "%'")
        dgBawah.Columns("id_menu").HeaderText = "Id Item"
        dgBawah.Columns("jenis").HeaderText = "Jenis Item"
        dgBawah.Columns("harga").HeaderText = "Harga (Rp.)"
        dgBawah.Columns("stok").HeaderText = "Jumlah Tersedia)"
    End Sub

    Private Sub TampilkanChart()
        Try
            OpenKoneksi()
            chMenu.DataSource = TampilChart("SELECT item, harga FROM list_menu")

            ' Bersihkan chart
            chMenu.Series.Clear()
            chMenu.ChartAreas.Clear()

            ' Tambah Chart Area
            Dim chartArea As New ChartArea()
            chMenu.ChartAreas.Add(chartArea)

            ' Tambah Series
            Dim series As New Series("Data Item/List Menu")
            series.ChartType = SeriesChartType.Pie
            'series.ChartType = SeriesChartType.Column
            'series.ChartType = SeriesChartType.Line
            'series.ChartType = SeriesChartType.BoxPlot
            'series.ChartType = SeriesChartType.Pyramid
            'series.ChartType = SeriesChartType.Column

            ' Isi data ke chart
            For Each row As DataRow In datachart.Rows
                series.Points.AddXY(row("item").ToString(), Convert.ToInt32(row("harga")))
            Next

            chMenu.Series.Add(series)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseKoneksi()
        End Try
    End Sub

    'Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=lks")

    'buat mode
    Dim mode As String '  WAJIB
    Function GenerateIdMenu(prefix As String) As String
        Try
            OpenKoneksi()

            Dim query As String = "
            SELECT MAX(CAST(SUBSTRING(id_menu, LENGTH(@prefix)+1) AS UNSIGNED)) 
            FROM list_menu 
            WHERE id_menu LIKE @prefix"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@prefix", prefix & "%")

            Dim result = cmd.ExecuteScalar()

            Dim number As Integer = 1

            If result IsNot DBNull.Value Then
                number = CInt(result) + 1
            End If

            Return prefix & number.ToString("D3")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return ""
        Finally
            CloseKoneksi()
        End Try
    End Function


    'fuction reset form
    Sub ResetForm()
        ' Kosongin input
        txtbIdMenu.Text = ""
        cboJenisMakanan.Text = ""
        txtbItem.Text = ""
        txtHarga.Text = ""
        txtStock.Text = ""

    End Sub

    Sub DisableInput()

        ' Disable input
        txtbIdMenu.Enabled = False
        cboJenisMakanan.Enabled = False
        txtbItem.Enabled = False
        txtHarga.Enabled = False
        txtStock.Enabled = False

    End Sub

    Sub ResetTombol()

        ' Reset tombol
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False

    End Sub
    Sub ResetMode()
        ' Reset mode
        mode = ""
    End Sub

    'fuction tampil data
    Sub TampilData()
        dgBawah.DataSource = GetData("SELECT * FROM list_menu")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPencarian()
        'tampilkan data
        TampilData()

        'items combo box
        cboJenisMakanan.Items.Add("Makanan")
        cboJenisMakanan.Items.Add("Minuman")
        cboJenisMakanan.Items.Add("Snack")
        btnSimpan.Enabled = False


        TampilkanChart()
        DisableInput()
        ResetForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        mode = "Tambah"

        ' Reset form dulu
        ResetForm()

        ' Aktifin input
        cboJenisMakanan.Enabled = True
        txtbItem.Enabled = True
        txtHarga.Enabled = True
        txtStock.Enabled = True

        ' Tombol
        btnSimpan.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnBatal.Enabled = True

        ' Fokus ke combo
        cboJenisMakanan.Focus()
    End Sub


    Private Sub dgBawah_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBawah.CellContentClick
        With Me.btnSimpan
            .Visible = True
            .Enabled = False
        End With
        btnSimpan.Enabled = False
        btnBatal.Enabled = True
        btnTambah.Enabled = True

    End Sub

    Private Sub dgBawah_SelectionChanged(sender As Object, e As EventArgs) Handles dgBawah.SelectionChanged
        Try
            If mode = "Tambah" Then Exit Sub

            If dgBawah.CurrentRow IsNot Nothing Then
                Dim row As DataGridViewRow = dgBawah.CurrentRow

                txtbIdMenu.Text = row.Cells(0).Value.ToString()
                cboJenisMakanan.Text = row.Cells(1).Value.ToString()
                txtbItem.Text = row.Cells(2).Value.ToString()
                txtHarga.Text = row.Cells(3).Value.ToString()
                txtStock.Text = row.Cells(4).Value.ToString()

                btnEdit.Enabled = True
                btnHapus.Enabled = True
                btnSimpan.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnSimpan.Enabled = False
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        Try
            OpenKoneksi()

            Dim query As String = ""

            'jangan typo "mode = Tambah"
            If mode = "Tambah" Then
                query = "INSERT INTO list_menu VALUES ('" & txtbIdMenu.Text & "','" & cboJenisMakanan.Text & "','" & txtbItem.Text & "'," & txtHarga.Text & "," & txtStock.Text & ")"

            ElseIf mode = "Edit" Then
                query = "UPDATE list_menu SET jenis='" & cboJenisMakanan.Text & "', item='" & txtbItem.Text & "', harga=" & txtHarga.Text & ", stok=" & txtStock.Text & " WHERE id_menu='" & txtbIdMenu.Text & "'"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            CloseKoneksi()

            MessageBox.Show("Data berhasil disimpan")


            ResetForm()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Dim result As DialogResult

        result = MessageBox.Show("Yakin mau batal?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DisableInput()
            ResetMode()
            ResetForm()
            btnTambah.Enabled = True
            btnEdit.Enabled = True
            btnHapus.Enabled = True

        End If
        'reset

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Cek data
        If txtbIdMenu.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        ' Konfirmasi
        If MessageBox.Show("Yakin mau hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        If txtbIdMenu.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        Dim result As Boolean = DeleteData(
            "DELETE FROM list_menu WHERE id_menu=@id",
            "@id",
            txtbIdMenu.Text
        )

        If result Then
            MessageBox.Show("Data berhasil dihapus")

            ResetForm()
        End If
    End Sub

    Private Sub cboJenisMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenisMakanan.SelectedIndexChanged

        If mode <> "Tambah" Then Exit Sub

        Dim prefix As String = ""

        If cboJenisMakanan.Text = "Makanan" Then
            prefix = "MK"
        ElseIf cboJenisMakanan.Text = "Minuman" Then
            prefix = "M"
        ElseIf cboJenisMakanan.Text = "Snack" Then
            prefix = "S"
        End If

        txtbIdMenu.Text = GenerateIdMenu(prefix)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        mode = "Edit"

        ' Aktifkan input
        cboJenisMakanan.Enabled = True
        txtbItem.Enabled = True
        txtHarga.Enabled = True
        txtStock.Enabled = True

        ' ID jangan diubah
        txtbIdMenu.Enabled = False

        ' Tombol
        btnSimpan.Enabled = True
        btnHapus.Enabled = True
        btnBatal.Enabled = True
    End Sub

    Private Sub txtbcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbcari.KeyPress
        LoadPencarian()
    End Sub

    Private Sub txtbcari_TextChanged(sender As Object, e As EventArgs) Handles txtbcari.TextChanged
        LoadPencarian()
    End Sub
End Class