Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9
    Private connector As DatabaseConnection = New DatabaseConnection
    Private controller As Controller = New Controller

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cmd As New System.Data.SqlClient.SqlCommand
        'Dim tipo As String = TypeTextBox.Text.ToString()
        'Dim capacidad As Integer = Integer.Parse(CapacityTextBox.Text).ToString()
        'Dim precioL As Double = Double.Parse(PriceHTextBox.Text).ToString()
        'Dim precioM As Double = Double.Parse(PriceMTextBox.Text).ToString()
        'Dim precioH As Double = Double.Parse(PriceLTextBox.Text).ToString()
        'cmd.CommandType = System.Data.CommandType.Text
        'cmd.CommandText = "INSERT Habitaciones (Tipo, Capacidad, PrecioL, PrecioM, PrecioL, Animales, Cuna) VALUES ('" & Tipo & "', '" & Capacidad & "', '" & PrecioL & "', '" & PrecioM & "', '" & PrecioH & "', '" & Animales & "', '" & Cuna & "')"
        'cmd.Connection = connector.Connect()
        'cmd.ExecuteNonQuery()
        'connector.Disconnect()
        'MessageBox.Show("Habitación registrada correctamente")

        Dim id As String = NumHabTextBox.Text
        Dim tipo As String = TypeTextBox.Text
        Dim capacidad As String = CapacityTextBox.Text
        Dim precioL As UInteger = UInteger.Parse(PriceLTextBox.Text).ToString()
        Dim precioM As UInteger = UInteger.Parse(PriceMTextBox.Text).ToString()
        Dim precioH As UInteger = UInteger.Parse(PriceHTextBox.Text).ToString()
        Dim newRoom As Room = New Room(id, tipo, capacidad, precioL, precioM, precioH)
        controller.addRoom(newRoom)
    End Sub
End Class