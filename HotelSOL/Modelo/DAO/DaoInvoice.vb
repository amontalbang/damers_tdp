Imports HotelSOL.Invoice

Public Class DaoInvoice
    Private connector As DataBaseConnection = New DataBaseConnection
    Public Sub AddInvoice(Invoice As Invoice)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Facturas (IDreserva, Total) VALUES ('" & Invoice.ReservationIdProp & "', '" & Invoice.TotalAmountProp & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Factura creada correctamente")
    End Sub

    Public Sub DeleteInvoice(Invoice As Invoice)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "DELETE from Facturas where IDfactura = '" & Invoice.InvoiceIdProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Factura eliminada con éxito")
    End Sub

    Public Sub UpdateInvoice(Invoice As Invoice)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "UPDATE Facturas set IDreserva = '" & Invoice.InvoiceIdProp & "', Total = '" & Invoice.TotalAmountProp & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Factura actualizada correctamente")
    End Sub

    Public Function InvoiceExists(Invoice As UInteger) As Boolean
        Return False
    End Function

    Public Function GetInvoiceById(Invoice As UInteger) As Invoice
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT from Facturas where IDfactura = '" & Invoice & "'"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        Return New Invoice()
    End Function

    Public Function GetInvoiceList() As Invoice()
        Return {New Invoice()}
    End Function
End Class
