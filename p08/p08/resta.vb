Public Class resta
    Protected Overrides Sub calcularResultado()
        MyBase.calcularResultado()
        'Variables
        Dim valor1 As Double
        Dim valor2 As Double
        Dim resultado As Double
        Try
            'calculando y enseñando el resultado por pantalla
            valor1 = CDbl(TextBox1.Text)
            valor2 = CDbl(TextBox2.Text)
            resultado = valor1 - valor2
            MsgBox("El resultado es de : " + CStr(resultado))
        Catch ex As Exception
            'Si no introduce un número, error
            MsgBox("Introduce números en el textbox")
        End Try
    End Sub

    Protected Overrides Sub cargarTitulo()
        MyBase.cargarTitulo()
        Label1.Text = "Resta"
        Label3.Text = "Número 1"
        Label4.Text = "Número 2"
    End Sub

    Protected Overrides Sub calcularOperacionesEjecutadas()
        MyBase.calcularOperacionesEjecutadas()
    End Sub
End Class
