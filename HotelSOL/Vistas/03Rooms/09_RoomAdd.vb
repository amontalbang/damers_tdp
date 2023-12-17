''' <summary>
''' Vista de añadir habitacion
''' </summary>
Public Class Form9

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ''' <summary>
    ''' Metodo de captura un boton para añadir habitacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = NumHabTextBox.Text
        Dim tipo As String = TypeTextBox.Text
        Dim capacidad As String = CapacityTextBox.Text
        Dim precioL As UInteger = UInteger.Parse(PriceLTextBox.Text).ToString()
        Dim precioM As UInteger = UInteger.Parse(PriceMTextBox.Text).ToString()
        Dim precioH As UInteger = UInteger.Parse(PriceHTextBox.Text).ToString()
        Dim newRoom As Room = New Room(id, tipo, capacidad, precioL, precioM, precioH)
        Try
            If controller.RoomExists(id) Then
                MessageBox.Show("ESTA HABITACIÓN YA EXISTE EN LA BASE DE DATOS")
            Else
                controller.AddRoom(newRoom)
                MessageBox.Show("HABITACIÓN CREADA CORRECTAMENTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub
End Class