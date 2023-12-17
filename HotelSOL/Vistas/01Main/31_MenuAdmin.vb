''' <summary>
''' Vista menu de administrador
''' </summary>
Public Class MenuAdmin

    ''' <summary>
    ''' Carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubmenu()
    End Sub

    ''' <summary>
    ''' Metodo para ocultar los submenus
    ''' </summary>
    Public Sub ocultarSubmenu()
        Try

        Catch ex As Exception

        End Try
        PanelSubmenuReserva.Visible = False
        PanelSubmenuCliente.Visible = False
        PanelSubmenuHabitaciones.Visible = False
        PanelSubmenuServicios.Visible = False
        PanelSubmenuConsultas.Visible = False
        PanelSubmenuUsuarios.Visible = False
    End Sub

    ''' <summary>
    ''' Metodo para mostrar los submenus
    ''' </summary>
    ''' <param name="submenu"></param>
    Private Sub mostrarSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    'Muestreo de los submenus al clicar sobre los botones del menu
    Private Sub ButtonReservas_Click(sender As Object, e As EventArgs) Handles ButtonReservas.Click
        mostrarSubmenu(PanelSubmenuReserva)
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        mostrarSubmenu(PanelSubmenuCliente)
    End Sub

    Private Sub ButtonHabitaciones_Click(sender As Object, e As EventArgs) Handles ButtonHabitaciones.Click
        mostrarSubmenu(PanelSubmenuHabitaciones)
    End Sub

    Private Sub ButtonServicios_Click(sender As Object, e As EventArgs) Handles ButtonServicios.Click
        mostrarSubmenu(PanelSubmenuServicios)
    End Sub

    Private Sub GestionUsuariosButton_Click(sender As Object, e As EventArgs) Handles GestionUsuariosButton.Click
        mostrarSubmenu(PanelSubmenuUsuarios)
    End Sub
    Private Sub ButtonConsultas_Click(sender As Object, e As EventArgs) Handles ButtonConsultas.Click
        mostrarSubmenu(PanelSubmenuConsultas)
    End Sub

    'Captura y redireccionado hacia cada una de las vistas del menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openFormHijo(New Form14())
        ocultarSubmenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openFormHijo(New Form15())
        ocultarSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openFormHijo(New Form16())
        ocultarSubmenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openFormHijo(New Form17())
        ocultarSubmenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openFormHijo(New Form18())
        ocultarSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        openFormHijo(New Form18())
        ocultarSubmenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        openFormHijo(New Form4())
        ocultarSubmenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        openFormHijo(New Form5())
        ocultarSubmenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        openFormHijo(New Form7())
        ocultarSubmenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        openFormHijo(New Form6())
        ocultarSubmenu()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        openFormHijo(New Form9())
        ocultarSubmenu()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        openFormHijo(New Form10())
        ocultarSubmenu()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        openFormHijo(New Form12())
        ocultarSubmenu()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        openFormHijo(New Form11())
        ocultarSubmenu()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        openFormHijo(New Form24())
        ocultarSubmenu()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        openFormHijo(New Form25())
        ocultarSubmenu()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        openFormHijo(New Form26())
        ocultarSubmenu()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        openFormHijo(New Form27())
        ocultarSubmenu()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        openFormHijo(New Form21())
        ocultarSubmenu()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        openFormHijo(New Form22())
        ocultarSubmenu()
    End Sub
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        openFormHijo(New UserAdd())
        ocultarSubmenu()
    End Sub

    Private Sub UpdateUserButton_Click(sender As Object, e As EventArgs) Handles UpdateUserButton.Click
        openFormHijo(New UserUpdate())
        ocultarSubmenu()
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        openFormHijo(New UserDelete())
        ocultarSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    ''' <summary>
    ''' Metodo para mostrarlas vistas de las secciones en un panel secundario
    ''' </summary>
    ''' <param name="childForm">objeto formulario</param>
    Public Sub openFormHijo(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelFormHijo.Controls.Add(childForm)
        PanelFormHijo.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    ''' <summary>
    ''' Metodo para Logout y regreso a menu principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OdooButton_Click_1(sender As Object, e As EventArgs) Handles OdooButton.Click
        openFormHijo(New _32_Exports())
        ocultarSubmenu()
    End Sub

    Private Sub PanelFormHijo_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormHijo.Paint

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class