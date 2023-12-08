Imports System.Data.SqlClient

''' <summary>
''' Clase que alberga los metodos referentes a Usuarios
''' </summary>
Public Class DaoUser
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
    ''' Metodo que añade un usuario en la BD
    ''' </summary>
    ''' <param name="User">Objeto Usuario a registrar en la BD</param>
    Public Sub AddUser(User As User)
        command.CommandText = "INSERT Usuarios (IDusuario, Email, Password) VALUES ('" & User.UserIdProp & "', '" & User.EmailProp & "', '" & User.PasswordProp & "')"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que elimina un usuario en la BD
    ''' </summary>
    ''' <param name="User">Objeto Usuario a eliminar de la BD</param>
    Public Sub DeleteUser(User As User)
        command.CommandText = "DELETE FROM Usuarios WHERE IDusuario = '" & User.UserIdProp & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que modifica un usuario de la BD
    ''' </summary>
    ''' <param name="User">Objeto Usuario a modificar en la BD</param>
    Public Sub UpdateUser(User As User)
        command.CommandText = "UPDATE Usuarios SET Email = '" & User.EmailProp & "', Password = '" & User.PasswordProp & "' where IDusuario = '" & User.UserIdProp() & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar si existe un usuario
    ''' </summary>
    ''' <param name="UserId">ID del usuario que queremos comprobar</param>
    ''' <returns>Booleano con la respuesta de su existencia en la BD</returns>
    Public Function UserExists(UserId As String) As Boolean
        Dim query As String = "SELECT * FROM Usuarios WHERE IDusuario = '" & UserId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Metodo que devuelve las lista de todos los usuarios registrados en la BD
    ''' </summary>
    ''' <returns>Un datatable con la lista de usuarios</returns>
    Public Function GetUserList() As DataTable
        Dim query As String = "SELECT * FROM Usuarios"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim userList As New DataTable
        adapter.Fill(userList)
        Return userList
    End Function

    ''' <summary>
    ''' Metodo que permite la autenticación en la aplicacion
    ''' </summary>
    ''' <param name="UserId">ID del usuario que esta manejando la app</param>
    ''' <param name="Password">Contraseña del usuario</param>
    ''' <returns>Booleano con la respuesta exitosa o no del login</returns>
    Public Function UserLogin(UserId As String, Password As String) As Boolean
        Try
            Dim query As String = "SELECT * FROM Usuarios where IDusuario='" & UserId & "'and Password ='" & Password & "'"
            Dim adapter As New SqlDataAdapter(query, connector.Connect())
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.AsEnumerable().Count() > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
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