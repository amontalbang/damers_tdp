Public Class Form4
    Private connector As DatabaseConnection = New DatabaseConnection
    Private controller As Controller = New Controller

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cmd As New System.Data.SqlClient.SqlCommand
        'Dim phone As Integer = Integer.Parse(PhoneTextBox.Text).ToString()
        'Dim credCard As Int64 = Int64.Parse(CredCardTextBox.Text).ToString()
        'Dim birth As Date = Date.Parse(BirthDatePicker.Text).ToString()
        'cmd.CommandType = System.Data.CommandType.Text
        'cmd.CommandText = "INSERT Clientes (IDcliente, Nombre, Apellidos, FechaNac, Telefono, Email, Direccion, TarjetaCred, Descuento, ReservaActiva) VALUES ('" & ClientIdTextBox.Text & "', '" & NameTextBox.Text & "', '" & SurnameTextBox.Text & "', '" & birth & "', '" & phone & "', '" & MailTextBox.Text & "', '" & AdressTextBox.Text & "', '" & credCard & "', '" & DiscountTextBox.Text & "', '" & 0 & "')"
        'cmd.Connection = connector.Connect()
        'cmd.ExecuteNonQuery()
        'connector.Disconnect()
        'MessageBox.Show("Cliente registrado correctamente")

        Dim idCliente As String = ClientIdTextBox.Text
        Dim nombre As String = NameTextBox.Text
        Dim apellidos As String = SurnameTextBox.Text
        Dim fechaNac As Date = Date.Parse(BirthDatePicker.Text).ToString()
        Dim telefono As String = PhoneTextBox.Text
        Dim mail As String = MailTextBox.Text
        Dim direccion As String = AdressTextBox.Text
        Dim tarjCred As String = CredCardTextBox.Text
        Dim descuento As UInteger = DiscountTextBox.Text
        Dim newClient As Client = New Client(idCliente, nombre, apellidos, fechaNac, telefono, mail, direccion, tarjCred, descuento, 0)
        controller.addClient(newClient)
    End Sub

End Class