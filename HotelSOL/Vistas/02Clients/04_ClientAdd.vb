''' <summary>
''' Vista de añadir cliente
''' </summary>
Public Class Form4

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ''' <summary>
    ''' Metodo que captura el boton para añadir un cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Try
            If controller.ClientExists(idCliente) Then
                MessageBox.Show("EL CLIENTE YA EXISTE EN LA BASE DE DATOS")
            Else
                controller.AddClient(newClient)
                MessageBox.Show("CLIENTE CREADO CORRECTAMENTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub
End Class