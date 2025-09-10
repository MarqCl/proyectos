Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cálculo de necesidades combustible"
        Label1.Text = "Por favor introduzca estos datos"
        Label2.Text = "Número de turismos"
        Label3.Text = "Número de todoterrenos"
        Label4.Text = "Capacidad de turismos (Litros)"
        Label5.Text = "Capacidad de todoterrenos (Litros)"
        Label6.Text = "Resultado:"
        Button1.Text = "Calcular"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Turismos, Todoterrenos As Integer
        Dim capturismos, Captodot As Single
        Dim Necesidadescom As Single

        If IsNumeric(TextBox1.Text) AndAlso IsNumeric(TextBox2.Text) AndAlso IsNumeric(TextBox3.Text) AndAlso IsNumeric(TextBox4.Text) Then
            Turismos = Val(TextBox1.Text)
            Todoterrenos = Val(TextBox2.Text)
            capturismos = Val(TextBox3.Text)
            Captodot = Val(TextBox4.Text)
            Necesidadescom = Turismos * capturismos + Todoterrenos * Captodot
            Label6.Text = "Las necesidades totales de combustible son de " & Necesidadescom & " litros"
        Else
            Label6.Text = "Por favor, ingrese valores numéricos válidos en todos los campos."
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
