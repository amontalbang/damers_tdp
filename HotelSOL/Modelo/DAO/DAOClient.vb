Imports System.Data.SqlClient

''' <summary>
''' Clase que alberga los metodos referentes a Clientes
''' </summary>
Public Class DaoClient
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
    ''' Metodo que añade un Cliente en la BD
    ''' </summary>
    ''' <param name="Client">Objeto Cliente a registrar en la BD</param>
    Public Sub AddClient(Client As Client)
        command.CommandText = "INSERT Clientes (IDCliente, Nombre, Apellidos, FechaNac, Telefono, Email, Direccion, TarjetaCred, Descuento, ReservaActiva) VALUES 
            ('" & Client.NumberIdProp() & "', '" & Client.NameProp() & "', '" & Client.SurnameProp() & "', '" & Client.BirthDateProp() & "', '" & Client.PhoneNumberProp() & "', '" & Client.EmailProp() & "', '" & Client.AddressProp() & "', '" & Client.CreditCardProp() & "', '" & Client.DiscountAvailableProp() & "', '" & Client.ActiveReservationProp() & "')"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un Cliente de la BD
    ''' </summary>
    ''' <param name="Client">Objeto Cliente a borrar en la BD</param>
    Public Sub DeleteClient(Client As Client)
        command.CommandText = "DELETE FROM Clientes WHERE IDcliente = '" & Client.NumberIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que actualiza un Cliente en la BD
    ''' </summary>
    ''' <param name="Client">Objeto Cliente a actualizar en la BD</param>
    Public Sub UpdateClient(Client As Client)
        command.CommandText = "UPDATE Clientes SET IDcliente = '" & Client.NumberIdProp() & "', Nombre = '" & Client.NameProp() & "', Apellidos = '" & Client.SurnameProp() & "',
            FechaNac = '" & Client.BirthDateProp() & "', Telefono = '" & Client.PhoneNumberProp() & "', Email = '" & Client.EmailProp() & "', Direccion = '" & Client.AddressProp() & "', TarjetaCred = '" & Client.CreditCardProp() & "', Descuento = '" & Client.DiscountAvailableProp() & "', ReservaActiva = '" & Client.ActiveReservationProp() & "' where IDcliente = '" & Client.NumberIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar si existe un cliente
    ''' </summary>
    ''' <param name="ClientId">ID del cliente que queremos comprobar</param>
    ''' <returns>Booleano con la respuesta de su existencia en la BD</returns>
    Public Function ClientExists(ClientId As String) As Boolean
        Try
            Dim query As String = "SELECT * FROM Clientes WHERE IDcliente = '" & ClientId & "'"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.AsEnumerable().Count() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo para obtener un cliente de la BD
    ''' </summary>
    ''' <param name="ClientId">ID del cliente que queremos recuperar</param>
    ''' <returns>Objeto cliente con la informacion del mismo si existe o cliente nuevo si no existe</returns>
    Public Function GetClientById(ClientId As String) As Client
        Dim query As String = "SELECT * FROM Clientes WHERE IDcliente = '" & ClientId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Client()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Dim client As New Client()
        Dim birth As String
        Dim discount As String
        Dim actRes As String
        'Return New Client(dr.Field(Of String)("IDcliente"), dr.Field(Of String)("Nombre"), dr.Field(Of String)("Apellidos"), dr.Field(Of Date)("FechaNac"), dr.Field(Of String)("Telefono"), dr.Field(Of String)("Email"), dr.Field(Of String)("Direccion"), dr.Field(Of String)("TarjetaCred"), dr.Field(Of UInteger)("Descuento"), dr.Field(Of Boolean)("ReservaActiva"))
        client.NumberIdProp = dt.AsEnumerable().ElementAt(0).Item(0).ToString
        client.NameProp = dt.AsEnumerable().ElementAt(0).Item(1).ToString
        client.SurnameProp = dt.AsEnumerable().ElementAt(0).Item(2).ToString
        birth = dt.AsEnumerable().ElementAt(0).Item(3).ToString
        client.BirthDateProp = CDate(birth)
        client.PhoneNumberProp = dt.AsEnumerable().ElementAt(0).Item(4).ToString
        client.EmailProp = dt.AsEnumerable().ElementAt(0).Item(5).ToString
        client.AddressProp = dt.AsEnumerable().ElementAt(0).Item(6).ToString
        client.CreditCardProp = dt.AsEnumerable().ElementAt(0).Item(7).ToString
        discount = dt.AsEnumerable().ElementAt(0).Item(8).ToString
        client.DiscountAvailableProp = CUInt(discount)
        actRes = dt.AsEnumerable().ElementAt(0).Item(9).ToString
        client.ActiveReservationProp = CBool(actRes)
        Return New Client(client.NumberIdProp, client.NameProp, client.SurnameProp, client.BirthDateProp, client.PhoneNumberProp, client.EmailProp, client.AddressProp, client.CreditCardProp, client.DiscountAvailableProp, client.ActiveReservationProp)
    End Function

    ''' <summary>
    ''' Metodo que devuelve las lista de todos los clientes registrados en la BD
    ''' </summary>
    ''' <returns>Un datatable con la lista de clientes</returns>
    Public Function GetClientList() As DataTable
        Dim query As String = "SELECT * FROM Clientes"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim clientList As New DataTable
        adapter.Fill(clientList)
        Return clientList
    End Function

    ''' <summary>
    ''' Metodo que establece la comunicacion con la BD
    ''' </summary>
    Public Sub ExecuteQuery()
        command.Connection = connector.Connect()
        command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class