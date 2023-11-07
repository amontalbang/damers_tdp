Imports HotelSOL.DaoClient
Imports HotelSOL.DaoService
Imports HotelSOL.DaoUser

Public Class DaoFactory
    Public Sub New()
    End Sub
    Public Function GetDaoUser() As DaoUser
        Return New DaoUser()
    End Function

    Public Function GetDaoClient() As DaoClient
        Return New DaoClient()
    End Function

    Public Function GetDaoService() As DaoService
        Return New DaoService()
    End Function
End Class