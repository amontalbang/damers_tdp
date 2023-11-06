'Esta clase contiene los atributos y metodos de la clase Reserva
'@author DAMERs TPD

Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Reservation
    Private reservationId As UInteger
    Private roomId As UInteger
    Private clientId As String
    Private entryDate As Date
    Private depatureDate As Date
    Private season As String
    Private board As String
    Private status As Boolean

    'Metodo constructor por defecto
    Public Sub New()
    End Sub

    'Metodos constructores parametrizados
    '@param reservationId - Numero de reserva
    '@param roomId - Numero de habitacion
    '@param clientId - ID del cliente (DNI)
    '@param entryDate - Fecha de entrada
    '@param depatureDate - Fecha de salida
    '@param season - Temporada de la reserva
    '@param board - Tipo de alojamiento
    '@param status - Estado de la reserva
    Public Sub New(reservationId As UInteger, roomId As UInteger, clientId As String, entryDate As Date, depatureDate As Date, season As String, board As String, status As Boolean)
        Me.reservationId = reservationId
        Me.roomId = roomId
        Me.clientId = clientId
        Me.entryDate = entryDate
        Me.depatureDate = depatureDate
        Me.season = season
        Me.board = board
        Me.status = status
    End Sub

    '*propiedades de reservationId
    Public Property ReservationIdProp() As UInteger
        'obtener el numero de habitacion
        Get
            Return reservationId
        End Get
        'asignar el numero de habitacion
        Set(ByVal Value As UInteger)
            reservationId = Value
        End Set
    End Property

    'propiedades de roomId
    Public Property RoomIdProp() As UInteger
        'obtener el tipo de habitacion
        Get
            Return roomId
        End Get
        'asignar el tipo de habitacion
        Set(ByVal Value As UInteger)
            roomId = Value
        End Set
    End Property

    'propiedades de clientId
    Public Property ClientIdProp() As String
        'obtener el tipo de habitacion
        Get
            Return clientId
        End Get
        'asignar el tipo de habitacion
        Set(ByVal Value As String)
            clientId = Value
        End Set
    End Property

    'propiedades de entryDate
    Public Property EntryDateProp() As Date
        'obtener la capacidad de huespedes para una habitacion
        Get
            Return entryDate
        End Get
        'asignar la capacidad de huespedes para una habitacion
        Set(ByVal Value As Date)
            entryDate = Value
        End Set
    End Property

    'propiedades de depatureDate
    Public Property DepartureDateProp() As Date
        'obtener el precio en temporada alta
        Get
            Return depatureDate
        End Get
        'asignar el precio en temporada alta
        Set(ByVal Value As Date)
            depatureDate = Value
        End Set
    End Property

    'propiedades de season
    Public Property SeasonProp() As String
        'obtener el precio en temporada media
        Get
            Return season
        End Get
        'asignar el precio en temporada media
        Set(ByVal Value As String)
            season = Value
        End Set
    End Property

    'propiedades de board
    Public Property BoardProp() As String
        'obtener el precio en temporada baja
        Get
            Return board
        End Get
        'asignar el precio en temporada baja
        Set(ByVal Value As String)
            board = Value
        End Set
    End Property

    'propiedades de status
    Public Property StatusProp() As Boolean
        'obtener el precio en temporada baja
        Get
            Return status
        End Get
        'asignar el precio en temporada baja
        Set(ByVal Value As Boolean)
            status = Value
        End Set
    End Property
End Class
