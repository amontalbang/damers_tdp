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

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Try
            If ListBox1.Items.Count > 0 Then
                Dim optionSelected As String = ListBox1.SelectedItem.ToString
                Dim filename As String = ""
                Select Case (optionSelected)
                    Case "Usuarios"
                        filename = "UsersToOdoo.py"
                        controller.datasetToXML("user")
                        Me.ejecutarScriptPython(filename)
                    Case "Servicios"
                        filename = "ServicesToOdoo.py"
                        controller.datasetToXML("service")
                        Me.ejecutarScriptPython(filename)
                    Case "Clientes"
                        filename = "ClientsToOdoo.py"
                        controller.datasetToXML("client")
                        Me.ejecutarScriptPython(filename)
                    Case "Habitaciones"
                        filename = "RoomsToOdoo.py"
                        controller.datasetToXML("room")
                        Me.ejecutarScriptPython(filename)
                    Case "Facturas"
                        filename = "InvoicesToOdoo.py"
                        controller.datasetToXML("invoice")
                        Me.ejecutarScriptPython(filename)
                    Case "Reservas"
                        filename = "ReservationsToOdoo.py"
                        controller.datasetToXML("reservation")
                        Me.ejecutarScriptPython(filename)
                End Select
            ElseIf ListBox1.Items.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una opción")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ejecutarScriptPython(filename As String)
        'Dim ejecutable As String = "C:\Users\monta\AppData\Local\Programs\Python\Python38-32\python.exe"
        Dim ejecutable As String = "C:\Users\Simon\AppData\Local\Programs\Python\Python36-32\python.exe"
        Dim psi As New ProcessStartInfo(ejecutable)
        psi.WorkingDirectory = IO.Path.GetDirectoryName("..\..\..\Odoo_Communication\")
        psi.FileName = filename
        Process.Start(psi)
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Try
            If ListBox1.Items.Count > 0 Then
                Dim optionSelected As String = ListBox1.SelectedItem.ToString
                Dim filename As String = ""
                Select Case (optionSelected)
                    Case "Usuarios"
                        filename = "OdooToApp_Users.py"
                        Me.ejecutarScriptPython(filename)
                        data = controller.XMLToDataset()
                    Case "Servicios"
                        filename = "OdooToApp_Services.py"
                        controller.datasetToXML("service")
                        Me.ejecutarScriptPython(filename)
                    Case "Clientes"
                        filename = "OdooToApp_Clients.py"
                        controller.datasetToXML("client")
                        Me.ejecutarScriptPython(filename)
                    Case "Habitaciones"
                        filename = "OdooToApp_Rooms.py"
                        controller.datasetToXML("room")
                        Me.ejecutarScriptPython(filename)
                    Case "Facturas"
                        filename = "OdooToApp_Invoices.py"
                        controller.datasetToXML("invoice")
                        Me.ejecutarScriptPython(filename)
                    Case "Reservas"
                        filename = "OdooToApp_Reservations.py"
                        controller.datasetToXML("reservation")
                        Me.ejecutarScriptPython(filename)
                End Select
                Show_Dialog()
            ElseIf ListBox1.Items.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una opción")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Show_Dialog()
        Dim formDialog As Form = New Dialog2(Me.data)
        formDialog.ShowDialog()
    End Sub



    'Private Sub executePython(pythonFile As String)
    '    Dim pyEngine As ScriptEngine = Python.CreateEngine()
    '    Dim pysource As ScriptSource = pyEngine.CreateScriptSourceFromFile(pythonFile)
    '    Debug.Print("lanzamos execute python")
    '    Try
    '        pysource.Execute()
    '        MessageBox.Show("La carga de datos en Odoo fue exitosa")
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
End Class