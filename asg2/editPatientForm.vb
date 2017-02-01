Imports System.IO
Imports System.Linq
Imports System.Xml.Serialization

Public Class editPatientForm

    Dim patientListForm As New patientListForm


    Private Sub editPatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not insuranceProvider = "" Then

            insuranceCheck.Checked = True

        End If

        txtID.Text = idNumber
        txtFname.Text = firstName
        txtLname.Text = lastName
        Datepick.Text = birthDate
        txtPhone.Text = phone
        txtEmail.Text = email
        comboProvider.Text = insuranceProvider
        comboPlan.Text = planType
        txtSubsID.Text = subscriberID
        txtPlanID.Text = planID


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Msgbox_Yes_No()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click

        'Closes forms and brings an updated version of the list up
        Me.Close()
        MainForm.Show()


    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click


        Dim patientIndex As Integer = CInt(idNumber)


        '************ERRORS FOR EMPTY FIELDS***********
        If Not Trim(txtFname.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtFname, "Please enter first name")

        Else
            Me.ErrorProvider.SetError(Me.txtFname, "")
        End If

        If Not Trim(txtLname.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtLname, "Please enter last name")

        Else
            Me.ErrorProvider.SetError(Me.txtLname, "")
        End If

        If Not Trim(txtPhone.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtPhone, "Please enter phone name")

        Else
            Me.ErrorProvider.SetError(Me.txtPhone, "")
        End If

        If Not Trim(txtEmail.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtEmail, "Please enter email name")

        Else
            Me.ErrorProvider.SetError(Me.txtEmail, "")
        End If


        If Not Trim(txtSubsID.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtSubsID, "Please enter subscriber id")

        Else
            Me.ErrorProvider.SetError(Me.txtSubsID, "")
        End If

        If Not Trim(txtPlanID.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtPlanID, "Please enter plan id")

        Else
            Me.ErrorProvider.SetError(Me.txtPlanID, "")
        End If



        If insuranceCheck.Checked = True Then

            If Trim(txtFname.Text) <> "" And
               Trim(txtLname.Text) <> "" And
               Trim(txtPhone.Text) <> "" And
               Trim(txtEmail.Text) <> "" And
               Trim(txtSubsID.Text) <> "" And
               Trim(txtPlanID.Text) <> "" Then



                patientList.Item(patientIndex).firstName = txtFname.Text
                patientList.Item(patientIndex).lastName = txtLname.Text
                patientList.Item(patientIndex).birthDate = Datepick.Text
                patientList.Item(patientIndex).phone = txtPhone.Text
                patientList.Item(patientIndex).email = txtEmail.Text
                patientList.Item(patientIndex).insuranceProvider = comboProvider.Text
                patientList.Item(patientIndex).planType = comboPlan.Text
                patientList.Item(patientIndex).subscriberID = txtSubsID.Text
                patientList.Item(patientIndex).planID = txtPlanID.Text


                'SAVE PATIENT
                Dim sw As New StreamWriter("Patients.xml")
                Dim serial As New XmlSerializer(patientList.GetType())
                serial.Serialize(sw, patientList)
                sw.Close()

                'Closes forms and brings an updated version of the list up
                Me.Close()
                patientListForm.Show()

            Else


                statLabel.Text = "Provide all required info"



            End If



        ElseIf insuranceCheck.Checked = False Then


            If Trim(txtFname.Text) <> "" And
               Trim(txtLname.Text) <> "" And
               Trim(txtPhone.Text) <> "" And
                Trim(txtEmail.Text) <> "" Then

                patientList.Item(patientIndex).firstName = txtFname.Text
                patientList.Item(patientIndex).lastName = txtLname.Text
                patientList.Item(patientIndex).birthDate = Datepick.Text
                patientList.Item(patientIndex).phone = txtPhone.Text
                patientList.Item(patientIndex).email = txtEmail.Text


                'SAVE PATIENT
                Dim sw As New StreamWriter("Patients.xml")
                Dim serial As New XmlSerializer(patientList.GetType())
                serial.Serialize(sw, patientList)
                sw.Close()


                'Closes forms and brings an updated version of the list up
                Me.Close()
                patientListForm.Show()


            Else

                statLabel.Text = "Provide all required info"

            End If

        End If



    End Sub

    Private Sub insuranceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles insuranceCheck.CheckedChanged

        insuranceBox.Visible = Not insuranceBox.Visible


    End Sub
End Class