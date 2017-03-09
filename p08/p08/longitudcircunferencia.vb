Public Class longitudcircunferencia
    Protected Overrides Sub calcularResultado()
        MyBase.calcularResultado()
        Dim Radio As Double
        Dim Resultado As Double
        Try
            'Calculando el area
            Radio = CDbl(TextBox1.Text)
            Resultado = 2 * Math.PI * Radio
            MsgBox("La longitud de la circunferencia es de : " + CStr(Resultado))
        Catch ex As Exception
            'Si no introduce un valor númerico, error
            MsgBox("Introduce un número en el textbox")
        End Try
    End Sub

    Protected Overrides Sub cargarTitulo()
        MyBase.cargarTitulo()
        Label1.Text = "Longitud de la Circumferència"
        Label3.Text = "Radio"
        Label4.Visible = False
        TextBox2.Visible = False
    End Sub

    Protected Overrides Sub calcularOperacionesEjecutadas()
        MyBase.calcularOperacionesEjecutadas()
    End Sub
End Class
