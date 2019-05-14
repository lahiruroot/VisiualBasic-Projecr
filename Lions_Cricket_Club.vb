Public Class frmmain

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmEMT.Show()


    End Sub

    Private Sub CAUSHREGISTRATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAUSHREGISTRATIONToolStripMenuItem.Click
        frmCMT.Show()
    End Sub

    Private Sub MACHDEATILSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PlayearsToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CoachsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MACHDEATILSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MACHDEATILSToolStripMenuItem.Click

    End Sub

    Private Sub PlayearsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PlayearsToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub CoachsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CoachsToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub CreatMatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatMatchToolStripMenuItem.Click

    End Sub

    Private Sub TeamSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamSelectionToolStripMenuItem.Click
        frmTSF.Show()
    End Sub

    Private Sub ShedulMatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShedulMatchToolStripMenuItem.Click
        frmMTC.Show()

    End Sub
End Class