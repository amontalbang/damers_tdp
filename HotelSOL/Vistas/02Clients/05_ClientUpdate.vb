Imports System.Data.SqlClient

Public Class Form5

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        conection = New SqlConnection("Data Source = MAQUEDA \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        conection.Open()
        Dim consulta As String = "select * from Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conection.Close()
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value()
        TextBox8.Text = DataGridView1.Item(1, i).Value()
        TextBox7.Text = DataGridView1.Item(2, i).Value()
        DateTimePicker1.Text = DataGridView1.Item(3, i).Value()
        TextBox5.Text = DataGridView1.Item(4, i).Value()
        TextBox4.Text = DataGridView1.Item(5, i).Value()
        TextBox3.Text = DataGridView1.Item(6, i).Value()
        TextBox2.Text = DataGridView1.Item(7, i).Value()
        TextBox9.Text = DataGridView1.Item(8, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phone As Integer = Integer.Parse(TextBox5.Text).ToString()
        Dim credCard As Int64 = Int64.Parse(TextBox2.Text).ToString()
        Dim birth As Date = Date.Parse(DateTimePicker1.Text).ToString()
        Dim consulta1 As String = "update Clientes set Nombre = '" & TextBox8.Text & "', Apellidos = '" & TextBox7.Text & "', FechaNac = '" & birth & "' , Telefono = '" & phone & "', Email = '" & TextBox4.Text & "', Direccion = '" & TextBox3.Text & "', TarjetaCred = '" & credCard & "', Descuento = '" & TextBox9.Text & "' where IDcliente = '" & TextBox1.Text & "'"
        comando = New SqlCommand(consulta1, conection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        conection.Close()
        MessageBox.Show("Cliente actualizado con éxito")
        llenar_grid()
    End Sub
End Class