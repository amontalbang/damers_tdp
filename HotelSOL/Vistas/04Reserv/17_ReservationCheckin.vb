Public Class Form17
    Private controller As New Controller
    Private reservationId As UInteger
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub SearchClientReservation_Click(sender As Object, e As EventArgs) Handles SearchClientReservation.Click
        Try
            Dim dt As DataTable
            dt = controller.GetAllReservationByClientId(ClientId.Text)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            reservationId = CUInt(DataGridView1.Item(0, 1).Value())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub checkin_Click(sender As Object, e As EventArgs) Handles checkin.Click
        Try
            Dim reservation As Reservation = controller.GetReservationById(reservationId)
            reservation.isActiveProp = True
            controller.UpdateReservation(reservation)
            MessageBox.Show("El checkin se ha realizado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class