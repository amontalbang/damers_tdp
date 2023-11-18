'Esta clase contiene los atributos y metodos de la clase Factura
'@author DAMERs TPD

Public Class Invoice

    Private InvoiceId As UInteger
    Private reservationId As UInteger
    Private consumedServices As Array
    Private totalAmount As Double

    'Metodo constructor por defecto
    Public Sub New()
        Me.totalAmount = 0
    End Sub

    'Metodos constructores parametrizados
    '@param invoice - Numero de factura
    '@param reservationId - Numero de reserva
    '@param totalAmount - Precio total de la factura
    Public Sub New(InvoiceId As UInteger, reservationId As UInteger, totalAmount As Double)
        Me.InvoiceId = InvoiceId
        Me.reservationId = reservationId
        Me.totalAmount = totalAmount
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
        'obtener el numero factura
        Get
            Return InvoiceId
        End Get
        'asignar el numero factura
        Set(ByVal Value As UInteger)
            InvoiceId = Value
        End Set
    End Property

    'propiedades de reservationId
    Public Property ReservationIdProp() As UInteger
        'obtener el numero de reserva
        Get
            Return reservationId
        End Get
        'asignar el numero de reserva
        Set(ByVal Value As UInteger)
            reservationId = Value
        End Set
    End Property

    'propiedades de capacity
    Public Property TotalAmountProp() As Double
        'obtener el precio total de la factura
        Get
            Return totalAmount
        End Get
        'asignar el precio total de la factura
        Set(ByVal Value As Double)
            totalAmount = Value
        End Set
    End Property

    'propiedades de priceH
    Public Property ConsumedServicesProp() As Array
        'obtener el precio en temporada alta
        Get
            Return consumedServices
        End Get
        'asignar el precio en temporada alta
        Set(ByVal Value As Array)
            consumedServices = Value
        End Set
    End Property
End Class
