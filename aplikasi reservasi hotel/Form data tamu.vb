Imports System.Data.SqlClient
Public Class form_data_tamu

    Dim conn As New SqlConnection(ConnString)

    Private Sub Form_data_tamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()


    End Sub

    Private Sub TampilData()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM tamu ORDER BY id_tamu"

            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable

            da.Fill(dt)

            dgvtamu.DataSource = dt

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Public Sub RefreshData()
        TampilData()
    End Sub

    Private Sub Bersihkan()

        txtid_tamu.Clear()
        txtnama_tamu.Clear()
        txtno_hp.Clear()
        txtalamat.Clear()

        txtid_tamu.ReadOnly = True

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        If txtnama_tamu.Text = "" Then
            MessageBox.Show("Nama tamu harus diisi!")
            txtnama_tamu.Focus()
            Exit Sub
        End If

        Try

            conn.Open()

            Dim query As String =
            "INSERT INTO tamu (nama_tamu, no_hp, alamat) " &
            "VALUES (@nama, @nohp, @alamat)"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@nama", txtnama_tamu.Text)
            cmd.Parameters.AddWithValue("@nohp", txtno_hp.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)

            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Data tamu berhasil disimpan!")

            TampilData()
            Bersihkan()

        Catch ex As Exception

            MessageBox.Show("Gagal menyimpan data: " & ex.Message)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub dgvTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtamu.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = dgvtamu.Rows(e.RowIndex)

            txtid_tamu.Text = row.Cells("id_tamu").Value.ToString()
            txtnama_tamu.Text = row.Cells("nama_tamu").Value.ToString()
            txtno_hp.Text = row.Cells("no_hp").Value.ToString()
            txtalamat.Text = row.Cells("alamat").Value.ToString()

        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        If txtid_tamu.Text = "" Then
            MessageBox.Show("Pilih data yang ingin diedit!")
            Exit Sub
        End If

        Try

            conn.Open()

            Dim query As String =
            "UPDATE tamu SET nama_tamu=@nama, no_hp=@nohp, alamat=@alamat " &
            "WHERE id_tamu=@id"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@nama", txtnama_tamu.Text)
            cmd.Parameters.AddWithValue("@nohp", txtno_hp.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@id", txtid_tamu.Text)

            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Data tamu berhasil diubah!")

            TampilData()
            Bersihkan()

        Catch ex As Exception

            MessageBox.Show("Gagal mengubah data: " & ex.Message)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

        If txtid_tamu.Text = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus!")
            Exit Sub
        End If

        Dim hasil As DialogResult =
        MessageBox.Show(
            "Yakin ingin menghapus data ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.No Then
            Exit Sub
        End If

        Try

            conn.Open()

            Dim query As String =
            "DELETE FROM tamu WHERE id_tamu=@id"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", txtid_tamu.Text)

            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Data tamu berhasil dihapus!")

            TampilData()
            Bersihkan()

        Catch ex As Exception

            MessageBox.Show("Gagal menghapus data: " & ex.Message)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        txtid_tamu.Clear()
        txtnama_tamu.Clear()
        txtno_hp.Clear()
        txtalamat.Clear()

        txtnama_tamu.Focus()

    End Sub


    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If txtnama_tamu.Text.Trim() = "" Then
            MessageBox.Show("masukkan nama yang ingin dicari", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnama_tamu.Focus()
            Exit Sub
        End If

        Try
            conn.Open()

            Dim query As String = "select id_tamu, nama_tamu, no_hp, alamat FROM tamu WHERE nama_tamu=@nama_tamu"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama_tamu", txtnama_tamu.Text)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            If rd.Read() Then
                txtid_tamu.Text = rd("id_tamu").ToString()
                txtnama_tamu.Text = rd("nama_tamu").ToString()
                txtno_hp.Text = rd("no_hp").ToString()
                txtalamat.Text = rd("alamat").ToString()
            Else
                MessageBox.Show("data tidak di temuka", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid_tamu.Clear()
                txtno_hp.Clear()
                txtalamat.Clear()
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Pencarian gagal!" & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso
                    conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnkembal_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        form_menu.Show()
    End Sub

    Private Sub form_data_tamu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Tampilkan menu lagi kalau form ditutup lewat tombol X.
        If e.CloseReason = CloseReason.UserClosing Then
            form_menu.Show()
        End If
    End Sub

    Private Sub txtid_tamu_TextChanged(sender As Object, e As EventArgs) Handles txtid_tamu.TextChanged

    End Sub

    Private Sub dgvtamu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtamu.CellContentClick

    End Sub
End Class
