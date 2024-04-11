Imports MySql.Data.MySqlClient
Module DatabaseConnection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dataReader As New MySqlDataAdapter
    Public table As New DataTable

    Public Sub DBCon()
        Try

            con.ConnectionString = "server=192.168.0.112;username=2d;password=johnrave29;database=ics_scheduling_db"
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Module
