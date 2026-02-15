Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim celsius As Integer = TextBox1.Text
            Dim fahrenheit As Integer = celsius * 1.8 + 32
            TextBox2.Text = fahrenheit
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim celsius As Decimal = TextBox1.Text
        Dim fahrenheit As Decimal = celsius * 1.8 + 32
        TextBox2.Text = fahrenheit
    End Sub
End Class
