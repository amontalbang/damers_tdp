Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form10

    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        connector.Connect()
        Dim consulta As String = "select * from Habitaciones"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        connector.Disconnect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connector.Connect()
        Dim Tipo As String = TypeTextBox.Text.ToString()
        Dim Capacidad As Integer = Integer.Parse(CapacityTextBox.Text).ToString()
        Dim PrecioL As Double = Double.Parse(PriceHTextBox.Text).ToString()
        Dim PrecioM As Double = Double.Parse(PriceMTextBox.Text).ToString()
        Dim PrecioH As Double = Double.Parse(PriceLTextBox.Text).ToString()
        Dim Animales As Boolean = AnimalsCheckBox.Text.ToString()
        Dim Cuna As Boolean = CradleCheckBox.Text.ToString()
        Dim consulta1 As String = "update Habitaciones set Tipo = '" & Tipo & "', Capacidad = '" & Capacidad & "', PrecioL = '" & PrecioL & "' , PrecioM = '" & PrecioM & "', PrecioH = '" & PrecioH & "', Animales = '" & Animales & "', Cuna = '" & Cuna & "'"
        comando = New SqlCommand(consulta1, connector.sqlConnection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        connector.Disconnect()
        MessageBox.Show("Habitación actualizada con éxito")
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        Label12.Text = DataGridView1.Item(0, i).Value()
        TypeTextBox.Text = DataGridView1.Item(1, i).Value()
        CapacityTextBox.Text = DataGridView1.Item(2, i).Value()
        PriceHTextBox.Text = DataGridView1.Item(3, i).Value()
        PriceMTextBox.Text = DataGridView1.Item(4, i).Value()
        PriceLTextBox.Text = DataGridView1.Item(5, i).Value()
        AnimalsCheckBox.Text = DataGridView1.Item(6, i).Value()
        CradleCheckBox.Text = DataGridView1.Item(7, i).Value()
    End Sub
End Class