''' <summary>
''' Vista de eliminar cliente
''' </summary>
Public Class Form7

    Private controller As Controller = New Controller
    Dim i As Integer

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            DataGridView1.DataSource = controller.GetClientList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que captura el boton para borrar un cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = ClientIdTextBox.Text
        Dim newClient As Client = New Client(id)
        Try
            If controller.ClientExists(id) Then
                controller.DeleteClient(newClient)
                DataGridView1.DataSource = controller.GetClientList()
                MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL CLIENTE NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        Finally
            Me.Refresh()
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que muestra los datos del objeto seleccionado en el Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        ClientIdTextBox.Text = DataGridView1.Item(0, i).Value()
    End Sub

End Class