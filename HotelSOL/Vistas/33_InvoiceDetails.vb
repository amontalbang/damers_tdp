Public Class _33_InvoiceDetails
    Private controller As Controller = New Controller
    Private reservationId As UInteger

    Public Sub New(ReservationId As UInteger)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.reservationId = ReservationId

    End Sub
    Private Sub _33_InvoiceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Llenar_Grid()
        Llenar_Labels()
    End Sub

    Private Sub Llenar_Labels()
        Try
            Dim reservation As Reservation = controller.GetReservationById(reservationId)
            TotalLabel.Text = controller.CheckOut(reservationId).ToString()
            RoomLabel.Text = reservation.RoomIdProp.ToString()
            ClientIDLabel.Text = reservation.ClientIdProp.ToString()
            ReservationIDLabel.Text = reservation.ReservationIdProp.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Llenar_Grid()
        Try
            DataGridView1.DataSource = controller.GetConsumedServices(reservationId)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class