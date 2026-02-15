Public Class Form4
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim celsius As Integer = TextBox1.Text
        Dim kelvin As Integer = celsius + 273.15
        TextBox2.Text = kelvin
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim celsius As Decimal = TextBox1.Text
        Dim kelvin As Decimal = celsius + 273.15
        TextBox2.Text = kelvin
    End Sub
End Class