Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

''' <summary>
''' Clase que implementa los metodos referentes a las reservas
''' </summary>
Public Class DAOReservation
    Private connector As DataBaseConnection = New DatabaseConnection

    ''' <summary>
    ''' Metodo que añade una reserva de la BD
    ''' </summary>
    ''' <param name="Reservation">objeto reserva</param>
    Public Sub AddReservation(Reservation As Reservation)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Reservas (IDCliente, IDHabitacion , FechaEntr , FechaSal, Temporada, Regimen, Estado) VALUES ('" & Reservation.ClientIdProp & "', '" & Reservation.RoomIdProp & "', '" & Reservation.EntryDateProp & "', '" & Reservation.DepartureDateProp & "',  '" & Reservation.SeasonProp & "','" & Reservation.BoardProp & "', '" & False & "')"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            connector.Disconnect()
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina una reserva de la BD
    ''' </summary>
    ''' <param name="ReservationId">objeto reserva</param>
    Public Sub RemoveReservation(ReservationId As Reservation)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "DELETE from Reservas where IDreserva = '" & ReservationId.ReservationIdProp & "'"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            connector.Disconnect()
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que actualiza una reserva en la BD
    ''' </summary>
    ''' <param name="Reservation">objeto reserva</param>
    Public Sub UpdateReservation(Reservation As Reservation)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            Dim estado As Integer
            If Reservation.isActiveProp Then
                estado = 1
            Else
                estado = 0
            End If
            cmd.CommandText = "UPDATE Reservas set IDcliente = '" & Reservation.ClientIdProp & "', IDHabitacion = '" & Reservation.RoomIdProp & "', FechaEntr = '" & Reservation.EntryDateProp & "' , FechaSal = '" & Reservation.DepartureDateProp & "', Temporada = '" & Reservation.SeasonProp & "', Regimen = '" & Reservation.BoardProp & "', Estado = " & estado & " where IDreserva = '" & Reservation.ReservationIdProp & "'"
            cmd.Connection = connector.Connect()
            cmd.ExecuteNonQuery()
            connector.Disconnect()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que comprueba se existe una reserva en la BD
    ''' </summary>
    ''' <param name="reservationId">ID de la reserva</param>
    ''' <returns>devuelve el resultado de la comprobacion</returns>
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

    ''' <summary>
    ''' Metodo que devuelve una reserva por su ID de reserva
    ''' </summary>
    ''' <param name="reservationId">ID de la reserva</param>
    ''' <returns>la reserva si existe en la BD o una nueva reserva si no existe</returns>
    Public Function GetReservationById(reservationId As UInteger) As Reservation
        Try
            Dim query As String = "SELECT * from Reservas WHERE IDreserva = '" & reservationId & "'"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.AsEnumerable().Count() = 0 Then
                Return New Reservation()
            End If
            Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
            Dim reserv As New Reservation
            'Return New Reservation(dr.Field(Of UInteger)("IDreserva"), dr.Field(Of UInteger)("IDhabitacion"), dr.Field(Of Date)("IDCliente"), dr.Field(Of Date)("FechaEntr"), dr.Field(Of String)("FechaSal"), dr.Field(Of String)("Temporada"), dr.Field(Of String)("Regimen"), dr.Field(Of Boolean)("Estado"))
            reserv.ReservationIdProp = CUInt(dt.AsEnumerable().ElementAt(0).Item(0).ToString)
            reserv.RoomIdProp = CUInt(dt.AsEnumerable().ElementAt(0).Item(1).ToString)
            reserv.ClientIdProp = dt.AsEnumerable().ElementAt(0).Item(2).ToString
            reserv.EntryDateProp = CDate(dt.AsEnumerable().ElementAt(0).Item(3).ToString)
            reserv.DepartureDateProp = CDate(dt.AsEnumerable().ElementAt(0).Item(4).ToString)
            reserv.SeasonProp = dt.AsEnumerable().ElementAt(0).Item(5).ToString
            reserv.BoardProp = dt.AsEnumerable().ElementAt(0).Item(6).ToString
            reserv.isActiveProp = CBool(dt.AsEnumerable().ElementAt(0).Item(7).ToString)
            Return New Reservation(reserv.ReservationIdProp, reserv.RoomIdProp, reserv.ClientIdProp, reserv.EntryDateProp, reserv.DepartureDateProp, reserv.SeasonProp, reserv.BoardProp, reserv.isActiveProp)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que devuelve una lista con todas las reservas
    ''' </summary>
    ''' <returns>devuelve un datatable con la lista de reservas</returns>
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

    ''' <summary>
    ''' Metodo que devuelve el listado de reservas activas
    ''' </summary>
    ''' <returns></returns>
    Public Function GetActiveReservationList() As DataTable
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE Estado = 1"
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Return reservationList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que devuelve las reservas referentes a un cliente
    ''' </summary>
    ''' <param name="ClientId">ID de cliente</param>
    ''' <returns>devuelve un datatable con la lista de reservas</returns>
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

    ''' <summary>
    ''' Metodo que devuelve un datatable con la informacion de un CLiente dado un ID de cliente
    ''' </summary>
    ''' <param name="ClientId">ID de cliente</param>
    ''' <returns>datatable con la informacion de un cliente</returns>
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

    ''' <summary>
    ''' Metodo que devuelve una reserva dada una ID de cliente y una ID de habitacion
    ''' </summary>
    ''' <param name="ClientId">ID de cliente</param>
    ''' <param name="RoomId">ID de habitacion</param>
    ''' <returns>Objeto reserva</returns>
    Public Function GetReservationByClientAndRoom(ClientId As String, RoomId As String) As Reservation
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDcliente = '" & ClientId & "' AND IDHabitacion = " & RoomId & "' AND Estado = 1"
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

    ''' <summary>
    ''' Metodo que devuelve una reserva dada una ID de habitacion
    ''' </summary>
    ''' <param name="RoomId">ID de habitacion</param>
    ''' <returns>objeto reserva</returns>
    Public Function GetReservationByRoomId(RoomId As UInteger) As Reservation
        Try
            Dim consulta As String = "SELECT * FROM Reservas WHERE IDhabitacion = " & RoomId & "AND  Estado = 1"
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

    ''' <summary>
    ''' MEtodo que comprueba si una reserva esta activa
    ''' </summary>
    ''' <param name="ReservationId">ID de reserva</param>
    ''' <returns>devuelve booleano con la respuesta de la comprobacion</returns>
    Public Function CheckIfReservationIsActive(ReservationId As UInteger) As Boolean
        Try
            Dim consulta As String = "SELECT Estado FROM Reservas WHERE IDreserva = " & ReservationId
            Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
            Dim reservationList As New DataTable
            adaptador.Fill(reservationList)
            Dim estado As UInteger = CUInt(reservationList.AsEnumerable().ElementAt(0).Item(0))
            If (estado = 1) Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' metodo que devuelve un datatable con la informacion de una reserva dado un rango de fechas
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns></returns>
    Public Function GetReservationByDate(startDate As Date, endDate As Date) As DataTable
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
