Public Class Appointment


    Public Property ID As String
    Public Property Doctor As String
    Public Property Patient As String
    Public Property [Date] As String
    Public Property Time As String
    Public Property Purpose As String
    Public Property Length As String

    Public Sub New()

    End Sub


    Public Sub New(ByVal idNumber As String,
                   ByVal doctorFirst As String,
                   ByVal doctorLast As String,
                   ByVal patientFirst As String,
                   ByVal patientLast As String,
                   ByVal apptDate As String,
                   ByVal apptTime As String,
                   ByVal purpose As String,
                   ByVal length As String)



        Me.ID = idNumber
        Me.Doctor = Trim(doctorLast & "," & doctorFirst)
        Me.Patient = Trim(patientLast & "," & patientFirst)
        Me.Date = apptDate
        Me.Time = apptTime
        Me.Purpose = purpose
        Me.Length = Trim(length) & " Minutes"


    End Sub




    Public Overrides Function ToString() As String

        Return ("." & ID & ".   " & vbTab &
                "[Doctor:" & Doctor &
                " Patient:" & Patient &
                " Date:" & [Date] &
                " Time" & Time &
                " Reason:" & Purpose &
                " Length:" & Length & "]")


    End Function


End Class
