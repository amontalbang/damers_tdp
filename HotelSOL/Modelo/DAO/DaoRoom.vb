Imports System.Data.SqlClient

Public Class DAORoom
    Private connector As DatabaseConnection = New DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Public Sub New()
        connector = New DatabaseConnection()
        command = New System.Data.SqlClient.SqlCommand()
        command.CommandType = System.Data.CommandType.Text
    End Sub

    Public Sub AddRoom(room As Room)
        command.CommandText = "INSERT Habitaciones (IDhabitacion, Tipo, Capacidad, PrecioL, PrecioM, PrecioH) VALUES 
            ('" & room.RoomIdProp() & "', '" & room.TypeProp() & "', '" & room.CapacityProp() & "', '" & room.PriceLProp() & "', '" & room.PriceMProp() & "', '" & room.PriceHProp() & "')"
        ExecuteQuery()
    End Sub

    Public Sub DeleteRoom(room As Room)
        command.CommandText = "DELETE FROM Habitaciones where IDhabitacion = '" & room.RoomIdProp() & "'"
        ExecuteQuery()
    End Sub

    Public Sub UpdateRoom(Room As Room)
        command.CommandText = "UPDATE Habitaciones SET Tipo = '" & Room.TypeProp() & "', Capacidad = '" & Room.CapacityProp() & "', 
            PrecioL = '" & Room.PriceLProp() & "', PrecioM = '" & Room.PriceMProp() & "', PrecioH = '" & Room.PriceHProp() & "' WHERE IDhabitacion = '" & Room.RoomIdProp() & "'"
        ExecuteQuery()
    End Sub

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
        Return New Room(room.RoomIdProp, room.TypeProp, room.CapacityProp, room.PriceLProp, room.PriceMProp, room.PriceHProp)
    End Function

    Public Function GetRoomList() As DataTable
        Dim consulta As String = "SELECT * FROM Habitaciones"
        Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
        Dim roomList As New DataTable
        adaptador.Fill(roomList)
        Return roomList
    End Function

    Public Sub ExecuteQuery()
        Command.Connection = connector.Connect()
        Command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class
