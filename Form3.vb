Imports System.Data.OleDb

Public Class frmMDF
    'Declare the Connection,Adapter,Dataset & Command
    Private oledbConn As New OleDbConnection
    Private oledbAdapt As New OleDbDataAdapter
    Private dsCRM As New DataSet
    Private oledbComm As New OleDbCommand

    Private Sub frmMDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet1.CRM' table. You can move, or remove it, as needed.
        Me.CRMTableAdapter1.Fill(Me.PayrollDataSet1.CRM)
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select MatchID,Tour,Series,Ground,Start,End,Captain,WC,Batting,Spinners,FastBalling From CRM", oledbConn)

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        'Load the data set conntrol ussing Adapter control
        oledbAdapt.Fill(dsCRM, "CRM")

        dsCRM.Tables("CRM").PrimaryKey = New DataColumn() {dsCRM.Tables("CRM").Columns("MatchId")}
        'Set the Data GRID Control 
        dgvCRM.DataSource = dsCRM.Tables("CRM")
        'Active the record operation GroupBox
        grbRecord.Enabled = True
        'Display the Message
        MessageBox.Show("Load Data base connect succesfully", "ABC company(pvt) LTD", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        'Chech the fill Matchid textbox control
        If Not (txtMatchid.Text = "") Then
            'check the Exting No
            'Declare the find data row
            Dim Emprow As DataRow = dsCRM.Tables("CRM").Rows.Find(txtMatchid.Text)
            If Not (Emprow Is Nothing) Then
                'Display the message
                MessageBox.Show("Plise Enter another Employ nomber", "ABC Company (PVT).", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Set the focus
                txtMatchid.Focus()
                'select the Matchid text boxes
                txtMatchid.SelectAll()
            Else
                'Declare the Responce variable
                Dim dirRes As DialogResult
                'Asing the message 
                dirRes = MessageBox.Show("Do you want to add new Record", "ABC Company (PVT)Ltd", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'Check the Response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Add new record
                    'Set the insert into command
                    oledbComm = New OleDbCommand("INSERT INTO CRM(MatchID,Tour,Series,Ground,Start,End,Captain,WC,Batting,Spinners,FastBalling)values('" & txtMatchid.Text & "','" & txttour.Text & "','" & txtseries.Text & "','" & txtground.Text & "','" & dtpdostr.Value & "','" & dtpdoend.Value & "','" & txtcapt.Text & "','" & txtwc.Text & "','" & txtbtmn.Text & "','" & txtspin.Text & "','" & txtfast.Text & "')")

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
            txtMatchid.Focus()
        End If
        'Cler textboxes
        clear()
    End Sub

    Private Sub txtMatchid_TextChanged(sender As Object, e As EventArgs) Handles txtMatchid.TextChanged

    End Sub
    Private Sub clear()
        'clear the buttons
        txtMatchid.ResetText()
        txttour.ResetText()
        txtseries.ResetText()
        txtground.ResetText()
        txtcapt.ResetText()
        txtwc.ResetText()
        txtbtmn.ResetText()
        txtspin.ResetText()
        txtfast.ResetText()



        'Inactive the transaction Type

        btnsave.Enabled = True
        'Clear the variables
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'Check the Fill MatchID Textbox control
        If Not (txtMatchid.Text) = "" Then
            'Declare the object variable
            Dim objeditno As Object
            'Asing the alue
            objeditno = txtMatchid.Text
            'Declare the edit data row
            Dim editrow As DataRow = dsCRM.Tables("CRM").Rows.Find(objeditno)
            'check the other records display or not 
            If Not (editrow Is Nothing) Then
                'Asing thether records 

                txtMatchid.Text = editrow("MatchID")
                txttour.Text = editrow("Tour")
                txtseries.Text = editrow("Series")
                txtground.Text = editrow("Ground")
                dtpdostr.Text = editrow("Start")
                dtpdoend.Text = editrow("End")
                txtcapt.Text = editrow("Captain")
                txtwc.Text = editrow("WC")
                txtbtmn.Text = editrow("Batting")
                txtspin.Text = editrow("Spinners")
                txtfast.Text = editrow("FastBalling")
                'Display the message
                MessageBox.Show("Plice cheange your record", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Display message
                MessageBox.Show("Record not found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'set the focus 
                txtMatchid.Focus()
                'select the MatchID textbox
                txtMatchid.SelectAll()

            End If
        Else

            'Display the message
            MessageBox.Show("plice enter the Employee No", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'set the focus
            txtMatchid.Focus()
        End If
    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        'Check the MatchID text box control
        If Not (txtMatchid.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtMatchid.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsCRM.Tables("CRM").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records

                txtMatchid.Text = findNow("MatchID")
                txttour.Text = findNow("Tour")
                txtseries.Text = findNow("Series")
                txtground.Text = findNow("Ground")
                dtpdostr.Text = findNow("Start")
                dtpdoend.Text = findNow("End")
                txtcapt.Text = findNow("Captain")
                txtwc.Text = findNow("WC")
                txtbtmn.Text = findNow("Batting")
                txtspin.Text = findNow("Spinners")
                txtfast.Text = findNow("FastBalling")
                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtMatchid.Focus()
                'Select the MatchID text boxes
                txtMatchid.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtMatchid.Focus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtMatchid.Text = Nothing
        txttour.Text = Nothing
        txtseries.Text = Nothing
        txtground.Text = Nothing
        dtpdostr.Text = Nothing
        dtpdoend.Text = Nothing
        txtcapt.Text = Nothing
        txtwc.Text = Nothing
        txtbtmn.Text = Nothing
        txtspin.Text = Nothing
        txtfast.Text = Nothing
        'Display the Message
        MessageBox.Show(" Data base Cler succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Check the fill emp no textbox control
        If Not (txtMatchid.Text = "") Then
            'Declare the responce variables
            Dim dirRes As DialogResult
            'Assign the message
            dirRes = MessageBox.Show("Do you want to update Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Check the response
            If dirRes = Windows.Forms.DialogResult.Yes Then

                'Edit record 
                oledbComm = New OleDbCommand("Update CRM SET Tour='" & txttour.Text & "',Series='" & txtseries.Text & "',Ground'" & txtground.Text & "',Start='" & dtpdostr.Value & "',End='" & dtpdoend.Value & "',Captain='" & txtcapt.Text & "',WC='" & txtwc.Text & "',Batting='" & txtbtmn.Text & "',Spinners='" & txtspin.Text & "',FastBalling='" & txtfast.Text & "' Where MatchID='" & txtMatchid.Text & "'")
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
            txtMatchid.Focus()

        End If
        'Clear the text boxes
        clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'check the texboxes
        If Not (txtMatchID.Text = "") Then

            'Declare the object variable
            Dim objDelNo As Object

            'Assign it code texbox
            objDelNo = txtMatchID.Text

            'Declare the edit Row instant
            Dim DelRow As DataRow = dsCRM.Tables("CRM").Rows.Find(objDelNo)

            'check the MatchID
            If Not (DelRow Is Nothing) Then

                'set the other textboxes

                txttour.Text = DelRow("Tour")
                txtseries.Text = DelRow("Series")
                txtground.Text = DelRow("Ground")
                dtpdostr.Text = DelRow("Start")
                dtpdoend.Text = DelRow("End")
                txtcapt.Text = DelRow("Captain")
                txtwc.Text = DelRow("WC")
                txtbtmn.Text = DelRow("Batting")
                txtspin.Text = DelRow("Spinners")
                txtfast.Text = DelRow("FastBalling")
            

                'Declare the responce Variable & assign the messageBox

                Dim dirRes As DialogResult

                dirRes = MessageBox.Show("Do You Want to Delete this Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'check response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Delete record
                    oledbComm = New OleDbCommand("DELETE* from CRM WHERE MatchID='" & txtMatchid.Text & "'")

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
End Class