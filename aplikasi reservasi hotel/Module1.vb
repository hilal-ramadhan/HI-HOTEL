
Imports System.Data.SqlClient

Module Module1

    ' Satu connection string dipakai oleh semua form.
    Public Const ConnString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=db_hotel2;Integrated Security=True;Encrypt=False"

    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand

    Public Sub koneksi()
        If conn Is Nothing Then
            conn = New SqlConnection(ConnString)
        End If

        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

End Module
