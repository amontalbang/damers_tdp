Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form25

    Private controller As Controller = New Controller
    Private connector As DatabaseConnection = New DatabaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'al seleccionar una fila manda los datos a los texbox
        i = DataGridView1.CurrentRow.Index
        Label7.Text = DataGridView1.Item(1, i).Value()
        ServiceIdTextBox.Text = DataGridView1.Item(0, i).Value()
        NameTextBox.Text = DataGridView1.Item(1, i).Value()
        DescriptionTextBox.Text = DataGridView1.Item(2, i).Value()
        PriceTextBox.Text = DataGridView1.Item(3, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim idServicio As Int16
        'idServicio = DataGridView1.Item(0, i).Value()
        'Dim decim As Decimal = Decimal.Parse(PriceTextBox.Text).ToString()
        'Dim consulta1 As String = "UPDATE Servicios set Nombre = '" & NameTextBox.Text & "', Descripcion = '" & DescriptionTextBox.Text & "', Precio = '" & decim & "' where IDservicio = '" & idServicio & "'"
        'comando = New SqlCommand(consulta1, connector.sqlConnection)
        'Dim lector As SqlDataReader
        'lector = comando.ExecuteReader
        'connector.Disconnect()
        'MessageBox.Show("Servicio actualizado con éxito")
        'llenar_grid()

        Dim idServicio As UInteger = UInteger.Parse(ServiceIdTextBox.Text).ToString()
        Dim nombre As String = NameTextBox.Text
        Dim descripcion As String = DescriptionTextBox.Text
        Dim precio As UInteger = UInteger.Parse(PriceTextBox.Text).ToString()
        Dim newService As Service = New Service(idServicio, nombre, descripcion, precio)
        controller.updateService(newService)
    End Sub
    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "SELECT * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class