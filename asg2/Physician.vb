
Public Enum Specialty
    Family = 1
    Obstetrics = 2
    Pediatrics = 3
    Orthopedics = 4
End Enum
Public Class Physician
    Public Property idNumber As String
    Public Property firstName As String
    Public Property lastName As String

    Public specialty As Specialty

    Public Sub New()

    End Sub


    Public Sub New(ByVal idNumber As String,
                   ByVal firstName As String,
                   ByVal lastName As String,
                   ByVal specialty As Integer)


        Me.idNumber = idNumber
        Me.firstName = firstName
        Me.lastName = lastName

        Select Case specialty
            Case 1
                Me.specialty = Asg2.Specialty.Family
            Case 2
                Me.specialty = Asg2.Specialty.Obstetrics
            Case 3
                Me.specialty = Asg2.Specialty.Orthopedics
            Case 4
                Me.specialty = Asg2.Specialty.Pediatrics
            Case Else
                MessageBox.Show("Invalid number")
        End Select

    End Sub



    Public Overrides Function ToString() As String

        Return ("." & idNumber & ".   " & firstName & " " & lastName & vbTab & "[" & specialty.ToString & "]")

    End Function

End Class
