﻿Imports System.Data.OleDb
Public Class frmEMT
    'Declare the Connection,Adapter,Dataset & Command
    Private oledbConn As New OleDbConnection
    Private oledbAdapt As New OleDbDataAdapter
    Private dsEMT As New DataSet
    Private oledbComm As New OleDbCommand
    Private Sub frmEMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select PlayearID,PlayearNO,Name,Address,Telno,DOB,Age,DOJ from EMT", oledbConn)
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        'Load the data set conntrol ussing Adapter control
        oledbAdapt.Fill(dsEMT, "EMT")

        dsEMT.Tables("EMT").PrimaryKey = New DataColumn() {dsEMT.Tables("EMT").Columns("PlayearID")}
        'Set the Data GRID Control 
        dgvEMT.DataSource = dsEMT.Tables("EMT")
        'Active the record operation GroupBox
        grbRecord.Enabled = True
        'Display the Message
        MessageBox.Show("Load Data base connect succesfully", "ABC company(pvt) LTD", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        'Chech the fill PlayearID textbox control
        If Not (txtPlayearID.Text = "") Then
            'check the Exting No
            'Declare the find data row
            Dim Emprow As DataRow = dsEMT.Tables("EMT").Rows.Find(txtPlayearID.Text)
            If Not (Emprow Is Nothing) Then
                'Display the message
                MessageBox.Show("Plise Enter another Employ nomber", "ABC Company (PVT).", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Set the focus
                txtPlayearID.Focus()
                'select the PlayearID text boxes
                txtPlayearID.SelectAll()
            Else
                'Declare the Responce variable
                Dim dirRes As DialogResult
                'Asing the message 
                dirRes = MessageBox.Show("Do you want to add new Record", "ABC Company (PVT)Ltd", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'Check the Response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Add new record
                    'Set the insert into command
                    oledbComm = New OleDbCommand("INSERT INTO EMT(PlayearID,PlayearNO,Name,Address,Telno,DOB,Age,DOJ)values('" & txtPlayearID.Text & "','" & txtPlayearNO.Text & "','" & txtname.Text & "','" & txtaddress.Text & "','" & txttelno.Text & "','" & dtpdob.Value & "','" & txtAge.Text & "','" & dtpdoj.Value & "')")

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
            txtPlayearID.Focus()
        End If
        'Cler textboxes
        clear()

    End Sub

    Private Sub dgvEMT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEMT.CellContentClick

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'Check the Fill PlayearID Textbox control
        If Not (txtPlayearID.Text) = "" Then
            'Declare the object variable
            Dim objeditno As Object
            'Asing the alue
            objeditno = txtPlayearID.Text
            'Declare the edit data row
            Dim editrow As DataRow = dsEMT.Tables("EMT").Rows.Find(objeditno)
            'check the other records display or not 
            If Not (editrow Is Nothing) Then
                'Asing thether records 
                txtPlayearNO.Text = editrow("PlayearNO")
                txtname.Text = editrow("Name")
                txtaddress.Text = editrow("Address")
                txttelno.Text = editrow("Telno")
                dtpdob.Text = editrow("DOB")
                txtAge.Text = editrow("Bsal")
                dtpdoj.Text = editrow("DOJ")
                'Display the message
                MessageBox.Show("Plice cheange your record", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Display message
                MessageBox.Show("Record not found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'set the focus 
                txtPlayearID.Focus()
                'select the PlayearID textbox
                txtPlayearID.SelectAll()

            End If
        Else

            'Display the message
            MessageBox.Show("plice enter the Employee No", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'set the focus
            txtPlayearID.Focus()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'Check the fill emp no textbox control
        If Not (txtPlayearID.Text = "") Then
            'Declare the responce variables
            Dim dirRes As DialogResult
            'Assign the message
            dirRes = MessageBox.Show("Do you want to update Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Check the response
            If dirRes = Windows.Forms.DialogResult.Yes Then

                'Edit record 
                oledbComm = New OleDbCommand("Update EMT SET PlayearNO='" & txtPlayearNO.Text & "',Name='" & txtname.Text & "',Address='" & txtaddress.Text & "',Telno='" & txttelno.Text & "',DOB='" & dtpdob.Text & "',Bsal='" & txtAge.Text & "',DOJ='" & dtpdoj.Value & "' Where PlayearID='" & txtPlayearID.Text & "'")
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
            txtPlayearID.Focus()

        End If
        'Clear the text boxes
        clear()

    End Sub
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        'Check the PlayearID text box control
        If Not (txtPlayearID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtPlayearID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsEMT.Tables("EMT").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records
                txtPlayearNO.Text = findNow("PlayearNO")
                txtPlayearID.Text = findNow("PlayearID")
                txtname.Text = findNow("Name")
                txtaddress.Text = findNow("Address")
                txttelno.Text = findNow("Telno")
                txtAge.Text = findNow("Age")
                dtpdob.Text = findNow("DOB")

                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtPlayearNO.Focus()
                'Select the PlayearID text boxes
                txtPlayearID.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtPlayearID.Focus()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'check the texboxes
        If Not (txtPlayearID.Text = "") Then

            'Declare the object variable
            Dim objDelNo As Object

            'Assign it code texbox
            objDelNo = txtPlayearID.Text

            'Declare the edit Row instant
            Dim DelRow As DataRow = dsEMT.Tables("EMT").Rows.Find(objDelNo)

            'check the PlayearID
            If Not (DelRow Is Nothing) Then

                'set the other textboxes
                txtPlayearNO.Text = DelRow("PlayearNO")
                txtname.Text = DelRow("Name")
                txtaddress.Text = DelRow("Address")
                txttelno.Text = DelRow("Telno")
                dtpdob.Text = DelRow("DOB")
                txtAge.Text = DelRow("Age")
                dtpdoj.Text = DelRow("DOJ")

                'Declare the responce Variable & assign the messageBox

                Dim dirRes As DialogResult

                dirRes = MessageBox.Show("Do You Want to Delete this Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'check response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Delete record
                    oledbComm = New OleDbCommand("DELETE* from EMT WHERE PlayearID='" & txtPlayearID.Text & "'")

                    'set the command cnnection
                    oledbComm.Connection = oledbConn

                    'Execute Coding
                    oledbComm.ExecuteNonQuery()

                    'Display Message
                    MessageBox.Show("Record are Delete Successfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'set the focus
                    txtPlayearID.Focus()
                    'select the PlayearID textbox
                    txtPlayearID.SelectAll()

                End If
            Else
                'Display Message
                MessageBox.Show("Record Not Found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'set the focus
                txtPlayearID.Focus()
                'select the PlayearID textbox
                txtPlayearID.SelectAll()


            End If
        Else
            'Display message
            MessageBox.Show("Please Enter Employee No ", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtPlayearID_TextChanged(sender As Object, e As EventArgs) Handles txtPlayearID.TextChanged
       
    End Sub
    Private Sub clear()
        'clear the buttons
        TxtPlayearID.Resettext()
        TxtPlayearNO.Resettext()
        txtname.ResetText()
        txtAge.ResetText()
        txttelno.ResetText()
        txtaddress.ResetText()




        'Inactive the transaction Type

        btnsave.Enabled = True
        'Clear the variables
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Check the PlayearID text box control
        If Not (txtPlayearID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtPlayearID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsEMT.Tables("EMT").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records
                txtPlayearNO.Text = findNow("PlayearNO")
                txtPlayearID.Text = findNow("PlayearID")
                txtname.Text = findNow("Name")
                txtaddress.Text = findNow("Address")
                txttelno.Text = findNow("Telno")
                dtpdob.Text = findNow("DOB")
                txtAge.Text = findNow("Bsal")
                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtPlayearNO.Focus()
                'Select the PlayearID text boxes
                txtPlayearID.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtPlayearID.Focus()
        End If

    End Sub

    Private Sub txtPlayearNO_TextChanged(sender As Object, e As EventArgs) Handles txtPlayearNO.TextChanged

    End Sub


    Private Sub grbRecord_Enter(sender As Object, e As EventArgs) Handles grbRecord.Enter

    End Sub


    Private Sub btnclear_Click_1(sender As Object, e As EventArgs) Handles btnclear.Click
        txtPlayearID.Text = Nothing
        txtPlayearNO.Text = Nothing
        txtname.Text = Nothing
        txttelno.Text = Nothing
        txtaddress.Text = Nothing
        txtAge.Text = Nothing
        'Display the Message
        MessageBox.Show(" Data base Cler succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

