<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ej2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(495, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Heavy", 14.25F, FontStyle.Italic)
        Label1.Location = New Point(282, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 24)
        Label1.TabIndex = 1
        Label1.Text = "Numero Elevado al Cuadrado"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(618, 119)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Heavy", 14.25F, FontStyle.Italic)
        Label2.Location = New Point(48, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(441, 24)
        Label2.TabIndex = 3
        Label2.Text = "Ingrese el numero que quiera elevar al cuadrado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Heavy", 14.25F, FontStyle.Italic)
        Label3.Location = New Point(331, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 24)
        Label3.TabIndex = 4
        Label3.Text = "Ejercicio 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Franklin Gothic Heavy", 14.25F, FontStyle.Italic)
        Label4.Location = New Point(223, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(325, 24)
        Label4.TabIndex = 5
        Label4.Text = "Calcular el cuadrado de un número."
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(296, 243)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 6
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(424, 243)
        Button3.Name = "Button3"
        Button3.Size = New Size(134, 23)
        Button3.TabIndex = 7
        Button3.Text = "Regresar al menu"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ej2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Fuchsia
        ClientSize = New Size(800, 309)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "ej2"
        Text = "ej2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
