Imports HotelSOL.User
Imports HotelSOL.DatabaseConnection
Imports System.Data.SqlClient

Public Class DaoUser
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Public Sub New()
        connector = New DatabaseConnection()
        command = New System.Data.SqlClient.SqlCommand()
        command.CommandType = System.Data.CommandType.Text
    End Sub
    Public Sub AddUser(User As User)
        command.CommandText = "INSERT Usuarios (IDusuario, Email, Password) VALUES ('" & User.UserIdProp & "', '" & User.EmailProp & "', '" & User.PasswordProp & "'"
        ExecuteQuery()
    End Sub
    Public Sub DeleteUser(UserId As String)
        command.CommandText = "DELETE FROM Usuarios WHERE IDusuario = '" & UserId & "'"
    End Sub
    Public Sub UpdateUser(User As User)
        command.CommandText = "UPDATE Usuarios SET Email = '" & User.EmailProp & "' Password = '" & User.PasswordProp & "'"
        ExecuteQuery()
    End Sub
    Public Function UserExists(UserId As String) As Boolean
        Dim query As String = "SELECT * FROM Usuarios WHERE IDcliente = '" & UserId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Sub ExecuteQuery()
        command.Connection = connector.Connect()
        command.ExecuteNonQuery()
        connector.Disconnect()
    End Sub
End Class