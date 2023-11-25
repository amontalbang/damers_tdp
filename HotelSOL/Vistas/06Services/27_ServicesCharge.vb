Public Class Form27

    Private controller As Controller = New Controller
    Private idServicio As Integer

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Llenar_grid()
        GetRooms()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roomId As UInteger = CUInt(RoomSelector.SelectedItem)
        Dim serviceId As String = ServiceTextBox.Text
        Dim units As Integer = CInt(UnitsTextBox.Text)
        controller.ChargeService(roomId, serviceId, units)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        idServicio = DataGridView1.Item(0, i).Value()
        ServiceTextBox.Text = DataGridView1.Item(1, i).Value()
    End Sub

    Private Sub Llenar_grid()
        Try
            Dim dt As DataTable = controller.GetServiceList()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GetRooms()
        Try
            RoomSelector.DataSource = controller.GetRoomIds()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class