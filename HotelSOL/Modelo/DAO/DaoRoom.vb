Imports System.Data.SqlClient

''' <summary>
''' Clase que implementa los metodos referentes a las habitaciones
''' </summary>
Public Class DAORoom
    Private connector As DatabaseConnection = New DatabaseConnection
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
    ''' Metodo que añade una habitacion
    ''' </summary>
    ''' <param name="room"></param>
    Public Sub AddRoom(room As Room)
        command.CommandText = "INSERT Habitaciones (IDhabitacion, Tipo, Capacidad, PrecioL, PrecioM, PrecioH) VALUES 
            ('" & room.RoomIdProp() & "', '" & room.TypeProp() & "', '" & room.CapacityProp() & "', '" & room.PriceLProp() & "', '" & room.PriceMProp() & "', '" & room.PriceHProp() & "')"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que elimina una habitacion
    ''' </summary>
    ''' <param name="room"></param>
    Public Sub DeleteRoom(room As Room)
        command.CommandText = "DELETE FROM Habitaciones where IDhabitacion = '" & room.RoomIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que actualiza una habitacion
    ''' </summary>
    ''' <param name="Room"></param>
    Public Sub UpdateRoom(Room As Room)
        command.CommandText = "UPDATE Habitaciones SET Tipo = '" & Room.TypeProp() & "', Capacidad = '" & Room.CapacityProp() & "', 
            PrecioL = '" & Room.PriceLProp() & "', PrecioM = '" & Room.PriceMProp() & "', PrecioH = '" & Room.PriceHProp() & "' WHERE IDhabitacion = '" & Room.RoomIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que comprueba si existe una habitacion
    ''' </summary>
    ''' <param name="roomId">ID de habitacion</param>
    ''' <returns>booleano con la respuesta</returns>
    Public Function RoomExists(roomId As UInteger) As Boolean
        Dim query As String = "SELECT * FROM Habitaciones WHERE IDhabitacion = '" & roomId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' MEtodo que devuelve una habitacion dado un numero de habitacion
    ''' </summary>
    ''' <param name="roomId"></param>
    ''' <returns></returns>
    Public Function GetRoomById(roomId As UInteger) As Room
        Dim query As String = "SELECT * FROM Habitaciones WHERE IDhabitacion = '" & roomId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Room()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Dim room As New Room
        Dim priceL As String
        Dim priceM As String
        Dim priceH As String
        'Return New Room(dr.Field(Of String)("IDhabitacion"), dr.Field(Of String)("Tipo"), dr.Field(Of String)("Capacidad"), dr.Field(Of UInteger)("PrecioH"), dr.Field(Of UInteger)("PrecioM"), dr.Field(Of UInteger)("PrecioL"))
        room.RoomIdProp = dt.AsEnumerable().ElementAt(0).Item(0).ToString
        room.TypeProp = dt.AsEnumerable().ElementAt(0).Item(1).ToString
        room.CapacityProp = dt.AsEnumerable().ElementAt(0).Item(2).ToString
        priceL = dt.AsEnumerable().ElementAt(0).Item(3).ToString
        room.PriceLProp = priceL
        priceM = dt.AsEnumerable().ElementAt(0).Item(4).ToString
        room.PriceMProp = priceM
        priceH = dt.AsEnumerable().ElementAt(0).Item(5).ToString
        room.PriceHProp = priceH
        Return New Room(room.RoomIdProp, room.TypeProp, room.CapacityProp, room.PriceHProp, room.PriceMProp, room.PriceLProp)
    End Function

    ''' <summary>
    ''' Metodo que devuelve un datatable con la informacion de todas las habitaciones
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRoomList() As DataTable
        Dim consulta As String = "SELECT * FROM Habitaciones"
        Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
        Dim roomList As New DataTable
        adaptador.Fill(roomList)
        Return roomList
    End Function

    ''' <summary>
    ''' Metodo de conexion a BD
    ''' </summary>
    Public Sub ExecuteQuery()
        Command.Connection = connector.Connect()
        Command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class
