Public Class UserDelete

    Private controller As Controller = New Controller
    Dim i As Integer
    Private Sub UserDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.getUserList()
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
        Dim newUser As User = New User(id)
        Try
            If controller.userExists(id) Then
                controller.deleteUser(newUser)
                DataGridView1.DataSource = controller.getUserList()
                MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL USUARIO ESPECIFICADO NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        Finally
            Me.Refresh()
        End Try
    End Sub
End Class