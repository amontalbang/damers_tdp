Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form14

    Private connector As DataBaseConnection = New DataBaseConnection

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim roomId As Integer = Integer.Parse(RoomIdTextBox.Text).ToString()
        Dim entry As Date = Date.Parse(EntryDatePicker.Text).ToString()
        Dim departure As Date = Date.Parse(DepartureDatePicker.Text).ToString()
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Clientes (IDhabitacion, IDCliente, FechaEntr, FechaSal, Temporada, Regimen, Estado) VALUES ('" & roomId & "', '" & ClientIdTextBox.Text & "', '" & entry & "', '" & departure & "', '" & "" & "', '" & BoardTextBox.Text & "', '" & 0 & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Reserva registrada correctamente")
    End Sub

End Class