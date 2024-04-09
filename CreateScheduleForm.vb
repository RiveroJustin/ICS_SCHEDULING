Public Class CreateScheduleForm
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub CreateScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartTime.Format = DateTimePickerFormat.Custom
        StartTime.CustomFormat = "hh:mm tt"

        EndTIme.Format = DateTimePickerFormat.Custom
        EndTIme.CustomFormat = "hh:mm tt"
    End Sub
End Class