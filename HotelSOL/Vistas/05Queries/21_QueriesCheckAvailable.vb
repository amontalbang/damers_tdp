Public Class Form21
    Dim controller As New Controller
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    'Comentario
    Private Sub AddReservationButton_Click(sender As Object, e As EventArgs) Handles AddReservationButton.Click
        MenuAdmin.openFormHijo(New Form14())
        MenuAdmin.ocultarSubmenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim type As String = ComboBox2.SelectedItem().ToString()
            Dim capacity As UInteger = CUInt(TextBox2.Text)
            Dim entryDate As Date = CDate(DateTimePicker1.Value)
            Dim departureDate As Date = CDate(DateTimePicker2.Value)
            DataGridView1.DataSource = controller.CheckRoomAvailability(type, capacity, entryDate, departureDate)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class