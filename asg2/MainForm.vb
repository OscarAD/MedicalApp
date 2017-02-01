Imports System.IO
Imports System.Xml.Serialization

Public Class MainForm

    Dim pForm As New patientForm
    Public highestID As String = CType(Files.patientList.Count, String)
    Public highestAppointmentID As String = CType(Files.appointmentList.Count, String)

    Dim patientColl As New Dictionary(Of Integer, Patient)


    Private Sub MainForm_Load() Handles MyBase.Load

        Dim sr As New StreamReader("Patients.xml")
        Dim sd As New StreamReader("Physicians.xml")


        Dim serialPatient As New XmlSerializer(Files.patientList.GetType())
        Dim serialPhysician As New XmlSerializer(physicianList.GetType())




        Files.patientList = CType(serialPatient.Deserialize(sr), List(Of Patient))
        physicianList = CType(serialPhysician.Deserialize(sd), List(Of Physician))


        sr.Close()
        sd.Close()


        'physicianList.Add(New Physician("AD21", "John", "Smith", 1))
        'physicianList.Add(New Physician("AD22", "Peter", "Griffin", 3))
        'physicianList.Add(New Physician("AD23", "Ashley", "Froid", 2))
        'physicianList.Add(New Physician("AD24", "Kim", "Diaz", 4))
        'physicianList.Add(New Physician("AD25", "Miguel", "Blanco", 2))


        'TESTING READING FROM LOADED LIST
        '******************************************************************
        'MessageBox.Show("The fourth doctor in the file is named " &
        '                physicianList(3).firstName.ToString & " " &
        '                physicianList(3).lastName.ToString)

        'MessageBox.Show("The second patient in the file is named " &
        '                patientList(1).firstName.ToString & " " &
        '                patientList(1).lastName.ToString)
        '******************************************************************

    End Sub

    Private Sub patientAdd_Click() Handles patientAdd.Click


        patientForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click

        Msgbox_Yes_No()

    End Sub

    Private Sub Timer_Tick() Handles Timer.Tick

        lblDateTime.Text = Format(Now, "f")

    End Sub

    Private Sub AboutToolStripMenuItem_Click() Handles AboutToolStripMenuItem.Click

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("Description.txt")
        MsgBox(fileReader)

    End Sub

    Private Sub patientList_Click() Handles patientList.Click


        patientListForm.Show()
        Me.Hide()


    End Sub

    Private Sub patientFind_Click(sender As Object, e As EventArgs) Handles patientFind.Click


        patientFindForm.Show()
        Me.Hide()


    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click


        AppointmentMake.Show()


    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click


        AppointmentView.Show()

    End Sub
End Class
