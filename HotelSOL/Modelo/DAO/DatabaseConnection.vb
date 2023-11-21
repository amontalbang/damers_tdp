Imports System.Data.SqlClient

''' <summary>
''' Clase que alberga los metodos de conexion con la BD
''' </summary>
Public Class DatabaseConnection
    Public sqlConnection As SqlConnection

    ''' <summary>
    ''' Metodo constructor de la clase
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Metodo que conecta con la BD
    ''' </summary>
    ''' <returns>Devuelve una conexion abierta con SQL</returns>
    Public Function Connect() As SqlConnection
        Try
            sqlConnection = New SqlConnection("Data Source = LAPTOP-QH1U0LAN\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
            sqlConnection.Open()
            Return sqlConnection
        Catch ex As Exception
            Throw New Exception("Cannot connect with DB")
        End Try
    End Function

    ''' <summary>
    ''' Metodo que desconecta con la BD
    ''' </summary>
    Public Sub Disconnect()
        sqlConnection.Close()
    End Sub
End Class