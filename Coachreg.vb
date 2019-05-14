Imports System.Data.OleDb
Public Class frmCMT
    'Declare the Connection,Adapter,Dataset & Command
    Private oledbConn As New OleDbConnection
    Private oledbAdapt As New OleDbDataAdapter
    Private dsCMT As New DataSet
    Private oledbComm As New OleDbCommand
    Private Sub frmCMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the DATA base connection
        oledbConn.ConnectionString = "Provider=Microsoft.Jet.oledb.4.0;Data source=""Payroll.mdb"""
        'Open the connetion
        oledbConn.Open()
        'Set the Adapter control
        oledbAdapt = New OleDbDataAdapter("select CoachID,Name,DOB,Experince,Telno,Age,DOJ from CMT", oledbConn)
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCoachID_TextChanged(sender As Object, e As EventArgs) Handles txtCoachID.TextChanged
    
    End Sub
    Private Sub clear()
        'clear the buttons
        txtCoachID.ResetText()
        txtname.ResetText()
        txtAge.ResetText()
        txtExperince.ResetText()
        txttelno.ResetText()





        'Inactive the transaction Type

        btnsave.Enabled = True
        'Clear the variables
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grbRecord_Enter(sender As Object, e As EventArgs) Handles grbRecord.Enter

    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        'Chech the fill CoachID textbox control
        If Not (txtCoachID.Text = "") Then
            'check the Exting No
            'Declare the find data row
            Dim Emprow As DataRow = dsCMT.Tables("CMT").Rows.Find(txtCoachID.Text)
            If Not (Emprow Is Nothing) Then
                'Display the message
                MessageBox.Show("Plise Enter another Employ nomber", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Set the focus
                txtCoachID.Focus()
                'select the CoachID text boxes
                txtCoachID.SelectAll()
            Else
                'Declare the Responce variable
                Dim dirRes As DialogResult
                'Asing the message 
                dirRes = MessageBox.Show("Do you want to add new Record", "Lions Cricket Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'Check the Response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Add new record
                    'Set the insert into command
                    oledbComm = New OleDbCommand("INSERT INTO CMT(CoachID,Name,DOB,Age,Telno,DOJ,Experince)values('" & txtCoachID.Text & "','" & txtname.Text & "','" & dtpdob.Value & "','" & txtAge.Text & "','" & txttelno.Text & "','" & dtpdoj.Value & "','" & txtExperince.Text & "')")

                    'Set the connetion
                    oledbComm.Connection = oledbConn
                    'Execute the statement
                    oledbComm.ExecuteNonQuery()
                    'Display Message
                    MessageBox.Show("Insert Record Succesfully", "Lions Cricket Club ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    'Dispaly Message
                    MessageBox.Show("Insert Record Cancel", " ABC Company (PVT) LTD ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            'Display Message
            MessageBox.Show("Please Enter Emp No", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the focus
            txtCoachID.Focus()
        End If
        'Cler textboxes
        clear()
    End Sub

    Private Sub btnclear_Click_1(sender As Object, e As EventArgs) Handles btnclear.Click
        txtCoachID.Text = Nothing
        txtname.Text = Nothing
        txtExperince.Text = Nothing
        txttelno.Text = Nothing
        txtAge.Text = Nothing
        'Display the Message
        MessageBox.Show(" Data base Cler succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        'Check the fill emp no textbox control
        If Not (txtCoachID.Text = "") Then
            'Declare the responce variables
            Dim dirRes As DialogResult
            'Assign the message
            dirRes = MessageBox.Show("Do you want to update Record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'Check the response
            If dirRes = Windows.Forms.DialogResult.Yes Then

                'Edit record 
                oledbComm = New OleDbCommand("Update CMT SET Name='" & txtname.Text & "',DOB='" & dtpdob.Value & "',Experince='" & txtExperince.Text & "',Telno='" & txttelno.Text & "',Age='" & txtAge.Text & "',DOJ='" & dtpdoj.Value & "' Where CoachID='" & txtCoachID.Text & "'")
                'set the command connection




                oledbComm.Connection = oledbConn
                'Execute codding
                oledbComm.ExecuteNonQuery()
                'Display message
                MessageBox.Show("Record are Successfuuly Updated", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Display Message
                MessageBox.Show("Update Record Cancal", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            'Display Message
            MessageBox.Show("Please Enter Employee No", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Set the Focus
            txtCoachID.Focus()

        End If
        'Clear the text boxes
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check the texboxes
        If Not (txtCoachID.Text = "") Then

            'Declare the object variable
            Dim objDelNo As Object

            'Assign it code texbox
            objDelNo = txtCoachID.Text

            'Declare the edit Row instant
            Dim DelRow As DataRow = dsCMT.Tables("CMT").Rows.Find(objDelNo)

            'check the CoachID
            If Not (DelRow Is Nothing) Then

                'set the other textboxes
                txtname.Text = DelRow("Name")
                txttelno.Text = DelRow("Telno")
                dtpdob.Value = DelRow("DOB")
                txtExperince.Text = DelRow("Experince")
                txtAge.Text = DelRow("Age")
                dtpdoj.Value = DelRow("DOJ")

                'Declare the responce Variable & assign the messageBox

                Dim dirRes As DialogResult

                dirRes = MessageBox.Show("Do You Want to Delete this Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'check response
                If dirRes = Windows.Forms.DialogResult.Yes Then
                    'Delete record
                    oledbComm = New OleDbCommand("DELETE* from CMT WHERE CoachID='" & txtCoachID.Text & "'")

                    'set the command cnnection
                    oledbComm.Connection = oledbConn

                    'Execute Coding
                    oledbComm.ExecuteNonQuery()

                    'Display Message
                    MessageBox.Show("Record are Delete Successfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'set the focus
                    txtCoachID.Focus()
                    'select the CoachID textbox
                    txtCoachID.SelectAll()

                End If
            Else
                'Display Message
                MessageBox.Show("Record Not Found", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'set the focus
                txtCoachID.Focus()
                'select the CoachID textbox
                txtCoachID.SelectAll()


            End If
        Else
            'Display message
            MessageBox.Show("Please Enter Employee No ", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnfind_Click_1(sender As Object, e As EventArgs) Handles btnfind.Click
        'Check the CoachID text box control
        If Not (txtCoachID.Text = "") Then
            'Declare the object variable
            Dim objectfindNo As Object
            'assing the valu
            objectfindNo = txtCoachID.Text
            'Declare the find Data Row
            Dim findNow As DataRow = dsCMT.Tables("CMT").Rows.Find(objectfindNo)
            'check the other Record display or Not 
            If Not (FindForm() Is Nothing) Then
                'asing the other records
                txtCoachID.Text = findNow("CoachID")
                txtname.Text = findNow("Name")

                txtExperince.Text = findNow("Experince")
                txttelno.Text = findNow("Telno")

                txtAge.Text = findNow("Age")
                'Dsplay the message
                MessageBox.Show("Search record found", "ABC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dispplay the message
                MessageBox.Show("Search record not found", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'select the focus
                txtname.Focus()
                'Select the CoachID text boxes
                txtCoachID.SelectAll()
            End If
            'Display the message
            MessageBox.Show("Please Enter Employeeno", "Lions Cricket Club.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Select the focus
            txtCoachID.Focus()
        End If
    End Sub

    Private Sub btnload_Click_1(sender As Object, e As EventArgs) Handles btnload.Click
        'Load the data set conntrol ussing Adapter control
        oledbAdapt.Fill(dsCMT, "CMT")

        dsCMT.Tables("CMT").PrimaryKey = New DataColumn() {dsCMT.Tables("CMT").Columns("CoachID")}
        'Set the Data GRID Control 
        dgvCMT.DataSource = dsCMT.Tables("CMT")
        'Active the record operation GroupBox
        grbRecord.Enabled = True
        'Display the Message
        MessageBox.Show("Load Data base connect succesfully", "Lions Cricket Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class