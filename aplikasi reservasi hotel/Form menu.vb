Imports System.Diagnostics.Eventing.Reader
Imports aplikasi_reservasi_hotel.db_hotel2DataSetTableAdapters

Public Class form_menu
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbljudul_Click(sender As Object, e As EventArgs) Handles lbljudul.Click

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnkamar_Click(sender As Object, e As EventArgs) Handles btnkamar.Click
        Form_data_kamar.RefreshData()
        Form_data_kamar.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panelcontent.Paint

    End Sub

    Private Sub btnpembayaran_Click(sender As Object, e As EventArgs) Handles btnpembayaran.Click
        Pembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub btntamu_Click(sender As Object, e As EventArgs) Handles btntamu.Click
        Form_data_tamu.RefreshData()
        Form_data_tamu.Show()
        Me.Hide()
    End Sub

    Private Sub btnreservasi_Click(sender As Object, e As EventArgs) Handles btnreservasi.Click
        reservasi.RefreshData()
        reservasi.Show()
        Me.Hide()
    End Sub

    Private Sub form_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub
End Class