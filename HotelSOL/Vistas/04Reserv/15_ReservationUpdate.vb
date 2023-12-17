Imports System.Data.SqlClient

Public Class Form15

    Private controller As Controller = New Controller
    Private reservation As Reservation
    Dim i As Integer

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
        GetRooms()
    End Sub

    'TODO: Falta implementar la lógica para filtrar por una reserva

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        Label13.Text = DataGridView1.Item(0, i).Value()
        RoomSelector.Text = DataGridView1.Item(1, i).Value()
        ClientIdTextBox.Text = DataGridView1.Item(2, i).Value()
        EntryDatePicker.Text = DataGridView1.Item(3, i).Value()
        DepartureDatePicker.Text = DataGridView1.Item(4, i).Value()
        BoardSelector.Text = DataGridView1.Item(6, i).Value()
        reservation = New Reservation(DataGridView1.Item(0, i).Value(), DataGridView1.Item(1, i).Value(), DataGridView1.Item(2, i).Value(), DataGridView1.Item(3, i).Value(), DataGridView1.Item(4, i).Value(), DataGridView1.Item(5, i).Value(), DataGridView1.Item(6, i).Value(), DataGridView1.Item(7, i).Value())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roomID As UInteger = CUInt(RoomSelector.SelectedItem.ToString)
        Dim clientId As String = ClientIdTextBox.Text
        Dim entryDate As Date = CDate(EntryDatePicker.Text)
        Dim departureDate As Date = CDate(DepartureDatePicker.Text)
        Dim board As String = BoardSelector.SelectedItem.ToString
        Dim season As String = controller.GetReservationSeasson(EntryDatePicker.Text)
        Dim newReserv As Reservation = New Reservation(reservation.ReservationIdProp, roomID, clientId, entryDate, departureDate, season, board, reservation.isActiveProp)
        Try
            If controller.CheckReservationExists(reservation.ReservationIdProp) Then
                controller.UpdateReservation(newReserv)
                DataGridView1.DataSource = controller.GetReservationsList
                DataGridView1.Refresh()
                MessageBox.Show("Reserva actualizada con éxito")
            Else
                MessageBox.Show("Se ha producido un error al realizar la actualización de los datos. Vuelva a intentarlo más tarde")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenar_grid()
        Dim dt As DataTable = controller.GetReservationsList()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub GetRooms()
        Try
            RoomSelector.DataSource = controller.GetRoomIds()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos")
        End Try
    End Sub
End Class