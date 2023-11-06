Imports System.Data.SqlClient

Public Class Form15

    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        Label13.Text = DataGridView1.Item(0, i).Value()
        RoomIdTextBox.Text = DataGridView1.Item(1, i).Value()
        ClientIdTextBox.Text = DataGridView1.Item(2, i).Value()
        EntryDatePicker.Text = DataGridView1.Item(3, i).Value()
        DepartureTimePicker.Text = DataGridView1.Item(4, i).Value()
        BoardTextBox.Text = DataGridView1.Item(6, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connector.Connect()
        Dim roomId As Integer = Integer.Parse(RoomIdTextBox.Text).ToString()
        Dim entry As Date = Date.Parse(EntryDatePicker.Text).ToString()
        Dim departure As Date = Date.Parse(DepartureTimePicker.Text).ToString()
        Dim consulta1 As String = "UPDATE Reservas set IDCliente = '" & ClientIdTextBox.Text & "', IDhabitacion = '" & RoomIdTextBox.Text & "', FechaEntr = '" & entry & "' , FechaSal = '" & departure & "', Board = '" & BoardTextBox.Text & "'"
        comando = New SqlCommand(consulta1, connector.sqlConnection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        connector.Disconnect()
        MessageBox.Show("Reserva actualizada con éxito")
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "select * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub
End Class