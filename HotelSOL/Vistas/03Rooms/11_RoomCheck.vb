Imports System.Data.SqlClient

Public Class Form11

    Private connector As DatabaseConnection = New DatabaseConnection
    Private controller As Controller = New Controller

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'connector.Connect()
        'Dim consulta As String = "select * from Habitaciones where IDhabitacion = '" & ClientIdTextBox.Text & "'"
        'Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        'Dim dt As New DataTable
        'adaptador.Fill(dt)
        'DataGridView1.DataSource = dt
        'If dt.Rows.Count = 0 Then
        ' MessageBox.Show("No existe ninguna habitacion con ese número de habitacion")
        ' End If
        ' connector.Disconnect()

        Dim id As String = NumHabTextBox.Text
        Dim newRoom As Room = New Room(id)
        controller.checkRoom(newRoom)
    End Sub

End Class