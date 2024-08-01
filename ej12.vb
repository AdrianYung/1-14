Public Class ej12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diasTrabajados As Integer
        Dim valorPorDia As Double
        Dim sueldoSemanal As Double
        diasTrabajados = TextBox1.Text
        valorPorDia = TextBox2.Text
        sueldoSemanal = diasTrabajados * valorPorDia
        Label1.Text = "Sueldo semanal: Q" & sueldoSemanal.ToString("F2")
    End Sub
End Class