﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("HotelSOL.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property ClientsToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("ClientsToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property InvoicesToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("InvoicesToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Clients() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Clients", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Invoices() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Invoices", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Reservations() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Reservations", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Rooms() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Rooms", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Services() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Services", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property OdooToApp_Users() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("OdooToApp_Users", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property ReservationsToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("ReservationsToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property RoomsToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("RoomsToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property ServicesToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("ServicesToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property UsersToOdoo() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("UsersToOdoo", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
