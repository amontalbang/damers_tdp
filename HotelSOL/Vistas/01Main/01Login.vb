Imports System.Data.SqlClient

Public Class LoginForm1

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        conection.Open()
        Dim query = "SELECT * FROM Usuarios where IDusuario='" & UsernameTextBox.Text & "'and Password ='" & PasswordTextBox.Text & "'"
        comando = New SqlCommand(query, conection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            MenuAdmin.Show()
            Form1.Hide()
            Me.Close()
        Else
            MessageBox.Show("El usuario no existe o los datos son incorrectos")
        End If
        conection.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        conection = New SqlConnection("Data Source = LAPTOP-QH1U0LAN\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
