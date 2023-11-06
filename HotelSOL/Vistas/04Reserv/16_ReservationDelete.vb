Imports System.Data.SqlClient

Public Class Form16

    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clientId As String = TextBox10.Text
        connector.Connect()
        Dim consulta As String = "SELECT * from Reservas where IDCliente = '" & clientId & "'"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = "DELETE from Reservas where IDreserva = '" & Label13.Text & "'"
        comando = New SqlCommand(query, connector.sqlConnection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Close()
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        MessageBox.Show("Reserva eliminada con éxito")
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "SELECT * from Reservas"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub
End Class