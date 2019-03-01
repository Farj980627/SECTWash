Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            If conexiones.Login(txtUsuario.Text, txtPassword.Text) = True Then
                Home.Show()
                txtPassword.Clear()
                Me.Hide()
            Else
                MsgBox("Usuario o contraseña incorrectos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
