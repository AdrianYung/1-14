Public Class ej5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim distancia As Double
        Dim tiempo As Double
        Dim velocidad As Double
        distancia = TextBox1.Text
        tiempo = TextBox2.Text
        velocidad = distancia / tiempo
        Label1.Text = velocidad.ToString() & " m/s"
    End Sub
End Class