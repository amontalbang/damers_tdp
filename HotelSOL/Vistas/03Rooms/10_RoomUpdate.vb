''' <summary>
''' Vista de modificar habitacion
''' </summary>
Public Class Form10

    Private controller As Controller = New Controller
    Dim i As Integer

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.GetRoomList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo de caprtura de un boton para modificar habitacion
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
                controller.UpdateRoom(newRoom)
                DataGridView1.DataSource = controller.GetRoomList()
                DataGridView1.Refresh()
                MessageBox.Show("HABITACIÓN ACTUALIZADA CORRECTAMENTE")
            Else
                MessageBox.Show("LA HABITACIÓN INDICADA NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que muestra los datos del objeto seleccionado en el Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        Label12.Text = DataGridView1.Item(0, i).Value()
        NumHabTextBox.Text = DataGridView1.Item(0, i).Value()
        TypeTextBox.Text = DataGridView1.Item(1, i).Value()
        CapacityTextBox.Text = DataGridView1.Item(2, i).Value()
        PriceHTextBox.Text = DataGridView1.Item(3, i).Value()
        PriceMTextBox.Text = DataGridView1.Item(4, i).Value()
        PriceLTextBox.Text = DataGridView1.Item(5, i).Value()
    End Sub
End Class