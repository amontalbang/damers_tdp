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
    ''' Metodo que instancia on objeto daoClient y accede al metodo de añadir cliente
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub AddClient(Client As Client)
        daoClient.AddClient(Client)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoClient y accede al metodo de modificar cliente
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub UpdateClient(Client As Client)
        daoClient.UpdateClient(Client)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoClient y accede al metodo de eliminar cliente
    ''' </summary>
    ''' <param name="Client">objeto cliente</param>
    Public Sub DeleteClient(Client As Client)
        daoClient.DeleteClient(Client)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoClient y accede al metodo de recuperar un cliente
    ''' </summary>
    ''' <param name="Client">cadena con Id del cliente</param>
    ''' <returns>devuelve el cliente solicitado</returns>
    Public Function GetClientById(Client As String)
        Return daoClient.GetClientById(Client)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoClient y accede al metodo comprobar si existe un cliente
    ''' </summary>
    ''' <param name="Client">cadena con Id del cliente</param>
    ''' <returns>devuelve booleano con la existencia del cliente</returns>
    Public Function ClientExists(Client As String) As Boolean
        Return daoClient.ClientExists(Client)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoClient y accede al metodo de recuperar todos los clientes
    ''' </summary>
    ''' <returns>devuelve la lista de clientes</returns>
    Public Function GetClientList()
        Return daoClient.GetClientList()
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo de añadir habitacion
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub AddRoom(Room As Room)
        daoRoom.AddRoom(Room)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo de eliminar habitacion
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub DeleteRoom(Room As Room)
        daoRoom.DeleteRoom(Room)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo de modificar habitacion
    ''' </summary>
    ''' <param name="Room">objeto habitacion</param>
    Public Sub UpdateRoom(Room As Room)
        daoRoom.UpdateRoom(Room)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo de recuperar una habitacion
    ''' </summary>
    ''' <param name="Room">cadena con el numero de habitacion</param>
    ''' <returns>devuelve la habitacion solicitada</returns>
    Public Function GetRoomById(Room As String)
        Return daoRoom.GetRoomById(Room)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo comprobar si existe una habitacion
    ''' </summary>
    ''' <param name="Room">cadena con el numero de habitacion</param>
    ''' <returns>booleano con la existencia de la habitacion</returns>
    Public Function RoomExists(Room As String) As Boolean
        Return daoRoom.RoomExists(Room)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoRoom y accede al metodo de recuperar todos las habitaciones
    ''' </summary>
    ''' <returns>devuelve datatable con lista de habitaciones</returns>
    Public Function GetRoomList()
        Return daoRoom.GetRoomList()
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo de añadir servicio
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub AddService(Service As Service)
        daoService.AddService(Service)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo de eliminar servicio
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub DeleteService(Service As Service)
        daoService.DeleteService(Service)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo de modificar servicio
    ''' </summary>
    ''' <param name="Service">objeto servicio</param>
    Public Sub UpdateService(Service As Service)
        daoService.UpdateService(Service)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo de recuperar un servicio
    ''' </summary>
    ''' <param name="Service">entero con el Id del servicio</param>
    ''' <returns>devuelve el objeto servicio solicitado</returns>
    Public Function GetServiceById(Service As UInteger)
        Return daoService.GetServiceById(Service)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo comprobar si existe un servicio
    ''' </summary>
    ''' <param name="Service">entero con el Id del servicio</param>
    ''' <returns>booleano con la existencia del servicio</returns>
    Public Function ServiceExists(Service As UInteger) As Boolean
        Return daoService.ServiceExists(Service)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoService y accede al metodo de recuperar todos los servicios
    ''' </summary>
    ''' <returns>devuelve lista con todos los servicios</returns>
    Public Function GetServiceList()
        Return daoService.GetServiceList()
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoUser y accede al metodo de añadir usuario
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub AddUser(User As User)
        daoUser.AddUser(User)
    End Sub

    ''' <summary>
    '''  Metodo que instancia on objeto daoUser y accede al metodo de eliminar usuario
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub DeleteUser(User As User)
        daoUser.DeleteUser(User)
    End Sub

    ''' <summary>
    '''  Metodo que instancia on objeto daoUser y accede al metodo de modificar usuario
    ''' </summary>
    ''' <param name="User">objeto usuario</param>
    Public Sub UpdateUser(User As User)
        daoUser.UpdateUser(User)
    End Sub

    ''' <summary>
    ''' Metodo que instancia on objeto daoUser y accede al metodo comprobar si existe un usuario
    ''' </summary>
    ''' <param name="User">cadena con el Id de usuario</param>
    ''' <returns>booleano con la existencia del usuario consultado</returns>
    Public Function UserExists(User As String) As Boolean
        Return daoUser.UserExists(User)
    End Function

    ''' <summary>
    ''' Metodo que instancia on objeto daoUser y accede al metodo de recuperar todos los usuarios
    ''' </summary>
    ''' <returns>devuelve lista con todos los usuarios</returns>
    Public Function GetUserList()
        Return daoUser.GetUserList()
    End Function

    Public Sub AddReservation(Reservation As Reservation)
        Try
            Dim seasson As String = GetReservationSeasson(Reservation.EntryDateProp)
            Reservation.SeasonProp = seasson
            daoReservation.AddReservation(Reservation)
            Dim invoice As Invoice = New Invoice(Reservation.ReservationIdProp)
            daoInvoice.AddInvoice(invoice)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateReservation(Reservation As Reservation)
        Try
            daoReservation.UpdateReservation(Reservation)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub PayReservation(ReservationId As UInteger)

    End Sub

    Public Sub RemoveReservation(ReservationId As UInteger)
        Try
            daoReservation.RemoveReservation(ReservationId)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CheckIn(ReservationId As UInteger)
        'Cambiar la vista del checkin para que sea el listado de reservas con entrada para la fecha actual o
        'un botón de checkin sin reserva
        Try
            If Me.CheckReservationExists(ReservationId) Then
                Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
                reservation.isActiveProp = True
                daoReservation.UpdateReservation(reservation)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CheckOut(ReservationId As UInteger)
        Try
            Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
            reservation.isActiveProp = False
            daoReservation.UpdateReservation(reservation)
            Me.GenerateInvoice(reservation)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetReservationById(ReservationId As UInteger) As DataTable
        If Me.CheckReservationExists(ReservationId) Then
            Dim dt As DataTable = New DataTable
            Dim reservation As Reservation = daoReservation.GetReservationById(ReservationId)
            'Rellenamos la tabla
            Return dt
        Else
            Return New DataTable
        End If
    End Function

    Public Function GetReservationsList() As DataTable
        Try
            Return daoReservation.GetReservationList()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetReservationByClientId(ClientId As String) As DataTable
        Try
            If Me.CheckClientExists(ClientId) Then
                Dim dt As DataTable
                dt = daoReservation.GetReservationByClientId(ClientId)
                Return dt
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GetReservationSeasson(EntryDate As Date) As String
        If EntryDate.Month >= 6 And EntryDate.Month <= 8 Then
            Return "alta"
        End If
        If (EntryDate.Month >= 1 And EntryDate.Month <= 3) Or (EntryDate.Month >= 11 And EntryDate.Month <= 12) Then
            Return "baja"
        End If
        Return "media"
    End Function

    Private Function CheckReservationExists(ReservationId As UInteger) As Boolean
        Try
            Return daoReservation.ReservationExists(ReservationId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CheckClientExists(ClientId As String) As Boolean
        Try
            Return daoClient.ClientExists(ClientId)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GenerateInvoice(Reservation As Reservation)
        Try
            Dim invoice As Invoice = daoInvoice.GetInvoiceByReservationId(Reservation.ReservationIdProp)
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
        Return daoUser.UserLogin(UserId, Password)
    End Function
End Class
