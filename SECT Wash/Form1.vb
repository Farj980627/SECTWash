Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If conexiones.Login(txtUsuario.Text, txtPassword.Text) = True Then
            Home.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos")
        End If
    End Sub
End Class
