''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Servicio
''' </summary>
Public Class Service

	'Definicion de atributos
	Private serviceId As String
	Private name As String
	Private description As String
	Private price As UInteger
	Private unitsAvailable As UInteger

	''' <summary>
	''' Metodo constructor con todos los atributos del objeto
	''' </summary>
	''' <param name="ServiceId">Id del servicio</param>
	''' <param name="Name">nombre del servicio</param>
	''' <param name="Description">descripcion del servicio</param>
	''' <param name="Price">precio del servicio</param>
	''' <param name="Units">unidades disponibles del producto</param>
	Public Sub New(ServiceId As String, Name As String, Description As String, Price As UInteger, Units As UInteger)
		Me.serviceId = ServiceId
		Me.name = Name
		Me.description = Description
		Me.price = Price
		Me.unitsAvailable = Units
	End Sub

	''' <summary>
	''' Metodo constructor con todos los atributos del objeto
	''' </summary>
	''' <param name="ServiceId">Id del servicio</param>
	''' <param name="Name">nombre del servicio</param>
	''' <param name="Description">descripcion del servicio</param>
	''' <param name="Price">precio del servicio</param>
	Public Sub New(ServiceId As String, Name As String, Description As String, Price As UInteger)
		Me.serviceId = ServiceId
		Me.name = Name
		Me.description = Description
		Me.price = Price
		Me.unitsAvailable = 0
	End Sub

	''' <summary>
	''' Constructor de objeto
	''' </summary>
	''' <param name="Name">nombre del servicio</param>
	''' <param name="Description">descripcion del servicio</param>
	''' <param name="Price">precio del servicio</param>
	Public Sub New(Name As String, Description As String, Price As UInteger)
		Me.name = Name
		Me.description = Description
		Me.price = Price
		Me.unitsAvailable = 0
	End Sub

	''' <summary>
	''' Constructor de objeto
	''' </summary>
	''' <param name="ServiceId">Id del servicio</param>
	Public Sub New(ServiceId As String)
		Me.serviceId = ServiceId
	End Sub

	''' <summary>
	''' Constructor vacio de objeto
	''' </summary>
	Public Sub New()
	End Sub

	''' <summary>
	''' Propiedad con get/set para la Id del servicio
	''' </summary>
	''' <returns>entero indicando la Id del servicio</returns>
	Public Property ServiceIdProp() As String
		Get
			Return serviceId
		End Get
		Set(ByVal Value As String)
			serviceId = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para el nombre del servicio
	''' </summary>
	''' <returns>cadena con el nombre del servicio</returns>
	Public Property NameProp() As String
		Get
			Return name
		End Get
		Set(ByVal Value As String)
			name = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para la descripcion del servicio
	''' </summary>
	''' <returns>cadena con la descripcion del servicio</returns>
	Public Property DescriptionProp() As String
		Get
			Return description
		End Get
		Set(ByVal Value As String)
			description = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para el precio del servicio
	''' </summary>
	''' <returns>entero indicando el precio del servicio</returns>
	Public Property PriceProp() As UInteger
		Get
			Return price
		End Get
		Set(ByVal Value As UInteger)
			price = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para el numero de unidades disponibles
	''' </summary>
	''' <returns>entero indicando el numero de unidades disponibles</returns>
	Public Property UnitsAvailableProp() As UInteger
		Get
			Return unitsAvailable
		End Get
		Set(ByVal Value As UInteger)
			unitsAvailable = Value
		End Set
	End Property
End Class