''' <summary>
''' Vista de comprobar cliente
''' </summary>
Public Class Form6

    Private controller As Controller = New Controller

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        DataGridView1.Hide()
    End Sub

    ''' <summary>
    ''' Metodo que captura un boton para recoger datos de un cliente y mostrar en el Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As String = ClientIdTextBox.Text
        Try
            If controller.ClientExists(id) Then
                Dim dr As DataRow
                Dim dt As New DataTable
                Dim client As Client = controller.GetClientById(id)
                dt.Columns.Add(New DataColumn("IDcliente", GetType(String)))
                dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
                dt.Columns.Add(New DataColumn("Apellidos", GetType(String)))
                dt.Columns.Add(New DataColumn("FechaNac", GetType(Date)))
                dt.Columns.Add(New DataColumn("Telefono", GetType(String)))
                dt.Columns.Add(New DataColumn("Email", GetType(String)))
                dt.Columns.Add(New DataColumn("Direccion", GetType(String)))
                dt.Columns.Add(New DataColumn("TarjetaCred", GetType(String)))
                dt.Columns.Add(New DataColumn("Descuento", GetType(UInteger)))
                dt.Columns.Add(New DataColumn("ReservaActiva", GetType(Boolean)))
                dr = dt.NewRow()
                dr("IDcliente") = client.NumberIdProp
                dr("Nombre") = client.NameProp
                dr("Apellidos") = client.SurnameProp
                dr("FechaNac") = client.BirthDateProp
                dr("Telefono") = client.PhoneNumberProp
                dr("Email") = client.EmailProp
                dr("Direccion") = client.AddressProp
                dr("TarjetaCred") = client.CreditCardProp
                dr("Descuento") = client.DiscountAvailableProp
                dr("ReservaActiva") = client.ActiveReservationProp
                dt.Rows.Add(dr)
                DataGridView1.DataSource = dt
                DataGridView1.Show()
            Else
                MessageBox.Show("NO EXISTE NINGÚN CLIENTE CON ESE ID")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class