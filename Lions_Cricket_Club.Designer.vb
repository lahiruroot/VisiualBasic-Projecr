<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAUSHREGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShedulMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MACHDEATILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayearsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoachsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CAUSHREGISTRATIONToolStripMenuItem, Me.CreatMatchToolStripMenuItem, Me.MACHDEATILSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 24)
        Me.ToolStripMenuItem1.Text = "PLAYEAR REAGISTRATION"
        '
        'CAUSHREGISTRATIONToolStripMenuItem
        '
        Me.CAUSHREGISTRATIONToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CAUSHREGISTRATIONToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CAUSHREGISTRATIONToolStripMenuItem.Name = "CAUSHREGISTRATIONToolStripMenuItem"
        Me.CAUSHREGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.CAUSHREGISTRATIONToolStripMenuItem.Text = "COACH REGISTRATION"
        '
        'CreatMatchToolStripMenuItem
        '
        Me.CreatMatchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CreatMatchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeamSelectionToolStripMenuItem, Me.ShedulMatchToolStripMenuItem})
        Me.CreatMatchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CreatMatchToolStripMenuItem.Name = "CreatMatchToolStripMenuItem"
        Me.CreatMatchToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.CreatMatchToolStripMenuItem.Text = "Creat Match "
        '
        'TeamSelectionToolStripMenuItem
        '
        Me.TeamSelectionToolStripMenuItem.Name = "TeamSelectionToolStripMenuItem"
        Me.TeamSelectionToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.TeamSelectionToolStripMenuItem.Text = "Team Selection"
        '
        'ShedulMatchToolStripMenuItem
        '
        Me.ShedulMatchToolStripMenuItem.Name = "ShedulMatchToolStripMenuItem"
        Me.ShedulMatchToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ShedulMatchToolStripMenuItem.Text = "Shedul Match"
        '
        'MACHDEATILSToolStripMenuItem
        '
        Me.MACHDEATILSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MACHDEATILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayearsToolStripMenuItem, Me.CoachsToolStripMenuItem})
        Me.MACHDEATILSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MACHDEATILSToolStripMenuItem.Name = "MACHDEATILSToolStripMenuItem"
        Me.MACHDEATILSToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.MACHDEATILSToolStripMenuItem.Text = "Search DEATILS"
        '
        'PlayearsToolStripMenuItem
        '
        Me.PlayearsToolStripMenuItem.Name = "PlayearsToolStripMenuItem"
        Me.PlayearsToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.PlayearsToolStripMenuItem.Text = "Playears"
        '
        'CoachsToolStripMenuItem
        '
        Me.CoachsToolStripMenuItem.Name = "CoachsToolStripMenuItem"
        Me.CoachsToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.CoachsToolStripMenuItem.Text = "Coach's"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(568, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 452)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1366, 738)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lions_Cricket_Club"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CAUSHREGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreatMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MACHDEATILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayearsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoachsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TeamSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShedulMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
