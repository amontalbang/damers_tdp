Imports System.Data.SqlClient

''' <summary>
''' Clase que alberga los metodos referentes a Servicios
''' </summary>
Public Class DaoService
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    ''' <summary>
    ''' Metodo constructor de la clase
    ''' </summary>
    Public Sub New()
        connector = New DatabaseConnection()
        command = New System.Data.SqlClient.SqlCommand()
        command.CommandType = System.Data.CommandType.Text
    End Sub

    ''' <summary>
    ''' Metodo que añade una factura en la BD
    ''' </summary>
    ''' <param name="Service">Objeto Servicio a registrar en la BD</param>
    Public Sub AddService(Service As Service)
        Try
            command.CommandText = "INSERT Servicios (IDservicio, Nombre, Descripcion, Precio, Disponible) VALUES 
            ('" & Service.ServiceIdProp() & "', '" & Service.NameProp() & "', '" & Service.DescriptionProp() & "', '" & Service.PriceProp() & "', '" & Service.UnitsAvailableProp & "')"
            ExecuteQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que elimina una factura de la BD
    ''' </summary>
    ''' <param name="Service">Objeto Factura a registrar en la BD</param>
    Public Sub DeleteService(Service As Service)
        command.CommandText = "DELETE FROM Servicios WHERE IDservicio = '" & Service.ServiceIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que modifica una factura de la BD
    ''' </summary>
    ''' <param name="Service">Objeto Factura a modificar en la BD</param>
    Public Sub UpdateService(Service As Service)
        command.CommandText = "UPDATE Servicios SET Nombre = '" & Service.NameProp & "', Descripcion = '" & Service.DescriptionProp & "', Precio = '" & Service.PriceProp & "', Disponible = '" & Service.UnitsAvailableProp & "' WHERE IDservicio = '" & Service.ServiceIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que indica si un servicio esta disponible
    ''' </summary>
    ''' <param name="ServiceId">ID del servicio a consultar</param>
    ''' <returns>Booleano con respuesta de servicio disponible</returns>
    Public Function ServiceAvailable(ServiceId As String) As Boolean
        Return False
    End Function

    ''' <summary>
    ''' Metodo para comprobar si existe un servicio
    ''' </summary>
    ''' <param name="IdService">ID del servicio a consultar</param>
    ''' <returns>Booleano con la existencia o no del servicio</returns>
    Public Function ServiceExists(IdService As String) As Boolean
        Dim query As String = "SELECT * FROM Servicios WHERE IDservicio = '" & IdService & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Metodo para comprobar si existe un servicio identificando por el nombre
    ''' </summary>
    ''' <param name="Name">Nombre del servicio a consultar</param>
    ''' <returns>Booleano con la existencia o no del servicio</returns>
    Public Function ServiceExistsByName(Name As String) As Boolean
        Dim query As String = "SELECT * FROM Servicios WHERE Nombre = '" & Name & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Metodo para recuperar un servicio de la BD
    ''' </summary>
    ''' <param name="IdService">ID del servicio a recuperar</param>
    ''' <returns>Objeto Servicio con los datos si existiera u objeto Servicio nuevo en caso de no existir</returns>
    Public Function GetServiceById(IdService As String) As Service
        Dim query As String = "SELECT * FROM Servicios WHERE IDservicio = '" & IdService & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Service()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Service(IdService, dr.Item(1), dr.Item(2), CUInt(dr.Item(3)), CUInt(dr.Item(4)))
        'Return New Service(IdService, dr.Field(Of String)("Nombre"), dr.Field(Of String)("Descripcion"), dr.Field(Of UInteger)("Precio"), dr.Field(Of UInteger)("Disponible"))
    End Function

    ''' <summary>
    ''' Metodo que devuelve la lista de todos los servicio registrados en la BD
    ''' </summary>
    ''' <returns>Devuelve un datatable con la lista de los servicios</returns>
    Public Function GetServiceList() As DataTable
        Try
            Dim query As String = "SELECT * FROM Servicios"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim serviceList As New DataTable
            adapter.Fill(serviceList)
            Return serviceList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ChargeService(invoiceId As UInteger, serviceId As String, units As UInteger)
        Try
            Dim query As String = "INSERT INTO ServiciosConsumidos (IDfactura, IDservicio, Cantidad) VALUES (" & invoiceId & ", '" & serviceId & "', " & units & ")"
            command.CommandText = query
            ExecuteQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetConsumedServices(InvoiceId As UInteger) As DataTable
        Try
            Dim query As String = "SELECT * FROM ServiciosConsumidos WHERE IDfactura = " & InvoiceId
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim servicesList As New DataTable
            adapter.Fill(servicesList)
            Return servicesList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetServicePrice(ServiceId As String) As UInteger
        Try
            Dim query As String = "SELECT * FROM Servicios WHERE IDservicio = " & ServiceId
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim service As New DataTable
            Dim price As UInteger
            adapter.Fill(service)
            price = CUInt(service.AsEnumerable().ElementAt(0).Item(3))
            Return price
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que establece la comunicacion con la BD
    ''' </summary>
    Private Sub ExecuteQuery()
        command.Connection = connector.Connect()
        command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub

End Class