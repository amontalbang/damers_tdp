Imports System.Data.SqlClient

Public Class DatabaseConnection
    Public sqlConnection As SqlConnection

    Public Sub New()
    End Sub

    Public Function Connect() As SqlConnection
        sqlConnection = New SqlConnection("Data Source = LAPTOP-QH1U0LAN\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        sqlConnection.Open()
        Return sqlConnection
    End Function
    Public Sub Disconnect()
        sqlConnection.Close()
    End Sub
End Class