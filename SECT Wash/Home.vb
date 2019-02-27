Public Class Home
    Public Shared usuario, total As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        lblPrecio.Text = conexiones.getPrecio(cbPaquetes.Text)
    End Sub

    Private Sub cbPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaquetes.SelectedIndexChanged
        lblPrecio.Text = conexiones.getPrecio(cbPaquetes.Text)
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        total = lblPrecio.Text
        Cobrar.ShowDialog()

    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        If conexiones.getNivel(Home.usuario) = False Then
            MsgBox("El usuario no tiene permitida esta funcion :c")
        Else
            Administrador.Show()
            Me.Hide()
        End If
    End Sub
End Class