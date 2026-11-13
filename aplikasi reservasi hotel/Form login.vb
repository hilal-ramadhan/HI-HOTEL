Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text.Trim() = "" Then
            MsgBox("Masukkan username")
            txtusername.Focus()
            Exit Sub
        End If

        If txtpassword.Text = "" Then
            MsgBox("Masukkan password")
            txtpassword.Focus()
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(ConnString)
                con.Open()

                Using cmd As New SqlCommand("SELECT COUNT(*) FROM users WHERE username = @username AND password = @password", con)
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text)

                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If jumlah > 0 Then
                        MsgBox("login berhasil")
                        txtpassword.Clear()
                        form_menu.Show()
                        Me.Hide()
                    Else
                        MsgBox("Pastikan username dan password benar")
                        txtusername.Clear()
                        txtpassword.Clear()
                        txtusername.Focus()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Application.Exit()
    End Sub
End Class
