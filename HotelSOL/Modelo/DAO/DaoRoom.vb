Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports HotelSOL.Room

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
        MessageBox.Show("Habitación creada correctamente")
    End Sub

    Public Sub DeleteRoom(room As Room)
        command.CommandText = "DELETE from Habitaciones where IDhabitacion = '" & room.RoomIdProp() & "'"
        ExecuteQuery()
        MessageBox.Show("Habitación eliminada con éxito")
    End Sub

    Public Sub UpdateRoom(Room As Room)
        command.CommandText = "UPDATE Habitaciones SET Tipo = '" & Room.TypeProp() & "', Capacidad = '" & Room.CapacityProp() & "', 
            PrecioL = '" & Room.PriceLProp() & "', PrecioM = '" & Room.PriceMProp() & "', PrecioH = '" & Room.PriceHProp() & "' WHERE IDhabitacion = '" & Room.RoomIdProp() & "'"
        ExecuteQuery()
        MessageBox.Show("Habitación actualizada correctamente")
    End Sub

    Public Sub CheckRoom(room As Room)
        connector.Connect()
        Dim consulta As String = "SELECT * from Habitaciones WHERE IDhabitacion = '" & room.RoomIdProp() & "'"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Form11.DataGridView1.DataSource = dt
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No existe ninguna habitacion con ese número de habitacion")
        End If
        connector.Disconnect()
    End Sub

    Public Function RoomExists(roomId As UInteger) As Boolean
        Dim query As String = "SELECT * from Habitaciones WHERE IDhabitacion = '" & roomId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function GetRoomById(roomId As UInteger) As Room
        Dim query As String = "SELECT from Habitaciones WHERE IDhabitacion = '" & roomId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Room()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Room(dr.Field(Of String)("IDhabitacion"), dr.Field(Of String)("Tipo"), dr.Field(Of String)("Capacidad"), dr.Field(Of String)("PrecioH"), dr.Field(Of String)("PrecioM"), dr.Field(Of String)("PrecioL"))

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
