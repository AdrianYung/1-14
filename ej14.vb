Public Class ej14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio1, precio2, precio3, precio4, precio5, precio6 As Double
        Dim subtotal As Double
        Dim iva As Double
        Dim total As Double
        Dim porcentajeIVA As Double = 12 / 100
        precio1 = TextBox1.Text
        precio2 = TextBox2.Text
        precio3 = TextBox3.Text
        precio4 = TextBox4.Text
        precio5 = TextBox5.Text
        precio6 = TextBox6.Text
        subtotal = precio1 + precio2 + precio3 + precio4 + precio5 + precio6
        iva = subtotal * porcentajeIVA
        total = subtotal + iva
        Label1.Text = "Total de la factura: Q" & total.ToString("F2")
    End Sub
End Class