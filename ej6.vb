Public Class ej6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim añoactual, añonacio, edad As Integer
        añoactual = 2024
        añonacio = TextBox1.Text
        edad = añoactual - añonacio
        Label1.Text = edad.ToString()
    End Sub
End Class