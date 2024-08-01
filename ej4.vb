Public Class ej4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1, numero2, numero3, numero4 As Double
        Dim multiplicacion, suma12, resta, resultadoFinal As Double
        numero1 = TextBox1.Text
        numero2 = TextBox2.Text
        numero3 = TextBox3.Text
        numero4 = TextBox4.Text
        multiplicacion = numero1 * numero2
        suma12 = multiplicacion + 12
        resta = numero3 - numero4
        resultadoFinal = suma12 * resta
        Label3.Text = resultadoFinal.ToString()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class