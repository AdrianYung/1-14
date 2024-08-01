Public Class ej1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado1, resultado2, resultado3, resultado4 As Double
        resultado1 = Math.Sqrt(TextBox1.Text)
        resultado2 = Math.Sqrt(TextBox2.Text)
        resultado3 = Math.Sqrt(TextBox3.Text)
        resultado4 = Math.Sqrt(TextBox4.Text)
        Label1.Text = resultado1.ToString("F2")
        Label2.Text = resultado2.ToString("F2")
        Label3.Text = resultado3.ToString("F2")
        Label4.Text = resultado4.ToString("F2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label1.Text = "Resultado Numero 1"
        Label2.Text = "Resultado Numero 2"
        Label3.Text = "Resultado Numero 3"
        Label4.Text = "Resultado Numero 4"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class