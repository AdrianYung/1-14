Public Class ej11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidadProductos As Integer
        Dim precioUnitario As Double = 9.99
        Dim subtotal As Double
        Dim iva As Double
        Dim total As Double
        Dim porcentajeIVA As Double = 12 / 100
        cantidadProductos = TextBox1.Text
        subtotal = cantidadProductos * precioUnitario
        iva = subtotal * porcentajeIVA
        total = subtotal + iva
        Label1.Text = "Total a pagar: Q" & total.ToString("F2")

    End Sub
End Class