Public Class UserUpdate

    Private controller As Controller = New Controller
    Dim i As Integer

    Private Sub UserUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            DataGridView1.DataSource = controller.getUserList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'al seleccionar una fila manda los datos a los texbox
        i = DataGridView1.CurrentRow.Index
        Label7.Text = DataGridView1.Item(0, i).Value()
        UserIdTextBox.Text = DataGridView1.Item(0, i).Value()
        EmailTextBox.Text = DataGridView1.Item(1, i).Value()
        PasswordTextBox.Text = DataGridView1.Item(2, i).Value()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idUsuario As UInteger = UInteger.Parse(UserIdTextBox.Text).ToString()
        Dim email As String = EmailTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim newUser As User = New User(idUsuario, email, password)
        Try
            If controller.userExists(idUsuario) Then
                controller.updateUser(newUser)
                DataGridView1.DataSource = controller.getUserList()
                DataGridView1.Refresh()
                MessageBox.Show("USARIO ACTUALIZADO CORRECTAMENTE")
            Else
                MessageBox.Show("EL USARIO INDICADO NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        End Try
    End Sub
End Class