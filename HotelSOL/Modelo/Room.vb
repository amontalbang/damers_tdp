'Esta clase contiene los atributos y metodos de la clase Habitacion
'@author DAMERs TPD

Public Class Room

    Private roomId As String
    Private type As String
    Private capacity As String
    Private priceH As UInteger
    Private priceM As UInteger
    Private priceL As UInteger

    'Metodo constructor por defecto
    Public Sub New()
    End Sub

    'Metodos constructores parametrizados
    '@param roomId - Numero de habitacion
    '@param type - Tipo de habitacion
    '@param capacity - Capacidad de la habitacion
    '@param price - Precio dependiendo de la temporada

    Public Sub New(roomId As String)
        Me.roomId = roomId
    End Sub

    Public Sub New(roomId As String, type As String, capacity As String, priceH As UInteger, priceM As UInteger, priceL As UInteger)
        Me.roomId = roomId
        Me.type = type
        Me.capacity = capacity
        Me.priceH = priceH
        Me.priceM = priceM
        Me.priceL = priceL
    End Sub

    '*propiedades de roomId
    Public Property RoomIdProp() As String
        'obtener el numero de habitacion
        Get
            Return roomId
        End Get
        'asignar el numero de habitacion
        Set(ByVal Value As String)
            roomId = Value
        End Set
    End Property

    'propiedades de type
    Public Property TypeProp() As String
        'obtener el tipo de habitacion
        Get
            Return type
        End Get
        'asignar el tipo de habitacion
        Set(ByVal Value As String)
            type = Value
        End Set
    End Property

    'propiedades de capacity
    Public Property CapacityProp() As String
        'obtener la capacidad de huespedes para una habitacion
        Get
            Return capacity
        End Get
        'asignar la capacidad de huespedes para una habitacion
        Set(ByVal Value As String)
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