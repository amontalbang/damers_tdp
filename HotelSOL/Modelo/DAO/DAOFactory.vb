''' <summary>
''' Clase que implementa el patron Factory Method y permiten creao objetos modificables de las distintas clases
''' en nesta superclase
''' </summary>
Public Class DaoFactory

    ''' <summary>
    ''' Metodo constructor de la clase
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Metodo para crear objeto DaoUser
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoUser</returns>
    Public Function GetDaoUser() As DaoUser
        Return New DaoUser()
    End Function

    ''' <summary>
    ''' Metodo para crear objeto DaoClient
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoClient</returns>
    Public Function GetDaoClient() As DaoClient
        Return New DaoClient()
    End Function

    ''' <summary>
    ''' Metodo para crear objeto DaoService
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoService</returns>
    Public Function GetDaoService() As DaoService
        Return New DaoService()
    End Function

    ''' <summary>
    ''' Metodo para crear objeto DaoInvoice
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoInvoice</returns>
    Public Function GetDaoInvoice() As DAOInvoice
        Return New DAOInvoice()
    End Function

    ''' <summary>
    ''' Metodo para crear objeto DaoRoom
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoRoom</returns>
    Public Function GetDaoRoom() As DAORoom
        Return New DAORoom()
    End Function

    ''' <summary>
    ''' Metodo para crear objeto DaoReservation
    ''' </summary>
    ''' <returns>Devuelve un nuevo DaoReservation</returns>
    Public Function GetDaoReservation() As DAOReservation
        Return New DAOReservation()
    End Function
End Class