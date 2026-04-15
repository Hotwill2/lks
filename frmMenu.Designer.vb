<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        pnlAtas = New Panel()
        txtStock = New TextBox()
        lblIdMenu = New Label()
        lblJenis = New Label()
        lblItem = New Label()
        lblHarga = New Label()
        txtbIdMenu = New TextBox()
        cboJenisMakanan = New ComboBox()
        txtbItem = New TextBox()
        txtHarga = New TextBox()
        dgBawah = New DataGridView()
        lblMenuKedaiMakan = New Label()
        btnTambah = New Button()
        btnSimpan = New Button()
        btnEdit = New Button()
        btnBatal = New Button()
        btnHapus = New Button()
        Panel2 = New Panel()
        btnQuit = New Button()
        picJAM = New PictureBox()
        picLogo = New PictureBox()
        Panel1 = New Panel()
        lblStok = New Label()
        chMenu = New DataVisualization.Charting.Chart()
        txtbcari = New TextBox()
        Label1 = New Label()
        pnlAtas.SuspendLayout()
        CType(dgBawah, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picJAM, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(chMenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlAtas
        ' 
        pnlAtas.BackColor = SystemColors.ButtonShadow
        pnlAtas.Controls.Add(Label1)
        pnlAtas.Controls.Add(txtbcari)
        pnlAtas.Controls.Add(txtStock)
        pnlAtas.ForeColor = SystemColors.ActiveCaptionText
        pnlAtas.Location = New Point(278, 12)
        pnlAtas.Name = "pnlAtas"
        pnlAtas.Size = New Size(614, 305)
        pnlAtas.TabIndex = 32
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        txtStock.Location = New Point(222, 201)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(132, 28)
        txtStock.TabIndex = 24
        ' 
        ' lblIdMenu
        ' 
        lblIdMenu.AutoSize = True
        lblIdMenu.BackColor = SystemColors.ButtonShadow
        lblIdMenu.Font = New Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIdMenu.ForeColor = SystemColors.ActiveCaptionText
        lblIdMenu.Location = New Point(303, 34)
        lblIdMenu.Name = "lblIdMenu"
        lblIdMenu.Size = New Size(68, 19)
        lblIdMenu.TabIndex = 16
        lblIdMenu.Text = "Id menu"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.BackColor = SystemColors.ButtonShadow
        lblJenis.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblJenis.ForeColor = SystemColors.ActiveCaptionText
        lblJenis.Location = New Point(303, 73)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(45, 19)
        lblJenis.TabIndex = 17
        lblJenis.Text = "Jenis"
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.BackColor = SystemColors.ButtonShadow
        lblItem.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblItem.ForeColor = SystemColors.ActiveCaptionText
        lblItem.Location = New Point(305, 117)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(43, 19)
        lblItem.TabIndex = 18
        lblItem.Text = "Item"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = SystemColors.ButtonShadow
        lblHarga.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblHarga.ForeColor = SystemColors.ActiveCaptionText
        lblHarga.Location = New Point(305, 164)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(54, 19)
        lblHarga.TabIndex = 19
        lblHarga.Text = "Harga"
        ' 
        ' txtbIdMenu
        ' 
        txtbIdMenu.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        txtbIdMenu.Location = New Point(500, 26)
        txtbIdMenu.Name = "txtbIdMenu"
        txtbIdMenu.Size = New Size(288, 28)
        txtbIdMenu.TabIndex = 20
        ' 
        ' cboJenisMakanan
        ' 
        cboJenisMakanan.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        cboJenisMakanan.FormattingEnabled = True
        cboJenisMakanan.Location = New Point(500, 70)
        cboJenisMakanan.Name = "cboJenisMakanan"
        cboJenisMakanan.Size = New Size(288, 25)
        cboJenisMakanan.TabIndex = 21
        ' 
        ' txtbItem
        ' 
        txtbItem.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        txtbItem.Location = New Point(500, 113)
        txtbItem.Name = "txtbItem"
        txtbItem.Size = New Size(288, 28)
        txtbItem.TabIndex = 22
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        txtHarga.Location = New Point(500, 160)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(132, 28)
        txtHarga.TabIndex = 23
        ' 
        ' dgBawah
        ' 
        dgBawah.AllowUserToAddRows = False
        dgBawah.AllowUserToDeleteRows = False
        dgBawah.AllowUserToResizeColumns = False
        dgBawah.AllowUserToResizeRows = False
        dgBawah.BackgroundColor = SystemColors.AppWorkspace
        dgBawah.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        dgBawah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgBawah.Cursor = Cursors.Hand
        dgBawah.Location = New Point(278, 338)
        dgBawah.Name = "dgBawah"
        dgBawah.ReadOnly = True
        dgBawah.RowHeadersWidth = 51
        dgBawah.Size = New Size(687, 369)
        dgBawah.TabIndex = 0
        dgBawah.TabStop = False
        ' 
        ' lblMenuKedaiMakan
        ' 
        lblMenuKedaiMakan.AutoSize = True
        lblMenuKedaiMakan.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMenuKedaiMakan.Location = New Point(13, 61)
        lblMenuKedaiMakan.Name = "lblMenuKedaiMakan"
        lblMenuKedaiMakan.Size = New Size(232, 23)
        lblMenuKedaiMakan.TabIndex = 25
        lblMenuKedaiMakan.Text = "Menu Kedai Makan Jamal"
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), Image)
        btnTambah.ImageAlign = ContentAlignment.MiddleLeft
        btnTambah.Location = New Point(36, 169)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(209, 58)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah"
        btnTambah.TextAlign = ContentAlignment.MiddleRight
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), Image)
        btnSimpan.ImageAlign = ContentAlignment.MiddleLeft
        btnSimpan.Location = New Point(36, 423)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(209, 56)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.TextAlign = ContentAlignment.MiddleRight
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.ImageAlign = ContentAlignment.MiddleLeft
        btnEdit.Location = New Point(36, 248)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(209, 63)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.TextAlign = ContentAlignment.MiddleRight
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), Image)
        btnBatal.ImageAlign = ContentAlignment.MiddleLeft
        btnBatal.Location = New Point(36, 500)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(209, 57)
        btnBatal.TabIndex = 5
        btnBatal.Text = "Batal"
        btnBatal.TextAlign = ContentAlignment.MiddleRight
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), Image)
        btnHapus.ImageAlign = ContentAlignment.MiddleLeft
        btnHapus.Location = New Point(36, 338)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(209, 63)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.TextAlign = ContentAlignment.MiddleRight
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(btnQuit)
        Panel2.Controls.Add(picJAM)
        Panel2.Controls.Add(picLogo)
        Panel2.Controls.Add(btnTambah)
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(lblMenuKedaiMakan)
        Panel2.Controls.Add(btnBatal)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(272, 718)
        Panel2.TabIndex = 33
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnQuit.ForeColor = Color.Red
        btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), Image)
        btnQuit.ImageAlign = ContentAlignment.MiddleLeft
        btnQuit.Location = New Point(36, 632)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(209, 57)
        btnQuit.TabIndex = 6
        btnQuit.Text = "Quit"
        btnQuit.TextAlign = ContentAlignment.MiddleRight
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' picJAM
        ' 
        picJAM.Image = CType(resources.GetObject("picJAM.Image"), Image)
        picJAM.Location = New Point(223, 12)
        picJAM.Name = "picJAM"
        picJAM.Size = New Size(46, 31)
        picJAM.SizeMode = PictureBoxSizeMode.Zoom
        picJAM.TabIndex = 32
        picJAM.TabStop = False
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(3, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(71, 46)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 31
        picLogo.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Location = New Point(22, 160)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 408)
        Panel1.TabIndex = 34
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.BackColor = SystemColors.ButtonShadow
        lblStok.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        lblStok.ForeColor = SystemColors.ActiveCaptionText
        lblStok.Location = New Point(305, 213)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(43, 19)
        lblStok.TabIndex = 34
        lblStok.Text = "Stok"
        ' 
        ' chMenu
        ' 
        ChartArea1.Name = "ChartArea1"
        chMenu.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chMenu.Legends.Add(Legend1)
        chMenu.Location = New Point(989, 12)
        chMenu.Name = "chMenu"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chMenu.Series.Add(Series1)
        chMenu.Size = New Size(695, 696)
        chMenu.TabIndex = 35
        ' 
        ' txtbcari
        ' 
        txtbcari.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold)
        txtbcari.Location = New Point(436, 271)
        txtbcari.Name = "txtbcari"
        txtbcari.Size = New Size(175, 28)
        txtbcari.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonShadow
        Label1.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(331, 272)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 19)
        Label1.TabIndex = 36
        Label1.Text = "Cari Menu"
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1696, 718)
        ControlBox = False
        Controls.Add(chMenu)
        Controls.Add(lblStok)
        Controls.Add(Panel2)
        Controls.Add(dgBawah)
        Controls.Add(txtHarga)
        Controls.Add(txtbItem)
        Controls.Add(cboJenisMakanan)
        Controls.Add(txtbIdMenu)
        Controls.Add(lblHarga)
        Controls.Add(lblItem)
        Controls.Add(lblJenis)
        Controls.Add(lblIdMenu)
        Controls.Add(pnlAtas)
        Name = "frmMenu"
        Text = "Menu Screen"
        pnlAtas.ResumeLayout(False)
        pnlAtas.PerformLayout()
        CType(dgBawah, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(picJAM, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(chMenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlAtas As Panel
    Friend WithEvents lblIdMenu As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtbIdMenu As TextBox
    Friend WithEvents cboJenisMakanan As ComboBox
    Friend WithEvents txtbItem As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dgBawah As DataGridView
    Friend WithEvents lblMenuKedaiMakan As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents picJAM As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents chMenu As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbcari As TextBox
End Class
