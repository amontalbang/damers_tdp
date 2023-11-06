Imports System.Data.SqlClient

Public Class Form5

    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        i = DataGridView1.CurrentRow.Index
        Label13.Text = DataGridView1.Item(0, i).Value()
        NameTextBox.Text = DataGridView1.Item(1, i).Value()
        SurnameTextBox.Text = DataGridView1.Item(2, i).Value()
        BirthDatePicker.Text = DataGridView1.Item(3, i).Value()
        PhoneTextBox.Text = DataGridView1.Item(4, i).Value()
        MailTextBox.Text = DataGridView1.Item(5, i).Value()
        AdressTextBox.Text = DataGridView1.Item(6, i).Value()
        CredCardTextBox.Text = DataGridView1.Item(7, i).Value()
        DiscountTextBox.Text = DataGridView1.Item(8, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connector.Connect()
        Dim phone As Integer = Integer.Parse(PhoneTextBox.Text).ToString()
        Dim credCard As Int64 = Int64.Parse(CredCardTextBox.Text).ToString()
        Dim birth As Date = Date.Parse(BirthDatePicker.Text).ToString()
        Dim consulta1 As String = "UPDATE Clientes set Nombre = '" & NameTextBox.Text & "', Apellidos = '" & SurnameTextBox.Text & "', FechaNac = '" & birth & "' , Telefono = '" & phone & "', Email = '" & MailTextBox.Text & "', Direccion = '" & AdressTextBox.Text & "', TarjetaCred = '" & credCard & "', Descuento = '" & DiscountTextBox.Text & "' where IDcliente = '" & Label13.Text & "'"
        comando = New SqlCommand(consulta1, connector.sqlConnection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        connector.Disconnect()
        MessageBox.Show("Cliente actualizado con éxito")
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