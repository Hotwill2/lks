Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlCommand
Module ModuleUsers

    'deklarasi
    Public roleuser As String




    Public Function LoginUser(username As String, password As String) As String
        Try
            OpenKoneksi()

            Dim query As String = "SELECT role FROM users WHERE username=@user AND password=@pass"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Return reader("role").ToString()
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        Finally
            CloseKoneksi()
        End Try
    End Function



End Module
