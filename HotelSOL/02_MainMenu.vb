Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Label3.Text = ""
        Dim TextBoxContents As String
        TextBoxContents = LoginForm1.UsernameTextBox.Text
        Label3.Text = TextBoxContents

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Form13.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form20.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Hide()
        Form8.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Form23.Show()

    End Sub
End Class