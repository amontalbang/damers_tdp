Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class DAOReservation
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
    Public Function ReservationExists(reservationId As UInteger) As Boolean
        Dim query As String = "SELECT * from Reservas WHERE IDreserva = '" & reservationId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function GetReservationById(reservationId As UInteger) As Reservation
        Dim query As String = "SELECT from Reservas WHERE IDreserva = '" & reservationId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Reservation()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Reservation(dr.Field(Of String)("reservationId"), dr.Field(Of String)("roomId"), dr.Field(Of String)("clientId"), dr.Field(Of String)("entryDate"), dr.Field(Of String)("departureDate"), dr.Field(Of String)("season"), dr.Field(Of String)("board"), dr.Field(Of String)("status"))

    End Function
    Public Function GetReservationList() As DataTable
        Dim consulta As String = "SELECT * FROM Reservas"
        Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
        Dim reservationList As New DataTable
        adaptador.Fill(reservationList)
        Return reservationList
    End Function
End Class
