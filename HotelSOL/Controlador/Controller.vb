Public Class Controller

    Private daoClient As DaoClient
    Private daoRoom As DAORoom
    Private daoService As DaoService
    Private daoReservation As DAOReservation
    Private daoInvoice As DAOInvoice
    Private reservationCheckout As Form18

    Public Sub New()
        Dim daoFactory As DaoFactory = New DaoFactory()
        daoClient = daoFactory.GetDaoClient()
        daoRoom = daoFactory.GetDaoRoom()
        daoService = daoFactory.GetDaoService()
        daoReservation = daoFactory.GetDaoReservation()
        daoInvoice = daoFactory.GetDaoInvoice()
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

End Class
