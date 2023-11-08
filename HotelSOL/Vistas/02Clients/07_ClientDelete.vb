Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7

    Private controller As Controller = New Controller
    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "SELECT * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim query = "DELETE from clientes where IDcliente = '" & ClientIdTextBox.Text & "'"
        'comando = New SqlCommand(query, connector.sqlConnection)
        'Dim lector As SqlDataReader
        'lector = comando.ExecuteReader
        'lector.Close()
        'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        'MessageBox.Show("Cliente eliminado con éxito")
        'llenar_grid()

        Dim id As String = ClientIdTextBox.Text
        Dim newClient As Client = New Client(id)
        Controller.deleteClient(newClient)
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        ClientIdTextBox.Text = DataGridView1.Item(0, i).Value()
    End Sub

End Class