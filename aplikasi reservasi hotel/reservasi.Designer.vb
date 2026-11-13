<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidreservasi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbkamar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpcheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.cmbtamu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpcheckin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotalbiaya = New System.Windows.Forms.TextBox()
        Me.lblrincian = New System.Windows.Forms.Label()
        Me.dgvreservasi = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvreservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lbljudul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 80)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(23, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(701, 3)
        Me.Panel3.TabIndex = 17
        '
        'lbljudul
        '
        Me.lbljudul.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbljudul.AutoSize = True
        Me.lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.White
        Me.lbljudul.Location = New System.Drawing.Point(287, 21)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(179, 31)
        Me.lbljudul.TabIndex = 25
        Me.lbljudul.Text = "RESERVASI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID RESERVASI"
        '
        'txtidreservasi
        '
        Me.txtidreservasi.Location = New System.Drawing.Point(29, 50)
        Me.txtidreservasi.Name = "txtidreservasi"
        Me.txtidreservasi.ReadOnly = True
        Me.txtidreservasi.Size = New System.Drawing.Size(309, 20)
        Me.txtidreservasi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "KAMAR"
        '
        'cmbkamar
        '
        Me.cmbkamar.FormattingEnabled = True
        Me.cmbkamar.Location = New System.Drawing.Point(29, 101)
        Me.cmbkamar.Name = "cmbkamar"
        Me.cmbkamar.Size = New System.Drawing.Size(309, 21)
        Me.cmbkamar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal Check-out"
        '
        'dtpcheckout
        '
        Me.dtpcheckout.Location = New System.Drawing.Point(29, 148)
        Me.dtpcheckout.Name = "dtpcheckout"
        Me.dtpcheckout.Size = New System.Drawing.Size(309, 20)
        Me.dtpcheckout.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status Reservasi"
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"dikonfirmasi", "dibatalkan"})
        Me.cmbstatus.Location = New System.Drawing.Point(29, 195)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(309, 21)
        Me.cmbstatus.TabIndex = 8
        '
        'cmbtamu
        '
        Me.cmbtamu.FormattingEnabled = True
        Me.cmbtamu.Location = New System.Drawing.Point(350, 49)
        Me.cmbtamu.Name = "cmbtamu"
        Me.cmbtamu.Size = New System.Drawing.Size(309, 21)
        Me.cmbtamu.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(347, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tamu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(347, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tanggal Check-in"
        '
        'dtpcheckin
        '
        Me.dtpcheckin.Location = New System.Drawing.Point(350, 101)
        Me.dtpcheckin.Name = "dtpcheckin"
        Me.dtpcheckin.Size = New System.Drawing.Size(309, 20)
        Me.dtpcheckin.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Biaya"
        '
        'txttotalbiaya
        '
        Me.txttotalbiaya.Location = New System.Drawing.Point(350, 148)
        Me.txttotalbiaya.Name = "txttotalbiaya"
        Me.txttotalbiaya.Size = New System.Drawing.Size(309, 20)
        Me.txttotalbiaya.TabIndex = 14
        '
        'lblrincian
        '
        Me.lblrincian.AutoSize = True
        Me.lblrincian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrincian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblrincian.Location = New System.Drawing.Point(350, 174)
        Me.lblrincian.Name = "lblrincian"
        Me.lblrincian.Size = New System.Drawing.Size(0, 13)
        Me.lblrincian.TabIndex = 25
        '
        'dgvreservasi
        '
        Me.dgvreservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreservasi.Location = New System.Drawing.Point(24, 397)
        Me.dgvreservasi.Name = "dgvreservasi"
        Me.dgvreservasi.Size = New System.Drawing.Size(700, 167)
        Me.dgvreservasi.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnkembali)
        Me.Panel2.Controls.Add(Me.btnbatal)
        Me.Panel2.Controls.Add(Me.btnhapus)
        Me.Panel2.Controls.Add(Me.btnedit)
        Me.Panel2.Controls.Add(Me.btnsimpan)
        Me.Panel2.Controls.Add(Me.txtidreservasi)
        Me.Panel2.Controls.Add(Me.txttotalbiaya)
        Me.Panel2.Controls.Add(Me.lblrincian)
        Me.Panel2.Controls.Add(Me.dtpcheckout)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpcheckin)
        Me.Panel2.Controls.Add(Me.cmbkamar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbstatus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmbtamu)
        Me.Panel2.Location = New System.Drawing.Point(24, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 281)
        Me.Panel2.TabIndex = 16
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembali.ForeColor = System.Drawing.Color.White
        Me.btnkembali.Location = New System.Drawing.Point(520, 233)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(100, 40)
        Me.btnkembali.TabIndex = 24
        Me.btnkembali.Text = "KEMBALI"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(400, 233)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(100, 40)
        Me.btnbatal.TabIndex = 23
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(280, 233)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 40)
        Me.btnhapus.TabIndex = 22
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(160, 233)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 40)
        Me.btnedit.TabIndex = 21
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(40, 233)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 40)
        Me.btnsimpan.TabIndex = 20
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'reservasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 576)
        Me.Controls.Add(Me.dgvreservasi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "reservasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvreservasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidreservasi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbkamar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpcheckout As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents cmbtamu As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpcheckin As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txttotalbiaya As TextBox
    Friend WithEvents lblrincian As Label
    Friend WithEvents dgvreservasi As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents lbljudul As Label
    Friend WithEvents Panel3 As Panel
End Class
