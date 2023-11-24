Public Class Form16

    Private controller As Controller = New Controller
    Dim i As Integer

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            DataGridView1.DataSource = controller.GetReservationsList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim reservId As UInteger = TextBox10.Text
    '    Try
    '        If controller.CheckReservationExists(reservId) Then
    '            Dim dr As DataRow
    '            Dim dt As New DataTable
    '            Dim reservation As Reservation = controller.GetReservationById(reservId)
    '            dt.Columns.Add(New DataColumn("IDreserva", GetType(UInteger)))
    '            dt.Columns.Add(New DataColumn("IDhabitacion", GetType(UInteger)))
    '            dt.Columns.Add(New DataColumn("IDCliente", GetType(String)))
    '            dt.Columns.Add(New DataColumn("FechaEntr", GetType(Date)))
    '            dt.Columns.Add(New DataColumn("FechaSal", GetType(Date)))
    '            dt.Columns.Add(New DataColumn("Temporada", GetType(String)))
    '            dt.Columns.Add(New DataColumn("Regimen", GetType(String)))
    '            dt.Columns.Add(New DataColumn("Estado", GetType(Boolean)))
    '            dr = dt.NewRow()
    '            dr("IDreserva") = reservation.ReservationIdProp
    '            dr("IDhabitacion") = reservation.RoomIdProp
    '            dr("IDCliente") = reservation.ClientIdProp
    '            dr("FechaEntr") = reservation.EntryDateProp
    '            dr("FechaSal") = reservation.DepartureDateProp
    '            dr("Temporada") = reservation.SeasonProp
    '            dr("Regimen") = reservation.BoardProp
    '            dr("Estado") = reservation.isActiveProp
    '            dt.Rows.Add(dr)
    '            DataGridView1.DataSource = dt
    '            DataGridView1.Show()
    '        Else
    '            MessageBox.Show("NO EXISTE NINGUNA RESERVA CON ESE ID")
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As UInteger = CUInt(ReservationIdTextBox.Text)
        Dim newReserv As Reservation = New Reservation(id)
        Try
            If controller.CheckReservationExists(id) Then
                controller.RemoveReservation(newReserv)
                DataGridView1.DataSource = controller.GetReservationsList()
                MessageBox.Show("RESERVA ELIMINADA CORRECTAMENTE")
            Else
                MessageBox.Show("LA RESERVA NO EXISTE")
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE HA PODIDO ESTABLECER CONEXIÓN CON LA BASE DE DATOS '" & vbCr & "''" & vbCr & "'ERROR: '" & ex.ToString & "'")
        Finally
            Me.Refresh()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        ReservationIdTextBox.Text = DataGridView1.Item(0, i).Value()
    End Sub

    Private Sub llenar_grid()
        Try
            Dim dt As DataTable = controller.GetReservationsList()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error en la conexión con base de datos")
        End Try
    End Sub
End Class