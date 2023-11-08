Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form10

    Private controller As Controller = New Controller
    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "SELECT * from Habitaciones"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'connector.Connect()
        'Dim Tipo As String = TypeTextBox.Text.ToString()
        'Dim Capacidad As Integer = Integer.Parse(CapacityTextBox.Text).ToString()
        'Dim PrecioL As Double = Double.Parse(PriceHTextBox.Text).ToString()
        'Dim PrecioM As Double = Double.Parse(PriceMTextBox.Text).ToString()
        'Dim PrecioH As Double = Double.Parse(PriceLTextBox.Text).ToString()
        'Dim consulta1 As String = "UPDATE Habitaciones set Tipo = '" & Tipo & "', Capacidad = '" & Capacidad & "', PrecioL = '" & PrecioL & "' , PrecioM = '" & PrecioM & "', PrecioH = '" & PrecioH & "'"
        'comando = New SqlCommand(consulta1, connector.sqlConnection)
        'Dim lector As SqlDataReader
        'lector = comando.ExecuteReader
        'connector.Disconnect()

        Dim id As String = NumHabTextBox.Text
        Dim tipo As String = TypeTextBox.Text
        Dim capacidad As String = CapacityTextBox.Text
        Dim precioL As UInteger = UInteger.Parse(PriceLTextBox.Text).ToString()
        Dim precioM As UInteger = UInteger.Parse(PriceMTextBox.Text).ToString()
        Dim precioH As UInteger = UInteger.Parse(PriceHTextBox.Text).ToString()
        Dim newRoom As Room = New Room(id, tipo, capacidad, precioL, precioM, precioH)
        controller.updateRoom(newRoom)
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        Label12.Text = DataGridView1.Item(0, i).Value()
        NumHabTextBox.Text = DataGridView1.Item(0, i).Value()
        TypeTextBox.Text = DataGridView1.Item(1, i).Value()
        CapacityTextBox.Text = DataGridView1.Item(2, i).Value()
        PriceHTextBox.Text = DataGridView1.Item(3, i).Value()
        PriceMTextBox.Text = DataGridView1.Item(4, i).Value()
        PriceLTextBox.Text = DataGridView1.Item(5, i).Value()
    End Sub
End Class