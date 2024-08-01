Public Class ej2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numero As Double
        Dim cuadrado As Double
        numero = TextBox1.Text
        cuadrado = Math.Pow(numero, 2)
        Label1.Text = cuadrado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label1.Text = "Numero Elevado al Cuadrado"
    End Sub
End Class