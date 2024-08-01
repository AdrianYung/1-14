Public Class ej15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad As Integer
        Dim horasPorDia As Double
        Dim totalHorasDormidas As Double
        Dim diasPorAno As Integer = 365
        edad = TextBox1.Text
        horasPorDia = TextBox2.Text
        totalHorasDormidas = edad * diasPorAno * horasPorDia
        Label1.Text = "Total de horas dormidas: " & totalHorasDormidas.ToString("N0") & " horas"
    End Sub
End Class