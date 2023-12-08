''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Factura
''' </summary>
Public Class Invoice

    'Definicion de atributos
    Private InvoiceId As UInteger
    Private reservationId As UInteger
    Private consumedServices As Array
    Private totalAmount As Double
    Private days As UInteger
    Private pricePerDay As Double

    ''' <summary>
	''' Metodo constructor vacio para Factura
	''' </summary>
    Public Sub New()
        Me.totalAmount = 0
    End Sub

    ''' <summary>
    ''' Metodo constructor del objeto
    ''' </summary>
    ''' <param name="InvoiceId">Numero de factura</param>
    ''' <param name="ReservationId">Numero de reserva</param>
    ''' <param name="TotalAmount">Precio total</param>
    Public Sub New(InvoiceId As UInteger, ReservationId As UInteger, TotalAmount As Double)
        Me.InvoiceId = InvoiceId
        Me.reservationId = ReservationId
        Me.totalAmount = TotalAmount
    End Sub

    'Metodos constructores parametrizados
    '@param reservationId - Numero de reserva
    '@param totalAmount - Precio total de la factura
    Public Sub New(reservationId As UInteger)
        Me.reservationId = reservationId
        Me.totalAmount = 0
    End Sub

    '*propiedades de invoice
    Public Property InvoiceIdProp() As UInteger
        Get
            Return InvoiceId
        End Get
        Set(ByVal Value As UInteger)
            InvoiceId = Value
        End Set
    End Property

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
    ''' Propiedad con get/set para precio total
    ''' </summary>
    ''' <returns>doble con el precio total</returns>
    Public Property TotalAmountProp() As Double
        Get
            Return totalAmount
        End Get
        Set(ByVal Value As Double)
            totalAmount = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para los servicios consumidos
    ''' </summary>
    ''' <returns>array con los servicios consumidos</returns>
    Public Property ConsumedServicesProp() As Array
        Get
            Return consumedServices
        End Get
        Set(ByVal Value As Array)
            consumedServices = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad con get/set para los dias de estancia
    ''' </summary>
    ''' <returns>Dias de estancia en la habitacion</returns>
    Public Property DaysProp() As UInteger
        Get
            Return days
        End Get
        Set(ByVal Value As UInteger)
            days = Value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad get/set para el precio por noche
    ''' </summary>
    ''' <returns>Precio por noche de la habitacion</returns>
    Public Property PricePerDayProp() As Double
        Get
            Return pricePerDay
        End Get
        Set(ByVal Value As Double)
            pricePerDay = Value
        End Set
    End Property

End Class
