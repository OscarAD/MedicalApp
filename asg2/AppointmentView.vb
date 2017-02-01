Public Class AppointmentView
    Private Sub AppointmentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'lstText.DataSource = appointmentList
        DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView.DataSource = appointmentList


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()


    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class