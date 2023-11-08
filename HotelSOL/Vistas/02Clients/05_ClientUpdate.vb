Imports System.Data.SqlClient

Public Class Form5

    Private controller As Controller = New Controller
    Private connector As DataBaseConnection = New DataBaseConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenar_grid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        Label13.Text = DataGridView1.Item(0, i).Value()
        ClientIdTextBox.Text = DataGridView1.Item(0, i).Value()
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
        'connector.Connect()
        'Dim phone As Integer = Integer.Parse(PhoneTextBox.Text).ToString()
        'Dim credCard As Int64 = Int64.Parse(CredCardTextBox.Text).ToString()
        'Dim birth As Date = Date.Parse(BirthDatePicker.Text).ToString()
        'Dim consulta1 As String = "UPDATE Clientes set Nombre = '" & NameTextBox.Text & "', Apellidos = '" & SurnameTextBox.Text & "', FechaNac = '" & birth & "' , Telefono = '" & phone & "', Email = '" & MailTextBox.Text & "', Direccion = '" & AdressTextBox.Text & "', TarjetaCred = '" & credCard & "', Descuento = '" & DiscountTextBox.Text & "' where IDcliente = '" & Label13.Text & "'"
        'comando = New SqlCommand(consulta1, connector.sqlConnection)
        'Dim lector As SqlDataReader
        'lector = comando.ExecuteReader
        'connector.Disconnect()
        'MessageBox.Show("Cliente actualizado con éxito")
        'llenar_grid()

        Dim idClinte As String = ClientIdTextBox.Text
        Dim nombre As String = NameTextBox.Text
        Dim apellidos As String = SurnameTextBox.Text
        Dim fechaNac As Date = Date.Parse(BirthDatePicker.Text).ToString()
        Dim telefono As String = PhoneTextBox.Text
        Dim mail As String = MailTextBox.Text
        Dim direccion As String = AdressTextBox.Text
        Dim tarjCred As String = CredCardTextBox.Text
        Dim descuento As UInteger = UInteger.Parse(DiscountTextBox.Text).ToString()
        Dim reservAct As Boolean = False
        Dim newClient As Client = New Client(idClinte, nombre, apellidos, fechaNac, telefono, mail, direccion, tarjCred, descuento, reservAct)
        controller.updateClient(newClient)
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
End Class