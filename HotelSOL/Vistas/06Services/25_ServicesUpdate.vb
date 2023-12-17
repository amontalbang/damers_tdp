''' <summary>
''' Vista de modificar servicio
''' </summary>
Public Class Form25

    Private controller As Controller = New Controller
    Dim i As Integer

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.GetServiceList()
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
        Label7.Text = DataGridView1.Item(1, i).Value()
        ServiceIdTextBox.Text = DataGridView1.Item(0, i).Value()
        NameTextBox.Text = DataGridView1.Item(1, i).Value()
        DescriptionTextBox.Text = DataGridView1.Item(2, i).Value()
        PriceTextBox.Text = DataGridView1.Item(3, i).Value()
    End Sub

    ''' <summary>
    ''' Metodo que captura el boton para modificar un servicio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idServicio As String = ServiceIdTextBox.Text
        Dim nombre As String = NameTextBox.Text
        Dim descripcion As String = DescriptionTextBox.Text
        Dim precio As UInteger = UInteger.Parse(PriceTextBox.Text).ToString()
        Dim newService As Service = New Service(idServicio, nombre, descripcion, precio)
        Try
            If controller.ServiceExists(idServicio) Then
                controller.UpdateService(newService)
                DataGridView1.DataSource = controller.GetServiceList()
                DataGridView1.Refresh()
                MessageBox.Show("SERVICIO ACTUALIZADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL SERVICIO INDICADO NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub
End Class