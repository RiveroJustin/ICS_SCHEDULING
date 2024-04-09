Imports MySql.Data.MySqlClient
Module DatabaseConnection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dataReader As New MySqlDataAdapter
    Public table As New DataTable

    Public Sub DBCon()
        Try
            'No connection
            con.ConnectionString = "server=localhost;username=root;password=;database="
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Module
