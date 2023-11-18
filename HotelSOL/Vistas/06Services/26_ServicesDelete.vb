Public Class Form26

    Private controller As Controller = New Controller
    Dim i As Integer

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.getServiceList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        TextBox10.Text = DataGridView1.Item(0, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox10.Text
        Dim newService As Service = New Service(id)
        Try
            If controller.serviceExists(id) Then
                controller.deleteService(newService)
                DataGridView1.DataSource = controller.getServiceList()
                MessageBox.Show("SERVICIO ELIMINADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL SERVICIO ESPECIFICADO NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        Finally
            Me.Refresh()
        End Try
    End Sub
End Class