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
    Private status As Boolean

    ''' <summary>
	''' Metodo constructor vacio para Reserva
	''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    '''  Metodo constructor con todos los atributos del objeto
    ''' </summary>
    ''' <param name="ReservationId">Numero de reserva</param>
    ''' <param name="RoomId">Numero de habitacion</param>
    ''' <param name="ClientId">Id del cliente</param>
    ''' <param name="EntryDate">Fecha de entrada</param>
    ''' <param name="DepatureDate">Fecha de salida</param>
    ''' <param name="Season">Temporada</param>
    ''' <param name="Board">Regimen</param>
    ''' <param name="Status">Estado de la reseva</param>
    Public Sub New(ReservationId As UInteger, RoomId As UInteger, ClientId As String, EntryDate As Date, DepatureDate As Date, Season As String, Board As String, Status As Boolean)
        Me.reservationId = ReservationId
        Me.roomId = RoomId
        Me.clientId = ClientId
        Me.entryDate = EntryDate
        Me.depatureDate = DepatureDate
        Me.season = Season
        Me.board = Board
        Me.status = Status
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

    ''' <summary>
    ''' Propiedad con get/set para estado de la reserva
    ''' </summary>
    ''' <returns>booleano estado de la reserva</returns>
    Public Property StatusProp() As Boolean
        Get
            Return status
        End Get
        Set(ByVal Value As Boolean)
            status = Value
        End Set
    End Property
End Class
