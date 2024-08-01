Public Class ej13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim libras As Double
        Dim kilogramos As Double
        Dim factorConversion As Double = 1 / 2.2
        libras = TextBox1.Text
        kilogramos = libras * factorConversion
        Label1.Text = kilogramos.ToString("F2") & " kg"

    End Sub
End Class