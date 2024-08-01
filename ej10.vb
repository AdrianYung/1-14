Public Class ej10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pulgadas As Double
        Dim centimetros As Double
        Dim factorConversion As Double = 2.54
        pulgadas = TextBox1.Text
        centimetros = pulgadas * factorConversion
        Label1.Text = centimetros.ToString("F2") & " cm"
    End Sub
End Class