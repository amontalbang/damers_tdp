Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form26

    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        Dim consulta As String = "SELECT * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        TextBox10.Text = DataGridView1.Item(0, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = "DELETE from Servicios where IDservicio = '" & TextBox10.Text & "'"
        comando = New SqlCommand(query, connector.sqlConnection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Close()
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        MessageBox.Show("Servicio eliminado con éxito")
        llenar_grid()
    End Sub
End Class