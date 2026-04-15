<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        lblussername = New Label()
        txtbUssername = New TextBox()
        txtbPassword = New TextBox()
        lblPassword = New Label()
        btnLogin = New Button()
        cbShowPass = New CheckBox()
        Label1 = New Label()
        btnQuit = New Button()
        pnlTengah = New FlowLayoutPanel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblussername
        ' 
        lblussername.AutoSize = True
        lblussername.BackColor = SystemColors.ButtonHighlight
        lblussername.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        lblussername.Location = New Point(162, 225)
        lblussername.Name = "lblussername"
        lblussername.Size = New Size(110, 23)
        lblussername.TabIndex = 0
        lblussername.Text = "Ussername"
        ' 
        ' txtbUssername
        ' 
        txtbUssername.BackColor = SystemColors.ButtonHighlight
        txtbUssername.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        txtbUssername.Location = New Point(295, 222)
        txtbUssername.Name = "txtbUssername"
        txtbUssername.Size = New Size(473, 36)
        txtbUssername.TabIndex = 0
        ' 
        ' txtbPassword
        ' 
        txtbPassword.BackColor = SystemColors.ButtonHighlight
        txtbPassword.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        txtbPassword.Location = New Point(295, 270)
        txtbPassword.Name = "txtbPassword"
        txtbPassword.Size = New Size(473, 36)
        txtbPassword.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.ButtonHighlight
        lblPassword.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        lblPassword.Location = New Point(162, 270)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(96, 23)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ButtonHighlight
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        btnLogin.Location = New Point(295, 378)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(195, 38)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' cbShowPass
        ' 
        cbShowPass.AutoSize = True
        cbShowPass.BackColor = SystemColors.ButtonHighlight
        cbShowPass.Font = New Font("Yu Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbShowPass.Location = New Point(295, 322)
        cbShowPass.Name = "cbShowPass"
        cbShowPass.Size = New Size(133, 21)
        cbShowPass.TabIndex = 2
        cbShowPass.Text = "Show Password"
        cbShowPass.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(309, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 39)
        Label1.TabIndex = 6
        Label1.Text = "Login Kedai Makan Jamal"
        ' 
        ' btnQuit
        ' 
        btnQuit.BackColor = Color.Red
        btnQuit.FlatStyle = FlatStyle.Flat
        btnQuit.Font = New Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuit.ForeColor = Color.White
        btnQuit.Location = New Point(809, 478)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(133, 33)
        btnQuit.TabIndex = 5
        btnQuit.Text = "Quit Program"
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' pnlTengah
        ' 
        pnlTengah.BackColor = SystemColors.ButtonHighlight
        pnlTengah.BorderStyle = BorderStyle.FixedSingle
        pnlTengah.Location = New Point(-4, 0)
        pnlTengah.Name = "pnlTengah"
        pnlTengah.Size = New Size(975, 549)
        pnlTengah.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Yu Gothic", 10.8F, FontStyle.Bold)
        Button1.Location = New Point(548, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 38)
        Button1.TabIndex = 4
        Button1.Text = "Batal"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(972, 549)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btnQuit)
        Controls.Add(cbShowPass)
        Controls.Add(btnLogin)
        Controls.Add(txtbPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtbUssername)
        Controls.Add(lblussername)
        Controls.Add(pnlTengah)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblussername As Label
    Friend WithEvents txtbUssername As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents cbShowPass As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents pnlTengah As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
