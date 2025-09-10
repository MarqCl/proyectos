Public Class Form1
    Dim Precio1, Precio2, Precio3, Media As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cálculo precio medio producto"
        Button1.Text = "Calcular precio medio"
        Label1.Text = "Introduzca aquí el precio en establecimiento n°1, en euros"
        Label2.Text = "Introduzca aquí el precio en establecimiento n°2, en euros"
        Label3.Text = "Introduzca aquí el precio en establecimiento n°3, en euros"
        Label4.Text = "Resultado:"
        Label4.Font = New Font("Arial", 10, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Precio1 = Val(TextBox1.Text)
        Precio2 = Val(TextBox2.Text)
        Precio3 = Val(TextBox3.Text)
        Media = (Precio1 + Precio2 + Precio3) / 3
        Label4.Text = "El precio medio del producto es de " & Media & " euros"
    End Sub
End Class



