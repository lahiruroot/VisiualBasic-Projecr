<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMTC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMTC))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnload = New System.Windows.Forms.Button()
        Me.dgvMTC = New System.Windows.Forms.DataGridView()
        Me.dtpDOS = New System.Windows.Forms.DateTimePicker()
        Me.grbRecord = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtSeries = New System.Windows.Forms.TextBox()
        Me.txtTour = New System.Windows.Forms.TextBox()
        Me.txtMatchID = New System.Windows.Forms.TextBox()
        Me.lbldoj = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldepno = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.txtGround = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1233, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(903, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 31)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Lions   Cricket   Club"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(735, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 39)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "MATC CREATION FORM"
        '
        'btnload
        '
        Me.btnload.BackgroundImage = Global.Lionscricket.My.Resources.Resources._21
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(572, 478)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(172, 44)
        Me.btnload.TabIndex = 99
        Me.btnload.Text = "&Load "
        Me.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnload.UseVisualStyleBackColor = True
        '
        'dgvMTC
        '
        Me.dgvMTC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvMTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMTC.Location = New System.Drawing.Point(632, 153)
        Me.dgvMTC.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMTC.Name = "dgvMTC"
        Me.dgvMTC.Size = New System.Drawing.Size(748, 262)
        Me.dgvMTC.TabIndex = 101
        '
        'dtpDOS
        '
        Me.dtpDOS.Location = New System.Drawing.Point(188, 389)
        Me.dtpDOS.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOS.Name = "dtpDOS"
        Me.dtpDOS.Size = New System.Drawing.Size(292, 22)
        Me.dtpDOS.TabIndex = 97
        '
        'grbRecord
        '
        Me.grbRecord.BackColor = System.Drawing.Color.Transparent
        Me.grbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grbRecord.Controls.Add(Me.btnclear)
        Me.grbRecord.Controls.Add(Me.btndelete)
        Me.grbRecord.Controls.Add(Me.btnfind)
        Me.grbRecord.Controls.Add(Me.btnedit)
        Me.grbRecord.Controls.Add(Me.btnnew)
        Me.grbRecord.Controls.Add(Me.btnsave)
        Me.grbRecord.Enabled = False
        Me.grbRecord.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRecord.Location = New System.Drawing.Point(34, 440)
        Me.grbRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Name = "grbRecord"
        Me.grbRecord.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Size = New System.Drawing.Size(530, 147)
        Me.grbRecord.TabIndex = 100
        Me.grbRecord.TabStop = False
        Me.grbRecord.Text = "Record operation"
        '
        'btnclear
        '
        Me.btnclear.ForeColor = System.Drawing.Color.Blue
        Me.btnclear.Image = Global.Lionscricket.My.Resources.Resources.folder_documents_512
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(25, 90)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(146, 49)
        Me.btnclear.TabIndex = 25
        Me.btnclear.Text = "&Clear "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.ForeColor = System.Drawing.Color.Blue
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btndelete.Location = New System.Drawing.Point(357, 33)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(146, 49)
        Me.btndelete.TabIndex = 23
        Me.btndelete.Text = "&Delete "
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.BackgroundImage = CType(resources.GetObject("btnfind.BackgroundImage"), System.Drawing.Image)
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.ForeColor = System.Drawing.Color.Blue
        Me.btnfind.Location = New System.Drawing.Point(357, 90)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(146, 49)
        Me.btnfind.TabIndex = 12
        Me.btnfind.Text = "&Find "
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.ForeColor = System.Drawing.Color.Blue
        Me.btnedit.Location = New System.Drawing.Point(194, 33)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(146, 49)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "&Edit "
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Add_Male_User_Icon_32
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnew.Location = New System.Drawing.Point(25, 33)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(146, 49)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "&Add New "
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Save_Icon_32
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnsave.Location = New System.Drawing.Point(194, 90)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(146, 49)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtSeries
        '
        Me.txtSeries.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeries.Location = New System.Drawing.Point(188, 323)
        Me.txtSeries.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeries.Multiline = True
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(292, 33)
        Me.txtSeries.TabIndex = 89
        '
        'txtTour
        '
        Me.txtTour.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour.Location = New System.Drawing.Point(188, 212)
        Me.txtTour.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTour.Multiline = True
        Me.txtTour.Name = "txtTour"
        Me.txtTour.Size = New System.Drawing.Size(292, 35)
        Me.txtTour.TabIndex = 86
        '
        'txtMatchID
        '
        Me.txtMatchID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMatchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatchID.Location = New System.Drawing.Point(188, 153)
        Me.txtMatchID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatchID.MaxLength = 4
        Me.txtMatchID.Multiline = True
        Me.txtMatchID.Name = "txtMatchID"
        Me.txtMatchID.Size = New System.Drawing.Size(292, 30)
        Me.txtMatchID.TabIndex = 84
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbldoj.Location = New System.Drawing.Point(28, 380)
        Me.lbldoj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.Size = New System.Drawing.Size(84, 35)
        Me.lbldoj.TabIndex = 98
        Me.lbldoj.Text = "Date "
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblname.Location = New System.Drawing.Point(28, 269)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(112, 35)
        Me.lblname.TabIndex = 87
        Me.lblname.Text = "Ground"
        '
        'lbldepno
        '
        Me.lbldepno.AutoSize = True
        Me.lbldepno.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbldepno.Location = New System.Drawing.Point(28, 212)
        Me.lbldepno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepno.Name = "lbldepno"
        Me.lbldepno.Size = New System.Drawing.Size(149, 35)
        Me.lbldepno.TabIndex = 85
        Me.lbldepno.Text = "Tour With"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblempno.Location = New System.Drawing.Point(28, 149)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(135, 35)
        Me.lblempno.TabIndex = 83
        Me.lblempno.Text = "Match ID"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(28, 319)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(93, 35)
        Me.lbladdress.TabIndex = 88
        Me.lbladdress.Text = "Series"
        '
        'txtGround
        '
        Me.txtGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGround.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGround.Location = New System.Drawing.Point(188, 269)
        Me.txtGround.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGround.Multiline = True
        Me.txtGround.Name = "txtGround"
        Me.txtGround.Size = New System.Drawing.Size(292, 35)
        Me.txtGround.TabIndex = 91
        '
        'frmMTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1393, 591)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvMTC)
        Me.Controls.Add(Me.dtpDOS)
        Me.Controls.Add(Me.grbRecord)
        Me.Controls.Add(Me.txtGround)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtTour)
        Me.Controls.Add(Me.txtMatchID)
        Me.Controls.Add(Me.lbldoj)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbldepno)
        Me.Controls.Add(Me.lblempno)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMTC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match Cration"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRecord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents dgvMTC As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDOS As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbRecord As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtSeries As System.Windows.Forms.TextBox
    Friend WithEvents txtTour As System.Windows.Forms.TextBox
    Friend WithEvents txtMatchID As System.Windows.Forms.TextBox
    Friend WithEvents lbldoj As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbldepno As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents txtGround As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button

End Class
