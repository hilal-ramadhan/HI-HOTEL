<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_data_kamar
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
        Me.lblidkamar = New System.Windows.Forms.Label()
        Me.lblnokamar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtnokamar = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtidkamar = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Panelheader = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.lbltipekamar = New System.Windows.Forms.Label()
        Me.cmbtipekamar = New System.Windows.Forms.ComboBox()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.dgvkamar = New System.Windows.Forms.DataGridView()
        Me.Panelheader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvkamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblidkamar
        '
        Me.lblidkamar.AutoSize = True
        Me.lblidkamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidkamar.Location = New System.Drawing.Point(48, 117)
        Me.lblidkamar.Name = "lblidkamar"
        Me.lblidkamar.Size = New System.Drawing.Size(67, 13)
        Me.lblidkamar.TabIndex = 0
        Me.lblidkamar.Text = "ID KAMAR"
        '
        'lblnokamar
        '
        Me.lblnokamar.AutoSize = True
        Me.lblnokamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnokamar.Location = New System.Drawing.Point(27, 66)
        Me.lblnokamar.Name = "lblnokamar"
        Me.lblnokamar.Size = New System.Drawing.Size(62, 13)
        Me.lblnokamar.TabIndex = 1
        Me.lblnokamar.Text = "No Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(859, 762)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipe Kamar"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.Location = New System.Drawing.Point(48, 249)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(83, 13)
        Me.lblharga.TabIndex = 3
        Me.lblharga.Text = "Harga/Malam"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(919, 855)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'txtnokamar
        '
        Me.txtnokamar.Location = New System.Drawing.Point(154, 59)
        Me.txtnokamar.Name = "txtnokamar"
        Me.txtnokamar.Size = New System.Drawing.Size(200, 20)
        Me.txtnokamar.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(957, 759)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'txtidkamar
        '
        Me.txtidkamar.Enabled = False
        Me.txtidkamar.Location = New System.Drawing.Point(154, 14)
        Me.txtidkamar.Name = "txtidkamar"
        Me.txtidkamar.Size = New System.Drawing.Size(200, 20)
        Me.txtidkamar.TabIndex = 7
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
        Me.btnsimpan.TabIndex = 8
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
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
        Me.btnedit.TabIndex = 9
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
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
        Me.btnhapus.TabIndex = 10
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
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
        Me.btnbatal.TabIndex = 11
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(48, 284)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(43, 13)
        Me.lblstatus.TabIndex = 12
        Me.lblstatus.Text = "Status"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(154, 146)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(200, 20)
        Me.txtharga.TabIndex = 13
        '
        'Panelheader
        '
        Me.Panelheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panelheader.Controls.Add(Me.Panel2)
        Me.Panelheader.Controls.Add(Me.lbljudul)
        Me.Panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelheader.Location = New System.Drawing.Point(0, 0)
        Me.Panelheader.Name = "Panelheader"
        Me.Panelheader.Size = New System.Drawing.Size(743, 80)
        Me.Panelheader.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(51, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 3)
        Me.Panel2.TabIndex = 1
        '
        'lbljudul
        '
        Me.lbljudul.AutoSize = True
        Me.lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.White
        Me.lbljudul.Location = New System.Drawing.Point(213, 23)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(304, 31)
        Me.lbljudul.TabIndex = 0
        Me.lbljudul.Text = "DATA KAMAR HOTEL"
        '
        'lbltipekamar
        '
        Me.lbltipekamar.AutoSize = True
        Me.lbltipekamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipekamar.Location = New System.Drawing.Point(48, 210)
        Me.lbltipekamar.Name = "lbltipekamar"
        Me.lbltipekamar.Size = New System.Drawing.Size(70, 13)
        Me.lbltipekamar.TabIndex = 15
        Me.lbltipekamar.Text = "Tipe kamar"
        '
        'cmbtipekamar
        '
        Me.cmbtipekamar.FormattingEnabled = True
        Me.cmbtipekamar.Items.AddRange(New Object() {"Standard", "Deluxe", "Suite"})
        Me.cmbtipekamar.Location = New System.Drawing.Point(154, 106)
        Me.cmbtipekamar.Name = "cmbtipekamar"
        Me.cmbtipekamar.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipekamar.TabIndex = 16
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Tersedia", "Terisi"})
        Me.cmbstatus.Location = New System.Drawing.Point(154, 180)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatus.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Controls.Add(Me.btnkembali)
        Me.Panel1.Controls.Add(Me.btnbatal)
        Me.Panel1.Controls.Add(Me.btnhapus)
        Me.Panel1.Controls.Add(Me.lblnokamar)
        Me.Panel1.Controls.Add(Me.txtnokamar)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.txtidkamar)
        Me.Panel1.Controls.Add(Me.cmbtipekamar)
        Me.Panel1.Controls.Add(Me.txtharga)
        Me.Panel1.Controls.Add(Me.cmbstatus)
        Me.Panel1.Location = New System.Drawing.Point(21, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 281)
        Me.Panel1.TabIndex = 18
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
        Me.btnkembali.TabIndex = 18
        Me.btnkembali.Text = "KEMBALI"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'dgvkamar
        '
        Me.dgvkamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkamar.Location = New System.Drawing.Point(21, 396)
        Me.dgvkamar.Name = "dgvkamar"
        Me.dgvkamar.Size = New System.Drawing.Size(700, 170)
        Me.dgvkamar.TabIndex = 19
        '
        'Form_data_kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 576)
        Me.Controls.Add(Me.dgvkamar)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.lbltipekamar)
        Me.Controls.Add(Me.lblidkamar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelheader)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form_data_kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panelheader.ResumeLayout(False)
        Me.Panelheader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvkamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblidkamar As Label
    Friend WithEvents lblnokamar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtnokamar As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtidkamar As TextBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents lblstatus As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Panelheader As Panel
    Friend WithEvents lbljudul As Label
    Friend WithEvents lbltipekamar As Label
    Friend WithEvents cmbtipekamar As ComboBox
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnkembali As Button
    Friend WithEvents dgvkamar As DataGridView
    Friend WithEvents Panel2 As Panel
End Class
