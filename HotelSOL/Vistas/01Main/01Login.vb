''' <summary>
''' Vista de ventana de Login
''' </summary>
Public Class LoginForm1

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ''' <summary>
    ''' Captura de boton confirmar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If controller.UserLogin(UsernameTextBox.Text, PasswordTextBox.Text) And UsernameTextBox.Text = "admin" Then
                MenuAdmin.Show()
                Form1.Hide()
                Me.Close()
            ElseIf controller.UserLogin(UsernameTextBox.Text, PasswordTextBox.Text) And UsernameTextBox.Text <> "admin" Then
                Form30.Show()
                Form1.Hide()
                Me.Close()
            Else
                MessageBox.Show("El usuario no existe o los datos son incorrectos")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Captura de boton cancelar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
