Public Class ej7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim añoactual, añonacio, edad As Integer
        Dim segundosEnUnAño As Double = 365 * 24 * 60 * 60
        Dim edadEnSegundos As Double
        añoactual = 2024
        añonacio = TextBox1.Text
        edad = añoactual - añonacio
        edadEnSegundos = edad * segundosEnUnAño
        Label1.Text = edadEnSegundos.ToString() & " segundos"
    End Sub
End Class