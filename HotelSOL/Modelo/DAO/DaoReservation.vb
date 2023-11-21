Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class DAOReservation
    Private connector As DataBaseConnection = New DatabaseConnection

    Public Sub AddReservation(Reservation As Reservation)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Reservas (IDCliente, IDHabitacion , FechaEntr , FechaSal, Regimen, Estado) VALUES ('" & Reservation.ClientIdProp & "', '" & Reservation.RoomIdProp & "', '" & Reservation.EntryDateProp & "', '" & Reservation.DepartureDateProp & "', '" & Reservation.BoardProp & "', '" & False & "')"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            connector.Disconnect()
        End Try
    End Sub
    Public Sub RemoveReservation(ReservationId As UInteger)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "DELETE from Reservas where IDreserva = '" & ReservationId.ToString() & "'"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            connector.Disconnect()
        End Try
    End Sub
    Public Sub UpdateReservation(Reservation As Reservation)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "UPDATE Reservas set IDcliente = '" & Reservation.ClientIdProp & "', IDHabitacion = '" & Reservation.RoomIdProp & "', FechaEntr = '" & Reservation.EntryDateProp & "' , FechaSal = '" & Reservation.DepartureDateProp & "', Regimen = '" & Reservation.BoardProp & "' where IDreserva = '" & Reservation.ReservationIdProp & "'"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
            connector.Disconnect()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ReservationExists(reservationId As UInteger) As Boolean
        Try
            Dim query As String = "SELECT * from Reservas WHERE IDreserva = '" & reservationId & "'"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.AsEnumerable().Count() > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetReservationById(reservationId As UInteger) As Reservation
        Try
            Dim query As String = "SELECT from Reservas WHERE IDreserva = '" & reservationId & "'"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.AsEnumerable().Count() = 0 Then
                Return New Reservation()
            End If
            Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
            Return New Reservation(dr.Field(Of String)("reservationId"), dr.Field(Of String)("roomId"), dr.Field(Of String)("clientId"), dr.Field(Of String)("entryDate"), dr.Field(Of String)("departureDate"), dr.Field(Of String)("season"), dr.Field(Of String)("board"), dr.Field(Of String)("status"))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetReservationList() As DataTable
        Try
            Dim consulta As String = "SELECT * FROM Reservas"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Return reservationList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetAllReservationByClientId(ClientId As String) As DataTable
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDcliente = '" & ClientId & "'"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Return reservationList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetReservationByClientId(ClientId As String) As DataTable
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDcliente = '" & ClientId & "' AND Estado = 1"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Return reservationList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetReservationByClientAndRoom(ClientId As String, RoomId As String) As Reservation
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDcliente = '" & ClientId & "' IDHabitacion = " & RoomId & "' AND Estado = 1"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Dim reservation As New Reservation
            reservation.ReservationIdProp = UInteger.Parse(reservationList.AsEnumerable().ElementAt(0).Item(0).ToString)
            reservation.RoomIdProp = reservationList.AsEnumerable().ElementAt(0).Item(1).ToString
            reservation.ClientIdProp = reservationList.AsEnumerable().ElementAt(0).Item(2).ToString
            reservation.EntryDateProp = CDate(reservationList.AsEnumerable().ElementAt(0).Item(3).ToString)
            reservation.DepartureDateProp = CDate(reservationList.AsEnumerable().ElementAt(0).Item(4).ToString)
            reservation.SeasonProp = reservationList.AsEnumerable().ElementAt(0).Item(5).ToString
            reservation.BoardProp = reservationList.AsEnumerable().ElementAt(0).Item(6).ToString
            reservation.isActiveProp = reservationList.AsEnumerable().ElementAt(0).Item(7).ToString
            Return reservation
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetReservationByRoomId(RoomId As String) As Reservation
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDhabitacion = '" & RoomId & "' Estado = 1"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Dim reservation As New Reservation
            reservation.ReservationIdProp = UInteger.Parse(reservationList.AsEnumerable().ElementAt(0).Item(0).ToString)
            reservation.RoomIdProp = reservationList.AsEnumerable().ElementAt(0).Item(1).ToString
            reservation.ClientIdProp = reservationList.AsEnumerable().ElementAt(0).Item(2).ToString
            reservation.EntryDateProp = CDate(reservationList.AsEnumerable().ElementAt(0).Item(3).ToString)
            reservation.DepartureDateProp = CDate(reservationList.AsEnumerable().ElementAt(0).Item(4).ToString)
            reservation.SeasonProp = reservationList.AsEnumerable().ElementAt(0).Item(5).ToString
            reservation.BoardProp = reservationList.AsEnumerable().ElementAt(0).Item(6).ToString
            reservation.isActiveProp = reservationList.AsEnumerable().ElementAt(0).Item(7).ToString
            Return reservation
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
