Imports MySql.Data.MySqlClient
Imports MySqlConnector.MySqlCommand
Module FormModule
    Private Sub BlockKeyDown(sender As Object, e As KeyEventArgs)
        e.SuppressKeyPress = True
    End Sub

    Private Sub BlockKeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub BlockMouseDown(sender As Object, e As MouseEventArgs)
        DirectCast(sender, Control).Focus()
    End Sub


    Public Sub DisableSemuaInput(parent As Control)
        For Each ctrl As Control In parent.Controls
            ' Pasang event handler
            AddHandler ctrl.KeyDown, AddressOf BlockKeyDown
            AddHandler ctrl.KeyPress, AddressOf BlockKeyPress
            AddHandler ctrl.MouseDown, AddressOf BlockMouseDown

            ' Jika control punya child (misalx nya Panel, GroupBox, dll)
            If ctrl.HasChildren Then
                DisableSemuaInput(ctrl)
            End If
        Next
    End Sub

    Public Sub EnableSemuaInput(parent As Control)
        For Each ctrl As Control In parent.Controls

            AddHandler ctrl.KeyDown, AddressOf BlockKeyDown
            AddHandler ctrl.KeyPress, AddressOf BlockKeyPress
            AddHandler ctrl.MouseDown, AddressOf BlockMouseDown

            ' Jika control punya child (misalx nya Panel, GroupBox, dll)
            If ctrl.HasChildren Then
                EnableSemuaInput(ctrl)
            End If
        Next
    End Sub
    Public Function ValidasiKosong(ParamArray controls() As Control) As Boolean
        For Each ctrl As Control In controls
            ' Validasi TextBox Kosong
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    MessageBox.Show("Masih ada isian yang kosong, lengkapi data", "Validasi")
                    ctrl.Focus()
                    Return False
                End If
            End If

            ' Validasi ComboBox Kosong
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                If cb.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cb.Text) Then
                    MessageBox.Show("Masih ada Combo Box yang belum dipilih, lengkapi data", "Validasi")
                    cb.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Public Function ValidasiAngkaTextBox(txt As TextBox, fieldName As String) As Boolean
        ' Validasi Input Harus Angka, dipanggil ketika klik tombol simpan
        Dim angka As Integer
        If Not Integer.TryParse(txt.Text, angka) Then
            MessageBox.Show(fieldName & " , periksa inputan anda!")
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Validasi Input hanya angka ketika proses ketik dari keyboard
    'dipanggil ketika kursor mengarah ke text box (Got Focus)
    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Module
