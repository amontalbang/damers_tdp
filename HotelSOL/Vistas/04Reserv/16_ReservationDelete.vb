Public Class Form16

    Private controller As Controller = New Controller
    Private reservationId As UInteger
    Dim i As Integer

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim clientId As String = TextBox10.Text
            Dim dt As DataTable = controller.GetAllReservationByClientId(clientId)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se ha podido realizar la consulta a base de datos")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If reservationId Then
            Try
                controller.RemoveReservation(reservationId)
                MessageBox.Show("La reserva se ha eliminado correctamente")
                llenar_grid()
            Catch ex As Exception
                MessageBox.Show("Error en base de datos")
            End Try
        Else

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        reservationId = UInteger.Parse(DataGridView1.Item(0, i).Value())
        Label13.Text = DataGridView1.Item(0, i).Value()
    End Sub

    Private Sub llenar_grid()
        Try
            Dim dt As DataTable = controller.GetReservationsList()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error en la conexión con base de datos")
        End Try
    End Sub
End Class