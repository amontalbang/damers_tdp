Public Class User
	Private userId As String
	Private email As String
	Private password As String

	Public Sub New(userId As String, email As String, password As String)
		Me.userId = userId
		Me.email = email
		Me.password = password
	End Sub

	Public Sub New(email As String, password As String)
		Me.email = email
		Me.password = password
	End Sub

	Public Sub New()

	End Sub

	Public Property UserIdProp() As String
		Get
			Return userId
		End Get
		Set(ByVal Value As String)
			userId = Value
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
	Public Property PasswordProp() As String
		Get
			Return password
		End Get
		Set(ByVal Value As String)
			password = Value
		End Set
	End Property
End Class