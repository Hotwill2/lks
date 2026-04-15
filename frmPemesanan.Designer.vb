<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPemesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPemesanan))
        txtbJumlah = New TextBox()
        lblidpemesanan = New Label()
        lblHargaPemesanan = New Label()
        lblJumlah = New Label()
        lblTotal = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        txtbTotal = New TextBox()
        txtbHarga = New TextBox()
        dgMenu = New DataGridView()
        btnSimpan = New Button()
        btnKirim = New Button()
        btnBatal = New Button()
        Panel1 = New Panel()
        btnTambah = New Button()
        Panel2 = New Panel()
        btnQuit = New Button()
        lblTanggal = New Label()
        txtbStock = New TextBox()
        lblStock = New Label()
        lblJenis = New Label()
        cboJenis = New ComboBox()
        txtbidpemesanan = New TextBox()
        dtPemesanan = New DateTimePicker()
        txtbMenu = New TextBox()
        lblidmenu = New Label()
        txtbItem = New TextBox()
        lblItem = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        dgKeranjang = New DataGridView()
        lblInfoPanel = New Label()
        lblKeteranganPemesanan = New Label()
        CType(dgMenu, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgKeranjang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbJumlah
        ' 
        txtbJumlah.BorderStyle = BorderStyle.FixedSingle
        txtbJumlah.Location = New Point(1000, 146)
        txtbJumlah.Name = "txtbJumlah"
        txtbJumlah.Size = New Size(348, 27)
        txtbJumlah.TabIndex = 1
        ' 
        ' lblidpemesanan
        ' 
        lblidpemesanan.AutoSize = True
        lblidpemesanan.BackColor = SystemColors.ButtonHighlight
        lblidpemesanan.FlatStyle = FlatStyle.Flat
        lblidpemesanan.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblidpemesanan.Location = New Point(883, 86)
        lblidpemesanan.Name = "lblidpemesanan"
        lblidpemesanan.Size = New Size(111, 19)
        lblidpemesanan.TabIndex = 2
        lblidpemesanan.Text = "id pemesanan"
        ' 
        ' lblHargaPemesanan
        ' 
        lblHargaPemesanan.AutoSize = True
        lblHargaPemesanan.BackColor = SystemColors.ButtonHighlight
        lblHargaPemesanan.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblHargaPemesanan.Location = New Point(293, 139)
        lblHargaPemesanan.Name = "lblHargaPemesanan"
        lblHargaPemesanan.Size = New Size(54, 19)
        lblHargaPemesanan.TabIndex = 3
        lblHargaPemesanan.Text = "Harga"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.BackColor = SystemColors.ButtonHighlight
        lblJumlah.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblJumlah.Location = New Point(884, 149)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(60, 19)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = SystemColors.ButtonHighlight
        lblTotal.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblTotal.Location = New Point(883, 186)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(45, 19)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Total"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.ControlLightLight
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Location = New Point(281, 37)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(506, 192)
        FlowLayoutPanel1.TabIndex = 6
        ' 
        ' txtbTotal
        ' 
        txtbTotal.BorderStyle = BorderStyle.FixedSingle
        txtbTotal.Location = New Point(1000, 183)
        txtbTotal.Name = "txtbTotal"
        txtbTotal.Size = New Size(348, 27)
        txtbTotal.TabIndex = 7
        ' 
        ' txtbHarga
        ' 
        txtbHarga.BorderStyle = BorderStyle.FixedSingle
        txtbHarga.Location = New Point(383, 131)
        txtbHarga.Name = "txtbHarga"
        txtbHarga.Size = New Size(348, 27)
        txtbHarga.TabIndex = 8
        ' 
        ' dgMenu
        ' 
        dgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMenu.Location = New Point(281, 288)
        dgMenu.Name = "dgMenu"
        dgMenu.RowHeadersWidth = 51
        dgMenu.Size = New Size(506, 413)
        dgMenu.TabIndex = 21
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), Image)
        btnSimpan.ImageAlign = ContentAlignment.MiddleLeft
        btnSimpan.Location = New Point(14, 98)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(225, 63)
        btnSimpan.TabIndex = 35
        btnSimpan.Text = "Simpan"
        btnSimpan.TextAlign = ContentAlignment.MiddleRight
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnKirim
        ' 
        btnKirim.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnKirim.Image = CType(resources.GetObject("btnKirim.Image"), Image)
        btnKirim.ImageAlign = ContentAlignment.MiddleLeft
        btnKirim.Location = New Point(14, 181)
        btnKirim.Name = "btnKirim"
        btnKirim.Size = New Size(225, 61)
        btnKirim.TabIndex = 36
        btnKirim.Text = "Kirim"
        btnKirim.TextAlign = ContentAlignment.MiddleRight
        btnKirim.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), Image)
        btnBatal.ImageAlign = ContentAlignment.MiddleLeft
        btnBatal.Location = New Point(14, 261)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(225, 62)
        btnBatal.TabIndex = 38
        btnBatal.Text = "Batal"
        btnBatal.TextAlign = ContentAlignment.MiddleRight
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(btnKirim)
        Panel1.Controls.Add(btnBatal)
        Panel1.Location = New Point(12, 271)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(251, 326)
        Panel1.TabIndex = 40
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), Image)
        btnTambah.ImageAlign = ContentAlignment.MiddleLeft
        btnTambah.Location = New Point(14, 17)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(225, 63)
        btnTambah.TabIndex = 58
        btnTambah.Text = "Tambah"
        btnTambah.TextAlign = ContentAlignment.MiddleRight
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(btnQuit)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(275, 713)
        Panel2.TabIndex = 41
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnQuit.ForeColor = Color.Red
        btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), Image)
        btnQuit.ImageAlign = ContentAlignment.MiddleLeft
        btnQuit.Location = New Point(12, 621)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(233, 61)
        btnQuit.TabIndex = 42
        btnQuit.Text = "Quit"
        btnQuit.TextAlign = ContentAlignment.MiddleRight
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.BackColor = SystemColors.ButtonHighlight
        lblTanggal.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblTanggal.Location = New Point(884, 121)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(66, 19)
        lblTanggal.TabIndex = 42
        lblTanggal.Text = "Tanggal"
        ' 
        ' txtbStock
        ' 
        txtbStock.BorderStyle = BorderStyle.FixedSingle
        txtbStock.Location = New Point(383, 178)
        txtbStock.Name = "txtbStock"
        txtbStock.Size = New Size(348, 27)
        txtbStock.TabIndex = 45
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.BackColor = SystemColors.ButtonHighlight
        lblStock.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblStock.Location = New Point(293, 181)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(51, 19)
        lblStock.TabIndex = 44
        lblStock.Text = "Stock"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.BackColor = SystemColors.ButtonHighlight
        lblJenis.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblJenis.Location = New Point(883, 53)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(45, 19)
        lblJenis.TabIndex = 46
        lblJenis.Text = "Jenis"
        ' 
        ' cboJenis
        ' 
        cboJenis.FormattingEnabled = True
        cboJenis.Location = New Point(1000, 46)
        cboJenis.Name = "cboJenis"
        cboJenis.Size = New Size(348, 28)
        cboJenis.TabIndex = 48
        ' 
        ' txtbidpemesanan
        ' 
        txtbidpemesanan.BorderStyle = BorderStyle.FixedSingle
        txtbidpemesanan.Location = New Point(1000, 80)
        txtbidpemesanan.Name = "txtbidpemesanan"
        txtbidpemesanan.Size = New Size(348, 27)
        txtbidpemesanan.TabIndex = 49
        ' 
        ' dtPemesanan
        ' 
        dtPemesanan.Location = New Point(1000, 113)
        dtPemesanan.Name = "dtPemesanan"
        dtPemesanan.Size = New Size(250, 27)
        dtPemesanan.TabIndex = 50
        ' 
        ' txtbMenu
        ' 
        txtbMenu.BorderStyle = BorderStyle.FixedSingle
        txtbMenu.Location = New Point(383, 50)
        txtbMenu.Name = "txtbMenu"
        txtbMenu.Size = New Size(348, 27)
        txtbMenu.TabIndex = 52
        ' 
        ' lblidmenu
        ' 
        lblidmenu.AutoSize = True
        lblidmenu.BackColor = SystemColors.ButtonHighlight
        lblidmenu.FlatStyle = FlatStyle.Flat
        lblidmenu.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblidmenu.Location = New Point(293, 55)
        lblidmenu.Name = "lblidmenu"
        lblidmenu.Size = New Size(68, 19)
        lblidmenu.TabIndex = 51
        lblidmenu.Text = "Id Menu"
        ' 
        ' txtbItem
        ' 
        txtbItem.BorderStyle = BorderStyle.FixedSingle
        txtbItem.Location = New Point(383, 91)
        txtbItem.Name = "txtbItem"
        txtbItem.Size = New Size(348, 27)
        txtbItem.TabIndex = 56
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.BackColor = SystemColors.ButtonHighlight
        lblItem.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblItem.Location = New Point(293, 99)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(43, 19)
        lblItem.TabIndex = 55
        lblItem.Text = "Item"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = SystemColors.ControlLightLight
        FlowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel2.Location = New Point(872, 37)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(486, 201)
        FlowLayoutPanel2.TabIndex = 7
        ' 
        ' dgKeranjang
        ' 
        dgKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgKeranjang.Location = New Point(855, 288)
        dgKeranjang.Name = "dgKeranjang"
        dgKeranjang.RowHeadersWidth = 51
        dgKeranjang.Size = New Size(526, 413)
        dgKeranjang.TabIndex = 57
        ' 
        ' lblInfoPanel
        ' 
        lblInfoPanel.AutoSize = True
        lblInfoPanel.BackColor = SystemColors.Control
        lblInfoPanel.FlatStyle = FlatStyle.Flat
        lblInfoPanel.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoPanel.Location = New Point(281, 20)
        lblInfoPanel.Name = "lblInfoPanel"
        lblInfoPanel.Size = New Size(166, 23)
        lblInfoPanel.TabIndex = 58
        lblInfoPanel.Text = "Keterangan Stock"
        ' 
        ' lblKeteranganPemesanan
        ' 
        lblKeteranganPemesanan.AutoSize = True
        lblKeteranganPemesanan.BackColor = SystemColors.Control
        lblKeteranganPemesanan.FlatStyle = FlatStyle.Flat
        lblKeteranganPemesanan.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKeteranganPemesanan.Location = New Point(872, 20)
        lblKeteranganPemesanan.Name = "lblKeteranganPemesanan"
        lblKeteranganPemesanan.Size = New Size(161, 23)
        lblKeteranganPemesanan.TabIndex = 59
        lblKeteranganPemesanan.Text = "Form Pemesanan"
        ' 
        ' frmPemesanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1393, 713)
        ControlBox = False
        Controls.Add(lblKeteranganPemesanan)
        Controls.Add(lblInfoPanel)
        Controls.Add(dgKeranjang)
        Controls.Add(txtbItem)
        Controls.Add(lblItem)
        Controls.Add(txtbMenu)
        Controls.Add(lblidmenu)
        Controls.Add(dtPemesanan)
        Controls.Add(txtbidpemesanan)
        Controls.Add(cboJenis)
        Controls.Add(lblJenis)
        Controls.Add(txtbStock)
        Controls.Add(lblStock)
        Controls.Add(lblTanggal)
        Controls.Add(dgMenu)
        Controls.Add(txtbHarga)
        Controls.Add(txtbTotal)
        Controls.Add(txtbJumlah)
        Controls.Add(lblTotal)
        Controls.Add(lblJumlah)
        Controls.Add(lblHargaPemesanan)
        Controls.Add(lblidpemesanan)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(FlowLayoutPanel2)
        Name = "frmPemesanan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pemesanan Screen"
        CType(dgMenu, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(dgKeranjang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtbJumlah As TextBox
    Friend WithEvents lblidpemesanan As Label
    Friend WithEvents lblHargaPemesanan As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents txtbHarga As TextBox
    Friend WithEvents dgMenu As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKirim As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblTanggal As Label
    Friend WithEvents txtbStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cboJenis As ComboBox
    Friend WithEvents txtbidpemesanan As TextBox
    Friend WithEvents dtPemesanan As DateTimePicker
    Friend WithEvents txtbMenu As TextBox
    Friend WithEvents lblidmenu As Label
    Friend WithEvents txtbItem As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents dgKeranjang As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblInfoPanel As Label
    Friend WithEvents lblKeteranganPemesanan As Label
End Class
