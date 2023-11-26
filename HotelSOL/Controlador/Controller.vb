Imports System.Data.Entity.Core
Imports System.Data.SqlClient
''' <summary>
''' Clase Controlador que enlaza las vistas y el modelo
''' </summary>
Public Class Controller

    Private daoClient As DaoClient
    Private daoRoom As DAORoom
    Private daoService As DaoService
    Private daoUser As DaoUser
    Private daoReservation As DAOReservation
    Private daoInvoice As DAOInvoice
    Private reservationCheckout As Form18

    ''' <summary>
    ''' Metodo constructor de la clase
    ''' </summary>
    Public Sub New()
        Dim daoFactory As DaoFactory = New DaoFactory()
        daoClient = daoFactory.GetDaoClient()
        daoRoom = daoFactory.GetDaoRoom()
        daoService = daoFactory.GetDaoService()
        daoUser = daoFactory.GetDaoUser()
        daoReservation = daoFactory.GetDaoReservation()
        daoInvoice = daoFactory.GetDaoInvoice()
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo AddClient de daoClient
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub AddClient(Client As Client)
        Try
            daoClient.AddClient(Client)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UpdateClient de daoClient
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub UpdateClient(Client As Client)
        Try
            daoClient.UpdateClient(Client)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo DeleteClient de daoClient
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub DeleteClient(Client As Client)
        Try
            daoClient.DeleteClient(Client)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo GetClientById de daoClient
    ''' </summary>
    ''' <param name="Client">cadena con Id del cliente</param>
    ''' <returns>devuelve el cliente solicitado</returns>
    Public Function GetClientById(Client As String)
        Try
            Return daoClient.GetClientById(Client)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo ClientExists de daoClient
    ''' </summary>
    ''' <param name="Client">cadena con Id del cliente</param>
    ''' <returns>devuelve booleano con la existencia del cliente</returns>
    Public Function ClientExists(Client As String) As Boolean
        Try
            Return daoClient.ClientExists(Client)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo GetClientList de daoClient
    ''' </summary>
    ''' <returns>devuelve la lista de clientes</returns>
    Public Function GetClientList()
        Try
            Return daoClient.GetClientList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo AddRoom de daoRoom
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub AddRoom(Room As Room)
        Try
            daoRoom.AddRoom(Room)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo DeleteRoom de daoRoom
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub DeleteRoom(Room As Room)
        Try
            daoRoom.DeleteRoom(Room)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UpdateRoom de daoRoom
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub UpdateRoom(Room As Room)
        Try
            daoRoom.UpdateRoom(Room)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo GetRoomById de daoRoom
    ''' </summary>
    ''' <param name="Room">cadena con el numero de habitacion</param>
    ''' <returns>devuelve la habitacion solicitada</returns>
    Public Function GetRoomById(Room As String)
        Try
            Return daoRoom.GetRoomById(Room)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo RoomExists de daoRoom
    ''' </summary>
    ''' <param name="Room">cadena con el numero de habitacion</param>
    ''' <returns>booleano con la existencia de la habitacion</returns>
    Public Function RoomExists(Room As String) As Boolean
        Try
            Return daoRoom.RoomExists(Room)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo GetRoomList de daoRoom
    ''' </summary>
    ''' <returns>devuelve datatable con lista de habitaciones</returns>
    Public Function GetRoomList()
        Try
            Return daoRoom.GetRoomList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo AddService de daoService
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub AddService(Service As Service)
        Try
            daoService.AddService(Service)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo DeleteService de daoService
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub DeleteService(Service As Service)
        Try
            daoService.DeleteService(Service)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UpdateService de daoService
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub UpdateService(Service As Service)
        Try
            daoService.UpdateService(Service)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo GetServiceById de daoService
    ''' </summary>
    ''' <param name="Service">entero con el Id del servicio</param>
    ''' <returns>devuelve el objeto servicio solicitado</returns>
    Public Function GetServiceById(Service As UInteger)
        Try
            Return daoService.GetServiceById(Service)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo ServiceExists de daoService
    ''' </summary>
    ''' <param name="Service">entero con el Id del servicio</param>
    ''' <returns>booleano con la existencia del servicio</returns>
    Public Function ServiceExists(Service As UInteger) As Boolean
        Try
            Return daoService.ServiceExists(Service)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo GetServiceList de daoService
    ''' </summary>
    ''' <returns>devuelve lista con todos los servicios</returns>
    Public Function GetServiceList()
        Try
            Return daoService.GetServiceList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método que carga un nuevo servicio a una reserva
    ''' </summary>
    ''' <param name="roomId"></param>
    ''' <param name="serviceId"></param>
    ''' <param name="units"></param>
    Public Sub ChargeService(roomId As UInteger, serviceId As UInteger, units As Integer)
        Try
            Dim reservation As Reservation = daoReservation.GetReservationByRoomId(roomId)
            Dim invoice As Invoice = daoInvoice.GetInvoiceByReservationId(reservation.ReservationIdProp)
            daoService.ChargeService(invoice.InvoiceIdProp, serviceId, units)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Recupara los identificadores de las habitaciones
    ''' </summary>
    ''' <returns>Array con los identificadores de las habitaciones</returns>
    Public Function GetRoomIds() As Array
        Try
            Dim dt As DataTable = daoRoom.GetRoomList()
            Dim totalRooms As Integer = dt.AsEnumerable().Count()
            Dim roomIds(totalRooms) As String
            For index = 0 To dt.AsEnumerable().Count() - 1
                roomIds(index) = dt.AsEnumerable().ElementAt(index).Item(0).ToString()
            Next
            Return roomIds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para comprobar si la habitación está disponible
    ''' </summary>
    ''' <param name="EntryDate"></param>
    ''' <param name="DepartureDate"></param>
    ''' <returns></returns>
    Public Function CheckRoomAvailability(EntryDate As Date, DepartureDate As Date) As Array
        Try
            Dim dt As DataTable = daoRoom.GetRoomList()
            Dim totalRooms As Integer = dt.AsEnumerable().Count()
            Dim availableRoomIds(totalRooms) As String
            For index = 0 To dt.AsEnumerable().Count() - 1
                Dim roomId As String = dt.AsEnumerable().ElementAt(index).Item(0).ToString()
                Dim reservation As Reservation = daoReservation.GetReservationByRoomId(roomId)
                If ((EntryDate.CompareTo(reservation.EntryDateProp) < 0 And DepartureDate.CompareTo(reservation.EntryDateProp) < 0) Or (EntryDate.CompareTo(reservation.DepartureDateProp) > 0 And DepartureDate.CompareTo(reservation.DepartureDateProp) > 0)) Then
                    availableRoomIds(index) = roomId
                End If
            Next
            Return availableRoomIds
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo AddUser de daoUser
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub AddUser(User As User)
        Try
            daoUser.AddUser(User)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo DeleteUser de daoUser
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub DeleteUser(User As User)
        Try
            daoUser.DeleteUser(User)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UpdateUser de daoUser
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub UpdateUser(User As User)
        Try
            daoUser.UpdateUser(User)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UserExists de daoUser
    ''' </summary>
    ''' <param name="User">cadena con el Id de usuario</param>
    ''' <returns>booleano con la existencia del usuario consultado</returns>
    Public Function UserExists(User As String) As Boolean
        Try
            Return daoUser.UserExists(User)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que accede al metodo GetUserList de daoUser
    ''' </summary>
    ''' <returns>devuelve lista con todos los usuarios</returns>
    Public Function GetUserList()
        Try
            Return daoUser.GetUserList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que añade una reserva
    ''' </summary>
    ''' <param name="Reservation">objeto reserva</param>
    Public Sub AddReservation(Reservation As Reservation)
        Try
            If (ClientExists(Reservation.ClientIdProp)) Then
                Dim seasson As String = GetReservationSeasson(Reservation.EntryDateProp)
                Reservation.SeasonProp = seasson
                daoReservation.AddReservation(Reservation)
            Else
                Throw (New Exception("El cliente introducido no existe"))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo UpdateReservation de daoReservation
    ''' </summary>
    ''' <param name="Reservation">objeto reserva</param>
    Public Sub UpdateReservation(Reservation As Reservation)
        Try
            If (ClientExists(Reservation.ClientIdProp)) Then
                daoReservation.UpdateReservation(Reservation)
            Else
                Throw (New Exception("El cliente introducido no existe"))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que accede al metodo RemoveReservation de daoReservation
    ''' </summary>
    ''' <param name="ReservationId">objeto reserva</param>
    Public Sub RemoveReservation(ReservationId As Reservation)
        Try
            daoReservation.RemoveReservation(ReservationId)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo para realizar el checkin de una reserva
    ''' </summary>
    ''' <param name="ReservationId">ID de la reserva</param>
    Public Sub CheckIn(ReservationId As UInteger)
        Try
            If Me.CheckReservationExists(ReservationId) And Not daoInvoice.CheckIfReservationHasInvoice(ReservationId) Then
                Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
                reservation.isActiveProp = True
                daoReservation.UpdateReservation(reservation)
                Dim Invoice As Invoice = New Invoice(ReservationId)
                daoInvoice.AddInvoice(Invoice)
            ElseIf (daoInvoice.CheckIfReservationHasInvoice(ReservationId)) Then
                Throw New Exception("La reserva ya se encuentra activa")
            Else
                Throw New Exception("La reserva no existe")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo para realizar el checkout de una reserva
    ''' </summary>
    ''' <param name="ReservationId">ID de la reserva</param>
    Public Function CheckOut(ReservationId As UInteger) As UInteger
        Try
            Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
            reservation.isActiveProp = False
            daoReservation.UpdateReservation(reservation)
            Dim invoice As Invoice = daoInvoice.GetInvoiceByReservationId(ReservationId)
            Return Me.GetTotalInvoice(reservation, invoice.InvoiceIdProp)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que devuelve una reserva dada una ID de reserva
    ''' </summary>
    ''' <param name="ReservationId">ID de la resevra</param>
    ''' <returns>datatable con la informacion de la reserva</returns>
    Public Function GetReservationById(ReservationId As UInteger) As Reservation
        Try
            If Me.CheckReservationExists(ReservationId) Then
                Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
                Return reservation
            Else
                Throw New Exception("El número de reserva introducido no existe")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que devuelve una lista de todas las reservas
    ''' </summary>
    ''' <returns>datatable con la informacion de las reservas</returns>
    Public Function GetReservationsList() As DataTable
        Try
            Return daoReservation.GetReservationList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que devuelve una reserva dada una ID de cliente
    ''' </summary>
    ''' <param name="ClientId">ID de cliente</param>
    ''' <returns>datatable con la informacion de la reserva</returns>
    Public Function GetReservationByClientId(ClientId As String) As DataTable
        Try
            If Me.CheckClientExists(ClientId) Then
                Dim dt As DataTable
                dt = daoReservation.GetReservationByClientId(ClientId)
                Return dt
            Else
                Throw New Exception("El cliente no existe")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ClientId"></param>
    ''' <returns></returns>
    Public Function GetAllReservationByClientId(ClientId As String) As DataTable
        Try
            If Me.CheckClientExists(ClientId) Then
                Dim dt As DataTable
                dt = daoReservation.GetAllReservationByClientId(ClientId)
                Return dt
            Else
                Throw New Exception("El cliente introducido no existe")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que devuelve la temporada de la reserva
    ''' </summary>
    ''' <param name="EntryDate">fecha de entrada en la reserva</param>
    ''' <returns>tipo de temporada</returns>
    Public Function GetReservationSeasson(EntryDate As Date) As String
        If EntryDate.Month >= 6 And EntryDate.Month <= 8 Then
            Return "alta"
        End If
        If (EntryDate.Month >= 1 And EntryDate.Month <= 3) Or (EntryDate.Month >= 11 And EntryDate.Month <= 12) Then
            Return "baja"
        End If
        Return "media"
    End Function

    ''' <summary>
    ''' Metodo que comprueba si existe una reserva dada una ID de reserva
    ''' </summary>
    ''' <param name="ReservationId">ID de la reserva</param>
    ''' <returns>booleano con la respuesta</returns>
    Public Function CheckReservationExists(ReservationId As UInteger) As Boolean
        Try
            Return daoReservation.ReservationExists(ReservationId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que comprueba si existe un cliente
    ''' </summary>
    ''' <param name="ClientId">ID de cliente</param>
    ''' <returns>booleano con la respuesta</returns>
    Private Function CheckClientExists(ClientId As String) As Boolean
        Try
            Return daoClient.ClientExists(ClientId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que genera una factura para una reserva concreta
    ''' </summary>
    ''' <param name="Reservation">objeto reserva</param>
    Private Sub GenerateInvoice(Reservation As Reservation)
        Try
            Dim invoice As Invoice = daoInvoice.GetInvoiceByReservationId(Reservation.ReservationIdProp)
            'Abrimos la pantalla que muestra los datos de la factura con la información precargada
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoUser y accede al metodo de comprobar las credenciales para el login
    ''' </summary>
    ''' <param name="UserId">cadena con el nombre de usuario</param>
    ''' <param name="Password">cadena con la contraseña de usuario</param>
    ''' <returns>devuelve booleano con resultado del login</returns>
    Public Function UserLogin(UserId As String, Password As String) As Boolean
        Try
            Return daoUser.UserLogin(UserId, Password)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Reservation"></param>
    ''' <param name="InvoiceId"></param>
    ''' <returns></returns>
    Public Function GetTotalInvoice(Reservation As Reservation, InvoiceId As UInteger) As UInteger
        Try
            Dim servicesList As DataTable = daoService.GetConsumedServices(InvoiceId)
            Dim totalCount As UInteger = 0
            Dim room As Room = daoRoom.GetRoomById(Reservation.RoomIdProp)
            Select Case Reservation.SeasonProp
                Case "baja"
                    totalCount = totalCount + CUInt(room.PriceLProp)
                Case "media"
                    totalCount = totalCount + CUInt(room.PriceMProp)
                Case "alta"
                    totalCount = totalCount + CUInt(room.PriceHProp)
            End Select
            Select Case Reservation.BoardProp
                Case "Sin régimen"
                    totalCount = totalCount * 1
                Case "Media pensión"
                    totalCount = totalCount * 1.25
                Case "Pensión completa"
                    totalCount = totalCount * 1.5
            End Select
            totalCount = totalCount * CInt(DateDiff("d", Reservation.EntryDateProp, Reservation.DepartureDateProp))
            For index = 0 To servicesList.Rows.Count() - 1
                Dim serviceId As UInteger = CUInt(servicesList.AsEnumerable().ElementAt(index).Item(0))
                totalCount = totalCount + daoService.GetServicePrice(serviceId) * servicesList.AsEnumerable().ElementAt(index).Item(3)
            Next
            Return totalCount
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ReservationId"></param>
    ''' <returns></returns>
    Public Function GetConsumedServices(ReservationId As UInteger) As DataTable
        Try
            Dim invoice As Invoice = daoInvoice.GetInvoiceByReservationId(ReservationId)
            Dim dt As DataTable = daoService.GetConsumedServices(invoice.InvoiceIdProp)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene los listados 
    ''' </summary>
    ''' <param name="InitialDate"></param>
    ''' <param name="FinalDate"></param>
    ''' <param name="Type"></param>
    ''' <returns></returns>
    Public Function GetReservationListsByDate(InitialDate As Date, FinalDate As Date, Type As String) As DataTable
        Try
            Dim dataSource As DataTable = daoReservation.GetReservationList()
            Dim dt As New DataTable
            dt.Merge(dataSource)
            Dim removedRows As Integer = 0
            Select Case Type
                Case "reservation"
                    For index = 0 To dataSource.Rows.Count() - 1
                        Dim entryDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(3))
                        Dim departureDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(4))
                        If (Not ((entryDate.Date.CompareTo(InitialDate) >= 0) And (entryDate.Date.CompareTo(FinalDate) <= 0) And (departureDate.Date.CompareTo(InitialDate) >= 0) And (departureDate.Date.CompareTo(FinalDate) <= 0))) Then
                            dt.Rows.RemoveAt(index - removedRows)
                            removedRows = removedRows + 1
                        End If
                    Next
                    Return dt
                Case "entry"
                    For index = 0 To dataSource.Rows.Count() - 1
                        Dim entryDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(3))
                        Dim departureDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(4))
                        If (Not ((entryDate.Date.CompareTo(InitialDate) >= 0) And (entryDate.Date.CompareTo(FinalDate) <= 0))) Then
                            dt.Rows.RemoveAt(index - removedRows)
                            removedRows = removedRows + 1
                        End If
                    Next
                    Return dt
                Case "departure"
                    For index = 0 To dataSource.Rows.Count() - 1
                        Dim entryDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(3))
                        Dim departureDate As Date = CDate(dataSource.AsEnumerable().ElementAt(index).Item(4))
                        If (Not ((departureDate.Date.CompareTo(InitialDate) >= 0) And (departureDate.Date.CompareTo(FinalDate) <= 0))) Then
                            dt.Rows.RemoveAt(index - removedRows)
                            removedRows = removedRows + 1
                        End If
                    Next
                    Return dt
            End Select
            Throw New Exception("No se ha podido comparar correctamente")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ClientId"></param>
    ''' <returns></returns>
    Public Function GetReservationByClient(ClientId As String) As DataTable
        Try
            If (daoClient.ClientExists(ClientId)) Then
                Return daoReservation.GetAllReservationByClientId(ClientId)
            Else
                Throw New Exception("El cliente introducido no existe")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetActiveReservations() As DataTable
        Try
            Dim dt As DataTable = daoReservation.GetActiveReservationList()
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
