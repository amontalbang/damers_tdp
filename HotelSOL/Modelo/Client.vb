Public Class Client
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

	Public Sub New(numberId As String, name As String, surname As String, birthDate As Date, phoneNumber As String,
					email As String, address As String, creditCard As String, discount As UInteger, activeReservation As Boolean)
		Me.name = name
		Me.surname = surname
		Me.numberId = numberId
		Me.birthDate = birthDate
		Me.phoneNumber = phoneNumber
		Me.email = email
		Me.address = address
		Me.creditCard = creditCard
		Me.discountAvailable = discount
		Me.activeReservation = activeReservation
	End Sub

	Public Sub New(numberId As String)
		Me.numberId = numberId
	End Sub

	Public Sub New()

	End Sub

	Public Property NameProp() As String
		Get
			Return name
		End Get
		Set(ByVal Value As String)
			name = Value
		End Set
	End Property

	Public Property SurnameProp() As String
		Get
			Return surname
		End Get
		Set(ByVal Value As String)
			surname = Value
		End Set
	End Property

	Public Property NumberIdProp() As String
		Get
			Return numberId
		End Get
		Set(ByVal Value As String)
			numberId = Value
		End Set
	End Property

	Public Property BirthDateProp() As Date
		Get
			Return birthDate
		End Get
		Set(ByVal Value As Date)
			birthDate = Value
		End Set
	End Property

	Public Property PhoneNumberProp() As String
		Get
			Return phoneNumber
		End Get
		Set(ByVal Value As String)
			phoneNumber = Value
		End Set
	End Property

	Public Property EmailProp() As String
		Get
			Return email
		End Get
		Set(ByVal Value As String)
			email = Value
		End Set
	End Property

	Public Property AddressProp() As String
		Get
			Return address
		End Get
		Set(ByVal Value As String)
			address = Value
		End Set
	End Property

	Public Property CreditCardProp() As String
		Get
			Return creditCard
		End Get
		Set(ByVal Value As String)
			creditCard = Value
		End Set
	End Property

	Public Property DiscountAvailableProp() As UInteger
		Get
			Return discountAvailable
		End Get
		Set(ByVal Value As UInteger)
			discountAvailable = Value
		End Set
	End Property

	Public Property ActiveReservationProp() As Boolean
		Get
			Return activeReservation
		End Get
		Set(ByVal Value As Boolean)
			activeReservation = Value
		End Set
	End Property

End Class