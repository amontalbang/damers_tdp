Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports IronPython
Imports IronPython.Hosting
Imports Microsoft.Scripting.Hosting

Public Class _32_Exports

    Private controller As Controller = New Controller
    Private connector As DatabaseConnection
    Private command As System.Data.SqlClient.SqlCommand

    Private Sub _32_Exports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Try
            If ListBox1.Items.Count > 0 Then
                Dim optionSelected As String = ListBox1.SelectedItem.ToString
                Dim pythonFile As String = ""
                Select Case (optionSelected)
                    Case "Usuarios"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_UsersImport.py"
                        controller.datasetToXML("user")
                    Case "Servicios"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_ServicesImport.py"
                        controller.datasetToXML("service")
                    Case "Clientes"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_ClientsImport.py"
                        controller.datasetToXML("client")
                    Case "Habitaciones"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_RoomsImport.py"
                        controller.datasetToXML("client")
                    Case "Facturas"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_InvoicesImport.py"
                        controller.datasetToXML("client")
                    Case "Reservas"
                        pythonFile = "C:\Users\Simon\source\repos\HotelSOL\Odoo_Python\Odoo_ReservationsImport.py"
                        controller.datasetToXML("client")
                End Select
                executePython(pythonFile)
            ElseIf ListBox1.Items.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una opción")
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub executePython(pythonFile As String)
        Dim pyEngine As ScriptEngine = Python.CreateEngine()
        Dim pysource As ScriptSource = pyEngine.CreateScriptSourceFromFile(pythonFile)
        Debug.Print("lanzamos execute python")
        Try
            pysource.Execute()
            MessageBox.Show("La carga de datos en Odoo fue exitosa")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class