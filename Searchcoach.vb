Imports System.Data.OleDb

Public Class Form4
    'Declare the Connection,Adapter,Dataset & Command
    Private oledbConn As New OleDbConnection
    Private oledbAdapt As New OleDbDataAdapter
    Private dsCMT As New DataSet
    Private oledbComm As New OleDbCommand
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select CoachID,Name,DOB,Age,DOJ from CMT", oledbConn)
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        'Load the data set conntrol ussing Adapter control
        oledbAdapt.Fill(dsCMT, "CMT")

        dsCMT.Tables("CMT").PrimaryKey = New DataColumn() {dsCMT.Tables("CMT").Columns("CoachID")}
        'Set the Data GRID Control 
        dgvCMT.DataSource = dsCMT.Tables("CMT")
        'Active the record operation GroupBox
        btnfind.Enabled = True
        'Display the Message
        MessageBox.Show("Load Data base connect succesfully", "ABC company(pvt) LTD", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        'Check the PlayearID text box control
        If Not (txtPlayearID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtPlayearID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsCMT.Tables("CMT").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records

                lbl02.Text = findNow("Name")
                dtpdob.Text = findNow("DOB")
                lbl03.Text = findNow("Age")
                dtpdoj.Text = findNow("DOJ")
                'Declare the responce Variable & assign the messageBox

                Dim dirRes As DialogResult

                'Dsplay the message
                dirRes = MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'check response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                End If
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtPlayearID.Focus()
                'Select the PlayearID text boxes
                txtPlayearID.SelectAll()
            End If
        Else
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtPlayearID.Focus()
        End If
    End Sub

    Private Sub dgvCMT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCMT.CellContentClick
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select CoachID,Name,DOB,Age,DOJ from CMT", oledbConn)
    End Sub
End Class