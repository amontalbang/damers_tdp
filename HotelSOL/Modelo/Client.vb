''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Cliente
''' </summary>
Public Class Client

	'Definicion de atributos
	Private name As String
	Private surname As String
	Private numberId As String
	Private birthDate As Date
	Private phoneNumber As String
	Private email As String
	Private address As String
	Private creditCard As String
	Private discountAvailable As UInteger
	Private activeReservation As Boolean


	''' <summary>
	''' Metodo constructor con todos los atributos del objeto
	''' </summary>
	''' <param name="NumberId">DNI del cliente</param>
	''' <param name="Name">Nombre del cliente</param>
	''' <param name="Surname">Apellidos del cliente</param>
	''' <param name="BirthDate">Fecha de nacimiento del cliente</param>
	''' <param name="PhoneNumber">Telefono del cliente</param>
	''' <param name="Email">Email del cliente</param>
	''' <param name="Address">Direccion del cliente</param>
	''' <param name="CreditCard">Numero de la tarjeta de credito del cliente</param>
	''' <param name="Discount">Descuento aplicable al cliente</param>
	''' <param name="ActiveReservation">Booleano que indica si el cliente esta hospedado en el momento de la consulta</param>
	Public Sub New(NumberId As String, Name As String, Surname As String, BirthDate As Date, PhoneNumber As String,
					Email As String, Address As String, CreditCard As String, Discount As UInteger, ActiveReservation As Boolean)
		Me.name = Name
		Me.surname = Surname
		Me.numberId = NumberId
		Me.birthDate = BirthDate
		Me.phoneNumber = PhoneNumber
		Me.email = Email
		Me.address = Address
		Me.creditCard = CreditCard
		Me.discountAvailable = Discount
		Me.activeReservation = ActiveReservation
	End Sub

	''' <summary>
	''' Metodo constructor con IdCliente
	''' </summary>
	''' <param name="NumberId">DNI del cliente</param>
	Public Sub New(NumberId As String)
		Me.numberId = NumberId
	End Sub

	''' <summary>
	''' Metodo constructor vacio para Cliente
	''' </summary>
	Public Sub New()

	End Sub

	''' <summary>
	''' Propiedad con get/set para nombre del cliente
	''' </summary>
	''' <returns>cadena con el nombre del cliente</returns>
	Public Property NameProp() As String
		Get
			Return name
		End Get
		Set(ByVal Value As String)
			name = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para apellidos del cliente
	''' </summary>
	''' <returns>cadena con los apellidos</returns>
	Public Property SurnameProp() As String
		Get
			Return surname
		End Get
		Set(ByVal Value As String)
			surname = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para DNI del cliente
	''' </summary>
	''' <returns>cadena con el DNI</returns>
	Public Property NumberIdProp() As String
		Get
			Return numberId
		End Get
		Set(ByVal Value As String)
			numberId = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para fecha de nac. del cliente
	''' </summary>
	''' <returns>fecha de nac.</returns>
	Public Property BirthDateProp() As Date
		Get
			Return birthDate
		End Get
		Set(ByVal Value As Date)
			birthDate = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para telefono del cliente
	''' </summary>
	''' <returns>cadena con el numero de telefono</returns>
	Public Property PhoneNumberProp() As String
		Get
			Return phoneNumber
		End Get
		Set(ByVal Value As String)
			phoneNumber = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para email del cliente
	''' </summary>
	''' <returns>cadena con el email</returns>
	Public Property EmailProp() As String
		Get
			Return email
		End Get
		Set(ByVal Value As String)
			email = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para direccion del cliente
	''' </summary>
	''' <returns>cadena con la direccion</returns>
	Public Property AddressProp() As String
		Get
			Return address
		End Get
		Set(ByVal Value As String)
			address = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para numero de tarjeta credito del cliente
	''' </summary>
	''' <returns>cadena con el numero de tarjeta credito</returns>
	Public Property CreditCardProp() As String
		Get
			Return creditCard
		End Get
		Set(ByVal Value As String)
			creditCard = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para descuento del cliente
	''' </summary>
	''' <returns>entero con porcentaje de descuento</returns>
	Public Property DiscountAvailableProp() As UInteger
		Get
			Return discountAvailable
		End Get
		Set(ByVal Value As UInteger)
			discountAvailable = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para reserva activa del cliente
	''' </summary>
	''' <returns>booleano reserva activa</returns>
	Public Property ActiveReservationProp() As Boolean
		Get
			Return activeReservation
		End Get
		Set(ByVal Value As Boolean)
			activeReservation = Value
		End Set
	End Property
End Class