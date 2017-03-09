Public Class Form1
    Dim contadorOperacion As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        cargarTitulo()
    End Sub

    Protected Overridable Sub cargarTitulo()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcularResultado()
    End Sub

    Protected Overridable Sub calcularResultado()
        contadorOperacion = contadorOperacion + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        calcularOperacionesEjecutadas()
    End Sub

    Protected Overridable Sub calcularOperacionesEjecutadas()
        Me.Close()
        MsgBox("El total de veces que has hecho esta operación es de: " + CStr(contadorOperacion))
    End Sub
End Class
