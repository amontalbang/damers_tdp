Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Form24
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlConnection As New System.Data.SqlClient.SqlConnection("Data Source = MAQUEDA \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim decim As Double = Double.Parse(TextBox7.Text).ToString() '"###,##"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Servicios (Nombre, Descripcion, Precio) VALUES ('" & TextBox1.Text & "', '" & TextBox8.Text & "', '" & decim & "')"
        cmd.Connection = sqlConnection
        sqlConnection.Open()
        cmd.ExecuteNonQuery()
        sqlConnection.Close()
        MessageBox.Show("Servicio registrado correctamente")
    End Sub

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form23.Show()
        Me.Close()

    End Sub
End Class