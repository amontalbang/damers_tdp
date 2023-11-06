Imports System.Data.SqlClient

Public Class Form24

    Private connector As DataBaseConnection = New DataBaseConnection

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim decim As Double = Double.Parse(PriceTextBox.Text).ToString()
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Servicios (Nombre, Descripcion, Precio) VALUES ('" & NameTextBox.Text & "', '" & DesciptionTextBox.Text & "', '" & decim & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Servicio registrado correctamente")
    End Sub
End Class