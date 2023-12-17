Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Public Class Form29

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        conection = New SqlConnection("Data Source = MAQUEDA\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        conection.Open()
        Dim consulta As String = "select * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim fs As New FileStream("ImportClientsXML.xml", FileMode.Open, FileAccess.Read)
        Dim sqlConnection As New System.Data.SqlClient.SqlConnection("Data Source = MAQUEDA\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        Dim cmd As New System.Data.SqlClient.SqlCommand

        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("Cliente")
        For i = 0 To xmlnode.Count - 1
            xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Clientes (IDcliente, Nombre, Apellidos, FechaNac, Telefono, Email, Direccion, TarjetaCred, Descuento, ReservaActiva) VALUES ('" & xmlnode(i).ChildNodes.Item(0).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(1).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(2).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(3).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(4).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(5).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(6).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(7).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(8).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(9).InnerText.Trim() & "')"
            cmd.Connection = sqlConnection
            sqlConnection.Open()
            cmd.ExecuteNonQuery()
            sqlConnection.Close()
        Next
        llenar_grid()
        MessageBox.Show("XML importado correctamente")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim consulta As String = "select * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Dim root As XElement = New XElement("Clientes")
        Dim node As XElement
        For i = 0 To dt.Rows.Count - 1
            node = New XElement("Clientes")
            node.Add(New XElement("IDcliente", DataGridView1.Item(0, i).Value()))
            node.Add(New XElement("Nombre", DataGridView1.Item(1, i).Value()))
            node.Add(New XElement("Apellidos", DataGridView1.Item(2, i).Value()))
            node.Add(New XElement("FechaNac", DataGridView1.Item(3, i).Value()))
            node.Add(New XElement("Telefono", DataGridView1.Item(4, i).Value()))
            node.Add(New XElement("Email", DataGridView1.Item(5, i).Value()))
            node.Add(New XElement("Direccion", DataGridView1.Item(6, i).Value()))
            node.Add(New XElement("TarjetaCred", DataGridView1.Item(7, i).Value()))
            node.Add(New XElement("Descuento", DataGridView1.Item(8, i).Value()))
            node.Add(New XElement("ReservaActiva", DataGridView1.Item(9, i).Value()))
            root.Add(node)
        Next
        Dim doc As XDocument = New XDocument(root)
        doc.Save("ExportedClients.xml")
        MessageBox.Show("XML exportado correctamente")
    End Sub

End Class