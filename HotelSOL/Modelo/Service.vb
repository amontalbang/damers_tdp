﻿''' <summary>
''' Clase que alberga los atributos, constructores y propiedades de Servicio
''' </summary>
Public Class Service

	'Definicion de atributos
	Private serviceId As UInteger
	Private name As String
	Private description As String
	Private price As UInteger

	''' <summary>
	''' Metodo constructor con todos los atributos del objeto
	''' </summary>
	''' <param name="ServiceId">Id del servicio</param>
	''' <param name="Name">nombre del servicio</param>
	''' <param name="Description">descripcion del servicio</param>
	''' <param name="Price">precio del servicio</param>
	Public Sub New(ServiceId As UInteger, Name As String, Description As String, Price As UInteger)
		Me.serviceId = ServiceId
		Me.name = Name
		Me.description = Description
		Me.price = Price
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
	End Sub

	''' <summary>
	''' Constructor de objeto
	''' </summary>
	''' <param name="ServiceId">Id del servicio</param>
	Public Sub New(ServiceId As UInteger)
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
	Public Property ServiceIdProp() As UInteger
		Get
			Return serviceId
		End Get
		Set(ByVal Value As UInteger)
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
End Class