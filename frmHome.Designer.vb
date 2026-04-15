<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        pnlKiri = New Panel()
        btnKeluarAplikasi = New Button()
        btnPembayaran = New Button()
        Button1 = New Button()
        btnPemesanan = New Button()
        MonthCalendar1 = New MonthCalendar()
        picJAM = New PictureBox()
        picLogo = New PictureBox()
        lblMotto = New Label()
        lblKedaiMakan = New Label()
        pnlAtas = New Panel()
        pnlKiri.SuspendLayout()
        CType(picJAM, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlKiri
        ' 
        pnlKiri.BackColor = SystemColors.ButtonHighlight
        pnlKiri.Controls.Add(btnKeluarAplikasi)
        pnlKiri.Controls.Add(btnPembayaran)
        pnlKiri.Controls.Add(Button1)
        pnlKiri.Controls.Add(btnPemesanan)
        pnlKiri.Controls.Add(MonthCalendar1)
        pnlKiri.Controls.Add(picJAM)
        pnlKiri.Controls.Add(picLogo)
        pnlKiri.Controls.Add(lblMotto)
        pnlKiri.Controls.Add(lblKedaiMakan)
        pnlKiri.Dock = DockStyle.Left
        pnlKiri.Location = New Point(0, 0)
        pnlKiri.Name = "pnlKiri"
        pnlKiri.Size = New Size(370, 687)
        pnlKiri.TabIndex = 0
        ' 
        ' btnKeluarAplikasi
        ' 
        btnKeluarAplikasi.FlatAppearance.BorderSize = 0
        btnKeluarAplikasi.FlatStyle = FlatStyle.Flat
        btnKeluarAplikasi.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        btnKeluarAplikasi.Image = CType(resources.GetObject("btnKeluarAplikasi.Image"), Image)
        btnKeluarAplikasi.ImageAlign = ContentAlignment.MiddleLeft
        btnKeluarAplikasi.Location = New Point(50, 599)
        btnKeluarAplikasi.Name = "btnKeluarAplikasi"
        btnKeluarAplikasi.Size = New Size(262, 60)
        btnKeluarAplikasi.TabIndex = 3
        btnKeluarAplikasi.Text = "Keluar Aplikasi"
        btnKeluarAplikasi.TextAlign = ContentAlignment.MiddleRight
        btnKeluarAplikasi.UseVisualStyleBackColor = True
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.FlatAppearance.BorderSize = 0
        btnPembayaran.FlatStyle = FlatStyle.Flat
        btnPembayaran.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        btnPembayaran.Image = CType(resources.GetObject("btnPembayaran.Image"), Image)
        btnPembayaran.ImageAlign = ContentAlignment.MiddleLeft
        btnPembayaran.Location = New Point(50, 515)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(262, 60)
        btnPembayaran.TabIndex = 2
        btnPembayaran.Text = "Pembayaran"
        btnPembayaran.TextAlign = ContentAlignment.MiddleRight
        btnPembayaran.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(50, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(262, 80)
        Button1.TabIndex = 0
        Button1.Text = "Menu"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnPemesanan
        ' 
        btnPemesanan.FlatAppearance.BorderSize = 0
        btnPemesanan.FlatStyle = FlatStyle.Flat
        btnPemesanan.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        btnPemesanan.Image = CType(resources.GetObject("btnPemesanan.Image"), Image)
        btnPemesanan.ImageAlign = ContentAlignment.MiddleLeft
        btnPemesanan.Location = New Point(50, 427)
        btnPemesanan.Name = "btnPemesanan"
        btnPemesanan.Size = New Size(262, 60)
        btnPemesanan.TabIndex = 1
        btnPemesanan.Text = "Pemesanan"
        btnPemesanan.TextAlign = ContentAlignment.MiddleRight
        btnPemesanan.UseVisualStyleBackColor = True
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(50, 89)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 100
        ' 
        ' picJAM
        ' 
        picJAM.Image = CType(resources.GetObject("picJAM.Image"), Image)
        picJAM.Location = New Point(318, 21)
        picJAM.Name = "picJAM"
        picJAM.Size = New Size(46, 31)
        picJAM.SizeMode = PictureBoxSizeMode.Zoom
        picJAM.TabIndex = 19
        picJAM.TabStop = False
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(9, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(85, 55)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 16
        picLogo.TabStop = False
        ' 
        ' lblMotto
        ' 
        lblMotto.AutoSize = True
        lblMotto.Font = New Font("Yu Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMotto.ForeColor = Color.Black
        lblMotto.Location = New Point(109, 47)
        lblMotto.Name = "lblMotto"
        lblMotto.Size = New Size(102, 17)
        lblMotto.TabIndex = 18
        lblMotto.Text = "Di Jamin ENAK!"
        ' 
        ' lblKedaiMakan
        ' 
        lblKedaiMakan.AutoSize = True
        lblKedaiMakan.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKedaiMakan.ForeColor = Color.Black
        lblKedaiMakan.Location = New Point(109, 21)
        lblKedaiMakan.Name = "lblKedaiMakan"
        lblKedaiMakan.Size = New Size(203, 26)
        lblKedaiMakan.TabIndex = 17
        lblKedaiMakan.Text = "Kedai Makan Jamal"
        ' 
        ' pnlAtas
        ' 
        pnlAtas.BackColor = SystemColors.AppWorkspace
        pnlAtas.Dock = DockStyle.Top
        pnlAtas.Location = New Point(370, 0)
        pnlAtas.Name = "pnlAtas"
        pnlAtas.Size = New Size(1013, 125)
        pnlAtas.TabIndex = 1
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1383, 687)
        ControlBox = False
        Controls.Add(pnlAtas)
        Controls.Add(pnlKiri)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home Screen"
        WindowState = FormWindowState.Maximized
        pnlKiri.ResumeLayout(False)
        pnlKiri.PerformLayout()
        CType(picJAM, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlKiri As Panel
    Friend WithEvents pnlAtas As Panel
    Friend WithEvents picJAM As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMotto As Label
    Friend WithEvents lblKedaiMakan As Label
    Friend WithEvents btnKeluarAplikasi As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPemesanan As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar

End Class
