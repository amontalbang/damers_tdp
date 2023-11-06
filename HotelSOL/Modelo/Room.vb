'Esta clase contiene los atributos y metodos de la clase Habitacion
'@author DAMERs TPD

Public Class Room

    Private roomId As UInteger
    Private type As String
    Private capacity As UInteger
    Private priceH As Double
    Private priceM As Double
    Private priceL As Double

    'Metodo constructor por defecto
    Public Sub New()
    End Sub

    'Metodos constructores parametrizados
    '@param roomId - Numero de habitacion
    '@param type - Tipo de habitacion
    '@param capacity - Capacidad de la habitacion
    '@param price - Precio dependiendo de la temporada
    Public Sub New(roomId As UInteger, type As String, capacity As UInteger, price As Double)
        Me.roomId = roomId
        Me.type = type
        Me.capacity = capacity
    End Sub

    '*propiedades de roomId
    Public Property RoomIdProp() As UInteger
        'obtener el numero de habitacion
        Get
            Return roomId
        End Get
        'asignar el numero de habitacion
        Set(ByVal Value As UInteger)
            roomId = Value
        End Set
    End Property

    'propiedades de type
    Public Property TypeProp() As UInteger
        'obtener el tipo de habitacion
        Get
            Return type
        End Get
        'asignar el tipo de habitacion
        Set(ByVal Value As UInteger)
            type = Value
        End Set
    End Property

    'propiedades de capacity
    Public Property CapacityProp() As UInteger
        'obtener la capacidad de huespedes para una habitacion
        Get
            Return capacity
        End Get
        'asignar la capacidad de huespedes para una habitacion
        Set(ByVal Value As UInteger)
            capacity = Value
        End Set
    End Property

    'propiedades de priceH
    Public Property PriceHProp() As UInteger
        'obtener el precio en temporada alta
        Get
            Return priceH
        End Get
        'asignar el precio en temporada alta
        Set(ByVal Value As UInteger)
            priceH = Value
        End Set
    End Property

    'propiedades de priceM
    Public Property PriceMProp() As UInteger
        'obtener el precio en temporada media
        Get
            Return priceM
        End Get
        'asignar el precio en temporada media
        Set(ByVal Value As UInteger)
            priceM = Value
        End Set
    End Property

    'propiedades de priceL
    Public Property PriceLProp() As UInteger
        'obtener el precio en temporada baja
        Get
            Return priceL
        End Get
        'asignar el precio en temporada baja
        Set(ByVal Value As UInteger)
            priceL = Value
        End Set
    End Property

End Class