Imports System.IO
Imports Microsoft.Scripting.Hosting

Public Class _32_Exports

    Private controller As Controller = New Controller
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand
    Private data As DataTable

    Private Sub _32_Exports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    ''' <summary>
    ''' Método que captura el clic en el botón de export
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Try
            If ListBox1.Items.Count > 0 Then
                Dim optionSelected As String = ListBox1.SelectedItem.ToString
                Dim filename As String = ""
                Select Case (optionSelected)
                    Case "Usuarios"
                        filename = "UsersToOdoo.py"
                        controller.datasetToXML("user")
                    Case "Servicios"
                        filename = "ServicesToOdoo.py"
                        controller.datasetToXML("service")
                    Case "Clientes"
                        filename = "ClientsToOdoo.py"
                        controller.datasetToXML("client")
                    Case "Habitaciones"
                        filename = "RoomsToOdoo.py"
                        controller.datasetToXML("room")
                    Case "Facturas"
                        filename = "InvoicesToOdoo.py"
                        controller.datasetToXML("invoice")
                    Case "Reservas"
                        filename = "ReservationsToOdoo.py"
                        controller.datasetToXML("reservation")
                End Select
                Me.ejecutarScriptPython(filename)
            ElseIf ListBox1.Items.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una opción")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Método para ejecutar el script de python
    ''' </summary>
    ''' <param name="filename"></param>
    Public Sub ejecutarScriptPython(filename As String)
        Dim ejecutable As String = "python.exe"
        Dim psi As New ProcessStartInfo(ejecutable)
        psi.Arguments = filename
        Process.Start(psi)
    End Sub

    ''' <summary>
    ''' Método que captura el clic en el botón del import
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Try
            If ListBox1.Items.Count > 0 Then
                Dim optionSelected As String = ListBox1.SelectedItem.ToString
                Dim filename As String = ""
                Select Case (optionSelected)
                    Case "Usuarios"
                        filename = "OdooToApp_Users.py"
                    Case "Servicios"
                        filename = "OdooToApp_Services.py"
                    Case "Clientes"
                        filename = "OdooToApp_Clients.py"
                    Case "Habitaciones"
                        filename = "OdooToApp_Rooms.py"
                    Case "Facturas"
                        filename = "OdooToApp_Invoices.py"
                    Case "Reservas"
                        filename = "OdooToApp_Reservations.py"
                End Select
                Me.ejecutarScriptPython(filename)
                data = controller.XMLToDataset(optionSelected)
                System.Threading.Thread.Sleep(3000)
                Show_Dialog()
            ElseIf ListBox1.Items.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una opción")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Método para mostrar el cuadro de diálogo con la información del import
    ''' </summary>
    Private Sub Show_Dialog()
        Dim formDialog As Form = New Dialog2(Me.data)
        formDialog.ShowDialog()
    End Sub
End Class