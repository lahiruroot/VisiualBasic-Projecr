<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEMT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEMT))
        Me.txtPlayearID = New System.Windows.Forms.TextBox()
        Me.lbldoj = New System.Windows.Forms.Label()
        Me.lblbsal = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lbltelno = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtPlayearNO = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnload = New System.Windows.Forms.Button()
        Me.dgvEMT = New System.Windows.Forms.DataGridView()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.dtpdoj = New System.Windows.Forms.DateTimePicker()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txttelno = New System.Windows.Forms.TextBox()
        Me.lbldepno = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.grbRecord = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPlayearID
        '
        Me.txtPlayearID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlayearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayearID.Location = New System.Drawing.Point(199, 155)
        Me.txtPlayearID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayearID.MaxLength = 4
        Me.txtPlayearID.Multiline = True
        Me.txtPlayearID.Name = "txtPlayearID"
        Me.txtPlayearID.Size = New System.Drawing.Size(292, 30)
        Me.txtPlayearID.TabIndex = 106
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoj.Location = New System.Drawing.Point(14, 565)
        Me.lbldoj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.Size = New System.Drawing.Size(134, 25)
        Me.lbldoj.TabIndex = 120
        Me.lbldoj.Text = "Date Of join"
        '
        'lblbsal
        '
        Me.lblbsal.AutoSize = True
        Me.lblbsal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbsal.Location = New System.Drawing.Point(14, 458)
        Me.lblbsal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbsal.Name = "lblbsal"
        Me.lblbsal.Size = New System.Drawing.Size(132, 25)
        Me.lblbsal.TabIndex = 116
        Me.lblbsal.Text = "Palyear Age"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(14, 512)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(148, 25)
        Me.lbldob.TabIndex = 115
        Me.lbldob.Text = "Date Of Birth"
        '
        'lbltelno
        '
        Me.lbltelno.AutoSize = True
        Me.lbltelno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelno.Location = New System.Drawing.Point(11, 402)
        Me.lbltelno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelno.Name = "lbltelno"
        Me.lbltelno.Size = New System.Drawing.Size(149, 25)
        Me.lbltelno.TabIndex = 112
        Me.lbltelno.Text = "Telephone No"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(14, 342)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(88, 25)
        Me.lbladdress.TabIndex = 110
        Me.lbladdress.Text = "Address"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(11, 280)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(151, 25)
        Me.lblname.TabIndex = 109
        Me.lblname.Text = "Playear Name"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(14, 160)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(122, 25)
        Me.lblempno.TabIndex = 105
        Me.lblempno.Text = "Playear ID"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(199, 332)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(292, 35)
        Me.txtaddress.TabIndex = 113
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(199, 272)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(292, 33)
        Me.txtname.TabIndex = 111
        '
        'txtPlayearNO
        '
        Me.txtPlayearNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlayearNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayearNO.Location = New System.Drawing.Point(199, 214)
        Me.txtPlayearNO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayearNO.Multiline = True
        Me.txtPlayearNO.Name = "txtPlayearNO"
        Me.txtPlayearNO.Size = New System.Drawing.Size(292, 35)
        Me.txtPlayearNO.TabIndex = 108
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1227, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 126
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(897, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 31)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Lions   Cricket   Club"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "PLAYEAR   REGISTATION   FORM"
        '
        'btnload
        '
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(1237, 425)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(136, 43)
        Me.btnload.TabIndex = 121
        Me.btnload.Text = "&Load"
        Me.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnload.UseVisualStyleBackColor = True
        '
        'dgvEMT
        '
        Me.dgvEMT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvEMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMT.Location = New System.Drawing.Point(510, 155)
        Me.dgvEMT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEMT.Name = "dgvEMT"
        Me.dgvEMT.Size = New System.Drawing.Size(863, 262)
        Me.dgvEMT.TabIndex = 123
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(199, 515)
        Me.dtpdob.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(292, 22)
        Me.dtpdob.TabIndex = 118
        '
        'dtpdoj
        '
        Me.dtpdoj.Location = New System.Drawing.Point(199, 566)
        Me.dtpdoj.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdoj.Name = "dtpdoj"
        Me.dtpdoj.Size = New System.Drawing.Size(292, 22)
        Me.dtpdoj.TabIndex = 119
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(199, 451)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(292, 33)
        Me.txtAge.TabIndex = 117
        '
        'txttelno
        '
        Me.txttelno.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttelno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelno.Location = New System.Drawing.Point(199, 394)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelno.MaxLength = 10
        Me.txttelno.Multiline = True
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(292, 33)
        Me.txttelno.TabIndex = 114
        '
        'lbldepno
        '
        Me.lbldepno.AutoSize = True
        Me.lbldepno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepno.Location = New System.Drawing.Point(14, 224)
        Me.lbldepno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepno.Name = "lbldepno"
        Me.lbldepno.Size = New System.Drawing.Size(112, 25)
        Me.lbldepno.TabIndex = 107
        Me.lbldepno.Text = "Player No"
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(197, 93)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(167, 53)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = CType(resources.GetObject("btnnew.BackgroundImage"), System.Drawing.Image)
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnew.Location = New System.Drawing.Point(9, 29)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(167, 53)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "&Add  New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(197, 29)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(167, 53)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "&Edit "
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.BackgroundImage = CType(resources.GetObject("btnfind.BackgroundImage"), System.Drawing.Image)
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnfind.Location = New System.Drawing.Point(384, 29)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(167, 53)
        Me.btnfind.TabIndex = 12
        Me.btnfind.Text = "&Find "
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(384, 93)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(167, 53)
        Me.btndelete.TabIndex = 23
        Me.btndelete.Text = "&Delete "
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
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
        Me.grbRecord.Location = New System.Drawing.Point(510, 442)
        Me.grbRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Name = "grbRecord"
        Me.grbRecord.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Size = New System.Drawing.Size(586, 167)
        Me.grbRecord.TabIndex = 122
        Me.grbRecord.TabStop = False
        Me.grbRecord.Text = "Record operation"
        '
        'btnclear
        '
        Me.btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.Image = Global.Lionscricket.My.Resources.Resources.folder_documents_512
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(9, 97)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(167, 49)
        Me.btnclear.TabIndex = 24
        Me.btnclear.Text = "&Clear "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'frmEMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1393, 622)
        Me.Controls.Add(Me.txtPlayearID)
        Me.Controls.Add(Me.lbldoj)
        Me.Controls.Add(Me.lblbsal)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lbltelno)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtPlayearNO)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvEMT)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.dtpdoj)
        Me.Controls.Add(Me.grbRecord)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txttelno)
        Me.Controls.Add(Me.lbldepno)
        Me.Name = "frmEMT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Playear Registration Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEMT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRecord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlayearID As System.Windows.Forms.TextBox
    Friend WithEvents lbldoj As System.Windows.Forms.Label
    Friend WithEvents lblbsal As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lbltelno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayearNO As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents dgvEMT As System.Windows.Forms.DataGridView
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txttelno As System.Windows.Forms.TextBox
    Friend WithEvents lbldepno As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents grbRecord As System.Windows.Forms.GroupBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
