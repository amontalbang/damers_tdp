Imports HotelSOL.Client
Imports HotelSOL.DatabaseConnection
Imports System.Data.SqlClient

Public Class DaoClient
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Public Sub New()
        connector = New DatabaseConnection()
        command = New System.Data.SqlClient.SqlCommand()
        command.CommandType = System.Data.CommandType.Text
    End Sub

    Public Sub AddClient(Client As Client)
        command.CommandText = "INSERT Clientes (IDCliente, Nombre, Apellidos, FechaNac, Telefono, Email, Direccion, TarjetaCred, Descuento, ReservaActiva) VALUES 
            ('" & Client.NumberIdProp() & "', '" & Client.NameProp() & "', '" & Client.SurnameProp() & "', '" & Client.BirthDateProp() & "', '" & Client.PhoneNumberProp() & "', '" & Client.EmailProp() & "', '" & Client.AddressProp() & "', '" & Client.CreditCardProp() & "', '" & Client.DiscountAvailableProp() & "', '" & Client.ActiveReservationProp() & "')"
        ExecuteQuery()
    End Sub
    Public Sub DeleteClient(Client As Client)
        command.CommandText = "DELETE FROM Clientes WHERE IDcliente = '" & Client.NumberIdProp() & "'"
        ExecuteQuery()
    End Sub
    Public Sub UpdateClient(Client As Client)
        command.CommandText = "UPDATE Clientes SET IDcliente = '" & Client.NumberIdProp() & "', Nombre = '" & Client.NameProp() & "', Apellidos = '" & Client.SurnameProp() & "',
            FechaNac = '" & Client.BirthDateProp() & "', Telefono = '" & Client.PhoneNumberProp() & "', Email = '" & Client.EmailProp() & "', Direccion = '" & Client.AddressProp() & "', TarjetaCred = '" & Client.CreditCardProp() & "', Descuento = '" & Client.DiscountAvailableProp() & "', ReservaActiva = '" & Client.ActiveReservationProp() & "' where IDcliente = '" & Client.NumberIdProp() & "'"
        ExecuteQuery()
    End Sub

    Public Sub CheckClient(client As Client)
        connector.Connect()
        Dim consulta As String = "SELECT * from Clientes WHERE IDcliente = '" & client.NumberIdProp() & "'"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Form6.DataGridView1.DataSource = dt
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No existe ningun cliente con ese ID")
        End If
        connector.Disconnect()
    End Sub

    Public Function ClientExists(ClientId As String) As Boolean
        Dim query As String = "SELECT * FROM Clientes WHERE IDcliente = '" & ClientId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function GetClientById(ClientId As String) As Client
        Dim query As String = "SELECT * FROM Clientes WHERE IDcliente = '" & ClientId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Client()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Client(dr.Field(Of String)("Nombre"), dr.Field(Of String)("Apellidos"), dr.Field(Of String)("NumberId"), dr.Field(Of String)("FechaNac"), dr.Field(Of String)("Telefono"), dr.Field(Of String)("Email"), dr.Field(Of String)("Adress"), dr.Field(Of String)("TarjetaCred"), dr.Field(Of UInteger)("Descuento"), dr.Field(Of Boolean)("ReservaActiva"))
    End Function
    Public Function GetClientList() As DataTable
        Dim query As String = "SELECT * FROM Clientes"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim clientList As New DataTable
        adapter.Fill(clientList)
        Return clientList
    End Function

    Public Sub ExecuteQuery()
        command.Connection = connector.Connect()
        command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class