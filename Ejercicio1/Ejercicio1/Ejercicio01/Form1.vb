Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim resultado As String
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b And b > c Then GoTo mayor1 Else GoTo e1
mayor1:
        resultado = a & ", " & b & ", " & c
        TextBox4.Text = resultado
        GoTo salir
e1:
        If a > c And c > b Then GoTo mayor2 Else GoTo e2
mayor2:
        resultado = a & ", " & c & ", " & b
        TextBox4.Text = resultado
        GoTo salir
e2:
        If b > a And a > c Then GoTo mayor3 Else GoTo e3
mayor3:
        resultado = b & ", " & a & ", " & c
        TextBox4.Text = resultado
        GoTo salir
e3:
        If b > c And c > a Then GoTo mayor4 Else GoTo e4
mayor4:
        resultado = b & ", " & c & ", " & a
        TextBox4.Text = resultado
        GoTo salir
e4:
        If c > a And a > b Then GoTo mayor5 Else GoTo e5
mayor5:
        resultado = c & ", " & a & ", " & b
        TextBox4.Text = resultado
        GoTo salir
e5:
        resultado = c & ", " & b & ", " & a
        TextBox4.Text = resultado
        GoTo salir
salir:
    End Sub
End Class
