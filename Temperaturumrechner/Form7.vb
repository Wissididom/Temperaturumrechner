Public Class Form7
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim kelvin As Integer = TextBox1.Text
        Dim réaumur As Integer = (kelvin - 273.15) * 0.8
        TextBox2.Text = réaumur
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim kelvin As Decimal = TextBox1.Text
        Dim réaumur As Decimal = (kelvin - 273.15) * 0.8
        TextBox2.Text = réaumur
    End Sub
End Class