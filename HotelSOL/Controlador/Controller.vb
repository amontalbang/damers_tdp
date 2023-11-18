''' <summary>
''' Clase Controlador que enlaza las vistas y el modelo
''' </summary>
Public Class Controller

    Private daoClient As DaoClient
    Private daoRoom As DAORoom
    Private daoService As DaoService
    Private daoUser As DaoUser

    ''' <summary>
    ''' Metodo constructor de la clase
    ''' </summary>
    Public Sub New()
        Dim daoFactory As DaoFactory = New DaoFactory()
        daoClient = daoFactory.GetDaoClient()
        daoRoom = daoFactory.GetDaoRoom()
        daoService = daoFactory.GetDaoService()
        daoUser = daoFactory.GetDaoUser()
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
