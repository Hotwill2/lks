Imports MySql.Data.MySqlClient
Imports MySqlConnector.MySqlCommand

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtbUssername.Text = "" Or txtbPassword.Text = "" Then
            MessageBox.Show("Username dan Password harus diisi!")
            Exit Sub
        End If

        'deklarasi
        Dim role = LoginUser(txtbUssername.Text, txtbPassword.Text)


        If role IsNot Nothing Then

            frmHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!")
        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub cbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged
        If cbShowPass.Checked Then
            txtbPassword.UseSystemPasswordChar = False
        Else
            txtbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtbUssername.Text = ""
        txtbPassword.Text = ""
    End Sub
End Class