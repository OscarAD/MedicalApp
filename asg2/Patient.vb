Imports Asg2
Imports System.Collections.Generic



Public Class Patient

    Public Property idNumber As String
    Public Property firstName As String
    Public Property lastName As String
    Public Property birthDate As String
    Public Property phone As String
    Public Property email As String
    Public Property insuranceProvider As String
    Public Property planType As String
    Public Property subscriberID As String
    Public Property planID As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal idNumber As String,
                   ByVal firstName As String,
                   ByVal lastName As String,
                   ByVal birthDate As String,
                   ByVal phone As String,
                   ByVal email As String,
                   ByVal insuranceProvider As String,
                   ByVal planType As String,
                   ByVal subscriberID As String,
                   ByVal planID As String)


        Me.idNumber = idNumber
        Me.firstName = Trim(firstName)
        Me.lastName = Trim(lastName)
        Me.birthDate = birthDate
        Me.phone = Trim(phone)
        Me.email = Trim(email)
        Me.insuranceProvider = insuranceProvider
        Me.planType = planType
        Me.subscriberID = Trim(subscriberID)
        Me.planID = Trim(planID)


    End Sub


    Public Sub New(ByVal idNumber As String,
                 ByVal firstName As String,
                 ByVal lastName As String,
                 ByVal birthDate As String,
                 ByVal phone As String,
                 ByVal email As String)

        Me.idNumber = idNumber
        Me.firstName = Trim(firstName)
        Me.lastName = Trim(lastName)
        Me.birthDate = birthDate
        Me.phone = Trim(phone)
        Me.email = Trim(email)

    End Sub



    Public Overrides Function ToString() As String

        Return ("." & idNumber & ".   " & vbTab & "[" & lastName & ", " & firstName & "]" & vbTab & "DOB:" & birthDate)

    End Function



End Class
