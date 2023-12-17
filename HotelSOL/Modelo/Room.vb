''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Habitacion
''' </summary>

Public Class Room

    'Atributos de la clase Habitacion
    Private roomId As String
    Private type As String
    Private capacity As String
    Private priceH As UInteger
    Private priceM As UInteger
    Private priceL As UInteger

    ''' <summary>
	''' Metodo constructor vacio para Habitacion
	''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Metodo constructor con numero de habitacion
    ''' </summary>
    ''' <param name="RoomId">numero de habitacion</param>
    Public Sub New(RoomId As String)
        Me.roomId = RoomId
    End Sub

    ''' <summary>
    ''' Metodo constructor con los atributos del objeto
    ''' </summary>
    ''' <param name="RoomId">numero de habitacion</param>
    ''' <param name="Type">tipo de habitacion</param>
    ''' <param name="Capacity">capacidad de huespedes</param>
    ''' <param name="PriceH">precio temporada alta</param>
    ''' <param name="PriceM">precio temporada media</param>
    ''' <param name="PriceL">precio temporada baja</param>
    Public Sub New(RoomId As String, Type As String, Capacity As String, PriceH As UInteger, PriceM As UInteger, PriceL As UInteger)
        Me.roomId = RoomId
        Me.type = Type
        Me.capacity = Capacity
        Me.priceH = PriceH
        Me.priceM = PriceM
        Me.priceL = PriceL
    End Sub

    ''' <summary>
    ''' Propiedad con get/set para numero de habitacion
    ''' </summary>
    ''' <returns>cadena con numero de habitacion</returns>
    Public Property RoomIdProp() As String
        Get
            Return roomId
        End Get
        Set(ByVal Value As String)
            roomId = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para tipo de habitacion
    ''' </summary>
    ''' <returns>cadena con tipo de habitacion</returns>
    Public Property TypeProp() As String
        Get
            Return type
        End Get
        Set(ByVal Value As String)
            type = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para capacidad de habitacion
    ''' </summary>
    ''' <returns>cadena con capacidad de habitacion</returns>
    Public Property CapacityProp() As String
        Get
            Return capacity
        End Get
        Set(ByVal Value As String)
            capacity = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para precio en temporada alta
    ''' </summary>
    ''' <returns>entero con el precio de la habitacion</returns>
    Public Property PriceHProp() As UInteger
        Get
            Return priceH
        End Get
        Set(ByVal Value As UInteger)
            priceH = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para precio en temporada media
    ''' </summary>
    ''' <returns>entero con el precio de la habitacion</returns>
    Public Property PriceMProp() As UInteger
        Get
            Return priceM
        End Get
        Set(ByVal Value As UInteger)
            priceM = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para precio en temporada baja
    ''' </summary>
    ''' <returns>entero con el precio de la habitacion</returns>
    Public Property PriceLProp() As UInteger
        Get
            Return priceL
        End Get
        Set(ByVal Value As UInteger)
            priceL = Value
        End Set
    End Property

End Class