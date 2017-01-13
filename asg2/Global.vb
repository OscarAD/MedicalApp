Imports System.IO
Imports System.Xml.Serialization

Module Files


    Public patientList As New List(Of Patient)
    Public physicianList As New List(Of Physician)
    Public appointmentList As New List(Of Appointment)


    Public Sub onlyNumbers(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar <> ControlChars.Back Then

            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)

        End If

    End Sub


    Public Sub NumbersNLetters(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = ("abcdefghijklmnopqrstuvwxyz0123456789".IndexOf(e.KeyChar) = -1)
        End If

    End Sub



    Sub Msgbox_Yes_No()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Close application?",
                          Buttons:=vbYesNo, Title:="Confirm")

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then

            Dim sw As New StreamWriter("Physicians.xml")
            Dim serial As New XmlSerializer(physicianList.GetType())
            serial.Serialize(sw, physicianList)
            sw.Close()
            Application.Exit()

        Else


        End If

    End Sub


    Public results As IEnumerable(Of Patient)


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

End Module
