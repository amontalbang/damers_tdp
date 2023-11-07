Public Class Service
	Private serviceId As String
	Private name As String
	Private description As String
	Private price As UInteger

	Public Sub New(serviceId As String, name As String, description As String, price As UInteger)
		Me.serviceId = serviceId
		Me.name = name
		Me.description = description
		Me.price = price
	End Sub

	Public Sub New(name As String, description As String, price As UInteger)
		Me.name = name
		Me.description = description
		Me.price = price
	End Sub

	Public Sub New()

	End Sub

	Public Property ServiceIdProp() As String
		Get
			Return serviceId
		End Get
		Set(ByVal Value As String)
			serviceId = Value
		End Set
	End Property

	Public Property NameProp() As String
		Get
			Return name
		End Get
		Set(ByVal Value As String)
			name = Value
		End Set
	End Property

	Public Property DescriptionProp() As String
		Get
			Return description
		End Get
		Set(ByVal Value As String)
			description = Value
		End Set
	End Property

	Public Property PriceProp() As UInteger
		Get
			Return price
		End Get
		Set(ByVal Value As UInteger)
			price = Value
		End Set
	End Property

End Class