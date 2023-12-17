''' <summary>
''' Vista de modificar cliente
''' </summary>
Public Class Form5

    Private controller As Controller = New Controller
    Dim i As Integer

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.GetClientList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que muestra los datos del objeto seleccionado en el Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
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

    ''' <summary>
    ''' Metodo que captura el boton para mopdificar un cliente
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
        Dim descuento As UInteger = UInteger.Parse(DiscountTextBox.Text).ToString()
        Dim reservAct As Boolean = False
        Dim newClient As Client = New Client(idCliente, nombre, apellidos, fechaNac, telefono, mail, direccion, tarjCred, descuento, reservAct)
        Try
            If controller.ClientExists(idCliente) Then
                controller.UpdateClient(newClient)
                DataGridView1.DataSource = controller.GetClientList()
                DataGridView1.Refresh()
                MessageBox.Show("CLIENTE ACTUALIZADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL CLIENTE INDICADO NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al realizar la actualización de los datos. Vuelva a intentarlo más tarde")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class