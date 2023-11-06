Imports HotelSOL.Room

Public Class DaoRoom
    Private connector As DataBaseConnection = New DataBaseConnection
    Public Sub AddRoomn(Room As Room)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Habitaciones (IDhabitacion, Tipo, Capacidad, PrecioL, PrecioM, PrecioH) VALUES ('" & Room.RoomIdProp & "', '" & Room.TypeProp & "', '" & Room.CapacityProp & "', '" & Room.PriceLProp & "', '" & Room.PriceMProp & "', '" & Room.PriceHProp & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Habitación creada correctamente")
    End Sub

    Public Sub DeleteRoom(Room As Room)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "DELETE from Habitaciones where IDhabitacion = '" & Room.RoomIdProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Habitación eliminada con éxito")
    End Sub

    Public Sub UpdateRoom(Room As Room)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "UPDATE Habitaciones set Tipo = '" & Room.TypeProp & "', Capacidad = '" & Room.CapacityProp & "', PrecioL = '" & Room.PriceLProp & "', PrecioM = '" & Room.PriceMProp & "', PrecioH = '" & Room.PriceHProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Habitación actualizada correctamente")
    End Sub

    Public Function RoomExists(Room As UInteger) As Boolean
        Return False
    End Function

    Public Function GetRoomById(Room As UInteger) As Room
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT from Habitaciones where IDhabitacion = '" & Room & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        Return New Room()
    End Function

    Public Function GetRoomList() As Room()
        Return {New Room()}
    End Function
End Class
