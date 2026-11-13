Imports System.Data.Common
Imports System.Data.SqlClient
Public Class reservasi

    Private totalBiaya As Decimal

    ' Menyimpan kamar asal saat data reservasi dipilih untuk diedit.
    Private idKamarAwal As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtidreservasi.TextChanged

    End Sub

    Private Sub reservasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidreservasi.ReadOnly = True
        txttotalbiaya.ReadOnly = True

        dgvreservasi.ReadOnly = True
        dgvreservasi.AllowUserToAddRows = False
        dgvreservasi.AllowUserToDeleteRows = False
        dgvreservasi.MultiSelect = False
        dgvreservasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        RefreshData()
    End Sub

    Public Sub RefreshData()
        TampilData()
        loadtamu()
        loadkamar()

        bersihkan()
    End Sub

    Private Sub bersihkan()
        totalBiaya = 0
        idKamarAwal = 0

        txtidreservasi.Clear()
        txttotalbiaya.Clear()
        lblrincian.Text = ""

        cmbtamu.SelectedIndex = -1
        cmbkamar.SelectedIndex = -1
        cmbstatus.SelectedIndex = -1

        dtpcheckin.Value = Date.Today
        dtpcheckout.Value = Date.Today.AddDays(1)
    End Sub

    Private Sub TampilData()
        Try

            koneksi()

            da = New SqlDataAdapter(
                "SELECT r.id_reservasi,
                    r.tamu AS id_tamu,
                    r.kamar AS id_kamar,
                    t.nama_tamu,
                    k.nomor_kamar,
                    r.check_in,
                    r.check_out,
                    r.total_harga
             FROM reservasi r
             JOIN tamu t ON r.tamu=t.id_tamu
             JOIN kamar k ON r.kamar=k.id_kamar
             ORDER BY r.id_reservasi",
                conn)

            ds = New DataSet

            da.Fill(ds, "reservasi")

            dgvreservasi.DataSource = ds.Tables("reservasi")

            dgvreservasi.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnMode.Fill

            ' Kolom ID tamu dan kamar hanya dipakai untuk mengisi form,
            ' jadi tidak perlu ditampilkan di tabel.
            If dgvreservasi.Columns.Contains("id_tamu") Then
                dgvreservasi.Columns("id_tamu").Visible = False
            End If

            If dgvreservasi.Columns.Contains("id_kamar") Then
                dgvreservasi.Columns("id_kamar").Visible = False
            End If

            dgvreservasi.Columns("id_reservasi").HeaderText = "ID Reservasi"
            dgvreservasi.Columns("nama_tamu").HeaderText = "Nama Tamu"
            dgvreservasi.Columns("nomor_kamar").HeaderText = "Nomor Kamar"
            dgvreservasi.Columns("check_in").HeaderText = "Check-in"
            dgvreservasi.Columns("check_out").HeaderText = "Check-out"
            dgvreservasi.Columns("total_harga").HeaderText = "Total Harga"

            dgvreservasi.Columns("check_in").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvreservasi.Columns("check_out").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvreservasi.Columns("total_harga").DefaultCellStyle.Format = "N0"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub loadtamu()
        Try

            koneksi()

            da = New SqlDataAdapter(
            "SELECT id_tamu, nama_tamu FROM tamu ORDER BY nama_tamu",
            conn)

            Dim dt As New DataTable

            da.Fill(dt)

            cmbtamu.DisplayMember = "nama_tamu"
            cmbtamu.ValueMember = "id_tamu"
            cmbtamu.DataSource = dt

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub loadkamar(Optional idKamarTambahan As Integer = 0)
        Try

            koneksi()

            Dim sql As String = "SELECT id_kamar, nomor_kamar, tipe_kamar, harga FROM kamar " & "WHERE status_kamar='Tersedia'"

            If idKamarTambahan > 0 Then
                sql &= " OR id_kamar=@id"
            End If

            sql &= " ORDER BY nomor_kamar"

            da = New SqlDataAdapter(sql, conn)

            If idKamarTambahan > 0 Then
                da.SelectCommand.Parameters.AddWithValue("@id", idKamarTambahan)
            End If

            Dim dt As New DataTable

            da.Fill(dt)

            ' Tampilkan tipe dan harga per malam agar kamar tidak salah pilih.
            dt.Columns.Add("info_kamar", GetType(String))

            For Each baris As DataRow In dt.Rows
                baris("info_kamar") =
                    baris("nomor_kamar").ToString() & " - " &
                    baris("tipe_kamar").ToString() & " - Rp" &
                    Convert.ToDecimal(baris("harga")).ToString("N0") & "/malam"
            Next

            cmbkamar.DisplayMember = "info_kamar"
            cmbkamar.ValueMember = "id_kamar"
            cmbkamar.DataSource = dt
            cmbkamar.DropDownWidth = Math.Max(cmbkamar.Width, 320)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub hitungtotal()
        totalBiaya = 0
        txttotalbiaya.Clear()
        lblrincian.Text = ""

        If cmbkamar.SelectedIndex = -1 Then Exit Sub

        Dim idKamar As Integer
        If cmbkamar.SelectedValue Is Nothing OrElse
           Not Integer.TryParse(cmbkamar.SelectedValue.ToString(), idKamar) Then
            Exit Sub
        End If

        Try

            koneksi()

            cmd = New SqlCommand(
            "SELECT harga FROM kamar WHERE id_kamar=@id",
            conn)

            cmd.Parameters.AddWithValue("@id", idKamar)

            Dim harga As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())

            ' Jumlah malam dihitung dari selisih tanggal, bukan dari jam.
            Dim lama As Integer =
                CInt((dtpcheckout.Value.Date - dtpcheckin.Value.Date).TotalDays)

            If lama <= 0 Then lama = 1

            totalBiaya = harga * lama

            txttotalbiaya.Text = totalBiaya.ToString("N0")
            lblrincian.Text = lama.ToString() & " malam x Rp" &
                              harga.ToString("N0") & "/malam"

        Catch ex As Exception

            MessageBox.Show("Gagal menghitung total biaya: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If conn IsNot Nothing AndAlso
               conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        form_menu.Show()
        Me.Hide()
    End Sub

    Private Sub dtpcheckin_ValueChanged(sender As Object, e As EventArgs) Handles dtpcheckin.ValueChanged
        hitungtotal()
    End Sub

    Private Sub dtpcheckout_ValueChanged(sender As Object, e As EventArgs) Handles dtpcheckout.ValueChanged
        hitungtotal()
    End Sub

    Private Sub txttotalbiaya_TextChanged(sender As Object, e As EventArgs) Handles txttotalbiaya.TextChanged

    End Sub

    Private Sub cmbkamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkamar.SelectedIndexChanged
        hitungtotal()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cmbtamu.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tamu!")
            Exit Sub
        End If

        If cmbkamar.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kamar!")
            Exit Sub
        End If

        If dtpcheckout.Value.Date <= dtpcheckin.Value.Date Then
            MessageBox.Show("Tanggal check-out harus setelah tanggal check-in!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Hitung ulang dari pilihan terbaru supaya total yang disimpan tidak basi.
        hitungtotal()

        If totalBiaya <= 0 Then
            MessageBox.Show("Total biaya belum dapat dihitung.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try

            koneksi()

            Dim sqlStatus As String = "UPDATE kamar SET status_kamar = 'Terisi' " & "WHERE id_kamar = @id"

            Using cmdStatus As New SqlCommand(sqlStatus, conn)
                cmdStatus.Parameters.AddWithValue("@id", cmbkamar.SelectedValue)
                cmdStatus.ExecuteNonQuery()
            End Using

            Dim sql As String = "INSERT INTO reservasi(tamu,kamar,check_in,check_out,total_harga) VALUES (@tamu,@kamar,@ci,@co,@total)"

            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@tamu", cmbtamu.SelectedValue)
            cmd.Parameters.AddWithValue("@kamar", cmbkamar.SelectedValue)
            cmd.Parameters.AddWithValue("@ci", dtpcheckin.Value.Date)
            cmd.Parameters.AddWithValue("@co", dtpcheckout.Value.Date)
            cmd.Parameters.AddWithValue("@total", totalBiaya)

            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("UPDATE kamar SET status_kamar='Terisi' WHERE id_kamar=@id", conn)

            cmd.Parameters.AddWithValue("@id", cmbkamar.SelectedValue)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Reservasi berhasil disimpan!")

            conn.Close()

            loadkamar()
            TampilData()
            bersihkan()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub dgvreservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreservasi.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvreservasi.Rows(e.RowIndex)

        If row.Cells("id_reservasi").Value Is Nothing OrElse
           row.Cells("id_reservasi").Value Is DBNull.Value Then
            Exit Sub
        End If

        txtidreservasi.Text = row.Cells("id_reservasi").Value.ToString()

        If row.Cells("id_tamu").Value IsNot Nothing AndAlso
           row.Cells("id_tamu").Value IsNot DBNull.Value Then
            cmbtamu.SelectedValue = Convert.ToInt32(row.Cells("id_tamu").Value)
        End If

        If row.Cells("id_kamar").Value IsNot Nothing AndAlso
           row.Cells("id_kamar").Value IsNot DBNull.Value Then
            idKamarAwal = Convert.ToInt32(row.Cells("id_kamar").Value)

            loadkamar(idKamarAwal)
            cmbkamar.SelectedValue = idKamarAwal
        End If

        dtpcheckin.Value = Convert.ToDateTime(row.Cells("check_in").Value)
        dtpcheckout.Value = Convert.ToDateTime(row.Cells("check_out").Value)

        hitungtotal()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtidreservasi.Text.Trim() = "" Then
            MessageBox.Show("Pilih data reservasi yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbtamu.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tamu terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbkamar.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kamar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpcheckout.Value.Date <= dtpcheckin.Value.Date Then
            MessageBox.Show("Tanggal check-out harus setelah tanggal check-in!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idreservasi As Integer
        Dim idtamu As Integer
        Dim idkamarbaru As Integer

        If Not Integer.TryParse(txtidreservasi.Text.Trim(), idreservasi) OrElse
           Not Integer.TryParse(cmbtamu.SelectedValue.ToString(), idtamu) OrElse
           Not Integer.TryParse(cmbkamar.SelectedValue.ToString(), idkamarbaru) Then
            MessageBox.Show("Data reservasi tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        hitungtotal()

        If totalBiaya <= 0 Then
            MessageBox.Show("Total biaya belum dapat dihitung.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jawab As DialogResult = MessageBox.Show("Simpan perubahan data reservasi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawab = DialogResult.No Then
            Exit Sub
        End If

        Try
            koneksi()

            Using trans As SqlTransaction = conn.BeginTransaction()

                If idkamarbaru <> idKamarAwal Then
                    Using cmdCek As New SqlCommand("SELECT COUNT(*) FROM kamar " & "WHERE id_kamar=@id AND status_kamar='Tersedia'", conn, trans)

                        cmdCek.Parameters.AddWithValue("@id", idkamarbaru)

                        If Convert.ToInt32(cmdCek.ExecuteScalar()) = 0 Then
                            trans.Rollback()
                            MessageBox.Show("Kamar yang dipilih sudah tidak tersedia.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End Using
                End If

                Using cmdUpdate As New SqlCommand("UPDATE reservasi SET tamu=@tamu, kamar=@kamar, " & "check_in=@ci, check_out=@co, total_harga=@total " & "WHERE id_reservasi=@id", conn, trans)

                    cmdUpdate.Parameters.AddWithValue("@tamu", idtamu)
                    cmdUpdate.Parameters.AddWithValue("@kamar", idkamarbaru)
                    cmdUpdate.Parameters.AddWithValue("@ci", dtpcheckin.Value.Date)
                    cmdUpdate.Parameters.AddWithValue("@co", dtpcheckout.Value.Date)
                    cmdUpdate.Parameters.AddWithValue("@total", totalBiaya)
                    cmdUpdate.Parameters.AddWithValue("@id", idreservasi)

                    If cmdUpdate.ExecuteNonQuery() = 0 Then
                        trans.Rollback()
                        MessageBox.Show("Data reservasi tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                If idkamarbaru <> idKamarAwal AndAlso idKamarAwal > 0 Then
                    Using cmdKamarLama As New SqlCommand("UPDATE kamar SET status_kamar='Tersedia' WHERE id_kamar=@id", conn, trans)

                        cmdKamarLama.Parameters.AddWithValue("@id", idKamarAwal)
                        cmdKamarLama.ExecuteNonQuery()
                    End Using
                End If

                Using cmdKamarBaru As New SqlCommand("UPDATE kamar SET status_kamar='Terisi' WHERE id_kamar=@id", conn, trans)

                    cmdKamarBaru.Parameters.AddWithValue("@id", idkamarbaru)
                    cmdKamarBaru.ExecuteNonQuery()
                End Using

                trans.Commit()
            End Using

            MessageBox.Show("Data reservasi berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshData()

        Catch ex As Exception

            MessageBox.Show("Data reservasi gagal diubah!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtidreservasi.Text.Trim() = "" Then
            MessageBox.Show("Pilih data reservasi yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idreservasi As Integer

        If Not Integer.TryParse(txtidreservasi.Text.Trim(), idreservasi) Then
            MessageBox.Show("Data reservasi tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jawab As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data reservasi ini?" & vbCrLf & "Status kamar akan kembali menjadi Tersedia.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If jawab = DialogResult.No Then
            Exit Sub
        End If

        Try
            koneksi()

            Using trans As SqlTransaction = conn.BeginTransaction()

                Using cmdCekBayar As New SqlCommand(
                    "SELECT COUNT(*) FROM pembayaran WHERE id_reservasi=@id",
                    conn, trans)

                    cmdCekBayar.Parameters.AddWithValue("@id", idreservasi)

                    If Convert.ToInt32(cmdCekBayar.ExecuteScalar()) > 0 Then
                        trans.Rollback()
                        MessageBox.Show("Reservasi ini sudah memiliki data pembayaran " &
                                        "sehingga tidak dapat dihapus.",
                                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Dim idkamar As Integer = 0

                Using cmdKamar As New SqlCommand(
                    "SELECT kamar FROM reservasi WHERE id_reservasi=@id",
                    conn, trans)

                    cmdKamar.Parameters.AddWithValue("@id", idreservasi)

                    Dim hasil As Object = cmdKamar.ExecuteScalar()

                    If hasil Is Nothing OrElse hasil Is DBNull.Value Then
                        trans.Rollback()
                        MessageBox.Show("Data reservasi tidak ditemukan.",
                                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    idkamar = Convert.ToInt32(hasil)
                End Using

                Using cmdHapus As New SqlCommand(
                    "DELETE FROM reservasi WHERE id_reservasi=@id",
                    conn, trans)

                    cmdHapus.Parameters.AddWithValue("@id", idreservasi)

                    If cmdHapus.ExecuteNonQuery() = 0 Then
                        trans.Rollback()
                        MessageBox.Show("Data reservasi tidak ditemukan.",
                                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Using cmdSisa As New SqlCommand(
                    "SELECT COUNT(*) FROM reservasi WHERE kamar=@kamar",
                    conn, trans)

                    cmdSisa.Parameters.AddWithValue("@kamar", idkamar)

                    If Convert.ToInt32(cmdSisa.ExecuteScalar()) = 0 Then
                        Using cmdKamarTersedia As New SqlCommand(
                            "UPDATE kamar SET status_kamar='Tersedia' WHERE id_kamar=@id",
                            conn, trans)

                            cmdKamarTersedia.Parameters.AddWithValue("@id", idkamar)
                            cmdKamarTersedia.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                trans.Commit()
            End Using

            MessageBox.Show("Data reservasi berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshData()
            dgvreservasi.ClearSelection()

        Catch ex As Exception

            MessageBox.Show("Data reservasi gagal dihapus!" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersihkan()
    End Sub

    Private Sub dgvreservasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreservasi.CellContentClick

    End Sub
End Class