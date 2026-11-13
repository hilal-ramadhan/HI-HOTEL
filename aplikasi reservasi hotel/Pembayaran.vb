Imports System.Data.SqlClient
Public Class pembayaran
    Private Sub PEMBYARAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilReservasi()
        TampilData()

        cmbmetode.Items.Clear()
        cmbmetode.Items.Add("Tunai")
        cmbmetode.Items.Add("Transfer")
        cmbmetode.Items.Add("Debit")

        cmbstatus.Items.Clear()
        cmbstatus.Items.Add("Belum Lunas")
        cmbstatus.Items.Add("Lunas")

        dtptanggal.Value = Date.Now
    End Sub

    Private Sub TampilReservasi()
        Try
            koneksi()

            Dim dt As New DataTable
            da = New SqlDataAdapter("SELECT id_reservasi, total_harga FROM reservasi ORDER BY id_reservasi", conn)

            da.Fill(dt)

            cmbreservasi.DataSource = Nothing
            cmbreservasi.DataSource = dt
            cmbreservasi.DisplayMember = "id_reservasi"
            cmbreservasi.ValueMember = "id_reservasi"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub TampilData()
        Try
            koneksi()

            da = New SqlDataAdapter("SELECT id_pembayaran, id_reservasi, tanggal_bayar, jumlah_bayar, metode_pembayaran, status_pembayaran FROM pembayaran ORDER BY id_pembayaran", conn)

            ds = New DataSet
            da.Fill(ds, "pembayaran")

            dgvpembayaran.DataSource = ds.Tables("pembayaran")
            dgvpembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvpembayaran.ReadOnly = True
            dgvpembayaran.AllowUserToAddRows = False

            dgvpembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvpembayaran.MultiSelect = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub cmbreservasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreservasi.SelectedIndexChanged
        If cmbreservasi.SelectedItem IsNot Nothing Then
            Dim baris As DataRowView = TryCast(cmbreservasi.SelectedItem, DataRowView)

            If baris IsNot Nothing Then
                txtjumlahbayar.Text = Convert.ToDecimal(baris("total_harga")).ToString("N0")
            End If
        End If

    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        form_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        If cmbreservasi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih ID Reservasi terlebih dahulu!")
            Exit Sub
        End If

        If cmbmetode.SelectedIndex = -1 Then
            MessageBox.Show("Pilih metode pembayaran!")
            Exit Sub
        End If

        If cmbstatus.SelectedIndex = -1 Then
            MessageBox.Show("Pilih status pembayaran!")
            Exit Sub
        End If

        Try
            koneksi()

            Dim sql As String = "INSERT INTO pembayaran 
            (id_reservasi, tanggal_bayar, jumlah_bayar, metode_pembayaran, status_pembayaran)
            VALUES (@reservasi, @tanggal, @jumlah, @metode, @status)"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@reservasi", cmbreservasi.SelectedValue)
            cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value.Date)
            cmd.Parameters.AddWithValue("@jumlah", Convert.ToDecimal(txtjumlahbayar.Text.Replace(",", "")))
            cmd.Parameters.AddWithValue("@metode", cmbmetode.Text)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pembayaran berhasil disimpan!")

            TampilData()
            Bersihkan()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
    Private Sub Bersihkan()
        txtidpembayaran.Clear()
        cmbreservasi.SelectedIndex = -1
        txtjumlahbayar.Clear()
        cmbmetode.SelectedIndex = -1
        cmbstatus.SelectedIndex = -1
        dtptanggal.Value = Date.Now
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        If txtidpembayaran.Text = "" Then
            MessageBox.Show("Pilih data pembayaran yang ingin diedit!")
            Exit Sub
        End If

        If cmbreservasi.SelectedIndex = -1 OrElse
       cmbmetode.SelectedIndex = -1 OrElse
       cmbstatus.SelectedIndex = -1 Then

            MessageBox.Show("Lengkapi data pembayaran!")
            Exit Sub
        End If

        Try
            koneksi()

            Dim sql As String = "UPDATE pembayaran SET
            id_reservasi = @reservasi,
            tanggal_bayar = @tanggal,
            jumlah_bayar = @jumlah,
            metode_pembayaran = @metode,
            status_pembayaran = @status
            WHERE id_pembayaran = @id"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@reservasi", cmbreservasi.SelectedValue)
            cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value.Date)
            cmd.Parameters.AddWithValue("@jumlah", Convert.ToDecimal(txtjumlahbayar.Text.Replace(",", "")))
            cmd.Parameters.AddWithValue("@metode", cmbmetode.Text)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text)
            cmd.Parameters.AddWithValue("@id", CInt(txtidpembayaran.Text))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pembayaran berhasil diedit!")

            TampilData()
            Bersihkan()

            dgvpembayaran.ClearSelection()
            dgvpembayaran.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show("Gagal mengedit: " & ex.Message)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtidpembayaran.Text = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin menghapus pembayaran ini?",
            "Konfirmasi", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
        End If

        Try
            koneksi()

            Dim sql As String = "DELETE FROM pembayaran WHERE id_pembayaran = @id"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", CInt(txtidpembayaran.Text))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pembayaran berhasil dihapus!")

            TampilData()
            Bersihkan()

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvpembayaran_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpembayaran.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim baris As DataGridViewRow = dgvpembayaran.Rows(e.RowIndex)

        txtidpembayaran.Text = baris.Cells("id_pembayaran").Value.ToString()
        cmbreservasi.SelectedValue = baris.Cells("id_reservasi").Value
        dtptanggal.Value = Convert.ToDateTime(baris.Cells("tanggal_bayar").Value)
        txtjumlahbayar.Text = Convert.ToDecimal(baris.Cells("jumlah_bayar").Value).ToString("N0")
        cmbmetode.Text = baris.Cells("metode_pembayaran").Value.ToString()
        cmbstatus.Text = baris.Cells("status_pembayaran").Value.ToString()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Bersihkan()
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged

    End Sub
End Class