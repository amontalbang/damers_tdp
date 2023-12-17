''' <summary>
''' Vista de eliminar habitacion
''' </summary>
Public Class Form12

    Private controller As Controller = New Controller
    Dim i As Integer

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.GetRoomList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que muestra los datos del objeto seleccionado en el Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        TextBox10.Text = DataGridView1.Item(0, i).Value()
    End Sub

    ''' <summary>
    ''' Metodo que captura un boton para eliminar una habitacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox10.Text
        Dim newRoom As Room = New Room(id)
        Try
            If controller.RoomExists(id) Then
                controller.DeleteRoom(newRoom)
                DataGridView1.DataSource = controller.GetRoomList()
                MessageBox.Show("HABITACIÓN ELIMINADA CORRECTAMENTE")
            Else
                MessageBox.Show("LA HABITACIÓN ESPECIFICADA NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        Finally
            Me.Refresh()
        End Try
    End Sub
End Class