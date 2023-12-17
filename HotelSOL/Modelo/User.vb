''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Usuario
''' </summary>
Public Class User

	'Definicion de atributos
	Private userId As String
	Private email As String
	Private password As String

	''' <summary>
	''' Metodo constructor con todos los atributos del objeto
	''' </summary>
	''' <param name="UserId">cadena Id del usuario</param>
	''' <param name="Email">cadena email del usuario</param>
	''' <param name="Password">cadena contraseña del usuario</param>
	Public Sub New(UserId As String, Email As String, Password As String)
		Me.userId = UserId
		Me.email = Email
		Me.password = Password
	End Sub

	''' <summary>
	''' Metodo constructor con Id de usuario
	''' </summary>
	''' <param name="UserId">cadena Id del usuario</param>
	Public Sub New(UserId As String)
		Me.userId = UserId
	End Sub

	''' <summary>
	''' Metodo constructor vacio para Cliente
	''' </summary>
	Public Sub New()

	End Sub

	''' <summary>
	''' Propiedad con get/set para Id del usuario
	''' </summary>
	''' <returns>cadena con Id</returns>
	Public Property UserIdProp() As String
		Get
			Return userId
		End Get
		Set(ByVal Value As String)
			userId = Value
		End Set
	End Property

	''' <summary>
	''' Propiedad con get/set para el email del usuario
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
	''' Propiedad con get/set para la contraseña del usuario
	''' </summary>
	''' <returns>cadena con la contraseña</returns>
	Public Property PasswordProp() As String
		Get
			Return password
		End Get
		Set(ByVal Value As String)
			password = Value
		End Set
	End Property
End Class