Imports System.Data.OleDb
Public Class frmMTC
    'Declare the Connection,Adapter,Dataset & Command
    Private oledbConn As New OleDbConnection
    Private oledbAdapt As New OleDbDataAdapter
    Private dsMTC As New DataSet
    Private oledbComm As New OleDbCommand
    Private Sub frmMTC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select MatchID,Tour,Ground,Series,DOS from MTC", oledbConn)
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        'Load the data set conntrol ussing Adapter control
        oledbAdapt.Fill(dsMTC, "MTC")

        dsMTC.Tables("MTC").PrimaryKey = New DataColumn() {dsMTC.Tables("MTC").Columns("MatchID")}
        'Set the Data GRID Control 
        dgvMTC.DataSource = dsMTC.Tables("MTC")
        'Active the record operation GroupBox
        grbRecord.Enabled = True
        'Display the Message
        MessageBox.Show("Load Data base connect succesfully", "ABC company(pvt) LTD", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        'Chech the fill MatchID textbox control
        If Not (txtMatchID.Text = "") Then
            'check the Exting No
            'Declare the find data row
            Dim Emprow As DataRow = dsMTC.Tables("MTC").Rows.Find(txtMatchID.Text)
            If Not (Emprow Is Nothing) Then
                'Display the message
                MessageBox.Show("Plise Enter another Employ nomber", "ABC Company (PVT).", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Set the focus
                txtMatchID.Focus()
                'select the MatchID text boxes
                txtMatchID.SelectAll()
            Else
                'Declare the Responce variable
                Dim dirRes As DialogResult
                'Asing the message 
                dirRes = MessageBox.Show("Do you want to add new Record", "ABC Company (PVT)Ltd", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'Check the Response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Add new record
                    'Set the insert into command
                    oledbComm = New OleDbCommand("INSERT INTO MTC(MatchID,Tour,Ground,Series,DOS)values('" & txtMatchID.Text & "','" & txtTour.Text & "','" & txtGround.Text & "','" & txtSeries.Text & "','" & dtpDOS.Value & "')")

                    'Set the connetion
                    oledbComm.Connection = oledbConn
                    'Execute the statement
                    oledbComm.ExecuteNonQuery()
                    'Display Message
                    MessageBox.Show("Insert Record Succesfully", "ABC Company (PVT) LTD ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    'Dispaly Message
                    MessageBox.Show("Insert Record Cancel", " ABC Company (PVT) LTD ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            'Display Message
            MessageBox.Show("Please Enter Emp No", "ABC Company (PVT)LTD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the focus
            txtMatchID.Focus()
        End If
        'Cler textboxes
        clear()

    End Sub

    Private Sub dgvMTC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMTC.CellContentClick

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)
        txtMatchID.Text = Nothing
        txtTour.Text = Nothing
        txtGround.Text = Nothing

        txtSeries.Text = Nothing

        'Display the Message
        MessageBox.Show(" Data base Cler succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'Check the Fill MatchID Textbox control
        If Not (txtMatchID.Text) = "" Then
            'Declare the object variable
            Dim objeditno As Object
            'Asing the alue
            objeditno = txtMatchID.Text
            'Declare the edit data row
            Dim editrow As DataRow = dsMTC.Tables("MTC").Rows.Find(objeditno)
            'check the other records display or not 
            If Not (editrow Is Nothing) Then
                'Asing thether records 
                txtTour.Text = editrow("Tour")
                txtGround.Text = editrow("Ground")
                txtSeries.Text = editrow("Series")

                dtpDOS.Text = editrow("DOS")
                'Display the message
                MessageBox.Show("Plice cheange your record", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Display message
                MessageBox.Show("Record not found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'set the focus 
                txtMatchID.Focus()
                'select the MatchID textbox
                txtMatchID.SelectAll()

            End If
        Else

            'Display the message
            MessageBox.Show("plice enter the Employee No", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'set the focus
            txtMatchID.Focus()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'Check the fill emp no textbox control
        If Not (txtMatchID.Text = "") Then
            'Declare the responce variables
            Dim dirRes As DialogResult
            'Assign the message
            dirRes = MessageBox.Show("Do you want to update Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Check the response
            If dirRes = Windows.Forms.DialogResult.Yes Then

                'Edit record 
                oledbComm = New OleDbCommand("Update MTC SET Tour='" & txtTour.Text & "',Ground='" & txtGround.Text & "',Series='" & txtSeries.Text & "',DOS='" & dtpDOS.Value & "' Where MatchID='" & txtMatchID.Text & "'")
                'set the command connection




                oledbComm.Connection = oledbConn
                'Execute codding
                oledbComm.ExecuteNonQuery()
                'Display message
                MessageBox.Show("Record are Successfuuly Updated", "ABC Company (Pvt) Ltd", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Display Message
                MessageBox.Show("Update Record Cancal", "ABC Company (Pvt) Ltd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            'Display Message
            MessageBox.Show("Please Enter Employee No", "ABC Company (Pvt) Ltd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the Focus
            txtMatchID.Focus()

        End If
        'Clear the text boxes
        clear()

    End Sub
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        'Check the MatchID text box control
        If Not (txtMatchID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtMatchID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsMTC.Tables("MTC").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records
                txtTour.Text = findNow("Tour")
                txtMatchID.Text = findNow("MatchID")
                txtGround.Text = findNow("Ground")
                txtSeries.Text = findNow("Series")


                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtTour.Focus()
                'Select the MatchID text boxes
                txtMatchID.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtMatchID.Focus()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'check the texboxes
        If Not (txtMatchID.Text = "") Then

            'Declare the object variable
            Dim objDelNo As Object

            'Assign it code texbox
            objDelNo = txtMatchID.Text

            'Declare the edit Row instant
            Dim DelRow As DataRow = dsMTC.Tables("MTC").Rows.Find(objDelNo)

            'check the MatchID
            If Not (DelRow Is Nothing) Then

                'set the other textboxes
                txtTour.Text = DelRow("Tour")
                txtGround.Text = DelRow("Ground")
                txtSeries.Text = DelRow("Series")

                dtpDOS.Text = DelRow("DOS")

                'Declare the responce Variable & assign the messageBox

                Dim dirRes As DialogResult

                dirRes = MessageBox.Show("Do You Want to Delete this Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'check response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Delete record
                    oledbComm = New OleDbCommand("DELETE* from MTC WHERE MatchID='" & txtMatchID.Text & "'")

                    'set the command cnnection
                    oledbComm.Connection = oledbConn

                    'Execute Coding
                    oledbComm.ExecuteNonQuery()

                    'Display Message
                    MessageBox.Show("Record are Delete Successfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'set the focus
                    txtMatchID.Focus()
                    'select the MatchID textbox
                    txtMatchID.SelectAll()

                End If
            Else
                'Display Message
                MessageBox.Show("Record Not Found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'set the focus
                txtMatchID.Focus()
                'select the MatchID textbox
                txtMatchID.SelectAll()


            End If
        Else
            'Display message
            MessageBox.Show("Please Enter Employee No ", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtMatchID_TextChanged(sender As Object, e As EventArgs) Handles txtMatchID.TextChanged
       
    End Sub
    Private Sub clear()
        'clear the buttons
        TxtMatchID.Resettext()
        TxtTour.Resettext()
        txtGround.ResetText()

        txtSeries.ResetText()




        'Inactive the transaction Type

        btnsave.Enabled = True
        'Clear the variables
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Check the MatchID text box control
        If Not (txtMatchID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtMatchID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsMTC.Tables("MTC").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records
                txtTour.Text = findNow("Tour")
                txtMatchID.Text = findNow("MatchID")
                txtGround.Text = findNow("Ground")
                txtSeries.Text = findNow("Series")

                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtTour.Focus()
                'Select the MatchID text boxes
                txtMatchID.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtMatchID.Focus()
        End If

    End Sub

    Private Sub txtTour_TextChanged(sender As Object, e As EventArgs) Handles txtTour.TextChanged

    End Sub

    Private Sub txtPlayearNO_TextChanged(sender As Object, e As EventArgs) Handles txtTour.TextChanged

    End Sub

    Private Sub btnclear_Click_1(sender As Object, e As EventArgs) Handles btnclear.Click
        txtMatchID.Text = Nothing
        txtTour.Text = Nothing
        txtGround.Text = Nothing

        txtSeries.Text = Nothing

        'Display the Message
        MessageBox.Show(" Data base Cler succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dtpDOS_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOS.ValueChanged

    End Sub
End Class

