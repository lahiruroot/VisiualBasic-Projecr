Imports System.Data.OleDb
Imports System.Data
Public Class frmLog

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    
        If txtUsername.Text = "Admin" Or txtPassword.Text = "123" Then
            MessageBox.Show(" Data base Login succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmmain.Show()
            Me.Hide()


        Else
            MessageBox.Show(" Data base Login Faild", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtPassword.Clear()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class