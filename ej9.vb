Public Class ej9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sueldoMensual As Double
        Dim igss As Double
        Dim porcentajeIGSS As Double = 4.83 / 100
        sueldoMensual = TextBox1.Text
        igss = sueldoMensual * porcentajeIGSS
        Label1.Text = "El total de IGSS es: Q" & igss.ToString("F2")
    End Sub
End Class