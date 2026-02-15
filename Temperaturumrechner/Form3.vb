Public Class Form3
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fahrenheit As Integer = TextBox1.Text
        Dim celsius As Integer = (fahrenheit - 32) * 5 / 9
        TextBox2.Text = fahrenheit
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim fahrenheit As Decimal = TextBox1.Text
        Dim celsius As Decimal = (fahrenheit - 32) * 5 / 9
        TextBox2.Text = fahrenheit
    End Sub
End Class