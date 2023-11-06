Imports System.Data.SqlClient

Public Class DataBaseConnection

    Public sqlConnection As SqlConnection

    Public Function Connect()
        sqlConnection = New System.Data.SqlClient.SqlConnection("Data Source = MAQUEDA\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        sqlConnection.Open()
        Return sqlConnection
    End Function

    Public Sub Disconnect()
        sqlConnection.Close()
    End Sub
End Class
