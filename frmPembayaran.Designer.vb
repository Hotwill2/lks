<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembayaran))
        pnlKiri = New Panel()
        btnQuit = New Button()
        Panel1 = New Panel()
        btnDataPesanan = New Button()
        btnBayar = New Button()
        btnHitung = New Button()
        btnBatal = New Button()
        lblKembalian = New Label()
        txtbKembalian = New TextBox()
        lblUangBayar = New Label()
        txtbUangBayar = New TextBox()
        txtbRingkasan = New TextBox()
        txtbIdPemesanan = New TextBox()
        txtbTotal = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        pnlKiri.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKiri
        ' 
        pnlKiri.BackColor = SystemColors.ButtonHighlight
        pnlKiri.Controls.Add(btnQuit)
        pnlKiri.Controls.Add(Panel1)
        pnlKiri.Dock = DockStyle.Left
        pnlKiri.Location = New Point(0, 0)
        pnlKiri.Name = "pnlKiri"
        pnlKiri.Size = New Size(274, 714)
        pnlKiri.TabIndex = 0
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnQuit.ForeColor = Color.Red
        btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), Image)
        btnQuit.ImageAlign = ContentAlignment.MiddleLeft
        btnQuit.Location = New Point(18, 602)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(233, 61)
        btnQuit.TabIndex = 43
        btnQuit.Text = "Quit"
        btnQuit.TextAlign = ContentAlignment.MiddleRight
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(btnDataPesanan)
        Panel1.Controls.Add(btnBayar)
        Panel1.Controls.Add(btnHitung)
        Panel1.Controls.Add(btnBatal)
        Panel1.Location = New Point(12, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(251, 298)
        Panel1.TabIndex = 41
        ' 
        ' btnDataPesanan
        ' 
        btnDataPesanan.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnDataPesanan.Image = CType(resources.GetObject("btnDataPesanan.Image"), Image)
        btnDataPesanan.ImageAlign = ContentAlignment.MiddleLeft
        btnDataPesanan.Location = New Point(14, 10)
        btnDataPesanan.Name = "btnDataPesanan"
        btnDataPesanan.Size = New Size(225, 63)
        btnDataPesanan.TabIndex = 59
        btnDataPesanan.Text = "Ambil Data Pesanan"
        btnDataPesanan.TextAlign = ContentAlignment.MiddleRight
        btnDataPesanan.UseVisualStyleBackColor = True
        ' 
        ' btnBayar
        ' 
        btnBayar.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnBayar.Image = CType(resources.GetObject("btnBayar.Image"), Image)
        btnBayar.ImageAlign = ContentAlignment.MiddleLeft
        btnBayar.Location = New Point(14, 148)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(225, 63)
        btnBayar.TabIndex = 58
        btnBayar.Text = "Bayar"
        btnBayar.TextAlign = ContentAlignment.MiddleRight
        btnBayar.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnHitung.Image = CType(resources.GetObject("btnHitung.Image"), Image)
        btnHitung.ImageAlign = ContentAlignment.MiddleLeft
        btnHitung.Location = New Point(14, 79)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(225, 63)
        btnHitung.TabIndex = 35
        btnHitung.Text = "Hitung"
        btnHitung.TextAlign = ContentAlignment.MiddleRight
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Yu Gothic", 9F, FontStyle.Bold)
        btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), Image)
        btnBatal.ImageAlign = ContentAlignment.MiddleLeft
        btnBatal.Location = New Point(14, 217)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(225, 62)
        btnBatal.TabIndex = 38
        btnBatal.Text = "Batal"
        btnBatal.TextAlign = ContentAlignment.MiddleRight
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' lblKembalian
        ' 
        lblKembalian.AutoSize = True
        lblKembalian.Location = New Point(360, 189)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(80, 20)
        lblKembalian.TabIndex = 4
        lblKembalian.Text = "Kembalian"
        ' 
        ' txtbKembalian
        ' 
        txtbKembalian.Location = New Point(480, 186)
        txtbKembalian.Name = "txtbKembalian"
        txtbKembalian.Size = New Size(799, 27)
        txtbKembalian.TabIndex = 3
        ' 
        ' lblUangBayar
        ' 
        lblUangBayar.AutoSize = True
        lblUangBayar.Location = New Point(355, 95)
        lblUangBayar.Name = "lblUangBayar"
        lblUangBayar.Size = New Size(85, 20)
        lblUangBayar.TabIndex = 6
        lblUangBayar.Text = "Uang Bayar"
        ' 
        ' txtbUangBayar
        ' 
        txtbUangBayar.Location = New Point(480, 92)
        txtbUangBayar.Name = "txtbUangBayar"
        txtbUangBayar.Size = New Size(799, 27)
        txtbUangBayar.TabIndex = 5
        ' 
        ' txtbRingkasan
        ' 
        txtbRingkasan.Location = New Point(480, 254)
        txtbRingkasan.Multiline = True
        txtbRingkasan.Name = "txtbRingkasan"
        txtbRingkasan.ReadOnly = True
        txtbRingkasan.ScrollBars = ScrollBars.Vertical
        txtbRingkasan.Size = New Size(799, 171)
        txtbRingkasan.TabIndex = 9
        ' 
        ' txtbIdPemesanan
        ' 
        txtbIdPemesanan.Location = New Point(480, 50)
        txtbIdPemesanan.Name = "txtbIdPemesanan"
        txtbIdPemesanan.Size = New Size(799, 27)
        txtbIdPemesanan.TabIndex = 10
        ' 
        ' txtbTotal
        ' 
        txtbTotal.Location = New Point(480, 140)
        txtbTotal.Name = "txtbTotal"
        txtbTotal.Size = New Size(799, 27)
        txtbTotal.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(375, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 12
        Label1.Text = "total"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(360, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 13
        Label2.Text = "Id pemesanan"
        ' 
        ' frmPembayaran
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1388, 714)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtbTotal)
        Controls.Add(txtbIdPemesanan)
        Controls.Add(txtbRingkasan)
        Controls.Add(lblUangBayar)
        Controls.Add(txtbUangBayar)
        Controls.Add(lblKembalian)
        Controls.Add(txtbKembalian)
        Controls.Add(pnlKiri)
        Name = "frmPembayaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pembayaran Screen"
        pnlKiri.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlKiri As Panel
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtbKembalian As TextBox
    Friend WithEvents lblUangBayar As Label
    Friend WithEvents txtbUangBayar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtbRingkasan As TextBox
    Friend WithEvents txtbIdPemesanan As TextBox
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents btnDataPesanan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
