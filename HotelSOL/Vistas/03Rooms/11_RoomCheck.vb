''' <summary>
''' Vista de comprobar habitacion
''' </summary>
Public Class Form11

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        DataGridView1.Hide()
    End Sub

    ''' <summary>
    ''' Metodo que captura un boton para comprobar una habitacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As String = NumHabTextBox.Text
        Try
            If controller.RoomExists(id) Then
                Dim dt As New DataTable
                Dim dr As DataRow
                Dim newRoom As Room = controller.GetRoomById(id)
                dt.Columns.Add(New DataColumn("IDhabitacion", GetType(String)))
                dt.Columns.Add(New DataColumn("Tipo", GetType(String)))
                dt.Columns.Add(New DataColumn("Capacidad", GetType(String)))
                dt.Columns.Add(New DataColumn("PrecioL", GetType(UInteger)))
                dt.Columns.Add(New DataColumn("PrecioM", GetType(UInteger)))
                dt.Columns.Add(New DataColumn("PrecioH", GetType(UInteger)))
                dr = dt.NewRow()
                dr("IDhabitacion") = newRoom.RoomIdProp
                dr("Tipo") = newRoom.TypeProp
                dr("Capacidad") = newRoom.CapacityProp
                dr("PrecioL") = newRoom.PriceLProp
                dr("PrecioM") = newRoom.PriceMProp
                dr("PrecioH") = newRoom.PriceHProp
                dt.Rows.Add(dr)
                DataGridView1.DataSource = dt
                DataGridView1.Show()
            Else
                MessageBox.Show("NO EXISTE NINGUNA HABITACIÓN CON ESE NÚMERO DE HABITACIÓN")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class