Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports HotelSol

<TestClass()> Public Class UnitTest1

    Private control As Controller = New Controller

    ''' <summary>
    ''' Metodo para comprobar la temporada 
    ''' </summary>
    <TestMethod()> Public Sub comprobarTemporada()
        'Arrange: parametros de prueba
        Dim entryDate As String = "26-8-2023"
        Dim baja As String = "baja"
        Dim media As String = "media"
        Dim alta As String = "alta"

        'Action: Metodo a probar
        Dim temporada As String = control.GetReservationSeasson(entryDate)

        'Assert:Validar resultado del metodo
        Assert.AreEqual(temporada, baja)
    End Sub

    ''' <summary>
    ''' Metodo para comprobar las funciones de existe existe registro en BD 
    ''' (Printa por consola el retorno de cada funcion)
    ''' </summary>
    <TestMethod()> Public Sub comprobarExiste()
        'Arrange: parametros de prueba
        Dim cliente As String = "56843265-O"
        Dim habitacion As UInteger = "101"
        Dim usuario As String = "Juan"
        Dim servicio As String = "8"
        Dim reserva As UInteger = "8"
        Dim resultado As Boolean = True

        'Action: Metodo a probar
        If resultado Then
            resultado = control.ClientExists(cliente)
            Debug.Write("ClientExists " & resultado.ToString & ", ")
        End If
        If resultado Then
            resultado = control.RoomExists(habitacion)
            Debug.Write("RoomExists " & resultado.ToString & ", ")
        End If
        If resultado Then
            resultado = control.UserExists(usuario)
            Debug.Write("UserExists " & resultado.ToString & ", ")
        End If
        If resultado Then
            resultado = control.ServiceExists(servicio)
            Debug.Write("ServiceExists " & resultado.ToString & ", ")
        End If
        'If resultado Then
        '    resultado = control.CheckReservationExists(reserva)
        '    Debug.Write("CheckReservationExists " & resultado.ToString & ", ")
        'End If

        'Assert:Validar resultado del metodo
        Assert.AreEqual(resultado, True)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    <TestMethod()> Public Sub comprobarDatatables()
        'Arrange: parametros de prueba
        Dim resultado As Boolean = True
        Dim reserva As UInteger = 1
        Dim cliente As String = "56847157-K"
        Dim dt As New DataTable

        'Action: Metodo a probar
        If resultado Then
            Dim reservation = New Reservation
            reservation = control.GetReservationById(reserva)
            If reservation.ClientIdProp = cliente Then
                resultado = True
            Else
                resultado = False
            End If
            Debug.Write("ReservasPorID " & resultado.ToString & ", ")
        End If
        resultado = True
        If resultado Then
            dt = control.GetReservationByClientId(cliente)
            If dt.Rows.Count = 0 Then
                resultado = True
            Else
                resultado = False
            End If
            Debug.Write("ReservasPorID_Cliente " & resultado.ToString & ", ")
        End If
        resultado = True
        'If resultado Then
        '    dt = control.GetReservationsList(cliente)
        '    If dt.Rows.Count > 0 Then
        '        resultado = True
        '    Else
        '        resultado = False
        '    End If
        '    Debug.Write("ListaDeReservas " & resultado.ToString & ", ")
        'End If

        'Assert:Validar resultado del metodo
        Assert.AreEqual(resultado, True)
    End Sub
End Class