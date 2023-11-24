Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class _32_Exports

    Private controller As Controller = New Controller
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Private Sub _32_Exports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent
    End Sub

    Private Sub ClientsExportButton_Click(sender As Object, e As EventArgs) Handles ClientsExportButton.Click
        Try
            Dim i As Integer
            Dim dt As New DataTable
            dt = controller.GetClientList()
            DataGridView1.DataSource = dt
            Dim root As XElement = New XElement("Clientes")
            Dim node As XElement
            For i = 0 To dt.Rows.Count - 1
                node = New XElement("Cliente")
                node.Add(New XElement("IDcliente", DataGridView1(0, i).Value()))
                node.Add(New XElement("Nombre", DataGridView1(1, i).Value()))
                node.Add(New XElement("Apellidos", DataGridView1(2, i).Value()))
                node.Add(New XElement("FechaNac", DataGridView1(3, i).Value()))
                node.Add(New XElement("Telefono", DataGridView1(4, i).Value()))
                node.Add(New XElement("Email", DataGridView1(5, i).Value()))
                node.Add(New XElement("Direccion", DataGridView1(6, i).Value()))
                node.Add(New XElement("TarjetaCred", DataGridView1(7, i).Value()))
                node.Add(New XElement("Descuento", DataGridView1(8, i).Value()))
                node.Add(New XElement("ReservaActiva", DataGridView1(9, i).Value()))
                root.Add(node)
            Next
            Dim doc As XDocument = New XDocument(root)
            doc.Save("EXPORTED_CLIENTS.xml")
            MessageBox.Show("XML de clientes exportado correctamente")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RoomsExportsButton_Click(sender As Object, e As EventArgs) Handles RoomsExportsButton.Click

    End Sub

    Private Sub ServicesExportButton_Click(sender As Object, e As EventArgs) Handles ServicesExportButton.Click

    End Sub

    Private Sub UsersExportButton_Click(sender As Object, e As EventArgs) Handles UsersExportButton.Click

    End Sub
End Class