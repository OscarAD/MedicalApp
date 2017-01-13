Public Class patientFindForm

    Public search As String

    Public Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click


        If onlyLastCheck.Checked = True Then

            'Clear error if on
            Me.ErrorProvider.SetError(Me.txtFname, "")

            If Trim(txtLname.Text) <> "" Then


                results = From n In patientList
                          Where n.lastName.ToLower = txtLname.Text.ToLower

                If results.Count > 0 Then

                    patientListForm.Show()

                    patientListForm.lstPatients.DataSource = results.ToList

                    statLabel.Text = ""
                Else
                    statLabel.Text = ("No records found with last name " & txtLname.Text)
                    Me.ErrorProvider.SetError(Me.txtLname, "")
                End If



            Else


                If Not Trim(txtLname.Text) <> "" Then
                    Me.ErrorProvider.SetError(Me.txtLname, "Please enter last name")
                End If

                statLabel.Text = ("Enter required field")

            End If



        Else

            If Trim(txtFname.Text) <> "" Then

                Me.ErrorProvider.SetError(Me.txtFname, "")

            End If

            If Trim(txtLname.Text) <> "" Then

                Me.ErrorProvider.SetError(Me.txtLname, "")

            End If

            If Trim(txtFname.Text) <> "" And
               Trim(txtLname.Text) <> "" Then


                results = From n In patientList
                          Where n.lastName.ToLower = txtLname.Text.ToLower And
                              n.firstName.ToLower = txtFname.Text.ToLower And
                              n.birthDate = Datepick.Text

                If results.Count > 0 Then

                    patientListForm.Show()

                    patientListForm.lstPatients.DataSource = results.ToList
                Else

                    statLabel.Text = ("No records found")


                End If

            Else

                If Not Trim(txtFname.Text) <> "" Then
                    Me.ErrorProvider.SetError(Me.txtFname, "Please enter first name")
                End If

                If Not Trim(txtLname.Text) <> "" Then
                    Me.ErrorProvider.SetError(Me.txtLname, "Please enter last name")
                End If

                statLabel.Text = ("Enter required field/s")


            End If



        End If



    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click

        MainForm.Show()
        Me.Close()


    End Sub

    Private Sub onlyLastCheck_CheckedChanged(sender As Object, e As EventArgs) Handles onlyLastCheck.CheckedChanged

        txtFname.Visible = Not txtFname.Visible
        Datepick.Visible = Not Datepick.Visible
        Label2.Visible = Not Label2.Visible
        Label5.Visible = Not Label5.Visible


    End Sub
End Class