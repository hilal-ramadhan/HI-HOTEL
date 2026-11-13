Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class Form_data_kamar
    Private Sub Form_data_kamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()

        txtidkamar.Clear()
        txtnokamar.Clear()
        txtharga.Clear()

        cmbtipekamar.SelectedIndex = -1
        cmbstatus.SelectedIndex = -1

        txtidkamar.ReadOnly = True

    End Sub

    Private Sub tampildata()

        Try


            koneksi()

            da = New SqlDataAdapter("SELECT id_kamar, nomor_kamar, tipe_kamar, harga, status_kamar FROM kamar ORDER BY id_kamar", conn)

            ds = New DataSet()

            da.Fill(ds, "kamar")

            dgvkamar.DataSource = ds.Tables("kamar")

            dgvkamar.Columns("id_kamar").HeaderText = "ID Kamar"
            dgvkamar.Columns("nomor_kamar").HeaderText = "Nomor Kamar"
            dgvkamar.Columns("tipe_kamar").HeaderText = "Tipe Kamar"
            dgvkamar.Columns("harga").HeaderText = "Harga"
            dgvkamar.Columns("status_kamar").HeaderText = "Status Kamar"

            dgvkamar.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data" & vbCrLf & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If conn IsNot Nothing AndAlso
               conn.State = ConnectionState.Open Then

                conn.Close()

            End If


        End Try
    End Sub

    Public Sub RefreshData()
        tampildata()
    End Sub

    Private Sub Bersihkan()

        txtidkamar.Clear()
        txtnokamar.Clear()
        txtharga.Clear()

        cmbtipekamar.SelectedIndex = -1
        cmbstatus.SelectedIndex = -1

        txtnokamar.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblstatus.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub lbljudul_Click(sender As Object, e As EventArgs) Handles lbljudul.Click

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnokamar.Text.Trim() = "" Then
            MessageBox.Show("Nomor kamar belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtnokamar.Focus()
            Exit Sub
        End If


        If cmbtipekamar.Text = "" Then
            MessageBox.Show("Tipe kamar belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            cmbtipekamar.Focus()
            Exit Sub
        End If

        If txtharga.Text.Trim() = "" Then
            MessageBox.Show("Harga belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtharga.Focus()
            Exit Sub
        End If


        If cmbstatus.Text = "" Then
            MessageBox.Show("Status kamar belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            cmbstatus.Focus()
            Exit Sub
        End If


        Dim harga As Decimal

        If Not Decimal.TryParse(txtharga.Text, harga) Then
            MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtharga.Focus()
            Exit Sub
        End If


        Try
            koneksi()
            Dim cek As String = "SELECT COUNT(*) FROM kamar WHERE nomor_kamar=@nomor"

            cmd = New SqlCommand(cek, conn)

            cmd.Parameters.AddWithValue("@nomor", txtnokamar.Text.Trim())

            Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If jumlah > 0 Then
                MessageBox.Show("Nomor kamar tersebut sudah terdaftar!")
                Exit Sub
            End If


            ' Simpan data
            Dim sql As String = "INSERT INTO kamar " & "(nomor_kamar, tipe_kamar, harga, status_kamar) " & "VALUES (@nomor, @tipe, @harga, @status)"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue(
                "@nomor",
                txtnokamar.Text.Trim())

            cmd.Parameters.AddWithValue(
                "@tipe",
                cmbtipekamar.Text)

            cmd.Parameters.AddWithValue(
                "@harga",
                harga)

            cmd.Parameters.AddWithValue(
                "@status",
                cmbstatus.Text)

            cmd.ExecuteNonQuery()


            MessageBox.Show(
                "Data kamar berhasil disimpan!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            tampildata()
            Bersihkan()

        Catch ex As Exception

            MessageBox.Show(
                "Data gagal disimpan!" & vbCrLf & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        Finally

            If conn IsNot Nothing AndAlso
               conn.State = ConnectionState.Open Then

                conn.Close()

            End If

        End Try

    End Sub

    Private Sub Panelheader_Paint(sender As Object, e As PaintEventArgs) Handles Panelheader.Paint

    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        form_menu.Show()
        Me.Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersihkan()
    End Sub

    Private Sub dgvkamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkamar.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow =
                dgvkamar.Rows(e.RowIndex)

            txtidkamar.Text =
                row.Cells("id_kamar").Value.ToString()

            txtnokamar.Text =
                row.Cells("nomor_kamar").Value.ToString()

            cmbtipekamar.Text =
                row.Cells("tipe_kamar").Value.ToString()

            txtharga.Text =
                row.Cells("harga").Value.ToString()

            cmbstatus.Text =
                row.Cells("status_kamar").Value.ToString()

        End If

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtidkamar.Text = "" Then
            MessageBox.Show(" Pilih data yang ingin di hapus!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jawab As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghpus data ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawab = DialogResult.No Then
            Exit Sub
        End If

        Try
            koneksi()
            Dim sql As String = "DELETE FROM kamar WHERE id_kamar=@id"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id", txtidkamar.Text.Trim())

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data kamar berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tampildata()
            bersihkan()
        Catch ex As Exception
            MessageBox.Show("Data kamar gagal di hapus!" & vbCrLf & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub Form_data_kamar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Tampilkan menu lagi kalau form ditutup lewat tombol X.
        If e.CloseReason = CloseReason.UserClosing Then
            form_menu.Show()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtidkamar.Text = "" Then
            MessageBox.Show("Pilih data yang ingin di edit", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim harga As Decimal
            If Not Decimal.TryParse(txtharga.Text, harga) Then

                MessageBox.Show("Harga harus berupa angka!")
                Exit Sub
            End If

            koneksi()

            ' Cegah nomor kamar ganda saat mengubah data.
            cmd = New SqlCommand(
                "SELECT COUNT(*) FROM kamar WHERE nomor_kamar=@nomor AND id_kamar<>@id",
                conn)
            cmd.Parameters.AddWithValue("@nomor", txtnokamar.Text.Trim())
            cmd.Parameters.AddWithValue("@id", txtidkamar.Text.Trim())

            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("Nomor kamar tersebut sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sql As String = "UPDATE kamar SET nomor_kamar=@nomor, tipe_kamar=@tipe, harga=@harga, status_kamar=@status WHERE id_kamar=@id"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@nomor", txtnokamar.Text.Trim())
            cmd.Parameters.AddWithValue("@tipe", cmbtipekamar.Text.Trim())
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@status", cmbstatus.Text.Trim())
            cmd.Parameters.AddWithValue("@id", txtidkamar.Text.Trim())

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data kamar berhasil di ubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tampildata()
            Bersihkan()
        Catch ex As Exception

            MessageBox.Show("Data kamar gagal di ubah!" & vbCrLf & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvkamar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkamar.CellContentClick

    End Sub
End Class