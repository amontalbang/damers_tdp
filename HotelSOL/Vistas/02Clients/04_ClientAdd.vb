Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlConnection As New System.Data.SqlClient.SqlConnection("Data Source = MAQUEDA\SQLEXPRESS;Initial Catalog=HotelSOL;Integrated Security=True")
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim phone As Integer = Integer.Parse(TextBox5.Text).ToString()
        Dim credCard As Int64 = Int64.Parse(TextBox2.Text).ToString()
        Dim birth As Date = Date.Parse(DateTimePicker1.Text).ToString()
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Clientes (IDcliente, Nombre, Apellidos, FechaNac, Telefono, Email, Direccion, TarjetaCred, Descuento, ReservaActiva) VALUES ('" & TextBox1.Text & "', '" & TextBox8.Text & "', '" & TextBox7.Text & "', '" & birth & "', '" & phone & "', '" & TextBox4.Text & "', '" & TextBox3.Text & "', '" & credCard & "', '" & TextBox9.Text & "', '" & 0 & "')"
        cmd.Connection = sqlConnection
        sqlConnection.Open()
        cmd.ExecuteNonQuery()
        sqlConnection.Close()
        MessageBox.Show("Cliente registrado correctamente")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class