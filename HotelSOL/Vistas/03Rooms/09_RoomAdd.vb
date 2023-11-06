Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9
    Private connector As DataBaseConnection = New DataBaseConnection

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim Tipo As String = TypeTextBox.Text.ToString()
        Dim Capacidad As Integer = Integer.Parse(CapacityTextBox.Text).ToString()
        Dim PrecioL As Double = Double.Parse(PriceHTextBox.Text).ToString()
        Dim PrecioM As Double = Double.Parse(PriceMTextBox.Text).ToString()
        Dim PrecioH As Double = Double.Parse(PriceLTextBox.Text).ToString()
        Dim Animales As Boolean = AnimalsCheckBox.Text.ToString()
        Dim Cuna As Boolean = CradleCheckBox.Text.ToString()
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Habitaciones (Tipo, Capacidad, PrecioL, PrecioM, PrecioL, Animales, Cuna) VALUES ('" & Tipo & "', '" & Capacidad & "', '" & PrecioL & "', '" & PrecioM & "', '" & PrecioH & "', '" & Animales & "', '" & Cuna & "')"
        cmd.Connection = connector.Connect()
        cmd.ExecuteNonQuery()
        connector.Disconnect()
        MessageBox.Show("Habitación registrada correctamente")
    End Sub
End Class