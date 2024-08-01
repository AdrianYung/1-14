Public Class ej3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Double
        Dim cubo As Double
        numero = TextBox1.Text
        cubo = Math.Pow(numero, 3)
        Label1.Text = cubo.ToString()
    End Sub
End Class