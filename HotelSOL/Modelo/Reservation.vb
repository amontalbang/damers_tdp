''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Reserva
''' </summary>

Public Class Reservation

    'Definicion de atributos
    Private reservationId As UInteger
    Private roomId As UInteger
    Private clientId As String
    Private entryDate As Date
    Private depatureDate As Date
    Private season As String
    Private board As String
    Private isActive As Boolean

    ''' <summary>
	''' Metodo constructor vacio para Reserva
	''' </summary>
    Public Sub New()
    End Sub

    Public Sub New(reservationId As UInteger)
        Me.reservationId = reservationId
    End Sub

    'Metodos constructores parametrizados
    '@param roomId - Numero de habitacion
    '@param clientId - ID del cliente (DNI)
    '@param entryDate - Fecha de entrada
    '@param depatureDate - Fecha de salida
    '@param board - Tipo de alojamiento
    '@param isActive - Estado de la reserva
    Public Sub New(roomId As UInteger, clientId As String, entryDate As Date, depatureDate As Date, board As String, isActive As Boolean)
        Me.roomId = roomId
        Me.clientId = clientId
        Me.entryDate = entryDate
        Me.depatureDate = depatureDate
        Me.board = board
        Me.isActive = isActive
    End Sub

    'Metodos constructores parametrizados
    '@param reservationId - Numero de reserva
    '@param roomId - Numero de habitacion
    '@param clientId - ID del cliente (DNI)
    '@param entryDate - Fecha de entrada
    '@param depatureDate - Fecha de salida
    '@param season - Temporada de la reserva
    '@param board - Tipo de alojamiento
    '@param isActive - Estado de la reserva
    Public Sub New(reservationId As UInteger, roomId As UInteger, clientId As String, entryDate As Date, depatureDate As Date, season As String, board As String, isActive As Boolean)
        Me.reservationId = reservationId
        Me.roomId = roomId
        Me.clientId = clientId
        Me.entryDate = entryDate
        Me.depatureDate = depatureDate
        Me.season = season
        Me.board = board
        Me.isActive = isActive
    End Sub

    ''' <summary>
    ''' Propiedad con get/set para numero de reserva
    ''' </summary>
    ''' <returns>entero con el numero de reserva</returns>
    Public Property ReservationIdProp() As UInteger
        Get
            Return reservationId
        End Get
        Set(ByVal Value As UInteger)
            reservationId = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para numero de habitacion
    ''' </summary>
    ''' <returns>entero con el numero de habitacion</returns>
    Public Property RoomIdProp() As UInteger
        Get
            Return roomId
        End Get
        Set(ByVal Value As UInteger)
            roomId = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para Id de cliente
    ''' </summary>
    ''' <returns>cadena con el Id de cliente</returns>
    Public Property ClientIdProp() As String
        Get
            Return clientId
        End Get
        Set(ByVal Value As String)
            clientId = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para fecha de entrada
    ''' </summary>
    ''' <returns>fecha de entrada</returns>
    Public Property EntryDateProp() As Date
        Get
            Return entryDate
        End Get
        Set(ByVal Value As Date)
            entryDate = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para fecha de salida
    ''' </summary>
    ''' <returns>fecha de salida</returns>
    Public Property DepartureDateProp() As Date
        Get
            Return depatureDate
        End Get
        Set(ByVal Value As Date)
            depatureDate = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para temporada
    ''' </summary>
    ''' <returns>cadena indicando la temporada</returns>
    Public Property SeasonProp() As String
        Get
            Return season
        End Get
        Set(ByVal Value As String)
            season = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para regimen
    ''' </summary>
    ''' <returns>cadena indicando el regimen</returns>
    Public Property BoardProp() As String
        Get
            Return board
        End Get
        Set(ByVal Value As String)
            board = Value
        End Set
    End Property

    'propiedades de isActive
    Public Property isActiveProp() As Boolean
        'obtener el precio en temporada baja
        Get
            Return isActive
        End Get
        Set(ByVal Value As Boolean)
            isActive = Value
        End Set
    End Property
End Class
