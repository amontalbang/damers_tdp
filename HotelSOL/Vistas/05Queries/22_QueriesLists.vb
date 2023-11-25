Public Class Form22
    Dim data As DataTable

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ButtonReservation_Click(sender As Object, e As EventArgs) Handles ButtonReservation.Click
        MenuAdmin.openFormHijo(New Dialog1(data))
    End Sub

    Private Sub ButtonEntries_Click(sender As Object, e As EventArgs) Handles ButtonEntries.Click
        MenuAdmin.openFormHijo(New Dialog1(data))
    End Sub

    Private Sub ButtonDepartures_Click(sender As Object, e As EventArgs) Handles ButtonDepartures.Click
        MenuAdmin.openFormHijo(New Dialog1(data))
    End Sub

    Private Sub ButtonActiveReservation_Click(sender As Object, e As EventArgs) Handles ButtonActiveReservation.Click
        MenuAdmin.openFormHijo(New Dialog1(data))
    End Sub
End Class