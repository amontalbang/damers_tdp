Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form25

    Dim conection As New SqlConnection
    Dim comando As New SqlCommand
    Dim i As Integer

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        conection = New SqlConnection("Data Source = MAQUEDA \ SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        llenar_grid()
    End Sub

    Private Sub llenar_grid()
        conection.Open()
        Dim consulta As String = "select * from Servicios"
        Dim adaptador As New SqlDataAdapter(consulta, conection)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conection.Close()
        Form23.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        'al seleccionar una fila manda los datos a los texbox
        i = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(1, i).Value()
        TextBox3.Text = DataGridView1.Item(2, i).Value()
        TextBox4.Text = DataGridView1.Item(3, i).Value()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idServicio As Int16
        idServicio = DataGridView1.Item(0, i).Value()
        Dim decim As Decimal = Decimal.Parse(TextBox4.Text).ToString()
        Dim consulta1 As String = "update Servicios set Nombre = '" & TextBox2.Text & "', Descripcion = '" & TextBox3.Text & "', Precio = '" & decim & "' where IDservicio = '" & idServicio & "'"
        'Dim adaptador As New SqlDataAdapter(consulta1, conection)
        MessageBox.Show(decim)
        comando = New SqlCommand(consulta1, conection)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        conection.Close()
        MessageBox.Show("Registro actualizado con éxito")
        llenar_grid()
    End Sub
End Class