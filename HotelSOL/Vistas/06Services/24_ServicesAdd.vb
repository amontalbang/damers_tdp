''' <summary>
''' Vista de añadir servicio
''' </summary>
Public Class Form24

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ''' <summary>
    ''' Metodo que captura el boton para añadir un servicio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = NameTextBox.Text
        Dim descripcion As String = DescriptionTextBox.Text
        Dim precio As UInteger = UInteger.Parse(PriceTextBox.Text).ToString()
        Dim id As UInteger
        Dim newService As Service = New Service(nombre, descripcion, precio)
        Try
            controller.AddService(newService)
            MessageBox.Show("SERVICIO CREADO CORRECTAMENTE")
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub
End Class