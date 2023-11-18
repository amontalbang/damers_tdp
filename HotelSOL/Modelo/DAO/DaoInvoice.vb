Imports System.Data.SqlClient

''' <summary>
''' Clase que alberga los metodos referentes a Facturas
''' </summary>
Public Class DAOInvoice
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
    ''' Metodo que añade una factura en la BD
    ''' </summary>
    ''' <param name="Invoice">Objeto Factura a registrar en la BD</param>
    Public Sub AddInvoice(Invoice As Invoice)
        command.CommandText = "INSERT Facturas (IDreserva, Total) VALUES ('" & Invoice.ReservationIdProp & "', '" & Invoice.TotalAmountProp & "')"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que elimina una factura de la BD
    ''' </summary>
    ''' <param name="Invoice">Objeto Factura a eliminar de la BD</param></param>
    Public Sub DeleteInvoice(Invoice As Invoice)
        command.CommandText = "DELETE from Facturas where IDfactura = '" & Invoice.InvoiceIdProp & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo que actualiza una factura de la BD
    ''' </summary>
    ''' <param name="Invoice">Objeto Factura a modificar en la BD</param>
    Public Sub UpdateInvoice(Invoice As Invoice)
        command.CommandText = "UPDATE Facturas set IDreserva = '" & Invoice.InvoiceIdProp & "', Total = '" & Invoice.TotalAmountProp & "'"
        ExecuteQuery()
    End Sub

    ''' <summary>
    ''' Metodo para comprobar si existe una factura en la BD
    ''' </summary>
    ''' <param name="InvoiceId">Numero de factura a comprobar</param>
    ''' <returns>Booleano con la respuesta de la existencia o no en la BD</returns>
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

    ''' <summary>
    ''' Metodo para recuperar una factura de la BD
    ''' </summary>
    ''' <param name="InvoiceId">Numero de factura a recuperar</param>
    ''' <returns>Objeto Factura con sus datos en caso de existir o nueva factura si no existe</returns>
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

    ''' <summary>
    ''' Metodo para obtener la lista con todas las facturas registradas en la base de datos
    ''' </summary>
    ''' <returns>Un datatable con la lista de facturas</returns>
    Public Function GetInvoiceList() As DataTable
        Dim consulta As String = "SELECT * FROM Facturas"
        Dim adaptador As New SqlDataAdapter(consulta, connector.Connect())
        Dim invoiceList As New DataTable
        adaptador.Fill(invoiceList)
        Return invoiceList
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
