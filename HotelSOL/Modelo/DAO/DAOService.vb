Imports HotelSOL.Service
Imports HotelSOL.DatabaseConnection
Imports System.Data.SqlClient

Public Class DaoService
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Public Sub New()
        connector = New DatabaseConnection()
        command = New System.Data.SqlClient.SqlCommand()
        command.CommandType = System.Data.CommandType.Text
    End Sub
    Public Sub AddService(Service As Service)
        command.CommandText = "INSERT Servicios (Nombre, Descripcion, Precio) VALUES 
            ('" & Service.NameProp & "', '" & Service.DescriptionProp & "', '" & Service.PriceProp & "')"
        ExecuteQuery()
    End Sub
    Public Sub DeleteService(ServiceId As String)
        command.CommandText = "DELETE FROM Servicios WHERE IDservicio = '" & ServiceId & "'"
        ExecuteQuery()
    End Sub
    Public Sub UpdateService(Service As Service)
        command.CommandText = "UPDATE Servicios SET Nombre = '" & Service.NameProp & "' Descripcion = '" & Service.DescriptionProp & "' Precio = '" & Service.PriceProp & "'"
        ExecuteQuery()
    End Sub
    Public Function ServiceAvailable(ServiceId As String) As Boolean
        Return False
    End Function
    Public Function GetServiceById(ServiceId As String) As Service
        Dim query As String = "SELECT * FROM Servicios WHERE IDservicio = '" & ServiceId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Service()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Service(dr.Field(Of String)("Nombre"), dr.Field(Of String)("Descripcion"), dr.Field(Of UInteger)("Precio"))
    End Function
    Public Function GetSericeList() As DataTable
        Dim query As String = "SELECT * FROM Servicios"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim serviceList As New DataTable
        adapter.Fill(serviceList)
        Return serviceList
    End Function
    Public Sub ExecuteQuery()
        Command.Connection = connector.Connect()
        Command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class