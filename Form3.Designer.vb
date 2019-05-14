<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDF
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDF))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnload = New System.Windows.Forms.Button()
        Me.dgvCRM = New System.Windows.Forms.DataGridView()
        Me.dtpdostr = New System.Windows.Forms.DateTimePicker()
        Me.dtpdoend = New System.Windows.Forms.DateTimePicker()
        Me.grbRecord = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtground = New System.Windows.Forms.TextBox()
        Me.txttour = New System.Windows.Forms.TextBox()
        Me.txtMatchid = New System.Windows.Forms.TextBox()
        Me.lbldoj = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldepno = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.txtseries = New System.Windows.Forms.TextBox()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.txtcapt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtwc = New System.Windows.Forms.TextBox()
        Me.txtbtmn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtspin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfast = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PayrollDataSet = New Lionscricket.PayrollDataSet()
        Me.CRMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMTableAdapter = New Lionscricket.PayrollDataSetTableAdapters.CRMTableAdapter()
        Me.MatchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroundDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaptainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BattingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpinnersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FastBallingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrollDataSet1 = New Lionscricket.PayrollDataSet1()
        Me.CRMBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRMTableAdapter1 = New Lionscricket.PayrollDataSet1TableAdapters.CRMTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRecord.SuspendLayout()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRMBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(833, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Match Details Form"
        '
        'btnload
        '
        Me.btnload.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(1215, 616)
        Me.btnload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(165, 79)
        Me.btnload.TabIndex = 121
        Me.btnload.Text = "&Load database"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'dgvCRM
        '
        Me.dgvCRM.AutoGenerateColumns = False
        Me.dgvCRM.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCRM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchIDDataGridViewTextBoxColumn, Me.TourDataGridViewTextBoxColumn, Me.SeriesDataGridViewTextBoxColumn, Me.GroundDataGridViewTextBoxColumn, Me.StartDataGridViewTextBoxColumn, Me.EndDataGridViewTextBoxColumn, Me.CaptainDataGridViewTextBoxColumn, Me.WCDataGridViewTextBoxColumn, Me.BattingDataGridViewTextBoxColumn, Me.SpinnersDataGridViewTextBoxColumn, Me.FastBallingDataGridViewTextBoxColumn})
        Me.dgvCRM.DataSource = Me.CRMBindingSource1
        Me.dgvCRM.Location = New System.Drawing.Point(510, 155)
        Me.dgvCRM.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCRM.Name = "dgvCRM"
        Me.dgvCRM.Size = New System.Drawing.Size(863, 409)
        Me.dgvCRM.TabIndex = 123
        '
        'dtpdostr
        '
        Me.dtpdostr.Location = New System.Drawing.Point(190, 381)
        Me.dtpdostr.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdostr.Name = "dtpdostr"
        Me.dtpdostr.Size = New System.Drawing.Size(292, 22)
        Me.dtpdostr.TabIndex = 118
        '
        'dtpdoend
        '
        Me.dtpdoend.Location = New System.Drawing.Point(190, 432)
        Me.dtpdoend.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpdoend.Name = "dtpdoend"
        Me.dtpdoend.Size = New System.Drawing.Size(292, 22)
        Me.dtpdoend.TabIndex = 119
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
        Me.grbRecord.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRecord.Location = New System.Drawing.Point(517, 576)
        Me.grbRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Name = "grbRecord"
        Me.grbRecord.Padding = New System.Windows.Forms.Padding(4)
        Me.grbRecord.Size = New System.Drawing.Size(683, 147)
        Me.grbRecord.TabIndex = 122
        Me.grbRecord.TabStop = False
        Me.grbRecord.Text = "Record operation"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(476, 90)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(195, 36)
        Me.btndelete.TabIndex = 23
        Me.btndelete.Text = "&Delete record"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.Location = New System.Drawing.Point(476, 29)
        Me.btnfind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(195, 36)
        Me.btnfind.TabIndex = 12
        Me.btnfind.Text = "&Find record"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(25, 90)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(195, 36)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "&Clear record"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(251, 29)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(195, 36)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "&Edit record "
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(25, 29)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(195, 36)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "&Add New record"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(251, 90)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(195, 36)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save record"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtground
        '
        Me.txtground.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtground.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtground.Location = New System.Drawing.Point(199, 329)
        Me.txtground.Margin = New System.Windows.Forms.Padding(4)
        Me.txtground.Multiline = True
        Me.txtground.Name = "txtground"
        Me.txtground.Size = New System.Drawing.Size(292, 33)
        Me.txtground.TabIndex = 111
        '
        'txttour
        '
        Me.txttour.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttour.Location = New System.Drawing.Point(199, 214)
        Me.txttour.Margin = New System.Windows.Forms.Padding(4)
        Me.txttour.Multiline = True
        Me.txttour.Name = "txttour"
        Me.txttour.Size = New System.Drawing.Size(292, 35)
        Me.txttour.TabIndex = 108
        '
        'txtMatchid
        '
        Me.txtMatchid.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMatchid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatchid.Location = New System.Drawing.Point(199, 155)
        Me.txtMatchid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatchid.MaxLength = 4
        Me.txtMatchid.Multiline = True
        Me.txtMatchid.Name = "txtMatchid"
        Me.txtMatchid.Size = New System.Drawing.Size(292, 30)
        Me.txtMatchid.TabIndex = 106
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoj.Location = New System.Drawing.Point(5, 431)
        Me.lbldoj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.Size = New System.Drawing.Size(106, 25)
        Me.lbldoj.TabIndex = 120
        Me.lbldoj.Text = "End Date"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(5, 378)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(111, 25)
        Me.lbldob.TabIndex = 115
        Me.lbldob.Text = "Start Date"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(11, 337)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(86, 25)
        Me.lblname.TabIndex = 109
        Me.lblname.Text = "Ground"
        '
        'lbldepno
        '
        Me.lbldepno.AutoSize = True
        Me.lbldepno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepno.Location = New System.Drawing.Point(14, 224)
        Me.lbldepno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepno.Name = "lbldepno"
        Me.lbldepno.Size = New System.Drawing.Size(111, 25)
        Me.lbldepno.TabIndex = 107
        Me.lbldepno.Text = "Tour with"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(14, 160)
        Me.lblempno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(108, 25)
        Me.lblempno.TabIndex = 105
        Me.lblempno.Text = "Match ID"
        '
        'txtseries
        '
        Me.txtseries.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtseries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseries.Location = New System.Drawing.Point(199, 271)
        Me.txtseries.Margin = New System.Windows.Forms.Padding(4)
        Me.txtseries.Multiline = True
        Me.txtseries.Name = "txtseries"
        Me.txtseries.Size = New System.Drawing.Size(292, 35)
        Me.txtseries.TabIndex = 128
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(14, 281)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(70, 25)
        Me.lbladdress.TabIndex = 127
        Me.lbladdress.Text = "Series"
        '
        'txtcapt
        '
        Me.txtcapt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcapt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcapt.Location = New System.Drawing.Point(199, 480)
        Me.txtcapt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcapt.Multiline = True
        Me.txtcapt.Name = "txtcapt"
        Me.txtcapt.Size = New System.Drawing.Size(292, 33)
        Me.txtcapt.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 488)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "captaincy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 539)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Wicket keeper"
        '
        'txtwc
        '
        Me.txtwc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtwc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwc.Location = New System.Drawing.Point(199, 531)
        Me.txtwc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwc.Multiline = True
        Me.txtwc.Name = "txtwc"
        Me.txtwc.Size = New System.Drawing.Size(292, 33)
        Me.txtwc.TabIndex = 130
        '
        'txtbtmn
        '
        Me.txtbtmn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbtmn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtmn.Location = New System.Drawing.Point(199, 582)
        Me.txtbtmn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbtmn.Multiline = True
        Me.txtbtmn.Name = "txtbtmn"
        Me.txtbtmn.Size = New System.Drawing.Size(292, 33)
        Me.txtbtmn.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 587)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 25)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Bats Mans"
        '
        'txtspin
        '
        Me.txtspin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtspin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspin.Location = New System.Drawing.Point(199, 634)
        Me.txtspin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtspin.Multiline = True
        Me.txtspin.Name = "txtspin"
        Me.txtspin.Size = New System.Drawing.Size(292, 33)
        Me.txtspin.TabIndex = 134
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 642)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Spinners"
        '
        'txtfast
        '
        Me.txtfast.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfast.Location = New System.Drawing.Point(199, 691)
        Me.txtfast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfast.Multiline = True
        Me.txtfast.Name = "txtfast"
        Me.txtfast.Size = New System.Drawing.Size(292, 33)
        Me.txtfast.TabIndex = 136
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 700)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 25)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Fast Ballers"
        '
        'PayrollDataSet
        '
        Me.PayrollDataSet.DataSetName = "PayrollDataSet"
        Me.PayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRMBindingSource
        '
        Me.CRMBindingSource.DataMember = "CRM"
        Me.CRMBindingSource.DataSource = Me.PayrollDataSet
        '
        'CRMTableAdapter
        '
        Me.CRMTableAdapter.ClearBeforeFill = True
        '
        'MatchIDDataGridViewTextBoxColumn
        '
        Me.MatchIDDataGridViewTextBoxColumn.DataPropertyName = "MatchID"
        Me.MatchIDDataGridViewTextBoxColumn.HeaderText = "MatchID"
        Me.MatchIDDataGridViewTextBoxColumn.Name = "MatchIDDataGridViewTextBoxColumn"
        '
        'TourDataGridViewTextBoxColumn
        '
        Me.TourDataGridViewTextBoxColumn.DataPropertyName = "Tour"
        Me.TourDataGridViewTextBoxColumn.HeaderText = "Tour"
        Me.TourDataGridViewTextBoxColumn.Name = "TourDataGridViewTextBoxColumn"
        '
        'SeriesDataGridViewTextBoxColumn
        '
        Me.SeriesDataGridViewTextBoxColumn.DataPropertyName = "Series"
        Me.SeriesDataGridViewTextBoxColumn.HeaderText = "Series"
        Me.SeriesDataGridViewTextBoxColumn.Name = "SeriesDataGridViewTextBoxColumn"
        '
        'GroundDataGridViewTextBoxColumn
        '
        Me.GroundDataGridViewTextBoxColumn.DataPropertyName = "Ground"
        Me.GroundDataGridViewTextBoxColumn.HeaderText = "Ground"
        Me.GroundDataGridViewTextBoxColumn.Name = "GroundDataGridViewTextBoxColumn"
        '
        'StartDataGridViewTextBoxColumn
        '
        Me.StartDataGridViewTextBoxColumn.DataPropertyName = "Start"
        Me.StartDataGridViewTextBoxColumn.HeaderText = "Start"
        Me.StartDataGridViewTextBoxColumn.Name = "StartDataGridViewTextBoxColumn"
        '
        'EndDataGridViewTextBoxColumn
        '
        Me.EndDataGridViewTextBoxColumn.DataPropertyName = "End"
        Me.EndDataGridViewTextBoxColumn.HeaderText = "End"
        Me.EndDataGridViewTextBoxColumn.Name = "EndDataGridViewTextBoxColumn"
        '
        'CaptainDataGridViewTextBoxColumn
        '
        Me.CaptainDataGridViewTextBoxColumn.DataPropertyName = "Captain"
        Me.CaptainDataGridViewTextBoxColumn.HeaderText = "Captain"
        Me.CaptainDataGridViewTextBoxColumn.Name = "CaptainDataGridViewTextBoxColumn"
        '
        'WCDataGridViewTextBoxColumn
        '
        Me.WCDataGridViewTextBoxColumn.DataPropertyName = "WC"
        Me.WCDataGridViewTextBoxColumn.HeaderText = "WC"
        Me.WCDataGridViewTextBoxColumn.Name = "WCDataGridViewTextBoxColumn"
        '
        'BattingDataGridViewTextBoxColumn
        '
        Me.BattingDataGridViewTextBoxColumn.DataPropertyName = "Batting"
        Me.BattingDataGridViewTextBoxColumn.HeaderText = "Batting"
        Me.BattingDataGridViewTextBoxColumn.Name = "BattingDataGridViewTextBoxColumn"
        '
        'SpinnersDataGridViewTextBoxColumn
        '
        Me.SpinnersDataGridViewTextBoxColumn.DataPropertyName = "Spinners"
        Me.SpinnersDataGridViewTextBoxColumn.HeaderText = "Spinners"
        Me.SpinnersDataGridViewTextBoxColumn.Name = "SpinnersDataGridViewTextBoxColumn"
        '
        'FastBallingDataGridViewTextBoxColumn
        '
        Me.FastBallingDataGridViewTextBoxColumn.DataPropertyName = "FastBalling"
        Me.FastBallingDataGridViewTextBoxColumn.HeaderText = "FastBalling"
        Me.FastBallingDataGridViewTextBoxColumn.Name = "FastBallingDataGridViewTextBoxColumn"
        '
        'PayrollDataSet1
        '
        Me.PayrollDataSet1.DataSetName = "PayrollDataSet1"
        Me.PayrollDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CRMBindingSource1
        '
        Me.CRMBindingSource1.DataMember = "CRM"
        Me.CRMBindingSource1.DataSource = Me.PayrollDataSet1
        '
        'CRMTableAdapter1
        '
        Me.CRMTableAdapter1.ClearBeforeFill = True
        '
        'frmMDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1393, 746)
        Me.Controls.Add(Me.txtfast)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtspin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbtmn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtwc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcapt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtseries)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvCRM)
        Me.Controls.Add(Me.dtpdostr)
        Me.Controls.Add(Me.dtpdoend)
        Me.Controls.Add(Me.grbRecord)
        Me.Controls.Add(Me.txtground)
        Me.Controls.Add(Me.txttour)
        Me.Controls.Add(Me.txtMatchid)
        Me.Controls.Add(Me.lbldoj)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbldepno)
        Me.Controls.Add(Me.lblempno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match Details"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRecord.ResumeLayout(False)
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRMBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents dgvCRM As System.Windows.Forms.DataGridView
    Friend WithEvents dtpdostr As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdoend As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbRecord As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtground As System.Windows.Forms.TextBox
    Friend WithEvents txttour As System.Windows.Forms.TextBox
    Friend WithEvents txtMatchid As System.Windows.Forms.TextBox
    Friend WithEvents lbldoj As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbldepno As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents txtseries As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents txtcapt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtwc As System.Windows.Forms.TextBox
    Friend WithEvents txtbtmn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtspin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfast As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PayrollDataSet As Lionscricket.PayrollDataSet
    Friend WithEvents CRMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CRMTableAdapter As Lionscricket.PayrollDataSetTableAdapters.CRMTableAdapter
    Friend WithEvents MatchIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TourDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroundDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptainDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BattingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpinnersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FastBallingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayrollDataSet1 As Lionscricket.PayrollDataSet1
    Friend WithEvents CRMBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CRMTableAdapter1 As Lionscricket.PayrollDataSet1TableAdapters.CRMTableAdapter
End Class
