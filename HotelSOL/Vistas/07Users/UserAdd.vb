﻿Public Class UserAdd

    Private controller As Controller = New Controller

    Private Sub UserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idUsuario As String = UserIdTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim newUser As User = New User(idUsuario, email, password)
        Try
            controller.addUser(newUser)
            MessageBox.Show("USUARIO CREADO CORRECTAMENTE")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class