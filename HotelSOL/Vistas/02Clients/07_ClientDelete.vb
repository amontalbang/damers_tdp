Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        conection = New SqlConnection("Data Source = MAQUEDA \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        conection.Open()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        Dim consulta As String = "select * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conection.Close()
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = "delete from clientes where IDcliente = '" & TextBox10.Text & "'"
        comando = New SqlCommand(query, conection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Close()
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        MessageBox.Show("Cliente eliminado con éxito")
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        TextBox10.Text = DataGridView1.Item(0, i).Value()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub
End Class