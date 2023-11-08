Imports System.Data.SqlClient
Imports HotelSOL.Invoice

Public Class DAOInvoice
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

    Public Function InvoiceExists(InvoiceId As UInteger) As Boolean
        Dim query As String = "SELECT * from Facturas WHERE IDfactura = '" & InvoiceId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function GetInvoiceById(InvoiceId As UInteger) As Invoice
        Dim query As String = "SELECT from Facturas WHERE IDfactura = '" & InvoiceId & "'"
        Dim adapter As New SqlDataAdapter(query, connector.Connect())
        Dim dt As New DataTable
        adapter.Fill(dt)
        If dt.AsEnumerable().Count() = 0 Then
            Return New Invoice()
        End If
        Dim dr As DataRow = dt.AsEnumerable().ElementAt(0)
        Return New Invoice(dr.Field(Of String)("IDfactura"), dr.Field(Of String)("IDreserva"), dr.Field(Of String)("Total"))
    End Function

    Public Function GetInvoiceList() As DataTable
        Dim consulta As String = "SELECT * FROM Facturas"
        Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
        Dim invoiceList As New DataTable
        adaptador.Fill(invoiceList)
        Return invoiceList
    End Function
End Class
