Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class DaoReservation
    Private connector As DataBaseConnection = New DataBaseConnection

    Public Sub AddReservation(Reservation As Reservation)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Reservas (IDCliente, IDHabitacion , FechaEntr , FechaSal, Regimen, Estado) VALUES ('" & Reservation.ClientIdProp & "', '" & Reservation.RoomIdProp & "', '" & Reservation.EntryDateProp & "', '" & Reservation.DepartureDateProp & "', '" & Reservation.BoardProp & "', '" & False & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Reserva registrada correctamente")
    End Sub
    Public Sub DeleteReservation(Reservation As Reservation)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "DELETE from Reservas where IDreserva = '" & Reservation.ReservationIdProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Reserva eliminada con éxito")
    End Sub
    Public Sub UpdateReservation(Reservation As Reservation)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "UPDATE Reservas set IDCliente = '" & Reservation.ClientIdProp & "', IDHabitacion = '" & Reservation.RoomIdProp & "', FechaEntr = '" & Reservation.EntryDateProp & "' , FechaSal = '" & Reservation.DepartureDateProp & "', Regimen = '" & Reservation.BoardProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Reserva actualizada correctamente")
    End Sub
    Public Function ReservationExists(Reservation As UInteger) As Boolean
        Return False
    End Function
    Public Function GetReservationById(Reservation As UInteger) As Reservation
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT from RESERVAS where IDreserva = '" & Reservation & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Reserva actualizada correctamente")
        Return New Reservation()
    End Function
    Public Function GetReservationList() As Reservation()
        Return {New Reservation()}
    End Function
End Class
