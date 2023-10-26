Imports System.Collections.ObjectModel
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Form28

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim consulta As String = "select * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Dim root As XElement = New XElement("Servicios")
        Dim node As XElement
        For i = 0 To dt.Rows.Count - 1
            node = New XElement("Servicios")
            node.Add(New XElement("IDservicio", DataGridView1.Item(0, i).Value()))
            node.Add(New XElement("Nombre", DataGridView1.Item(1, i).Value()))
            node.Add(New XElement("Descripcion", DataGridView1.Item(2, i).Value()))
            node.Add(New XElement("Precio", DataGridView1.Item(3, i).Value()))
            root.Add(node)
        Next
        Dim doc As XDocument = New XDocument(root)
        doc.Save("123.xml")
        MessageBox.Show("XML exportado correctamente")
    End Sub

    Private Class Service
        Public Property IDservicio As String
        Public Property Nombre As String
        Public Property Descripcion As String
        Public Property Precio As String
    End Class

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        llenar_grid()

    End Sub

    Private Sub llenar_grid()

        conection = New SqlConnection("Data Source = LAPTOP-QH1U0LAN \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        conection.Open()
        Dim consulta As String = "select * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        conection.Close()
        Form23.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim fs As New FileStream("ImportXML.xml", FileMode.Open, FileAccess.Read)
        Dim sqlConnection As New System.Data.SqlClient.SqlConnection("Data Source = LAPTOP-QH1U0LAN \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        Dim cmd As New System.Data.SqlClient.SqlCommand

        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("Servicio")
        For i = 0 To xmlnode.Count - 1
            xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Servicios (Nombre, Descripcion, Precio) VALUES ('" & xmlnode(i).ChildNodes.Item(1).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(2).InnerText.Trim() & "', '" & xmlnode(i).ChildNodes.Item(3).InnerText.Trim() & "')"
            cmd.Connection = sqlConnection
            sqlConnection.Open()
            cmd.ExecuteNonQuery()
            sqlConnection.Close()
        Next
        llenar_grid()
        MessageBox.Show("XML importado correctamente")

    End Sub
End Class