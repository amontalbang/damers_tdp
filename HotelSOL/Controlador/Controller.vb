Public Class Controller

    Private daoClient As DaoClient
    Private daoRoom As DAORoom
    Private daoService As DaoService

    Public Sub New()
        Dim daoFactory As DaoFactory = New DaoFactory()
        daoClient = daoFactory.GetDaoClient()
        daoRoom = daoFactory.GetDaoRoom()
        daoService = daoFactory.GetDaoService()
    End Sub

    Public Sub addClient(Client As Client)
        daoClient.AddClient(Client)
    End Sub

    Public Sub updateClient(Client As Client)
        daoClient.UpdateClient(Client)
    End Sub

    Public Sub deleteClient(Client As Client)
        daoClient.DeleteClient(Client)
    End Sub

    Public Function checkClient(Client As Client)
        daoClient.CheckClient(Client)
    End Function

    Public Sub addRoom(Room As Room)
        daoRoom.AddRoom(Room)
    End Sub

    Public Sub deleteRoom(Room As Room)
        daoRoom.DeleteRoom(Room)
    End Sub

    Public Sub updateRoom(Room As Room)
        daoRoom.UpdateRoom(Room)
    End Sub

    Public Function checkRoom(Room As Room)
        daoRoom.CheckRoom(Room)
    End Function

    Public Sub addService(Service As Service)
        daoService.AddService(Service)
    End Sub

    Public Sub deleteService(Service As Service)
        daoService.DeleteService(Service)
    End Sub

    Public Sub updateService(Service As Service)
        daoService.UpdateService(Service)
    End Sub

    Public Function checkService(Service As Service)
        daoService.CheckService(Service)
    End Function

End Class
