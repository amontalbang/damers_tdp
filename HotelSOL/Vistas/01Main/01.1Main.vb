''' <summary>
''' Vista de menu principal
''' </summary>
Public Class Form1

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ''' <summary>
    ''' Captura boton login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm1.Show()
        'Form30.Show()
    End Sub

    ''' <summary>
    ''' Captura boton salda de la app
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


