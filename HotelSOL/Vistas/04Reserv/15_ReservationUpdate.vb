Imports System.Data.SqlClient

Public Class Form15

    Private controller As Controller = New Controller
    Private reservation As Reservation
    Dim i As Integer

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    'TODO: Falta implementar la lógica para filtrar por una reserva

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        Label13.Text = DataGridView1.Item(0, i).Value()
        RoomIdTextBox.Text = DataGridView1.Item(1, i).Value()
        ClientIdTextBox.Text = DataGridView1.Item(2, i).Value()
        EntryDatePicker.Text = DataGridView1.Item(3, i).Value()
        DepartureDatePicker.Text = DataGridView1.Item(4, i).Value()
        BoardTextBox.Text = DataGridView1.Item(6, i).Value()
        reservation = New Reservation(DataGridView1.Item(0, i).Value(), DataGridView1.Item(1, i).Value(), DataGridView1.Item(2, i).Value(), DataGridView1.Item(3, i).Value(), DataGridView1.Item(4, i).Value(), DataGridView1.Item(5, i).Value(), DataGridView1.Item(6, i).Value(), DataGridView1.Item(7, i).Value())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            controller.UpdateReservation(Me.reservation)
            MessageBox.Show("Reserva actualizada con éxito")
            llenar_grid()
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al realizar la actualización de los datos. Vuelva a intentarlo más tarde")
        End Try
    End Sub

    Private Sub llenar_grid()
        Dim dt As DataTable = controller.GetReservationsList()
        DataGridView1.DataSource = dt
    End Sub
End Class