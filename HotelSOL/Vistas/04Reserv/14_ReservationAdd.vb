''' <summary>
''' Vista de añadir reserva
''' </summary>
Public Class Form14

    Private controller As Controller = New Controller

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(Sender As Object, E As EventArgs) Handles Button1.Click
        Try
            Dim roomId As Integer = Integer.Parse(RoomIdTextBox.Text).ToString()
            Dim entry As Date = Date.Parse(EntryDatePicker.Text)
            Dim departure As Date = Date.Parse(DepartureDatePicker.Text)
            Dim clientId As String = ClientIdTextBox.ToString()
            Dim board As String = BoardTextBox.ToString()
            Dim reservation As Reservation = New Reservation(roomId, clientId, entry, departure, board, False)
            controller.AddReservation(reservation)
            MessageBox.Show("Reserva registrada correctamente")
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un problema y la reserva no ha podido darse de alta.")
        End Try
    End Sub
End Class