<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.dtpdoj = New System.Windows.Forms.DateTimePicker()
        Me.lbldoj = New System.Windows.Forms.Label()
        Me.lblbsal = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldepno = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.lbl03 = New System.Windows.Forms.Label()
        Me.lbl04 = New System.Windows.Forms.Label()
        Me.dgvEMT = New System.Windows.Forms.DataGridView()
        Me.txtPlayearID = New System.Windows.Forms.TextBox()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvEMT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(264, 417)
        Me.dtpdob.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(292, 22)
        Me.dtpdob.TabIndex = 112
        '
        'dtpdoj
        '
        Me.dtpdoj.Location = New System.Drawing.Point(264, 468)
        Me.dtpdoj.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdoj.Name = "dtpdoj"
        Me.dtpdoj.Size = New System.Drawing.Size(292, 22)
        Me.dtpdoj.TabIndex = 113
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoj.Location = New System.Drawing.Point(79, 467)
        Me.lbldoj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.Size = New System.Drawing.Size(134, 25)
        Me.lbldoj.TabIndex = 114
        Me.lbldoj.Text = "Date Of join"
        '
        'lblbsal
        '
        Me.lblbsal.AutoSize = True
        Me.lblbsal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbsal.Location = New System.Drawing.Point(79, 360)
        Me.lblbsal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbsal.Name = "lblbsal"
        Me.lblbsal.Size = New System.Drawing.Size(132, 25)
        Me.lblbsal.TabIndex = 110
        Me.lblbsal.Text = "Palyear Age"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(79, 414)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(148, 25)
        Me.lbldob.TabIndex = 109
        Me.lbldob.Text = "Date Of Birth"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(76, 301)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(151, 25)
        Me.lblname.TabIndex = 103
        Me.lblname.Text = "Playear Name"
        '
        'lbldepno
        '
        Me.lbldepno.AutoSize = True
        Me.lbldepno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepno.Location = New System.Drawing.Point(79, 245)
        Me.lbldepno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepno.Name = "lbldepno"
        Me.lbldepno.Size = New System.Drawing.Size(112, 25)
        Me.lbldepno.TabIndex = 101
        Me.lbldepno.Text = "Player No"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(79, 181)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(122, 25)
        Me.lblempno.TabIndex = 99
        Me.lblempno.Text = "Playear ID"
        '
        'lbl02
        '
        Me.lbl02.AutoSize = True
        Me.lbl02.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl02.Location = New System.Drawing.Point(258, 295)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.Size = New System.Drawing.Size(0, 32)
        Me.lbl02.TabIndex = 115
        '
        'lbl03
        '
        Me.lbl03.AutoSize = True
        Me.lbl03.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl03.Location = New System.Drawing.Point(258, 354)
        Me.lbl03.Name = "lbl03"
        Me.lbl03.Size = New System.Drawing.Size(0, 32)
        Me.lbl03.TabIndex = 115
        '
        'lbl04
        '
        Me.lbl04.AutoSize = True
        Me.lbl04.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl04.Location = New System.Drawing.Point(258, 238)
        Me.lbl04.Name = "lbl04"
        Me.lbl04.Size = New System.Drawing.Size(0, 32)
        Me.lbl04.TabIndex = 115
        '
        'dgvEMT
        '
        Me.dgvEMT.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMT.Location = New System.Drawing.Point(654, 41)
        Me.dgvEMT.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEMT.Name = "dgvEMT"
        Me.dgvEMT.Size = New System.Drawing.Size(10, 10)
        Me.dgvEMT.TabIndex = 116
        '
        'txtPlayearID
        '
        Me.txtPlayearID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlayearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayearID.Location = New System.Drawing.Point(233, 176)
        Me.txtPlayearID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayearID.MaxLength = 4
        Me.txtPlayearID.Multiline = True
        Me.txtPlayearID.Name = "txtPlayearID"
        Me.txtPlayearID.Size = New System.Drawing.Size(292, 30)
        Me.txtPlayearID.TabIndex = 118
        '
        'btnfind
        '
        Me.btnfind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfind.Enabled = False
        Me.btnfind.Location = New System.Drawing.Point(533, 176)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(95, 30)
        Me.btnfind.TabIndex = 119
        Me.btnfind.Text = "&Search"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(340, 509)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(156, 61)
        Me.btnload.TabIndex = 120
        Me.btnload.Text = "&Load database"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(571, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 31)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Lions   Cricket   Club"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 39)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = " SEARCH Playear"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 747)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.txtPlayearID)
        Me.Controls.Add(Me.dgvEMT)
        Me.Controls.Add(Me.lbl04)
        Me.Controls.Add(Me.lbl03)
        Me.Controls.Add(Me.lbl02)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.dtpdoj)
        Me.Controls.Add(Me.lbldoj)
        Me.Controls.Add(Me.lblbsal)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbldepno)
        Me.Controls.Add(Me.lblempno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Playears"
        CType(Me.dgvEMT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldoj As System.Windows.Forms.Label
    Friend WithEvents lblbsal As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbldepno As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents lbl02 As System.Windows.Forms.Label
    Friend WithEvents lbl03 As System.Windows.Forms.Label
    Friend WithEvents lbl04 As System.Windows.Forms.Label
    Friend WithEvents dgvEMT As System.Windows.Forms.DataGridView
    Friend WithEvents txtPlayearID As System.Windows.Forms.TextBox
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
