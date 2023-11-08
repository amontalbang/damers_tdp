Imports System.Data.SqlClient

Public Class Form24

    Private connector As DatabaseConnection = New DatabaseConnection
    Private controller As Controller = New Controller

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cmd As New System.Data.SqlClient.SqlCommand
        'Dim decim As Double = Double.Parse(PriceTextBox.Text).ToString()
        'cmd.CommandType = System.Data.CommandType.Text
        'cmd.CommandText = "INSERT Servicios (Nombre, Descripcion, Precio) VALUES ('" & NameTextBox.Text & "', '" & DesciptionTextBox.Text & "', '" & decim & "')"
        'cmd.Connection = connector.Connect()
        'cmd.ExecuteNonQuery()
        'connector.Disconnect()
        'MessageBox.Show("Servicio registrado correctamente")

        Dim nombre As String = NameTextBox.Text
        Dim descripcion As String = DescriptionTextBox.Text
        Dim precio As UInteger = UInteger.Parse(PriceTextBox.Text).ToString()
        Dim newService As Service = New Service(nombre, descripcion, precio)
        controller.addService(newService)
    End Sub
End Class