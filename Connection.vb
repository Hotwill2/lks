Imports MySql.Data.MySqlClient
Imports MySqlConnector.MySqlCommand

Module Koneksi
    'deklarasi
    Public Conn As MySqlConnection
    Public sql As New MySqlCommand
    Public dataadapter As New MySqlDataAdapter
    Public datarecord As New DataTable
    Public dt As New DataTable
    Public datachart As New DataTable
    Public query As String
    Public Status As String
    'Dim da As New MySqlDataAdapter



    Public Sub OpenKoneksi()
        Try
            If Conn Is Nothing Then
                Conn = New MySqlConnection("server=localhost;user id=root;password=;database=lks")
            End If

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseKoneksi()
        Try
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error tutup koneksi: " & ex.Message)
        End Try
    End Sub

    Public Function GetData(query As String) As DataTable
        Dim dt As New DataTable

        Try
            OpenKoneksi()
            Dim da As New MySqlDataAdapter(query, Conn)

            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseKoneksi()
        End Try

        Return dt
    End Function

    Public Function DeleteData(query As String, paramName As String, value As String) As Boolean
        Try
            OpenKoneksi()

            Dim cmd As New MySqlCommand(query, Conn)
            cmd.Parameters.AddWithValue(paramName, value)

            cmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            If ex.Message.Contains("foreign key constraint") Then
                MessageBox.Show("Data tidak bisa dihapus karena sudah digunakan!")
            Else
                MessageBox.Show(ex.Message)
            End If

            Return False

        Finally
            CloseKoneksi()
        End Try
    End Function

    Public Function TampilChart(query As String) As DataTable
        OpenKoneksi()
        sql = New MySqlCommand(query, Conn)
        dataadapter = New MySqlDataAdapter(sql)
        datachart = New DataTable
        dataadapter.Fill(datachart)

        CloseKoneksi()
        Return datachart
    End Function

    Public Function TampilRecord(query As String) As DataTable
        OpenKoneksi()
        sql = New MySqlCommand(query, Conn)
        dataadapter = New MySqlDataAdapter(sql)
        datarecord = New DataTable
        dataadapter.Fill(datarecord) 'error sementara

        CloseKoneksi()
        Return datarecord
    End Function


End Module