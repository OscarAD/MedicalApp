Imports System.IO
Imports System.Xml.Serialization

Public Class AppointmentMake
    Dim mForm As New MainForm

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

        checkErrors()

        If txtLength.Text <> "" And
            txtReason.Text <> "" Then


            Dim datePicked As String = (DateTimePicker.Value.Day.ToString & "/" & DateTimePicker.Value.Month.ToString &
                                        "/" & DateTimePicker.Value.Year.ToString)
            Dim timePicked As String = (DateTimePicker.Value.Hour.ToString & ":" & DateTimePicker.Value.Minute.ToString)


            'This gets the index of the object
            Dim PatientindexExtract As String() = Split(lstPatients.SelectedItem.ToString(), ".")
            Dim DoctorindexExtract As String() = Split(lstDoctors.SelectedItem.ToString(), ".")


            Dim Patientindex As Integer = CInt(PatientindexExtract(1))
            Dim Doctorindex As Integer = CInt(DoctorindexExtract(1))


            Dim newAppointment As New Appointment(txtID.Text,
                                              physicianList.Item(Doctorindex).firstName,
                                              physicianList.Item(Doctorindex).lastName,
                                              patientList.Item(Patientindex).firstName,
                                              patientList.Item(Patientindex).lastName,
                                              datePicked,
                                              timePicked,
                                              txtReason.Text,
                                              txtLength.Text)

            appointmentList.Add(newAppointment)


            mForm.highestAppointmentID = (CInt(mForm.highestAppointmentID) + 1).ToString
            txtID.Text = mForm.highestAppointmentID

            statLabel.Text = "Appointment added successfully"

        Else

            statLabel.Text = "Provide all required info"

        End If

    End Sub

    Private Sub AppointmentMake_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtID.Text = mForm.highestAppointmentID

        lstDoctors.DataSource = physicianList
        lstPatients.DataSource = patientList

        DateTimePicker.CustomFormat = "[HH:mm] [dd-MM-yyyy]"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        Me.Close()

    End Sub

    Private Sub txtLength_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLength.KeyPress

        onlyNumbers(sender, e)

    End Sub


    Private Sub checkErrors()


        If Not txtLength.Text <> "" Then
            Me.ErrorProvider.SetError(Me.txtLength, "Provide length of appointment")

        Else
            Me.ErrorProvider.SetError(Me.txtLength, "")
        End If

        If Not Trim(txtReason.Text) <> "" Then
            Me.ErrorProvider.SetError(Me.txtReason, "Provide reason for visit")

        Else
            Me.ErrorProvider.SetError(Me.txtReason, "")
        End If

    End Sub



End Class