<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTSF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTSF))
        Me.txtPlayearID = New System.Windows.Forms.TextBox()
        Me.lblbsal = New System.Windows.Forms.Label()
        Me.lbltelno = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtPlayearNO = New System.Windows.Forms.TextBox()
        Me.txtstats = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTSF = New System.Windows.Forms.DataGridView()
        Me.grbRecord = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lbldepno = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        CType(Me.dgvTSF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRecord.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPlayearID
        '
        Me.txtPlayearID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlayearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayearID.Location = New System.Drawing.Point(229, 36)
        Me.txtPlayearID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayearID.MaxLength = 4
        Me.txtPlayearID.Multiline = True
        Me.txtPlayearID.Name = "txtPlayearID"
        Me.txtPlayearID.Size = New System.Drawing.Size(293, 45)
        Me.txtPlayearID.TabIndex = 128
        '
        'lblbsal
        '
        Me.lblbsal.AutoSize = True
        Me.lblbsal.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbsal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblbsal.Location = New System.Drawing.Point(16, 264)
        Me.lblbsal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbsal.Name = "lblbsal"
        Me.lblbsal.Size = New System.Drawing.Size(172, 35)
        Me.lblbsal.TabIndex = 138
        Me.lblbsal.Text = "Palyear Age"
        '
        'lbltelno
        '
        Me.lbltelno.AutoSize = True
        Me.lbltelno.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbltelno.Location = New System.Drawing.Point(16, 341)
        Me.lbltelno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelno.Name = "lbltelno"
        Me.lbltelno.Size = New System.Drawing.Size(78, 35)
        Me.lbltelno.TabIndex = 134
        Me.lbltelno.Text = "Stats"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblname.Location = New System.Drawing.Point(16, 189)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(197, 35)
        Me.lblname.TabIndex = 131
        Me.lblname.Text = "Playear Name"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblempno.Location = New System.Drawing.Point(16, 36)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(151, 35)
        Me.lblempno.TabIndex = 127
        Me.lblempno.Text = "Playear ID"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(229, 189)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(293, 41)
        Me.txtname.TabIndex = 133
        '
        'txtPlayearNO
        '
        Me.txtPlayearNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlayearNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayearNO.Location = New System.Drawing.Point(229, 113)
        Me.txtPlayearNO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayearNO.Multiline = True
        Me.txtPlayearNO.Name = "txtPlayearNO"
        Me.txtPlayearNO.Size = New System.Drawing.Size(293, 43)
        Me.txtPlayearNO.TabIndex = 130
        '
        'txtstats
        '
        Me.txtstats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstats.Location = New System.Drawing.Point(229, 341)
        Me.txtstats.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstats.MaxLength = 10
        Me.txtstats.Multiline = True
        Me.txtstats.Name = "txtstats"
        Me.txtstats.Size = New System.Drawing.Size(293, 41)
        Me.txtstats.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(956, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 30)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Lions   Cricket   Club"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateGray
        Me.Label1.Location = New System.Drawing.Point(798, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 39)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "TEAM SELECTION   FORM"
        '
        'dgvTSF
        '
        Me.dgvTSF.BackgroundColor = System.Drawing.Color.Moccasin
        Me.dgvTSF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTSF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvTSF.Location = New System.Drawing.Point(557, 143)
        Me.dgvTSF.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTSF.Name = "dgvTSF"
        Me.dgvTSF.Size = New System.Drawing.Size(853, 398)
        Me.dgvTSF.TabIndex = 145
        '
        'grbRecord
        '
        Me.grbRecord.BackColor = System.Drawing.Color.Transparent
        Me.grbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grbRecord.Controls.Add(Me.btndelete)
        Me.grbRecord.Controls.Add(Me.btnfind)
        Me.grbRecord.Controls.Add(Me.btnclear)
        Me.grbRecord.Controls.Add(Me.btnedit)
        Me.grbRecord.Controls.Add(Me.btnnew)
        Me.grbRecord.Controls.Add(Me.btnsave)
        Me.grbRecord.Enabled = False
        Me.grbRecord.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRecord.ForeColor = System.Drawing.Color.Navy
        Me.grbRecord.Location = New System.Drawing.Point(13, 390)
        Me.grbRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Name = "grbRecord"
        Me.grbRecord.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Size = New System.Drawing.Size(536, 147)
        Me.grbRecord.TabIndex = 144
        Me.grbRecord.TabStop = False
        Me.grbRecord.Text = "Record operation"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(229, 264)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(293, 41)
        Me.txtAge.TabIndex = 139
        '
        'lbldepno
        '
        Me.lbldepno.AutoSize = True
        Me.lbldepno.Font = New System.Drawing.Font("Adobe Fangsong Std R", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbldepno.Location = New System.Drawing.Point(16, 115)
        Me.lbldepno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepno.Name = "lbldepno"
        Me.lbldepno.Size = New System.Drawing.Size(144, 35)
        Me.lbldepno.TabIndex = 129
        Me.lbldepno.Text = "Player No"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1269, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 148
        Me.PictureBox2.TabStop = False
        '
        'btnload
        '
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnload.Image = Global.Lionscricket.My.Resources.Resources._21
        Me.btnload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnload.Location = New System.Drawing.Point(562, 87)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(197, 48)
        Me.btnload.TabIndex = 143
        Me.btnload.Text = "&Load database"
        Me.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Image = Global.Lionscricket.My.Resources.Resources.Remove_Male_User_Icon_48
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(370, 91)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(148, 51)
        Me.btndelete.TabIndex = 23
        Me.btndelete.Text = "&Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Search_Male_User_Icon_48
        Me.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfind.Location = New System.Drawing.Point(370, 30)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(148, 53)
        Me.btnfind.TabIndex = 12
        Me.btnfind.Text = "&Find "
        Me.btnfind.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = Global.Lionscricket.My.Resources.Resources.folder_documents_512
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(25, 90)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(167, 49)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "&Clear "
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Lionscricket.My.Resources.Resources.Edit_Male_User_Icon_48
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(200, 29)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(153, 53)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "&Edit "
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = Global.Lionscricket.My.Resources.Resources.Add_Male_User_Icon_48
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(25, 29)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(167, 53)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "&Add New "
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Lionscricket.My.Resources.Resources.Save_Icon_32
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(200, 90)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(153, 51)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save "
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmTSF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1428, 543)
        Me.Controls.Add(Me.txtPlayearID)
        Me.Controls.Add(Me.lblbsal)
        Me.Controls.Add(Me.lbltelno)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtPlayearNO)
        Me.Controls.Add(Me.txtstats)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvTSF)
        Me.Controls.Add(Me.grbRecord)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lbldepno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTSF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTSF"
        CType(Me.dgvTSF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRecord.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlayearID As System.Windows.Forms.TextBox
    Friend WithEvents lblbsal As System.Windows.Forms.Label
    Friend WithEvents lbltelno As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayearNO As System.Windows.Forms.TextBox
    Friend WithEvents txtstats As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents dgvTSF As System.Windows.Forms.DataGridView
    Friend WithEvents grbRecord As System.Windows.Forms.GroupBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lbldepno As System.Windows.Forms.Label
End Class
