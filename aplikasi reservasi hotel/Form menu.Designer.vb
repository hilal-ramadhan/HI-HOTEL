<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_menu
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
        Me.btntamu = New System.Windows.Forms.Button()
        Me.btnkamar = New System.Windows.Forms.Button()
        Me.btnreservasi = New System.Windows.Forms.Button()
        Me.btnpembayaran = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panelheader = New System.Windows.Forms.Panel()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.lblmenu = New System.Windows.Forms.Label()
        Me.Panelcontent = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.Panelheader.SuspendLayout()
        Me.panelmenu.SuspendLayout()
        Me.Panelcontent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntamu
        '
        Me.btntamu.BackColor = System.Drawing.Color.White
        Me.btntamu.FlatAppearance.BorderSize = 0
        Me.btntamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntamu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btntamu.Location = New System.Drawing.Point(0, 83)
        Me.btntamu.Name = "btntamu"
        Me.btntamu.Size = New System.Drawing.Size(203, 47)
        Me.btntamu.TabIndex = 1
        Me.btntamu.Text = "👤 Data Tamu"
        Me.btntamu.UseVisualStyleBackColor = False
        '
        'btnkamar
        '
        Me.btnkamar.BackColor = System.Drawing.Color.White
        Me.btnkamar.FlatAppearance.BorderSize = 0
        Me.btnkamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnkamar.Location = New System.Drawing.Point(-1, 149)
        Me.btnkamar.Name = "btnkamar"
        Me.btnkamar.Size = New System.Drawing.Size(200, 47)
        Me.btnkamar.TabIndex = 2
        Me.btnkamar.Text = "🛏️ Data Kamar"
        Me.btnkamar.UseVisualStyleBackColor = False
        '
        'btnreservasi
        '
        Me.btnreservasi.BackColor = System.Drawing.Color.White
        Me.btnreservasi.FlatAppearance.BorderSize = 0
        Me.btnreservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreservasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreservasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnreservasi.Location = New System.Drawing.Point(0, 217)
        Me.btnreservasi.Name = "btnreservasi"
        Me.btnreservasi.Size = New System.Drawing.Size(200, 47)
        Me.btnreservasi.TabIndex = 3
        Me.btnreservasi.Text = "📋 Reservasi"
        Me.btnreservasi.UseVisualStyleBackColor = False
        '
        'btnpembayaran
        '
        Me.btnpembayaran.BackColor = System.Drawing.Color.White
        Me.btnpembayaran.FlatAppearance.BorderSize = 0
        Me.btnpembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnpembayaran.Location = New System.Drawing.Point(0, 283)
        Me.btnpembayaran.Name = "btnpembayaran"
        Me.btnpembayaran.Size = New System.Drawing.Size(200, 47)
        Me.btnpembayaran.TabIndex = 4
        Me.btnpembayaran.Text = "💳 Pembayaran"
        Me.btnpembayaran.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.White
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(-1, 393)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(200, 47)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Panelheader
        '
        Me.Panelheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panelheader.Controls.Add(Me.lbljudul)
        Me.Panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelheader.Location = New System.Drawing.Point(0, 0)
        Me.Panelheader.Name = "Panelheader"
        Me.Panelheader.Size = New System.Drawing.Size(909, 100)
        Me.Panelheader.TabIndex = 6
        '
        'lbljudul
        '
        Me.lbljudul.AutoSize = True
        Me.lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.White
        Me.lbljudul.Location = New System.Drawing.Point(345, 32)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(283, 31)
        Me.lbljudul.TabIndex = 0
        Me.lbljudul.Text = "RESERVASI HOTEL"
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.lblmenu)
        Me.panelmenu.Controls.Add(Me.btntamu)
        Me.panelmenu.Controls.Add(Me.btnkamar)
        Me.panelmenu.Controls.Add(Me.btnlogout)
        Me.panelmenu.Controls.Add(Me.btnpembayaran)
        Me.panelmenu.Controls.Add(Me.btnreservasi)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 100)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(200, 471)
        Me.panelmenu.TabIndex = 7
        '
        'lblmenu
        '
        Me.lblmenu.AutoSize = True
        Me.lblmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmenu.ForeColor = System.Drawing.Color.White
        Me.lblmenu.Location = New System.Drawing.Point(65, 20)
        Me.lblmenu.Name = "lblmenu"
        Me.lblmenu.Size = New System.Drawing.Size(70, 24)
        Me.lblmenu.TabIndex = 0
        Me.lblmenu.Text = "MENU"
        '
        'Panelcontent
        '
        Me.Panelcontent.Controls.Add(Me.PictureBox1)
        Me.Panelcontent.Controls.Add(Me.lblwelcome)
        Me.Panelcontent.Controls.Add(Me.lblinfo)
        Me.Panelcontent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontent.Location = New System.Drawing.Point(200, 100)
        Me.Panelcontent.Name = "Panelcontent"
        Me.Panelcontent.Size = New System.Drawing.Size(709, 471)
        Me.Panelcontent.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.aplikasi_reservasi_hotel.My.Resources.Resources.ChatGPT_Image_Sep_4__2026__06_07_23_PM
        Me.PictureBox1.Location = New System.Drawing.Point(151, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblwelcome.Location = New System.Drawing.Point(168, 29)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(326, 37)
        Me.lblwelcome.TabIndex = 0
        Me.lblwelcome.Text = "SELAMAT DATANG"
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(203, 375)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(291, 40)
        Me.lblinfo.TabIndex = 1
        Me.lblinfo.Text = "Silakan pilih menu untuk mengelola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 reservasi hotel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 571)
        Me.Controls.Add(Me.Panelcontent)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.Panelheader)
        Me.Name = "form_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form - Menu"
        Me.Panelheader.ResumeLayout(False)
        Me.Panelheader.PerformLayout()
        Me.panelmenu.ResumeLayout(False)
        Me.panelmenu.PerformLayout()
        Me.Panelcontent.ResumeLayout(False)
        Me.Panelcontent.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btntamu As Button
    Friend WithEvents btnkamar As Button
    Friend WithEvents btnreservasi As Button
    Friend WithEvents btnpembayaran As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Panelheader As Panel
    Friend WithEvents lbljudul As Label
    Friend WithEvents panelmenu As Panel
    Friend WithEvents lblmenu As Label
    Friend WithEvents Panelcontent As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents lblinfo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
