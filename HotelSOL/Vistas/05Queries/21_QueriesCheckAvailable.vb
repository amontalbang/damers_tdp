Public Class Form21
    Private Sub AddReservationButton_Click(sender As Object, e As EventArgs) Handles AddReservationButton.Click
        MenuAdmin.openFormHijo(New Form14())
        MenuAdmin.ocultarSubmenu()
    End Sub
End Class