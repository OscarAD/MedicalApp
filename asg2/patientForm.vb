Imports System.IO
Imports System.Xml.Serialization

Public Class patientForm



    Private Sub saveBtn_Click() Handles saveBtn.Click

        '************CHECK ERRORS FOR EMPTY FIELDS***********
        checkErrors()


        If insuranceCheck.Checked = False Then

            If Trim(txtFname.Text) <> "" And
               Trim(txtLname.Text) <> "" And
               Trim(txtPhone.Text) <> "" And
                Trim(txtEmail.Text) <> "" Then

                Dim newPatient As New Patient(txtID.Text,
                                              txtFname.Text,
                                              txtLname.Text,
                                              Datepick.Text,
                                              txtPhone.Text,
                                              txtEmail.Text)

                patientList.Add(newPatient)


                statLabel.Text = "Patient " & txtFname.Text &
                                 " " & txtLname.Text & " added successfully"

                saveBtn.Enabled = False

            Else


                statLabel.Text = "Provide all required info"



                End If

        ElseIf insuranceCheck.Checked = True


                If Trim(txtFname.Text) <> "" And
                   Trim(txtLname.Text) <> "" And
                   Trim(txtPhone.Text) <> "" And
                   Trim(txtEmail.Text) <> "" And
                   Trim(txtSubsID.Text) <> "" And
                    Trim(txtPlanID.Text) <> "" Then

                    Dim newPatient As New Patient(txtID.Text,
                                              txtFname.Text,
                                              txtLname.Text,
                                              Datepick.Text,
                                              txtPhone.Text,
                                              txtEmail.Text,
                                              comboProvider.SelectedItem.ToString,
                                              comboPlan.SelectedItem.ToString,
                                              txtSubsID.Text, txtPlanID.Text)

                    patientList.Add(newPatient)

                    statLabel.Text = "Patient " & txtFname.Text &
                                     " " & txtLname.Text & " added successfully"

                    saveBtn.Enabled = False


                Else

                    statLabel.Text = "Provide all required info"

                End If

        End If

        Dim sw As New StreamWriter("Patients.xml")
        Dim serial As New XmlSerializer(patientList.GetType())
        serial.Serialize(sw, patientList)
        sw.Close()

    End Sub

    Private Sub insuranceCheck_CheckedChanged() Handles insuranceCheck.CheckedChanged

        insuranceBox.Visible = Not insuranceBox.Visible

    End Sub

    Private Sub closeBtn_Click() Handles closeBtn.Click

        Me.Close()
        MainForm.Show()

    End Sub

    Private Sub patientForm_Load() Handles MyBase.Load
        Dim mForm As New MainForm

        Datepick.Format = DateTimePickerFormat.Custom
        Datepick.CustomFormat = "M/d/yyyy"


        txtID.Text = mForm.highestID

        comboProvider.SelectedItem = "Estrella"
        comboPlan.SelectedItem = "HMO"

        Datepick.Text = "6/19/1970"


    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click

        Msgbox_Yes_No()

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress

        onlyNumbers(sender, e)

    End Sub



    Private Sub txtSubsID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubsID.KeyPress

        onlyNumbers(sender, e)

    End Sub

    Private Sub txtPlanID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlanID.KeyPress

        NumbersNLetters(sender, e)

    End Sub



    Private Sub checkErrors()


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



    End Sub


End Class