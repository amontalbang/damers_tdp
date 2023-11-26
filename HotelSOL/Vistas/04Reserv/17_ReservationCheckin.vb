Public Class Form17
    Private controller As New Controller
    Private reservationId As UInteger
    Private client As String
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub SearchClientReservation_Click(sender As Object, e As EventArgs) Handles SearchClientReservation.Click
        Try
            client = ClientId.Text
            Llenar_grid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            reservationId = CUInt(DataGridView1.Item(0, i).Value())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub checkin_Click(sender As Object, e As EventArgs) Handles checkin.Click
        Try
            controller.CheckIn(reservationId)
            Llenar_grid()
            MessageBox.Show("El check-in se ha realizado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Llenar_grid()
        Try
            Dim dt As DataTable
            dt = controller.GetAllReservationByClientId(client)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuAdmin.openFormHijo(New Form21())
        MenuAdmin.ocultarSubmenu()
    End Sub
End Class