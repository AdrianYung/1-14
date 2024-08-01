Public Class ej8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iva, totalcompra, total, total2 As Double
        iva = 0.12
        totalcompra = TextBox1.Text
        total = totalcompra * iva
        total2 = total + totalcompra
        Label1.Text = "El total de la compra con iva es: " & total2.ToString()
    End Sub
End Class