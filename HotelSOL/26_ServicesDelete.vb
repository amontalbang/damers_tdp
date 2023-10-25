Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form26

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conection = New SqlConnection("Data Source = MAQUEDA \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        conection.Open()
        llenar_grid()

    End Sub

    Private Sub llenar_grid()

        Dim consulta As String = "select * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As Int16 = DataGridView1.CurrentCell.Value
        Dim query = "delete from Servicios where IDservicio = '" & id & "'"
        comando = New SqlCommand(query, conection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Close()
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        MessageBox.Show("Registro eliminado con éxito")
        llenar_grid()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        conection.Close()
        Form23.Show()
        Me.Close()

    End Sub
End Class