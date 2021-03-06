﻿Public Class patientListForm



    Private Sub patientListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lstPatients.DataSource = patientList


    End Sub


    Private Sub btnExit_Click() Handles btnExit.Click

        Msgbox_Yes_No()

    End Sub

    Private Sub closeBtn_Click() Handles closeBtn.Click


        Me.Close()
        MainForm.Show()

    End Sub

    Public Sub btnEdit_Click() Handles btnEdit.Click


        'This gets the index of the object
        Dim indexExtract As String() = Split(lstPatients.SelectedItem.ToString(), ".")
        Dim index As Integer = CInt(indexExtract(1))


        idNumber = patientList.Item(index).idNumber
        firstName = patientList.Item(index).firstName
        lastName = patientList.Item(index).lastName
        birthDate = patientList.Item(index).birthDate
        phone = patientList.Item(index).phone
        email = patientList.Item(index).email
        insuranceProvider = patientList.Item(index).insuranceProvider
        planType = patientList.Item(index).planType
        subscriberID = patientList.Item(index).subscriberID
        planID = patientList.Item(index).planID

        Me.Close()
        editPatientForm.Show()

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click

    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        Try

            Dim indexExtract As String() = Split(lstPatients.SelectedItem.ToString(), ".")
            Dim index As Integer = CInt(indexExtract(1))

            patientList.RemoveAt(index)
            RefreshListView()

        Catch ex As ArgumentOutOfRangeException
            MsgBox("WOOOOOOT", 0, "YOU BROKE IT!!!!")
        Catch ex As System.NullReferenceException
            MsgBox("WOOOOOOT", 0, "YOU BROKE IT AGAIN!!!!")
        End Try



    End Sub


    Public Sub RefreshListView()

        lstPatients.DataSource = patientList

        lstPatients.ClearSelected()
        Me.Hide()
        Me.Show()


    End Sub


End Class