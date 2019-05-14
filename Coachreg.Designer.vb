<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMT))
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txttelno = New System.Windows.Forms.TextBox()
        Me.txtExperince = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtCoachID = New System.Windows.Forms.TextBox()
        Me.lbldoj = New System.Windows.Forms.Label()
        Me.lblbsal = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lbltelno = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.dgvCMT = New System.Windows.Forms.DataGridView()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.dtpdoj = New System.Windows.Forms.DateTimePicker()
        Me.grbRecord = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.dgvCMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRecord.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(195, 446)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(292, 33)
        Me.txtAge.TabIndex = 115
        '
        'txttelno
        '
        Me.txttelno.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttelno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelno.Location = New System.Drawing.Point(195, 386)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelno.MaxLength = 10
        Me.txttelno.Multiline = True
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(292, 33)
        Me.txttelno.TabIndex = 112
        '
        'txtExperince
        '
        Me.txtExperince.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtExperince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExperince.Location = New System.Drawing.Point(195, 325)
        Me.txtExperince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExperince.Multiline = True
        Me.txtExperince.Name = "txtExperince"
        Me.txtExperince.Size = New System.Drawing.Size(292, 35)
        Me.txtExperince.TabIndex = 111
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(195, 216)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(292, 33)
        Me.txtname.TabIndex = 109
        '
        'txtCoachID
        '
        Me.txtCoachID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCoachID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoachID.Location = New System.Drawing.Point(195, 165)
        Me.txtCoachID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCoachID.MaxLength = 4
        Me.txtCoachID.Multiline = True
        Me.txtCoachID.Name = "txtCoachID"
        Me.txtCoachID.Size = New System.Drawing.Size(292, 30)
        Me.txtCoachID.TabIndex = 106
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoj.Location = New System.Drawing.Point(12, 506)
        Me.lbldoj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.Size = New System.Drawing.Size(134, 25)
        Me.lbldoj.TabIndex = 118
        Me.lbldoj.Text = "Date Of join"
        '
        'lblbsal
        '
        Me.lblbsal.AutoSize = True
        Me.lblbsal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbsal.Location = New System.Drawing.Point(10, 454)
        Me.lblbsal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbsal.Name = "lblbsal"
        Me.lblbsal.Size = New System.Drawing.Size(56, 25)
        Me.lblbsal.TabIndex = 114
        Me.lblbsal.Text = " Age"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(10, 275)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(148, 25)
        Me.lbldob.TabIndex = 113
        Me.lbldob.Text = "Date Of Birth"
        '
        'lbltelno
        '
        Me.lbltelno.AutoSize = True
        Me.lbltelno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelno.Location = New System.Drawing.Point(12, 394)
        Me.lbltelno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelno.Name = "lbltelno"
        Me.lbltelno.Size = New System.Drawing.Size(149, 25)
        Me.lbltelno.TabIndex = 110
        Me.lbltelno.Text = "Telephone No"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(12, 335)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(112, 25)
        Me.lbladdress.TabIndex = 108
        Me.lbladdress.Text = "Experince"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(10, 170)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(104, 25)
        Me.lblempno.TabIndex = 105
        Me.lblempno.Text = "Coach ID"
        '
        'dgvCMT
        '
        Me.dgvCMT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvCMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCMT.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dgvCMT.Location = New System.Drawing.Point(512, 165)
        Me.dgvCMT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCMT.Name = "dgvCMT"
        Me.dgvCMT.Size = New System.Drawing.Size(857, 262)
        Me.dgvCMT.TabIndex = 120
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(195, 278)
        Me.dtpdob.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(292, 22)
        Me.dtpdob.TabIndex = 116
        '
        'dtpdoj
        '
        Me.dtpdoj.Location = New System.Drawing.Point(195, 509)
        Me.dtpdoj.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdoj.Name = "dtpdoj"
        Me.dtpdoj.Size = New System.Drawing.Size(292, 22)
        Me.dtpdoj.TabIndex = 117
        '
        'grbRecord
        '
        Me.grbRecord.BackColor = System.Drawing.Color.Transparent
        Me.grbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grbRecord.Controls.Add(Me.btnfind)
        Me.grbRecord.Controls.Add(Me.Button1)
        Me.grbRecord.Controls.Add(Me.btnsave)
        Me.grbRecord.Controls.Add(Me.btnedit)
        Me.grbRecord.Controls.Add(Me.btnclear)
        Me.grbRecord.Controls.Add(Me.btnnew)
        Me.grbRecord.Enabled = False
        Me.grbRecord.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRecord.Location = New System.Drawing.Point(512, 446)
        Me.grbRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Name = "grbRecord"
        Me.grbRecord.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Size = New System.Drawing.Size(516, 147)
        Me.grbRecord.TabIndex = 119
        Me.grbRecord.TabStop = False
        Me.grbRecord.Text = "Record operation"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1223, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(916, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 31)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Lions   Cricket   Club"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(638, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 39)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "COACH   REGISTATION   FORM"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(11, 216)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(133, 25)
        Me.lblname.TabIndex = 107
        Me.lblname.Text = "Coach Name"
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Add_Male_User_Icon_32
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnew.Location = New System.Drawing.Point(36, 33)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(146, 49)
        Me.btnnew.TabIndex = 24
        Me.btnnew.Text = "&Add New "
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.ForeColor = System.Drawing.Color.Blue
        Me.btnclear.Image = Global.Lionscricket.My.Resources.Resources.folder_documents_512
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(36, 90)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(146, 49)
        Me.btnclear.TabIndex = 26
        Me.btnclear.Text = "&Clear "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.ForeColor = System.Drawing.Color.Blue
        Me.btnedit.Location = New System.Drawing.Point(190, 33)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(146, 49)
        Me.btnedit.TabIndex = 27
        Me.btnedit.Text = "&Edit "
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Save_Icon_32
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Blue
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnsave.Location = New System.Drawing.Point(190, 90)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(146, 49)
        Me.btnsave.TabIndex = 28
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button1.Location = New System.Drawing.Point(344, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 49)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Delete "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.BackgroundImage = CType(resources.GetObject("btnfind.BackgroundImage"), System.Drawing.Image)
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.ForeColor = System.Drawing.Color.Blue
        Me.btnfind.Location = New System.Drawing.Point(344, 90)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(146, 49)
        Me.btnfind.TabIndex = 30
        Me.btnfind.Text = "&Find "
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.BackgroundImage = Global.Lionscricket.My.Resources.Resources._21
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(1049, 506)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(165, 48)
        Me.btnload.TabIndex = 124
        Me.btnload.Text = "&Load "
        Me.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnload.UseVisualStyleBackColor = True
        '
        'frmCMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1393, 622)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txttelno)
        Me.Controls.Add(Me.txtExperince)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtCoachID)
        Me.Controls.Add(Me.lbldoj)
        Me.Controls.Add(Me.lblbsal)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lbltelno)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.dgvCMT)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.dtpdoj)
        Me.Controls.Add(Me.grbRecord)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCMT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAUCH REGISTATION FORM"
        CType(Me.dgvCMT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRecord.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txttelno As System.Windows.Forms.TextBox
    Friend WithEvents txtExperince As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtCoachID As System.Windows.Forms.TextBox
    Friend WithEvents lbldoj As System.Windows.Forms.Label
    Friend WithEvents lblbsal As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lbltelno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents dgvCMT As System.Windows.Forms.DataGridView
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbRecord As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
End Class
