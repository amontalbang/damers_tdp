Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6

    Private connector As DataBaseConnection = New DataBaseConnection

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connector.Connect()
        Dim consulta As String = "select * from Clientes where IDcliente = '" & ClientIdTextBox.Text & "'"
        Dim adaptador As New SqlDataAdapter(consulta, connector.sqlConnection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No existe ningun cliente con ese ID")
        End If
        connector.Disconnect()
    End Sub

End Class