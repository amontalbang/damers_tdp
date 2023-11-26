Public Class Form22
    Dim data As DataTable
    Dim controller As New Controller

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ButtonReservation_Click(sender As Object, e As EventArgs) Handles ButtonReservation.Click
        Try
            data = controller.GetReservationListsByDate(DateTimePicker1.Value, DateTimePicker2.Value, "reservation")
            Show_Dialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEntries_Click(sender As Object, e As EventArgs) Handles ButtonEntries.Click
        Try
            data = controller.GetReservationListsByDate(DateTimePicker4.Value, DateTimePicker3.Value, "entry")
            Show_Dialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDepartures_Click(sender As Object, e As EventArgs) Handles ButtonDepartures.Click
        Try
            data = controller.GetReservationListsByDate(DateTimePicker6.Value, DateTimePicker5.Value, "departure")
            Show_Dialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonActiveReservation_Click(sender As Object, e As EventArgs) Handles ButtonActiveReservation.Click
        Try
            data = controller.GetActiveReservations()
            Show_Dialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonClient_Click(sender As Object, e As EventArgs) Handles ButtonClient.Click
        Try
            Dim clientId As String = ClientTextBox.Text
            data = controller.GetReservationByClient(clientId)
            Show_Dialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Show_Dialog()
        Dim formDialog As Form = New Dialog1(data)
        formDialog.ShowDialog()
    End Sub
End Class