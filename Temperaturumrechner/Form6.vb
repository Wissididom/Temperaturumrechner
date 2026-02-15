Public Class Form6
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim kelvin As Integer = TextBox1.Text
        Dim celsius As Integer = kelvin - 273.15
        TextBox2.Text = celsius
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim kelvin As Decimal = TextBox1.Text
        Dim rankine As Decimal = kelvin * 1.8
        TextBox2.Text = rankine
    End Sub
End Class